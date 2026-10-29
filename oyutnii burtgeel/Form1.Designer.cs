namespace oyutnii_burtgeel
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
            textBox1 = new TextBox();
            checkBox1 = new CheckBox();
            radioButton1 = new RadioButton();
            checkedListBox1 = new CheckedListBox();
            numericUpDown1 = new NumericUpDown();
            comboBox1 = new ComboBox();
            maskedTextBox1 = new MaskedTextBox();
            dateTimePicker1 = new DateTimePicker();
            button1 = new Button();
            labelNiit = new Label();
            linkLabel1 = new LinkLabel();
            listBox1 = new ListBox();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            listView1 = new ListView();
            treeView1 = new TreeView();
            richTextBox1 = new RichTextBox();
            label3 = new Label();
            progressBar1 = new ProgressBar();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(10, 8);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 0;
            textBox1.Text = "M.SW23D060";
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(12, 51);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(91, 19);
            checkBox1.TabIndex = 1;
            checkBox1.Text = "Тэтгэлэгтэй";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(12, 76);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(113, 19);
            radioButton1.TabIndex = 2;
            radioButton1.TabStop = true;
            radioButton1.Text = "Өдрийн сургалт";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Items.AddRange(new object[] { "Программчлал", "Өгөгдлийн бүтэц", "Алгоритм", "Өгөгдлийн сан", "Сүлжээ" });
            checkedListBox1.Location = new Point(12, 127);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(120, 94);
            checkedListBox1.TabIndex = 3;
            checkedListBox1.SelectedIndexChanged += checkedListBox1_SelectedIndexChanged;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(12, 238);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 23);
            numericUpDown1.TabIndex = 4;
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "--Тэнхим сонгох" });
            comboBox1.Location = new Point(12, 279);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 5;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(12, 320);
            maskedTextBox1.Mask = "00000000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(100, 23);
            maskedTextBox1.TabIndex = 6;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(10, 362);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(123, 23);
            dateTimePicker1.TabIndex = 7;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // button1
            // 
            button1.Location = new Point(19, 406);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 8;
            button1.Text = "Бүртгэх";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // labelNiit
            // 
            labelNiit.AutoSize = true;
            labelNiit.Location = new Point(178, 16);
            labelNiit.Name = "labelNiit";
            labelNiit.Size = new Size(44, 15);
            labelNiit.TabIndex = 9;
            labelNiit.Text = "Нийт:0";
            labelNiit.Click += label1_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(305, 16);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(59, 15);
            linkLabel1.TabIndex = 10;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Цэвэрлэх";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Items.AddRange(new object[] { "Монгол", "Англи", "Орос", "Хятад", "Япон", "Солонгос" });
            listBox1.Location = new Point(178, 61);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(120, 94);
            listBox1.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(178, 206);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 12;
            label2.Text = "Цээж зураг";
            label2.Click += label2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.images;
            pictureBox1.Location = new Point(160, 238);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(161, 163);
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // listView1
            // 
            listView1.Location = new Point(328, 58);
            listView1.Name = "listView1";
            listView1.Size = new Size(164, 152);
            listView1.TabIndex = 14;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // treeView1
            // 
            treeView1.Location = new Point(342, 238);
            treeView1.Name = "treeView1";
            treeView1.Size = new Size(150, 163);
            treeView1.TabIndex = 15;
            treeView1.AfterSelect += treeView1_AfterSelect;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(160, 458);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(308, 96);
            richTextBox1.TabIndex = 16;
            richTextBox1.Text = "";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 550);
            label3.Name = "label3";
            label3.Size = new Size(93, 15);
            label3.TabIndex = 18;
            label3.Text = "Бүртгэлийн явц";
            label3.Click += label3_Click;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(19, 577);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(447, 23);
            progressBar1.TabIndex = 19;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(504, 612);
            Controls.Add(progressBar1);
            Controls.Add(label3);
            Controls.Add(richTextBox1);
            Controls.Add(treeView1);
            Controls.Add(listView1);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(listBox1);
            Controls.Add(linkLabel1);
            Controls.Add(labelNiit);
            Controls.Add(button1);
            Controls.Add(dateTimePicker1);
            Controls.Add(maskedTextBox1);
            Controls.Add(comboBox1);
            Controls.Add(numericUpDown1);
            Controls.Add(checkedListBox1);
            Controls.Add(radioButton1);
            Controls.Add(checkBox1);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Оюутны бүртгэлийн программ";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private CheckBox checkBox1;
        private RadioButton radioButton1;
        private CheckedListBox checkedListBox1;
        private NumericUpDown numericUpDown1;
        private ComboBox comboBox1;
        private MaskedTextBox maskedTextBox1;
        private DateTimePicker dateTimePicker1;
        private Button button1;
        private Label labelNiit;
        private LinkLabel linkLabel1;
        private ListBox listBox1;
        private Label label2;
        private PictureBox pictureBox1;
        private ListView listView1;
        private TreeView treeView1;
        private RichTextBox richTextBox1;
        private Label label3;
        private ProgressBar progressBar1;
    }
}
