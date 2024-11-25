namespace LuaCompilador
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            InputTextBox = new TextBox();
            executeButton = new Button();
            outputTextBox = new TextBox();
            errorTextBox = new TextBox();
            cleanButtom = new Button();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // InputTextBox
            // 
            InputTextBox.ForeColor = SystemColors.ActiveCaptionText;
            InputTextBox.Location = new Point(19, 27);
            InputTextBox.Margin = new Padding(10, 10, 3, 3);
            InputTextBox.Multiline = true;
            InputTextBox.Name = "InputTextBox";
            InputTextBox.Size = new Size(760, 468);
            InputTextBox.TabIndex = 0;
            // 
            // executeButton
            // 
            executeButton.BackColor = Color.MediumSeaGreen;
            executeButton.ForeColor = Color.White;
            executeButton.Location = new Point(490, 501);
            executeButton.Name = "executeButton";
            executeButton.Size = new Size(100, 40);
            executeButton.TabIndex = 1;
            executeButton.Text = "Ejecutar";
            executeButton.UseVisualStyleBackColor = false;
            executeButton.Click += button1_Click;
            // 
            // outputTextBox
            // 
            outputTextBox.Location = new Point(792, 27);
            outputTextBox.Margin = new Padding(10, 260, 3, 3);
            outputTextBox.Multiline = true;
            outputTextBox.Name = "outputTextBox";
            outputTextBox.ReadOnly = true;
            outputTextBox.Size = new Size(522, 468);
            outputTextBox.TabIndex = 2;
            
            // 
            // errorTextBox
            // 
            errorTextBox.ForeColor = Color.Red;
            errorTextBox.Location = new Point(19, 571);
            errorTextBox.Margin = new Padding(10, 390, 3, 3);
            errorTextBox.Multiline = true;
            errorTextBox.Name = "errorTextBox";
            errorTextBox.ReadOnly = true;
            errorTextBox.Size = new Size(760, 120);
            errorTextBox.TabIndex = 3;
            // 
            // cleanButtom
            // 
            cleanButtom.BackColor = Color.SkyBlue;
            cleanButtom.ForeColor = SystemColors.ButtonHighlight;
            cleanButtom.Location = new Point(613, 501);
            cleanButtom.Name = "cleanButtom";
            cleanButtom.Size = new Size(100, 40);
            cleanButtom.TabIndex = 4;
            cleanButtom.Text = "Limpiar";
            cleanButtom.UseVisualStyleBackColor = false;
            cleanButtom.Click += cleanButtom_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.ButtonFace;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(19, 528);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 31);
            textBox1.TabIndex = 5;
            textBox1.Text = "Lista de errores";
            
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(1326, 703);
            Controls.Add(textBox1);
            Controls.Add(cleanButtom);
            Controls.Add(errorTextBox);
            Controls.Add(outputTextBox);
            Controls.Add(executeButton);
            Controls.Add(InputTextBox);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox InputTextBox;
        private Button executeButton;
        private TextBox outputTextBox;
        private TextBox errorTextBox;
        private Button cleanButtom;
        private TextBox textBox1;
    }
}
