using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agentie_turism
{
    [Serializable]
    public class Rezervare
    {
        private int id { get; set; }
        private DateTime checkIn { get; set; }
        private DateTime checkOut { get; set; }
        private Turist Turist { get; set; }
        private Hotel Hotel { get; set; }

        public Rezervare(int id, DateTime checkIn, DateTime checkOut, Turist turist, Hotel hotel)
        {
            this.id = id;
            this.checkIn = checkIn;
            this.checkOut = checkOut;
            this.Turist = turist;
            this.Hotel = hotel;
        }
        public Rezervare()
        {

        }

        
        public override string ToString()
        {
            return "#" + id;
        }
        public int CompareTo(Rezervare other)
        {
            return id.CompareTo(other.id);
        }
       

    }

}
