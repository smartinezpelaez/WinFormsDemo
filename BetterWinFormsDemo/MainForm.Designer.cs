namespace BetterWinFormsDemo
{
    partial class MainForm
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
            firstNameLabel = new Label();
            FirstNameText = new TextBox();
            SayHelloButton = new Button();
            lastNameText = new TextBox();
            lastNameLabel = new Label();
            SuspendLayout();
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Location = new Point(106, 107);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new Size(129, 32);
            firstNameLabel.TabIndex = 0;
            firstNameLabel.Text = "First Name";
            // 
            // FirstNameText
            // 
            FirstNameText.Location = new Point(254, 100);
            FirstNameText.Name = "FirstNameText";
            FirstNameText.Size = new Size(253, 39);
            FirstNameText.TabIndex = 1;
            FirstNameText.TextChanged += textBox1_TextChanged;
            // 
            // SayHelloButton
            // 
            SayHelloButton.Location = new Point(254, 231);
            SayHelloButton.Name = "SayHelloButton";
            SayHelloButton.Size = new Size(159, 67);
            SayHelloButton.TabIndex = 3;
            SayHelloButton.Text = "Say Hello";
            SayHelloButton.UseVisualStyleBackColor = true;
            SayHelloButton.Click += SayHelloButton_Click;
            // 
            // lastNameText
            // 
            lastNameText.Location = new Point(254, 157);
            lastNameText.Name = "lastNameText";
            lastNameText.Size = new Size(253, 39);
            lastNameText.TabIndex = 2;
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Location = new Point(106, 164);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new Size(126, 32);
            lastNameLabel.TabIndex = 3;
            lastNameLabel.Text = "Last Name";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(693, 361);
            Controls.Add(lastNameText);
            Controls.Add(lastNameLabel);
            Controls.Add(SayHelloButton);
            Controls.Add(FirstNameText);
            Controls.Add(firstNameLabel);
            Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(6, 6, 6, 6);
            Name = "MainForm";
            Text = "Main Form by Steven Martinez";
            Load += MainForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label firstNameLabel;
        private TextBox FirstNameText;
        private Button SayHelloButton;
        private TextBox lastNameText;
        private Label lastNameLabel;
    }
}
