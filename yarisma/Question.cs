using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yarisma
{
    public class Question
    {
        public string Text { get; set; }
        public string[] Options { get; set; }  // string[] (dizi) kullanılıyor
        public string CorrectAnswer { get; set; }

    }
}
