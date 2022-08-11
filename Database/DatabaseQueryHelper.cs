using NotemakingApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NotemakingApplication.Database
{
    public static class DatabaseQueryHelper
    {

        // Notes Queries

        // get all notes
        public static string getAllNotesQuery(){
            return "SELECT * FROM Note Order By Title";
        }

        // get Note by Id
        public static string getNotesByIdQuery(int id){
            return "SELECT * FROM Note Where Id ='"+id+"'";
        }

        // Create new Note
        public static string createNoteQuery(string name,string description,string tag,int groupid){
            return "INSERT INTO Note values ('" + groupid + "','" + name + "','" + description + "','" + tag + "')";
        }

        // Update Note
        public static string updateNoteQuery(Note note){
            return "UPDATE Note set GroupId='" + note.GroupId + "',Title='" + note.Title + "',Description='" + note.Description + "',Tag='" + note.Tag + "' " +
                "Where Id ='"+note.Id+"'";
        }

        // Delete Note By Id
        public static string deleteNoteQuery(int id){
            return "Delete from Note where Id='"+id+"'";
        }


        // Group Queries




    }
}