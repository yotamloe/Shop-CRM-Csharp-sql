using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;


namespace WindowsFormsApplication1
{
    static class Program
    {
        public static System.Collections.Generic.List<Employee> Employees;
        public static System.Collections.Generic.List<Order> Orders;
        public static System.Collections.Generic.List<Customer> Customers;
        public static System.Collections.Generic.List<Sale> Sales;
        public static System.Collections.Generic.List<Lending> Lendings;
        public static System.Collections.Generic.List<Returning> Returnings;
        public static System.Collections.Generic.List<Record> Records;
        public static System.Collections.Generic.List<Vendor> Vendors;
      

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        

        public static void initLists()//מילוי הרשימות מתוך בסיס הנתונים
        {
            init_Employees();//אתחול הרשימה של העובדים
            init_Records();//אתחול הרשימה של התקליטים
            init_Customers(); //אתחול הרשימה של הלקוחות
            init_Vendors(); //אתחול הרשימה של הספקים
            init_Orders();//אתחול הרשימה של ההזמנות
            init_Sales();//אתחול הרשימה של מכירות
            init_Lendings();//אתחול הרשימה של ההשאלות
            init_Returnings();//אתחול הרשימה של החזרות
            init_Records_in_Lendings();//אתחול הרשימה של תקליטים בהשאלות
            init_Records_in_Sales();//אתחול הרשימה של תקליטים במכירות
            init_Records_in_Orders();//אתחול הרשימה של תקליטים בהזמנות
        }


        public static void init_Employees()//מילוי רשימת העובדים מתוך בסיס הנתונים
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE Get_all_EmployeeS";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);

            Employees = new List<Employee>();

            while (rdr.Read())
            {
                EmplyeeStatus es = (EmplyeeStatus)Enum.Parse(typeof(EmplyeeStatus), rdr.GetValue(4).ToString());
                Role r = (Role)Enum.Parse(typeof(Role), rdr.GetValue(5).ToString());
                Employee e = new Employee(int.Parse(rdr.GetValue(0).ToString()), rdr.GetValue(1).ToString(), rdr.GetValue(2).ToString(), DateTime.Parse(rdr.GetValue(3).ToString()), es, r, DateTime.Parse(rdr.GetValue(6).ToString()), rdr.GetValue(7).ToString(), false);
                Employees.Add(e);
            }
        }

        public static void init_Orders()//מילוי רשימת העובדים מתוך בסיס הנתונים
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.Get_all_Orders";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);

            Orders = new List<Order>();

