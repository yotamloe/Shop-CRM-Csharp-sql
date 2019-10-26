using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{

    public class Record
    {
        private int qrCode;
        private string recordName;
        private string artist;
        private Genere genere;
        private float price;
        private int quantityInStock;
        private int quantityInLending;
        private List<Returning> Returning;
        private List<Record_in_lending> Records_in_lendings;
        private List<Record_in_order> Records_in_orders;
        private List<Record_in_sale> Records_in_sales;




        public Record(int qrCode, string name, string artist, Genere genere, float price, int quantityInStock, int quantityInLending, bool is_new)
        {
            this.qrCode = qrCode;
            this.recordName = name;
            this.artist = artist;
            this.genere = genere;
            this.price = price;
            this.quantityInStock = quantityInStock;
            this.quantityInLending = quantityInLending;
            this.Returning = new List<Returning>();
            this.Records_in_lendings = new List<Record_in_lending>();
            this.Records_in_orders = new List<Record_in_order>();
            this.Records_in_sales = new List<Record_in_sale>();
            if (is_new)
            {
                this.create_record();
                Program.Records.Add(this);
            }
        }

        // Add objects to lists methods
        //
        //
        public int getQrCode()
        {
            return this.qrCode;
        }
        public override string ToString()
        {
            return this.recordName;
        }
        public string getRecordName()
        {
            return this.recordName;
        }
        public string getArtist()
        {
            return this.artist;
        }
        public Genere getGener()
        {
            return this.genere;
        }
        public float getPrice()
        {
            return this.price;
        }
        public int getQuantityInStock()
        {
            return this.quantityInStock;
        }
        public int getQuantityInLending()
        {
            return this.quantityInLending;
        }
        public void setQuantityInStock(int quantity)
        {
            this.quantityInStock = quantity;

            string tempc = "dbo.sp_UpdateRecord " + this.getQrCode().ToString() + " , "
                            + quantity.ToString();
            SqlCommand cc = new SqlCommand();
            cc.CommandText = tempc;
            SQL_CON SCc = new SQL_CON();
            SqlDataReader rdrc = SCc.execute_query(cc);
        }
                public void setQuantityInLending(int quantity)
        {
            this.quantityInLending = quantity;

            string tempc = "dbo.sp_QuantityInLending " + this.getQrCode().ToString() + " , "
                           + quantity.ToString();
            SqlCommand cc = new SqlCommand();
            cc.CommandText = tempc;
            SQL_CON SCc = new SQL_CON();
            SqlDataReader rdrc = SCc.execute_query(cc);
        }

        public void addRecordInLending(Record_in_lending r)
        {
            this.Records_in_lendings.Add(r);
        }
        public void addRecordInSale(Record_in_sale r)
        {
            this.Records_in_sales.Add(r);
        }
        public void addRecordInOrder(Record_in_order r)
        {
            this.Records_in_orders.Add(r);
        }
        public List<Record_in_lending> getRecord_in_lendings()
        {
            return this.Records_in_lendings;
        }
        public List<Record_in_order> getRecord_in_orders()
        {
            return this.Records_in_orders;
        }
        public List<Record_in_sale> getRecord_in_sales()
        {
            return this.Records_in_sales;
        }

        public void create_record()
        {
            string temp = "dbo.sp_AddRecord " + this.getQrCode().ToString() + " , " + this.getRecordName().ToString() + " , "
                + this.getArtist().ToString() + " , " + this.getGener().ToString() + " , " + this.getPrice().ToString() + " , "
                + this.getQuantityInStock().ToString();
            SqlCommand c = new SqlCommand();
            c.CommandText = temp;
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);
        }
    }
}