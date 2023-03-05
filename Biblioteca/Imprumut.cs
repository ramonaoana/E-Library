using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Imprumut
    {
        private int idImprumut;
        private Cititor cititor;
        private DateTime dataImprumut;
        private DateTime dataRestituire;
        public List<Carte> listaCarti;

        public Imprumut(int _idImprumut, Cititor _cititor, DateTime _dataImprumut, DateTime _dataRestituire,List<Carte> lista)
        {
            idImprumut = _idImprumut;
            cititor = _cititor;
            dataImprumut = _dataImprumut;
            dataRestituire = _dataRestituire;
            listaCarti = lista;
        }

        public int IdImprumut
        {
            get => idImprumut;
            set
            {
                if (value > 0)
                    idImprumut = value;
            }
        }
        public Cititor Cititor
        {
            get
            {
                return cititor;
            }
            set
            {
                cititor = value;
            }
        }
        public DateTime DataImprumut
        {
            get => dataImprumut;
            set => dataImprumut = value;
        }
        public DateTime DataRestituire
        {
            get => dataRestituire;
            set => dataRestituire = value;
        }
        public List<Carte> ListaCarti
        {
            get => listaCarti;
            set => listaCarti = value;
        }
      
        public override string ToString()
        {
           
            return idImprumut + "-" + cititor.ToString() + "-" + dataImprumut + "-"+dataRestituire;
        }


    }
}
