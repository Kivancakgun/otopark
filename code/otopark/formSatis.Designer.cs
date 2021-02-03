
namespace otopark
{
    partial class formSatis
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
            this.dataGridViewSatis = new System.Windows.Forms.DataGridView();
            this.labelSatisMessage = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSatis)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewSatis
            // 
            this.dataGridViewSatis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSatis.Location = new System.Drawing.Point(73, 12);
            this.dataGridViewSatis.Name = "dataGridViewSatis";
            this.dataGridViewSatis.RowHeadersWidth = 51;
            this.dataGridViewSatis.RowTemplate.Height = 24;
            this.dataGridViewSatis.Size = new System.Drawing.Size(652, 365);
            this.dataGridViewSatis.TabIndex = 0;
            // 
            // labelSatisMessage
            // 
            this.labelSatisMessage.AutoSize = true;
            this.labelSatisMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelSatisMessage.Location = new System.Drawing.Point(68, 406);
            this.labelSatisMessage.Name = "labelSatisMessage";
            this.labelSatisMessage.Size = new System.Drawing.Size(149, 25);
            this.labelSatisMessage.TabIndex = 1;
            this.labelSatisMessage.Text = "SatisMessage";
            // 
            // formSatis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelSatisMessage);
            this.Controls.Add(this.dataGridViewSatis);
            this.Name = "formSatis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formSatis";
            this.Load += new System.EventHandler(this.formSatis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSatis)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewSatis;
        private System.Windows.Forms.Label labelSatisMessage;
    }
}