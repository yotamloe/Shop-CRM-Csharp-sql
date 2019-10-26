using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class Vendor
    {
        private int vendorID;
        private string email;
        private int phone;
        private List<Order> Orders;

        public Vendor(int ID, int phone, string email,  bool is_new)
        {
            this.vendorID = ID;
            this.email = email;
            this.phone = phone;
            this.Orders = new List<Order>();
        }
        public int getID()
        {
            return this.vendorID;
        }
        public string getMail()
        {
            return this.email;
        }
        public int getPhone()
        {
            return this.phone;
        }

    }
}
