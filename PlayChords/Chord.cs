using System;
using System.Collections.Generic;

namespace PlayChords
{
    public class Chord
    {
        readonly List<string> allNotes = new(12);

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


        public string MajeurAkkoord(string baseNote)
        {
            var index1 = allNotes.IndexOf(baseNote);
            Math.DivRem((index1 + 4), 12, out int index2);
            Math.DivRem((index2 + 3), 12, out int index3);
            return $"{baseNote} - {allNotes[index2]} - {allNotes[index3]}";
        }



        public string MineurAkkoord(string baseNote)
        {
            var index1 = allNotes.IndexOf(baseNote);
            Math.DivRem((index1 + 3), 12, out int index2);
            Math.DivRem((index2 + 4), 12, out int index3);
            return $"{baseNote} - {allNotes[index2]} - {allNotes[index3]}";
        }



        public string GeefAkkoord(string baseNote, bool mineur, bool sus, bool dominant, bool verminderd, bool halfVerminderd)
        {
            var index1 = allNotes.IndexOf(baseNote);
            int b = 4;
            int c = 7;
            int d = 0;
            if (c == 7 || d != 0)
            {
                d = 11;
            }
            if (mineur && !dominant && !verminderd && !halfVerminderd)
            {
                b--;
                d--;
            }
            if (sus && !mineur)
            {
                c -= 2;
            }
            if (dominant && !mineur)
            {
                d -= 1;
            }
            if (verminderd && !halfVerminderd)
            {
                if (!mineur)
                {
                    b--;
                }
                if (sus)
                {
                    c++;
                }
                else
                {
                    c--;
                }
                if (dominant)
                {
                    d--;
                }
                else
                {
                    d -= 2;
                }
            }
            if (halfVerminderd && !verminderd)
            {
                if (!mineur)
                {
                    b--;
                    c--;
                }
                if (dominant)
                {
                    throw new ArgumentException("halfverminderd kan niet samen met dominant");
                }
                else
                {
                    d -= 1;
                }
            }


            Math.DivRem((index1 + b), 12, out int index2);
            Math.DivRem((index1 + c), 12, out int index3);
            Math.DivRem((index1 + d), 12, out int index4);
            return $"{baseNote} - {allNotes[index2]} - {allNotes[index3]} - {allNotes[index4]}";
        }

    }
}
