namespace Asrfly.Gui.GuiHome
{
    partial class HomeUserControl
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBoxlogo = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonAddInput = new System.Windows.Forms.Button();
            this.buttonAddOutput = new System.Windows.Forms.Button();
            this.buttonAddUser = new System.Windows.Forms.Button();
            this.buttonAddproject = new System.Windows.Forms.Button();
            this.buttonAddSupplier = new System.Windows.Forms.Button();
            this.buttonAddCusomer = new System.Windows.Forms.Button();
            this.buttonAddCateg = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.labelCompanyName = new System.Windows.Forms.Label();
            this.labelWellcome = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxlogo)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.pictureBoxlogo);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 335);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(950, 106);
            this.panel1.TabIndex = 0;
            // 
            // pictureBoxlogo
            // 
            this.pictureBoxlogo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxlogo.Image = global::Asrfly.Properties.Resources.icons8_smart_96px;
            this.pictureBoxlogo.Location = new System.Drawing.Point(362, 0);
            this.pictureBoxlogo.Name = "pictureBoxlogo";
            this.pictureBoxlogo.Size = new System.Drawing.Size(46, 42);
            this.pictureBoxlogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxlogo.TabIndex = 3;
            this.pictureBoxlogo.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.buttonAddInput);
            this.groupBox1.Controls.Add(this.buttonAddOutput);
            this.groupBox1.Controls.Add(this.buttonAddUser);
            this.groupBox1.Controls.Add(this.buttonAddproject);
            this.groupBox1.Controls.Add(this.buttonAddSupplier);
            this.groupBox1.Controls.Add(this.buttonAddCusomer);
            this.groupBox1.Controls.Add(this.buttonAddCateg);
            this.groupBox1.Location = new System.Drawing.Point(3, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(944, 74);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "اضافة";
            // 
            // buttonAddInput
            // 
            this.buttonAddInput.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonAddInput.Image = global::Asrfly.Properties.Resources.icons8_input_32px;
            this.buttonAddInput.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAddInput.Location = new System.Drawing.Point(44, 23);
            this.buttonAddInput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonAddInput.Name = "buttonAddInput";
            this.buttonAddInput.Size = new System.Drawing.Size(114, 44);
            this.buttonAddInput.TabIndex = 7;
            this.buttonAddInput.Text = "قبض";
            this.buttonAddInput.UseVisualStyleBackColor = true;
            // 
            // buttonAddOutput
            // 
            this.buttonAddOutput.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonAddOutput.Image = global::Asrfly.Properties.Resources.icons8_output_32px;
            this.buttonAddOutput.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAddOutput.Location = new System.Drawing.Point(166, 23);
            this.buttonAddOutput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonAddOutput.Name = "buttonAddOutput";
            this.buttonAddOutput.Size = new System.Drawing.Size(114, 44);
            this.buttonAddOutput.TabIndex = 6;
            this.buttonAddOutput.Text = "صرف";
            this.buttonAddOutput.UseVisualStyleBackColor = true;
            // 
            // buttonAddUser
            // 
            this.buttonAddUser.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonAddUser.Image = global::Asrfly.Properties.Resources.icons8_users_32px;
            this.buttonAddUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAddUser.Location = new System.Drawing.Point(291, 23);
            this.buttonAddUser.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonAddUser.Name = "buttonAddUser";
            this.buttonAddUser.Size = new System.Drawing.Size(114, 44);
            this.buttonAddUser.TabIndex = 5;
            this.buttonAddUser.Text = "    مستخدم";
            this.buttonAddUser.UseVisualStyleBackColor = true;
            // 
            // buttonAddproject
            // 
            this.buttonAddproject.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonAddproject.Image = global::Asrfly.Properties.Resources.icons8_microsoft_project_32px;
            this.buttonAddproject.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAddproject.Location = new System.Drawing.Point(416, 23);
            this.buttonAddproject.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonAddproject.Name = "buttonAddproject";
            this.buttonAddproject.Size = new System.Drawing.Size(114, 44);
            this.buttonAddproject.TabIndex = 4;
            this.buttonAddproject.Text = "مشروع";
            this.buttonAddproject.UseVisualStyleBackColor = true;
            // 
            // buttonAddSupplier
            // 
            this.buttonAddSupplier.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonAddSupplier.Image = global::Asrfly.Properties.Resources.icons8_users_32px_1;
            this.buttonAddSupplier.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAddSupplier.Location = new System.Drawing.Point(538, 23);
            this.buttonAddSupplier.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonAddSupplier.Name = "buttonAddSupplier";
            this.buttonAddSupplier.Size = new System.Drawing.Size(114, 44);
            this.buttonAddSupplier.TabIndex = 3;
            this.buttonAddSupplier.Text = "مورد";
            this.buttonAddSupplier.UseVisualStyleBackColor = true;
            // 
            // buttonAddCusomer
            // 
            this.buttonAddCusomer.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonAddCusomer.Image = global::Asrfly.Properties.Resources.icons8_customer_insight_32px;
            this.buttonAddCusomer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAddCusomer.Location = new System.Drawing.Point(663, 23);
            this.buttonAddCusomer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonAddCusomer.Name = "buttonAddCusomer";
            this.buttonAddCusomer.Size = new System.Drawing.Size(114, 44);
            this.buttonAddCusomer.TabIndex = 2;
            this.buttonAddCusomer.Text = "عميل";
            this.buttonAddCusomer.UseVisualStyleBackColor = true;
            // 
            // buttonAddCateg
            // 
            this.buttonAddCateg.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonAddCateg.Image = global::Asrfly.Properties.Resources.icons8_categorize_32px;
            this.buttonAddCateg.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAddCateg.Location = new System.Drawing.Point(788, 23);
            this.buttonAddCateg.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonAddCateg.Name = "buttonAddCateg";
            this.buttonAddCateg.Size = new System.Drawing.Size(114, 44);
            this.buttonAddCateg.TabIndex = 1;
            this.buttonAddCateg.Text = "صنف";
            this.buttonAddCateg.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(405, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "الوصول السريع";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.labelCompanyName);
            this.panel2.Location = new System.Drawing.Point(666, 39);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(239, 76);
            this.panel2.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox2.Image = global::Asrfly.Properties.Resources.PicsArt_10_11_11_41_52;
            this.pictureBox2.Location = new System.Drawing.Point(138, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(101, 76);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // labelCompanyName
            // 
            this.labelCompanyName.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelCompanyName.Location = new System.Drawing.Point(3, 3);
            this.labelCompanyName.Name = "labelCompanyName";
            this.labelCompanyName.Size = new System.Drawing.Size(144, 70);
            this.labelCompanyName.TabIndex = 0;
            this.labelCompanyName.Text = "البدر اليماني ";
            this.labelCompanyName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelWellcome
            // 
            this.labelWellcome.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelWellcome.Location = new System.Drawing.Point(47, 39);
            this.labelWellcome.Name = "labelWellcome";
            this.labelWellcome.Size = new System.Drawing.Size(279, 70);
            this.labelWellcome.TabIndex = 0;
            this.labelWellcome.Text = "مرحبا بك مجدداً علي عدلان";
            this.labelWellcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HomeUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.labelWellcome);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.Name = "HomeUserControl";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(950, 441);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxlogo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonAddproject;
        private System.Windows.Forms.Button buttonAddSupplier;
        private System.Windows.Forms.Button buttonAddCusomer;
        private System.Windows.Forms.Button buttonAddCateg;
        private System.Windows.Forms.PictureBox pictureBoxlogo;
        private System.Windows.Forms.Button buttonAddInput;
        private System.Windows.Forms.Button buttonAddOutput;
        private System.Windows.Forms.Button buttonAddUser;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label labelCompanyName;
        private System.Windows.Forms.Label labelWellcome;
    }
}
