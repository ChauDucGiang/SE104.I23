﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLHS.DAO
{
    public class KhoiLopDAO
    {
        private static KhoiLopDAO instance;

        public static KhoiLopDAO Instance
        {
            get { if (instance == null) instance = new KhoiLopDAO(); return instance; }
            set => instance = value;
        }
        private KhoiLopDAO() { }

        public DataTable LoadKhoiLop()
        {
            string query = "SELECT * FROM dbo.KhoiLop";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }
    }
}
