using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace NotemakingApplication.Models
{
    public class Note {

        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int GroupId {get;set;}
        public string Tag { get; set; }
       
        public Note(){

        }

        public Note(int noteid,string title,string description, int groupid = 0, string tag = "General")
        {
            this.Id = noteid;
            this.Title = title;
            this.Tag = tag;
            this.GroupId = groupid;
            this.Description = description;
        }
        
        public Note(DataRow data)
        {
            this.Id = Convert.ToInt32(data["Id"]);
            this.GroupId = Convert.ToInt32(data["GroupId"]);
            this.Tag = data["Tag"].ToString();
            this.Title = data["Title"].ToString();
            this.Description = data["Description"].ToString();
        }
    }
}