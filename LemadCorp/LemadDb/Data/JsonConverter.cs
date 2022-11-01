using LemadDb.Domain.Entities;
using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemadDb.Data
{
    public static class JsonConverter
    {
        static public Dictionary<int, int> jsonToIntDictionary(string json)
        {
            Dictionary<int, int> dictionary = new Dictionary<int, int>();
            string list = "";

            foreach (char item in json)
            {
                if (item != '\\' && item != 34)
                {
                    list += item;
                }
            }

            list = list.Replace("},", "};");
            string[] newList = list.Split(';');

            foreach (var item in newList) {
                int indexId = item.IndexOf("id:") + 3;
                int indexComa = item.IndexOf(',');
                int indexContract = item.IndexOf("contract:") + 9;
                int indexEnd = item.IndexOf('}');

                int id = int.Parse(item.Substring(indexId, indexComa - indexId));
                int contract = int.Parse(item.Substring(indexContract, indexEnd - indexContract));

                dictionary.Add(id, contract);
            }

            return dictionary;
        }
    }
}
