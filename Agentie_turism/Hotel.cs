using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agentie_turism
{
    [Serializable]
    public class Hotel: IComparable<Hotel>
    {
        private int id { get; set; }
        private string denumire { get; set; }
        private string cameraType { get; set; }
        private double pricePerNight { get; set; }

        public Hotel(int id,string denumire, string cameraType, double pricePerNight)
        {
            this.denumire = denumire;
            this.cameraType = cameraType;
            this.pricePerNight = pricePerNight;
        }

        public Hotel()
        {

        }

        public override string ToString()
        {
            if (this.id == -1)
            {
                return "null";
            }
            else
            {
                return id + " - " + denumire;
            }
        }
        public int CompareTo(Hotel other)
        {
            return this.id.CompareTo(other.id);
        }

        


    }

}
