﻿using System;
using System.Security.Cryptography;
using System.Text;

// CREDITS: Loki
namespace Destiny.Security
{
    public static class HashGenerator
    {
        public static string GenerateMD5(string input = null)
        {
            if (input == null)
            {
                input = Destiny.Random.Next().ToString();
            }

            return BitConverter.ToString(new MD5CryptoServiceProvider().ComputeHash(Encoding.ASCII.GetBytes(input))).Replace("-", "").ToLower();
        }
    }
}