using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeyWorld
{
    class IteratorDemo :IEnumerable
    {
        string[] movies = { "mov1", "mov2", "mov3" ,"mov4"};
        string[,] reviws = new string[4, 2]
        {
            {"4","good" },
            {"4","vgood" },
            {"4","ok" },
            {"4","bad" }
        };
        public IEnumerator GetEnumerator()
        {
            for(int i=0;i<movies.Length;i++)
            {
                yield return movies[i];
            }
        }

    }
}
