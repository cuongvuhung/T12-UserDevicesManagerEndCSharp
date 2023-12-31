﻿using System.Data.SqlClient;

namespace T12
{
    internal class DeviceServices
    {
        private List<Device> devices = new ();
        ///////////////////////////////////////////////////////////////////////////////////////////////////
        // Get database data
        public void GetData()
        {
            DAL dla = new ();
            string str = "Select,DEVICES";
            List<string> rows = dla.SQLQuery(str);
            devices.Clear ();

            foreach (string row in rows)
            {
                Device item = new()
                {
                    Id = Convert.ToInt32(row.Split(",")[0]),
                    Name = (string)row.Split(",")[1],
                    Quantity = Convert.ToInt32(row.Split(",")[2])
                };
                devices.Add(item);
            }
        }
        public int AddNew(Device device)
        {
            string str = "Insert,DEVICES,";
            str += device.Name + ',';
            str += device.Quantity;
            DAL dla = new ();
            return dla.SQLExecute(str);
        }
        public int Update(Device device)
        {
            string str = "Update,DEVICES,";
            str += device.Id + ",";
            if (device.Name != "") { str += "name," + device.Name + ','; }
            if (device.Quantity != 0) { str += "quantity," + device.Quantity; }
            DAL dla = new ();
            return dla.SQLExecute(str);
        }
        public int Delete(Device device)
        {
            string str = "Delete,DEVICES,";
            str += device.Id + ",";
            if (device.Name != "") { str += "username," + device.Name + ','; }
            if (device.Quantity != 0) { str += "quantity," + device.Quantity; }
            DAL dla = new ();
            return dla.SQLExecute(str);
        }        
        public List<Device> SearchDeviceList(string name)
        {
            string str = "Select,DEVICES,Username," + name;
            DAL dla = new ();
            List<Device> result = new ();
            List<string> rows = dla.SQLQuery(str);
            foreach (string row in rows)
            {
                Device item = new()
                {
                    Id = Convert.ToInt32(row.Split(",")[0]),
                    Name = (string)row.Split(",")[1],
                    Quantity = Convert.ToInt32(row.Split(",")[2])
                };
                result.Add(item);
            }
            return result;
        }
        public List<Device> SortedDeviceList()
        {
            return devices.OrderByDescending(x => x.Id).ToList();
        }
    }
}
