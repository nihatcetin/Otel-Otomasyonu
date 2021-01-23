﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace OtelOtomasyonu.ORM.Entity
{
   public class Odalar
    {
        public Odalar()
        {
            Aktif = true;
        }
        public int Id { get; set; }
        public string Adi { get; set; }
        public string Aciklama { get; set; }
        public int OdaTurID { get; set; }
        public bool Aktif { get; set; }
    }
}
