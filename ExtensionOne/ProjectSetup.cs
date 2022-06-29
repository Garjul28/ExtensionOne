using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using System.IO;

namespace ExtensionOne
{
    public partial class ProjectSetup : System.Windows.Forms.Form
    {
        Document doc;
        public ProjectSetup(Document doc)
        {
            InitializeComponent();
            this.doc = doc;
        }

        private void wall_count_Click(object sender, EventArgs e)
        {
            ICollection<Element> walls =
                new FilteredElementCollector(doc, doc.ActiveView.Id).OfCategory(BuiltInCategory.OST_Walls).ToElements();

            TaskDialog.Show("Wall Count", walls.Count.ToString() + "walls");
        }

        private void CreateForm_Load(object sender, EventArgs e)
        {

        }

        private void browse_costdata_Click_1(object sender, EventArgs e)
        {


            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "excel files (*.xls; *.xlsx)| *.xls; *.xlsx"; 

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                //display the filepath of costdata file in textbox
                costdata_filepath.Text = ofd.FileName;
            }
        }

        private void browse_assemblycode(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.Description = "Project Setup - Choose the folder to save the assembly code file.";

            //display the folder to save assembly code file in textbox. default file name would be given automatically. 
            if (fbd.ShowDialog() == DialogResult.OK)
                assemblycode_filepath.Text = fbd.SelectedPath;
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            cancel_button.DialogResult = DialogResult.Cancel;
            Debug.WriteLine("Cancelled.");
        }

        private void ok_button_Click(object sender, EventArgs e)
        {
            ok_button.DialogResult = DialogResult.OK;
            Debug.WriteLine("Project Setting successfully saved. Assembly Code file has been added. Continue to assign assembly codes to model elements.");
            Close();

            return;
        }
    }
}
