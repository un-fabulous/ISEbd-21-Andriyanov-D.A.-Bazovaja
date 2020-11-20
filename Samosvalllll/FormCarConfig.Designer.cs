namespace Samosvalllll
{
    partial class FormCarConfig
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.checkBoxSupport = new System.Windows.Forms.CheckBox();
			this.checkBoxCarcass = new System.Windows.Forms.CheckBox();
			this.numericUpDownWeight = new System.Windows.Forms.NumericUpDown();
			this.numericUpDownSpeed = new System.Windows.Forms.NumericUpDown();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.pictureBoxCar = new System.Windows.Forms.PictureBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.labelSamosval = new System.Windows.Forms.Label();
			this.labelGruzovik = new System.Windows.Forms.Label();
			this.panelCar = new System.Windows.Forms.Panel();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.panelBlue = new System.Windows.Forms.Panel();
			this.panelGreen = new System.Windows.Forms.Panel();
			this.panelGold = new System.Windows.Forms.Panel();
			this.panelGrey = new System.Windows.Forms.Panel();
			this.panelWhite = new System.Windows.Forms.Panel();
			this.panelBlack = new System.Windows.Forms.Panel();
			this.panelYellow = new System.Windows.Forms.Panel();
			this.panelRed = new System.Windows.Forms.Panel();
			this.buttonCr = new System.Windows.Forms.Button();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownWeight)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownSpeed)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxCar)).BeginInit();
			this.groupBox2.SuspendLayout();
			this.panelCar.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.checkBoxSupport);
			this.groupBox1.Controls.Add(this.checkBoxCarcass);
			this.groupBox1.Controls.Add(this.numericUpDownWeight);
			this.groupBox1.Controls.Add(this.numericUpDownSpeed);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(12, 130);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(287, 109);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Параметры";
			// 
			// checkBoxSupport
			// 
			this.checkBoxSupport.AutoSize = true;
			this.checkBoxSupport.Location = new System.Drawing.Point(149, 76);
			this.checkBoxSupport.Name = "checkBoxSupport";
			this.checkBoxSupport.Size = new System.Drawing.Size(58, 17);
			this.checkBoxSupport.TabIndex = 6;
			this.checkBoxSupport.Text = "Опора";
			this.checkBoxSupport.UseVisualStyleBackColor = true;
			// 
			// checkBoxCarcass
			// 
			this.checkBoxCarcass.AutoSize = true;
			this.checkBoxCarcass.Location = new System.Drawing.Point(149, 37);
			this.checkBoxCarcass.Name = "checkBoxCarcass";
			this.checkBoxCarcass.Size = new System.Drawing.Size(56, 17);
			this.checkBoxCarcass.TabIndex = 5;
			this.checkBoxCarcass.Text = "Кузов";
			this.checkBoxCarcass.UseVisualStyleBackColor = true;
			// 
			// numericUpDownWeight
			// 
			this.numericUpDownWeight.Location = new System.Drawing.Point(35, 76);
			this.numericUpDownWeight.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			this.numericUpDownWeight.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
			this.numericUpDownWeight.Name = "numericUpDownWeight";
			this.numericUpDownWeight.Size = new System.Drawing.Size(62, 20);
			this.numericUpDownWeight.TabIndex = 3;
			this.numericUpDownWeight.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
			// 
			// numericUpDownSpeed
			// 
			this.numericUpDownSpeed.Location = new System.Drawing.Point(35, 37);
			this.numericUpDownSpeed.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			this.numericUpDownSpeed.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
			this.numericUpDownSpeed.Name = "numericUpDownSpeed";
			this.numericUpDownSpeed.Size = new System.Drawing.Size(62, 20);
			this.numericUpDownSpeed.TabIndex = 2;
			this.numericUpDownSpeed.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(7, 60);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(55, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Вес авто:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(7, 20);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(90, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Макс. скорость:";
			// 
			// pictureBoxCar
			// 
			this.pictureBoxCar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureBoxCar.Location = new System.Drawing.Point(3, 3);
			this.pictureBoxCar.Name = "pictureBoxCar";
			this.pictureBoxCar.Size = new System.Drawing.Size(173, 104);
			this.pictureBoxCar.TabIndex = 1;
			this.pictureBoxCar.TabStop = false;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.labelSamosval);
			this.groupBox2.Controls.Add(this.labelGruzovik);
			this.groupBox2.Location = new System.Drawing.Point(12, 12);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(143, 112);
			this.groupBox2.TabIndex = 2;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Тип";
			// 
			// labelSamosval
			// 
			this.labelSamosval.AllowDrop = true;
			this.labelSamosval.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.labelSamosval.Location = new System.Drawing.Point(21, 63);
			this.labelSamosval.Name = "labelSamosval";
			this.labelSamosval.Size = new System.Drawing.Size(100, 23);
			this.labelSamosval.TabIndex = 1;
			this.labelSamosval.Text = "Самосвал";
			this.labelSamosval.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.labelSamosval.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelSamosval_MouseDown);
			// 
			// labelGruzovik
			// 
			this.labelGruzovik.AllowDrop = true;
			this.labelGruzovik.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.labelGruzovik.Location = new System.Drawing.Point(21, 29);
			this.labelGruzovik.Name = "labelGruzovik";
			this.labelGruzovik.Size = new System.Drawing.Size(100, 23);
			this.labelGruzovik.TabIndex = 0;
			this.labelGruzovik.Text = "Грузовик";
			this.labelGruzovik.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.labelGruzovik.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelGruzovik_MouseDown);
			// 
			// panelCar
			// 
			this.panelCar.AllowDrop = true;
			this.panelCar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panelCar.Controls.Add(this.pictureBoxCar);
			this.panelCar.Location = new System.Drawing.Point(161, 3);
			this.panelCar.Name = "panelCar";
			this.panelCar.Size = new System.Drawing.Size(181, 121);
			this.panelCar.TabIndex = 3;
			this.panelCar.DragDrop += new System.Windows.Forms.DragEventHandler(this.panelCar_DragDrop);
			this.panelCar.DragEnter += new System.Windows.Forms.DragEventHandler(this.panelCar_DragEnter);
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.label4);
			this.groupBox3.Controls.Add(this.label3);
			this.groupBox3.Controls.Add(this.panelBlue);
			this.groupBox3.Controls.Add(this.panelGreen);
			this.groupBox3.Controls.Add(this.panelGold);
			this.groupBox3.Controls.Add(this.panelGrey);
			this.groupBox3.Controls.Add(this.panelWhite);
			this.groupBox3.Controls.Add(this.panelBlack);
			this.groupBox3.Controls.Add(this.panelYellow);
			this.groupBox3.Controls.Add(this.panelRed);
			this.groupBox3.Location = new System.Drawing.Point(348, 24);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(154, 139);
			this.groupBox3.TabIndex = 4;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Цвета";
			// 
			// label4
			// 
			this.label4.AllowDrop = true;
			this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label4.Location = new System.Drawing.Point(78, 21);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(66, 23);
			this.label4.TabIndex = 3;
			this.label4.Text = "Доп. цвет";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.label4.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelDopColor_DragDrop);
			this.label4.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelBaseColor_DragEnter);
			// 
			// label3
			// 
			this.label3.AllowDrop = true;
			this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label3.Location = new System.Drawing.Point(6, 21);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(66, 23);
			this.label3.TabIndex = 2;
			this.label3.Text = "Осн. цвет";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.label3.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelBaseColor_DragDrop);
			this.label3.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelBaseColor_DragEnter);
			// 
			// panelBlue
			// 
			this.panelBlue.AllowDrop = true;
			this.panelBlue.BackColor = System.Drawing.Color.Blue;
			this.panelBlue.Location = new System.Drawing.Point(114, 91);
			this.panelBlue.Name = "panelBlue";
			this.panelBlue.Size = new System.Drawing.Size(30, 32);
			this.panelBlue.TabIndex = 1;
			this.panelBlue.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
			// 
			// panelGreen
			// 
			this.panelGreen.AllowDrop = true;
			this.panelGreen.BackColor = System.Drawing.Color.Green;
			this.panelGreen.Location = new System.Drawing.Point(78, 91);
			this.panelGreen.Name = "panelGreen";
			this.panelGreen.Size = new System.Drawing.Size(30, 32);
			this.panelGreen.TabIndex = 1;
			this.panelGreen.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
			// 
			// panelGold
			// 
			this.panelGold.AllowDrop = true;
			this.panelGold.BackColor = System.Drawing.Color.Gold;
			this.panelGold.Location = new System.Drawing.Point(42, 91);
			this.panelGold.Name = "panelGold";
			this.panelGold.Size = new System.Drawing.Size(30, 32);
			this.panelGold.TabIndex = 1;
			this.panelGold.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
			// 
			// panelGrey
			// 
			this.panelGrey.AllowDrop = true;
			this.panelGrey.BackColor = System.Drawing.Color.Gray;
			this.panelGrey.Location = new System.Drawing.Point(6, 91);
			this.panelGrey.Name = "panelGrey";
			this.panelGrey.Size = new System.Drawing.Size(30, 32);
			this.panelGrey.TabIndex = 1;
			this.panelGrey.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
			// 
			// panelWhite
			// 
			this.panelWhite.AllowDrop = true;
			this.panelWhite.BackColor = System.Drawing.Color.White;
			this.panelWhite.Location = new System.Drawing.Point(114, 53);
			this.panelWhite.Name = "panelWhite";
			this.panelWhite.Size = new System.Drawing.Size(30, 32);
			this.panelWhite.TabIndex = 1;
			this.panelWhite.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
			// 
			// panelBlack
			// 
			this.panelBlack.AllowDrop = true;
			this.panelBlack.BackColor = System.Drawing.Color.Black;
			this.panelBlack.Location = new System.Drawing.Point(78, 53);
			this.panelBlack.Name = "panelBlack";
			this.panelBlack.Size = new System.Drawing.Size(30, 32);
			this.panelBlack.TabIndex = 1;
			this.panelBlack.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
			// 
			// panelYellow
			// 
			this.panelYellow.AllowDrop = true;
			this.panelYellow.BackColor = System.Drawing.Color.Yellow;
			this.panelYellow.Location = new System.Drawing.Point(42, 53);
			this.panelYellow.Name = "panelYellow";
			this.panelYellow.Size = new System.Drawing.Size(30, 32);
			this.panelYellow.TabIndex = 1;
			this.panelYellow.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
			// 
			// panelRed
			// 
			this.panelRed.AllowDrop = true;
			this.panelRed.BackColor = System.Drawing.Color.Red;
			this.panelRed.Location = new System.Drawing.Point(6, 53);
			this.panelRed.Name = "panelRed";
			this.panelRed.Size = new System.Drawing.Size(30, 32);
			this.panelRed.TabIndex = 0;
			this.panelRed.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
			// 
			// buttonCr
			// 
			this.buttonCr.Location = new System.Drawing.Point(427, 178);
			this.buttonCr.Name = "buttonCr";
			this.buttonCr.Size = new System.Drawing.Size(75, 23);
			this.buttonCr.TabIndex = 5;
			this.buttonCr.Text = "Добавить";
			this.buttonCr.UseVisualStyleBackColor = true;
			this.buttonCr.Click += new System.EventHandler(this.buttonCr_Click);
			// 
			// buttonCancel
			// 
			this.buttonCancel.Location = new System.Drawing.Point(427, 209);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(75, 23);
			this.buttonCancel.TabIndex = 6;
			this.buttonCancel.Text = "Отмена";
			this.buttonCancel.UseVisualStyleBackColor = true;
			// 
			// FormCarConfig
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(514, 244);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.buttonCr);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.panelCar);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Name = "FormCarConfig";
			this.Text = "Выбор машины";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownWeight)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownSpeed)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxCar)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.panelCar.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBoxSupport;
        private System.Windows.Forms.CheckBox checkBoxCarcass;
        private System.Windows.Forms.NumericUpDown numericUpDownWeight;
        private System.Windows.Forms.NumericUpDown numericUpDownSpeed;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBoxCar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label labelSamosval;
        private System.Windows.Forms.Label labelGruzovik;
        private System.Windows.Forms.Panel panelCar;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panelBlue;
        private System.Windows.Forms.Panel panelGreen;
        private System.Windows.Forms.Panel panelGold;
        private System.Windows.Forms.Panel panelGrey;
        private System.Windows.Forms.Panel panelWhite;
        private System.Windows.Forms.Panel panelBlack;
        private System.Windows.Forms.Panel panelYellow;
        private System.Windows.Forms.Panel panelRed;
        private System.Windows.Forms.Button buttonCr;
        private System.Windows.Forms.Button buttonCancel;
    }
}