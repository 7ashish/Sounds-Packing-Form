namespace SoundPacking_Final
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
            this.components = new System.ComponentModel.Container();
            this.SourceBrowse = new System.Windows.Forms.Button();
            this.Sourcee = new System.Windows.Forms.FolderBrowserDialog();
            this.SourceTxt = new System.Windows.Forms.TextBox();
            this.Source = new System.Windows.Forms.Label();
            this.Type = new System.Windows.Forms.ComboBox();
            this.Start = new System.Windows.Forms.Button();
            this.ChooseType = new System.Windows.Forms.Label();
            this.Time = new System.Windows.Forms.Label();
            this.MaximumTime = new System.Windows.Forms.Label();
            this.MaxTime = new System.Windows.Forms.TextBox();
            this.Destinationn = new System.Windows.Forms.FolderBrowserDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.FirstFitTime = new System.Windows.Forms.Label();
            this.BestFitTime = new System.Windows.Forms.Label();
            this.BestFitDecreasingTime = new System.Windows.Forms.Label();
            this.FolderFillingTime = new System.Windows.Forms.Label();
            this.WorstFitLinearTime = new System.Windows.Forms.Label();
            this.WorstFitDecTime = new System.Windows.Forms.Label();
            this.WorstFitPQTime = new System.Windows.Forms.Label();
            this.WorstFitDecPQ = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // SourceBrowse
            // 
            this.SourceBrowse.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.SourceBrowse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SourceBrowse.Location = new System.Drawing.Point(701, 51);
            this.SourceBrowse.Margin = new System.Windows.Forms.Padding(2);
            this.SourceBrowse.Name = "SourceBrowse";
            this.SourceBrowse.Size = new System.Drawing.Size(40, 29);
            this.SourceBrowse.TabIndex = 0;
            this.SourceBrowse.Text = "...";
            this.SourceBrowse.UseVisualStyleBackColor = true;
            this.SourceBrowse.Click += new System.EventHandler(this.SourceBrowse_Click);
            // 
            // SourceTxt
            // 
            this.SourceTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SourceTxt.Location = new System.Drawing.Point(328, 50);
            this.SourceTxt.Margin = new System.Windows.Forms.Padding(2);
            this.SourceTxt.Multiline = true;
            this.SourceTxt.Name = "SourceTxt";
            this.SourceTxt.Size = new System.Drawing.Size(347, 30);
            this.SourceTxt.TabIndex = 2;
            // 
            // Source
            // 
            this.Source.AutoSize = true;
            this.Source.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Source.Location = new System.Drawing.Point(216, 53);
            this.Source.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Source.Name = "Source";
            this.Source.Size = new System.Drawing.Size(66, 20);
            this.Source.TabIndex = 4;
            this.Source.Text = "Source";
            // 
            // Type
            // 
            this.Type.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Type.FormattingEnabled = true;
            this.Type.Items.AddRange(new object[] {
            "First_Fit_Decreasing_Algorithm",
            "Best_Fit_Algorithm",
            "Best_Fit_Decreasing_Algorithm",
            "Worst_Fit_Algorithm",
            "Worst_Fit_Deacreasing_Algorithm",
            "Worst_Fit_Algorithm_Priority_Queue",
            "Worst_Fit_Decreasing_Algorithm_Priority_Queue",
            "Folder_Filling_Algorithm ",
            "Multi_Threading"});
            this.Type.Location = new System.Drawing.Point(47, 152);
            this.Type.Margin = new System.Windows.Forms.Padding(2);
            this.Type.Name = "Type";
            this.Type.Size = new System.Drawing.Size(460, 28);
            this.Type.TabIndex = 6;
            this.Type.SelectedIndexChanged += new System.EventHandler(this.Type_SelectedIndexChanged);
            // 
            // Start
            // 
            this.Start.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Start.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Start.Location = new System.Drawing.Point(644, 422);
            this.Start.Margin = new System.Windows.Forms.Padding(2);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(108, 27);
            this.Start.TabIndex = 7;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // ChooseType
            // 
            this.ChooseType.AutoSize = true;
            this.ChooseType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChooseType.Location = new System.Drawing.Point(216, 115);
            this.ChooseType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ChooseType.Name = "ChooseType";
            this.ChooseType.Size = new System.Drawing.Size(113, 20);
            this.ChooseType.TabIndex = 8;
            this.ChooseType.Text = "Choose Type";
            this.ChooseType.Click += new System.EventHandler(this.ChooseType_Click);
            // 
            // Time
            // 
            this.Time.AutoSize = true;
            this.Time.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Time.Location = new System.Drawing.Point(41, 226);
            this.Time.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(47, 20);
            this.Time.TabIndex = 10;
            this.Time.Text = "Time";
            // 
            // MaximumTime
            // 
            this.MaximumTime.AutoSize = true;
            this.MaximumTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximumTime.Location = new System.Drawing.Point(590, 115);
            this.MaximumTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MaximumTime.Name = "MaximumTime";
            this.MaximumTime.Size = new System.Drawing.Size(121, 20);
            this.MaximumTime.TabIndex = 11;
            this.MaximumTime.Text = "Folder Length";
            // 
            // MaxTime
            // 
            this.MaxTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaxTime.Location = new System.Drawing.Point(594, 165);
            this.MaxTime.Margin = new System.Windows.Forms.Padding(2);
            this.MaxTime.Multiline = true;
            this.MaxTime.Name = "MaxTime";
            this.MaxTime.Size = new System.Drawing.Size(110, 25);
            this.MaxTime.TabIndex = 12;
            this.MaxTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 266);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "First Fit Decreasing Algorithm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 304);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "Best Fit Algorithm";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(43, 338);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "Best Fit Decreasing Algorithm";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(44, 375);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 16);
            this.label4.TabIndex = 16;
            this.label4.Text = "Folder Filling Algorithm";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(419, 266);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 16);
            this.label5.TabIndex = 17;
            this.label5.Text = "Worst Fit Linear Algorithm";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(419, 304);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(186, 16);
            this.label6.TabIndex = 18;
            this.label6.Text = "Worst Fit Decreasing Algorithm";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(419, 338);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(145, 16);
            this.label7.TabIndex = 19;
            this.label7.Text = "Worst Fit Priority Queue";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(419, 375);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(212, 16);
            this.label8.TabIndex = 20;
            this.label8.Text = "Worst Fit Decreasing Priority Queue";
            // 
            // FirstFitTime
            // 
            this.FirstFitTime.AutoSize = true;
            this.FirstFitTime.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstFitTime.Location = new System.Drawing.Point(290, 266);
            this.FirstFitTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.FirstFitTime.Name = "FirstFitTime";
            this.FirstFitTime.Size = new System.Drawing.Size(29, 16);
            this.FirstFitTime.TabIndex = 21;
            this.FirstFitTime.Text = "000";
            // 
            // BestFitTime
            // 
            this.BestFitTime.AutoSize = true;
            this.BestFitTime.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BestFitTime.Location = new System.Drawing.Point(290, 304);
            this.BestFitTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.BestFitTime.Name = "BestFitTime";
            this.BestFitTime.Size = new System.Drawing.Size(29, 16);
            this.BestFitTime.TabIndex = 22;
            this.BestFitTime.Text = "000";
            // 
            // BestFitDecreasingTime
            // 
            this.BestFitDecreasingTime.AutoSize = true;
            this.BestFitDecreasingTime.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BestFitDecreasingTime.Location = new System.Drawing.Point(290, 338);
            this.BestFitDecreasingTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.BestFitDecreasingTime.Name = "BestFitDecreasingTime";
            this.BestFitDecreasingTime.Size = new System.Drawing.Size(29, 16);
            this.BestFitDecreasingTime.TabIndex = 23;
            this.BestFitDecreasingTime.Text = "000";
            // 
            // FolderFillingTime
            // 
            this.FolderFillingTime.AutoSize = true;
            this.FolderFillingTime.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FolderFillingTime.Location = new System.Drawing.Point(290, 375);
            this.FolderFillingTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.FolderFillingTime.Name = "FolderFillingTime";
            this.FolderFillingTime.Size = new System.Drawing.Size(29, 16);
            this.FolderFillingTime.TabIndex = 24;
            this.FolderFillingTime.Text = "000";
            // 
            // WorstFitLinearTime
            // 
            this.WorstFitLinearTime.AutoSize = true;
            this.WorstFitLinearTime.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WorstFitLinearTime.Location = new System.Drawing.Point(665, 266);
            this.WorstFitLinearTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.WorstFitLinearTime.Name = "WorstFitLinearTime";
            this.WorstFitLinearTime.Size = new System.Drawing.Size(29, 16);
            this.WorstFitLinearTime.TabIndex = 25;
            this.WorstFitLinearTime.Text = "000";
            // 
            // WorstFitDecTime
            // 
            this.WorstFitDecTime.AutoSize = true;
            this.WorstFitDecTime.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WorstFitDecTime.Location = new System.Drawing.Point(665, 304);
            this.WorstFitDecTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.WorstFitDecTime.Name = "WorstFitDecTime";
            this.WorstFitDecTime.Size = new System.Drawing.Size(29, 16);
            this.WorstFitDecTime.TabIndex = 26;
            this.WorstFitDecTime.Text = "000";
            // 
            // WorstFitPQTime
            // 
            this.WorstFitPQTime.AutoSize = true;
            this.WorstFitPQTime.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WorstFitPQTime.Location = new System.Drawing.Point(665, 338);
            this.WorstFitPQTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.WorstFitPQTime.Name = "WorstFitPQTime";
            this.WorstFitPQTime.Size = new System.Drawing.Size(29, 16);
            this.WorstFitPQTime.TabIndex = 27;
            this.WorstFitPQTime.Text = "000";
            this.WorstFitPQTime.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // WorstFitDecPQ
            // 
            this.WorstFitDecPQ.AutoSize = true;
            this.WorstFitDecPQ.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WorstFitDecPQ.Location = new System.Drawing.Point(665, 375);
            this.WorstFitDecPQ.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.WorstFitDecPQ.Name = "WorstFitDecPQ";
            this.WorstFitDecPQ.Size = new System.Drawing.Size(29, 16);
            this.WorstFitDecPQ.TabIndex = 28;
            this.WorstFitDecPQ.Text = "000";
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::SoundPacking_Final.Properties.Resources.box_cardboard_packing_handling_08_sound_effect_006144746_iconm;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(1, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(183, 78);
            this.panel1.TabIndex = 29;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 471);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.WorstFitDecPQ);
            this.Controls.Add(this.WorstFitPQTime);
            this.Controls.Add(this.WorstFitDecTime);
            this.Controls.Add(this.WorstFitLinearTime);
            this.Controls.Add(this.FolderFillingTime);
            this.Controls.Add(this.BestFitDecreasingTime);
            this.Controls.Add(this.BestFitTime);
            this.Controls.Add(this.FirstFitTime);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MaxTime);
            this.Controls.Add(this.MaximumTime);
            this.Controls.Add(this.Time);
            this.Controls.Add(this.ChooseType);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.Type);
            this.Controls.Add(this.Source);
            this.Controls.Add(this.SourceTxt);
            this.Controls.Add(this.SourceBrowse);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SourceBrowse;
        private System.Windows.Forms.FolderBrowserDialog Sourcee;
        private System.Windows.Forms.TextBox SourceTxt;
        private System.Windows.Forms.Label Source;
        private System.Windows.Forms.ComboBox Type;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Label ChooseType;
        private System.Windows.Forms.Label Time;
        private System.Windows.Forms.Label MaximumTime;
        private System.Windows.Forms.TextBox MaxTime;
        private System.Windows.Forms.FolderBrowserDialog Destinationn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label FirstFitTime;
        private System.Windows.Forms.Label BestFitTime;
        private System.Windows.Forms.Label BestFitDecreasingTime;
        private System.Windows.Forms.Label FolderFillingTime;
        private System.Windows.Forms.Label WorstFitLinearTime;
        private System.Windows.Forms.Label WorstFitDecTime;
        private System.Windows.Forms.Label WorstFitPQTime;
        private System.Windows.Forms.Label WorstFitDecPQ;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel1;
    }
}

