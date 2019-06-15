namespace SqlMapperLibrary
{
    partial class Form1
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
            this.txt_connection = new System.Windows.Forms.TextBox();
            this.lbl_Connection = new System.Windows.Forms.Label();
            this.btn_connect = new System.Windows.Forms.Button();
            this.cmb_table = new System.Windows.Forms.ComboBox();
            this.cmb_view = new System.Windows.Forms.ComboBox();
            this.cmb_sp = new System.Windows.Forms.ComboBox();
            this.lbl_view = new System.Windows.Forms.Label();
            this.lbl_sp = new System.Windows.Forms.Label();
            this.lbl_table = new System.Windows.Forms.Label();
            this.btn_Generate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_connection
            // 
            this.txt_connection.Location = new System.Drawing.Point(12, 23);
            this.txt_connection.Multiline = true;
            this.txt_connection.Name = "txt_connection";
            this.txt_connection.Size = new System.Drawing.Size(379, 42);
            this.txt_connection.TabIndex = 0;
            // 
            // lbl_Connection
            // 
            this.lbl_Connection.AutoSize = true;
            this.lbl_Connection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lbl_Connection.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Connection.Location = new System.Drawing.Point(12, 7);
            this.lbl_Connection.Name = "lbl_Connection";
            this.lbl_Connection.Size = new System.Drawing.Size(108, 13);
            this.lbl_Connection.TabIndex = 1;
            this.lbl_Connection.Text = "Connection String";
            // 
            // btn_connect
            // 
            this.btn_connect.BackColor = System.Drawing.Color.Red;
            this.btn_connect.Location = new System.Drawing.Point(397, 23);
            this.btn_connect.Name = "btn_connect";
            this.btn_connect.Size = new System.Drawing.Size(66, 42);
            this.btn_connect.TabIndex = 3;
            this.btn_connect.Text = "Coonect";
            this.btn_connect.UseVisualStyleBackColor = false;
            this.btn_connect.Click += new System.EventHandler(this.btn_connect_Click);
            // 
            // cmb_table
            // 
            this.cmb_table.FormattingEnabled = true;
            this.cmb_table.Location = new System.Drawing.Point(469, 44);
            this.cmb_table.Name = "cmb_table";
            this.cmb_table.Size = new System.Drawing.Size(170, 21);
            this.cmb_table.TabIndex = 4;
            // 
            // cmb_view
            // 
            this.cmb_view.FormattingEnabled = true;
            this.cmb_view.Location = new System.Drawing.Point(867, 44);
            this.cmb_view.Name = "cmb_view";
            this.cmb_view.Size = new System.Drawing.Size(180, 21);
            this.cmb_view.TabIndex = 5;
            // 
            // cmb_sp
            // 
            this.cmb_sp.FormattingEnabled = true;
            this.cmb_sp.Location = new System.Drawing.Point(658, 44);
            this.cmb_sp.Name = "cmb_sp";
            this.cmb_sp.Size = new System.Drawing.Size(188, 21);
            this.cmb_sp.TabIndex = 6;
            // 
            // lbl_view
            // 
            this.lbl_view.AutoSize = true;
            this.lbl_view.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lbl_view.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_view.Location = new System.Drawing.Point(864, 23);
            this.lbl_view.Name = "lbl_view";
            this.lbl_view.Size = new System.Drawing.Size(74, 13);
            this.lbl_view.TabIndex = 7;
            this.lbl_view.Text = "Select View";
            // 
            // lbl_sp
            // 
            this.lbl_sp.AutoSize = true;
            this.lbl_sp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lbl_sp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sp.Location = new System.Drawing.Point(655, 26);
            this.lbl_sp.Name = "lbl_sp";
            this.lbl_sp.Size = new System.Drawing.Size(63, 13);
            this.lbl_sp.TabIndex = 8;
            this.lbl_sp.Text = "Select SP";
            // 
            // lbl_table
            // 
            this.lbl_table.AutoSize = true;
            this.lbl_table.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lbl_table.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_table.Location = new System.Drawing.Point(469, 26);
            this.lbl_table.Name = "lbl_table";
            this.lbl_table.Size = new System.Drawing.Size(115, 13);
            this.lbl_table.TabIndex = 9;
            this.lbl_table.Text = "Select Table Name";
            // 
            // btn_Generate
            // 
            this.btn_Generate.BackColor = System.Drawing.Color.Lime;
            this.btn_Generate.Location = new System.Drawing.Point(1053, 32);
            this.btn_Generate.Name = "btn_Generate";
            this.btn_Generate.Size = new System.Drawing.Size(76, 42);
            this.btn_Generate.TabIndex = 10;
            this.btn_Generate.Text = "Generte";
            this.btn_Generate.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1160, 503);
            this.Controls.Add(this.btn_Generate);
            this.Controls.Add(this.lbl_table);
            this.Controls.Add(this.lbl_sp);
            this.Controls.Add(this.lbl_view);
            this.Controls.Add(this.cmb_sp);
            this.Controls.Add(this.cmb_view);
            this.Controls.Add(this.cmb_table);
            this.Controls.Add(this.btn_connect);
            this.Controls.Add(this.lbl_Connection);
            this.Controls.Add(this.txt_connection);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_connection;
        private System.Windows.Forms.Label lbl_Connection;
        private System.Windows.Forms.Button btn_connect;
        private System.Windows.Forms.ComboBox cmb_table;
        private System.Windows.Forms.ComboBox cmb_view;
        private System.Windows.Forms.ComboBox cmb_sp;
        private System.Windows.Forms.Label lbl_view;
        private System.Windows.Forms.Label lbl_sp;
        private System.Windows.Forms.Label lbl_table;
        private System.Windows.Forms.Button btn_Generate;
    }
}

