using System;

namespace Dori15_Encapsulation
{
    /// <summary>
    /// 변수
    /// </summary>
    partial class cData
    {
        public string message = string.Empty;
        public string ProductName
        {
            get
            {
                return ProductName;
            }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    message = "You have to select a product";
                }
                else
                {
                    ProductName = value;
                }
            }
        }

        public int iRate
        {
            get
            {
                return iRate;
            }
            set
            {
                if (value < 1)
                {
                    message = "Please check your count";
                }
                else if (value > 20)
                {
                    message = "You don't have access";
                }
                else
                {
                    iRate = value;
                }
            }
        }
        public int iCount
        {
            get { return iCount; }
            set
            {
                if (value < 1)
                {
                    message = "You have to check your count";
                }
                else if (value > 101)
                {
                    message = "Only can get less than 100";
                }
                else
                {
                    iCount = value;
                }
            }
        }

        public cData()
        {
            ProductName = string.Empty;
            iRate = 0;
            iCount = 0;
        }

    }

    partial class cData
    {
        public double GetItemPrice()
        {
            double price = 0;
            double rate = 0;
            if (String.IsNullOrEmpty(message))
            {

            }
        }
    }
}
