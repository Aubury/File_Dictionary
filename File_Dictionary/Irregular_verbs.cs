using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File_Dictionary
{
    class Irregular_verbs
    {
        public string Infinitive { get; set; }
        public string Past_Simple { get; set; }
        public string Past_Participle { get; set; }
        public string Translation { get; set; }
        public Irregular_verbs(string inf, string past_s, string past_p, string tran)
        {
            Infinitive = inf;
            Past_Simple = past_s;
            Past_Participle = past_p;
            Translation = tran;
        }

        public override string ToString()
        {
            return $"\nInfinitive = {Infinitive},\nPast Simple =  { Past_Simple},\nPast Participle = {Past_Participle},\nTranslation = {Translation}";
        }

    }
}
