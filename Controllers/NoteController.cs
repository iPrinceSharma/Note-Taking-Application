using Newtonsoft.Json.Linq;
using NotemakingApplication.Database;
using NotemakingApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NotemakingApplication.Controllers
{
    public class NoteController : Controller
    {
        List<Note> notesList = new List<Note>();


        // GET: Note  (Get All Notes)
        public ActionResult AllNotes(){
            String notebyIdQuery = DatabaseQueryHelper.getAllNotesQuery();
            List<Note> notes = (List<Note>)DatabaseUtility.Instance.ExcuteObject<Note>(notebyIdQuery);
            notesList = notes;
            return View(notesList);
        }

        [Route("notebyid")]
        public ActionResult GetNotebyId(int id)
        {
            String notebyIdQuery = DatabaseQueryHelper.getNotesByIdQuery(id);
            List<Note> notes = (List<Note>)DatabaseUtility.Instance.ExcuteObject<Note>(notebyIdQuery);
            return Json(notes, JsonRequestBehavior.AllowGet);
        }


        [HttpPost]
        [Route("create")]
        public string CreateNote([FromBody] Note note){
            String createQuery = DatabaseQueryHelper.createNoteQuery(note.Title,note.Description,note.Tag,note.GroupId);
            List<Note> notes = (List<Note>)DatabaseUtility.Instance.ExcuteObject<Note>(createQuery);
            return "Created New Note";
        }

        [HttpPost]
        [Route("update")]
        public string UpdateNote([FromBody] Note note){
           String updateQuery = DatabaseQueryHelper.updateNoteQuery(note);
           List<Note> notes = (List<Note>)DatabaseUtility.Instance.ExcuteObject<Note>(updateQuery);
           return "Note Updated";
        }

        [Route("delete")]
        public string DeleteNote(int id){
        String deleteQuery = DatabaseQueryHelper.deleteNoteQuery(id);
        List<Note> notes = (List<Note>)DatabaseUtility.Instance.ExcuteObject<Note>(deleteQuery);
        return "Note Deleted";
    }

    }
}