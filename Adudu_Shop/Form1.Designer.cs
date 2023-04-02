namespace Adudu_Shop
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataGridViewTampil = new System.Windows.Forms.DataGridView();
            this.dataGridViewCategory = new System.Windows.Forms.DataGridView();
            this.labelProduct = new System.Windows.Forms.Label();
            this.labelCategory = new System.Windows.Forms.Label();
            this.buttonAll = new System.Windows.Forms.Button();
            this.buttonFilter = new System.Windows.Forms.Button();
            this.comboBoxFilter = new System.Windows.Forms.ComboBox();
            this.labelDetail = new System.Windows.Forms.Label();
            this.labelNamaProduct = new System.Windows.Forms.Label();
            this.labelCategoryDetails = new System.Windows.Forms.Label();
            this.labelHarga = new System.Windows.Forms.Label();
            this.labelStock = new System.Windows.Forms.Label();
            this.textBoxNamaProduct = new System.Windows.Forms.TextBox();
            this.textBoxHarga = new System.Windows.Forms.TextBox();
            this.textBoxStock = new System.Windows.Forms.TextBox();
            this.buttonAddDetails = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonRemoveProduct = new System.Windows.Forms.Button();
            this.labelNamaCategory = new System.Windows.Forms.Label();
            this.textBoxNamaCategory = new System.Windows.Forms.TextBox();
            this.buttonAddCategory = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.labelTimer = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.buttonWarna = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTampil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewTampil
            // 
            this.dataGridViewTampil.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTampil.Location = new System.Drawing.Point(12, 59);
            this.dataGridViewTampil.Name = "dataGridViewTampil";
            this.dataGridViewTampil.Size = new System.Drawing.Size(518, 199);
            this.dataGridViewTampil.TabIndex = 0;
            this.dataGridViewTampil.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTampil_CellClick);
            // 
            // dataGridViewCategory
            // 
            this.dataGridViewCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCategory.Location = new System.Drawing.Point(548, 59);
            this.dataGridViewCategory.Name = "dataGridViewCategory";
            this.dataGridViewCategory.Size = new System.Drawing.Size(240, 150);
            this.dataGridViewCategory.TabIndex = 1;
            this.dataGridViewCategory.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCategory_CellClick);
            // 
            // labelProduct
            // 
            this.labelProduct.AutoSize = true;
            this.labelProduct.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProduct.Location = new System.Drawing.Point(12, 27);
            this.labelProduct.Name = "labelProduct";
            this.labelProduct.Size = new System.Drawing.Size(80, 26);
            this.labelProduct.TabIndex = 2;
            this.labelProduct.Text = "Product";
            // 
            // labelCategory
            // 
            this.labelCategory.AutoSize = true;
            this.labelCategory.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCategory.Location = new System.Drawing.Point(543, 30);
            this.labelCategory.Name = "labelCategory";
            this.labelCategory.Size = new System.Drawing.Size(90, 26);
            this.labelCategory.TabIndex = 3;
            this.labelCategory.Text = "Category";
            // 
            // buttonAll
            // 
            this.buttonAll.Location = new System.Drawing.Point(287, 33);
            this.buttonAll.Name = "buttonAll";
            this.buttonAll.Size = new System.Drawing.Size(43, 23);
            this.buttonAll.TabIndex = 4;
            this.buttonAll.Text = "All";
            this.buttonAll.UseVisualStyleBackColor = true;
            this.buttonAll.Click += new System.EventHandler(this.buttonAll_Click);
            // 
            // buttonFilter
            // 
            this.buttonFilter.Location = new System.Drawing.Point(336, 32);
            this.buttonFilter.Name = "buttonFilter";
            this.buttonFilter.Size = new System.Drawing.Size(52, 23);
            this.buttonFilter.TabIndex = 5;
            this.buttonFilter.Text = "Filter";
            this.buttonFilter.UseVisualStyleBackColor = true;
            this.buttonFilter.Click += new System.EventHandler(this.buttonFilter_Click);
            // 
            // comboBoxFilter
            // 
            this.comboBoxFilter.FormattingEnabled = true;
            this.comboBoxFilter.Location = new System.Drawing.Point(394, 32);
            this.comboBoxFilter.Name = "comboBoxFilter";
            this.comboBoxFilter.Size = new System.Drawing.Size(121, 21);
            this.comboBoxFilter.TabIndex = 6;
            this.comboBoxFilter.SelectedIndexChanged += new System.EventHandler(this.comboBoxFilter_SelectedIndexChanged);
            this.comboBoxFilter.SelectionChangeCommitted += new System.EventHandler(this.comboBoxFilter_SelectionChangeCommitted);
            // 
            // labelDetail
            // 
            this.labelDetail.AutoSize = true;
            this.labelDetail.Location = new System.Drawing.Point(65, 285);
            this.labelDetail.Name = "labelDetail";
            this.labelDetail.Size = new System.Drawing.Size(39, 13);
            this.labelDetail.TabIndex = 7;
            this.labelDetail.Text = "Details";
            // 
            // labelNamaProduct
            // 
            this.labelNamaProduct.AutoSize = true;
            this.labelNamaProduct.Location = new System.Drawing.Point(67, 316);
            this.labelNamaProduct.Name = "labelNamaProduct";
            this.labelNamaProduct.Size = new System.Drawing.Size(81, 13);
            this.labelNamaProduct.TabIndex = 8;
            this.labelNamaProduct.Text = "Nama Product :";
            // 
            // labelCategoryDetails
            // 
            this.labelCategoryDetails.AutoSize = true;
            this.labelCategoryDetails.Location = new System.Drawing.Point(67, 342);
            this.labelCategoryDetails.Name = "labelCategoryDetails";
            this.labelCategoryDetails.Size = new System.Drawing.Size(55, 13);
            this.labelCategoryDetails.TabIndex = 9;
            this.labelCategoryDetails.Text = "Category :";
            // 
            // labelHarga
            // 
            this.labelHarga.AutoSize = true;
            this.labelHarga.Location = new System.Drawing.Point(67, 371);
            this.labelHarga.Name = "labelHarga";
            this.labelHarga.Size = new System.Drawing.Size(42, 13);
            this.labelHarga.TabIndex = 10;
            this.labelHarga.Text = "Harga :";
            // 
            // labelStock
            // 
            this.labelStock.AutoSize = true;
            this.labelStock.Location = new System.Drawing.Point(67, 403);
            this.labelStock.Name = "labelStock";
            this.labelStock.Size = new System.Drawing.Size(41, 13);
            this.labelStock.TabIndex = 11;
            this.labelStock.Text = "Stock :";
            // 
            // textBoxNamaProduct
            // 
            this.textBoxNamaProduct.Location = new System.Drawing.Point(164, 313);
            this.textBoxNamaProduct.Name = "textBoxNamaProduct";
            this.textBoxNamaProduct.Size = new System.Drawing.Size(280, 20);
            this.textBoxNamaProduct.TabIndex = 12;
            // 
            // textBoxHarga
            // 
            this.textBoxHarga.Location = new System.Drawing.Point(164, 368);
            this.textBoxHarga.Name = "textBoxHarga";
            this.textBoxHarga.Size = new System.Drawing.Size(121, 20);
            this.textBoxHarga.TabIndex = 14;
            this.textBoxHarga.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxHarga_KeyPress);
            // 
            // textBoxStock
            // 
            this.textBoxStock.Location = new System.Drawing.Point(164, 396);
            this.textBoxStock.Name = "textBoxStock";
            this.textBoxStock.Size = new System.Drawing.Size(121, 20);
            this.textBoxStock.TabIndex = 15;
            this.textBoxStock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxStock_KeyPress);
            // 
            // buttonAddDetails
            // 
            this.buttonAddDetails.Location = new System.Drawing.Point(299, 355);
            this.buttonAddDetails.Name = "buttonAddDetails";
            this.buttonAddDetails.Size = new System.Drawing.Size(52, 47);
            this.buttonAddDetails.TabIndex = 16;
            this.buttonAddDetails.Text = "Add";
            this.buttonAddDetails.UseVisualStyleBackColor = true;
            this.buttonAddDetails.Click += new System.EventHandler(this.buttonAddDetails_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(357, 355);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(52, 47);
            this.buttonUpdate.TabIndex = 17;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonRemoveProduct
            // 
            this.buttonRemoveProduct.Location = new System.Drawing.Point(415, 355);
            this.buttonRemoveProduct.Name = "buttonRemoveProduct";
            this.buttonRemoveProduct.Size = new System.Drawing.Size(55, 47);
            this.buttonRemoveProduct.TabIndex = 18;
            this.buttonRemoveProduct.Text = "Remove";
            this.buttonRemoveProduct.UseVisualStyleBackColor = true;
            this.buttonRemoveProduct.Click += new System.EventHandler(this.buttonRemoveProduct_Click);
            // 
            // labelNamaCategory
            // 
            this.labelNamaCategory.AutoSize = true;
            this.labelNamaCategory.Location = new System.Drawing.Point(545, 234);
            this.labelNamaCategory.Name = "labelNamaCategory";
            this.labelNamaCategory.Size = new System.Drawing.Size(80, 13);
            this.labelNamaCategory.TabIndex = 19;
            this.labelNamaCategory.Text = "Nama Category";
            // 
            // textBoxNamaCategory
            // 
            this.textBoxNamaCategory.Location = new System.Drawing.Point(631, 231);
            this.textBoxNamaCategory.Name = "textBoxNamaCategory";
            this.textBoxNamaCategory.Size = new System.Drawing.Size(157, 20);
            this.textBoxNamaCategory.TabIndex = 20;
            // 
            // buttonAddCategory
            // 
            this.buttonAddCategory.Location = new System.Drawing.Point(631, 269);
            this.buttonAddCategory.Name = "buttonAddCategory";
            this.buttonAddCategory.Size = new System.Drawing.Size(75, 44);
            this.buttonAddCategory.TabIndex = 21;
            this.buttonAddCategory.Text = "Add";
            this.buttonAddCategory.UseVisualStyleBackColor = true;
            this.buttonAddCategory.Click += new System.EventHandler(this.buttonAddCategory_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.Location = new System.Drawing.Point(713, 269);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(75, 44);
            this.buttonRemove.TabIndex = 22;
            this.buttonRemove.Text = "Remove";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Location = new System.Drawing.Point(164, 341);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCategory.TabIndex = 23;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // labelTimer
            // 
            this.labelTimer.AutoSize = true;
            this.labelTimer.Font = new System.Drawing.Font("Microsoft YaHei", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTimer.Location = new System.Drawing.Point(661, 17);
            this.labelTimer.Name = "labelTimer";
            this.labelTimer.Size = new System.Drawing.Size(116, 32);
            this.labelTimer.TabIndex = 24;
            this.labelTimer.Text = "00:00:00";
            // 
            // pictureBox1
            // 
            this.pictureBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(488, 285);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(127, 157);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(621, 319);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(119, 136);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 26;
            this.pictureBox2.TabStop = false;
            // 
            // buttonWarna
            // 
            this.buttonWarna.Location = new System.Drawing.Point(222, 34);
            this.buttonWarna.Name = "buttonWarna";
            this.buttonWarna.Size = new System.Drawing.Size(59, 22);
            this.buttonWarna.TabIndex = 27;
            this.buttonWarna.Text = "Warna";
            this.buttonWarna.UseVisualStyleBackColor = true;
            this.buttonWarna.Click += new System.EventHandler(this.buttonWarna_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonWarna);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelTimer);
            this.Controls.Add(this.comboBoxCategory);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.buttonAddCategory);
            this.Controls.Add(this.textBoxNamaCategory);
            this.Controls.Add(this.labelNamaCategory);
            this.Controls.Add(this.buttonRemoveProduct);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonAddDetails);
            this.Controls.Add(this.textBoxStock);
            this.Controls.Add(this.textBoxHarga);
            this.Controls.Add(this.textBoxNamaProduct);
            this.Controls.Add(this.labelStock);
            this.Controls.Add(this.labelHarga);
            this.Controls.Add(this.labelCategoryDetails);
            this.Controls.Add(this.labelNamaProduct);
            this.Controls.Add(this.labelDetail);
            this.Controls.Add(this.comboBoxFilter);
            this.Controls.Add(this.buttonFilter);
            this.Controls.Add(this.buttonAll);
            this.Controls.Add(this.labelCategory);
            this.Controls.Add(this.labelProduct);
            this.Controls.Add(this.dataGridViewCategory);
            this.Controls.Add(this.dataGridViewTampil);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTampil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewTampil;
        private System.Windows.Forms.DataGridView dataGridViewCategory;
        private System.Windows.Forms.Label labelProduct;
        private System.Windows.Forms.Label labelCategory;
        private System.Windows.Forms.Button buttonAll;
        private System.Windows.Forms.Button buttonFilter;
        private System.Windows.Forms.ComboBox comboBoxFilter;
        private System.Windows.Forms.Label labelDetail;
        private System.Windows.Forms.Label labelNamaProduct;
        private System.Windows.Forms.Label labelCategoryDetails;
        private System.Windows.Forms.Label labelHarga;
        private System.Windows.Forms.Label labelStock;
        private System.Windows.Forms.TextBox textBoxNamaProduct;
        private System.Windows.Forms.TextBox textBoxHarga;
        private System.Windows.Forms.TextBox textBoxStock;
        private System.Windows.Forms.Button buttonAddDetails;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonRemoveProduct;
        private System.Windows.Forms.Label labelNamaCategory;
        private System.Windows.Forms.TextBox textBoxNamaCategory;
        private System.Windows.Forms.Button buttonAddCategory;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.ComboBox comboBoxCategory;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label labelTimer;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button buttonWarna;
    }
}

