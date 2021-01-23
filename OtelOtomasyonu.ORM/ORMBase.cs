using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace OtelOtomasyonu.ORM
{
    public class ORMBase<T> : IORM<T> where T : class
    {

        private string ClassName
        {
            get
            {
                return typeof(T).Name;
                //typeof() :Tipi belli(generic olan) olmayan bir elemanın tipini belli etmeyi sağlar.
            }
        }
        public DataTable Select()
        {
            SqlDataAdapter adp = new SqlDataAdapter(string.Format("prc_{0}_Select", ClassName), Tools.Baglanti);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            adp.Fill(dt);
            return dt;
        }

        public bool Insert(T entity)
        {
            SqlCommand cmd = new SqlCommand(string.Format("prc_{0}_Insert", ClassName), Tools.Baglanti);
            cmd.CommandType = CommandType.StoredProcedure;

            //GetProperties: T elemanın eçerisindeki  propperty'ler bir dizi olarak dönderen metotdur.
            //PropertyInfo[] propertys = typeof(T).GetProperties();
            //foreach (PropertyInfo pi in propertys)
            //{
            //    //pi.name :property'nin adını verir.
            //    string name = pi.Name;
            //    if (name.ToLower() == "id" || name.ToLower() == "ıd")
            //    {
            //        continue;
            //    }

            //    object value = pi.GetValue(entity);
            //    cmd.Parameters.AddWithValue("@" + name, value);
            //}
            Tools.ParametreOlurtur<T>(cmd, KomutTip.Insert, entity);

            return Tools.Exec(cmd);

        }
        public object InsertScalar(T entity)
        {
            SqlCommand cmd = new SqlCommand(string.Format("prc_{0}_Insert", ClassName), Tools.Baglanti);
            cmd.CommandType = CommandType.StoredProcedure;

            Tools.ParametreOlurtur<T>(cmd, KomutTip.Insert, entity);

            return Tools.ExecuteScalar(cmd);
        }

        public bool Update(T entity)
        {
            SqlCommand cmd = new SqlCommand(string.Format("prc_{0}_Update", ClassName), Tools.Baglanti);
            cmd.CommandType = CommandType.StoredProcedure;

            Tools.ParametreOlurtur<T>(cmd, KomutTip.Update, entity);
            return Tools.Exec(cmd);
        }

        public bool Delete(T entity)
        {
            SqlCommand cmd = new SqlCommand(string.Format("prc_{0}_Delete", ClassName), Tools.Baglanti);
            cmd.CommandType = CommandType.StoredProcedure;

            Tools.ParametreOlurtur(cmd, KomutTip.Delete, entity);
            return Tools.Exec(cmd);

        }


       
    }
}
