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
        pictureBox1 = new System.Windows.Forms.PictureBox();
        trackBar1 = new System.Windows.Forms.TrackBar();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
        ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
        SuspendLayout();
        // 
        // pictureBox1
        // 
        pictureBox1.Location = new System.Drawing.Point(325, 182);
        pictureBox1.Name = "pictureBox1";
        pictureBox1.Size = new System.Drawing.Size(138, 147);
        pictureBox1.TabIndex = 0;
        pictureBox1.TabStop = false;
        // 
        // trackBar1
        // 
        trackBar1.Location = new System.Drawing.Point(325, 100);
        trackBar1.Name = "trackBar1";
        trackBar1.Size = new System.Drawing.Size(104, 45);
        trackBar1.TabIndex = 1;
        // 
        // Form2
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(800, 450);
        Controls.Add(trackBar1);
        Controls.Add(pictureBox1);
        Text = "Form2";
        ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
        ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.TrackBar trackBar1;

    private System.Windows.Forms.PictureBox pictureBox1;

    #endregion
}