using System;
namespace Indexer
{
    public class StringDataStore
    {
        private string[] strArr = new string[10];
        public string this[int index]
        {
            get
            {
                if (index < 0 || index >= strArr.Length)
                {
                    throw new ArgumentException($"Index out of range exception");
                }
                return strArr[index];
            }
            set
            {
                if (index < 0 || index >= strArr.Length)
                    throw new ArgumentException($"Index out of range exception");

                strArr[index] = value;
            }
        }

        public string this[string name]
        {
            get
            {
                foreach (string str in strArr)
                {
                    if (!string.IsNullOrEmpty(str) && str.ToLower() == name.ToLower())
                        return str;
                }

                return null;
            }
        }
    }
}