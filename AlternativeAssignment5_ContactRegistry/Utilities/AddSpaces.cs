using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlternativeAssignment5_ContactRegistry.Utilities
{
    public static class AddSpaces
    {
        public static string addSpace(int spacecount)
        {
            string space = " ";
            for (int i = 0; i < spacecount; i++)
            {
                space = space + " ";
            }
            //space = space + spacecount.ToString();
            return space;
        }
    }
}
