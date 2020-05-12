using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace IdentityModel.Internal
{
    internal static class DictionaryExtensions
    {
        public static void AddOptional(this IDictionary<string, string> dictionary, string key, string value)
        {
            if (value.IsPresent())
            {
                if (dictionary.ContainsKey(key))
                {
                    throw new InvalidOperationException(string.Concat("Duplicate parameter: ", key));
                }
                dictionary.Add(key, value);
            }
        }

        public static void AddRequired(this IDictionary<string, string> dictionary, string key, string value, bool allowEmpty = false)
        {
            if (!value.IsPresent())
            {
                if (!allowEmpty)
                {
                    throw new ArgumentException("Parameter is required", key);
                }
                dictionary.Add(key, "");
                return;
            }
            if (dictionary.ContainsKey(key))
            {
                throw new InvalidOperationException(string.Concat("Duplicate parameter: ", key));
            }
            dictionary.Add(key, value);
        }
    }
}