using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace oyutnii_burtgeel
{
    public partial class Form1 : Form
    {
        private static readonly Color Navy = Color.FromArgb(0, 0, 128);
        private static readonly Color Green = Color.FromArgb(34, 125, 34);

        // Designer-т нэмэх шаардлагагүй, кодоор үүсгэнэ
        private readonly NotifyIcon notifyIconMain = new NotifyIcon();
        private readonly ToolTip toolTipMain = new ToolTip();

        public Form1()
        {
            InitializeComponent();
            WireEvents();
        }

        // Designer-т холбогдоогүй үзэгдлүүдийг кодоор холбоно.
        // "-=" дараа нь "+=" бичсэн тул давхар ажиллахгүй.
        private void WireEvents()
        {
            Load -= Form1_Load;
            Load += Form1_Load;

            FormClosing -= Form1_FormClosing;
            FormClosing += Form1_FormClosing;

            maskedTextBox1.TextChanged -= Input_Changed;
            maskedTextBox1.TextChanged += Input_Changed;

            maskedTextBox1.MaskInputRejected -= maskedTextBox1_MaskInputRejected;
            maskedTextBox1.MaskInputRejected += maskedTextBox1_MaskInputRejected;

            checkedListBox1.ItemCheck -= checkedListBox1_ItemCheck;
            checkedListBox1.ItemCheck += checkedListBox1_ItemCheck;

            pictureBox1.Click -= pictureBox1_Click;
            pictureBox1.Click += pictureBox1_Click;

            listView1.SelectedIndexChanged -= listView1_SelectedIndexChanged;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;

            linkLabel1.LinkClicked -= linkLabel1_LinkClicked;
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
        }

        // ================= Форм =================
        private void Form1_Load(object sender, EventArgs e)
        {
            Text = "Оюутны бүртгэлийн программ";

            checkBox1.Text = "Тэтгэлэгтэй";
            radioButton1.Text = "Өдрийн сургалт";
            checkedListBox1.CheckOnClick = true;
            listBox1.SelectionMode = SelectionMode.MultiSimple;

            // Minimum, Maximum-ыг эхэлж тавина
            numericUpDown1.Minimum = 16;
            numericUpDown1.Maximum = 60;
            numericUpDown1.Value = 18;

            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Items.Clear();
            comboBox1.Items.AddRange(new object[] {
                "-- Тэнхим сонгох --",
                "Компьютерын ухаан",
                "Мэдээллийн технологи",
                "Программ хангамж",
                "Математик",
                "Физик" });
            comboBox1.SelectedIndex = 0;

            maskedTextBox1.Mask = "0000-0000";
            dateTimePicker1.Format = DateTimePickerFormat.Short;

            button1.Text = "Бүртгэх";
            button1.FlatStyle = FlatStyle.Flat;
            button1.FlatAppearance.BorderColor = Color.DodgerBlue;
            button1.BackColor = Color.White;
            button1.ForeColor = Color.Blue;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button1.Size = new Size(150, 45);

            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Size = new Size(150, 170);
            toolTipMain.SetToolTip(pictureBox1, "Зураг сонгохын тулд дарна уу");

            listView1.View = View.Details;
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.MultiSelect = false;
            listView1.Columns.Clear();
            listView1.Columns.Add("Код", 100);
            listView1.Columns.Add("Утас", 80);
            listView1.Columns.Add("Нас", 40);

            treeView1.Nodes.Clear();
            TreeNode s1 = treeView1.Nodes.Add("Мэдээлэл, холбооны сургууль");
            s1.Nodes.Add("Компьютерын ухаан");
            s1.Nodes.Add("Мэдээллийн технологи");
            s1.Nodes.Add("Программ хангамж");
            TreeNode s2 = treeView1.Nodes.Add("Байгалийн ухааны сургууль");
            s2.Nodes.Add("Математик");
            s2.Nodes.Add("Физик");
            treeView1.ExpandAll();

            richTextBox1.ReadOnly = true;
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;

            notifyIconMain.Icon = SystemIcons.Information;
            notifyIconMain.Text = "Бүртгэл";

            labelNiit.Text = "Нийт: 0";
            ResetRichText();
            UpdateProgress();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            notifyIconMain.Visible = false;
            notifyIconMain.Dispose();
        }

        // ================= Designer-т холбогдсон функцүүд =================
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            UpdateProgress();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateProgress();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            int age = DateTime.Today.Year - dateTimePicker1.Value.Year;
            if (dateTimePicker1.Value.Date > DateTime.Today.AddYears(-age)) age--;
            if (age >= numericUpDown1.Minimum && age <= numericUpDown1.Maximum)
                numericUpDown1.Value = age;
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            int idx = comboBox1.Items.IndexOf(e.Node.Text);
            if (idx > 0) comboBox1.SelectedIndex = idx;
        }

        // Эдгээр нь Designer-т холбогдсон тул устгаж болохгүй (хоосон үлдээнэ)
        private void checkBox1_CheckedChanged(object sender, EventArgs e) { }
        private void radioButton1_CheckedChanged(object sender, EventArgs e) { }
        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e) { }
        private void numericUpDown1_ValueChanged(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }

        // ================= Кодоор холбосон функцүүд =================
        private void Input_Changed(object sender, EventArgs e)
        {
            UpdateProgress();
        }

        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            // ItemCheck нь өөрчлөлтийн ӨМНӨ ажилладаг тул хойшлуулна
            BeginInvoke(new Action(UpdateProgress));
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            toolTipMain.Show("Зөвхөн тоо оруулна уу", maskedTextBox1, 0, maskedTextBox1.Height, 1500);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Зураг|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.Image?.Dispose();
                    using (Image tmp = Image.FromFile(ofd.FileName))
                    {
                        pictureBox1.Image = new Bitmap(tmp);
                    }
                    toolTipMain.SetToolTip(pictureBox1, Path.GetFileName(ofd.FileName));
                    UpdateProgress();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                Warn("Оюутны кодоо оруулна уу.");
                textBox1.Focus();
                return;
            }
            if (!maskedTextBox1.MaskCompleted)
            {
                Warn("Утасны дугаараа бүрэн оруулна уу.");
                maskedTextBox1.Focus();
                return;
            }
            if (comboBox1.SelectedIndex <= 0)
            {
                Warn("Тэнхимээ сонгоно уу.");
                comboBox1.Focus();
                return;
            }
            foreach (ListViewItem item in listView1.Items)
            {
                if (item.Text == textBox1.Text.Trim())
                {
                    Warn("Энэ кодтой оюутан бүртгэгдсэн байна.");
                    textBox1.Focus();
                    return;
                }
            }

            Student s = new Student
            {
                Code = textBox1.Text.Trim(),
                Phone = maskedTextBox1.Text,
                Age = (int)numericUpDown1.Value,
                BirthDate = dateTimePicker1.Value.Date,
                Study = radioButton1.Checked ? "Өдрийн" : "Сонгоогүй",
                Department = comboBox1.Text,
                Scholarship = checkBox1.Checked,
                Photo = pictureBox1.Image != null ? new Bitmap(pictureBox1.Image) : null
            };
            foreach (var item in checkedListBox1.CheckedItems)
                s.Subjects.Add(item.ToString()!);
            foreach (var item in listBox1.SelectedItems)
                s.Languages.Add(item.ToString()!);

            ShowInRichText(s);

            ListViewItem lvi = new ListViewItem(s.Code);
            lvi.SubItems.Add(s.Phone);
            lvi.SubItems.Add(s.Age.ToString());
            lvi.Tag = s;
            listView1.Items.Add(lvi);

            labelNiit.Text = "Нийт: " + listView1.Items.Count;

            notifyIconMain.Visible = true;
            notifyIconMain.ShowBalloonTip(2000, "Бүртгэл", s.Code + " амжилттай бүртгэгдлээ", ToolTipIcon.Info);
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 1 &&
                listView1.SelectedItems[0].Tag is Student s)
            {
                ShowInRichText(s);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            textBox1.Clear();
            maskedTextBox1.Clear();
            comboBox1.SelectedIndex = 0;
            checkBox1.Checked = false;
            radioButton1.Checked = false;
            numericUpDown1.Value = 18;
            dateTimePicker1.Value = DateTime.Today;
            listBox1.ClearSelected();
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
                checkedListBox1.SetItemChecked(i, false);
            pictureBox1.Image?.Dispose();
            pictureBox1.Image = null;
            toolTipMain.SetToolTip(pictureBox1, "Зураг сонгохын тулд дарна уу");
            ResetRichText();
            UpdateProgress();
        }

        // ================= Туслах функцүүд =================
        private void UpdateProgress()
        {
            int done = 0;
            if (!string.IsNullOrWhiteSpace(textBox1.Text)) done++;
            if (maskedTextBox1.MaskCompleted) done++;
            if (comboBox1.SelectedIndex > 0) done++;
            if (checkedListBox1.CheckedItems.Count > 0) done++;
            if (pictureBox1.Image != null) done++;
            progressBar1.Value = done * 100 / 5;
        }

        private void ResetRichText()
        {
            richTextBox1.Clear();
            richTextBox1.SelectionColor = Color.Gray;
            richTextBox1.AppendText("Бүртгэлийн мэдээлэл энд харагдана...");
        }

        private void AddText(string text, Color color, bool bold = false, float size = 10F)
        {
            richTextBox1.SelectionStart = richTextBox1.TextLength;
            richTextBox1.SelectionLength = 0;
            richTextBox1.SelectionColor = color;
            richTextBox1.SelectionFont = new Font("Segoe UI", size, bold ? FontStyle.Bold : FontStyle.Regular);
            richTextBox1.AppendText(text);
        }

        private void AddRow(string label, string value)
        {
            AddText(label + ": ", Color.Black, true);
            AddText(value + "\n", Green);
        }

        private void ShowInRichText(Student s)
        {
            richTextBox1.Clear();
            AddText("ОЮУТНЫ БҮРТГЭЛ\n", Navy, true, 14F);
            AddText("─────────────────────\n", Color.Gray);
            AddRow("Код", s.Code);
            AddRow("Утас", s.Phone);
            AddRow("Нас", s.Age.ToString());
            AddRow("Төрсөн өдөр", s.BirthDate.ToString("yyyy-MM-dd"));
            AddRow("Сургалт", s.Study);
            AddRow("Тэнхим", s.Department);
            AddRow("Тэтгэлэг", s.Scholarship ? "Тийм" : "Үгүй");
            AddRow("Хичээл", string.Join(", ", s.Subjects));
            AddRow("Хэл", string.Join(", ", s.Languages));
        }

        private void Warn(string msg)
        {
            MessageBox.Show(msg, "Анхааруулга", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }

    // Student класс энэ файл дотор байгаа тул тусад нь Student.cs үүсгэх шаардлагагүй
    public class Student
    {
        public string Code { get; set; } = "";
        public string Phone { get; set; } = "";
        public int Age { get; set; }
        public DateTime BirthDate { get; set; }
        public string Study { get; set; } = "";
        public string Department { get; set; } = "";
        public bool Scholarship { get; set; }
        public System.Collections.Generic.List<string> Subjects { get; set; } = new System.Collections.Generic.List<string>();
        public System.Collections.Generic.List<string> Languages { get; set; } = new System.Collections.Generic.List<string>();
        public Image? Photo { get; set; }
    }
}