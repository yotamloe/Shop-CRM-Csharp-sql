using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace WindowsFormsApplication1
{
    public class Record_in_lending
    {
        private Record record;
        private Lending lending;
        private int quantity;


        public Record_in_lending(Lending lending, Record record, int quantity, bool is_new)
        {
            this.record = record;
            this.lending = lending;
            this.quantity = quantity;
            if (is_new)
            {
                this.create_Record_in_lending();
           
            }
        }

        public Record getRecord()
        {
            return this.record;
        }
        public Lending getLending()
        {
            return this.lending;
        }
        public int getQuantity()
        {
            return this.quantity;
        }

        public void create_Record_in_lending()
        {
            string temp = "dbo.sp_AddRecordInLending " + this.getLending().getLendingID().ToString() + " , " + this.getRecord().getQrCode().ToString() + " , "
               + this.getQuantity().ToString();
            SqlCommand c = new SqlCommand();
            c.CommandText = temp;
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);
        }
    }
}