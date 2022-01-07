using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FTR_Devices
{
    public class FTR_Devices
    {
        Dictionary<int, Cam_ab> cam = new Dictionary<int, Cam_ab>();
        public FTR_Devices()
        {
            cam.Add(cam.Count + 1, new Cam_Panasonic_HE());
        }

    }
}
