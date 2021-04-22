namespace Grossberg_crypto_system
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
            this.TextInput = new System.Windows.Forms.TextBox();
            this.Encode = new System.Windows.Forms.Button();
            this.Decode = new System.Windows.Forms.Button();
            this.TextOutput = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TextInput
            // 
            this.TextInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextInput.Location = new System.Drawing.Point(12, 12);
            this.TextInput.Multiline = true;
            this.TextInput.Name = "TextInput";
            this.TextInput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TextInput.Size = new System.Drawing.Size(776, 95);
            this.TextInput.TabIndex = 0;
            // 
            // Encode
            // 
            this.Encode.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Encode.Location = new System.Drawing.Point(79, 113);
            this.Encode.Name = "Encode";
            this.Encode.Size = new System.Drawing.Size(190, 82);
            this.Encode.TabIndex = 1;
            this.Encode.Text = "Encode";
            this.Encode.UseVisualStyleBackColor = true;
            this.Encode.Click += new System.EventHandler(this.Encode_Click);
            // 
            // Decode
            // 
            this.Decode.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Decode.Location = new System.Drawing.Point(524, 113);
            this.Decode.Name = "Decode";
            this.Decode.Size = new System.Drawing.Size(190, 82);
            this.Decode.TabIndex = 2;
            this.Decode.Text = "Decode";
            this.Decode.UseVisualStyleBackColor = true;
            this.Decode.Click += new System.EventHandler(this.Decode_Click);
            // 
            // TextOutput
            // 
            this.TextOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextOutput.Location = new System.Drawing.Point(12, 201);
            this.TextOutput.Multiline = true;
            this.TextOutput.Name = "TextOutput";
            this.TextOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TextOutput.Size = new System.Drawing.Size(776, 119);
            this.TextOutput.TabIndex = 3;
            this.TextOutput.TextChanged += new System.EventHandler(this.TextOutput_TextChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(278, 326);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(233, 112);
            this.button1.TabIndex = 4;
            this.button1.Text = "Restart net";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TextOutput);
            this.Controls.Add(this.Decode);
            this.Controls.Add(this.Encode);
            this.Controls.Add(this.TextInput);
            this.Name = "Form1";
            this.Text = "Enigma";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextInput;
        private System.Windows.Forms.Button Encode;
        private System.Windows.Forms.Button Decode;
        private System.Windows.Forms.TextBox TextOutput;
        private System.Windows.Forms.Button button1;
    }
}

