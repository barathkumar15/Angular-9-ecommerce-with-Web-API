using HRMS.DataModel;
using HRMS.DataModel.EshoppingModel;
using HRMS.IRepository;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMS.Repository
{
   public class EshoppingRepository : IEshoppingRepository
    {
       
        public DataTable Returndatatable(string Querydetails)
        {
            DataTable dt = new DataTable();
            try
            {
                string _strConstr = ConfigurationSettings.AppSettings["DatabaseConnectionString"].ToString();

                try
                {
                    using (SqlConnection conn = new SqlConnection(_strConstr))
                    {
                        conn.Open();
                        SqlDataAdapter da = new SqlDataAdapter(Querydetails, conn);
                        da.SelectCommand.CommandTimeout = 300;
                        da.Fill(dt);
                        conn.Close();
                    }
                }
                catch (Exception ex) { }
            }
            catch (Exception ex1) { }
            return dt;
        }

        public string Returnstring(string Querydetails)
        {
            string retvalue = "";
            string _strConstr = ConfigurationSettings.AppSettings["DatabaseConnectionString"].ToString();
            try
            {
                using (SqlConnection con = new SqlConnection(_strConstr))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(Querydetails, con);

                    try
                    {
                        SqlDataReader dr;
                        dr = cmd.ExecuteReader();
                        while (dr.Read())
                        {
                            retvalue = dr.GetValue(0).ToString();
                        }
                        dr.Close(); con.Close();

                    }
                    catch (Exception ex) { }
                    cmd.Dispose();
                }
            }
            catch (Exception ex1) { }
            return retvalue;
        }

        public int Returnupdate(string Querydetails)
        {
            int retrows = 0;
            string _strConstr = ConfigurationSettings.AppSettings["DatabaseConnectionString"].ToString();
            try
            {
                using (SqlConnection con = new SqlConnection(_strConstr))
                {
                    if (con.State != ConnectionState.Open)
                        con.Open();
                    SqlCommand cmd = new SqlCommand(Querydetails, con);
                    try
                    {
                        //con.Open();
                        retrows = cmd.ExecuteNonQuery();
                        con.Close();

                    }
                    catch (Exception ex) { }
                    cmd.Dispose();
                }

            }
            catch (Exception ex1) { }
            return retrows;
        }

        public String ReturnUpdateByScalar(string Querydetails)
        {
            String rws = "";
            string _strConstr = ConfigurationSettings.AppSettings["DatabaseConnectionString"].ToString();
            try
            {
                using (SqlConnection con = new SqlConnection(_strConstr))
                {
                    if (con.State != ConnectionState.Open)
                        con.Open();
                    SqlCommand cmd = new SqlCommand(Querydetails, con);
                    try
                    {
                        //int n;
                        //return Int32.TryParse(s, out n);                  
                        rws = Convert.ToString(cmd.ExecuteScalar());
                        con.Close();

                    }
                    catch (Exception ex) { }
                    cmd.Dispose();
                }
            }
            catch { }
            return rws;
        }
        //default functions
        public List<EshoppingModel> GetAllProduct()
        {
            List<EshoppingModel> models = new List<EshoppingModel>();

            string productview = "select * from PRODUCT_LIST";
            DataTable data = Returndatatable(productview);

            foreach (DataRow dr in data.Rows)
            {
                models.Add(new EshoppingModel()
                {
                    Product_id = Convert.ToInt32(dr["PRODUCT_ID"]),
                    Product_name = dr["PRODUCT_NAME"].ToString(),
                    Product_description = dr["PRODUCT_DESCRIPTION"].ToString(),
                    Quantity = Convert.ToInt32(dr["QUANTITY"]),
                    Amount = Convert.ToInt32(dr["AMOUNT"]),
                    ImageUrl = dr["IMAGEURL"].ToString(),
                    Category_id = Convert.ToInt32(dr["CATEGORY_ID"])

                });
            }

            return models;
        }
    }
}
