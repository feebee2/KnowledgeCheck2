using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnowledgeCheck2_Carp
{
    public class Carp : Fish
    {
        public string species = "";

        public override string ToString()
        {
            return string.Join("; ",
                $"sizeCM = {sizeCM}",
                $"color = {color}",
                $"ageYR = {ageYR}",
                $"species = {species}"
                );
        }
    }
}
