﻿using System;
using System.Text.RegularExpressions;
using Humanizer;

namespace LinqAn.Google.Generator.Core
{
    public static class ColumnExtensions
    {
        public static string ToClassName(this Column column)
        {
            var id = column.Id;
            var className = GetClassName(id);
            return className;
        }

        public static string GetClassName(this string id)
        {
            var className = id.Replace("ga:", "").Pascalize().Replace("ID", "Id");
            var match = Regex.Match(className, "^[0-9]+");
            if (!match.Success) return className;
            var number = match.ToString();
            var numberAsInt = Convert.ToInt32(number);
            var replacement = numberAsInt.ToWords().Dehumanize().Pascalize();
            var remaining = className.Replace(number, "").Pascalize();
            className = replacement + remaining;
            return className;
        }
    }
}