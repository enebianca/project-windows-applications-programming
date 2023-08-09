using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agentie_turism
{
    [Serializable]
    public class Turist :Persoana, ICloneable
    {
        public List<string> tip_Tranzactie { get; set; }
        private int id { get; set; }
        public string nume { get; set; }
        public string prenume { get; set; }
        public string telefon { get; set; }
        private string email { get; set; }
        public float valoare { get; set; }
        public Tranzactie tranzactie { get; set; }

        public Turist(List<string> tip_Tranzactie,int id, string nume, string prenume, string telefon, string email,float valoare)
        {
            this.tip_Tranzactie = tip_Tranzactie;
            this.id = id;
            this.nume = nume;
            this.prenume = prenume;
            this.telefon = telefon;
            this.email = email;
            this.valoare = valoare;
           
        }

        public Turist(List<string> tip_Tranzactie, string nume, string prenume, string telefon, float valoare)
        {
            this.tip_Tranzactie = tip_Tranzactie;
            this.nume = nume;
            this.prenume = prenume;
            this.telefon = telefon;
            this.valoare = valoare;
        }

        public Turist()
        {
        }

        public override string ToString()
        {
            return id + " - " + nume + " " + prenume;
        }
        public int CompareTo(Turist other)
        {
            return id.CompareTo(other.id);
        }

        public override string GetDetalii()
        {
            return $"{ this.nume} are telefonul {this.telefon}";
        }

        public object Clone()
        {
            Turist clona = new Turist
            {
                nume = this.nume,
                prenume = this.prenume,
                telefon = this.telefon,
                email = this.email,
                tip_Tranzactie = new List<string>()

            };
            foreach (String tip in this.tip_Tranzactie)
            {
                clona.tip_Tranzactie.Add(tip);
            }
            return clona;
        }
    }
}
