using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testVirginia
{
    static class VirginiaConveter
    {
        #region 维吉尼亚密码加密
        public static void ENCRYPT(string context, string key)
        {
            context = context.ToUpper();
            key = key.ToUpper();
            context = context.Replace(" ", "");
            key = key.Replace(" ", "");
            char[][] referenceMatrix = new char[26][];
            ArrayList contextArr = new ArrayList();
            ArrayList keyArr = new ArrayList();
            ArrayList encryptInfoArr = new ArrayList();
            for (int i = 0; i < 26; i++)
            {
                int offset = i;
                referenceMatrix[i] = new char[26];
                for (int j = 0; j < 26; j++)
                {
                    if (65 + offset > 90)
                    {
                        offset = 0;
                    }
                    referenceMatrix[i][j] = (char)(65 + offset);
                    offset++;
                }
            }

            foreach (var item in referenceMatrix)
            {
                foreach (var chr in item)
                {
                    Console.Write(chr);
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            foreach (char chr in context)
            {
                contextArr.Add(chr);
            }

            foreach (char item in contextArr)
            {
                Console.Write(item);
            }
            Console.WriteLine();

            int size = 0;
            for (int i = 0; i < contextArr.Count; i++)
            {
                if (size == key.Length)
                {
                    size = 0;
                }
                keyArr.Add(key[size]);
                size++;
            }

            foreach (char item in keyArr)
            {
                Console.Write(item);
            }
            Console.WriteLine();

            ArrayList x = new ArrayList();
            char xChr;
            ArrayList y = new ArrayList();
            char yChr;
            foreach (char chr in contextArr)
            {
                yChr = chr;
                for (int i = 0; i < 26; i++)
                {
                    if (yChr.Equals(Convert.ToChar(65 + i)))
                    {
                        y.Add(i);
                        break;
                    }
                }
            }
            foreach (char chr in keyArr)
            {
                xChr = chr;
                for (int i = 0; i < 26; i++)
                {
                    if (xChr.Equals(Convert.ToChar(65 + i)))
                    {
                        x.Add(i);
                        break;
                    }
                }
            }

            for (int i = 0; i < context.Length; i++)
            {
                int y_p = (int)y[i];
                int x_p = (int)x[i];
                encryptInfoArr.Add(referenceMatrix[y_p][x_p]);
            }

            foreach (char item in encryptInfoArr)
            {
                Console.Write(item);
            }
            Console.WriteLine();
            Console.Read();
        }
        #endregion

        #region 维吉尼亚密码解密
        public static void DECRYPT(string encryptInfo, string key)
        {
            encryptInfo = encryptInfo.ToUpper();
            key = key.ToUpper();
            encryptInfo = encryptInfo.Replace(" ", "");
            key = key.Replace(" ", "");
            char[][] referenceMatrix = new char[26][];
            ArrayList encryptInfoArr = new ArrayList();
            ArrayList keyArr = new ArrayList();
            ArrayList contextArr = new ArrayList();
            ArrayList x = new ArrayList();
            ArrayList y = new ArrayList();

            for (int i = 0; i < 26; i++)
            {
                int offset = i;
                referenceMatrix[i] = new char[26];
                for (int j = 0; j < 26; j++)
                {
                    if (65 + offset > 90)
                    {
                        offset = 0;
                    }
                    referenceMatrix[i][j] = (char)(65 + offset);
                    offset++;
                }
            }

            foreach (var item in referenceMatrix)
            {
                foreach (var chr in item)
                {
                    Console.Write(chr);
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            foreach (char chr in encryptInfo)
            {
                encryptInfoArr.Add(chr);
            }
            foreach (char item in encryptInfoArr)
            {
                Console.Write(item);
            }
            Console.WriteLine();

            int size = 0;
            for (int i = 0; i < encryptInfoArr.Count; i++)
            {
                if (size == key.Length)
                {
                    size = 0;
                }
                keyArr.Add(key[size]);
                size++;
            }
            foreach (char item in keyArr)
            {
                Console.Write(item);
            }
            Console.WriteLine();

            for (int i = 0; i < encryptInfoArr.Count; i++)
            {
                int chrPos = Convert.ToInt32(keyArr[i]) - 65;
                for (int j = 0; j < 26; j++)
                {
                    if (encryptInfoArr[i].Equals(referenceMatrix[j][chrPos]))
                    {
                        y.Add(j);
                        break;
                    }
                }
            }

            for (int i = 0; i < encryptInfoArr.Count; i++)
            {
                contextArr.Add((char)(65 + (int)y[i]));
            }

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine();
            Console.WriteLine("decryptResult:");
            Console.WriteLine();
            foreach (var chr in contextArr)
            {
                Console.Write(chr);
            }
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine();
            Console.Read();
        }
        #endregion
    }
}
