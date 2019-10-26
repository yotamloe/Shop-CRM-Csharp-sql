using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class Record_in_sale
    {
        private Record record;
        private Sale sale;
        private int quantity;

        public Record_in_sale(Record record, Sale sale, int quantity, bool is_new)
        {
            this.record = record;
            this.sale = sale;
            this.quantity = quantity;

            if (is_new)
           {
                this.create_Record_in_sale();
          
          }
        }

        public Record getRecord()
        {
            return this.record;
        }

        public Sale getSale()
        {
            return this.sale;
        }

        public int getQuantity()
        {
            return this.quantity;
        }

        public void create_Record_in_sale()
        {
            string temp = "dbo.SP_AddRecordInSale " + sale.getSaleID().ToString()  + " , " + record.getQrCode().ToString() + " , " + this.getQuantity().ToString();
            SqlCommand c = new SqlCommand();
            c.CommandText = temp;
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);
        }
    }
}