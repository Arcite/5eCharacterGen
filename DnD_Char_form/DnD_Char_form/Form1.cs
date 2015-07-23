using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DnD_Char_form
{
   public partial class Form1 : Form
   {
      public Form1()
      {
         InitializeComponent();
      }

      public static string GetTextBoxInput(string sPrompt, string sCaption)
      {
         Form fPrompt         = new Form();
         Label textLabel      = new Label()       {   Left = 50, Top = 20, 
                                                      Text = sPrompt                   };
         TextBox textBox      = new TextBox       {   Left = 50, Top = 50,
                                                      Width = 400                      };
         Button confirmation  = new Button()       {  Text = "Ok", Left = 350, 
                                                      Width = 100, Top = 70, 
                                                      DialogResult = DialogResult.OK   };

         fPrompt.Width           = 500;
         fPrompt.Height          = 150;
         fPrompt.FormBorderStyle = FormBorderStyle.FixedDialog;
         fPrompt.Text            = sCaption;
         fPrompt.StartPosition   = FormStartPosition.CenterScreen;

         confirmation.Click += (sender, e) => { fPrompt.Close(); };

         fPrompt.Controls.Add(textBox);
         fPrompt.Controls.Add(confirmation);
         fPrompt.Controls.Add(textLabel);
         fPrompt.AcceptButton = confirmation;

         return fPrompt.ShowDialog() == DialogResult.OK ? textBox.Text : "";
      }

      private void Form1_Load(object sender, EventArgs e)
      {

      }
   }
}
