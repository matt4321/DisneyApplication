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
        public List<Disney> QueryResults(List<Disney> disneyData, List<RadioButton> checkedRadio, string textData)
        {
            var checkedTitle = checkedRadio.Select(x => x.Text).First();
            var checkedOutput = result(checkedTitle);
            var resultsDisneyData = disneyData.Where(x => x.GetType().GetProperty(checkedOutput).GetValue(x, null).ToString().Contains(textData));
            var listResultsDisneyData = resultsDisneyData.ToList();
            return listResultsDisneyData;
        }

        public string result(string checkedTitle)
        {
            var list = new List<ConverstionClass>();
            list.Add(new ConverstionClass { input = "Year", output = "yr" });
            list.Add(new ConverstionClass { input = "Length", output = "len" });
            list.Add(new ConverstionClass { input = "Title", output = "mv" });
            list.Add(new ConverstionClass { input = "Rating", output = "rt" });
            var result = list.Where(x => x.input == checkedTitle).First().output;
            return result;
        }
    }
}
