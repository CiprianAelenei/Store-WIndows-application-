using System;
using System.Data.Common;

namespace ProjectPAW
{
    public class Product : ICloneable, IComparable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        
        private decimal price;
        private int stoc;

        public Product(int produs_ID, string numeProdus, decimal pret, int stc)
        {
            Id = produs_ID;
            Name = numeProdus;
            price = pret;
            stoc = stc;
          
        }

        public decimal Price
        {
            get
            {
                return price;
            }
            set
            {
                if (value >= 0)
                    price = value;
                else
                {
                    throw new Exception("Baga si tu o valoare pozitiva!");
                }
            }


        }

        public int Stoc
        {
            get
            {
                return stoc;
            }
            set
            {
                if (value >= 0)
                    stoc = value;
                else
                {
                    throw new Exception("Baga si tu o valoare pozitiva!");
                }
            }


        }

        public object Clone()
        {
            Product p = (Product)MemberwiseClone();
            //string[] produseNoi = (string[])produseAnterioare.Clone();
            //p.produseAnterioare = produseNoi;
            return p;
        }

        public int CompareTo(object obj)
        {
            Product p = (Product)obj;
            if (price < p.price)
                return -1;
            else
                if (price > p.price)
                return 1;
            else
                return 0;
        }

        public static bool operator ==(Product a, Product b)
        {
            if (a.price == b.price && a.Name.Equals(b.Name) && a.Id == b.Id)
                return true;
            else
                return false;
        }

        public static bool operator !=(Product a, Product b)
        {
            if (a.price != b.price || !a.Name.Equals(b.Name) || a.Id != b.Id)
                return true;
            else
                return false;
        }

        public override string ToString()
        {
            return $"Produs_ID: {Id} Nume: {Name} Pret: {price} lei {stoc} bucati";
        }
    }
}
