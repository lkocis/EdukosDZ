using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadaća2_
{
    //Preimenovanje ZAD4
    public class Note
    {
        public string Title { get; set; }
        public string Text { get; set; }
        public DateTime Creation { get; private set; }

        public Note(string title, string text)
        {
            Title = title;
            Text = text;
            Creation = DateTime.Now;
        }
    }

    public class Notes
    {
        public string Author { get; private set; }
        public List<Note> notes;

        public Notes(string author)
        {
            Author = author;
            notes = new List<Note>();
        }

        public void AddNote(Note note)
        {
            notes.Add(note);
        }
    }
}
