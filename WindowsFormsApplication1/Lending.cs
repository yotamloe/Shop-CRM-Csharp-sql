using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace WindowsFormsApplication1
{

    public class Lending
    {
        private int lendingID;
        private DateTime startDate;
        private DateTime endDate;
        private LendingStatus status;
        private List<Record_in_lending> records;
        private Customer Customer;
        private DateTime returnDate;


        public Lending(int ID, DateTime startDate, DateTime endDate, LendingStatus status,  Customer Customer, DateTime returnDate, bool is_new)
        {
            this.lendingID = ID;
            this.startDate = startDate;
            this.endDate = endDate;
            this.status = status;
            this.Customer = Customer;
            this.returnDate = returnDate;
            this.records = new List<Record_in_lending>();
            foreach (Record_in_lending r in records)
            {
                this.records.Add(r);
            }

            if (is_new)
            {
                this.create_lending();
                Program.Lendings.Add(this);
            }
        }

        public int getLendingID()
        {
            return this.lendingID;
        }
        public DateTime getStartDate()
        {
            return this.startDate;
        }
        public DateTime getEndDate()
        {
            return this.endDate;
        }
        public DateTime getReturnDate()
        {
            return this.returnDate;
        }
        public LendingStatus getStatus()
        {
            return this.status;
        }
        public void setStatus(LendingStatus status)
        {
            this.status = status;

            string temp1 = "dbo.sp_LendingStatus " + this.getLendingID().ToString() + " , " + this.status.ToString();
            SqlCommand c1 = new SqlCommand();
            c1.CommandText = temp1;
            SQL_CON SC1 = new SQL_CON();
            SqlDataReader rdr1 = SC1.execute_query(c1);
        }
        public List<Record_in_lending> getRecords()
        {
            return this.records;
        }
        public void addRecord(Record_in_lending r)
        {
            this.records.Add(r);
        }
        public Customer getCustomer()
        {
            return this.Customer;
        }
        public void setEndDate(DateTime DT)
        {
            this.endDate = DT;
            string temp1 = "dbo.sp_LendingEndDate " + this.getLendingID().ToString() + " , '" + this.endDate.ToString()+" '";
            SqlCommand c1 = new SqlCommand();
            c1.CommandText = temp1;
            SQL_CON SC1 = new SQL_CON();
            SqlDataReader rdr1 = SC1.execute_query(c1);
        }
        public void setReturnDate(DateTime DT)
        {
            this.returnDate = DT;

            string temp1 = "dbo.sp_LendingReturnDate " + this.getLendingID().ToString() + " , ' " + this.returnDate.ToString () + " '";
            SqlCommand c1 = new SqlCommand();
            c1.CommandText = temp1;
            SQL_CON SC1 = new SQL_CON();
            SqlDataReader rdr1 = SC1.execute_query(c1);
        }

        public void create_lending()
        {
            string temp = "dbo.sp_AddLending " + this.getLendingID().ToString() + " , ' " + this.getStartDate().ToString() + " ' ,  '"
                + this.getEndDate().ToString() + " ' , " + this.getStatus().ToString() + " , [" + this.getCustomer().getEmail().ToString() + "] , ' "
                + this.getReturnDate().ToString()+" ' ";
            SqlCommand c = new SqlCommand();
            c.CommandText = temp;
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);
        }


    }
}