namespace AksanaChopchytsAutoQATasks.Core
{
    public abstract class Order: IComparable<Order>
    {
        private string _productName;
        public string ProductName
        {
            get
            {
                return _productName;
            }
            set
            {
                _productName = value;
            }
        } 
        private long _phoneNumber;
        public long PhoneNumber
        {
            get
            {
                return _phoneNumber;
            }
            set
            {
                if (value.ToString().Length == 13)
                    _phoneNumber = value;
            }
        }

        private float _cost;
        public float Cost
        {
            get
            {
                return _cost;
            }
            set
            {
                if (value > 0 && value <= 1000)
                    _cost = value;
            }
        }
        private string _deliveryAddress;
        public string DeliveryAddress
        {
            get
            {
                return _deliveryAddress;
            }
            set
            {
                _deliveryAddress = value;
            }
        }

        public Order(string productName, long phoneNumber, float cost, string deliveryAddress)
        {
            ProductName = productName;
            PhoneNumber = phoneNumber;
            Cost = cost;
            DeliveryAddress = deliveryAddress;
        }
        public abstract string GetFullInfo();
        public override string ToString()
        {
            return GetFullInfo();
        }
        public int CompareTo(Order other)
        {
            return PhoneNumber.CompareTo(other.PhoneNumber);
        }
    }
}
