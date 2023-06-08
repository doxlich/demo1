using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace forms1
{
    internal class DbData
    {
        public const string UsersUL = "UserUL.txt";
        public const string UsersFL = "UserFL.txt";
        public const string Orders = "Orders.txt";
        public const string Sevices = "Sercices.txt";

        public static int LastOrderNumber => 99;
        public static string DirectoryPath => Path.GetDirectoryName(Application.ExecutablePath);
        public static string DbPath => Path.Combine(DirectoryPath, "DB");

        public static void SaveULUser(string data) => SaveUser(UsersUL, data);
        public static void SaveFLUser(string data) => SaveUser(UsersFL, data);

        public static void SaveUser(string fileName, string data)
        {
            var userFilePath = Path.Combine(DbPath, fileName);
            ValidateAndSave(userFilePath, data);
        }

        public static void SaveOrder(string data)
        {
            var ordersPath = Path.Combine(DbPath, Orders);
            ValidateAndSave(ordersPath, data);
        }

        public static List<string> ReadUsersUL()
        {
            var ordersPath = Path.Combine(DbPath, UsersUL);

            ValidatePath(ordersPath);

            var ordersData = File.ReadAllLines(ordersPath);
            return ordersData.ToList();
        }

        public static List<string> ReadUsersFL()
        {
            var ordersPath = Path.Combine(DbPath, UsersFL);

            ValidatePath(ordersPath);

            var ordersData = File.ReadAllLines(ordersPath);
            return ordersData.ToList();
        }
        public static List<string> ReadOders()
        {
            var ordersPath = Path.Combine(DbPath, Orders);

            ValidatePath(ordersPath);

            var ordersData = File.ReadAllLines(ordersPath);
            return ordersData.ToList();
        }

        private static void ValidateAndSave(string path, string data)
        {
            ValidatePath(path);
         
            File.AppendAllText(path, data + Environment.NewLine);
        }

        private static void ValidatePath(string path)
        {
            var dirPath = Path.GetDirectoryName(path);
            if (File.Exists(dirPath) == false)
                Directory.CreateDirectory(dirPath);

            if (File.Exists(path) == false)
            {
                var file = File.Create(path);
                file.Close();
            }
        }
    }
}
