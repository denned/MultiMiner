﻿namespace MultiMiner.Win
{
    partial class CoinsForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CoinsForm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.addCoinButton = new System.Windows.Forms.ToolStripButton();
            this.removeCoinButton = new System.Windows.Forms.ToolStripButton();
            this.coinListBox = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.saveButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.poolDownButton = new System.Windows.Forms.Button();
            this.poolUpButton = new System.Windows.Forms.Button();
            this.addPoolButton = new System.Windows.Forms.Button();
            this.removePoolButton = new System.Windows.Forms.Button();
            this.poolListBox = new System.Windows.Forms.ListBox();
            this.miningPoolBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.userNameEdit = new System.Windows.Forms.TextBox();
            this.hostEdit = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.coinConfigurationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.adjustProfitCombo = new System.Windows.Forms.ComboBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.miningPoolBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coinConfigurationBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addCoinButton,
            this.removeCoinButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(558, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // addCoinButton
            // 
            this.addCoinButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.addCoinButton.Image = ((System.Drawing.Image)(resources.GetObject("addCoinButton.Image")));
            this.addCoinButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addCoinButton.Name = "addCoinButton";
            this.addCoinButton.Size = new System.Drawing.Size(61, 22);
            this.addCoinButton.Text = "Add Coin";
            this.addCoinButton.Click += new System.EventHandler(this.addCoinButton_Click);
            // 
            // removeCoinButton
            // 
            this.removeCoinButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.removeCoinButton.Image = ((System.Drawing.Image)(resources.GetObject("removeCoinButton.Image")));
            this.removeCoinButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.removeCoinButton.Name = "removeCoinButton";
            this.removeCoinButton.Size = new System.Drawing.Size(82, 22);
            this.removeCoinButton.Text = "Remove Coin";
            this.removeCoinButton.Click += new System.EventHandler(this.removeCoinButton_Click);
            // 
            // coinListBox
            // 
            this.coinListBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.coinListBox.FormattingEnabled = true;
            this.coinListBox.Location = new System.Drawing.Point(0, 25);
            this.coinListBox.Name = "coinListBox";
            this.coinListBox.Size = new System.Drawing.Size(160, 286);
            this.coinListBox.TabIndex = 1;
            this.coinListBox.SelectedIndexChanged += new System.EventHandler(this.coinListBox_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.saveButton);
            this.panel1.Controls.Add(this.cancelButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 311);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(558, 47);
            this.panel1.TabIndex = 7;
            // 
            // saveButton
            // 
            this.saveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.saveButton.Location = new System.Drawing.Point(390, 12);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 0;
            this.saveButton.Text = "OK";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(471, 12);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.poolDownButton);
            this.groupBox1.Controls.Add(this.poolUpButton);
            this.groupBox1.Controls.Add(this.addPoolButton);
            this.groupBox1.Controls.Add(this.removePoolButton);
            this.groupBox1.Controls.Add(this.poolListBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.userNameEdit);
            this.groupBox1.Controls.Add(this.hostEdit);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(166, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(380, 182);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pools";
            // 
            // poolDownButton
            // 
            this.poolDownButton.BackColor = System.Drawing.SystemColors.Control;
            this.poolDownButton.Image = global::MultiMiner.Win.Properties.Resources.arrow_down;
            this.poolDownButton.Location = new System.Drawing.Point(342, 50);
            this.poolDownButton.Name = "poolDownButton";
            this.poolDownButton.Size = new System.Drawing.Size(25, 25);
            this.poolDownButton.TabIndex = 4;
            this.poolDownButton.UseVisualStyleBackColor = false;
            this.poolDownButton.Click += new System.EventHandler(this.poolDownButton_Click);
            // 
            // poolUpButton
            // 
            this.poolUpButton.BackColor = System.Drawing.SystemColors.Control;
            this.poolUpButton.Image = global::MultiMiner.Win.Properties.Resources.arrow_up;
            this.poolUpButton.Location = new System.Drawing.Point(342, 19);
            this.poolUpButton.Name = "poolUpButton";
            this.poolUpButton.Size = new System.Drawing.Size(25, 25);
            this.poolUpButton.TabIndex = 3;
            this.poolUpButton.UseVisualStyleBackColor = false;
            this.poolUpButton.Click += new System.EventHandler(this.poolUpButton_Click);
            // 
            // addPoolButton
            // 
            this.addPoolButton.BackColor = System.Drawing.SystemColors.Control;
            this.addPoolButton.Image = global::MultiMiner.Win.Properties.Resources.add;
            this.addPoolButton.Location = new System.Drawing.Point(265, 19);
            this.addPoolButton.Name = "addPoolButton";
            this.addPoolButton.Size = new System.Drawing.Size(71, 25);
            this.addPoolButton.TabIndex = 1;
            this.addPoolButton.Text = "Add";
            this.addPoolButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.addPoolButton.UseVisualStyleBackColor = false;
            this.addPoolButton.Click += new System.EventHandler(this.addPoolButton_Click);
            // 
            // removePoolButton
            // 
            this.removePoolButton.BackColor = System.Drawing.SystemColors.Control;
            this.removePoolButton.Image = global::MultiMiner.Win.Properties.Resources.remove;
            this.removePoolButton.Location = new System.Drawing.Point(265, 50);
            this.removePoolButton.Name = "removePoolButton";
            this.removePoolButton.Size = new System.Drawing.Size(71, 25);
            this.removePoolButton.TabIndex = 2;
            this.removePoolButton.Text = "Remove";
            this.removePoolButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.removePoolButton.UseVisualStyleBackColor = false;
            this.removePoolButton.Click += new System.EventHandler(this.removePoolButton_Click);
            // 
            // poolListBox
            // 
            this.poolListBox.DataSource = this.miningPoolBindingSource;
            this.poolListBox.DisplayMember = "Host";
            this.poolListBox.FormattingEnabled = true;
            this.poolListBox.Location = new System.Drawing.Point(6, 19);
            this.poolListBox.Name = "poolListBox";
            this.poolListBox.Size = new System.Drawing.Size(253, 56);
            this.poolListBox.TabIndex = 0;
            this.poolListBox.SelectedIndexChanged += new System.EventHandler(this.poolListBox_SelectedIndexChanged);
            // 
            // miningPoolBindingSource
            // 
            this.miningPoolBindingSource.DataSource = typeof(MultiMiner.Xgminer.MiningPool);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Host:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(262, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Port:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Password:";
            // 
            // userNameEdit
            // 
            this.userNameEdit.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.miningPoolBindingSource, "Username", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.userNameEdit.Location = new System.Drawing.Point(71, 121);
            this.userNameEdit.Name = "userNameEdit";
            this.userNameEdit.Size = new System.Drawing.Size(188, 20);
            this.userNameEdit.TabIndex = 11;
            this.userNameEdit.Validating += new System.ComponentModel.CancelEventHandler(this.textBox4_Validating);
            // 
            // hostEdit
            // 
            this.hostEdit.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.miningPoolBindingSource, "Host", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.hostEdit.Location = new System.Drawing.Point(71, 95);
            this.hostEdit.Name = "hostEdit";
            this.hostEdit.Size = new System.Drawing.Size(188, 20);
            this.hostEdit.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.miningPoolBindingSource, "Port", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBox2.Location = new System.Drawing.Point(297, 95);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(70, 20);
            this.textBox2.TabIndex = 10;
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.miningPoolBindingSource, "Password", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBox1.Location = new System.Drawing.Point(71, 147);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(188, 20);
            this.textBox1.TabIndex = 12;
            // 
            // textBox3
            // 
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.coinConfigurationBindingSource, "MinerFlags", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBox3.Location = new System.Drawing.Point(271, 245);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(262, 20);
            this.textBox3.TabIndex = 4;
            // 
            // coinConfigurationBindingSource
            // 
            this.coinConfigurationBindingSource.DataSource = typeof(MultiMiner.Engine.Configuration.CoinConfiguration);
            this.coinConfigurationBindingSource.CurrentChanged += new System.EventHandler(this.coinConfigurationBindingSource_CurrentChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(173, 248);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Miner parameters:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(174, 274);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Adjust profitability:";
            // 
            // textBox5
            // 
            this.textBox5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.coinConfigurationBindingSource, "ProfitabilityAdjustment", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBox5.Location = new System.Drawing.Point(271, 271);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(67, 20);
            this.textBox5.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(344, 274);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(15, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "%";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(365, 274);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Adjust by:";
            // 
            // adjustProfitCombo
            // 
            this.adjustProfitCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.adjustProfitCombo.FormattingEnabled = true;
            this.adjustProfitCombo.Items.AddRange(new object[] {
            "Addition",
            "Multiplication"});
            this.adjustProfitCombo.Location = new System.Drawing.Point(424, 271);
            this.adjustProfitCombo.Name = "adjustProfitCombo";
            this.adjustProfitCombo.Size = new System.Drawing.Size(109, 21);
            this.adjustProfitCombo.TabIndex = 6;
            this.adjustProfitCombo.SelectedIndexChanged += new System.EventHandler(this.adjustProfitCombo_SelectedIndexChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.coinConfigurationBindingSource, "Enabled", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkBox1.Location = new System.Drawing.Point(166, 28);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(152, 17);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "Coin configuration enabled";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // CoinsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(558, 358);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.adjustProfitCombo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.coinListBox);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CoinsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Configure Coins";
            this.Load += new System.EventHandler(this.CoinsForm_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.miningPoolBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coinConfigurationBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ListBox coinListBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.ToolStripButton removeCoinButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button addPoolButton;
        private System.Windows.Forms.Button removePoolButton;
        private System.Windows.Forms.ListBox poolListBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox userNameEdit;
        private System.Windows.Forms.TextBox hostEdit;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.BindingSource miningPoolBindingSource;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.BindingSource coinConfigurationBindingSource;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox adjustProfitCombo;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button poolDownButton;
        private System.Windows.Forms.Button poolUpButton;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripButton addCoinButton;
    }
}