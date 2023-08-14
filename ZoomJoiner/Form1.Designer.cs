namespace ZoomJoiner
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ButtonUkr = new System.Windows.Forms.Button();
            this.ButtonPravo = new System.Windows.Forms.Button();
            this.ButtonMath = new System.Windows.Forms.Button();
            this.ButtonBioliga = new System.Windows.Forms.Button();
            this.ButtonArt = new System.Windows.Forms.Button();
            this.ButtonOsvita = new System.Windows.Forms.Button();
            this.ButtonEng = new System.Windows.Forms.Button();
            this.ButtonHistory = new System.Windows.Forms.Button();
            this.ButtonGeugraphy = new System.Windows.Forms.Button();
            this.ButtonPhysics = new System.Windows.Forms.Button();
            this.ButtonLibrary = new System.Windows.Forms.Button();
            this.ButtonChemistry = new System.Windows.Forms.Button();
            this.ButtonTo = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.buttonBiology2 = new System.Windows.Forms.Button();
            this.buttonArt2 = new System.Windows.Forms.Button();
            this.buttonosvita2 = new System.Windows.Forms.Button();
            this.buttonChemistry2 = new System.Windows.Forms.Button();
            this.buttonHistory2 = new System.Windows.Forms.Button();
            this.buttonGeography2 = new System.Windows.Forms.Button();
            this.buttonpad = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.buttonFizra = new System.Windows.Forms.Button();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(256, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Zoom Joiner";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(273, 305);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Skeden, v1.1.5";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            this.label1.MouseEnter += new System.EventHandler(this.label1_MouseEnter);
            this.label1.MouseLeave += new System.EventHandler(this.label1_MouseLeave);
            // 
            // ButtonUkr
            // 
            this.ButtonUkr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonUkr.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ButtonUkr.Location = new System.Drawing.Point(15, 61);
            this.ButtonUkr.Name = "ButtonUkr";
            this.ButtonUkr.Size = new System.Drawing.Size(96, 60);
            this.ButtonUkr.TabIndex = 3;
            this.ButtonUkr.Text = "Укр.Мова";
            this.ButtonUkr.UseVisualStyleBackColor = true;
            this.ButtonUkr.Click += new System.EventHandler(this.ButtonUkr_Click);
            // 
            // ButtonPravo
            // 
            this.ButtonPravo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonPravo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ButtonPravo.Location = new System.Drawing.Point(117, 61);
            this.ButtonPravo.Name = "ButtonPravo";
            this.ButtonPravo.Size = new System.Drawing.Size(96, 60);
            this.ButtonPravo.TabIndex = 4;
            this.ButtonPravo.Text = "Захист Вітчизни";
            this.ButtonPravo.UseVisualStyleBackColor = true;
            this.ButtonPravo.Click += new System.EventHandler(this.ButtonPravo_Click);
            // 
            // ButtonMath
            // 
            this.ButtonMath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonMath.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ButtonMath.Location = new System.Drawing.Point(321, 61);
            this.ButtonMath.Name = "ButtonMath";
            this.ButtonMath.Size = new System.Drawing.Size(96, 60);
            this.ButtonMath.TabIndex = 6;
            this.ButtonMath.Text = "Алгебра Геометрия";
            this.ButtonMath.UseVisualStyleBackColor = true;
            this.ButtonMath.Click += new System.EventHandler(this.ButtonMath_Click);
            // 
            // ButtonBioliga
            // 
            this.ButtonBioliga.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonBioliga.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ButtonBioliga.Location = new System.Drawing.Point(423, 61);
            this.ButtonBioliga.Name = "ButtonBioliga";
            this.ButtonBioliga.Size = new System.Drawing.Size(96, 60);
            this.ButtonBioliga.TabIndex = 7;
            this.ButtonBioliga.Text = "Биология";
            this.ButtonBioliga.UseVisualStyleBackColor = true;
            this.ButtonBioliga.Click += new System.EventHandler(this.ButtonBioliga_Click);
            // 
            // ButtonArt
            // 
            this.ButtonArt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonArt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ButtonArt.Location = new System.Drawing.Point(525, 61);
            this.ButtonArt.Name = "ButtonArt";
            this.ButtonArt.Size = new System.Drawing.Size(96, 60);
            this.ButtonArt.TabIndex = 8;
            this.ButtonArt.Text = "Мистецтво";
            this.ButtonArt.UseVisualStyleBackColor = true;
            this.ButtonArt.Click += new System.EventHandler(this.ButtonArt_Click);
            // 
            // ButtonOsvita
            // 
            this.ButtonOsvita.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonOsvita.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ButtonOsvita.Location = new System.Drawing.Point(525, 147);
            this.ButtonOsvita.Name = "ButtonOsvita";
            this.ButtonOsvita.Size = new System.Drawing.Size(96, 60);
            this.ButtonOsvita.TabIndex = 14;
            this.ButtonOsvita.Text = "Громадянська освіта";
            this.ButtonOsvita.UseVisualStyleBackColor = true;
            this.ButtonOsvita.Click += new System.EventHandler(this.ButtonOsvita_Click);
            // 
            // ButtonEng
            // 
            this.ButtonEng.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonEng.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ButtonEng.Location = new System.Drawing.Point(423, 147);
            this.ButtonEng.Name = "ButtonEng";
            this.ButtonEng.Size = new System.Drawing.Size(96, 60);
            this.ButtonEng.TabIndex = 13;
            this.ButtonEng.Text = "Английский";
            this.ButtonEng.UseVisualStyleBackColor = true;
            this.ButtonEng.Click += new System.EventHandler(this.ButtonEng_Click);
            // 
            // ButtonHistory
            // 
            this.ButtonHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonHistory.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ButtonHistory.Location = new System.Drawing.Point(321, 147);
            this.ButtonHistory.Name = "ButtonHistory";
            this.ButtonHistory.Size = new System.Drawing.Size(96, 60);
            this.ButtonHistory.TabIndex = 12;
            this.ButtonHistory.Text = "История";
            this.ButtonHistory.UseVisualStyleBackColor = true;
            this.ButtonHistory.Click += new System.EventHandler(this.ButtonHistory_Click);
            // 
            // ButtonGeugraphy
            // 
            this.ButtonGeugraphy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonGeugraphy.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ButtonGeugraphy.Location = new System.Drawing.Point(219, 147);
            this.ButtonGeugraphy.Name = "ButtonGeugraphy";
            this.ButtonGeugraphy.Size = new System.Drawing.Size(96, 60);
            this.ButtonGeugraphy.TabIndex = 11;
            this.ButtonGeugraphy.Text = "География";
            this.ButtonGeugraphy.UseVisualStyleBackColor = true;
            this.ButtonGeugraphy.Click += new System.EventHandler(this.ButtonGeugraphy_Click);
            // 
            // ButtonPhysics
            // 
            this.ButtonPhysics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonPhysics.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ButtonPhysics.Location = new System.Drawing.Point(117, 147);
            this.ButtonPhysics.Name = "ButtonPhysics";
            this.ButtonPhysics.Size = new System.Drawing.Size(96, 60);
            this.ButtonPhysics.TabIndex = 10;
            this.ButtonPhysics.Text = "Физика";
            this.ButtonPhysics.UseVisualStyleBackColor = true;
            this.ButtonPhysics.Click += new System.EventHandler(this.ButtonPhysics_Click);
            // 
            // ButtonLibrary
            // 
            this.ButtonLibrary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonLibrary.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ButtonLibrary.Location = new System.Drawing.Point(15, 147);
            this.ButtonLibrary.Name = "ButtonLibrary";
            this.ButtonLibrary.Size = new System.Drawing.Size(96, 60);
            this.ButtonLibrary.TabIndex = 9;
            this.ButtonLibrary.Text = "Литра";
            this.ButtonLibrary.UseVisualStyleBackColor = true;
            this.ButtonLibrary.Click += new System.EventHandler(this.ButtonLibrary_Click);
            // 
            // ButtonChemistry
            // 
            this.ButtonChemistry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonChemistry.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ButtonChemistry.Location = new System.Drawing.Point(219, 61);
            this.ButtonChemistry.Name = "ButtonChemistry";
            this.ButtonChemistry.Size = new System.Drawing.Size(96, 60);
            this.ButtonChemistry.TabIndex = 15;
            this.ButtonChemistry.Text = "Химия";
            this.ButtonChemistry.UseVisualStyleBackColor = true;
            this.ButtonChemistry.Click += new System.EventHandler(this.ButtonChemistry_Click);
            // 
            // ButtonTo
            // 
            this.ButtonTo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonTo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ButtonTo.Location = new System.Drawing.Point(346, 258);
            this.ButtonTo.Name = "ButtonTo";
            this.ButtonTo.Size = new System.Drawing.Size(124, 40);
            this.ButtonTo.TabIndex = 16;
            this.ButtonTo.Text = "Расписание";
            this.ButtonTo.UseVisualStyleBackColor = true;
            this.ButtonTo.Click += new System.EventHandler(this.ButtonTo_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(541, 306);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(91, 17);
            this.checkBox1.TabIndex = 19;
            this.checkBox1.Text = "Слить Уроки";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.Click += new System.EventHandler(this.checkBox1_Click);
            // 
            // buttonBiology2
            // 
            this.buttonBiology2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBiology2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonBiology2.Location = new System.Drawing.Point(423, 61);
            this.buttonBiology2.Name = "buttonBiology2";
            this.buttonBiology2.Size = new System.Drawing.Size(96, 60);
            this.buttonBiology2.TabIndex = 21;
            this.buttonBiology2.Text = "Биология";
            this.buttonBiology2.UseVisualStyleBackColor = true;
            this.buttonBiology2.Click += new System.EventHandler(this.buttonBiology2_Click);
            // 
            // buttonArt2
            // 
            this.buttonArt2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonArt2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonArt2.Location = new System.Drawing.Point(525, 61);
            this.buttonArt2.Name = "buttonArt2";
            this.buttonArt2.Size = new System.Drawing.Size(96, 60);
            this.buttonArt2.TabIndex = 22;
            this.buttonArt2.Text = "Мистецтво";
            this.buttonArt2.UseVisualStyleBackColor = true;
            this.buttonArt2.Click += new System.EventHandler(this.buttonArt2_Click);
            // 
            // buttonosvita2
            // 
            this.buttonosvita2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonosvita2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonosvita2.Location = new System.Drawing.Point(321, 61);
            this.buttonosvita2.Name = "buttonosvita2";
            this.buttonosvita2.Size = new System.Drawing.Size(96, 60);
            this.buttonosvita2.TabIndex = 23;
            this.buttonosvita2.Text = "Громадянська освіта";
            this.buttonosvita2.UseVisualStyleBackColor = true;
            this.buttonosvita2.Click += new System.EventHandler(this.buttonosvita2_Click);
            // 
            // buttonChemistry2
            // 
            this.buttonChemistry2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonChemistry2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonChemistry2.Location = new System.Drawing.Point(219, 61);
            this.buttonChemistry2.Name = "buttonChemistry2";
            this.buttonChemistry2.Size = new System.Drawing.Size(96, 60);
            this.buttonChemistry2.TabIndex = 24;
            this.buttonChemistry2.Text = "Химия";
            this.buttonChemistry2.UseVisualStyleBackColor = true;
            this.buttonChemistry2.Click += new System.EventHandler(this.buttonChemistry2_Click);
            // 
            // buttonHistory2
            // 
            this.buttonHistory2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHistory2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonHistory2.Location = new System.Drawing.Point(117, 61);
            this.buttonHistory2.Name = "buttonHistory2";
            this.buttonHistory2.Size = new System.Drawing.Size(96, 60);
            this.buttonHistory2.TabIndex = 25;
            this.buttonHistory2.Text = "История";
            this.buttonHistory2.UseVisualStyleBackColor = true;
            this.buttonHistory2.Click += new System.EventHandler(this.buttonHistory2_Click);
            // 
            // buttonGeography2
            // 
            this.buttonGeography2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGeography2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonGeography2.Location = new System.Drawing.Point(15, 61);
            this.buttonGeography2.Name = "buttonGeography2";
            this.buttonGeography2.Size = new System.Drawing.Size(96, 60);
            this.buttonGeography2.TabIndex = 26;
            this.buttonGeography2.Text = "География";
            this.buttonGeography2.UseVisualStyleBackColor = true;
            this.buttonGeography2.Click += new System.EventHandler(this.buttonGeography2_Click);
            // 
            // buttonpad
            // 
            this.buttonpad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonpad.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonpad.Location = new System.Drawing.Point(12, 261);
            this.buttonpad.Name = "buttonpad";
            this.buttonpad.Size = new System.Drawing.Size(96, 35);
            this.buttonpad.TabIndex = 28;
            this.buttonpad.Text = "Meowpad";
            this.buttonpad.UseVisualStyleBackColor = true;
            this.buttonpad.Click += new System.EventHandler(this.buttonpad_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(525, 261);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 35);
            this.button1.TabIndex = 29;
            this.button1.Text = "Soundpad";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button7
            // 
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button7.Location = new System.Drawing.Point(166, 258);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(124, 40);
            this.button7.TabIndex = 30;
            this.button7.Text = "Список Учеников";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // buttonFizra
            // 
            this.buttonFizra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFizra.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonFizra.Location = new System.Drawing.Point(270, 147);
            this.buttonFizra.Name = "buttonFizra";
            this.buttonFizra.Size = new System.Drawing.Size(96, 60);
            this.buttonFizra.TabIndex = 27;
            this.buttonFizra.Text = "Физра";
            this.buttonFizra.UseVisualStyleBackColor = true;
            this.buttonFizra.Click += new System.EventHandler(this.buttonFizra_Click);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(12, 306);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(120, 17);
            this.checkBox2.TabIndex = 31;
            this.checkBox2.Text = "Авто-подключение";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Working...";
            this.notifyIcon1.Visible = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(640, 335);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonpad);
            this.Controls.Add(this.buttonFizra);
            this.Controls.Add(this.buttonGeography2);
            this.Controls.Add(this.buttonHistory2);
            this.Controls.Add(this.buttonChemistry2);
            this.Controls.Add(this.buttonosvita2);
            this.Controls.Add(this.buttonArt2);
            this.Controls.Add(this.buttonBiology2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.ButtonTo);
            this.Controls.Add(this.ButtonChemistry);
            this.Controls.Add(this.ButtonOsvita);
            this.Controls.Add(this.ButtonEng);
            this.Controls.Add(this.ButtonHistory);
            this.Controls.Add(this.ButtonGeugraphy);
            this.Controls.Add(this.ButtonPhysics);
            this.Controls.Add(this.ButtonLibrary);
            this.Controls.Add(this.ButtonArt);
            this.Controls.Add(this.ButtonBioliga);
            this.Controls.Add(this.ButtonMath);
            this.Controls.Add(this.ButtonPravo);
            this.Controls.Add(this.ButtonUkr);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zoom Joiner";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ButtonUkr;
        private System.Windows.Forms.Button ButtonPravo;
        private System.Windows.Forms.Button ButtonMath;
        private System.Windows.Forms.Button ButtonBioliga;
        private System.Windows.Forms.Button ButtonArt;
        private System.Windows.Forms.Button ButtonOsvita;
        private System.Windows.Forms.Button ButtonEng;
        private System.Windows.Forms.Button ButtonHistory;
        private System.Windows.Forms.Button ButtonGeugraphy;
        private System.Windows.Forms.Button ButtonPhysics;
        private System.Windows.Forms.Button ButtonLibrary;
        private System.Windows.Forms.Button ButtonChemistry;
        private System.Windows.Forms.Button ButtonTo;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button buttonBiology2;
        private System.Windows.Forms.Button buttonArt2;
        private System.Windows.Forms.Button buttonosvita2;
        private System.Windows.Forms.Button buttonChemistry2;
        private System.Windows.Forms.Button buttonHistory2;
        private System.Windows.Forms.Button buttonGeography2;
        private System.Windows.Forms.Button buttonpad;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button buttonFizra;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}

