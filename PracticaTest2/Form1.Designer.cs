﻿namespace PracticaTest2
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
            this.labelC = new System.Windows.Forms.Label();
            this.labelPO = new System.Windows.Forms.Label();
            this.labelFil = new System.Windows.Forms.Label();
            this.labelPeriod = new System.Windows.Forms.Label();
            this.labelServer = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.dtpBegin = new System.Windows.Forms.DateTimePicker();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonDownErrors = new System.Windows.Forms.Button();
            this.buttonSettings = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelC
            // 
            this.labelC.AutoSize = true;
            this.labelC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelC.Location = new System.Drawing.Point(13, 22);
            this.labelC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelC.Name = "labelC";
            this.labelC.Size = new System.Drawing.Size(84, 20);
            this.labelC.TabIndex = 0;
            this.labelC.Text = "Период с ";
            // 
            // labelPO
            // 
            this.labelPO.AutoSize = true;
            this.labelPO.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPO.Location = new System.Drawing.Point(13, 64);
            this.labelPO.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPO.Name = "labelPO";
            this.labelPO.Size = new System.Drawing.Size(90, 20);
            this.labelPO.TabIndex = 1;
            this.labelPO.Text = "Период по";
            // 
            // labelFil
            // 
            this.labelFil.AutoSize = true;
            this.labelFil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFil.Location = new System.Drawing.Point(303, 108);
            this.labelFil.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFil.Name = "labelFil";
            this.labelFil.Size = new System.Drawing.Size(131, 20);
            this.labelFil.TabIndex = 2;
            this.labelFil.Text = "Фильтр ошибок";
            // 
            // labelPeriod
            // 
            this.labelPeriod.AutoSize = true;
            this.labelPeriod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPeriod.Location = new System.Drawing.Point(14, 110);
            this.labelPeriod.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPeriod.Name = "labelPeriod";
            this.labelPeriod.Size = new System.Drawing.Size(133, 20);
            this.labelPeriod.TabIndex = 3;
            this.labelPeriod.Text = "Текущий период";
            // 
            // labelServer
            // 
            this.labelServer.AutoSize = true;
            this.labelServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelServer.Location = new System.Drawing.Point(318, 43);
            this.labelServer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelServer.Name = "labelServer";
            this.labelServer.Size = new System.Drawing.Size(161, 20);
            this.labelServer.TabIndex = 4;
            this.labelServer.Text = "Состояние сервера:";
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelStatus.ForeColor = System.Drawing.Color.ForestGreen;
            this.labelStatus.Location = new System.Drawing.Point(487, 43);
            this.labelStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(82, 20);
            this.labelStatus.TabIndex = 5;
            this.labelStatus.Text = "Работает";
            // 
            // dtpBegin
            // 
            this.dtpBegin.Location = new System.Drawing.Point(105, 22);
            this.dtpBegin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpBegin.Name = "dtpBegin";
            this.dtpBegin.Size = new System.Drawing.Size(172, 22);
            this.dtpBegin.TabIndex = 6;
            // 
            // dtpEnd
            // 
            this.dtpEnd.Location = new System.Drawing.Point(111, 64);
            this.dtpEnd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(172, 22);
            this.dtpEnd.TabIndex = 7;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(442, 110);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(431, 24);
            this.comboBox1.TabIndex = 8;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(18, 156);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(855, 306);
            this.dataGridView1.TabIndex = 9;
            // 
            // buttonDownErrors
            // 
            this.buttonDownErrors.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDownErrors.Location = new System.Drawing.Point(611, 24);
            this.buttonDownErrors.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonDownErrors.Name = "buttonDownErrors";
            this.buttonDownErrors.Size = new System.Drawing.Size(120, 60);
            this.buttonDownErrors.TabIndex = 10;
            this.buttonDownErrors.Text = "Загрузить ошибки";
            this.buttonDownErrors.UseVisualStyleBackColor = true;
            this.buttonDownErrors.Click += new System.EventHandler(this.ButtonDownErrors_Click);
            // 
            // buttonSettings
            // 
            this.buttonSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSettings.Location = new System.Drawing.Point(752, 24);
            this.buttonSettings.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonSettings.Name = "buttonSettings";
            this.buttonSettings.Size = new System.Drawing.Size(121, 60);
            this.buttonSettings.TabIndex = 11;
            this.buttonSettings.Text = "Настройки";
            this.buttonSettings.UseVisualStyleBackColor = true;
            this.buttonSettings.Click += new System.EventHandler(this.ButtonSettings_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 485);
            this.Controls.Add(this.buttonSettings);
            this.Controls.Add(this.buttonDownErrors);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dtpEnd);
            this.Controls.Add(this.dtpBegin);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.labelServer);
            this.Controls.Add(this.labelPeriod);
            this.Controls.Add(this.labelFil);
            this.Controls.Add(this.labelPO);
            this.Controls.Add(this.labelC);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Контроль ошибок";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelC;
        private System.Windows.Forms.Label labelPO;
        private System.Windows.Forms.Label labelFil;
        private System.Windows.Forms.Label labelPeriod;
        private System.Windows.Forms.Label labelServer;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.DateTimePicker dtpBegin;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonDownErrors;
        private System.Windows.Forms.Button buttonSettings;
    }
}

