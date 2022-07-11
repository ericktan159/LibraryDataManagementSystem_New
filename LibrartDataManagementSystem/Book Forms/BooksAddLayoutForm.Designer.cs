﻿
namespace LibrartDataManagementSystem
{
    partial class BooksAddLayoutForm
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
            this.btn_BookAdd = new System.Windows.Forms.Button();
            this.txtBx_BookTitle_BookAdd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBx_BookAuthor_BookAdd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBx_BookGenre_BookAdd = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBx_BookPublisher_BookAdd = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtBx_NumOfQuantity_BookAdd = new System.Windows.Forms.TextBox();
            this.dtp_BookYearPublishe_BookAdd = new System.Windows.Forms.DateTimePicker();
            this.label_maxBooks = new System.Windows.Forms.Label();
            this.checkResetAfterSubmit = new System.Windows.Forms.CheckBox();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_BookAdd
            // 
            this.btn_BookAdd.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_BookAdd.BackColor = System.Drawing.Color.Aqua;
            this.btn_BookAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_BookAdd.Location = new System.Drawing.Point(374, 426);
            this.btn_BookAdd.Name = "btn_BookAdd";
            this.btn_BookAdd.Size = new System.Drawing.Size(141, 23);
            this.btn_BookAdd.TabIndex = 7;
            this.btn_BookAdd.Text = "Add Book";
            this.btn_BookAdd.UseVisualStyleBackColor = false;
            this.btn_BookAdd.Click += new System.EventHandler(this.btn_BookAdd_Click);
            // 
            // txtBx_BookTitle_BookAdd
            // 
            this.txtBx_BookTitle_BookAdd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBx_BookTitle_BookAdd.Location = new System.Drawing.Point(136, 80);
            this.txtBx_BookTitle_BookAdd.Name = "txtBx_BookTitle_BookAdd";
            this.txtBx_BookTitle_BookAdd.Size = new System.Drawing.Size(665, 20);
            this.txtBx_BookTitle_BookAdd.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Book Title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(398, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Add Book";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Author";
            // 
            // txtBx_BookAuthor_BookAdd
            // 
            this.txtBx_BookAuthor_BookAdd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBx_BookAuthor_BookAdd.Location = new System.Drawing.Point(136, 119);
            this.txtBx_BookAuthor_BookAdd.Name = "txtBx_BookAuthor_BookAdd";
            this.txtBx_BookAuthor_BookAdd.Size = new System.Drawing.Size(665, 20);
            this.txtBx_BookAuthor_BookAdd.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Genre";
            // 
            // txtBx_BookGenre_BookAdd
            // 
            this.txtBx_BookGenre_BookAdd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBx_BookGenre_BookAdd.Location = new System.Drawing.Point(136, 151);
            this.txtBx_BookGenre_BookAdd.Name = "txtBx_BookGenre_BookAdd";
            this.txtBx_BookGenre_BookAdd.Size = new System.Drawing.Size(665, 20);
            this.txtBx_BookGenre_BookAdd.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Year Published";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 228);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Publisher";
            // 
            // txtBx_BookPublisher_BookAdd
            // 
            this.txtBx_BookPublisher_BookAdd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBx_BookPublisher_BookAdd.Location = new System.Drawing.Point(136, 225);
            this.txtBx_BookPublisher_BookAdd.Name = "txtBx_BookPublisher_BookAdd";
            this.txtBx_BookPublisher_BookAdd.Size = new System.Drawing.Size(665, 20);
            this.txtBx_BookPublisher_BookAdd.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 265);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Number of Quantity";
            // 
            // txtBx_NumOfQuantity_BookAdd
            // 
            this.txtBx_NumOfQuantity_BookAdd.Location = new System.Drawing.Point(136, 262);
            this.txtBx_NumOfQuantity_BookAdd.Name = "txtBx_NumOfQuantity_BookAdd";
            this.txtBx_NumOfQuantity_BookAdd.Size = new System.Drawing.Size(54, 20);
            this.txtBx_NumOfQuantity_BookAdd.TabIndex = 6;
            this.txtBx_NumOfQuantity_BookAdd.Text = "1";
            this.txtBx_NumOfQuantity_BookAdd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBx_NumOfQuantity_BookAdd_KeyPress);
            this.txtBx_NumOfQuantity_BookAdd.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBx_NumOfQuantity_BookAdd_KeyUp);
            // 
            // dtp_BookYearPublishe_BookAdd
            // 
            this.dtp_BookYearPublishe_BookAdd.CalendarTrailingForeColor = System.Drawing.SystemColors.Highlight;
            this.dtp_BookYearPublishe_BookAdd.CustomFormat = "yyyy";
            this.dtp_BookYearPublishe_BookAdd.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtp_BookYearPublishe_BookAdd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_BookYearPublishe_BookAdd.Location = new System.Drawing.Point(136, 189);
            this.dtp_BookYearPublishe_BookAdd.Name = "dtp_BookYearPublishe_BookAdd";
            this.dtp_BookYearPublishe_BookAdd.ShowUpDown = true;
            this.dtp_BookYearPublishe_BookAdd.Size = new System.Drawing.Size(54, 20);
            this.dtp_BookYearPublishe_BookAdd.TabIndex = 4;
            // 
            // label_maxBooks
            // 
            this.label_maxBooks.AutoSize = true;
            this.label_maxBooks.ForeColor = System.Drawing.Color.Red;
            this.label_maxBooks.Location = new System.Drawing.Point(141, 285);
            this.label_maxBooks.Name = "label_maxBooks";
            this.label_maxBooks.Size = new System.Drawing.Size(41, 13);
            this.label_maxBooks.TabIndex = 16;
            this.label_maxBooks.Text = "99 max";
            // 
            // checkResetAfterSubmit
            // 
            this.checkResetAfterSubmit.AutoSize = true;
            this.checkResetAfterSubmit.Location = new System.Drawing.Point(24, 314);
            this.checkResetAfterSubmit.Name = "checkResetAfterSubmit";
            this.checkResetAfterSubmit.Size = new System.Drawing.Size(155, 17);
            this.checkResetAfterSubmit.TabIndex = 17;
            this.checkResetAfterSubmit.Text = "Clear inputs after submitting";
            this.checkResetAfterSubmit.UseVisualStyleBackColor = true;
            // 
            // btn_Reset
            // 
            this.btn_Reset.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Reset.BackColor = System.Drawing.Color.Red;
            this.btn_Reset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Reset.Location = new System.Drawing.Point(24, 426);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(95, 23);
            this.btn_Reset.TabIndex = 18;
            this.btn_Reset.Text = "Clear Inputs";
            this.btn_Reset.UseVisualStyleBackColor = false;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // BooksAddLayoutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(813, 461);
            this.Controls.Add(this.btn_Reset);
            this.Controls.Add(this.checkResetAfterSubmit);
            this.Controls.Add(this.label_maxBooks);
            this.Controls.Add(this.dtp_BookYearPublishe_BookAdd);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtBx_NumOfQuantity_BookAdd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtBx_BookPublisher_BookAdd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBx_BookGenre_BookAdd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBx_BookAuthor_BookAdd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBx_BookTitle_BookAdd);
            this.Controls.Add(this.btn_BookAdd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BooksAddLayoutForm";
            this.Text = "BooksAddLayoutForm";
            this.Load += new System.EventHandler(this.BooksAddLayoutForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_BookAdd;
        private System.Windows.Forms.TextBox txtBx_BookTitle_BookAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBx_BookAuthor_BookAdd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBx_BookGenre_BookAdd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBx_BookPublisher_BookAdd;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtBx_NumOfQuantity_BookAdd;
        private System.Windows.Forms.DateTimePicker dtp_BookYearPublishe_BookAdd;
        private System.Windows.Forms.Label label_maxBooks;
        private System.Windows.Forms.CheckBox checkResetAfterSubmit;
        private System.Windows.Forms.Button btn_Reset;
    }
}