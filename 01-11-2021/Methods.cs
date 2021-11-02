using System;
using System.Collections.Generic;
using System.Text;

namespace _01_11_2021
{
    class Methods
    {
        #region Assignment-1 Method
        public void oneSpace(string text)
        {
            while (text.IndexOf("  ") != -1)
            {
                text = text.Replace("  ", " ");
            }

            Console.WriteLine(text);

            //Console.WriteLine(newString);

        }
        #endregion

        #region Assignment-2 Method
        public bool checkString(string text)
        {
            bool check1 = false;
            bool check2 = false;
            bool check3 = false;
            foreach (var item1 in text)
            {
                if (Char.IsUpper(item1) == true)
                {
                    check1 = true;
                    break;
                }

                else
                    check1 = false;
            }

            foreach (var item2 in text)
            {
                if (Char.IsLetter(item2) == true)
                {
                    check2 = true;
                    break;
                }

                else
                    check2 = false;
            }

            foreach (var item3 in text)
            {
                if (Char.IsDigit(item3) == true)
                {
                    check3 = true;
                    break;
                }

                else
                    check3 = false;
            }

            if (check1 == true && check2 == true && check3 == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion

        #region Assignment-3 Method
        public int[] addArray(int[] array, int number)
        {
            Array.Resize(ref array, array.Length + 1);
            array[array.Length - 1] = number;

            return array;
        }
        #endregion

        #region Assignment-4 Method
        public string[] stringArray(string text, string seperator)
        {
            while (text.IndexOf("  ") != -1)
            {
                text = text.Replace("  ", " ");
            }

            return text.Split(seperator);
        }
        #endregion

        #region Assignment-5 Method
        public string[] LastStringArray()
        {
            string[] texts = { "p201 proqramlasdirma oyrenir", "elnur is coni" };
            string[] lastStringArr = new string[0];

            foreach (var item in texts)
            {
                string[] wordItem = item.Split(" ");
                string lastWord = wordItem[wordItem.Length - 1];
                Array.Resize(ref lastStringArr, lastStringArr.Length + 1);
                lastStringArr[lastStringArr.Length - 1] = lastWord;
            }

            return lastStringArr;
        }
        #endregion
    }
}
