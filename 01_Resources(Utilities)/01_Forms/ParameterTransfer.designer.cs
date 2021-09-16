
namespace UtilityForms
{
    partial class ParameterTransfer
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
            this.CopyFrom = new System.Windows.Forms.TextBox();
            this.CopyTo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.GroupElement = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ParameterType = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CopyFrom
            // 
            this.CopyFrom.Location = new System.Drawing.Point(12, 36);
            this.CopyFrom.Name = "CopyFrom";
            this.CopyFrom.Size = new System.Drawing.Size(282, 20);
            this.CopyFrom.TabIndex = 0;
            // 
            // CopyTo
            // 
            this.CopyTo.Location = new System.Drawing.Point(339, 36);
            this.CopyTo.Name = "CopyTo";
            this.CopyTo.Size = new System.Drawing.Size(282, 20);
            this.CopyTo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ParameterTo Copy From";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(340, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "ParameterTo Copy To";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // GroupElement
            // 
            this.GroupElement.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GroupElement.FormattingEnabled = true;
            this.GroupElement.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.GroupElement.Location = new System.Drawing.Point(154, 74);
            this.GroupElement.Name = "GroupElement";
            this.GroupElement.Size = new System.Drawing.Size(139, 21);
            this.GroupElement.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Process Elements in Groups";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(342, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Parameter Type";
            // 
            // ParameterType
            // 
            this.ParameterType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ParameterType.FormattingEnabled = true;
            this.ParameterType.Items.AddRange(new object[] {
            "Instance",
            "Type"});
            this.ParameterType.Location = new System.Drawing.Point(485, 75);
            this.ParameterType.Name = "ParameterType";
            this.ParameterType.Size = new System.Drawing.Size(136, 21);
            this.ParameterType.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(546, 102);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Run";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ParameterTransfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 130);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ParameterType);
            this.Controls.Add(this.GroupElement);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CopyTo);
            this.Controls.Add(this.CopyFrom);
            this.Name = "ParameterTransfer";
            this.Text = "ParameterTransfer";
            this.Load += new System.EventHandler(this.ParameterTransfer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CopyFrom;
        private System.Windows.Forms.TextBox CopyTo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox GroupElement;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox ParameterType;
        private System.Windows.Forms.Button button1;
    }
}