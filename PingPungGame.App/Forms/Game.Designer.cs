namespace PingPungGame.App
{
    partial class Game
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.txtRacket = new System.Windows.Forms.TextBox();
            this.picBall = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.s1 = new System.Windows.Forms.Splitter();
            this.s2 = new System.Windows.Forms.Splitter();
            this.s3 = new System.Windows.Forms.Splitter();
            this.chartLocation = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnStart = new PingPungGame.App.NewButton();
            ((System.ComponentModel.ISupportInitialize)(this.picBall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartLocation)).BeginInit();
            this.SuspendLayout();
            // 
            // txtRacket
            // 
            this.txtRacket.BackColor = System.Drawing.Color.DarkRed;
            this.txtRacket.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRacket.Cursor = System.Windows.Forms.Cursors.Cross;
            this.txtRacket.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRacket.ForeColor = System.Drawing.Color.DarkRed;
            this.txtRacket.HideSelection = false;
            this.txtRacket.Location = new System.Drawing.Point(299, 445);
            this.txtRacket.Name = "txtRacket";
            this.txtRacket.ReadOnly = true;
            this.txtRacket.Size = new System.Drawing.Size(254, 32);
            this.txtRacket.TabIndex = 0;
            this.txtRacket.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtRacket_MouseDown);
            this.txtRacket.MouseMove += new System.Windows.Forms.MouseEventHandler(this.txtRacket_MouseMove);
            this.txtRacket.MouseUp += new System.Windows.Forms.MouseEventHandler(this.txtRacket_MouseUp);
            // 
            // picBall
            // 
            this.picBall.BackColor = System.Drawing.Color.White;
            this.picBall.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picBall.Image = ((System.Drawing.Image)(resources.GetObject("picBall.Image")));
            this.picBall.Location = new System.Drawing.Point(386, 404);
            this.picBall.Name = "picBall";
            this.picBall.Size = new System.Drawing.Size(45, 45);
            this.picBall.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBall.TabIndex = 1;
            this.picBall.TabStop = false;
            this.picBall.Click += new System.EventHandler(this.picBall_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 2;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // s1
            // 
            this.s1.Location = new System.Drawing.Point(0, 0);
            this.s1.Name = "s1";
            this.s1.Size = new System.Drawing.Size(10, 733);
            this.s1.TabIndex = 2;
            this.s1.TabStop = false;
            // 
            // s2
            // 
            this.s2.Dock = System.Windows.Forms.DockStyle.Top;
            this.s2.Location = new System.Drawing.Point(10, 0);
            this.s2.Name = "s2";
            this.s2.Size = new System.Drawing.Size(826, 10);
            this.s2.TabIndex = 3;
            this.s2.TabStop = false;
            // 
            // s3
            // 
            this.s3.Dock = System.Windows.Forms.DockStyle.Right;
            this.s3.Location = new System.Drawing.Point(826, 10);
            this.s3.Name = "s3";
            this.s3.Size = new System.Drawing.Size(10, 723);
            this.s3.TabIndex = 4;
            this.s3.TabStop = false;
            // 
            // chartLocation
            // 
            this.chartLocation.BackColor = System.Drawing.Color.Transparent;
            this.chartLocation.BorderlineColor = System.Drawing.Color.Red;
            chartArea1.BackSecondaryColor = System.Drawing.Color.Black;
            chartArea1.BorderColor = System.Drawing.Color.BlanchedAlmond;
            chartArea1.Name = "ChartArea1";
            this.chartLocation.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartLocation.Legends.Add(legend1);
            this.chartLocation.Location = new System.Drawing.Point(16, 504);
            this.chartLocation.Name = "chartLocation";
            series1.BackHatchStyle = System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle.Cross;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series1.Legend = "Legend1";
            series1.Name = "Location";
            this.chartLocation.Series.Add(series1);
            this.chartLocation.Size = new System.Drawing.Size(364, 217);
            this.chartLocation.TabIndex = 6;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(386, 504);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(225, 217);
            this.textBox1.TabIndex = 8;
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Cyan;
            this.btnStart.FlatAppearance.BorderSize = 0;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("Consolas", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.Color.Red;
            this.btnStart.Location = new System.Drawing.Point(16, 12);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(804, 153);
            this.btnStart.TabIndex = 5;
            this.btnStart.Text = "Start Game";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(836, 733);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.chartLocation);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.s3);
            this.Controls.Add(this.s2);
            this.Controls.Add(this.s1);
            this.Controls.Add(this.picBall);
            this.Controls.Add(this.txtRacket);
            this.Cursor = System.Windows.Forms.Cursors.Cross;
            this.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Game";
            this.Text = "PingPungGame";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartLocation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRacket;
        private System.Windows.Forms.PictureBox picBall;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Splitter s1;
        private System.Windows.Forms.Splitter s2;
        private System.Windows.Forms.Splitter s3;
        private NewButton btnStart;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartLocation;
        private System.Windows.Forms.TextBox textBox1;
    }
}

