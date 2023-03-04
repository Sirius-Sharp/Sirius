namespace Sirius_Sharp
{
    partial class ImageRec
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
            CaptureBox = new PictureBox();
            panel1 = new Panel();
            ResultTextBox = new RichTextBox();
            CaptureButton = new Button();
            AutoCheckBox = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)CaptureBox).BeginInit();
            SuspendLayout();
            // 
            // CaptureBox
            // 
            CaptureBox.BackColor = Color.OrangeRed;
            CaptureBox.Dock = DockStyle.Top;
            CaptureBox.Location = new Point(0, 0);
            CaptureBox.Name = "CaptureBox";
            CaptureBox.Size = new Size(728, 287);
            CaptureBox.TabIndex = 0;
            CaptureBox.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 287);
            panel1.Name = "panel1";
            panel1.Size = new Size(728, 28);
            panel1.TabIndex = 1;
            // 
            // ResultTextBox
            // 
            ResultTextBox.Dock = DockStyle.Top;
            ResultTextBox.Location = new Point(0, 315);
            ResultTextBox.Name = "ResultTextBox";
            ResultTextBox.Size = new Size(728, 87);
            ResultTextBox.TabIndex = 2;
            ResultTextBox.Text = "";
            // 
            // CaptureButton
            // 
            CaptureButton.Dock = DockStyle.Top;
            CaptureButton.Location = new Point(0, 402);
            CaptureButton.Name = "CaptureButton";
            CaptureButton.Size = new Size(728, 49);
            CaptureButton.TabIndex = 3;
            CaptureButton.Text = "Capture";
            CaptureButton.UseVisualStyleBackColor = true;
            CaptureButton.Click += CaptureButton_Click;
            // 
            // AutoCheckBox
            // 
            AutoCheckBox.AutoSize = true;
            AutoCheckBox.Dock = DockStyle.Fill;
            AutoCheckBox.Location = new Point(0, 451);
            AutoCheckBox.Name = "AutoCheckBox";
            AutoCheckBox.Size = new Size(728, 58);
            AutoCheckBox.TabIndex = 4;
            AutoCheckBox.Text = "AutoCapture";
            AutoCheckBox.UseVisualStyleBackColor = true;
            // 
            // ImageRec
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(728, 509);
            Controls.Add(AutoCheckBox);
            Controls.Add(CaptureButton);
            Controls.Add(ResultTextBox);
            Controls.Add(panel1);
            Controls.Add(CaptureBox);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "ImageRec";
            Text = "Add Text";
            TransparencyKey = Color.OrangeRed;
            Load += ImageRec_Load;
            ((System.ComponentModel.ISupportInitialize)CaptureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox CaptureBox;
        private Panel panel1;
        private RichTextBox ResultTextBox;
        private Button CaptureButton;
        private CheckBox AutoCheckBox;
    }
}