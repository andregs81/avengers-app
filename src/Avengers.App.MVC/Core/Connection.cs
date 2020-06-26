using System;
using System.IO;

namespace Avengers.App.MVC.Core
{
    public static class Connection
    {
        public static string ReadFromFile()
        {
            return File.ReadAllText(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "conn.txt"));
        }
    }
}
