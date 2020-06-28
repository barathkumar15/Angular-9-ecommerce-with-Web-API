using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMS.DataModel.EshoppingModel
{
    public class EshoppingModel
    {
        //user_registration model
        //public int User_id { get; set; }
        //public string User_name { get; set; }
        //public string Password { get; set; }
        //public string Mail_id { get; set; }
        //public string Phone { get; set; } 
        
        //category model
        public int Category_id { get; set; }
        //public string Category_name { get; set; }

        //product model
        public string ImageUrl { get; set; }
        public int Product_id { get; set; }
        public string Product_name { get; set; }
        public string Product_description { get; set; }
        public int Quantity { get; set; }
        public int Amount { get; set; }
    }
}
