using ProgramBox.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace ProgramBox.Utils
{
    class JsonDataUtils
    {
        public class JsonData
        {
            [JsonProperty]
            public List<WebAtom> WebAtomList;

            [JsonProperty]
            public List<NativeAtom> NativeAtomList;

            [JsonProperty]
            public List<InsAtom> InsAtomList;

            [JsonProperty]
            public List<WinToolAtom> WinToolAtomList;
        }

        public JsonData jsonData;

        public List<WebAtom> WebAtomList
        {
            get
            {
                if (jsonData.WebAtomList == null) jsonData.WebAtomList = new List<WebAtom>();
                return jsonData.WebAtomList;
            }
        }

        public List<NativeAtom> NativeAtomList
        {
            get
            {
                if (jsonData.NativeAtomList == null) jsonData.NativeAtomList = new List<NativeAtom>();
                return jsonData.NativeAtomList;
            }
        }

        public List<InsAtom> InsAtomList
        {
            get
            {
                if (jsonData.InsAtomList == null) jsonData.InsAtomList = new List<InsAtom>();
                return jsonData.InsAtomList;
            }
        }


        public List<WinToolAtom> WinToolAtomList
        {
            get
            {
                if (jsonData.WinToolAtomList == null) jsonData.WinToolAtomList = new List<WinToolAtom>();
                return jsonData.WinToolAtomList;
            }
        }

        public JsonDataUtils()
        {
            if (!File.Exists(App.JsonPath)) File.Create(App.JsonPath).Close();
            string text = File.ReadAllText(App.JsonPath);
            jsonData = JsonConvert.DeserializeObject<JsonData>(text);
            if (jsonData == null)
            {
                jsonData = new JsonData();
            }
        }

        public void Save()
        {
            File.WriteAllText(App.JsonPath, JsonConvert.SerializeObject(jsonData));
        }
    }
}
