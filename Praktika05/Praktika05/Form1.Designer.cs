
namespace Praktika05
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtForm1_first = new System.Windows.Forms.TextBox();
            this.btnSendToForm2 = new System.Windows.Forms.Button();
            this.btnGetForm2Data = new System.Windows.Forms.Button();
            this.txtForm1_second = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Собственные данные:";
            // 
            // txtForm1_first
            // 
            this.txtForm1_first.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtForm1_first.Location = new System.Drawing.Point(12, 32);
            this.txtForm1_first.Name = "txtForm1_first";
            this.txtForm1_first.Size = new System.Drawing.Size(359, 26);
            this.txtForm1_first.TabIndex = 1;
            // 
            // btnSendToForm2
            // 
            this.btnSendToForm2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSendToForm2.Location = new System.Drawing.Point(16, 64);
            this.btnSendToForm2.Name = "btnSendToForm2";
            this.btnSendToForm2.Size = new System.Drawing.Size(348, 29);
            this.btnSendToForm2.TabIndex = 2;
            this.btnSendToForm2.Text = "Передать во вторую форму";
            this.btnSendToForm2.UseVisualStyleBackColor = true;
            this.btnSendToForm2.Click += new System.EventHandler(this.btnSendToForm2_Click);
            // 
            // btnGetForm2Data
            // 
            this.btnGetForm2Data.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnGetForm2Data.Location = new System.Drawing.Point(16, 176);
            this.btnGetForm2Data.Name = "btnGetForm2Data";
            this.btnGetForm2Data.Size = new System.Drawing.Size(348, 29);
            this.btnGetForm2Data.TabIndex = 5;
            this.btnGetForm2Data.Text = "Получить данные из второй формы";
            this.btnGetForm2Data.UseVisualStyleBackColor = true;
            this.btnGetForm2Data.Click += new System.EventHandler(this.btnGetForm2Data_Click);
            // 
            // txtForm1_second
            // 
            this.txtForm1_second.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtForm1_second.Location = new System.Drawing.Point(12, 144);
            this.txtForm1_second.Name = "txtForm1_second";
            this.txtForm1_second.ReadOnly = true;
            this.txtForm1_second.Size = new System.Drawing.Size(359, 26);
            this.txtForm1_second.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(210, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Данные из второй формы:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 225);
            this.Controls.Add(this.btnGetForm2Data);
            this.Controls.Add(this.txtForm1_second);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSendToForm2);
            this.Controls.Add(this.txtForm1_first);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(403, 264);
            this.MinimumSize = new System.Drawing.Size(403, 264);
            this.Name = "Form1";
            this.Text = "Главная форма";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtForm1_first;
        private System.Windows.Forms.Button btnSendToForm2;
        private System.Windows.Forms.Button btnGetForm2Data;
        private System.Windows.Forms.TextBox txtForm1_second;
        private System.Windows.Forms.Label label2;
    }
}

