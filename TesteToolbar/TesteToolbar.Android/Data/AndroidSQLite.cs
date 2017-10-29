using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using SQLite.Net;
using TesteToolbar.DataService;
using System.IO;
using SQLite.Net.Platform.XamarinAndroid;
using TesteToolbar.Droid.Data;
using System.Runtime.CompilerServices;
using Xamarin.Forms;

[assembly: Xamarin.Forms.Dependency(typeof(AndroidSQLite))]
namespace TesteToolbar.Droid.Data
{
    public class AndroidSQLite : ISQLite
    {
        public SQLiteConnection GetConnection()
        {
            var databaseName = "DBUSUARIOSERVICO.db3";
            var documentsPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            var combinePath = Path.Combine(documentsPath, databaseName);

            var connection = new SQLiteConnection(new SQLitePlatformAndroid(), combinePath);
            return connection;
        }
    }
}