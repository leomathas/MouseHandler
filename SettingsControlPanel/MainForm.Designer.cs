namespace SettingsControlPanel
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
            this.SelectLabel = new System.Windows.Forms.Label();
            this.DeviceSelector = new System.Windows.Forms.ComboBox();
            this.NaturalScrollingCheckBox = new System.Windows.Forms.CheckBox();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.Details = new System.Windows.Forms.TextBox();
            this.DetailsLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SelectLabel
            // 
            this.SelectLabel.AutoSize = true;
            this.SelectLabel.Location = new System.Drawing.Point(51, 36);
            this.SelectLabel.Name = "SelectLabel";
            this.SelectLabel.Size = new System.Drawing.Size(126, 15);
            this.SelectLabel.TabIndex = 0;
            this.SelectLabel.Text = "Select your usb mouse";
            // 
            // DeviceSelector
            // 
            this.DeviceSelector.FormattingEnabled = true;
            this.DeviceSelector.Location = new System.Drawing.Point(51, 54);
            this.DeviceSelector.Name = "DeviceSelector";
            this.DeviceSelector.Size = new System.Drawing.Size(734, 23);
            this.DeviceSelector.TabIndex = 1;
            this.DeviceSelector.SelectionChangeCommitted += new System.EventHandler(this.DeviceSelector_SelectionChangeCommitted);
            // 
            // NaturalScrollingCheckBox
            // 
            this.NaturalScrollingCheckBox.AutoSize = true;
            this.NaturalScrollingCheckBox.Location = new System.Drawing.Point(51, 266);
            this.NaturalScrollingCheckBox.Name = "NaturalScrollingCheckBox";
            this.NaturalScrollingCheckBox.Size = new System.Drawing.Size(152, 19);
            this.NaturalScrollingCheckBox.TabIndex = 3;
            this.NaturalScrollingCheckBox.Text = "Enable Natural Scrolling";
            this.NaturalScrollingCheckBox.UseVisualStyleBackColor = true;
            // 
            // SubmitButton
            // 
            this.SubmitButton.Location = new System.Drawing.Point(710, 289);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(75, 23);
            this.SubmitButton.TabIndex = 4;
            this.SubmitButton.Text = "Save Changes";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.SubmitButton_MouseClick);
            // 
            // Details
            // 
            this.Details.Location = new System.Drawing.Point(51, 125);
            this.Details.Multiline = true;
            this.Details.Name = "Details";
            this.Details.ReadOnly = true;
            this.Details.Size = new System.Drawing.Size(734, 123);
            this.Details.TabIndex = 2;
            // 
            // DetailsLabel
            // 
            this.DetailsLabel.AutoSize = true;
            this.DetailsLabel.Location = new System.Drawing.Point(51, 107);
            this.DetailsLabel.Name = "DetailsLabel";
            this.DetailsLabel.Size = new System.Drawing.Size(42, 15);
            this.DetailsLabel.TabIndex = 0;
            this.DetailsLabel.Text = "Details";
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(838, 396);
            this.Controls.Add(this.DetailsLabel);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.NaturalScrollingCheckBox);
            this.Controls.Add(this.Details);
            this.Controls.Add(this.DeviceSelector);
            this.Controls.Add(this.SelectLabel);
            this.Name = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }




        #endregion

        private System.Windows.Forms.Label SelectLabel;
        private System.Windows.Forms.ComboBox DeviceSelector;
        private System.Windows.Forms.CheckBox NaturalScrollingCheckBox;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.TextBox Details;
        private System.Windows.Forms.Label DetailsLabel;
    }
}

