namespace TicketSystemApp_P113.UserControls
{
    partial class CreateTicketUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txbx_Title = new System.Windows.Forms.TextBox();
            this.txbx_Description = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_createTicket = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_createTicket);
            this.groupBox1.Controls.Add(this.txbx_Description);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txbx_Title);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(489, 321);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Create Ticket";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Title";
            // 
            // txbx_Title
            // 
            this.txbx_Title.Location = new System.Drawing.Point(42, 53);
            this.txbx_Title.Name = "txbx_Title";
            this.txbx_Title.Size = new System.Drawing.Size(410, 20);
            this.txbx_Title.TabIndex = 1;
            // 
            // txbx_Description
            // 
            this.txbx_Description.Location = new System.Drawing.Point(42, 116);
            this.txbx_Description.Multiline = true;
            this.txbx_Description.Name = "txbx_Description";
            this.txbx_Description.Size = new System.Drawing.Size(410, 148);
            this.txbx_Description.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Description";
            // 
            // btn_createTicket
            // 
            this.btn_createTicket.Location = new System.Drawing.Point(183, 271);
            this.btn_createTicket.Name = "btn_createTicket";
            this.btn_createTicket.Size = new System.Drawing.Size(138, 44);
            this.btn_createTicket.TabIndex = 4;
            this.btn_createTicket.Text = "Create Ticket";
            this.btn_createTicket.UseVisualStyleBackColor = true;
            // 
            // CreateTicketUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "CreateTicketUserControl";
            this.Size = new System.Drawing.Size(495, 327);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.TextBox txbx_Description;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txbx_Title;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button btn_createTicket;
    }
}
