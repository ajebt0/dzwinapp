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
        components = new System.ComponentModel.Container();
        label1 = new System.Windows.Forms.Label();
        timer1 = new System.Windows.Forms.Timer(components);
        SuspendLayout();
        // 
        // label1
        // 
        label1.Location = new System.Drawing.Point(314, 158);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(183, 140);
        label1.TabIndex = 0;
        label1.Text = "label1";
        label1.Click += label1_Click;
        // 
        // timer1
        // 
        timer1.Tick += timer1_Tick;
        // 
        // Form1
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.SystemColors.GradientActiveCaption;
        ClientSize = new System.Drawing.Size(800, 450);
        Controls.Add(label1);
        Text = "Form1";
        ResumeLayout(false);
    }

    private System.Windows.Forms.Timer timer1;

    private System.Windows.Forms.Label label1;

    #endregion
}