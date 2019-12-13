namespace TicketSystemApp_P113.UserControls
{
    partial class ListTicketUserControl
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
            this.ticketListGrid = new System.Windows.Forms.DataGridView();
            this.btn_updateTicket = new System.Windows.Forms.Button();
            this.txbx_Description = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbx_Title = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ticketListGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // ticketListGrid
            // 
            this.ticketListGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ticketListGrid.Location = new System.Drawing.Point(11, 11);
            this.ticketListGrid.Name = "ticketListGrid";
            this.ticketListGrid.Size = new System.Drawing.Size(658, 230);
            this.ticketListGrid.TabIndex = 0;
            // 
            // btn_updateTicket
            // 
            this.btn_updateTicket.Location = new System.Drawing.Point(152, 489);
            this.btn_updateTicket.Name = "btn_updateTicket";
            this.btn_updateTicket.Size = new System.Drawing.Size(138, 44);
            this.btn_updateTicket.TabIndex = 9;
            this.btn_updateTicket.Text = "Update Ticket";
            this.btn_updateTicket.UseVisualStyleBackColor = true;
            // 
            // txbx_Description
            // 
            this.txbx_Description.Location = new System.Drawing.Point(11, 334);
            this.txbx_Description.Multiline = true;
            this.txbx_Description.Name = "txbx_Description";
            this.txbx_Description.Size = new System.Drawing.Size(410, 148);
            this.txbx_Description.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 317);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Description";
            // 
            // txbx_Title
            // 
            this.txbx_Title.Location = new System.Drawing.Point(11, 271);
            this.txbx_Title.Name = "txbx_Title";
            this.txbx_Title.Size = new System.Drawing.Size(410, 20);
            this.txbx_Title.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 254);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Title";
            // 
            // ListTicketUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_updateTicket);
            this.Controls.Add(this.txbx_Description);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbx_Title);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ticketListGrid);
            this.Name = "ListTicketUserControl";
            this.Size = new System.Drawing.Size(685, 548);
            ((System.ComponentModel.ISupportInitialize)(this.ticketListGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView ticketListGrid;
        public System.Windows.Forms.Button btn_updateTicket;
        public System.Windows.Forms.TextBox txbx_Description;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txbx_Title;
        private System.Windows.Forms.Label label1;
    }
}
