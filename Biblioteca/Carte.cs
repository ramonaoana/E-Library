using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public enum tipCarte { Beletristica, Copii, Istorie, Business, Stiinte, Arta, Limbi_straine,Literatura }
    public class Carte
    {
        private int idCarte;
        private string numeCarte;
        private string autor;
        private string editura;
        private float pret;
        private double nrPagini;
        private string tip;

        public Carte()
        {
            idCarte = 0;
            editura = "";
            numeCarte = "-";
            autor = "-";
            pret = 0;
            nrPagini = 0;
            tip = "";
        }
        public Carte(int _id,string _editura, string _nume, string _autor, float _pret, double _nrPag, string _tip)
        {
            idCarte = _id;
            editura = _editura;
            numeCarte = _nume;
            autor = _autor;
            pret = _pret;
            nrPagini = _nrPag;
            tip = _tip;
        }
        
        public int IdCarte
        {
            get { return idCarte; }
            set
            {
                if (value > 0)
                    idCarte = value;
            }
        }
        public string Editura
        {
            get { return editura; }
            set
            {
                if(value.Length>2)
                    editura = value;
            }
        }

        public string NumeCarte
        {
            get { return numeCarte; }
            set
            {
                if (value.Length>0)
                    numeCarte = value;
            }
        }
        public string Autor
        {
            get { return autor; }
            set
            {
                if (value.Length > 0)
                    autor = value;
            }
        }


        public float Pret
        {
            get { return pret; }
            set
            {
                if (value > 0)
                    pret = value;
            }
        }

        public double NrPagini
        {
            get { return nrPagini; }
            set
            {
                if ( value> 0)
                    nrPagini = value;
            }
        }
        public string Tip
        {
            get { return tip; }
            set
            {
                if(value.Length>2)
                {
                    tip = value;
                }
            }
        }
        public override string ToString()
        {

            return "Cartea cu id-ul " + idCarte + " de la editura  " +editura + " se numeste " + numeCarte + ", este scrisa de " + autor + ", a costat " +
                pret + ", are " + nrPagini + " si se incadreaza la categoria: " + tip;
        }
       

    }
}
