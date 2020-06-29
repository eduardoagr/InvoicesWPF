using Invoices.Model;

using SQLite;

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;

namespace Invoices.DatabaseHelpers {
    static class Operation {

        static string db_name = "Users.db";
        static string folder_path = Directory.GetCurrentDirectory();
        static string db_path = Path.Combine(folder_path, db_name);

        public static void Insert(User user) {

            using (SQLiteConnection connection = new SQLiteConnection(db_path)) {
                connection.CreateTable<User>();
                connection.Insert(user);
            }
        }

        public static ObservableCollection<User> Read() {

            List<User> userList = new List<User>();

            using (SQLiteConnection connection = new SQLiteConnection(db_path)) {
                connection.CreateTable<User>();
                userList = connection.Table<User>().ToList();
            }

            return new ObservableCollection<User>(userList); 
        }
    }
}