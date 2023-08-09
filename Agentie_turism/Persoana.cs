using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agentie_turism
{
    [Serializable]
    public abstract class Persoana
    {
        public int Id { get; set; }
        private int cod { get; set; }
        private String denumire { get; set; }
        public float pret { get; set; }


        public Persoana(int cod)
        {
            this.cod = cod;
        }

        public Persoana(int cod, string denumire, float pret) : this(cod)
        {
            this.denumire = denumire;
            this.pret = pret;

        }
        public Persoana()
        {

        }
        public abstract String GetDetalii();
        public virtual String GetDenumire()
        {
            return "nedenumit";
        }
    }
}
