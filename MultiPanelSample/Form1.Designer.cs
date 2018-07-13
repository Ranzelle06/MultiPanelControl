namespace MultiPanelSample
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
            this.MainLayout = new System.Windows.Forms.TableLayoutPanel();
            this.NavLayout = new System.Windows.Forms.TableLayoutPanel();
            this.btnRED = new System.Windows.Forms.Button();
            this.btnBLUE = new System.Windows.Forms.Button();
            this.btnGREEN = new System.Windows.Forms.Button();
            this.MainPanelManager = new MultiPanel();
            this.page_RED = new MultiPanelPage();
            this.page_BLUE = new MultiPanelPage();
            this.page_GREEN = new MultiPanelPage();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.page_Home = new MultiPanelPage();
            this.label4 = new System.Windows.Forms.Label();
            this.MainLayout.SuspendLayout();
            this.NavLayout.SuspendLayout();
            this.MainPanelManager.SuspendLayout();
            this.page_RED.SuspendLayout();
            this.page_BLUE.SuspendLayout();
            this.page_GREEN.SuspendLayout();
            this.page_Home.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainLayout
            // 
            this.MainLayout.ColumnCount = 2;
            this.MainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.MainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainLayout.Controls.Add(this.NavLayout, 0, 0);
            this.MainLayout.Controls.Add(this.MainPanelManager, 1, 0);
            this.MainLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainLayout.Location = new System.Drawing.Point(0, 0);
            this.MainLayout.Name = "MainLayout";
            this.MainLayout.RowCount = 1;
            this.MainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.MainLayout.Size = new System.Drawing.Size(644, 423);
            this.MainLayout.TabIndex = 0;
            // 
            // NavLayout
            // 
            this.NavLayout.ColumnCount = 1;
            this.NavLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.NavLayout.Controls.Add(this.btnGREEN, 0, 2);
            this.NavLayout.Controls.Add(this.btnBLUE, 0, 1);
            this.NavLayout.Controls.Add(this.btnRED, 0, 0);
            this.NavLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NavLayout.Location = new System.Drawing.Point(3, 3);
            this.NavLayout.Name = "NavLayout";
            this.NavLayout.RowCount = 4;
            this.NavLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.NavLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.NavLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.NavLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.NavLayout.Size = new System.Drawing.Size(194, 417);
            this.NavLayout.TabIndex = 0;
            // 
            // btnRED
            // 
            this.btnRED.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRED.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnRED.Location = new System.Drawing.Point(3, 3);
            this.btnRED.Name = "btnRED";
            this.btnRED.Size = new System.Drawing.Size(188, 44);
            this.btnRED.TabIndex = 0;
            this.btnRED.Text = "RED";
            this.btnRED.UseVisualStyleBackColor = true;
            this.btnRED.Click += new System.EventHandler(this.btnRED_Click);
            // 
            // btnBLUE
            // 
            this.btnBLUE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBLUE.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnBLUE.Location = new System.Drawing.Point(3, 53);
            this.btnBLUE.Name = "btnBLUE";
            this.btnBLUE.Size = new System.Drawing.Size(188, 44);
            this.btnBLUE.TabIndex = 1;
            this.btnBLUE.Text = "BLUE";
            this.btnBLUE.UseVisualStyleBackColor = true;
            this.btnBLUE.Click += new System.EventHandler(this.btnBLUE_Click);
            // 
            // btnGREEN
            // 
            this.btnGREEN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnGREEN.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnGREEN.Location = new System.Drawing.Point(3, 103);
            this.btnGREEN.Name = "btnGREEN";
            this.btnGREEN.Size = new System.Drawing.Size(188, 44);
            this.btnGREEN.TabIndex = 2;
            this.btnGREEN.Text = "GREEN";
            this.btnGREEN.UseVisualStyleBackColor = true;
            this.btnGREEN.Click += new System.EventHandler(this.btnGREEN_Click);
            // 
            // MainPanelManager
            // 
            this.MainPanelManager.Controls.Add(this.page_RED);
            this.MainPanelManager.Controls.Add(this.page_BLUE);
            this.MainPanelManager.Controls.Add(this.page_GREEN);
            this.MainPanelManager.Controls.Add(this.page_Home);
            this.MainPanelManager.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanelManager.Location = new System.Drawing.Point(203, 3);
            this.MainPanelManager.Name = "MainPanelManager";
            this.MainPanelManager.SelectedPage = this.page_Home;
            this.MainPanelManager.Size = new System.Drawing.Size(438, 417);
            this.MainPanelManager.TabIndex = 1;
            // 
            // page_RED
            // 
            this.page_RED.Controls.Add(this.label1);
            this.page_RED.Dock = System.Windows.Forms.DockStyle.Fill;
            this.page_RED.Location = new System.Drawing.Point(0, 0);
            this.page_RED.Name = "page_RED";
            this.page_RED.Size = new System.Drawing.Size(438, 417);
            this.page_RED.TabIndex = 0;
            this.page_RED.Text = "RED";
            // 
            // page_BLUE
            // 
            this.page_BLUE.Controls.Add(this.label2);
            this.page_BLUE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.page_BLUE.Location = new System.Drawing.Point(0, 0);
            this.page_BLUE.Name = "page_BLUE";
            this.page_BLUE.Size = new System.Drawing.Size(438, 417);
            this.page_BLUE.TabIndex = 1;
            this.page_BLUE.Text = "BLUE";
            // 
            // page_GREEN
            // 
            this.page_GREEN.Controls.Add(this.label3);
            this.page_GREEN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.page_GREEN.Location = new System.Drawing.Point(0, 0);
            this.page_GREEN.Name = "page_GREEN";
            this.page_GREEN.Size = new System.Drawing.Size(438, 417);
            this.page_GREEN.TabIndex = 2;
            this.page_GREEN.Text = "GREEN";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.Location = new System.Drawing.Point(176, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "RED";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label2.Location = new System.Drawing.Point(166, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "BLUE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label3.Location = new System.Drawing.Point(174, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 26);
            this.label3.TabIndex = 1;
            this.label3.Text = "GREEN";
            // 
            // page_Home
            // 
            this.page_Home.Controls.Add(this.label4);
            this.page_Home.Dock = System.Windows.Forms.DockStyle.Fill;
            this.page_Home.Location = new System.Drawing.Point(0, 0);
            this.page_Home.Name = "page_Home";
            this.page_Home.Size = new System.Drawing.Size(438, 417);
            this.page_Home.TabIndex = 3;
            this.page_Home.Text = "Page1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label4.Location = new System.Drawing.Point(160, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 26);
            this.label4.TabIndex = 0;
            this.label4.Text = "HOME";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 423);
            this.Controls.Add(this.MainLayout);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MainLayout.ResumeLayout(false);
            this.NavLayout.ResumeLayout(false);
            this.MainPanelManager.ResumeLayout(false);
            this.page_RED.ResumeLayout(false);
            this.page_RED.PerformLayout();
            this.page_BLUE.ResumeLayout(false);
            this.page_BLUE.PerformLayout();
            this.page_GREEN.ResumeLayout(false);
            this.page_GREEN.PerformLayout();
            this.page_Home.ResumeLayout(false);
            this.page_Home.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel MainLayout;
        private System.Windows.Forms.TableLayoutPanel NavLayout;
        private System.Windows.Forms.Button btnGREEN;
        private System.Windows.Forms.Button btnBLUE;
        private System.Windows.Forms.Button btnRED;
        private MultiPanel MainPanelManager;
        private MultiPanelPage page_RED;
        private System.Windows.Forms.Label label1;
        private MultiPanelPage page_BLUE;
        private System.Windows.Forms.Label label2;
        private MultiPanelPage page_GREEN;
        private System.Windows.Forms.Label label3;
        private MultiPanelPage page_Home;
        private System.Windows.Forms.Label label4;
    }
}

