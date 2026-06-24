using System.Drawing;
using System.Windows.Forms;

namespace WinFormsApp1;

partial class Form1
{
    private System.ComponentModel.IContainer components = null;

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
        listBox1 = new System.Windows.Forms.ListBox();
        textBox1 = new System.Windows.Forms.TextBox();
        SuspendLayout();
        // 
        // listBox1
        // 
        listBox1.FormattingEnabled = true;
        listBox1.Location = new System.Drawing.Point(305, 92);
        listBox1.Name = "listBox1";
        listBox1.Size = new System.Drawing.Size(120, 94);
        listBox1.TabIndex = 0;
        
        // 
        // textBox1
        // 
        textBox1.Location = new System.Drawing.Point(305, 43);
        textBox1.Name = "textBox1";
        textBox1.Size = new System.Drawing.Size(100, 23);
        textBox1.TabIndex = 1;
        // 
        // Form1
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.SystemColors.GradientActiveCaption;
        ClientSize = new System.Drawing.Size(800, 450);
        Controls.Add(textBox1);
        Controls.Add(listBox1);
        Text = "Form1";
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.TextBox textBox1;

    private System.Windows.Forms.ListBox listBox1;

    #endregion
}