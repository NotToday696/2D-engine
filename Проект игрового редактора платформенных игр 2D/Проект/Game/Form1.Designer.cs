namespace Game
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.danger = new System.Windows.Forms.PictureBox();
            this.model_player = new System.Windows.Forms.PictureBox();
            this.fon = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.danger)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.model_player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fon)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.danger);
            this.panel1.Controls.Add(this.model_player);
            this.panel1.Controls.Add(this.fon);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(782, 553);
            this.panel1.TabIndex = 0;
            // 
            // danger
            // 
            this.danger.Location = new System.Drawing.Point(333, 145);
            this.danger.Name = "danger";
            this.danger.Size = new System.Drawing.Size(167, 88);
            this.danger.TabIndex = 2;
            this.danger.TabStop = false;
            // 
            // model_player
            // 
            this.model_player.Location = new System.Drawing.Point(41, 206);
            this.model_player.Name = "model_player";
            this.model_player.Size = new System.Drawing.Size(178, 95);
            this.model_player.TabIndex = 1;
            this.model_player.TabStop = false;
            // 
            // fon
            // 
            this.fon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fon.Location = new System.Drawing.Point(0, 0);
            this.fon.Name = "fon";
            this.fon.Size = new System.Drawing.Size(782, 553);
            this.fon.TabIndex = 0;
            this.fon.TabStop = false;
            this.fon.Paint += new System.Windows.Forms.PaintEventHandler(this.fon_Paint);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.danger)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.model_player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox danger;
        private System.Windows.Forms.PictureBox model_player;
        private System.Windows.Forms.PictureBox fon;
        private System.Windows.Forms.Timer timer1;
    }
}

