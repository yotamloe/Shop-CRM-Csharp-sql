using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace WindowsFormsApplication1
{
    public class Record_in_order
    {
        private int requiredQuantity;
        private int arrivedQuantity;
        private Order order;
        private Record record;


        public Record_in_order(Order order, Record record, int requiredQ, int arrivedQ, bool is_new)
        {
            this.requiredQuantity = requiredQ;
            this.order = order;
            this.record = record;
            this.arrivedQuantity = arrivedQ;
          
        }

        public int getRequiredQ()
        {
            return this.requiredQuantity;
        }
        public override string ToString()
        {
            return this.record.ToString();
        }
        public Record getRecord()
        {
            return this.record;
        }
        public Order getOrder()
        {
            return this.order;
        }
        public void setarrivedQuantity(int num)
        {
            this.arrivedQuantity += num;

            string temp = "dbo.sp_updateArriveQuantity " + num.ToString() + " , " + order.getID().ToString()
                         + " , " + this.getRecord().getQrCode().ToString();
            SqlCommand c = new SqlCommand();
            c.CommandText = temp;
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);
        }
        public int getarrivedQ()
        {
            return this.arrivedQuantity;
        }



    }
}