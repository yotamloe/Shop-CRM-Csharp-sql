using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace WindowsFormsApplication1
{

    public class Order
    {
        private int orderID;
        private DateTime orderTime;
        private DateTime plannedArrival;
        private Vendor vendor;
        private OrderStatus orderStatus;
        private List<Record_in_order> records;

        public Order(int ID, DateTime Date, DateTime arrivalDate, OrderStatus status, Vendor vendor, bool is_new)
        {
            this.orderID = ID;
            this.orderTime = Date;
            this.plannedArrival = arrivalDate;
            this.orderStatus = status;
            this.vendor = vendor;
            this.records = new List<Record_in_order>();

        }
        public int getID()
        {
            return this.orderID;
        }
        public DateTime getDate()
        {
            return this.orderTime;
        }
        public DateTime getArrivalDate()
        {
            return this.plannedArrival;
        }
        public void setStatus(OrderStatus status)
        {
            this.orderStatus = status;

            string temp1 = "dbo.sp_ordersStatus " + this.getID().ToString() + " , " + status.ToString();
            SqlCommand c1 = new SqlCommand();
            c1.CommandText = temp1;
            SQL_CON SC1 = new SQL_CON();
            SqlDataReader rdr1 = SC1.execute_query(c1);
        }
        public List<Record_in_order> getRecords()
        {
            return this.records;
        }
        public void addRecord(Record_in_order r)
        {
            this.records.Add(r);
        }

    }
}
    