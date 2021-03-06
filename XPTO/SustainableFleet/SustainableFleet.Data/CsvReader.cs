﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace SustainableFleet.Cmd
{
    public class CsvReader
    {
        public static IEnumerable<string[]> Reader(string filePath)          
        {
            List<string> rowList = null;        

            using (StreamReader sr = new StreamReader(filePath, Encoding.UTF7))
            {
                string content = sr.ReadToEnd();
                rowList = new List<string>(
                    content.Split("\n")
                );
            }
            for (int i = 1; i < rowList.Count-1; i++)
            {
                var value = rowList[i];

                var sanitized = Sanitize(value);

                var splited = sanitized.Split(";");

                yield return splited;
            }
        }

        private static string Sanitize( string value)
        {
            var replaced = value;

            MatchCollection col = Regex.Matches(replaced, "\\\"(.*?)\\\"");

            for (int i = 0; i < col.Count; i++)
                replaced = replaced.Replace(col[i].ToString(), col[i].ToString()
                    .Replace(";", "--")
                    .Replace("\"", ""));

            return replaced.Replace("\r", "").Replace("'", "");
        }
    }
}
