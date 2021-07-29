
namespace ASCOM.DewPack
{
    partial class Form1
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
            this.buttonChoose = new System.Windows.Forms.Button();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.labelDriverId = new System.Windows.Forms.Label();
            this.buttonUsb0 = new System.Windows.Forms.Button();
            this.buttonUSB1 = new System.Windows.Forms.Button();
            this.trackBarUSB0 = new System.Windows.Forms.TrackBar();
            this.trackBarUSB1 = new System.Windows.Forms.TrackBar();
            this.buttonUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarUSB0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarUSB1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonChoose
            // 
            this.buttonChoose.Location = new System.Drawing.Point(309, 10);
            this.buttonChoose.Name = "buttonChoose";
            this.buttonChoose.Size = new System.Drawing.Size(72, 23);
            this.buttonChoose.TabIndex = 0;
            this.buttonChoose.Text = "Choose";
            this.buttonChoose.UseVisualStyleBackColor = true;
            this.buttonChoose.Click += new System.EventHandler(this.buttonChoose_Click);
            // 
            // buttonConnect
            // 
            this.buttonConnect.Location = new System.Drawing.Point(309, 39);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(72, 23);
            this.buttonConnect.TabIndex = 1;
            this.buttonConnect.Text = "Connect";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // labelDriverId
            // 
            this.labelDriverId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelDriverId.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::ASCOM.DewPack.Properties.Settings.Default, "DriverId", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.labelDriverId.Location = new System.Drawing.Point(12, 40);
            this.labelDriverId.Name = "labelDriverId";
            this.labelDriverId.Size = new System.Drawing.Size(291, 21);
            this.labelDriverId.TabIndex = 2;
            this.labelDriverId.Text = global::ASCOM.DewPack.Properties.Settings.Default.DriverId;
            this.labelDriverId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonUsb0
            // 
            this.buttonUsb0.Location = new System.Drawing.Point(12, 64);
            this.buttonUsb0.Name = "buttonUsb0";
            this.buttonUsb0.Size = new System.Drawing.Size(75, 23);
            this.buttonUsb0.TabIndex = 3;
            this.buttonUsb0.Text = "USB 0: On";
            this.buttonUsb0.UseVisualStyleBackColor = true;
            this.buttonUsb0.Click += new System.EventHandler(this.buttonUsb0_Click);
            // 
            // buttonUSB1
            // 
            this.buttonUSB1.Location = new System.Drawing.Point(12, 106);
            this.buttonUSB1.Name = "buttonUSB1";
            this.buttonUSB1.Size = new System.Drawing.Size(75, 23);
            this.buttonUSB1.TabIndex = 4;
            this.buttonUSB1.Text = "USB 1: On";
            this.buttonUSB1.UseVisualStyleBackColor = true;
            this.buttonUSB1.Click += new System.EventHandler(this.buttonUSB1_Click);
            // 
            // trackBarUSB0
            // 
            this.trackBarUSB0.Location = new System.Drawing.Point(94, 64);
            this.trackBarUSB0.Maximum = 255;
            this.trackBarUSB0.Name = "trackBarUSB0";
            this.trackBarUSB0.Size = new System.Drawing.Size(287, 45);
            this.trackBarUSB0.TabIndex = 5;
            this.trackBarUSB0.Scroll += new System.EventHandler(this.trackBarUSB0_Scroll);
            // 
            // trackBarUSB1
            // 
            this.trackBarUSB1.Location = new System.Drawing.Point(93, 106);
            this.trackBarUSB1.Maximum = 255;
            this.trackBarUSB1.Name = "trackBarUSB1";
            this.trackBarUSB1.Size = new System.Drawing.Size(288, 45);
            this.trackBarUSB1.TabIndex = 6;
            this.trackBarUSB1.Scroll += new System.EventHandler(this.trackBarUSB1_Scroll);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(12, 155);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdate.TabIndex = 7;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 190);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.trackBarUSB1);
            this.Controls.Add(this.trackBarUSB0);
            this.Controls.Add(this.buttonUSB1);
            this.Controls.Add(this.buttonUsb0);
            this.Controls.Add(this.labelDriverId);
            this.Controls.Add(this.buttonConnect);
            this.Controls.Add(this.buttonChoose);
            this.Name = "Form1";
            this.Text = "TEMPLATEDEVICETYPE Test";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarUSB0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarUSB1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonChoose;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.Label labelDriverId;
        private System.Windows.Forms.Button buttonUsb0;
        private System.Windows.Forms.Button buttonUSB1;
        private System.Windows.Forms.TrackBar trackBarUSB0;
        private System.Windows.Forms.TrackBar trackBarUSB1;
        private System.Windows.Forms.Button buttonUpdate;
    }
}

