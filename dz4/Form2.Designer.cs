using System.ComponentModel;

namespace WinFormsApp1;

partial class Form2
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

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
        label1 = new System.Windows.Forms.Label();
        label2 = new System.Windows.Forms.Label();
        label3 = new System.Windows.Forms.Label();
        button1 = new System.Windows.Forms.Button();
        button2 = new System.Windows.Forms.Button();
        SuspendLayout();
        // 
        // label1
        // 
        label1.Location = new System.Drawing.Point(111, 115);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(157, 156);
        label1.TabIndex = 0;
        label1.Text = "label1";
        label1.Click += label1_Click;
        // 
        // label2
        // 
        label2.Location = new System.Drawing.Point(311, 124);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(161, 169);
        label2.TabIndex = 1;
        label2.Text = "label2";
        label2.Click += label2_Click;
        // 
        // label3
        // 
        label3.Location = new System.Drawing.Point(536, 124);
        label3.Name = "label3";
        label3.Size = new System.Drawing.Size(159, 169);
        label3.TabIndex = 2;
        label3.Text = "label3";
        label3.Click += label3_Click;
        // 
        // button1
        // 
        button1.Location = new System.Drawing.Point(353, 309);
        button1.Name = "button1";
        button1.Size = new System.Drawing.Size(75, 23);
        button1.TabIndex = 3;
        button1.Text = "button1";
        button1.UseVisualStyleBackColor = true;
        button1.Click += button1_Click;
        // 
        // button2
        // 
        button2.Location = new System.Drawing.Point(539, 291);
        button2.Name = "button2";
        button2.Size = new System.Drawing.Size(75, 23);
        button2.TabIndex = 4;
        button2.Text = "button2";
        button2.UseVisualStyleBackColor = true;
        button2.Click += button2_Click;
        // 
        // Form2
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(800, 450);
        Controls.Add(button2);
        Controls.Add(button1);
        Controls.Add(label3);
        Controls.Add(label2);
        Controls.Add(label1);
        Text = "Form2";
        ResumeLayout(false);
    }

    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Button button2;

    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;

    private System.Windows.Forms.Label label1;

    #endregion
}