using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace billInvoiceApp
{
    class DataAccess
    {
        //private SqlConnection con;

        private String conStr = ConfigurationManager.ConnectionStrings["billInvoiceApp.Properties.Settings.BillInvoiceConnectionString"].ConnectionString;

        public DataTable getBillDetailScheme()
        {
            SqlConnection con = new SqlConnection(conStr);
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("select ItmDescription,Quantity,Rate, '' as Amount from BillDetail where 1=2", con);
            SqlDataAdapter dadp = new SqlDataAdapter(cmd);
            dadp.Fill(dt);
            DataRow dr;
            for (int i = 0; i < 11; i++)
            {
                dr = dt.NewRow();
                dt.Rows.Add(dr);
            }
            return dt;
        }

        public String getInvoiceNumber()
        {
            String MaxInvoiceNo = "";
            SqlConnection con = new SqlConnection(conStr);
            try
            {
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand("select (IsNull(MAX(InvoiceNo),0) + 1) as InvoiceNo from BillMst", con);
                con.Open();
                MaxInvoiceNo = Convert.ToString(cmd.ExecuteScalar());
                con.Close();
            }
            catch (Exception)
            {

            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
            return MaxInvoiceNo;
        }

        public bool SaveData(BillData billData)
        {
            bool chkBool = false;
            Int64 chkflag = 0;
            SqlConnection con = new SqlConnection(conStr);
            try
            {
                SqlParameter[] para = new SqlParameter[]{
                new SqlParameter("BillToAdd",billData.BillToAdd),
                new SqlParameter("DeliverytoAdd",billData.DeliveryToAdd),
                new SqlParameter("InvoiceNo",billData.InvoiceNo),
                new SqlParameter("yourRefNo",billData.yourRefNo),
                new SqlParameter("ourRefNo",billData.ourRefNo),
                new SqlParameter("tax",billData.tax),
                new SqlParameter("freight",billData.freight),
                new SqlParameter("billID", SqlDbType.BigInt,Int32.MaxValue),
                };
                SqlCommand com = new SqlCommand("InBillMst", con);
                com.Parameters.AddRange(para);
                com.Parameters["billID"].Direction = ParameterDirection.Output;
                com.CommandType = CommandType.StoredProcedure;
                con.Open();
                chkflag = com.ExecuteNonQuery();
                if (chkflag > 0)
                {
                    chkflag = Convert.ToInt64(com.Parameters["billID"].Value);

                    if (chkflag > 0)
                    {
                        //Loop insert for bill details.
                        foreach (BillItems BillItm in billData.billItms)
                        {
                            para = new SqlParameter[]{
                                   new SqlParameter("BillId",chkflag),
                                   new SqlParameter("ItmDescription",BillItm.ItmDescription),
                                   new SqlParameter("Quantity",BillItm.Quantity),
                                   new SqlParameter("Rate",BillItm.Rate)
                                   };
                            com = new SqlCommand("InBillDetail", con);
                            com.Parameters.AddRange(para);
                            com.CommandType = CommandType.StoredProcedure;
                            com.ExecuteNonQuery();
                        }

                    }
                    chkBool = true;
                }
                con.Close();
            }
            catch (Exception ex)
            {
                chkBool = false;
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
            return chkBool;
        }

    }

    class BillData
    {
        public string BillToAdd { get; set; }
        public string DeliveryToAdd { get; set; }
        public Int64 InvoiceNo { get; set; }
        public String yourRefNo { get; set; }
        public String ourRefNo { get; set; }
        public Double tax { get; set; }
        public Double freight { get; set; }
        public DateTime? billDate { get; set; }
        public List<BillItems> billItms { get; set; }
    }

    class BillItems
    {
        public Int64 BillId { get; set; }
        public String ItmDescription { get; set; }
        public Double Quantity { get; set; }
        public Double Rate { get; set; }
    }
}
