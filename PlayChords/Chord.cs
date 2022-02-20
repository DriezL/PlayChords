using System;
using System.Collections.Generic;

namespace PlayChords
{
    public class Chord
    {
        readonly List<string> allNotes = new List<string>(12);

        public Chord()
        {
            allNotes.Add("A");
            allNotes.Add("Bes");
            allNotes.Add("B");
            allNotes.Add("C");
            allNotes.Add("Des");
            allNotes.Add("D");
            allNotes.Add("Es");
            allNotes.Add("E");
            allNotes.Add("F");
            allNotes.Add("Ges");
            allNotes.Add("G");
            allNotes.Add("As");
        }

        public string MajeurAkkoord(string note)
        {
            var index1 = allNotes.IndexOf(note);
            Math.DivRem((index1 + 4), 12, out int index2);
            Math.DivRem((index2 + 3), 12, out int index3);
            return $"{note} - {allNotes[index2]} - {allNotes[index3]}";
        }

        public string Doe()
        {
            return "";
        }

        public string MineurAkkoord(string note)
        {
            var index1 = allNotes.IndexOf(note);
            Math.DivRem((index1 + 3), 12, out int index2);
            Math.DivRem((index2 + 4), 12, out int index3);
            return $"{note} - {allNotes[index2]} - {allNotes[index3]}";
        }
    }
}
