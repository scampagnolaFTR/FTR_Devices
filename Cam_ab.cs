using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Crestron.SimplSharpPro;
using FTR_Utils;

namespace FTR_Devices
{
    abstract class Cam_ab : GenericDevice_ab
    {
        public Dictionary<int, Action<int>> input_hooks_bool = new Dictionary<int, Action<int>>();
        public Dictionary<int, Action<int>> input_hooks_ushort = new Dictionary<int, Action<int>>();
        public Dictionary<int, Action<int>> input_hooks_string = new Dictionary<int, Action<int>>();

        public Dictionary<string, PanelSigInfo> output_hooks;

        public Cam_ab()
        // Constructor: Quick start (no params passed)
        {
            // Quick start (probably requires some data entry after instantiation)
            InitJoinLists();
        }
        public Cam_ab(string _name, string _ip, ComType _comtype)
        // Constructor: basic - device_name, ip_address, com_type
        {
            device_name = _name;
            ip_address = _ip;
            com_type = _comtype;

            InitJoinLists();
        }
        public Cam_ab(string _name, string _fname, string _ip, int _port, ComType _comtype, string _login, string _pw)
        // Constructor: TCP - device_name, friendly_name, ip_address, port, com_type , creds_login, creds_pw
        {
            device_name = _name;
            friendly_name = _fname;
            ip_address = _ip;
            port = _port;
            com_type = _comtype;
            creds_login = _login;
            creds_pw = _pw;

            InitJoinLists();
        }        
        public Cam_ab(string _name, string _fname, string _ip, int _port, ComType _comtype, int _com_port, string _login, string _pw)
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

            InitJoinLists();
        }


        public abstract void DPad(int i);

        public abstract void Zoom(int i);

        public abstract void PresetStore(int i);

        public abstract void PresetRecall(int i);



        public void InitJoinLists()
        {
            AddHookBool(1, 5, DPad);
            AddHookBool(10, 11, Zoom);
            AddHookBool(51, 70, PresetStore);
            AddHookBool(71, 90, PresetRecall);
        }
        public void AddHookBool(int low, int high, Action<int> a)
        {
            for (var i = low; i <= high; i++)
                input_hooks_bool.Add(i, a);
        }

    }
}
