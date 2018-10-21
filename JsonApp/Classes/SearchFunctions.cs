using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JsonApp
{
    class SearchFunctions
    {
        public List<Disney> QueryResults(List<Disney> disneyData, List<RadioButton> checkedRadio)
        {
            var tmp2 = checkedRadio.Select(x => x.Text).First();
            return disneyData;
        }
    }
}
