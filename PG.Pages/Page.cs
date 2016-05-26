using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PG.Pages
{
    public class Page
    {
        public IEnumerable<Section> Sections { get; set; }

        public  IEnumerable<Body> GetBodies()
        {
            return this.Sections?.SelectMany(s => s.Bodies);
        }
    }
}
