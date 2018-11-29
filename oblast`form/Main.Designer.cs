namespace oblast_form
{
    partial class fMain
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
            this.tMain = new System.Windows.Forms.TextBox();
            this.bAddA = new System.Windows.Forms.Button();
            this.bExit = new System.Windows.Forms.Button();
            this.bClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tMain
            // 
            this.tMain.Location = new System.Drawing.Point(21, 20);
            this.tMain.Multiline = true;
            this.tMain.Name = "tMain";
            this.tMain.ReadOnly = true;
            this.tMain.Size = new System.Drawing.Size(548, 305);
            this.tMain.TabIndex = 0;
            // 
            // bAddA
            // 
            this.bAddA.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.bAddA.Location = new System.Drawing.Point(590, 20);
            this.bAddA.Name = "bAddA";
            this.bAddA.Size = new System.Drawing.Size(185, 38);
            this.bAddA.TabIndex = 1;
            this.bAddA.Text = "Додати назву планшету";
            this.bAddA.UseVisualStyleBackColor = true;
            this.bAddA.Click += new System.EventHandler(this.bAddA_Click);
            // 
            // bExit
            // 
            this.bExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.bExit.Location = new System.Drawing.Point(590, 287);
            this.bExit.Name = "bExit";
            this.bExit.Size = new System.Drawing.Size(185, 38);
            this.bExit.TabIndex = 2;
            this.bExit.Text = "Вихід";
            this.bExit.UseVisualStyleBackColor = true;
            this.bExit.Click += new System.EventHandler(this.bExit_Click);
            // 
            // bClear
            // 
            this.bClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.bClear.Location = new System.Drawing.Point(590, 141);
            this.bClear.Name = "bClear";
            this.bClear.Size = new System.Drawing.Size(185, 59);
            this.bClear.TabIndex = 3;
            this.bClear.Text = "Очистити";
            this.bClear.UseVisualStyleBackColor = true;
            this.bClear.Click += new System.EventHandler(this.bClear_Click);
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 346);
            this.Controls.Add(this.bClear);
            this.Controls.Add(this.bExit);
            this.Controls.Add(this.bAddA);
            this.Controls.Add(this.tMain);
            this.MinimizeBox = false;
            this.Name = "fMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Лабараторна робота №8";
            this.Load += new System.EventHandler(this.fMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tMain;
        private System.Windows.Forms.Button bAddA;
        private System.Windows.Forms.Button bExit;
        private System.Windows.Forms.Button bClear;
    }
}

