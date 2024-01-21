namespace facilitator.app
{
    partial class GeneralForm
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
            btnJsonFormatter = new Button();
            btnHtmlFormatter = new Button();
            btnGuidGenerator = new Button();
            btnGeneratorHashes = new Button();
            btnPasswordGenerator = new Button();
            groupGenerators = new GroupBox();
            button3 = new Button();
            button2 = new Button();
            groupFormatters = new GroupBox();
            groupAnalisys = new GroupBox();
            button1 = new Button();
            groupGenerators.SuspendLayout();
            groupFormatters.SuspendLayout();
            groupAnalisys.SuspendLayout();
            SuspendLayout();
            // 
            // btnJsonFormatter
            // 
            btnJsonFormatter.Location = new Point(15, 34);
            btnJsonFormatter.Name = "btnJsonFormatter";
            btnJsonFormatter.Size = new Size(113, 34);
            btnJsonFormatter.TabIndex = 1;
            btnJsonFormatter.Text = "JSON Formatter";
            btnJsonFormatter.UseVisualStyleBackColor = true;
            btnJsonFormatter.Click += btnJsonFormatter_Click;
            // 
            // btnHtmlFormatter
            // 
            btnHtmlFormatter.Location = new Point(146, 34);
            btnHtmlFormatter.Name = "btnHtmlFormatter";
            btnHtmlFormatter.Size = new Size(113, 34);
            btnHtmlFormatter.TabIndex = 2;
            btnHtmlFormatter.Text = "HTML Formatter";
            btnHtmlFormatter.UseVisualStyleBackColor = true;
            // 
            // btnGuidGenerator
            // 
            btnGuidGenerator.Location = new Point(287, 48);
            btnGuidGenerator.Name = "btnGuidGenerator";
            btnGuidGenerator.Size = new Size(113, 31);
            btnGuidGenerator.TabIndex = 4;
            btnGuidGenerator.Text = "Guid Generator";
            btnGuidGenerator.UseVisualStyleBackColor = true;
            // 
            // btnGeneratorHashes
            // 
            btnGeneratorHashes.Location = new Point(15, 48);
            btnGeneratorHashes.Name = "btnGeneratorHashes";
            btnGeneratorHashes.Size = new Size(113, 31);
            btnGeneratorHashes.TabIndex = 5;
            btnGeneratorHashes.Text = "Hashes Generators";
            btnGeneratorHashes.UseVisualStyleBackColor = true;
            // 
            // btnPasswordGenerator
            // 
            btnPasswordGenerator.Location = new Point(146, 48);
            btnPasswordGenerator.Name = "btnPasswordGenerator";
            btnPasswordGenerator.Size = new Size(113, 31);
            btnPasswordGenerator.TabIndex = 6;
            btnPasswordGenerator.Text = "Password Generator";
            btnPasswordGenerator.UseVisualStyleBackColor = true;
            // 
            // groupGenerators
            // 
            groupGenerators.Controls.Add(button3);
            groupGenerators.Controls.Add(button2);
            groupGenerators.Controls.Add(btnGeneratorHashes);
            groupGenerators.Controls.Add(btnGuidGenerator);
            groupGenerators.Controls.Add(btnPasswordGenerator);
            groupGenerators.Location = new Point(27, 132);
            groupGenerators.Name = "groupGenerators";
            groupGenerators.Size = new Size(753, 139);
            groupGenerators.TabIndex = 7;
            groupGenerators.TabStop = false;
            groupGenerators.Text = "Generators";
            // 
            // button3
            // 
            button3.Location = new Point(567, 48);
            button3.Name = "button3";
            button3.Size = new Size(139, 31);
            button3.TabIndex = 8;
            button3.Text = "Test Data Generator";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(430, 48);
            button2.Name = "button2";
            button2.Size = new Size(113, 31);
            button2.TabIndex = 7;
            button2.Text = "Barcode Generator";
            button2.UseVisualStyleBackColor = true;
            // 
            // groupFormatters
            // 
            groupFormatters.Controls.Add(btnJsonFormatter);
            groupFormatters.Controls.Add(btnHtmlFormatter);
            groupFormatters.Location = new Point(27, 12);
            groupFormatters.Name = "groupFormatters";
            groupFormatters.Size = new Size(753, 100);
            groupFormatters.TabIndex = 8;
            groupFormatters.TabStop = false;
            groupFormatters.Text = "Formatters";
            // 
            // groupAnalisys
            // 
            groupAnalisys.Controls.Add(button1);
            groupAnalisys.Location = new Point(28, 296);
            groupAnalisys.Name = "groupAnalisys";
            groupAnalisys.Size = new Size(747, 100);
            groupAnalisys.TabIndex = 9;
            groupAnalisys.TabStop = false;
            groupAnalisys.Text = "Analisys";
            // 
            // button1
            // 
            button1.Location = new Point(14, 41);
            button1.Name = "button1";
            button1.Size = new Size(140, 31);
            button1.TabIndex = 0;
            button1.Text = "Query SQL Analizye";
            button1.UseVisualStyleBackColor = true;
            // 
            // GeneralForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 484);
            Controls.Add(groupAnalisys);
            Controls.Add(groupFormatters);
            Controls.Add(groupGenerators);
            Name = "GeneralForm";
            Text = "Facilitator Tools";
            Load += GeneralForm_Load;
            groupGenerators.ResumeLayout(false);
            groupFormatters.ResumeLayout(false);
            groupAnalisys.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Button btnJsonFormatter;
        private Button btnHtmlFormatter;
        private Button btnGuidGenerator;
        private Button btnGeneratorHashes;
        private Button btnPasswordGenerator;
        private GroupBox groupGenerators;
        private GroupBox groupFormatters;
        private Button button2;
        private GroupBox groupAnalisys;
        private Button button1;
        private Button button3;
    }
}