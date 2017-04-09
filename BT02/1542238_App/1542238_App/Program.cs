using System;
using Microsoft.SqlServer.Dts.Runtime;

namespace _1542238_App
{
    class Program
    {
        static void Main(string[] args)
        {
            string pkgLocation = @"C:\Users\ng.phuocloc\Documents\24HCB-PTHTTTHD\BT02\1542238\1542238\Import.dtsx";

            Package pkg;
            Application app;
            DTSExecResult pkgResults;
            Variables vars;

            //string variableName = string.Empty;
            //variableName = "User::FolderPath";


            app = new Application();
            pkg = app.LoadPackage(pkgLocation, null);

            vars = pkg.Variables;
            string filePath = @"C:\Users\ng.phuocloc\Documents\24HCB-PTHTTTHD\BT02\1542238\COW_INFO\Cow_info1.xls";
            vars["User::file_path"].Value = "C:\\Users\\ng.phuocloc\\Documents\\24HCB-PTHTTTHD\\BT02\\1542238\\COW_INFO\\Cow_info1.xls"; ;
            //var file = pkg.Connections.Add("EXCEL");
            //file.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source= C:\Users\ng.phuocloc\Documents\24HCB-PTHTTTHD\BT02\1542238\COW_INFO\Cow_info1.xls;Extended Properties='EXCEL 8.0; HDR = YES';";

            pkgResults = pkg.Execute(null, vars, null, null, null);

            if (pkgResults == DTSExecResult.Success)
                Console.WriteLine("Package ran successfully");
            else
                Console.WriteLine("Package failed");
        }
    }
}
