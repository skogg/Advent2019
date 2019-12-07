using System;
using System.Collections.Generic;
using System.IO;

namespace Common.Readers
{
    public static class FileReader
    {
        public static List<T> GetList<T>(string path)
        {
            var result = new List<T>();
            using (var reader = new StreamReader(path))
            {

                var line = reader.ReadLine();
                while (line != null)
                {
                    result.Add(line.ChangeType<T>());
                    line = reader.ReadLine();
                }
            }

            return result;
        }

        static T ChangeType<T>(this object obj)
        {
            return (T)Convert.ChangeType(obj, typeof(T));
        }
    }
}
