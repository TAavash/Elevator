namespace Elevator
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
            components = new System.ComponentModel.Container();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            button2 = new Button();
            closeBtn = new Button();
            openBtn = new Button();
            pictureBox2 = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            rightDoor_G = new PictureBox();
            leftDoor_G = new PictureBox();
            leftDoor_T = new PictureBox();
            rightDoor_T = new PictureBox();
            timer2 = new System.Windows.Forms.Timer(components);
            dataGridViewLogs = new DataGridView();
            ClearAll = new Button();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            callUp = new Button();
            callDown = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)rightDoor_G).BeginInit();
            ((System.ComponentModel.ISupportInitialize)leftDoor_G).BeginInit();
            ((System.ComponentModel.ISupportInitialize)leftDoor_T).BeginInit();
            ((System.ComponentModel.ISupportInitialize)rightDoor_T).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewLogs).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.Pika_Lift;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(63, 275);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(158, 175);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // button1
            // 
            button1.BackgroundImage = Properties.Resources.Screenshot_2024_10_18_074020;
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Location = new Point(319, 85);
            button1.Name = "button1";
            button1.Size = new Size(78, 66);
            button1.TabIndex = 1;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackgroundImage = Properties.Resources.Screenshot_2024_10_18_080230;
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.Location = new Point(319, 157);
            button2.Name = "button2";
            button2.Size = new Size(78, 64);
            button2.TabIndex = 2;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // closeBtn
            // 
            closeBtn.BackgroundImage = Properties.Resources.Screenshot_2024_10_18_074100;
            closeBtn.BackgroundImageLayout = ImageLayout.Stretch;
            closeBtn.Location = new Point(270, 237);
            closeBtn.Name = "closeBtn";
            closeBtn.Size = new Size(75, 69);
            closeBtn.TabIndex = 3;
            closeBtn.UseVisualStyleBackColor = true;
            closeBtn.Click += button3_Click;
            // 
            // openBtn
            // 
            openBtn.BackgroundImage = Properties.Resources.Screenshot_2024_10_18_074114;
            openBtn.BackgroundImageLayout = ImageLayout.Stretch;
            openBtn.Location = new Point(367, 237);
            openBtn.Name = "openBtn";
            openBtn.Size = new Size(79, 69);
            openBtn.TabIndex = 4;
            openBtn.UseVisualStyleBackColor = true;
            openBtn.Click += button4_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = Properties.Resources.neon;
            pictureBox2.Location = new Point(261, 48);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(195, 362);
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // timer1
            // 
            timer1.Interval = 10;
            timer1.Tick += timer1_Tick;
            // 
            // rightDoor_G
            // 
            rightDoor_G.BackgroundImage = Properties.Resources.liftpp;
            rightDoor_G.Location = new Point(138, 275);
            rightDoor_G.Name = "rightDoor_G";
            rightDoor_G.Size = new Size(83, 175);
            rightDoor_G.TabIndex = 6;
            rightDoor_G.TabStop = false;
            rightDoor_G.Click += pictureBox3_Click;
            // 
            // leftDoor_G
            // 
            leftDoor_G.BackgroundImage = Properties.Resources.leftdoor;
            leftDoor_G.Location = new Point(63, 275);
            leftDoor_G.Name = "leftDoor_G";
            leftDoor_G.Size = new Size(76, 175);
            leftDoor_G.TabIndex = 7;
            leftDoor_G.TabStop = false;
            leftDoor_G.Click += pictureBox4_Click;
            // 
            // leftDoor_T
            // 
            leftDoor_T.BackgroundImage = Properties.Resources.leftdoor;
            leftDoor_T.Location = new Point(63, 0);
            leftDoor_T.Name = "leftDoor_T";
            leftDoor_T.Size = new Size(76, 175);
            leftDoor_T.TabIndex = 8;
            leftDoor_T.TabStop = false;
            leftDoor_T.Click += pictureBox5_Click;
            // 
            // rightDoor_T
            // 
            rightDoor_T.BackgroundImage = Properties.Resources.liftpp;
            rightDoor_T.Location = new Point(138, 0);
            rightDoor_T.Name = "rightDoor_T";
            rightDoor_T.Size = new Size(83, 175);
            rightDoor_T.TabIndex = 9;
            rightDoor_T.TabStop = false;
            rightDoor_T.Click += pictureBox6_Click;
            // 
            // timer2
            // 
            timer2.Tick += timer2_Tick;
            // 
            // dataGridViewLogs
            // 
            dataGridViewLogs.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewLogs.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewLogs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewLogs.Location = new Point(482, 0);
            dataGridViewLogs.Name = "dataGridViewLogs";
            dataGridViewLogs.RowHeadersWidth = 51;
            dataGridViewLogs.Size = new Size(318, 450);
            dataGridViewLogs.TabIndex = 10;
            dataGridViewLogs.CellContentClick += dataGridViewLogs_CellContentClick;
            // 
            // ClearAll
            // 
            ClearAll.BackgroundImage = Properties.Resources.sharingan;
            ClearAll.BackgroundImageLayout = ImageLayout.Stretch;
            ClearAll.ForeColor = SystemColors.ButtonHighlight;
            ClearAll.Location = new Point(319, 312);
            ClearAll.Name = "ClearAll";
            ClearAll.Size = new Size(78, 78);
            ClearAll.TabIndex = 11;
            ClearAll.Text = "Shut Down";
            ClearAll.UseVisualStyleBackColor = true;
            ClearAll.Click += ClearAll_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = Properties.Resources.wall;
            pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox3.Location = new Point(-2, 0);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(487, 221);
            pictureBox3.TabIndex = 12;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click_1;
            // 
            // pictureBox4
            // 
            pictureBox4.BackgroundImage = Properties.Resources.wall;
            pictureBox4.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox4.Location = new Point(-2, 218);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(487, 232);
            pictureBox4.TabIndex = 13;
            pictureBox4.TabStop = false;
            // 
            // callUp
            // 
            callUp.BackgroundImage = Properties.Resources.Screenshot_2024_10_29_100926;
            callUp.BackgroundImageLayout = ImageLayout.Stretch;
            callUp.Location = new Point(12, 85);
            callUp.Name = "callUp";
            callUp.Size = new Size(37, 31);
            callUp.TabIndex = 14;
            callUp.UseVisualStyleBackColor = true;
            callUp.Click += callUp_Click;
            // 
            // callDown
            // 
            callDown.BackgroundImage = Properties.Resources.Screenshot_2024_10_29_100916;
            callDown.BackgroundImageLayout = ImageLayout.Stretch;
            callDown.Location = new Point(12, 344);
            callDown.Name = "callDown";
            callDown.Size = new Size(37, 34);
            callDown.TabIndex = 15;
            callDown.UseVisualStyleBackColor = true;
            callDown.Click += callDown_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(callDown);
            Controls.Add(callUp);
            Controls.Add(ClearAll);
            Controls.Add(dataGridViewLogs);
            Controls.Add(rightDoor_T);
            Controls.Add(leftDoor_T);
            Controls.Add(rightDoor_G);
            Controls.Add(leftDoor_G);
            Controls.Add(openBtn);
            Controls.Add(closeBtn);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)rightDoor_G).EndInit();
            ((System.ComponentModel.ISupportInitialize)leftDoor_G).EndInit();
            ((System.ComponentModel.ISupportInitialize)leftDoor_T).EndInit();
            ((System.ComponentModel.ISupportInitialize)rightDoor_T).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewLogs).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Button button1;
        private Button button2;
        private Button closeBtn;
        private Button openBtn;
        private PictureBox pictureBox2;
        private System.Windows.Forms.Timer timer1;
        private PictureBox rightDoor_G;
        private PictureBox leftDoor_G;
        private PictureBox leftDoor_T;
        private PictureBox rightDoor_T;
        private System.Windows.Forms.Timer timer2;
        private DataGridView dataGridViewLogs;
        private Button ClearAll;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private Button callUp;
        private Button callDown;
    }
}
