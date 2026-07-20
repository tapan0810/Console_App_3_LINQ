using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_App_3_LINQ.Linq
{
    public class Projection
    {
        //Select() Projection Example
        List<int> nums = new()
        {
            1,2,3,4,5,6,7,8,9,10
        };

        public void SelectExample()
        {
            var result = nums.Select(x => x * x);

            foreach(var i in result)
            {
                Console.WriteLine(i +" ");
            }
        }

    }
}
