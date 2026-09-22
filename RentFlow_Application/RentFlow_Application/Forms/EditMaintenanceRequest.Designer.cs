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
            btnCancelEdit = new Button();
            btnSaveChanges = new Button();
            lblEditingRequest = new Label();
            rdoPending = new RadioButton();
            rdoResolved = new RadioButton();
            rdoRemove = new RadioButton();
            roundedPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // roundedPanel1
            // 
            roundedPanel1.BackColor = Color.White;
            roundedPanel1.Controls.Add(rdoRemove);
            roundedPanel1.Controls.Add(rdoResolved);
            roundedPanel1.Controls.Add(rdoPending);
            roundedPanel1.Controls.Add(btnCancelEdit);
            roundedPanel1.Controls.Add(btnSaveChanges);
            roundedPanel1.Controls.Add(lblEditingRequest);
            roundedPanel1.Location = new Point(44, 46);
            roundedPanel1.Name = "roundedPanel1";
            roundedPanel1.Size = new Size(568, 374);
            roundedPanel1.TabIndex = 0;
            roundedPanel1.Paint += roundedPanel1_Paint;
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
            btnSaveChanges.Click += btnSaveChanges_Click;
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
            // rdoPending
            // 
            rdoPending.AutoSize = true;
            rdoPending.FlatAppearance.BorderSize = 0;
            rdoPending.FlatStyle = FlatStyle.Flat;
            rdoPending.Font = new Font("Segoe UI", 10.2F);
            rdoPending.Location = new Point(13, 76);
            rdoPending.Name = "rdoPending";
            rdoPending.Size = new Size(370, 27);
            rdoPending.TabIndex = 20;
            rdoPending.TabStop = true;
            rdoPending.Text = "Maintanance Request is Pending(To be fixed)";
            rdoPending.UseVisualStyleBackColor = true;
            // 
            // rdoResolved
            // 
            rdoResolved.AutoSize = true;
            rdoResolved.FlatAppearance.BorderSize = 0;
            rdoResolved.FlatStyle = FlatStyle.Flat;
            rdoResolved.Font = new Font("Segoe UI", 10.2F);
            rdoResolved.Location = new Point(13, 154);
            rdoResolved.Name = "rdoResolved";
            rdoResolved.Size = new Size(283, 27);
            rdoResolved.TabIndex = 21;
            rdoResolved.TabStop = true;
            rdoResolved.Text = "Maintanance Request is Resolved";
            rdoResolved.UseVisualStyleBackColor = true;
            // 
            // rdoRemove
            // 
            rdoRemove.AutoSize = true;
            rdoRemove.FlatAppearance.BorderSize = 0;
            rdoRemove.FlatStyle = FlatStyle.Flat;
            rdoRemove.Font = new Font("Segoe UI", 10.2F);
            rdoRemove.Location = new Point(13, 232);
            rdoRemove.Name = "rdoRemove";
            rdoRemove.Size = new Size(261, 27);
            rdoRemove.TabIndex = 22;
            rdoRemove.TabStop = true;
            rdoRemove.Text = "Remove Maintanance Request";
            rdoRemove.UseVisualStyleBackColor = true;
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
            //throw new NotImplementedException();
        }

        #endregion

        private RoundedPanel roundedPanel1;
        private Label lblEditingRequest;
        private Button btnSaveChanges;
        private Button btnCancelEdit;
        private RadioButton rdoRemove;
        private RadioButton rdoResolved;
        private RadioButton rdoPending;
    }
}