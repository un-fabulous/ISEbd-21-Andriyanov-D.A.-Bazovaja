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
            this.groupBoxParams = new System.Windows.Forms.GroupBox();
            this.checkBoxSupport = new System.Windows.Forms.CheckBox();
            this.checkBoxCarcass = new System.Windows.Forms.CheckBox();
            this.numericUpDownWeight = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownSpeed = new System.Windows.Forms.NumericUpDown();
            this.labelWeight = new System.Windows.Forms.Label();
            this.labelSpeed = new System.Windows.Forms.Label();
            this.pictureBoxCar = new System.Windows.Forms.PictureBox();
            this.groupBoxType = new System.Windows.Forms.GroupBox();
            this.labelSamosval = new System.Windows.Forms.Label();
            this.labelGruzovik = new System.Windows.Forms.Label();
            this.panelCar = new System.Windows.Forms.Panel();
            this.groupBoxColors = new System.Windows.Forms.GroupBox();
            this.labelDopColor = new System.Windows.Forms.Label();
            this.labelMainColor = new System.Windows.Forms.Label();
            this.panelBlue = new System.Windows.Forms.Panel();
            this.panelGreen = new System.Windows.Forms.Panel();
            this.panelGold = new System.Windows.Forms.Panel();
            this.panelGray = new System.Windows.Forms.Panel();
            this.panelWhite = new System.Windows.Forms.Panel();
            this.panelBlack = new System.Windows.Forms.Panel();
            this.panelYellow = new System.Windows.Forms.Panel();
            this.panelRed = new System.Windows.Forms.Panel();
            this.buttonCr = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.groupBoxParams.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCar)).BeginInit();
            this.groupBoxType.SuspendLayout();
            this.panelCar.SuspendLayout();
            this.groupBoxColors.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxParams
            // 
            this.groupBoxParams.Controls.Add(this.checkBoxSupport);
            this.groupBoxParams.Controls.Add(this.checkBoxCarcass);
            this.groupBoxParams.Controls.Add(this.numericUpDownWeight);
            this.groupBoxParams.Controls.Add(this.numericUpDownSpeed);
            this.groupBoxParams.Controls.Add(this.labelWeight);
            this.groupBoxParams.Controls.Add(this.labelSpeed);
            this.groupBoxParams.Location = new System.Drawing.Point(12, 130);
            this.groupBoxParams.Name = "groupBoxParams";
            this.groupBoxParams.Size = new System.Drawing.Size(287, 109);
            this.groupBoxParams.TabIndex = 0;
            this.groupBoxParams.TabStop = false;
            this.groupBoxParams.Text = "Параметры";
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
            // labelWeight
            // 
            this.labelWeight.AutoSize = true;
            this.labelWeight.Location = new System.Drawing.Point(7, 60);
            this.labelWeight.Name = "labelWeight";
            this.labelWeight.Size = new System.Drawing.Size(55, 13);
            this.labelWeight.TabIndex = 1;
            this.labelWeight.Text = "Вес авто:";
            // 
            // labelSpeed
            // 
            this.labelSpeed.AutoSize = true;
            this.labelSpeed.Location = new System.Drawing.Point(7, 20);
            this.labelSpeed.Name = "labelSpeed";
            this.labelSpeed.Size = new System.Drawing.Size(90, 13);
            this.labelSpeed.TabIndex = 0;
            this.labelSpeed.Text = "Макс. скорость:";
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
            // groupBoxType
            // 
            this.groupBoxType.Controls.Add(this.labelSamosval);
            this.groupBoxType.Controls.Add(this.labelGruzovik);
            this.groupBoxType.Location = new System.Drawing.Point(12, 12);
            this.groupBoxType.Name = "groupBoxType";
            this.groupBoxType.Size = new System.Drawing.Size(143, 112);
            this.groupBoxType.TabIndex = 2;
            this.groupBoxType.TabStop = false;
            this.groupBoxType.Text = "Тип";
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
            // groupBoxColors
            // 
            this.groupBoxColors.Controls.Add(this.labelDopColor);
            this.groupBoxColors.Controls.Add(this.labelMainColor);
            this.groupBoxColors.Controls.Add(this.panelBlue);
            this.groupBoxColors.Controls.Add(this.panelGreen);
            this.groupBoxColors.Controls.Add(this.panelGold);
            this.groupBoxColors.Controls.Add(this.panelGray);
            this.groupBoxColors.Controls.Add(this.panelWhite);
            this.groupBoxColors.Controls.Add(this.panelBlack);
            this.groupBoxColors.Controls.Add(this.panelYellow);
            this.groupBoxColors.Controls.Add(this.panelRed);
            this.groupBoxColors.Location = new System.Drawing.Point(348, 24);
            this.groupBoxColors.Name = "groupBoxColors";
            this.groupBoxColors.Size = new System.Drawing.Size(154, 139);
            this.groupBoxColors.TabIndex = 4;
            this.groupBoxColors.TabStop = false;
            this.groupBoxColors.Text = "Цвета";
            // 
            // labelDopColor
            // 
            this.labelDopColor.AllowDrop = true;
            this.labelDopColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelDopColor.Location = new System.Drawing.Point(78, 21);
            this.labelDopColor.Name = "labelDopColor";
            this.labelDopColor.Size = new System.Drawing.Size(66, 23);
            this.labelDopColor.TabIndex = 3;
            this.labelDopColor.Text = "Доп. цвет";
            this.labelDopColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelDopColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelDopColor_DragDrop);
            this.labelDopColor.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelBaseColor_DragEnter);
            // 
            // labelMainColor
            // 
            this.labelMainColor.AllowDrop = true;
            this.labelMainColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelMainColor.Location = new System.Drawing.Point(6, 21);
            this.labelMainColor.Name = "labelMainColor";
            this.labelMainColor.Size = new System.Drawing.Size(66, 23);
            this.labelMainColor.TabIndex = 2;
            this.labelMainColor.Text = "Осн. цвет";
            this.labelMainColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelMainColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelBaseColor_DragDrop);
            this.labelMainColor.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelBaseColor_DragEnter);
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
            // panelGray
            // 
            this.panelGray.AllowDrop = true;
            this.panelGray.BackColor = System.Drawing.Color.Gray;
            this.panelGray.Location = new System.Drawing.Point(6, 91);
            this.panelGray.Name = "panelGray";
            this.panelGray.Size = new System.Drawing.Size(30, 32);
            this.panelGray.TabIndex = 1;
            this.panelGray.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
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
            this.Controls.Add(this.groupBoxColors);
            this.Controls.Add(this.panelCar);
            this.Controls.Add(this.groupBoxType);
            this.Controls.Add(this.groupBoxParams);
            this.Name = "FormCarConfig";
            this.Text = "Выбор машины";
            this.groupBoxParams.ResumeLayout(false);
            this.groupBoxParams.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCar)).EndInit();
            this.groupBoxType.ResumeLayout(false);
            this.panelCar.ResumeLayout(false);
            this.groupBoxColors.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxParams;
        private System.Windows.Forms.CheckBox checkBoxSupport;
        private System.Windows.Forms.CheckBox checkBoxCarcass;
        private System.Windows.Forms.NumericUpDown numericUpDownWeight;
        private System.Windows.Forms.NumericUpDown numericUpDownSpeed;
        private System.Windows.Forms.Label labelWeight;
        private System.Windows.Forms.Label labelSpeed;
        private System.Windows.Forms.PictureBox pictureBoxCar;
        private System.Windows.Forms.GroupBox groupBoxType;
        private System.Windows.Forms.Label labelSamosval;
        private System.Windows.Forms.Label labelGruzovik;
        private System.Windows.Forms.Panel panelCar;
        private System.Windows.Forms.GroupBox groupBoxColors;
        private System.Windows.Forms.Label labelDopColor;
        private System.Windows.Forms.Label labelMainColor;
        private System.Windows.Forms.Panel panelBlue;
        private System.Windows.Forms.Panel panelGreen;
        private System.Windows.Forms.Panel panelGold;
        private System.Windows.Forms.Panel panelGray;
        private System.Windows.Forms.Panel panelWhite;
        private System.Windows.Forms.Panel panelBlack;
        private System.Windows.Forms.Panel panelYellow;
        private System.Windows.Forms.Panel panelRed;
        private System.Windows.Forms.Button buttonCr;
        private System.Windows.Forms.Button buttonCancel;
    }
}