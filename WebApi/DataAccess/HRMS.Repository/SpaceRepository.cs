using HRMS.DataModel;
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
    public class SpaceRepository : ISpaceRepository
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

        public DataTable Returndatatable1(string Querydetails)
        {
            DataTable dt = new DataTable();
            try
            {
                string _strConstr = ConfigurationSettings.AppSettings["DatabaseConnectionString1"].ToString();

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

        //get all space data from table
        public List<SpaceModel> GetAllSpaces(int Booking_Id)
        {
            List<SpaceModel> models = new List<SpaceModel>();

            string childviewsql = "select * from BLOCK_ADS_CHILD  where BOOKING_ID='" + Booking_Id + "' and DELETE_FLAG = 'N' ";
            DataTable data = Returndatatable(childviewsql);

            foreach (DataRow dr in data.Rows)
            {
                models.Add(new SpaceModel()
                {
                    Booking_Id = Convert.ToInt32(dr["BOOKING_ID"]),
                    Ad_Id = Convert.ToInt32(dr["AD_ID"]),
                    Publication = dr["PUBLICATION"].ToString(),
                    Product = dr["PRODUCT"].ToString(),
                    sEdition = dr["EDITION"].ToString(),
                    Issue_Date = Convert.ToDateTime(dr["ISSUE_DATE"]),
                    Colour_Type = dr["COLOUR_TYPE"].ToString(),
                    Height = (float)Convert.ToDouble(dr["HEIGHT"]),
                    Width = (float)Convert.ToDouble(dr["WIDTH"]),
                    Page = dr["PAGE_NO"].ToString(),
                    Amount = (float)Convert.ToDouble(dr["AMOUNT"]),
                    TimeStamp = dr["TIME_STAMP"].ToString(),
                    area = (float)Convert.ToDouble(dr["AREA"]),
                    status = dr["STATUS"].ToString()
                    
                });
            }

            return models;
        }

        //Get All parenttable By BookingId

        public List<SpaceModel> GetAllParentByBKID(int Booking_Id)
        {
            List<SpaceModel> models = new List<SpaceModel>();

            string parentviewsql = " select BLOCK_ADS_PARENT.Booking_Id,BLOCK_ADS_PARENT.Agency,BLOCK_ADS_PARENT.Client,BLOCK_ADS_PARENT.Total_Amount,BLOCK_ADS_PARENT.Ro_No,BLOCK_ADS_PARENT.Ro_date," +
                "BLOCK_ADS_CHILD.Ad_Id,BLOCK_ADS_CHILD.Publication,BLOCK_ADS_CHILD.Product,BLOCK_ADS_CHILD.Edition,BLOCK_ADS_CHILD.Issue_Date,BLOCK_ADS_CHILD.PAGE_NO," +
                "BLOCK_ADS_CHILD.Colour_Type,BLOCK_ADS_CHILD.Height,BLOCK_ADS_CHILD.Width,BLOCK_ADS_CHILD.Amount from BLOCK_ADS_CHILD inner join " +
                "BLOCK_ADS_PARENT ON BLOCK_ADS_CHILD.BOOKING_ID = BLOCK_ADS_PARENT.BOOKING_ID AND BLOCK_ADS_PARENT.BOOKING_ID='" + Booking_Id + "' ";
            DataTable data = Returndatatable(parentviewsql);
     
            foreach (DataRow dr in data.Rows)
            {
                models.Add(new SpaceModel()
                {
                    Ad_Id = Convert.ToInt32(dr["AD_ID"]),
                    Booking_Id = Convert.ToInt32(dr["BOOKING_ID"]),
                    Agency = dr["AGENCY"].ToString(),
                    Client = dr["CLIENT"].ToString(),
                    Ro_No = dr["RO_NO"].ToString(),
                    Ro_date = Convert.ToDateTime(dr["RO_DATE"]),
                    Publication = dr["PUBLICATION"].ToString(),
                    Product = dr["PRODUCT"].ToString(),
                    sEdition = dr["EDITION"].ToString(),
                    Issue_Date = Convert.ToDateTime(dr["ISSUE_DATE"]),
                    Colour_Type = dr["COLOUR_TYPE"].ToString(),
                    Height = (float)Convert.ToDouble(dr["HEIGHT"]),
                    Width = (float)Convert.ToDouble(dr["WIDTH"]),
                    Page = dr["PAGE_NO"].ToString(),
                    Amount = (float)Convert.ToDouble(dr["AMOUNT"]),
                    Total_Amount = (float)Convert.ToDouble(dr["TOTAL_AMOUNT"]),
                    
                 });
            }

            return models;
        }

        //Get All parenttable details
        public List<SpaceModel> GetAllParentValues()
        {
            List<SpaceModel> models = new List<SpaceModel>();

            string parentviewsql = "select * from BLOCK_ADS_PARENT ORDER BY BOOKING_ID DESC ";
            DataTable data = Returndatatable(parentviewsql);

            foreach (DataRow dr in data.Rows)
            {
                models.Add(new SpaceModel()
                {
                    Booking_Id = Convert.ToInt32(dr["BOOKING_ID"]),
                    Agency = dr["AGENCY"].ToString(),
                    Client = dr["CLIENT"].ToString(),
                    Sales_Person_Id = Convert.ToInt32(dr["SALES_PERSON_ID"]),
                    Date_Of_Booking = Convert.ToDateTime(dr["DATE_OF_BOOKING"]),
                    status = dr["STATUS"].ToString(),
                    Ro_No = dr["RO_NO"].ToString(),
                    Ro_date = Convert.ToDateTime(dr["RO_DATE"]),
                    Total_Amount = (float)Convert.ToDouble(dr["TOTAL_AMOUNT"]),
                });
            }

            return models;
        }
    }
}
