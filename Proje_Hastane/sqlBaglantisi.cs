﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Proje_Hastane
{
    internal class sqlBaglantisi
    {
        //Sürekli sql bağlantısı açmamak için ayrı bir class içerisinde sql metodu oluşturuldu.
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection("Data Source=Oguzhan\\SQLEXPRESS;Initial Catalog=HastaneProje;Integrated Security=True");
            baglan.Open();
            return baglan;
        }
    }
}
