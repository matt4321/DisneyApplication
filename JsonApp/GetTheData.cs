using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonApp
{
    class GetTheData
    {
        public List<Disney> deserialise(string path)
        {
            var jsonObject = JsonConvert.DeserializeObject<List<Disney>>(File.ReadAllText(path));
            return jsonObject;
        }
    }
}
