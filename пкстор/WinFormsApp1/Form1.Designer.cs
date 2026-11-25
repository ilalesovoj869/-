namespace ComputerShop
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Label lblProducts;
        private System.Windows.Forms.Label lblCart;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblTotal;

        private System.Windows.Forms.ListBox listBoxProducts;
        private System.Windows.Forms.ListBox listBoxCart;

        private System.Windows.Forms.NumericUpDown numQuantity;

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnCheckout;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblTitle = new Label();
            lblSubtitle = new Label();
            lblProducts = new Label();
            lblCart = new Label();
            lblQuantity = new Label();
            lblTotal = new Label();
            listBoxProducts = new ListBox();
            listBoxCart = new ListBox();
            numQuantity = new NumericUpDown();
            btnAdd = new Button();
            btnRemove = new Button();
            btnClear = new Button();
            btnCheckout = new Button();
            ((System.ComponentModel.ISupportInitialize)numQuantity).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Segoe UI", 26F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(163, 230, 93);
            lblTitle.Location = new Point(25, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(430, 50);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "PC STORE";
            // 
            // lblSubtitle
            // 
            lblSubtitle.Font = new Font("Segoe UI", 10F);
            lblSubtitle.ForeColor = Color.FromArgb(155, 165, 185);
            lblSubtitle.Location = new Point(28, 75);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(600, 25);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Комплектующие для твоей следующей сборки";
            // 
            // lblProducts
            // 
            lblProducts.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblProducts.ForeColor = Color.White;
            lblProducts.Location = new Point(25, 120);
            lblProducts.Name = "lblProducts";
            lblProducts.Size = new Size(430, 35);
            lblProducts.TabIndex = 2;
            lblProducts.Text = "Каталог товаров";
            // 
            // lblCart
            // 
            lblCart.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblCart.ForeColor = Color.White;
            lblCart.Location = new Point(485, 120);
            lblCart.Name = "lblCart";
            lblCart.Size = new Size(430, 35);
            lblCart.TabIndex = 3;
            lblCart.Text = "Твоя корзина";
            // 
            // lblQuantity
            // 
            lblQuantity.ForeColor = Color.FromArgb(155, 165, 185);
            lblQuantity.Location = new Point(25, 440);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(110, 25);
            lblQuantity.TabIndex = 4;
            lblQuantity.Text = "Количество";
            // 
            // lblTotal
            // 
            lblTotal.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTotal.ForeColor = Color.FromArgb(163, 230, 93);
            lblTotal.Location = new Point(485, 495);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(430, 35);
            lblTotal.TabIndex = 6;
            lblTotal.Text = "Итого: 0 ₽";
            // 
            // listBoxProducts
            // 
            listBoxProducts.BackColor = Color.FromArgb(32, 37, 50);
            listBoxProducts.BorderStyle = BorderStyle.None;
            listBoxProducts.Font = new Font("Segoe UI", 11F);
            listBoxProducts.ForeColor = Color.White;
            listBoxProducts.FormattingEnabled = true;
            listBoxProducts.HorizontalScrollbar = true;
            listBoxProducts.IntegralHeight = false;
            listBoxProducts.Location = new Point(25, 165);
            listBoxProducts.Name = "listBoxProducts";
            listBoxProducts.Size = new Size(430, 260);
            listBoxProducts.TabIndex = 0;
            listBoxProducts.DoubleClick += BtnAdd_Click;
            // 
            // listBoxCart
            // 
            listBoxCart.BackColor = Color.FromArgb(32, 37, 50);
            listBoxCart.BorderStyle = BorderStyle.None;
            listBoxCart.Font = new Font("Segoe UI", 11F);
            listBoxCart.ForeColor = Color.White;
            listBoxCart.FormattingEnabled = true;
            listBoxCart.HorizontalScrollbar = true;
            listBoxCart.IntegralHeight = false;
            listBoxCart.Location = new Point(485, 165);
            listBoxCart.Name = "listBoxCart";
            listBoxCart.Size = new Size(430, 260);
            listBoxCart.TabIndex = 3;
            // 
            // numQuantity
            // 
            numQuantity.BackColor = Color.FromArgb(32, 37, 50);
            numQuantity.Font = new Font("Segoe UI", 12F);
            numQuantity.ForeColor = Color.White;
            numQuantity.Location = new Point(25, 475);
            numQuantity.Maximum = new decimal(new int[] { 99, 0, 0, 0 });
            numQuantity.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numQuantity.Name = "numQuantity";
            numQuantity.Size = new Size(90, 29);
            numQuantity.TabIndex = 1;
            numQuantity.TextAlign = HorizontalAlignment.Center;
            numQuantity.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(163, 230, 93);
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnAdd.ForeColor = Color.FromArgb(20, 23, 32);
            btnAdd.Location = new Point(135, 470);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(320, 42);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Добавить в корзину";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += BtnAdd_Click;
            // 
            // btnRemove
            // 
            btnRemove.BackColor = Color.FromArgb(45, 51, 67);
            btnRemove.Cursor = Cursors.Hand;
            btnRemove.FlatAppearance.BorderSize = 0;
            btnRemove.FlatStyle = FlatStyle.Flat;
            btnRemove.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnRemove.ForeColor = Color.White;
            btnRemove.Location = new Point(485, 440);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(205, 38);
            btnRemove.TabIndex = 4;
            btnRemove.Text = "Удалить позицию";
            btnRemove.UseVisualStyleBackColor = false;
            btnRemove.Click += BtnRemove_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(45, 51, 67);
            btnClear.Cursor = Cursors.Hand;
            btnClear.FlatAppearance.BorderSize = 0;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(710, 440);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(205, 38);
            btnClear.TabIndex = 5;
            btnClear.Text = "Очистить корзину";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += BtnClear_Click;
            // 
            // btnCheckout
            // 
            btnCheckout.BackColor = Color.FromArgb(163, 230, 93);
            btnCheckout.Cursor = Cursors.Hand;
            btnCheckout.FlatAppearance.BorderSize = 0;
            btnCheckout.FlatStyle = FlatStyle.Flat;
            btnCheckout.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnCheckout.ForeColor = Color.FromArgb(20, 23, 32);
            btnCheckout.Location = new Point(485, 540);
            btnCheckout.Name = "btnCheckout";
            btnCheckout.Size = new Size(430, 42);
            btnCheckout.TabIndex = 6;
            btnCheckout.Text = "Оформить заказ";
            btnCheckout.UseVisualStyleBackColor = false;
            btnCheckout.Click += BtnCheckout_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(20, 23, 32);
            ClientSize = new Size(940, 605);
            Controls.Add(lblTitle);
            Controls.Add(lblSubtitle);
            Controls.Add(lblProducts);
            Controls.Add(lblCart);
            Controls.Add(listBoxProducts);
            Controls.Add(listBoxCart);
            Controls.Add(lblQuantity);
            Controls.Add(numQuantity);
            Controls.Add(btnAdd);
            Controls.Add(btnRemove);
            Controls.Add(btnClear);
            Controls.Add(lblTotal);
            Controls.Add(btnCheckout);
            Font = new Font("Segoe UI", 10F);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PC STORE — компьютерный магазин";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)numQuantity).EndInit();
            ResumeLayout(false);
        }
    }
}