namespace AppG2.View
{
    partial class frmContacts
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
            this.titile = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dtgContacts = new System.Windows.Forms.DataGridView();
            this.btnClose = new System.Windows.Forms.Button();
            this.bdsContacts = new System.Windows.Forms.BindingSource(this.components);
            this.colKey = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.linkA = new System.Windows.Forms.LinkLabel();
            this.linkD = new System.Windows.Forms.LinkLabel();
            this.linkG = new System.Windows.Forms.LinkLabel();
            this.linkM = new System.Windows.Forms.LinkLabel();
            this.linkP = new System.Windows.Forms.LinkLabel();
            this.linkS = new System.Windows.Forms.LinkLabel();
            this.linkZ = new System.Windows.Forms.LinkLabel();
            this.linkW = new System.Windows.Forms.LinkLabel();
            this.linkJ = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dtgContacts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsContacts)).BeginInit();
            this.SuspendLayout();
            // 
            // titile
            // 
            this.titile.AutoSize = true;
            this.titile.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.titile.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.titile.Location = new System.Drawing.Point(129, 9);
            this.titile.Name = "titile";
            this.titile.Size = new System.Drawing.Size(106, 29);
            this.titile.TabIndex = 0;
            this.titile.Text = "Contacts";
            this.titile.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.SystemColors.Menu;
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtSearch.Location = new System.Drawing.Point(12, 53);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(338, 26);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.TextChanged += new System.EventHandler(this.TxtSearch_TextChanged);
            this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtSearch_KeyDown);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(275, 84);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(198, 84);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(121, 84);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // dtgContacts
            // 
            this.dtgContacts.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dtgContacts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgContacts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colKey,
            this.colName,
            this.colPhone,
            this.colEmail});
            this.dtgContacts.Location = new System.Drawing.Point(12, 111);
            this.dtgContacts.Name = "dtgContacts";
            this.dtgContacts.RowHeadersVisible = false;
            this.dtgContacts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgContacts.Size = new System.Drawing.Size(323, 315);
            this.dtgContacts.TabIndex = 5;
            this.dtgContacts.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DtgContacts_KeyPress);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Lime;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnClose.Location = new System.Drawing.Point(260, 432);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 27);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // colKey
            // 
            this.colKey.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.colKey.DataPropertyName = "key";
            this.colKey.HeaderText = "";
            this.colKey.Name = "colKey";
            this.colKey.Width = 19;
            // 
            // colName
            // 
            this.colName.DataPropertyName = "name";
            this.colName.HeaderText = "Name";
            this.colName.Name = "colName";
            // 
            // colPhone
            // 
            this.colPhone.DataPropertyName = "phone";
            this.colPhone.HeaderText = "Phone";
            this.colPhone.Name = "colPhone";
            // 
            // colEmail
            // 
            this.colEmail.DataPropertyName = "email";
            this.colEmail.HeaderText = "Email";
            this.colEmail.Name = "colEmail";
            // 
            // linkA
            // 
            this.linkA.AutoSize = true;
            this.linkA.Location = new System.Drawing.Point(341, 134);
            this.linkA.Name = "linkA";
            this.linkA.Size = new System.Drawing.Size(13, 13);
            this.linkA.TabIndex = 7;
            this.linkA.TabStop = true;
            this.linkA.Text = "a";
            this.linkA.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkA_LinkClicked);
            // 
            // linkD
            // 
            this.linkD.AutoSize = true;
            this.linkD.Location = new System.Drawing.Point(341, 166);
            this.linkD.Name = "linkD";
            this.linkD.Size = new System.Drawing.Size(13, 13);
            this.linkD.TabIndex = 8;
            this.linkD.TabStop = true;
            this.linkD.Text = "d";
            this.linkD.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkD_LinkClicked);
            // 
            // linkG
            // 
            this.linkG.AutoSize = true;
            this.linkG.Location = new System.Drawing.Point(341, 200);
            this.linkG.Name = "linkG";
            this.linkG.Size = new System.Drawing.Size(13, 13);
            this.linkG.TabIndex = 9;
            this.linkG.TabStop = true;
            this.linkG.Text = "g";
            this.linkG.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkG_LinkClicked);
            // 
            // linkM
            // 
            this.linkM.AutoSize = true;
            this.linkM.Location = new System.Drawing.Point(341, 273);
            this.linkM.Name = "linkM";
            this.linkM.Size = new System.Drawing.Size(15, 13);
            this.linkM.TabIndex = 10;
            this.linkM.TabStop = true;
            this.linkM.Text = "m";
            this.linkM.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkM_LinkClicked);
            // 
            // linkP
            // 
            this.linkP.AutoSize = true;
            this.linkP.Location = new System.Drawing.Point(341, 308);
            this.linkP.Name = "linkP";
            this.linkP.Size = new System.Drawing.Size(13, 13);
            this.linkP.TabIndex = 11;
            this.linkP.TabStop = true;
            this.linkP.Text = "p";
            this.linkP.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkP_LinkClicked);
            // 
            // linkS
            // 
            this.linkS.AutoSize = true;
            this.linkS.Location = new System.Drawing.Point(341, 342);
            this.linkS.Name = "linkS";
            this.linkS.Size = new System.Drawing.Size(12, 13);
            this.linkS.TabIndex = 12;
            this.linkS.TabStop = true;
            this.linkS.Text = "s";
            this.linkS.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkS_LinkClicked);
            // 
            // linkZ
            // 
            this.linkZ.AutoSize = true;
            this.linkZ.Location = new System.Drawing.Point(341, 411);
            this.linkZ.Name = "linkZ";
            this.linkZ.Size = new System.Drawing.Size(12, 13);
            this.linkZ.TabIndex = 13;
            this.linkZ.TabStop = true;
            this.linkZ.Text = "z";
            this.linkZ.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkZ_LinkClicked);
            // 
            // linkW
            // 
            this.linkW.AutoSize = true;
            this.linkW.Location = new System.Drawing.Point(341, 376);
            this.linkW.Name = "linkW";
            this.linkW.Size = new System.Drawing.Size(15, 13);
            this.linkW.TabIndex = 14;
            this.linkW.TabStop = true;
            this.linkW.Text = "w";
            this.linkW.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkW_LinkClicked);
            // 
            // linkJ
            // 
            this.linkJ.AutoSize = true;
            this.linkJ.Location = new System.Drawing.Point(341, 236);
            this.linkJ.Name = "linkJ";
            this.linkJ.Size = new System.Drawing.Size(15, 13);
            this.linkJ.TabIndex = 15;
            this.linkJ.TabStop = true;
            this.linkJ.Text = " j ";
            this.linkJ.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkJ_LinkClicked);
            // 
            // frmContacts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(362, 471);
            this.Controls.Add(this.linkJ);
            this.Controls.Add(this.linkW);
            this.Controls.Add(this.linkZ);
            this.Controls.Add(this.linkS);
            this.Controls.Add(this.linkP);
            this.Controls.Add(this.linkM);
            this.Controls.Add(this.linkG);
            this.Controls.Add(this.linkD);
            this.Controls.Add(this.linkA);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dtgContacts);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.titile);
            this.Name = "frmContacts";
            this.Text = "Contacts";
            ((System.ComponentModel.ISupportInitialize)(this.dtgContacts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsContacts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titile;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dtgContacts;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.BindingSource bdsContacts;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKey;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmail;
        private System.Windows.Forms.LinkLabel linkA;
        private System.Windows.Forms.LinkLabel linkD;
        private System.Windows.Forms.LinkLabel linkG;
        private System.Windows.Forms.LinkLabel linkM;
        private System.Windows.Forms.LinkLabel linkP;
        private System.Windows.Forms.LinkLabel linkS;
        private System.Windows.Forms.LinkLabel linkZ;
        private System.Windows.Forms.LinkLabel linkW;
        private System.Windows.Forms.LinkLabel linkJ;
    }
}