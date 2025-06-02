namespace WindowsMusic1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            listBox1 = new ListBox();
            openFileDialog1 = new OpenFileDialog();
            folderBrowserDialog1 = new FolderBrowserDialog();
            label1 = new Label();
            trackBar1 = new TrackBar();
            label2 = new Label();
            butten1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            panel1 = new Panel();
            volumeDownButton = new Button();
            volumeUpButton = new Button();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)axWindowsMediaPlayer1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // axWindowsMediaPlayer1
            // 
            axWindowsMediaPlayer1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            axWindowsMediaPlayer1.Enabled = true;
            axWindowsMediaPlayer1.Location = new Point(26, 471);
            axWindowsMediaPlayer1.Margin = new Padding(4);
            axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            axWindowsMediaPlayer1.OcxState = (AxHost.State)resources.GetObject("axWindowsMediaPlayer1.OcxState");
            axWindowsMediaPlayer1.Size = new Size(977, 45);
            axWindowsMediaPlayer1.TabIndex = 0;
            // 
            // listBox1
            // 
            listBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listBox1.BackColor = Color.White;
            listBox1.BorderStyle = BorderStyle.None;
            listBox1.Font = new Font("微软雅黑", 10F, FontStyle.Regular, GraphicsUnit.Point, 134);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 23;
            listBox1.Location = new Point(26, 82);
            listBox1.Margin = new Padding(4);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(1806, 759);
            listBox1.TabIndex = 1;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // folderBrowserDialog1
            // 
            folderBrowserDialog1.RootFolder = Environment.SpecialFolder.MyComputer;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("微软雅黑", 10F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label1.ForeColor = Color.FromArgb(64, 64, 64);
            label1.Location = new Point(26, 29);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(95, 23);
            label1.TabIndex = 3;
            label1.Text = "当前播放：";
            // 
            // trackBar1
            // 
            trackBar1.Anchor = AnchorStyles.Right;
            trackBar1.AutoSize = false;
            trackBar1.Location = new Point(1609, 15);
            trackBar1.Margin = new Padding(4);
            trackBar1.Maximum = 100;
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(150, 30);
            trackBar1.TabIndex = 4;
            trackBar1.TickStyle = TickStyle.None;
            trackBar1.Value = 50;
            trackBar1.Scroll += trackBar1_Scroll;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label2.ForeColor = Color.White;
            label2.Location = new Point(1769, 20);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(40, 20);
            label2.TabIndex = 5;
            label2.Text = "50%";
            // 
            // butten1
            // 
            butten1.BackColor = Color.Transparent;
            butten1.FlatAppearance.BorderSize = 0;
            butten1.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 45, 45);
            butten1.FlatStyle = FlatStyle.Flat;
            butten1.Font = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            butten1.ForeColor = Color.White;
            butten1.Location = new Point(26, 10);
            butten1.Margin = new Padding(4);
            butten1.Name = "butten1";
            butten1.Size = new Size(120, 40);
            butten1.TabIndex = 2;
            butten1.Text = "添加音乐";
            butten1.UseVisualStyleBackColor = false;
            butten1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 45, 45);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            button2.ForeColor = Color.White;
            button2.Location = new Point(546, 10);
            button2.Margin = new Padding(4);
            button2.Name = "button2";
            button2.Size = new Size(120, 40);
            button2.TabIndex = 6;
            button2.Text = "停止";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Transparent;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 45, 45);
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            button3.ForeColor = Color.White;
            button3.Location = new Point(416, 10);
            button3.Margin = new Padding(4);
            button3.Name = "button3";
            button3.Size = new Size(120, 40);
            button3.TabIndex = 7;
            button3.Text = "下一曲";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Transparent;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 45, 45);
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            button4.ForeColor = Color.White;
            button4.Location = new Point(676, 10);
            button4.Margin = new Padding(4);
            button4.Name = "button4";
            button4.Size = new Size(120, 40);
            button4.TabIndex = 8;
            button4.Text = "继续播放";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.Transparent;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 45, 45);
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            button5.ForeColor = Color.White;
            button5.Location = new Point(156, 10);
            button5.Size = new Size(120, 40);
            button5.Text = "添加文件夹";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.Transparent;
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 45, 45);
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            button6.ForeColor = Color.White;
            button6.Location = new Point(286, 10);
            button6.Size = new Size(120, 40);
            button6.Text = "上一曲";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // volumeDownButton
            // 
            volumeDownButton.BackColor = Color.Transparent;
            volumeDownButton.FlatAppearance.BorderSize = 0;
            volumeDownButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 45, 45);
            volumeDownButton.FlatStyle = FlatStyle.Flat;
            volumeDownButton.Font = new Font("Segoe MDL2 Assets", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            volumeDownButton.ForeColor = Color.White;
            volumeDownButton.Location = new Point(1569, 15);
            volumeDownButton.Size = new Size(32, 32);
            volumeDownButton.Text = "🔉";
            volumeDownButton.UseVisualStyleBackColor = false;
            volumeDownButton.Click += volumeDownButton_Click;
            // 
            // volumeUpButton
            // 
            volumeUpButton.BackColor = Color.Transparent;
            volumeUpButton.FlatAppearance.BorderSize = 0;
            volumeUpButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 45, 45);
            volumeUpButton.FlatStyle = FlatStyle.Flat;
            volumeUpButton.Font = new Font("Segoe MDL2 Assets", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            volumeUpButton.ForeColor = Color.White;
            volumeUpButton.Location = new Point(1729, 15);
            volumeUpButton.Size = new Size(32, 32);
            volumeUpButton.Text = "🔊";
            volumeUpButton.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(33, 33, 33);
            panel1.Controls.Add(volumeDownButton);
            panel1.Controls.Add(volumeUpButton);
            panel1.Controls.Add(button6);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(butten1);
            panel1.Controls.Add(trackBar1);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(20, 10, 20, 10);
            panel1.Size = new Size(1029, 60);
            panel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(listBox1);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 60);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(20, 10, 20, 10);
            panel2.Size = new Size(1029, 505);
            panel2.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1029, 565);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(axWindowsMediaPlayer1);
            Margin = new Padding(4);
            MinimumSize = new Size(1023, 556);
            Name = "Form1";
            Text = "音乐播放器";
            ((System.ComponentModel.ISupportInitialize)axWindowsMediaPlayer1).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private ListBox listBox1;
        private OpenFileDialog openFileDialog1;
        private FolderBrowserDialog folderBrowserDialog1;
        private Label label1;
        private TrackBar trackBar1;
        private Label label2;
        private Button butten1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button volumeDownButton;
        private Button volumeUpButton;
        private Panel panel1;
        private Panel panel2;
    }
}
