﻿
namespace GameUtilityApp.Function.KartRider.Nickname_Tracker
{
    partial class Add_my_nickname
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_my_nickname));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonUserCheck = new System.Windows.Forms.Button();
            this.panelSaveCancel = new System.Windows.Forms.Panel();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panelSaveCancel.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(158, 21);
            this.textBox1.TabIndex = 0;
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // buttonUserCheck
            // 
            this.buttonUserCheck.Location = new System.Drawing.Point(176, 11);
            this.buttonUserCheck.Name = "buttonUserCheck";
            this.buttonUserCheck.Size = new System.Drawing.Size(93, 23);
            this.buttonUserCheck.TabIndex = 1;
            this.buttonUserCheck.Text = "User Check";
            this.buttonUserCheck.UseVisualStyleBackColor = true;
            this.buttonUserCheck.Click += new System.EventHandler(this.buttonUserCheck_Click);
            // 
            // panelSaveCancel
            // 
            this.panelSaveCancel.Controls.Add(this.buttonCancel);
            this.panelSaveCancel.Controls.Add(this.buttonSave);
            this.panelSaveCancel.Location = new System.Drawing.Point(60, 55);
            this.panelSaveCancel.Name = "panelSaveCancel";
            this.panelSaveCancel.Size = new System.Drawing.Size(162, 30);
            this.panelSaveCancel.TabIndex = 2;
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(84, 3);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 1;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Enabled = false;
            this.buttonSave.Location = new System.Drawing.Point(3, 3);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 0;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 14);
            this.label1.TabIndex = 3;
            this.label1.Text = "dd";
            this.label1.Visible = false;
            // 
            // Add_my_nickname
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(281, 97);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelSaveCancel);
            this.Controls.Add(this.buttonUserCheck);
            this.Controls.Add(this.textBox1);
            this.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Add_my_nickname";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add_my_nickname";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Add_my_nickname_FormClosing);
            this.Load += new System.EventHandler(this.Add_my_nickname_Load);
            this.panelSaveCancel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonUserCheck;
        private System.Windows.Forms.Panel panelSaveCancel;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label label1;
    }
}