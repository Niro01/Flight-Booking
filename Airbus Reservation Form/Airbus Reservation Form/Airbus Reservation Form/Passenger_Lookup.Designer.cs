namespace Airbus_Reservation_Form
{
    partial class Passenger_Lookup
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvPassangers = new System.Windows.Forms.DataGridView();
            this.btnCancel = new System.Windows.Forms.Button();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seatNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seatPositionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passengerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.passengerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.programBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPassangers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passengerBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passengerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.programBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Double Click to Select Passenger";
            // 
            // dgvPassangers
            // 
            this.dgvPassangers.AllowUserToAddRows = false;
            this.dgvPassangers.AllowUserToDeleteRows = false;
            this.dgvPassangers.AutoGenerateColumns = false;
            this.dgvPassangers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPassangers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.seatNumberDataGridViewTextBoxColumn,
            this.seatPositionDataGridViewTextBoxColumn});
            this.dgvPassangers.DataSource = this.passengerBindingSource1;
            this.dgvPassangers.Location = new System.Drawing.Point(15, 52);
            this.dgvPassangers.Name = "dgvPassangers";
            this.dgvPassangers.Size = new System.Drawing.Size(344, 273);
            this.dgvPassangers.TabIndex = 3;
            this.dgvPassangers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPassangers_CellContentClick_1);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Perpetua Titling MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(170, 331);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(190, 32);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click_1);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // seatNumberDataGridViewTextBoxColumn
            // 
            this.seatNumberDataGridViewTextBoxColumn.DataPropertyName = "SeatNumber";
            this.seatNumberDataGridViewTextBoxColumn.HeaderText = "SeatNumber";
            this.seatNumberDataGridViewTextBoxColumn.Name = "seatNumberDataGridViewTextBoxColumn";
            // 
            // seatPositionDataGridViewTextBoxColumn
            // 
            this.seatPositionDataGridViewTextBoxColumn.DataPropertyName = "SeatPosition";
            this.seatPositionDataGridViewTextBoxColumn.HeaderText = "SeatPosition";
            this.seatPositionDataGridViewTextBoxColumn.Name = "seatPositionDataGridViewTextBoxColumn";
            // 
            // passengerBindingSource1
            // 
            this.passengerBindingSource1.DataSource = typeof(Airbus_Reservation_Form.Passenger);
            // 
            // passengerBindingSource
            // 
            this.passengerBindingSource.DataSource = typeof(Airbus_Reservation_Form.Passenger);
            // 
            // programBindingSource
            // 
            this.programBindingSource.DataSource = typeof(Airbus_Reservation_Form.Program);
            // 
            // Passenger_Lookup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 386);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.dgvPassangers);
            this.Controls.Add(this.label1);
            this.Name = "Passenger_Lookup";
            this.Text = "Passenger_Lookup";
            this.Load += new System.EventHandler(this.Passenger_Lookup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPassangers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passengerBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passengerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.programBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvPassangers;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.BindingSource programBindingSource;
        private System.Windows.Forms.BindingSource passengerBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn seatNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn seatPositionDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource passengerBindingSource1;
    }
}