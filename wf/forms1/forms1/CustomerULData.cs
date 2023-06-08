namespace forms1
{
    internal class CustomersData
    {
        public class CustomerULData
        {
            public string Company { get; set; }
            public string Address { get; set; }
            public string Inn { get; set; }
            public string Rs { get; set; }
            public string Bik { get; set; }
            public string NameLead { get; set; }
            public string NameContact { get; set; }
            public string PhoneContact { get; set; }
            public string Email { get; set; }
        }

        public class CustomerFLData
        {
            public string Email { get; set; }
            public string Name { get; set; }
            public string Birthday { get; set; }
            public string PasportSeries { get; set; }
            public string PasportNumber { get; set; }
            public string Phone { get; set; }
        }
    }
}
