namespace IB_TradingPlatform
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
            btnConnect = new Button();
            lbData = new ListBox();
            cboSymbol = new ComboBox();
            SuspendLayout();
            // 
            // btnConnect
            // 
            btnConnect.Location = new Point(30, 41);
            btnConnect.Name = "btnConnect";
            btnConnect.Size = new Size(121, 23);
            btnConnect.TabIndex = 0;
            btnConnect.Text = "Connect";
            btnConnect.UseVisualStyleBackColor = true;
            btnConnect.Click += btnConnect_Click;
            // 
            // lbData
            // 
            lbData.FormattingEnabled = true;
            lbData.ItemHeight = 15;
            lbData.Location = new Point(30, 199);
            lbData.Name = "lbData";
            lbData.Size = new Size(279, 94);
            lbData.TabIndex = 1;
            // 
            // cboSymbol
            // 
            cboSymbol.FormattingEnabled = true;
            cboSymbol.Items.AddRange(new object[] { "MSFT", "TSLA", "IBM" });
            cboSymbol.Location = new Point(30, 89);
            cboSymbol.Name = "cboSymbol";
            cboSymbol.Size = new Size(121, 23);
            cboSymbol.TabIndex = 2;
            cboSymbol.Text = "MSFT";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cboSymbol);
            Controls.Add(lbData);
            Controls.Add(btnConnect);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnConnect;
        private ListBox lbData;
        private ComboBox cboSymbol;
    }
}