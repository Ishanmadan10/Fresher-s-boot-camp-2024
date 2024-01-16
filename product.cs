using System;
using System.Text;

namespace ProductManagement
{
    internal class Product
    {
        private static int ProdCounter;
        public static int GetCounter()
        {
            return ProdCounter;
        }

        internal Product()
        {
            ProdCounter++;
        }

        private int m_ProdId;
        public int ProdId
        {
            get
            {
                return m_ProdId;
            }
            set
            {
                if (value > 0)
                {
                    m_ProdId = value;
                }
                else
                {
                    throw new Exception("Invalid");
                }
            }
        }

        private string m_Name;
        public string ProdName
        {
            get
            {
                return m_Name;
            }
            set
            {
                if (value.Length > 3)
                {
                    m_Name = value;
                }
                else
                {
                    throw new Exception("Invalid");
                }
            }
        }

        private DateTime m_MfgDate;
        public DateTime MfgDate
        {
            get
            {
                return m_MfgDate;
            }
            set
            {
                if (value<DateTime.Now)
                {
                    m_MfgDate = value;
                }
                else
                {
                    throw new Exception("Invalid");
                }

            }
        }

        private int m_Warranty;
        public int Warranty
        {
            get
            {
                return m_Warranty;
            }
            set
            {
                m_Warranty = value;
            }
        }

        private int m_Price;
        public int Price
        {
            get
            {
                return m_Price;
            }
            set
            {
                if (value > 0)
                {
                    m_Price = value;
                }
                else
                {
                    throw new Exception("Invalid");
                }
            }
        }


        private int m_Tax;
        public int Tax
        {
            get
            {
                return m_Tax;
            }
            set
            {
                if (value == 5 || value == 12 || value == 18 || value == 28)
                {
                    m_Tax = value;
                }
                else
                {
                    throw new Exception("Invalid");

                }
            }
        }
        private int m_Discount;
        public int Discount
        {
            get
            {
                return m_Discount;
            }
            set
            {
                if (1 < value && value < 30)
                {
                    m_Discount = value;
                }
                else
                {
                    throw new Exception("Invalid");
                }
            }
        }

        private int m_Stock;
        public int Stock
        {
            get
            {
                return m_Stock;
            }
            set
            {
                m_Stock = value;
            }
        }

         public string Display()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Product Id: " + ProdId);
            sb.AppendLine("Product Name: " + ProdName);
            sb.AppendLine("Manufacturing Date: " + MfgDate);
            sb.AppendLine("Warranty: " + Warranty);
            sb.AppendLine("Tax Price: " + (Price + Price * Tax / 100));
            sb.AppendLine("Discount Price: " + (Price + Price * Tax / 100) * Discount / 100);
            sb.AppendLine("Stock: " + Stock + "");

            return sb.ToString();
        }
    }
}
