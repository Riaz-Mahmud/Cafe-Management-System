namespace CafeManagementSystem
{
    partial class HomeForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.removeItembtn = new System.Windows.Forms.Button();
            this.updateItemBtn = new System.Windows.Forms.Button();
            this.addItemBtn = new System.Windows.Forms.Button();
            this.placeOrderBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.placeOrderControl1 = new CafeManagementSystem.placeOrderControl();
            this.itemDeleteControl1 = new CafeManagementSystem.itemDeleteControl();
            this.itemUpdateControl1 = new CafeManagementSystem.itemUpdateControl();
            this.addItemControl1 = new CafeManagementSystem.addItemControl();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.removeItembtn);
            this.panel1.Controls.Add(this.updateItemBtn);
            this.panel1.Controls.Add(this.addItemBtn);
            this.panel1.Controls.Add(this.placeOrderBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(192, 656);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(38, 618);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Logout";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // removeItembtn
            // 
            this.removeItembtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.removeItembtn.FlatAppearance.BorderSize = 0;
            this.removeItembtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeItembtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeItembtn.ForeColor = System.Drawing.Color.White;
            this.removeItembtn.Location = new System.Drawing.Point(31, 183);
            this.removeItembtn.Name = "removeItembtn";
            this.removeItembtn.Size = new System.Drawing.Size(161, 51);
            this.removeItembtn.TabIndex = 3;
            this.removeItembtn.Text = "Remove Item";
            this.removeItembtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.removeItembtn.UseVisualStyleBackColor = true;
            this.removeItembtn.Click += new System.EventHandler(this.removeItembtn_Click);
            // 
            // updateItemBtn
            // 
            this.updateItemBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updateItemBtn.FlatAppearance.BorderSize = 0;
            this.updateItemBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateItemBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateItemBtn.ForeColor = System.Drawing.Color.White;
            this.updateItemBtn.Location = new System.Drawing.Point(31, 126);
            this.updateItemBtn.Name = "updateItemBtn";
            this.updateItemBtn.Size = new System.Drawing.Size(161, 51);
            this.updateItemBtn.TabIndex = 2;
            this.updateItemBtn.Text = "Update Item";
            this.updateItemBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.updateItemBtn.UseVisualStyleBackColor = true;
            this.updateItemBtn.Click += new System.EventHandler(this.updateItemBtn_Click);
            // 
            // addItemBtn
            // 
            this.addItemBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addItemBtn.FlatAppearance.BorderSize = 0;
            this.addItemBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addItemBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addItemBtn.ForeColor = System.Drawing.Color.White;
            this.addItemBtn.Location = new System.Drawing.Point(31, 69);
            this.addItemBtn.Name = "addItemBtn";
            this.addItemBtn.Size = new System.Drawing.Size(161, 51);
            this.addItemBtn.TabIndex = 1;
            this.addItemBtn.Text = "Add Item";
            this.addItemBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.addItemBtn.UseVisualStyleBackColor = true;
            this.addItemBtn.Click += new System.EventHandler(this.addItemBtn_Click);
            // 
            // placeOrderBtn
            // 
            this.placeOrderBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.placeOrderBtn.FlatAppearance.BorderSize = 0;
            this.placeOrderBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.placeOrderBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.placeOrderBtn.ForeColor = System.Drawing.Color.White;
            this.placeOrderBtn.Location = new System.Drawing.Point(31, 12);
            this.placeOrderBtn.Name = "placeOrderBtn";
            this.placeOrderBtn.Size = new System.Drawing.Size(161, 51);
            this.placeOrderBtn.TabIndex = 0;
            this.placeOrderBtn.Text = "Place Order";
            this.placeOrderBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.placeOrderBtn.UseVisualStyleBackColor = true;
            this.placeOrderBtn.Click += new System.EventHandler(this.placeOrderBtn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.placeOrderControl1);
            this.panel2.Controls.Add(this.itemDeleteControl1);
            this.panel2.Controls.Add(this.itemUpdateControl1);
            this.panel2.Controls.Add(this.addItemControl1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(192, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1097, 656);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // placeOrderControl1
            // 
            this.placeOrderControl1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.placeOrderControl1.Location = new System.Drawing.Point(0, 0);
            this.placeOrderControl1.Name = "placeOrderControl1";
            this.placeOrderControl1.Size = new System.Drawing.Size(1097, 656);
            this.placeOrderControl1.TabIndex = 4;
            // 
            // itemDeleteControl1
            // 
            this.itemDeleteControl1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.itemDeleteControl1.Location = new System.Drawing.Point(0, 0);
            this.itemDeleteControl1.Name = "itemDeleteControl1";
            this.itemDeleteControl1.Size = new System.Drawing.Size(1097, 656);
            this.itemDeleteControl1.TabIndex = 3;
            // 
            // itemUpdateControl1
            // 
            this.itemUpdateControl1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.itemUpdateControl1.Location = new System.Drawing.Point(0, 0);
            this.itemUpdateControl1.Name = "itemUpdateControl1";
            this.itemUpdateControl1.Size = new System.Drawing.Size(1097, 656);
            this.itemUpdateControl1.TabIndex = 2;
            // 
            // addItemControl1
            // 
            this.addItemControl1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.addItemControl1.Location = new System.Drawing.Point(0, 0);
            this.addItemControl1.Name = "addItemControl1";
            this.addItemControl1.Size = new System.Drawing.Size(1097, 656);
            this.addItemControl1.TabIndex = 1;
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1289, 656);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "HomeForm";
            this.Text = "HomeForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.HomeForm_FormClosed);
            this.Load += new System.EventHandler(this.HomeForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button updateItemBtn;
        private System.Windows.Forms.Button addItemBtn;
        private System.Windows.Forms.Button placeOrderBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button removeItembtn;
        private System.Windows.Forms.Label label1;
        private addItemControl addItemControl1;
        private itemUpdateControl itemUpdateControl1;
        private itemDeleteControl itemDeleteControl1;
        private placeOrderControl placeOrderControl1;
    }
}