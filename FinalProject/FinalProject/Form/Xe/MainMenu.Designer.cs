﻿
namespace FinalProject
{
    partial class fMainMenu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.xeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xeCôngTyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xeGởiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thợToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.côngViệcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hợpĐồngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xeToolStripMenuItem,
            this.thợToolStripMenuItem,
            this.côngViệcToolStripMenuItem,
            this.hợpĐồngToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(699, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // xeToolStripMenuItem
            // 
            this.xeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xeCôngTyToolStripMenuItem,
            this.xeGởiToolStripMenuItem});
            this.xeToolStripMenuItem.Name = "xeToolStripMenuItem";
            this.xeToolStripMenuItem.Size = new System.Drawing.Size(32, 20);
            this.xeToolStripMenuItem.Text = "Xe";
            this.xeToolStripMenuItem.Click += new System.EventHandler(this.xeToolStripMenuItem_Click);
            // 
            // xeCôngTyToolStripMenuItem
            // 
            this.xeCôngTyToolStripMenuItem.Name = "xeCôngTyToolStripMenuItem";
            this.xeCôngTyToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.xeCôngTyToolStripMenuItem.Text = "Xe Công Ty";
            // 
            // xeGởiToolStripMenuItem
            // 
            this.xeGởiToolStripMenuItem.Name = "xeGởiToolStripMenuItem";
            this.xeGởiToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.xeGởiToolStripMenuItem.Text = "Xe Gởi";
            // 
            // thợToolStripMenuItem
            // 
            this.thợToolStripMenuItem.Name = "thợToolStripMenuItem";
            this.thợToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.thợToolStripMenuItem.Text = "Thợ";
            // 
            // côngViệcToolStripMenuItem
            // 
            this.côngViệcToolStripMenuItem.Name = "côngViệcToolStripMenuItem";
            this.côngViệcToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.côngViệcToolStripMenuItem.Text = "Công Việc";
            // 
            // hợpĐồngToolStripMenuItem
            // 
            this.hợpĐồngToolStripMenuItem.Name = "hợpĐồngToolStripMenuItem";
            this.hợpĐồngToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.hợpĐồngToolStripMenuItem.Text = "Hợp Đồng";
            // 
            // fMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 415);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "fMainMenu";
            this.Text = "MainMenu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem xeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xeCôngTyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xeGởiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thợToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem côngViệcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hợpĐồngToolStripMenuItem;
    }
}

