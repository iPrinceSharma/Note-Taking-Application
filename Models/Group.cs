using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace NotemakingApplication.Models
{
    public class Group
    {
        public int GroupId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Tag { get; set; }

        public Group() { }

        public Group(int groupId,string name,string description,string tag){
            this.GroupId = groupId;
            this.Title = name;
            this.Description = description;
            this.Tag = tag;
        }

        public Group(DataRow data)
        {
            this.GroupId = Convert.ToInt32(data["GroupId"]);
            this.Title = data["Title"].ToString();
            this.Description = data["Description"].ToString();
            this.Tag = data["Tag"].ToString();
        }
    }
}