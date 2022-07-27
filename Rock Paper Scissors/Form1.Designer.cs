
namespace Rock_Paper_Scissors
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
            this.btnRock = new System.Windows.Forms.Button();
            this.btnPaper = new System.Windows.Forms.Button();
            this.btnScissor = new System.Windows.Forms.Button();
            this.PLAYER_PIC = new System.Windows.Forms.PictureBox();
            this.CPU_PIC = new System.Windows.Forms.PictureBox();
            this.lblCPUchoice = new System.Windows.Forms.Label();
            this.lblPlayerchoice = new System.Windows.Forms.Label();
            this.lblPlayerresult = new System.Windows.Forms.Label();
            this.lblCPUresult = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PLAYER_PIC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CPU_PIC)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRock
            // 
            this.btnRock.Font = new System.Drawing.Font("Snap ITC", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRock.Location = new System.Drawing.Point(86, 377);
            this.btnRock.Name = "btnRock";
            this.btnRock.Size = new System.Drawing.Size(106, 40);
            this.btnRock.TabIndex = 0;
            this.btnRock.Tag = "R";
            this.btnRock.Text = "Rock";
            this.btnRock.UseVisualStyleBackColor = true;
            this.btnRock.Click += new System.EventHandler(this.MakeChoiceEvent);
            // 
            // btnPaper
            // 
            this.btnPaper.Font = new System.Drawing.Font("Snap ITC", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPaper.Location = new System.Drawing.Point(344, 377);
            this.btnPaper.Name = "btnPaper";
            this.btnPaper.Size = new System.Drawing.Size(106, 40);
            this.btnPaper.TabIndex = 0;
            this.btnPaper.Tag = "P";
            this.btnPaper.Text = "Paper";
            this.btnPaper.UseVisualStyleBackColor = true;
            this.btnPaper.Click += new System.EventHandler(this.MakeChoiceEvent);
            // 
            // btnScissor
            // 
            this.btnScissor.Font = new System.Drawing.Font("Snap ITC", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnScissor.Location = new System.Drawing.Point(605, 377);
            this.btnScissor.Name = "btnScissor";
            this.btnScissor.Size = new System.Drawing.Size(106, 40);
            this.btnScissor.TabIndex = 0;
            this.btnScissor.Tag = "S";
            this.btnScissor.Text = "Scissors";
            this.btnScissor.UseVisualStyleBackColor = true;
            this.btnScissor.Click += new System.EventHandler(this.MakeChoiceEvent);
            // 
            // PLAYER_PIC
            // 
            this.PLAYER_PIC.Location = new System.Drawing.Point(350, 215);
            this.PLAYER_PIC.Name = "PLAYER_PIC";
            this.PLAYER_PIC.Size = new System.Drawing.Size(100, 100);
            this.PLAYER_PIC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PLAYER_PIC.TabIndex = 1;
            this.PLAYER_PIC.TabStop = false;
            // 
            // CPU_PIC
            // 
            this.CPU_PIC.Location = new System.Drawing.Point(350, 52);
            this.CPU_PIC.Name = "CPU_PIC";
            this.CPU_PIC.Size = new System.Drawing.Size(100, 100);
            this.CPU_PIC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CPU_PIC.TabIndex = 1;
            this.CPU_PIC.TabStop = false;
            // 
            // lblCPUchoice
            // 
            this.lblCPUchoice.AutoSize = true;
            this.lblCPUchoice.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblCPUchoice.ForeColor = System.Drawing.Color.White;
            this.lblCPUchoice.Location = new System.Drawing.Point(316, 9);
            this.lblCPUchoice.Name = "lblCPUchoice";
            this.lblCPUchoice.Size = new System.Drawing.Size(168, 28);
            this.lblCPUchoice.TabIndex = 2;
            this.lblCPUchoice.Text = "Computer Choice";
            // 
            // lblPlayerchoice
            // 
            this.lblPlayerchoice.AutoSize = true;
            this.lblPlayerchoice.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblPlayerchoice.ForeColor = System.Drawing.Color.White;
            this.lblPlayerchoice.Location = new System.Drawing.Point(330, 335);
            this.lblPlayerchoice.Name = "lblPlayerchoice";
            this.lblPlayerchoice.Size = new System.Drawing.Size(135, 28);
            this.lblPlayerchoice.TabIndex = 2;
            this.lblPlayerchoice.Text = "Player Choice";
            // 
            // lblPlayerresult
            // 
            this.lblPlayerresult.AutoSize = true;
            this.lblPlayerresult.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblPlayerresult.ForeColor = System.Drawing.Color.White;
            this.lblPlayerresult.Location = new System.Drawing.Point(63, 124);
            this.lblPlayerresult.Name = "lblPlayerresult";
            this.lblPlayerresult.Size = new System.Drawing.Size(129, 28);
            this.lblPlayerresult.TabIndex = 2;
            this.lblPlayerresult.Text = "Player Result";
            // 
            // lblCPUresult
            // 
            this.lblCPUresult.AutoSize = true;
            this.lblCPUresult.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblCPUresult.ForeColor = System.Drawing.Color.White;
            this.lblCPUresult.Location = new System.Drawing.Point(605, 124);
            this.lblCPUresult.Name = "lblCPUresult";
            this.lblCPUresult.Size = new System.Drawing.Size(162, 28);
            this.lblCPUresult.TabIndex = 2;
            this.lblCPUresult.Text = "Computer Result";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblCPUresult);
            this.Controls.Add(this.lblPlayerresult);
            this.Controls.Add(this.lblPlayerchoice);
            this.Controls.Add(this.lblCPUchoice);
            this.Controls.Add(this.CPU_PIC);
            this.Controls.Add(this.PLAYER_PIC);
            this.Controls.Add(this.btnScissor);
            this.Controls.Add(this.btnPaper);
            this.Controls.Add(this.btnRock);
            this.Name = "Form1";
            this.Text = "Rock Paper Scissors";
            ((System.ComponentModel.ISupportInitialize)(this.PLAYER_PIC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CPU_PIC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRock;
        private System.Windows.Forms.Button btnPaper;
        private System.Windows.Forms.Button btnScissor;
        private System.Windows.Forms.PictureBox PLAYER_PIC;
        private System.Windows.Forms.PictureBox CPU_PIC;
        private System.Windows.Forms.Label lblCPUchoice;
        private System.Windows.Forms.Label lblPlayerchoice;
        private System.Windows.Forms.Label lblPlayerresult;
        private System.Windows.Forms.Label lblCPUresult;
    }
}

