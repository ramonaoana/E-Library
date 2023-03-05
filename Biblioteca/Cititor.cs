using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Cititor
    {
        private int idCititor;
        private string numeCititor;
        private string adresaCititor;
        private string mailCititor;
        private string cnp;

        public Cititor()
        {
            idCititor = 0;
            numeCititor = "";
            adresaCititor = "";
            mailCititor = "";
            cnp = "";
        }
        public Cititor(int _idCititor, string _nume, string _adresa, string _mail, string _cnp)
        {
            idCititor = _idCititor;
            numeCititor = _nume;
            adresaCititor = _adresa;
            mailCititor = _mail;
            cnp =_cnp;
        }
        public int IdCititor
        {
            get => idCititor;
            set
            {
                if (value > 0)
                    idCititor = value;
            }
        }
        public string NumeCititor
        {
            get => numeCititor;
            set
            {
                if (value.Length > 0)
                    numeCititor = value;
            }
        }
        public string AdresaCititor
        {
            get => adresaCititor;
            set
            {
                if (value.Length > 0)
                    adresaCititor = value;
            }
        }
        public string MailCititor
        {
            get => mailCititor;
            set
            {
                if (value.Length > 0)
                    mailCititor = value;
            }
        }
        public string Cnp
        {
            get => Cnp;
            set
            {
                if (value.Length > 0)
                    Cnp = value;
            }
        }
        public override string ToString()
        {
            return idCititor + "-" + numeCititor + "-" + adresaCititor + "-" + adresaCititor + "-" + mailCititor + "-" + cnp;
        }












    }
}
