using DocumentFormat.OpenXml.Office.CustomUI;
using System.Windows.Forms;
using Button = System.Windows.Forms.Button;

namespace ExcelData
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            
            button2 = new Button();
            listView2 = new ListView();
            SuspendLayout();
            // 
            // button
            // 
            button2.Location = new Point(63, 26);
            button2.Name = "button";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 0;
            button2.Text = "Save";
            button2.UseVisualStyleBackColor = true;
            // 
            // listView
            // 
            listView2.Location = new Point(41, 82);
            listView2.Name = "listView";
            listView2.Size = new Size(656, 320);
            listView2.TabIndex = 1;
            listView2.UseCompatibleStateImageBehavior = false;
            // 
            // button2
            // 

            // 
            // listView2
            // 

            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listView2);
            Controls.Add(button2);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion
        private Button button2;
        private ListView listView2;
    }
}
