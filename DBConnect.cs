﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T12
{
    internal class DBConnect
    {
        private Config config = new Config();
        public SqlConnection Cnn;
        public DBConnect()
        {
            Cnn = new SqlConnection(config.conStr);
            Cnn.Open();
        }        
    }
}