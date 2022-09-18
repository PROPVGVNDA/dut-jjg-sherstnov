using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11
{
    internal class Car
    {
        private bool camberAngle = false;
        private bool painted = false;
        private bool machineOilChanged = false ;
        private bool carInspection = false;
        private bool tiresChanged = false;
        private bool repairedBody = false;

        public bool CamberAngle { get => camberAngle; set => camberAngle = value; }
        public bool Painted { get => painted; set => painted = value; }
        public bool MachineOilChanged { get => machineOilChanged; set => machineOilChanged = value; }
        public bool CarInspection { get => carInspection; set => carInspection = value; }
        public bool TiresChanged { get => tiresChanged; set => tiresChanged = value; }
        public bool RepairedBody { get => repairedBody; set => repairedBody = value; }
    }
}
