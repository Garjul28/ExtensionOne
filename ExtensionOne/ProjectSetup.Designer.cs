namespace ExtensionOne
{
    partial class ProjectSetup
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.browse_costdata = new System.Windows.Forms.Button();
            this.assemblycode_filepath = new System.Windows.Forms.RichTextBox();
            this.assemblycode_location = new System.Windows.Forms.Button();
            this.costdata_filepath = new System.Windows.Forms.RichTextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.ok_button = new System.Windows.Forms.Button();
            this.cancel_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // browse_costdata
            // 
            this.browse_costdata.Location = new System.Drawing.Point(25, 138);
            this.browse_costdata.Name = "browse_costdata";
            this.browse_costdata.Size = new System.Drawing.Size(220, 55);
            this.browse_costdata.TabIndex = 4;
            this.browse_costdata.Text = "Browse";
            this.browse_costdata.UseVisualStyleBackColor = true;
            this.browse_costdata.Click += new System.EventHandler(this.browse_costdata_Click_1);
            // 
            // assemblycode_filepath
            // 
            this.assemblycode_filepath.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.assemblycode_filepath.Font = new System.Drawing.Font("Revit_HEB_DWG", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.assemblycode_filepath.Location = new System.Drawing.Point(245, 580);
            this.assemblycode_filepath.Multiline = false;
            this.assemblycode_filepath.Name = "assemblycode_filepath";
            this.assemblycode_filepath.RightMargin = 3;
            this.assemblycode_filepath.Size = new System.Drawing.Size(770, 55);
            this.assemblycode_filepath.TabIndex = 5;
            this.assemblycode_filepath.Text = "";
            this.assemblycode_filepath.WordWrap = false;
            // 
            // assemblycode_location
            // 
            this.assemblycode_location.Location = new System.Drawing.Point(25, 580);
            this.assemblycode_location.Name = "assemblycode_location";
            this.assemblycode_location.Size = new System.Drawing.Size(220, 55);
            this.assemblycode_location.TabIndex = 6;
            this.assemblycode_location.Text = "Browse";
            this.assemblycode_location.UseVisualStyleBackColor = true;
            this.assemblycode_location.Click += new System.EventHandler(this.browse_assemblycode);
            // 
            // costdata_filepath
            // 
            this.costdata_filepath.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.costdata_filepath.Font = new System.Drawing.Font("Revit_HEB_DWG", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.costdata_filepath.Location = new System.Drawing.Point(245, 138);
            this.costdata_filepath.Multiline = false;
            this.costdata_filepath.Name = "costdata_filepath";
            this.costdata_filepath.RightMargin = 3;
            this.costdata_filepath.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.costdata_filepath.Size = new System.Drawing.Size(770, 55);
            this.costdata_filepath.TabIndex = 7;
            this.costdata_filepath.Text = "";
            this.costdata_filepath.WordWrap = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Revit_HEB_DWG", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(25, 519);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(990, 55);
            this.textBox1.TabIndex = 8;
            this.textBox1.Text = "A tab delimited file containing the assembly code system  based on the selected c" +
    "ost database template will be automatically created. Please select the file loca" +
    "tion to save:";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Revit_HEB_DWG", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(25, 88);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(469, 34);
            this.textBox2.TabIndex = 9;
            this.textBox2.Text = "Choose Custom Cost Database Template:";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("Revit_HEB_DWG", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(25, 28);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(503, 34);
            this.textBox3.TabIndex = 10;
            this.textBox3.Text = "Project Setup ==> Select Cost Template";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("Revit_HEB_DWG", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(245, 217);
            this.richTextBox1.Multiline = false;
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.RightMargin = 3;
            this.richTextBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.richTextBox1.Size = new System.Drawing.Size(770, 55);
            this.richTextBox1.TabIndex = 12;
            this.richTextBox1.Text = "";
            this.richTextBox1.WordWrap = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(25, 217);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(220, 55);
            this.button1.TabIndex = 11;
            this.button1.Text = "Select Sheet";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // richTextBox2
            // 
            this.richTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox2.Font = new System.Drawing.Font("Revit_HEB_DWG", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox2.Location = new System.Drawing.Point(245, 299);
            this.richTextBox2.Multiline = false;
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.RightMargin = 3;
            this.richTextBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.richTextBox2.Size = new System.Drawing.Size(770, 55);
            this.richTextBox2.TabIndex = 14;
            this.richTextBox2.Text = "";
            this.richTextBox2.WordWrap = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(25, 299);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(220, 55);
            this.button2.TabIndex = 13;
            this.button2.Text = "Select Range";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Font = new System.Drawing.Font("Revit_HEB_DWG", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(25, 397);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(469, 34);
            this.textBox4.TabIndex = 15;
            this.textBox4.Text = "Download Recommended Template.";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(867, 381);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(148, 55);
            this.button3.TabIndex = 16;
            this.button3.Text = "Download";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Font = new System.Drawing.Font("Revit_HEB_DWG", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(25, 731);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(758, 55);
            this.textBox5.TabIndex = 17;
            this.textBox5.Text = "Created tab delimited file (assembly code file) will be directly imported into cu" +
    "rrent Revit Document.";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(919, 731);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(96, 55);
            this.button4.TabIndex = 18;
            this.button4.Text = "No";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(817, 731);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(96, 55);
            this.button5.TabIndex = 19;
            this.button5.Text = "Yes";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // ok_button
            // 
            this.ok_button.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.ok_button.Location = new System.Drawing.Point(867, 1000);
            this.ok_button.Name = "ok_button";
            this.ok_button.Size = new System.Drawing.Size(148, 55);
            this.ok_button.TabIndex = 20;
            this.ok_button.Text = "OK";
            this.ok_button.UseVisualStyleBackColor = true;
            this.ok_button.Click += new System.EventHandler(this.ok_button_Click);
            // 
            // cancel_button
            // 
            this.cancel_button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancel_button.Location = new System.Drawing.Point(713, 1000);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(148, 55);
            this.cancel_button.TabIndex = 21;
            this.cancel_button.Text = "Cancel";
            this.cancel_button.UseVisualStyleBackColor = true;
            this.cancel_button.Click += new System.EventHandler(this.cancel_button_Click);
            // 
            // ProjectSetup
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1044, 1099);
            this.Controls.Add(this.cancel_button);
            this.Controls.Add(this.ok_button);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.costdata_filepath);
            this.Controls.Add(this.assemblycode_location);
            this.Controls.Add(this.assemblycode_filepath);
            this.Controls.Add(this.browse_costdata);
            this.Font = new System.Drawing.Font("Revit_HEB_DWG", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "ProjectSetup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "COST DECK - ABSTRACT COST ANALYSIS V.0.0.0 (ddp assg prototype)";
            this.Load += new System.EventHandler(this.CreateForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button browse_costdata;
        private System.Windows.Forms.RichTextBox assemblycode_filepath;
        private System.Windows.Forms.Button assemblycode_location;
        private System.Windows.Forms.RichTextBox costdata_filepath;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button ok_button;
        private System.Windows.Forms.Button cancel_button;
    }
}