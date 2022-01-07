using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FTR_Devices
{
    class GenericDevice_ab
    {
        public int joins_used = 100;          // be kind, use round numbers 
        public int device_index = 1;               // overwritten by Device_Manager
        public int join_offset = 0;

        public string device_name = "Room01_GenericDevice01";     // internal only, for reference
        public string friendly_name = "Generic 01";  // the device name to appear on touch panels
        public string short_name = "DEV01";         // this is usually the device ID found on drawings
        public string ip_address = "0.0.0.0";
        public int port = 23;
        public ComType com_type = ComType.TCP;
        public int com_port = 1;
        public string creds_login = "admin";
        public string creds_pw = "password";
    }
    enum ComType : int
    {
        TCP = 0,
        SSH = 1,
        RS232 = 2,
        RS422 = 3,
        RS485 = 4,
    }
}
