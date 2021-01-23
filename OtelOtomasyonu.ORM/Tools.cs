using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace OtelOtomasyonu.ORM
{
    public class Tools
    {
        //Singleton Patern:Tanımlamış olduğum elemanın property'sini get anında geriye fiel'ın degerini döndermeden önce null mu diye kontrol ederim.Null ise new'lerim değilse var olanı dönderirim.

        private static SqlConnection baglanti; // field

        public static SqlConnection Baglanti //property
        {
            get
            {
                if (baglanti == null)
                {
                    baglanti = new SqlConnection(ConfigurationManager.ConnectionStrings["Baglanti"].ConnectionString);
                }
                return baglanti;
            }
        }

        public static bool Exec(SqlCommand cmd)
        {
            try
            {
                if (cmd.Connection.State != ConnectionState.Open)
                {
                    cmd.Connection.Open();
                }

                int etk = cmd.ExecuteNonQuery();
                return etk > 0 ? true : false;
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                if (cmd.Connection.State != ConnectionState.Closed)
                {
                    cmd.Connection.Close();
                }
            }
        }

        public static object ExecuteScalar(SqlCommand cmd)
        {
            try
            {
                if (cmd.Connection.State != ConnectionState.Open)
                {
                    cmd.Connection.Open();
                }
                object deger = cmd.ExecuteScalar();
                return deger;

            }
            catch (Exception)
            {
                return 0;
            }
            finally
            {
                if (cmd.Connection.State != ConnectionState.Closed)
                {
                    cmd.Connection.Close();
                }
            }
        }

        public static void ParametreOlurtur<T>(SqlCommand cmd, KomutTip kt, T ent)
        {
            PropertyInfo[] propertys = typeof(T).GetProperties();

            foreach (PropertyInfo pi in propertys)
            {
                string name = pi.Name;
                if (name.ToLower() == "ıd" || name.ToLower() == "id" && kt == KomutTip.Insert)
                {
                    continue;
                }
                else if (kt == KomutTip.Delete && (name.ToLower() != "ıd" || name.ToLower() != "id"))
                {
                    continue;
                }

                object value = pi.GetValue(ent);
                cmd.Parameters.AddWithValue("@" + name, value);
            }

            
        }
    }
}
