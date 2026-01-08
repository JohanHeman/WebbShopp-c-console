using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webbshopp
{
    internal class Helpers
    {

        public static List<string> EnumsToLists(Type e)
        {
            List<string> theList = new List<string>();

            var enumValues = Enum.GetValues(e);
            
            foreach ( var value in enumValues )
            {
                theList.Add((int)value + ": " + value.ToString());
            }
            return theList;   
        }
    }
}
