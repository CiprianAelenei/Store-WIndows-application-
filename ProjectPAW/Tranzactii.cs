using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPAW
{
    public class  Tranzactii
    {
        public DateTime dataTranzactie;
        public string ID_Tranzactie;
        private decimal soldTranzactie;
        private int codProdus;
        private int cantitate;
        private decimal pretProdus;
        private string numeProdus;
        private decimal pretTotalProdus;
        private decimal subTotal;


        public void autogen()
        {
            string num = "123456789";
            int len = num.Length;
            string otp = string.Empty;
            int otpdigit = 5;
            string finaldigit;

            int getiindex;

            for (int i = 0; i < otpdigit; i++)
            {
                do
                {
                    getiindex = new Random().Next(0, len);
                    finaldigit = num.ToCharArray()[getiindex].ToString();

                }
                while (otp.IndexOf(finaldigit) != -1);
                otp += finaldigit + Convert.ToInt32(DateTime.Now);
            }

            ID_Tranzactie = (otp);

        }

        public Tranzactii(string Id, decimal sold, int codprod, int cant, decimal pretP, string numeP, decimal pretTP, decimal subT)
        {
            dataTranzactie = DateTime.Now;
            autogen();
            soldTranzactie = sold;
            codProdus = codprod;
            cantitate = cant;
            pretProdus = pretP;
            numeProdus = numeP;
            pretTotalProdus = pretTP;
            subTotal = subT;
        }


    //    ToString
    }
}
