using System;

namespace Dori15_Encapsulation
{
    /// <summary>
    /// 변수
    /// </summary>
    partial class cData
    {
        private string _name;
        private int _iRate;
        private int _iCount;

        public string message = string.Empty;
        public string ProductName
        {
            get { return _name; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    message = "You have to select a product";
                }
                else
                {
                    _name = value;
                }
            }
        }

        public int iRate
        {
            get { return _iRate; }
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
                    _iRate = value;
                }
            }
        }
        public int iCount
        {
            get { return _iCount; }
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
                    _iCount = value;
                }
            }
        }

        public cData()
        {
            _name = string.Empty;
            _iRate = 0;
            _iCount = 0;
        }

    }

    partial class cData
    {
        public double GetItemPrice()
        {
            int price = 0;
            double discountPrice = 0;
            if (String.IsNullOrEmpty(message))
            {
                price = ((int)Enum.Parse(typeof(EnumProduct), ProductName));
                discountPrice = price - Math.Round((double)price * (double)_iRate / 100, 2);
            }

            return discountPrice * _iCount;
        }
    }

    partial class cData
    {
        public string fResult(double dPrice)
        {
            if(_iRate == 0)
            {
                return string.Format("[{0}] 수량: {1} 가격: {2}", _name, _iCount, dPrice);

            }
            else
            {
                return string.Format("[{0}] 수량: {1} 가격: {2} (할인율: {3}%)", _name, _iCount, dPrice, _iRate);
            }
        }
        
    }
}
