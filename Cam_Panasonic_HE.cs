using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FTR_Devices
{
    class Cam_Panasonic_HE : Cam_ab
    {
        public Cam_Panasonic_HE() : base()
        // Constructor: Quick start (no params passed)
        {

            // Quick start (probably requires some data entry after instantiation)
        }
        public Cam_Panasonic_HE(string _name, string _ip, ComType _comtype) :
            base(_name, _ip, _comtype)
        // Constructor: basic - device_name, ip_address, com_type
        {
            device_name = _name;
            ip_address = _ip;
            com_type = _comtype;

        }
        public Cam_Panasonic_HE(string _name, string _fname, string _ip, int _port, ComType _comtype, string _login, string _pw) :
            base(_name, _fname, _ip, _port, _comtype, _login, _pw)
        // Constructor: TCP - device_name, friendly_name, ip_address, port, com_type , creds_login, creds_pw
        {
            device_name = _name;
            friendly_name = _fname;
            ip_address = _ip;
            port = _port;
            com_type = _comtype;
            creds_login = _login;
            creds_pw = _pw;

        }
        public Cam_Panasonic_HE(string _name, string _fname, string _ip, int _port, ComType _comtype, int _com_port, string _login, string _pw) :
            base( _name, _fname, _ip, _port, _comtype, _com_port, _login, _pw)
        // Constructor: ALL - device_name, friendly_name, short_name, ip_address, port, com_type, com_port, creds_login, creds_pw
        {
            device_name = _name;
            friendly_name = _fname;
            ip_address = _ip;
            port = _port;
            com_type = _comtype;
            com_port = _com_port;
            creds_login = _login;
            creds_pw = _pw;

        }


        public override void DPad(int i)
        {
            switch (i)
            {
                case 1:
                    // Up - do something
                    break;
                case 2:
                    // Down - do something
                    break;
                case 3:
                    // Left - do something
                    break;
                case 4:
                    // Right - do something
                    break;
                case 5:
                    // Enter - do something
                    break;
                default:
                    // Default behavior
                    break;
            }
        }

        public override void Zoom(int i)
        {
            switch (i)
            {
                case 0:
                    // Release - do something
                    break;
                case 1:
                    // Tight - do something
                    break;
                case 2:
                    // Wide - do something
                    break;
                default:
                    // Default behavior
                    break;
            }
        }

        public override void PresetStore(int i)
        {
            // Store preset i
        }

        public override void PresetRecall(int i)
        {
            // Recall preset i
        }


    }
}
