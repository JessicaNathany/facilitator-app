namespace facilitator.app
{
    partial class GeneralForm
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
            groupBox1 = new GroupBox();
            btnCode = new Button();
            btnHtmlFormat = new Button();
            btnJsonFormatter = new Button();
            label1 = new Label();
            groupGenerators = new GroupBox();
            btnNumberCard = new Button();
            button1 = new Button();
            btnHashesGenerators = new Button();
            btnGeneratorPassword = new Button();
            btnGeneratorGuid = new Button();
            btnClose = new Button();
            groupBox1.SuspendLayout();
            groupGenerators.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnCode);
            groupBox1.Controls.Add(btnHtmlFormat);
            groupBox1.Controls.Add(btnJsonFormatter);
            groupBox1.Location = new Point(26, 68);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(715, 161);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Formatters";
            // 
            // btnCode
            // 
            btnCode.Location = new Point(344, 41);
            btnCode.Name = "btnCode";
            btnCode.Size = new Size(130, 41);
            btnCode.TabIndex = 3;
            btnCode.Text = "SQL Format";
            btnCode.UseVisualStyleBackColor = true;
            // 
            // btnHtmlFormat
            // 
            btnHtmlFormat.Location = new Point(182, 41);
            btnHtmlFormat.Name = "btnHtmlFormat";
            btnHtmlFormat.Size = new Size(115, 43);
            btnHtmlFormat.TabIndex = 1;
            btnHtmlFormat.Text = "HTML Format";
            btnHtmlFormat.UseVisualStyleBackColor = true;
            // 
            // btnJsonFormatter
            // 
            btnJsonFormatter.Location = new Point(35, 41);
            btnJsonFormatter.Name = "btnJsonFormatter";
            btnJsonFormatter.Size = new Size(115, 43);
            btnJsonFormatter.TabIndex = 0;
            btnJsonFormatter.Text = "JSON Format";
            btnJsonFormatter.UseVisualStyleBackColor = true;
            btnJsonFormatter.Click += ButtonJsonFormat;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 19);
            label1.Name = "label1";
            label1.Size = new Size(84, 15);
            label1.TabIndex = 1;
            label1.Text = "Facilitator App";
            // 
            // groupGenerators
            // 
            groupGenerators.Controls.Add(btnNumberCard);
            groupGenerators.Controls.Add(button1);
            groupGenerators.Controls.Add(btnHashesGenerators);
            groupGenerators.Controls.Add(btnGeneratorPassword);
            groupGenerators.Controls.Add(btnGeneratorGuid);
            groupGenerators.Location = new Point(25, 255);
            groupGenerators.Name = "groupGenerators";
            groupGenerators.Size = new Size(716, 193);
            groupGenerators.TabIndex = 2;
            groupGenerators.TabStop = false;
            groupGenerators.Text = "Generators";
            // 
            // btnNumberCard
            // 
            btnNumberCard.Location = new Point(36, 118);
            btnNumberCard.Name = "btnNumberCard";
            btnNumberCard.Size = new Size(132, 43);
            btnNumberCard.TabIndex = 4;
            btnNumberCard.Text = "Number Card Generator";
            btnNumberCard.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(511, 46);
            button1.Name = "button1";
            button1.Size = new Size(130, 43);
            button1.TabIndex = 3;
            button1.Text = "Test Data Generator";
            button1.UseVisualStyleBackColor = true;
            // 
            // btnHashesGenerators
            // 
            btnHashesGenerators.Location = new Point(345, 46);
            btnHashesGenerators.Name = "btnHashesGenerators";
            btnHashesGenerators.Size = new Size(132, 43);
            btnHashesGenerators.TabIndex = 2;
            btnHashesGenerators.Text = "Hashes Generators";
            btnHashesGenerators.UseVisualStyleBackColor = true;
            // 
            // btnGeneratorPassword
            // 
            btnGeneratorPassword.Location = new Point(183, 46);
            btnGeneratorPassword.Name = "btnGeneratorPassword";
            btnGeneratorPassword.Size = new Size(132, 43);
            btnGeneratorPassword.TabIndex = 1;
            btnGeneratorPassword.Text = "Password Generator";
            btnGeneratorPassword.UseVisualStyleBackColor = true;
            // 
            // btnGeneratorGuid
            // 
            btnGeneratorGuid.Location = new Point(36, 46);
            btnGeneratorGuid.Name = "btnGeneratorGuid";
            btnGeneratorGuid.Size = new Size(132, 43);
            btnGeneratorGuid.TabIndex = 0;
            btnGeneratorGuid.Text = "GUID/UID Generator";
            btnGeneratorGuid.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(635, 478);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(106, 39);
            btnClose.TabIndex = 3;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += ButtonClose;
            // 
            // GeneralForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(769, 539);
            Controls.Add(btnClose);
            Controls.Add(groupGenerators);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Name = "GeneralForm";
            Text = "GeneralForm";
            groupBox1.ResumeLayout(false);
            groupGenerators.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnJsonFormatter;
        private Label label1;
        private Button btnCode;
        private Button btnHtmlFormat;
        private GroupBox groupGenerators;
        private Button btnHashesGenerators;
        private Button btnGeneratorPassword;
        private Button btnGeneratorGuid;
        private Button btnNumberCard;
        private Button button1;
        private Button btnClose;
    }
}