namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_IP = new System.Windows.Forms.TextBox();
            this.textBox_Port = new System.Windows.Forms.TextBox();
            this.textBox_ListenPort = new System.Windows.Forms.TextBox();
            this.button_ = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.radioButton_Red = new System.Windows.Forms.RadioButton();
            this.radioButton_Green = new System.Windows.Forms.RadioButton();
            this.radioButton_Blue = new System.Windows.Forms.RadioButton();
            this.radioButton_Black = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "目標IP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(185, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "目標Port";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(370, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "接聽Port";
            // 
            // textBox_IP
            // 
            this.textBox_IP.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox_IP.Location = new System.Drawing.Point(58, 9);
            this.textBox_IP.Name = "textBox_IP";
            this.textBox_IP.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_IP.Size = new System.Drawing.Size(111, 25);
            this.textBox_IP.TabIndex = 3;
            // 
            // textBox_Port
            // 
            this.textBox_Port.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox_Port.Location = new System.Drawing.Point(251, 9);
            this.textBox_Port.Name = "textBox_Port";
            this.textBox_Port.Size = new System.Drawing.Size(111, 25);
            this.textBox_Port.TabIndex = 4;
            // 
            // textBox_ListenPort
            // 
            this.textBox_ListenPort.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox_ListenPort.Location = new System.Drawing.Point(436, 9);
            this.textBox_ListenPort.Name = "textBox_ListenPort";
            this.textBox_ListenPort.Size = new System.Drawing.Size(111, 25);
            this.textBox_ListenPort.TabIndex = 5;
            // 
            // button_
            // 
            this.button_.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_.Location = new System.Drawing.Point(564, 8);
            this.button_.Name = "button_";
            this.button_.Size = new System.Drawing.Size(86, 28);
            this.button_.TabIndex = 6;
            this.button_.Text = "連線";
            this.button_.UseVisualStyleBackColor = true;
            this.button_.Click += new System.EventHandler(this.button1_Click);
            // 
            // radioButton_Red
            // 
            this.radioButton_Red.AutoSize = true;
            this.radioButton_Red.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.radioButton_Red.Location = new System.Drawing.Point(736, 12);
            this.radioButton_Red.Name = "radioButton_Red";
            this.radioButton_Red.Size = new System.Drawing.Size(49, 21);
            this.radioButton_Red.TabIndex = 7;
            this.radioButton_Red.Text = "Red";
            this.radioButton_Red.UseVisualStyleBackColor = true;
            // 
            // radioButton_Green
            // 
            this.radioButton_Green.AutoSize = true;
            this.radioButton_Green.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.radioButton_Green.Location = new System.Drawing.Point(800, 12);
            this.radioButton_Green.Name = "radioButton_Green";
            this.radioButton_Green.Size = new System.Drawing.Size(63, 21);
            this.radioButton_Green.TabIndex = 8;
            this.radioButton_Green.Text = "Green";
            this.radioButton_Green.UseVisualStyleBackColor = true;
            // 
            // radioButton_Blue
            // 
            this.radioButton_Blue.AutoSize = true;
            this.radioButton_Blue.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.radioButton_Blue.Location = new System.Drawing.Point(866, 12);
            this.radioButton_Blue.Name = "radioButton_Blue";
            this.radioButton_Blue.Size = new System.Drawing.Size(52, 21);
            this.radioButton_Blue.TabIndex = 9;
            this.radioButton_Blue.Text = "Blue";
            this.radioButton_Blue.UseVisualStyleBackColor = true;
            // 
            // radioButton_Black
            // 
            this.radioButton_Black.AutoSize = true;
            this.radioButton_Black.Checked = true;
            this.radioButton_Black.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.radioButton_Black.Location = new System.Drawing.Point(671, 12);
            this.radioButton_Black.Name = "radioButton_Black";
            this.radioButton_Black.Size = new System.Drawing.Size(57, 21);
            this.radioButton_Black.TabIndex = 10;
            this.radioButton_Black.TabStop = true;
            this.radioButton_Black.Text = "Black";
            this.radioButton_Black.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 564);
            this.Controls.Add(this.radioButton_Black);
            this.Controls.Add(this.radioButton_Blue);
            this.Controls.Add(this.radioButton_Green);
            this.Controls.Add(this.radioButton_Red);
            this.Controls.Add(this.button_);
            this.Controls.Add(this.textBox_ListenPort);
            this.Controls.Add(this.textBox_Port);
            this.Controls.Add(this.textBox_IP);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_IP;
        private System.Windows.Forms.TextBox textBox_Port;
        private System.Windows.Forms.TextBox textBox_ListenPort;
        private System.Windows.Forms.Button button_;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.RadioButton radioButton_Red;
        private System.Windows.Forms.RadioButton radioButton_Green;
        private System.Windows.Forms.RadioButton radioButton_Blue;
        private System.Windows.Forms.RadioButton radioButton_Black;
    }
}

