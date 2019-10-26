using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class Sale
    {
        private int saleID;
        private DateTime saleDate;
        private float totalCost;
        private PaymentMethod paymentMethod;
        private List<Record_in_sale> records;
        private Customer Customer;


        public Sale(int ID, DateTime saleDate, PaymentMethod payment,  Customer Customer, bool is_new)
        {
            this.saleID = ID;
            this.saleDate = saleDate;
            this.paymentMethod = payment;
            this.records = new List<Record_in_sale>();
            this.totalCost = 0;
            this.Customer = Customer;

            
      if (is_new)
            {
               this.create_sale();
                Program.Sales.Add(this);
           }
        }

        public int getSaleID()
        {
            return this.saleID;
        }

        public DateTime getDate()
        {
            return this.saleDate;
        }

        public float getTotalCost()
        {
            return this.totalCost;
        }
        public PaymentMethod getPaymentAccount()
        {
            return this.paymentMethod;
        }
        public List<Record_in_sale> getRecords()
        {
            return this.records;
        }
        public void addRecord(Record_in_sale r)
        {
            this.records.Add(r);
        }

        public void create_sale()
        {
            string temp = "dbo.SP_AddSale " + this.getSaleID().ToString() + " , ' " + this.getDate().ToString() +
                " ' , " +  this.getTotalCost().ToString() 
              +" , " + this.getPaymentAccount().ToString()+ " ,  [" + this.Customer.getEmail().ToString()+"]";
            SqlCommand c = new SqlCommand();
            c.CommandText = temp;
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);
        }
        public void updateTotalCost()
        {
            foreach (Record_in_sale r in this.records)
            {
              this.totalCost = this.totalCost +(r.getRecord().getPrice() * r.getQuantity());
            }
            string temp = "dbo.SP_UpdateTotalCost " + this.getSaleID().ToString() + " , " + this.getTotalCost().ToString();
            SqlCommand c = new SqlCommand();
            c.CommandText = temp;
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);

        }


    }
}