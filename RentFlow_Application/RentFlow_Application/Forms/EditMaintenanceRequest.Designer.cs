namespace RentFlow_Application.Forms
{
    partial class EditMaintenanceRequest
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
            roundedPanel1 = new RoundedPanel();
            lblEditingRequest = new Label();
            chkbxPending = new CheckBox();
            chckbxResolved = new CheckBox();
            checkBox3 = new CheckBox();
            btnSaveChanges = new Button();
            btnCancelEdit = new Button();
            roundedPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // roundedPanel1
            // 
            roundedPanel1.BackColor = Color.White;
            roundedPanel1.Controls.Add(btnCancelEdit);
            roundedPanel1.Controls.Add(btnSaveChanges);
            roundedPanel1.Controls.Add(checkBox3);
            roundedPanel1.Controls.Add(chckbxResolved);
            roundedPanel1.Controls.Add(chkbxPending);
            roundedPanel1.Controls.Add(lblEditingRequest);
            roundedPanel1.Location = new Point(44, 46);
            roundedPanel1.Name = "roundedPanel1";
            roundedPanel1.Size = new Size(568, 374);
            roundedPanel1.TabIndex = 0;
            roundedPanel1.Paint += this.roundedPanel1_Paint;
            // 
            // lblEditingRequest
            // 
            lblEditingRequest.AutoSize = true;
            lblEditingRequest.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEditingRequest.Location = new Point(13, 11);
            lblEditingRequest.Name = "lblEditingRequest";
            lblEditingRequest.Size = new Size(161, 28);
            lblEditingRequest.TabIndex = 1;
            lblEditingRequest.Text = "Editing Request";
            // 
            // chkbxPending
            // 
            chkbxPending.AutoSize = true;
            chkbxPending.FlatAppearance.BorderSize = 0;
            chkbxPending.FlatStyle = FlatStyle.Flat;
            chkbxPending.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            chkbxPending.ForeColor = Color.Black;
            chkbxPending.Location = new Point(13, 90);
            chkbxPending.Name = "chkbxPending";
            chkbxPending.Size = new Size(374, 27);
            chkbxPending.TabIndex = 2;
            chkbxPending.Text = "Maintanance Request is Pending(To be fixed)";
            chkbxPending.UseVisualStyleBackColor = true;
            chkbxPending.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // chckbxResolved
            // 
            chckbxResolved.AutoSize = true;
            chckbxResolved.FlatAppearance.BorderSize = 0;
            chckbxResolved.FlatStyle = FlatStyle.Flat;
            chckbxResolved.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            chckbxResolved.ForeColor = Color.Black;
            chckbxResolved.Location = new Point(13, 165);
            chckbxResolved.Name = "chckbxResolved";
            chckbxResolved.Size = new Size(285, 27);
            chckbxResolved.TabIndex = 3;
            chckbxResolved.Text = "Maintanance Request is Resolved";
            chckbxResolved.UseVisualStyleBackColor = true;
            chckbxResolved.CheckedChanged += this.checkBox2_CheckedChanged;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.FlatAppearance.BorderSize = 0;
            checkBox3.FlatStyle = FlatStyle.Flat;
            checkBox3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            checkBox3.ForeColor = Color.Black;
            checkBox3.Location = new Point(13, 240);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(263, 27);
            checkBox3.TabIndex = 4;
            checkBox3.Text = "Remove Maintanance Request";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // btnSaveChanges
            // 
            btnSaveChanges.BackColor = Color.FromArgb(37, 99, 235);
            btnSaveChanges.FlatAppearance.BorderSize = 0;
            btnSaveChanges.FlatStyle = FlatStyle.Flat;
            btnSaveChanges.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSaveChanges.ForeColor = SystemColors.ButtonHighlight;
            btnSaveChanges.Location = new Point(13, 303);
            btnSaveChanges.Name = "btnSaveChanges";
            btnSaveChanges.Size = new Size(263, 40);
            btnSaveChanges.TabIndex = 6;
            btnSaveChanges.Text = "Save Changes";
            btnSaveChanges.UseVisualStyleBackColor = false;
            // 
            // btnCancelEdit
            // 
            btnCancelEdit.BackColor = Color.LightGray;
            btnCancelEdit.Cursor = Cursors.Hand;
            btnCancelEdit.FlatAppearance.BorderSize = 0;
            btnCancelEdit.FlatStyle = FlatStyle.Flat;
            btnCancelEdit.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelEdit.ForeColor = Color.DimGray;
            btnCancelEdit.Location = new Point(326, 303);
            btnCancelEdit.Margin = new Padding(2);
            btnCancelEdit.Name = "btnCancelEdit";
            btnCancelEdit.Size = new Size(230, 40);
            btnCancelEdit.TabIndex = 19;
            btnCancelEdit.Text = "Cancel";
            btnCancelEdit.UseVisualStyleBackColor = false;
            btnCancelEdit.Click += btnCancelEdit_Click;
            // 
            // EditMaintenanceRequest
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(657, 456);
            Controls.Add(roundedPanel1);
            Name = "EditMaintenanceRequest";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EditMaintenanceRequest";
            roundedPanel1.ResumeLayout(false);
            roundedPanel1.PerformLayout();
            ResumeLayout(false);
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void roundedPanel1_Paint(object sender, PaintEventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private RoundedPanel roundedPanel1;
        private CheckBox chkbxPending;
        private Label lblEditingRequest;
        private CheckBox checkBox3;
        private CheckBox chckbxResolved;
        private Button btnSaveChanges;
        private Button btnCancelEdit;
    }
}