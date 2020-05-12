﻿using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace IdentityModel.Internal
{
    internal static class InternalStringExtensions
    {
        [DebuggerStepThrough]
        public static string EnsureTrailingSlash(this string url)
        {
            if (url.EndsWith("/"))
            {
                return url;
            }
            return string.Concat(url, "/");
        }

        [DebuggerStepThrough]
        public static bool IsMissing(this string value)
        {
            return string.IsNullOrWhiteSpace(value);
        }

        [DebuggerStepThrough]
        public static bool IsPresent(this string value)
        {
            return !value.IsMissing();
        }

        [DebuggerStepThrough]
        public static string RemoveTrailingSlash(this string url)
        {
            if (url != null && url.EndsWith("/"))
            {
                url = url.Substring(0, url.Length - 1);
            }
            return url;
        }
    }
}