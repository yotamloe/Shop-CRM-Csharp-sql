using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class Customer
    {
        private string customerName;
        private int cutomerID;
        private string email;
        private string gender;
        private DateTime dob;
        private Genere favoriteGenere;
        private bool hasLendingTab;
        private DateTime lendingEndDate;
        private string address_city;
        private string address_street;
        private int address_number;
        private string phone;
        private  List<Sale> Sales;
        private  List<Lending> Lendings;
        private  List<Returning> Returnings;


        public Customer(string name, int ID, string email, string gender, DateTime DOB, Genere genere, bool hasLendingTab, DateTime date, string city, string street, int number, string phone, bool is_new)
        {
            this.customerName = name;
            this.cutomerID = ID;
            this.email = email;
            this.gender = gender;
            this.dob = DOB;
            this.favoriteGenere = genere;
            this.hasLendingTab = hasLendingTab;
            this.lendingEndDate = date;
            this.address_city = city;
            this.Sales = new List<Sale>();
            this.Lendings = new List<Lending>();
            this.Returnings = new List<Returning>();
            this.address_street = street;
            this.address_number = number;
            this.phone = phone;


        }

        public string getCustomerName()
        {
            return this.customerName;
        }
        public override string ToString()
        {
            return this.customerName;
        }
        public List<Sale> getSales()
        {
            return this.Sales;
        }
        public List<Lending> getLendings()
        {
            return this.Lendings;
        }

        public int getCustomerID()
        {
            return this.cutomerID;
        }

        public string getEmail()
        {
            return this.email;
        }
        public string getGender()
        {
            return this.gender;
        }
        public DateTime getDOB()
        {
            return this.dob;
        }
        public Genere getFavoriteGenere()
        {
            return this.favoriteGenere;
        }
        public string get_addressCity()
        {
            return this.address_city;
        }
        public string get_addressStreet()
        {
            return this.address_street;
        }
        public int get_addressNumber()
        {
            return this.address_number;
        }
        public string getPhone()
        {
            return this.phone;
        }

        public void set_hasLendingTab(bool hasLendingTab)
        {
            this.hasLendingTab = hasLendingTab;
        }
       
        public void set_lendingEndDate(DateTime lendingEndDate)
        {
            this.lendingEndDate = lendingEndDate;
        }
        public void add_sale(Sale sale)
        {
            this.Sales.Add(sale);
        }
        public void add_lending(Lending lending)
        {
            this.Lendings.Add(lending);
        }
        public void add_returning(Returning returning)
        {
            this.Returnings.Add(returning);
        }
        public bool getHasLendingTab()
        {
            return this.hasLendingTab;
        }
        public DateTime getLendingEndDate()
        {
            return this.lendingEndDate;
        }
    }
}