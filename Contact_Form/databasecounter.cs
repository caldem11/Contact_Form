using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contact_Form
{
    class databasecounter
    {
        public void databaseconter()
        {

        }
        public void databaseitems()
        {
            Customer table = new Customer();

            bool contains = table.Rows.Cast<DataRow>().SelectMany(r => r.ItemArray).Contains(value);
        }
    }
}
