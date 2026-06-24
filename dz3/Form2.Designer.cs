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
        components = new System.ComponentModel.Container();
        progressBar1 = new System.Windows.Forms.ProgressBar();
        button1 = new System.Windows.Forms.Button();
        progressBar2 = new System.Windows.Forms.ProgressBar();
        progressBar3 = new System.Windows.Forms.ProgressBar();
        button2 = new System.Windows.Forms.Button();
        button3 = new System.Windows.Forms.Button();
        label1 = new System.Windows.Forms.Label();
        timer1 = new System.Windows.Forms.Timer(components);
        SuspendLayout();
        // 
        // progressBar1
        // 
        progressBar1.Location = new System.Drawing.Point(476, 135);
        progressBar1.Name = "progressBar1";
        progressBar1.Size = new System.Drawing.Size(100, 23);
        progressBar1.TabIndex = 0;
        progressBar1.Click += progressBar1_Click;
        // 
        // button1
        // 
        button1.Location = new System.Drawing.Point(395, 212);
        button1.Name = "button1";
        button1.Size = new System.Drawing.Size(75, 23);
        button1.TabIndex = 1;
        button1.Text = "button1";
        button1.UseVisualStyleBackColor = true;
        button1.Click += button1_Click;
        // 
        // progressBar2
        // 
        progressBar2.Location = new System.Drawing.Point(370, 135);
        progressBar2.Name = "progressBar2";
        progressBar2.Size = new System.Drawing.Size(100, 23);
        progressBar2.TabIndex = 2;
        // 
        // progressBar3
        // 
        progressBar3.Location = new System.Drawing.Point(582, 135);
        progressBar3.Name = "progressBar3";
        progressBar3.Size = new System.Drawing.Size(100, 23);
        progressBar3.TabIndex = 3;
        progressBar3.Click += progressBar3_Click;
        // 
        // button2
        // 
        button2.Location = new System.Drawing.Point(476, 212);
        button2.Name = "button2";
        button2.Size = new System.Drawing.Size(75, 23);
        button2.TabIndex = 4;
        button2.Text = "button2";
        button2.UseVisualStyleBackColor = true;
        button2.Click += button2_Click;
        // 
        // button3
        // 
        button3.Location = new System.Drawing.Point(582, 212);
        button3.Name = "button3";
        button3.Size = new System.Drawing.Size(75, 23);
        button3.TabIndex = 5;
        button3.Text = "button3";
        button3.UseVisualStyleBackColor = true;
        button3.Click += button3_Click;
        // 
        // label1
        // 
        label1.Location = new System.Drawing.Point(433, 281);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(168, 83);
        label1.TabIndex = 6;
        label1.Text = "label1";
        label1.Click += label1_Click;
        // 
        // timer1
        // 
        timer1.Tick += timer1_Tick;
        // 
        // Form2
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(800, 450);
        Controls.Add(label1);
        Controls.Add(button3);
        Controls.Add(button2);
        Controls.Add(progressBar3);
        Controls.Add(progressBar2);
        Controls.Add(button1);
        Controls.Add(progressBar1);
        Text = "Form2";
        ResumeLayout(false);
    }

    private System.Windows.Forms.Timer timer1;

    private System.Windows.Forms.Button button2;
    private System.Windows.Forms.Button button3;
    private System.Windows.Forms.Label label1;

    private System.Windows.Forms.ProgressBar progressBar2;
    private System.Windows.Forms.ProgressBar progressBar3;

    private System.Windows.Forms.ProgressBar progressBar1;
    private System.Windows.Forms.Button button1;

    #endregion
}