            while (rdr.Read())
            {
                OrderStatus os = (OrderStatus)Enum.Parse(typeof(OrderStatus), rdr.GetValue(3).ToString());
                Order o = new Order(int.Parse(rdr.GetValue(0).ToString()), DateTime.Parse(rdr.GetValue(1).ToString()), DateTime.Parse(rdr.GetValue(2).ToString()), os, GetVendorByID(int.Parse(rdr.GetValue(4).ToString())), false);
                Orders.Add(o);
            }
        }

        public static void init_Customers()//מילוי רשימת הלקוחות מתוך בסיס הנתונים
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.Get_all_Customers";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);

            Customers = new List<Customer>();

            while (rdr.Read())
            {
                Genere g = (Genere)Enum.Parse(typeof(Genere), rdr.GetValue(5).ToString());
                Customer cu = new Customer(rdr.GetValue(0).ToString(), int.Parse(rdr.GetValue(1).ToString()), rdr.GetValue(2).ToString(), rdr.GetValue(3).ToString(), DateTime.Parse(rdr.GetValue(4).ToString()),
                    g, Boolean.Parse(rdr.GetValue(6).ToString()), DateTime.Parse(rdr.GetValue(7).ToString()), rdr.GetValue(8).ToString(), rdr.GetValue(9).ToString(),
                    int.Parse(rdr.GetValue(10).ToString()), rdr.GetValue(11).ToString(),false) ;
                Customers.Add(cu);
            }
        }

        public static void init_Vendors()//מילוי רשימת העובדים מתוך בסיס הנתונים
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.Get_all_vendors";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);

            Vendors = new List<Vendor>();

            while (rdr.Read())
            {
                Vendor v = new Vendor(int.Parse(rdr.GetValue(0).ToString()),
                    int.Parse(rdr.GetValue(1).ToString()), rdr.GetValue(2).ToString(),  false);
                Vendors.Add(v);
            }
        }

        public static void init_Sales()//מילוי רשימת המכירות מתוך בסיס הנתונים
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.Get_all_sales";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);

            Sales = new List<Sale>();

            while (rdr.Read())
            {
                PaymentMethod pm = (PaymentMethod)Enum.Parse(typeof(PaymentMethod), rdr.GetValue(3).ToString());
                Sale s = new Sale(int.Parse(rdr.GetValue(0).ToString()), DateTime.Parse(rdr.GetValue(1).ToString()), pm, GetCustomerByEmail(rdr.GetValue(4).ToString()), false);
                Sales.Add(s);
            }
        }

        public static void init_Lendings()//מילוי רשימת ההשאלות מתוך בסיס הנתונים
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.Get_all_lending";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);

            Lendings = new List<Lending>();
            DateTime DT;
            while (rdr.Read())
            {
                if (rdr.GetValue(5).ToString().Equals(""))
                {
                    DT = DateTime.MinValue;
                }
                else
                {
                    DT = DateTime.Parse(rdr.GetValue(5).ToString());
                }

                LendingStatus ls = (LendingStatus)Enum.Parse(typeof(LendingStatus), rdr.GetValue(3).ToString());
                Lending l = new Lending(int.Parse(rdr.GetValue(0).ToString()), DateTime.Parse(rdr.GetValue(1).ToString()), DateTime.Parse(rdr.GetValue(2).ToString()), ls, GetCustomerByEmail(rdr.GetValue(4).ToString()),DT , false);
                Lendings.Add(l);
            }

        }

        public static void init_Returnings()//מילוי רשימת ההחזרות מתוך בסיס הנתונים
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE Get_all_Returnings";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);

            Returnings = new List<Returning>();

            while (rdr.Read())
            {
                Returning r = new Returning(int.Parse(rdr.GetValue(0).ToString()), DateTime.Parse(rdr.GetValue(1).ToString()), GetRecordByQR(int.Parse(rdr.GetValue(3).ToString())), GetCustomerByEmail(rdr.GetValue(2).ToString()), false);
                Returnings.Add(r);
            }
        }

        public static void init_Records()//מילוי רשימת התקיטים מתוך בסיס הנתונים
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.Get_all_records";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);

            Records = new List<Record>();

            while (rdr.Read())
            {
                Genere g = (Genere)Enum.Parse(typeof(Genere), rdr.GetValue(3).ToString());
                Record r = new Record(int.Parse(rdr.GetValue(0).ToString()), rdr.GetValue(1).ToString(), rdr.GetValue(2).ToString(), g, float.Parse(rdr.GetValue(4).ToString()), int.Parse(rdr.GetValue(5).ToString()), int.Parse(rdr.GetValue(6).ToString()), false);
                Records.Add(r);
            }
        }

        public static void init_Records_in_Sales()//מילוי רשימת התקליטים במכירות מתוך בסיס הנתונים
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.Get_all_RecordsinSales";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);

            while (rdr.Read())
            {
                Record r = GetRecordByQR(int.Parse(rdr.GetValue(1).ToString()));
                Sale s = GetSaleByID(int.Parse(rdr.GetValue(0).ToString()));
                Record_in_sale ris = new Record_in_sale(r, s, int.Parse(rdr.GetValue(2).ToString()), false);
                r.addRecordInSale(ris);
                s.addRecord(ris);

               

            }
            foreach( Sale s in Program.Sales)
            {
                s.updateTotalCost();
            }
            
        }

        public static void init_Records_in_Orders()//מילוי רשימת התקיטים בהזמנות מתוך בסיס הנתונים
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.Get_all_RecordsinOrders";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);


            while (rdr.Read())
            {
                Order o = GetOrderByID(int.Parse(rdr.GetValue(0).ToString()));
                Record r = GetRecordByQR(int.Parse(rdr.GetValue(1).ToString()));
                Record_in_order rio = new Record_in_order(o, r, int.Parse(rdr.GetValue(2).ToString()), int.Parse(rdr.GetValue(3).ToString()), false);
                o.addRecord(rio);
                r.addRecordInOrder(rio);

            }
        }

        public static void init_Records_in_Lendings()//מילוי רשימת התקיטים בהשאלות מתוך בסיס הנתונים
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.Get_all_RecordsinLendings";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);


            while (rdr.Read())
            {
                Lending l = GetLendingByID(int.Parse(rdr.GetValue(0).ToString()));
                Record r = GetRecordByQR(int.Parse(rdr.GetValue(1).ToString()));
                Record_in_lending ril = new Record_in_lending(l, r, int.Parse(rdr.GetValue(2).ToString()), false);
                l.addRecord(ril);
                r.addRecordInLending(ril);
        
            }
        }
        [STAThread]
        static void Main()
        {
            initLists();
            foreach (Employee e in Employees)
            {
                Console.WriteLine(e.getID());
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Conect_Form());
           
        }
        // Get methods for Lists
        public static Vendor GetVendorByID(int id)
        {
            Vendor temp = Vendors.First();
            foreach (Vendor v in Vendors)
            {
                if (v.getID() == id)
                    temp = v;
            }
            return temp;
        }

        public static Customer GetCustomerByEmail(string email)
        {
            Customer temp = Customers.First();
            foreach (Customer c in Customers)
            {
                if (c.getEmail() == email)
                    temp = c;
            }
            return temp;
        }
        public static Record GetRecordByQR(int qr)
        {
            Record temp = Records.First();
            foreach (Record r in Records)
            {
                if (r.getQrCode() == qr)
                    temp = r;
            }
            return temp;
        }

        public static Sale GetSaleByID(int id)
        {
            Sale temp = Sales.First();
            foreach (Sale s in Sales)
            {
                if (s.getSaleID() == id)
                    temp = s;
            }
            return temp;
        }

        public static Order GetOrderByID(int id)
        {
            Order temp = Orders.First();
            foreach (Order o in Orders)
            {
                if (o.getID() == id)
                    temp = o;
            }
            return temp;
        }

        public static Lending GetLendingByID(int id)
        {
            Lending temp = Lendings.First();
            foreach (Lending l in Lendings)
            {
                if (l.getLendingID() == id)
                    temp = l;
            }
            return temp;
        }

        public static Customer GetCustomerByID(int ID)
        {
            Customer temp = Customers.First();
            foreach (Customer c in Customers)
            {
                if (c.getCustomerID() == ID)
                    temp = c;
            }
            return temp;
        }


    }
}
