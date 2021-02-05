
namespace Praktika05
{
    partial class Form2
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
            this.btnGetDataForm1 = new System.Windows.Forms.Button();
            this.btnSendDataToForm1 = new System.Windows.Forms.Button();
            this.txtForm2_first = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtForm2_second = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGetDataForm1
            // 
            this.btnGetDataForm1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnGetDataForm1.Location = new System.Drawing.Point(21, 21);
            this.btnGetDataForm1.Name = "btnGetDataForm1";
            this.btnGetDataForm1.Size = new System.Drawing.Size(169, 65);
            this.btnGetDataForm1.TabIndex = 0;
            this.btnGetDataForm1.Text = "Получить данные из первой формы";
            this.btnGetDataForm1.UseVisualStyleBackColor = true;
            this.btnGetDataForm1.Click += new System.EventHandler(this.btnGetDataForm1_Click);
            // 
            // btnSendDataToForm1
            // 
            this.btnSendDataToForm1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSendDataToForm1.Location = new System.Drawing.Point(21, 109);
            this.btnSendDataToForm1.Name = "btnSendDataToForm1";
            this.btnSendDataToForm1.Size = new System.Drawing.Size(169, 65);
            this.btnSendDataToForm1.TabIndex = 1;
            this.btnSendDataToForm1.Text = "Добавить данные в первую форму";
            this.btnSendDataToForm1.UseVisualStyleBackColor = true;
            this.btnSendDataToForm1.Click += new System.EventHandler(this.btnSendDataToForm1_Click);
            // 
            // txtForm2_first
            // 
            this.txtForm2_first.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtForm2_first.Location = new System.Drawing.Point(205, 60);
            this.txtForm2_first.Name = "txtForm2_first";
            this.txtForm2_first.ReadOnly = true;
            this.txtForm2_first.Size = new System.Drawing.Size(275, 26);
            this.txtForm2_first.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(207, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Данные из первой формы:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(207, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Данные в первую форму:";
            // 
            // txtForm2_second
            // 
            this.txtForm2_second.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtForm2_second.Location = new System.Drawing.Point(205, 148);
            this.txtForm2_second.Name = "txtForm2_second";
            this.txtForm2_second.Size = new System.Drawing.Size(275, 26);
            this.txtForm2_second.TabIndex = 4;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClose.Location = new System.Drawing.Point(5, 208);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(490, 54);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "ВЫХОД";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 265);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtForm2_second);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtForm2_first);
            this.Controls.Add(this.btnSendDataToForm1);
            this.Controls.Add(this.btnGetDataForm1);
            this.MaximumSize = new System.Drawing.Size(515, 304);
            this.MinimumSize = new System.Drawing.Size(515, 304);
            this.Name = "Form2";
            this.Text = "Вспомогательная форма";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGetDataForm1;
        private System.Windows.Forms.Button btnSendDataToForm1;
        private System.Windows.Forms.TextBox txtForm2_first;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtForm2_second;
        private System.Windows.Forms.Button btnClose;
    }
}