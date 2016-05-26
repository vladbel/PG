using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PG.Pages
{
    public class Group
    {
        public Page Page { get; set; }

        public static IEnumerable<Body> GetBodies (IEnumerable<Group> groups)
        {
            var bodies = groups.SelectMany(g => g.Page.GetBodies());
            return bodies;
        }

        public static void UpdateBodyImages (IEnumerable<Group> groups)
        {

        }
    }


}
