namespace facilitator.app
{
    partial class FormFormatters
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
            label1 = new Label();
            jsonDataUrl = new RichTextBox();
            btnProcess = new Button();
            jsonDataFormated = new RichTextBox();
            btnCopy = new Button();
            btnClose = new Button();
            btnClear = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 23);
            label1.Name = "label1";
            label1.Size = new Size(88, 15);
            label1.TabIndex = 0;
            label1.Text = "JSON Data/URL";
            // 
            // jsonDataUrl
            // 
            jsonDataUrl.Location = new Point(23, 55);
            jsonDataUrl.Name = "jsonDataUrl";
            jsonDataUrl.Size = new Size(1080, 252);
            jsonDataUrl.TabIndex = 1;
            jsonDataUrl.Text = "";
            // 
            // btnProcess
            // 
            btnProcess.Location = new Point(23, 326);
            btnProcess.Name = "btnProcess";
            btnProcess.Size = new Size(120, 35);
            btnProcess.TabIndex = 2;
            btnProcess.Text = "Process";
            btnProcess.UseVisualStyleBackColor = true;
            btnProcess.Click += ButtonProcess;
            // 
            // jsonDataFormated
            // 
            jsonDataFormated.Enabled = false;
            jsonDataFormated.Location = new Point(12, 383);
            jsonDataFormated.Name = "jsonDataFormated";
            jsonDataFormated.Size = new Size(1100, 252);
            jsonDataFormated.TabIndex = 3;
            jsonDataFormated.Text = "";
            // 
            // btnCopy
            // 
            btnCopy.Location = new Point(171, 326);
            btnCopy.Name = "btnCopy";
            btnCopy.Size = new Size(120, 35);
            btnCopy.TabIndex = 4;
            btnCopy.Text = "Copy";
            btnCopy.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(992, 658);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(120, 35);
            btnClose.TabIndex = 6;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += ButtonClose;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(319, 326);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(120, 35);
            btnClear.TabIndex = 7;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += ButtonClear;
            // 
            // FormFormatters
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1131, 725);
            Controls.Add(btnClear);
            Controls.Add(btnClose);
            Controls.Add(btnCopy);
            Controls.Add(jsonDataFormated);
            Controls.Add(btnProcess);
            Controls.Add(jsonDataUrl);
            Controls.Add(label1);
            Name = "FormFormatters";
            Text = "FormFormatters";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private RichTextBox jsonDataUrl;
        private Button btnProcess;
        private RichTextBox jsonDataFormated;
        private Button btnCopy;
        private Button btnClose;
        private Button btnClear;
    }
}