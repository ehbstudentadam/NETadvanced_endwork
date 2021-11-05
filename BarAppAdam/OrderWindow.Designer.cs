namespace BarAppAdam
{
    partial class OrderWindow
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
            this.CounterBeer = new System.Windows.Forms.Label();
            this.ViewMember = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.Cancel = new System.Windows.Forms.Button();
            this.Done = new System.Windows.Forms.Button();
            this.ViewOrder = new System.Windows.Forms.ListView();
            this.AddBeer = new System.Windows.Forms.Button();
            this.RemoveBeer = new System.Windows.Forms.Button();
            this.PictureBeer = new System.Windows.Forms.PictureBox();
            this.CounterWine = new System.Windows.Forms.Label();
            this.AddWine = new System.Windows.Forms.Button();
            this.RemoveWine = new System.Windows.Forms.Button();
            this.PictureWine = new System.Windows.Forms.PictureBox();
            this.CounterSoftdrink = new System.Windows.Forms.Label();
            this.AddSoftdrink = new System.Windows.Forms.Button();
            this.RemoveSoftdrink = new System.Windows.Forms.Button();
            this.PictureSoftdrink = new System.Windows.Forms.PictureBox();
            this.CounterShot = new System.Windows.Forms.Label();
            this.AddShot = new System.Windows.Forms.Button();
            this.RemoveShot = new System.Windows.Forms.Button();
            this.PictureShot = new System.Windows.Forms.PictureBox();
            this.CounterCocktail = new System.Windows.Forms.Label();
            this.AddCocktail = new System.Windows.Forms.Button();
            this.RemoveCocktail = new System.Windows.Forms.Button();
            this.PictureCocktail = new System.Windows.Forms.PictureBox();
            this.PriceBeerLabel = new System.Windows.Forms.Label();
            this.PriceSoftdrinkLabel = new System.Windows.Forms.Label();
            this.PriceWineLabel = new System.Windows.Forms.Label();
            this.PriceShotLabel = new System.Windows.Forms.Label();
            this.PriceCocktailLabel = new System.Windows.Forms.Label();
            this.OrderTotalLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBeer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureWine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureSoftdrink)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureShot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureCocktail)).BeginInit();
            this.SuspendLayout();
            // 
            // CounterBeer
            // 
            this.CounterBeer.AutoSize = true;
            this.CounterBeer.Location = new System.Drawing.Point(132, 230);
            this.CounterBeer.Name = "CounterBeer";
            this.CounterBeer.Size = new System.Drawing.Size(13, 15);
            this.CounterBeer.TabIndex = 90;
            this.CounterBeer.Text = "0";
            // 
            // ViewMember
            // 
            this.ViewMember.Location = new System.Drawing.Point(630, 12);
            this.ViewMember.Name = "ViewMember";
            this.ViewMember.Size = new System.Drawing.Size(200, 336);
            this.ViewMember.TabIndex = 88;
            this.ViewMember.UseCompatibleStateImageBehavior = false;
            this.ViewMember.View = System.Windows.Forms.View.List;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(424, 354);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 15);
            this.label1.TabIndex = 87;
            this.label1.Text = "ORDER";
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(630, 610);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(200, 80);
            this.Cancel.TabIndex = 86;
            this.Cancel.Text = "CANCEL";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // Done
            // 
            this.Done.Location = new System.Drawing.Point(630, 354);
            this.Done.Name = "Done";
            this.Done.Size = new System.Drawing.Size(200, 250);
            this.Done.TabIndex = 85;
            this.Done.Text = "DONE";
            this.Done.UseVisualStyleBackColor = true;
            this.Done.Click += new System.EventHandler(this.Done_Click);
            // 
            // ViewOrder
            // 
            this.ViewOrder.Location = new System.Drawing.Point(424, 372);
            this.ViewOrder.Name = "ViewOrder";
            this.ViewOrder.Size = new System.Drawing.Size(200, 300);
            this.ViewOrder.TabIndex = 84;
            this.ViewOrder.UseCompatibleStateImageBehavior = false;
            this.ViewOrder.View = System.Windows.Forms.View.List;
            // 
            // AddBeer
            // 
            this.AddBeer.Location = new System.Drawing.Point(122, 268);
            this.AddBeer.Name = "AddBeer";
            this.AddBeer.Size = new System.Drawing.Size(80, 80);
            this.AddBeer.TabIndex = 71;
            this.AddBeer.Text = "+";
            this.AddBeer.UseVisualStyleBackColor = true;
            this.AddBeer.Click += new System.EventHandler(this.AddBeer_Click);
            // 
            // RemoveBeer
            // 
            this.RemoveBeer.Location = new System.Drawing.Point(21, 268);
            this.RemoveBeer.Name = "RemoveBeer";
            this.RemoveBeer.Size = new System.Drawing.Size(80, 80);
            this.RemoveBeer.TabIndex = 70;
            this.RemoveBeer.Text = "-";
            this.RemoveBeer.UseVisualStyleBackColor = true;
            this.RemoveBeer.Click += new System.EventHandler(this.RemoveBeer_Click);
            // 
            // PictureBeer
            // 
            this.PictureBeer.Image = global::BarAppAdam.Properties.Resources.Beer;
            this.PictureBeer.Location = new System.Drawing.Point(12, 12);
            this.PictureBeer.Name = "PictureBeer";
            this.PictureBeer.Size = new System.Drawing.Size(200, 250);
            this.PictureBeer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBeer.TabIndex = 69;
            this.PictureBeer.TabStop = false;
            // 
            // CounterWine
            // 
            this.CounterWine.AutoSize = true;
            this.CounterWine.Location = new System.Drawing.Point(338, 230);
            this.CounterWine.Name = "CounterWine";
            this.CounterWine.Size = new System.Drawing.Size(13, 15);
            this.CounterWine.TabIndex = 94;
            this.CounterWine.Text = "0";
            // 
            // AddWine
            // 
            this.AddWine.Location = new System.Drawing.Point(328, 268);
            this.AddWine.Name = "AddWine";
            this.AddWine.Size = new System.Drawing.Size(80, 80);
            this.AddWine.TabIndex = 93;
            this.AddWine.Text = "+";
            this.AddWine.UseVisualStyleBackColor = true;
            this.AddWine.Click += new System.EventHandler(this.AddWine_Click);
            // 
            // RemoveWine
            // 
            this.RemoveWine.Location = new System.Drawing.Point(227, 268);
            this.RemoveWine.Name = "RemoveWine";
            this.RemoveWine.Size = new System.Drawing.Size(80, 80);
            this.RemoveWine.TabIndex = 92;
            this.RemoveWine.Text = "-";
            this.RemoveWine.UseVisualStyleBackColor = true;
            this.RemoveWine.Click += new System.EventHandler(this.RemoveWine_Click);
            // 
            // PictureWine
            // 
            this.PictureWine.Image = global::BarAppAdam.Properties.Resources.Wine;
            this.PictureWine.Location = new System.Drawing.Point(218, 12);
            this.PictureWine.Name = "PictureWine";
            this.PictureWine.Size = new System.Drawing.Size(200, 250);
            this.PictureWine.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureWine.TabIndex = 91;
            this.PictureWine.TabStop = false;
            // 
            // CounterSoftdrink
            // 
            this.CounterSoftdrink.AutoSize = true;
            this.CounterSoftdrink.Location = new System.Drawing.Point(544, 230);
            this.CounterSoftdrink.Name = "CounterSoftdrink";
            this.CounterSoftdrink.Size = new System.Drawing.Size(13, 15);
            this.CounterSoftdrink.TabIndex = 98;
            this.CounterSoftdrink.Text = "0";
            // 
            // AddSoftdrink
            // 
            this.AddSoftdrink.Location = new System.Drawing.Point(534, 268);
            this.AddSoftdrink.Name = "AddSoftdrink";
            this.AddSoftdrink.Size = new System.Drawing.Size(80, 80);
            this.AddSoftdrink.TabIndex = 97;
            this.AddSoftdrink.Text = "+";
            this.AddSoftdrink.UseVisualStyleBackColor = true;
            this.AddSoftdrink.Click += new System.EventHandler(this.AddSoftdrink_Click);
            // 
            // RemoveSoftdrink
            // 
            this.RemoveSoftdrink.Location = new System.Drawing.Point(433, 268);
            this.RemoveSoftdrink.Name = "RemoveSoftdrink";
            this.RemoveSoftdrink.Size = new System.Drawing.Size(80, 80);
            this.RemoveSoftdrink.TabIndex = 96;
            this.RemoveSoftdrink.Text = "-";
            this.RemoveSoftdrink.UseVisualStyleBackColor = true;
            this.RemoveSoftdrink.Click += new System.EventHandler(this.RemoveSoftdrink_Click);
            // 
            // PictureSoftdrink
            // 
            this.PictureSoftdrink.Image = global::BarAppAdam.Properties.Resources.Softdrink;
            this.PictureSoftdrink.Location = new System.Drawing.Point(424, 12);
            this.PictureSoftdrink.Name = "PictureSoftdrink";
            this.PictureSoftdrink.Size = new System.Drawing.Size(200, 250);
            this.PictureSoftdrink.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureSoftdrink.TabIndex = 95;
            this.PictureSoftdrink.TabStop = false;
            // 
            // CounterShot
            // 
            this.CounterShot.AutoSize = true;
            this.CounterShot.Location = new System.Drawing.Point(132, 572);
            this.CounterShot.Name = "CounterShot";
            this.CounterShot.Size = new System.Drawing.Size(13, 15);
            this.CounterShot.TabIndex = 102;
            this.CounterShot.Text = "0";
            // 
            // AddShot
            // 
            this.AddShot.Location = new System.Drawing.Point(122, 610);
            this.AddShot.Name = "AddShot";
            this.AddShot.Size = new System.Drawing.Size(80, 80);
            this.AddShot.TabIndex = 101;
            this.AddShot.Text = "+";
            this.AddShot.UseVisualStyleBackColor = true;
            this.AddShot.Click += new System.EventHandler(this.AddShot_Click);
            // 
            // RemoveShot
            // 
            this.RemoveShot.Location = new System.Drawing.Point(21, 610);
            this.RemoveShot.Name = "RemoveShot";
            this.RemoveShot.Size = new System.Drawing.Size(80, 80);
            this.RemoveShot.TabIndex = 100;
            this.RemoveShot.Text = "-";
            this.RemoveShot.UseVisualStyleBackColor = true;
            this.RemoveShot.Click += new System.EventHandler(this.RemoveShot_Click);
            // 
            // PictureShot
            // 
            this.PictureShot.Image = global::BarAppAdam.Properties.Resources.Shot;
            this.PictureShot.Location = new System.Drawing.Point(12, 354);
            this.PictureShot.Name = "PictureShot";
            this.PictureShot.Size = new System.Drawing.Size(200, 250);
            this.PictureShot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureShot.TabIndex = 99;
            this.PictureShot.TabStop = false;
            // 
            // CounterCocktail
            // 
            this.CounterCocktail.AutoSize = true;
            this.CounterCocktail.Location = new System.Drawing.Point(338, 572);
            this.CounterCocktail.Name = "CounterCocktail";
            this.CounterCocktail.Size = new System.Drawing.Size(13, 15);
            this.CounterCocktail.TabIndex = 106;
            this.CounterCocktail.Text = "0";
            // 
            // AddCocktail
            // 
            this.AddCocktail.Location = new System.Drawing.Point(328, 610);
            this.AddCocktail.Name = "AddCocktail";
            this.AddCocktail.Size = new System.Drawing.Size(80, 80);
            this.AddCocktail.TabIndex = 105;
            this.AddCocktail.Text = "+";
            this.AddCocktail.UseVisualStyleBackColor = true;
            this.AddCocktail.Click += new System.EventHandler(this.AddCocktail_Click);
            // 
            // RemoveCocktail
            // 
            this.RemoveCocktail.Location = new System.Drawing.Point(227, 610);
            this.RemoveCocktail.Name = "RemoveCocktail";
            this.RemoveCocktail.Size = new System.Drawing.Size(80, 80);
            this.RemoveCocktail.TabIndex = 104;
            this.RemoveCocktail.Text = "-";
            this.RemoveCocktail.UseVisualStyleBackColor = true;
            this.RemoveCocktail.Click += new System.EventHandler(this.RemoveCocktail_Click);
            // 
            // PictureCocktail
            // 
            this.PictureCocktail.Image = global::BarAppAdam.Properties.Resources.Cocktail;
            this.PictureCocktail.Location = new System.Drawing.Point(218, 354);
            this.PictureCocktail.Name = "PictureCocktail";
            this.PictureCocktail.Size = new System.Drawing.Size(200, 250);
            this.PictureCocktail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureCocktail.TabIndex = 103;
            this.PictureCocktail.TabStop = false;
            // 
            // PriceBeerLabel
            // 
            this.PriceBeerLabel.AutoSize = true;
            this.PriceBeerLabel.Location = new System.Drawing.Point(12, 12);
            this.PriceBeerLabel.Name = "PriceBeerLabel";
            this.PriceBeerLabel.Size = new System.Drawing.Size(45, 15);
            this.PriceBeerLabel.TabIndex = 107;
            this.PriceBeerLabel.Text = "Price: 0";
            // 
            // PriceSoftdrinkLabel
            // 
            this.PriceSoftdrinkLabel.AutoSize = true;
            this.PriceSoftdrinkLabel.Location = new System.Drawing.Point(424, 12);
            this.PriceSoftdrinkLabel.Name = "PriceSoftdrinkLabel";
            this.PriceSoftdrinkLabel.Size = new System.Drawing.Size(45, 15);
            this.PriceSoftdrinkLabel.TabIndex = 108;
            this.PriceSoftdrinkLabel.Text = "Price: 0";
            // 
            // PriceWineLabel
            // 
            this.PriceWineLabel.AutoSize = true;
            this.PriceWineLabel.Location = new System.Drawing.Point(218, 12);
            this.PriceWineLabel.Name = "PriceWineLabel";
            this.PriceWineLabel.Size = new System.Drawing.Size(45, 15);
            this.PriceWineLabel.TabIndex = 109;
            this.PriceWineLabel.Text = "Price: 0";
            // 
            // PriceShotLabel
            // 
            this.PriceShotLabel.AutoSize = true;
            this.PriceShotLabel.Location = new System.Drawing.Point(12, 354);
            this.PriceShotLabel.Name = "PriceShotLabel";
            this.PriceShotLabel.Size = new System.Drawing.Size(45, 15);
            this.PriceShotLabel.TabIndex = 110;
            this.PriceShotLabel.Text = "Price: 0";
            // 
            // PriceCocktailLabel
            // 
            this.PriceCocktailLabel.AutoSize = true;
            this.PriceCocktailLabel.Location = new System.Drawing.Point(218, 354);
            this.PriceCocktailLabel.Name = "PriceCocktailLabel";
            this.PriceCocktailLabel.Size = new System.Drawing.Size(45, 15);
            this.PriceCocktailLabel.TabIndex = 111;
            this.PriceCocktailLabel.Text = "Price: 0";
            // 
            // OrderTotalLabel
            // 
            this.OrderTotalLabel.AutoSize = true;
            this.OrderTotalLabel.Location = new System.Drawing.Point(424, 675);
            this.OrderTotalLabel.Name = "OrderTotalLabel";
            this.OrderTotalLabel.Size = new System.Drawing.Size(82, 15);
            this.OrderTotalLabel.TabIndex = 112;
            this.OrderTotalLabel.Text = "ORDER TOTAL:";
            // 
            // OrderWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 702);
            this.Controls.Add(this.OrderTotalLabel);
            this.Controls.Add(this.PriceCocktailLabel);
            this.Controls.Add(this.PriceShotLabel);
            this.Controls.Add(this.PriceWineLabel);
            this.Controls.Add(this.PriceSoftdrinkLabel);
            this.Controls.Add(this.PriceBeerLabel);
            this.Controls.Add(this.CounterCocktail);
            this.Controls.Add(this.AddCocktail);
            this.Controls.Add(this.RemoveCocktail);
            this.Controls.Add(this.PictureCocktail);
            this.Controls.Add(this.CounterShot);
            this.Controls.Add(this.AddShot);
            this.Controls.Add(this.RemoveShot);
            this.Controls.Add(this.PictureShot);
            this.Controls.Add(this.CounterSoftdrink);
            this.Controls.Add(this.AddSoftdrink);
            this.Controls.Add(this.RemoveSoftdrink);
            this.Controls.Add(this.PictureSoftdrink);
            this.Controls.Add(this.CounterWine);
            this.Controls.Add(this.AddWine);
            this.Controls.Add(this.RemoveWine);
            this.Controls.Add(this.PictureWine);
            this.Controls.Add(this.CounterBeer);
            this.Controls.Add(this.ViewMember);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Done);
            this.Controls.Add(this.ViewOrder);
            this.Controls.Add(this.AddBeer);
            this.Controls.Add(this.RemoveBeer);
            this.Controls.Add(this.PictureBeer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OrderWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "OrderWindow";
            ((System.ComponentModel.ISupportInitialize)(this.PictureBeer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureWine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureSoftdrink)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureShot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureCocktail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label CounterBeer;
        private ListView ViewMember;
        private Label label1;
        private Button Cancel;
        private Button Done;
        private ListView ViewOrder;
        private Button AddBeer;
        private Button RemoveBeer;
        private PictureBox PictureBeer;
        private Label CounterWine;
        private Button AddWine;
        private Button RemoveWine;
        private PictureBox PictureWine;
        private Label CounterSoftdrink;
        private Button AddSoftdrink;
        private Button RemoveSoftdrink;
        private PictureBox PictureSoftdrink;
        private Label CounterShot;
        private Button AddShot;
        private Button RemoveShot;
        private PictureBox PictureShot;
        private Label CounterCocktail;
        private Button AddCocktail;
        private Button RemoveCocktail;
        private PictureBox PictureCocktail;
        private Label PriceBeerLabel;
        private Label PriceSoftdrinkLabel;
        private Label PriceWineLabel;
        private Label PriceShotLabel;
        private Label PriceCocktailLabel;
        private Label OrderTotalLabel;
    }
}