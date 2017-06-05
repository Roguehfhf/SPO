using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using GeometricFigures;

namespace GeometricsFigureView
{
    public static class Serialization
    {
        private static readonly BinaryFormatter _formatter = new BinaryFormatter();

        public static void Serialize(string fileName, List<INterfaceFigures> file)
        {
            using (var fs = new FileStream(fileName, FileMode.OpenOrCreate))
            {
                _formatter.Serialize(fs, file);
            }
        }

        public static List<INterfaceFigures> Deserialize(string fileName)
        {
            using (var fs = new FileStream(fileName, FileMode.OpenOrCreate))
            {
                var file = (List<INterfaceFigures>)_formatter.Deserialize(fs);
                return file;
            }
        }
    }
}

