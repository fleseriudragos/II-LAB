﻿using System.ComponentModel;

namespace Exercise1;

partial class Form2
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
        button1 = new Button();
        label1 = new Label();
        SuspendLayout();
        // 
        // button1
        // 
        button1.Location = new Point(82, 75);
        button1.Name = "button1";
        button1.Size = new Size(129, 71);
        button1.TabIndex = 0;
        button1.Text = "Exit";
        button1.UseVisualStyleBackColor = true;
        button1.Click += button1_Click;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(82, 33);
        label1.Name = "label1";
        label1.Size = new Size(41, 15);
        label1.TabIndex = 1;
        label1.Text = "Hello, ";
        //
        // // Form2
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(288, 158);
        Controls.Add(label1);
        Controls.Add(button1);
        Name = "Form2";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Form2";
        Load += Form2_Load;
        ResumeLayout(false);
        PerformLayout(); 
    }
    #endregion
    private Button button1;
    private Label label1;
}