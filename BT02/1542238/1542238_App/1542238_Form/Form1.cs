using Microsoft.SqlServer.Dts.Runtime;
using System;
using System.IO;
using System.Windows.Forms;

namespace _1542238_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                string file = openFileDialog1.FileName;
                try
                {
                    string pkgLocation = @"C:\Users\ng.phuocloc\Documents\24HCB-PTHTTTHD\BT02\1542238\1542238\Import.dtsx";

                    Package pkg;
                    Microsoft.SqlServer.Dts.Runtime.Application app;
                    DTSExecResult pkgResults;
                    Variables vars;

                    app = new Microsoft.SqlServer.Dts.Runtime.Application();
                    pkg = app.LoadPackage(pkgLocation, null);
                    textBox1.Text = file;

                    vars = pkg.Variables;
                    vars["User::file_path"].Value = file;

                    pkgResults = pkg.Execute(null, vars, null, null, null);

                    if (pkgResults == DTSExecResult.Success)
                        MessageBox.Show("Import successfully");
                    else
                        MessageBox.Show("Import failed");
                }
                catch (IOException)
                {
                }
            }
        }
    }
}
