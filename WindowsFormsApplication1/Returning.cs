using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class Returning
    {
        private int returnID;
        private DateTime returnDate;
        private Record record;
        private float totalCost;
        private Customer Customer;


        public Returning(int ID, DateTime date, Record record, Customer Customer, bool is_new)
        {
            this.returnDate = date;
            this.returnID = ID;
            this.record = record;
            this.Customer = Customer;
            this.totalCost = record.getPrice();

        }
        public int getReturnID()
        {
            return this.returnID;
        }
        public DateTime getReturnDate()
        {
            return this.returnDate;
        }
        public Record getRecord()
        {
            return this.record;
        }
    }
}