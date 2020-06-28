using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace HRMS.DataModel
{
    public class SpaceModel
    {
        public int Booking_Id { get; set; }
        public int Ad_Id { get; set; }
        public string Publication { get; set; }
        public string Product { get; set; }

        public string sEdition { get; set; }


        //public virtual ICollection<Worker> Worker { get; set; } = new List<string>();
        //public string Edition { get; set; }
        public DateTime Issue_Date { get; set; }
        public string Issue_Date1 { get; set; }
        public string Page { get; set; }
        public string Colour_Type { get; set; }
        public float Height { get; set; }
        public float Width { get; set; }
        public float area { get; set; }
        public float Amount { get; set; }
        public string status { get; set; }
        public string TimeStamp { get; set; }
        public DateTime Date_Of_Booking { get; set; }
        public string Agency { get; set; }
        public string Client { get; set; }
        public int Sales_Person_Id { get; set; }
        public float Total_Amount { get; set; }
        public string Ro_No { get; set; }
        public DateTime Ro_date { get; set; }
        public AttachmentModel Attachment { get; set; }
    }

    public class AttachmentModel
    {
        public string Filename { get; set; }
        public string DocumentBase64String { get; set; }
        public string Filepath { get; set; }
    }
}
