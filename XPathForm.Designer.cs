namespace XmlStore
{
    partial class XPathForm
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
            this.xmlTreeView = new System.Windows.Forms.TreeView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.xPathValidateButton = new System.Windows.Forms.Button();
            this.XPathTextBox = new System.Windows.Forms.TextBox();
            this.mainTabControl = new System.Windows.Forms.TabControl();
            this.resultsTabPage = new System.Windows.Forms.TabPage();
            this.resultsRichTextBox = new System.Windows.Forms.RichTextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.errorsRichTextBox = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            this.mainTabControl.SuspendLayout();
            this.resultsTabPage.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // xmlTreeView
            // 
            this.xmlTreeView.Location = new System.Drawing.Point(6, 19);
            this.xmlTreeView.Name = "xmlTreeView";
            this.xmlTreeView.Size = new System.Drawing.Size(699, 290);
            this.xmlTreeView.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.xPathValidateButton);
            this.groupBox1.Controls.Add(this.XPathTextBox);
            this.groupBox1.Controls.Add(this.xmlTreeView);
            this.groupBox1.Location = new System.Drawing.Point(2, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(711, 346);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "XPath validator:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 317);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enter path to validate:";
            // 
            // xPathValidateButton
            // 
            this.xPathValidateButton.Location = new System.Drawing.Point(614, 314);
            this.xPathValidateButton.Name = "xPathValidateButton";
            this.xPathValidateButton.Size = new System.Drawing.Size(91, 23);
            this.xPathValidateButton.TabIndex = 2;
            this.xPathValidateButton.Text = "Validate";
            this.xPathValidateButton.UseVisualStyleBackColor = true;
            this.xPathValidateButton.Click += new System.EventHandler(this.xPathValidateButton_Click);
            // 
            // XPathTextBox
            // 
            this.XPathTextBox.Location = new System.Drawing.Point(114, 315);
            this.XPathTextBox.Name = "XPathTextBox";
            this.XPathTextBox.Size = new System.Drawing.Size(494, 20);
            this.XPathTextBox.TabIndex = 1;
            // 
            // mainTabControl
            // 
            this.mainTabControl.Controls.Add(this.resultsTabPage);
            this.mainTabControl.Controls.Add(this.tabPage2);
            this.mainTabControl.Location = new System.Drawing.Point(2, 356);
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(711, 236);
            this.mainTabControl.TabIndex = 2;
            // 
            // resultsTabPage
            // 
            this.resultsTabPage.Controls.Add(this.resultsRichTextBox);
            this.resultsTabPage.Location = new System.Drawing.Point(4, 22);
            this.resultsTabPage.Name = "resultsTabPage";
            this.resultsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.resultsTabPage.Size = new System.Drawing.Size(703, 210);
            this.resultsTabPage.TabIndex = 0;
            this.resultsTabPage.Text = "Results";
            this.resultsTabPage.UseVisualStyleBackColor = true;
            // 
            // resultsRichTextBox
            // 
            this.resultsRichTextBox.Location = new System.Drawing.Point(4, 7);
            this.resultsRichTextBox.Name = "resultsRichTextBox";
            this.resultsRichTextBox.ReadOnly = true;
            this.resultsRichTextBox.Size = new System.Drawing.Size(699, 197);
            this.resultsRichTextBox.TabIndex = 0;
            this.resultsRichTextBox.Text = "";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.errorsRichTextBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(703, 210);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Errors";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // errorsRichTextBox
            // 
            this.errorsRichTextBox.Location = new System.Drawing.Point(2, 7);
            this.errorsRichTextBox.Name = "errorsRichTextBox";
            this.errorsRichTextBox.ReadOnly = true;
            this.errorsRichTextBox.Size = new System.Drawing.Size(699, 200);
            this.errorsRichTextBox.TabIndex = 0;
            this.errorsRichTextBox.Text = "";
            // 
            // XPathForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 594);
            this.Controls.Add(this.mainTabControl);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "XPathForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "XPath Validator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.mainTabControl.ResumeLayout(false);
            this.resultsTabPage.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView xmlTreeView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button xPathValidateButton;
        private System.Windows.Forms.TextBox XPathTextBox;
        private System.Windows.Forms.TabControl mainTabControl;
        private System.Windows.Forms.TabPage resultsTabPage;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.RichTextBox resultsRichTextBox;
        private System.Windows.Forms.RichTextBox errorsRichTextBox;
    }
}