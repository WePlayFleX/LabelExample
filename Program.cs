using System;
using System.Drawing;
using System.Windows.Forms;

namespace LabelExample
{
    public class Program
    {
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }

    public enum Sex
    {
        MALE, FEMALE
    }

    public class MainForm : Form
    {
        private Button anotherButton;
        public MainForm()
        {
            Text = "Label Example";
            ClientSize = new Size(800, 600);

            //Label label = new Label();
            //label.Parent = this;                //или ---->Controls.Add(label);
            //label.BackColor = Color.Yellow;
            //label.AutoSize = true;
            //label.Size = new Size(780, 580);
            //label.Text = "Simple Text";
            ////label.Image = Image.FromFile("..\\..\\Tux.png");
            //label.Location = new Point(10, 10);
            //label.Font = new Font("Arial", 48);
            ////label.Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right| AnchorStyles.Bottom;

            //    TextBox textBox = new TextBox
            //    {
            //        Parent = this,
            //        Location = new Point(10, 10),
            //        Size = new Size(780,580),
            //        Anchor = AnchorStyles.Left | AnchorStyles.Top |
            //        AnchorStyles.Right | AnchorStyles.Bottom,
            //        Multiline = true,
            //        AcceptsReturn = true,
            //        WordWrap = true,
            //    };

            //    textBox.KeyDown += TextBox_KeyDown;
            //    textBox.KeyPress += TextBox_KeyPress;
            //    textBox.TextChanged += TextBox_TextChanged;
            //}

            //private void TextBox_TextChanged(object sender, EventArgs e)
            //{

            //}

            //private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
            //{
            //    if (isLetterPressed)
            //    {
            //        e.Handled = true;
            //        isLetterPressed = false;
            //    }
            //}

            //private bool isLetterPressed = false;

            //private void TextBox_KeyDown(object sender, KeyEventArgs e)
            //{
            //    if (e.KeyCode < Keys.D0 || e.KeyCode > Keys.D9)
            //    {
            //        isLetterPressed = true;
            //        e.Handled = true;
            //        return;
            //    }

            //Button button = new Button

            //{
            //    Parent = this,
            //    Location = new Point(10, 10),
            //    Size = new Size(100, 50),
            //    Text = "Push me!"
            //};

            //button.Click += Button_Click;


            //anotherButton = new Button

            //{
            //    Parent = this,
            //    Location = new Point(10 + button.Width + 10, 10),
            //    Size = new Size(100, 50),
            //    Text = "Cancel!",
            //    Enabled = false
            //};

            //anotherButton.Click += AnotherButton_Click;


            //CheckBox checkBox = new CheckBox

            //{
            //    Parent = this,
            //    Location = new Point(10, 10 + button.Width + 10),
            //    Size = new Size(200, 50),
            //    Text = "Is Cancel Button Enabled"
            //};

            //checkBox.CheckedChanged += CheckBox_CheckedChanged;
            //checkBox.CheckStateChanged += CheckBox_CheckStateChanged;


            //RadioButton radioButton1 = new RadioButton
            //{
            //    Parent = this,
            //    Location = new Point(10, checkBox.Bottom + 10),
            //    Text = "Male",
            //    Tag = Sex.MALE
            //};

            //radioButton1.CheckedChanged += RadioButton_CheckedChanged;


            //RadioButton radioButton2 = new RadioButton
            //{
            //    Parent = this,
            //    Location = new Point(10, radioButton1.Bottom + 10),
            //    Text = "Female",
            //    Tag = Sex.FEMALE
            //};

            //radioButton2.CheckedChanged += RadioButton_CheckedChanged;

            //CustomButton customButton = new CustomButton
            //{
            //    Parent = this,
            //    Location = new Point(10, radioButton2.Bottom + 10)
            //};

            //    DateTimePicker dateTimePicker = new DateTimePicker
            //    {
            //        Parent = this,
            //        Location = new Point(10, 10),
            //        Format = DateTimePickerFormat.Time,
            //        ShowCheckBox = true,
            //        ShowUpDown = true
            //    };

            //    dateTimePicker.ValueChanged += DateTimePicker_ValueChanged;
            //}

            //private void DateTimePicker_ValueChanged(object sender, EventArgs e)
            //{
            //    var picker = (DateTimePicker)sender;
            //    MessageBox.Show(picker.Value.ToLongDateString());


            //    MonthCalendar calendar = new MonthCalendar
            //    {
            //        Parent = this,
            //        Location = new Point(10, 10),
            //        ShowToday = true,
            //        ShowTodayCircle = true,
            //        ShowWeekNumbers = true
            //    };

            TextBox textBox1 = new TextBox
            {
                Parent = this,
                Location = new Point(10, 10),
                Size = new Size(50, 20),
                Anchor = AnchorStyles.Left | AnchorStyles.Top |
                    AnchorStyles.Right | AnchorStyles.Bottom,
                Multiline = true,
                AcceptsReturn = true,
                WordWrap = true,
            };

            textBox1.KeyDown += TextBox_KeyDown;
            textBox1.KeyPress += TextBox_KeyPress;
            textBox1.TextChanged += TextBox_TextChanged;



            TextBox textBox2 = new TextBox
            {
                Parent = this,
                Location = new Point(10 + textBox1.Right + 10, 10),
                Size = new Size(50, 20),
                Anchor = AnchorStyles.Left | AnchorStyles.Top |
                    AnchorStyles.Right | AnchorStyles.Bottom,
                Multiline = true,
                AcceptsReturn = true,
                WordWrap = true,
            };

            textBox2.KeyDown += TextBox_KeyDown;
            textBox2.KeyPress += TextBox_KeyPress;
            textBox2.TextChanged += TextBox_TextChanged;


            TextBox textBox3 = new TextBox
            {
                Parent = this,
                Location = new Point(10, 50 + textBox1.Bottom + 10 ),
                Size = new Size(100, 20),
                Anchor = AnchorStyles.Left | AnchorStyles.Top |
                    AnchorStyles.Right | AnchorStyles.Bottom,
                Multiline = true,
                AcceptsReturn = true,
                WordWrap = true,
            };

            textBox3.KeyDown += TextBox_KeyDown;
            textBox3.KeyPress += TextBox_KeyPress;
            textBox3.TextChanged += TextBox_TextChanged;


            Button button1 = new Button

            {
                Parent = this,
                Location = new Point(10, 50),
                Size = new Size(20, 20),
                Text = "+"
            };

            Button button2 = new Button

            {
                Parent = this,
                Location = new Point(40, 50),
                Size = new Size(20, 20),
                Text = "-"
            };

            Button button3 = new Button

            {
                Parent = this,
                Location = new Point(70, 50),
                Size = new Size(20, 20),
                Text = "*"
            };

            Button button4 = new Button

            {
                Parent = this,
                Location = new Point(100, 50),
                Size = new Size(20, 20),
                Text = "/"
            };

            button1.Click += Button_Click1;
            button2.Click += Button_Click2;
            button3.Click += Button_Click3;
            button4.Click += Button_Click4;
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (isLetterPressed)
            {
                e.Handled = true;
                isLetterPressed = false;
            }
        }

        private bool isLetterPressed = false;

        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode < Keys.D0 || e.KeyCode > Keys.D9)
            {
                isLetterPressed = true;
                e.Handled = true;
                return;
            }
        }

        private void Button_Click1(object sender, EventArgs e)
        {
            MessageBox.Show("Сложение");
        }

        private void Button_Click2(object sender, EventArgs e)
        {
            MessageBox.Show("Вычетание");
        }

        private void Button_Click3(object sender, EventArgs e)
        {
            MessageBox.Show("Умножение");
        }

        private void Button_Click4(object sender, EventArgs e)
        {
            MessageBox.Show("Деление");
        }


        //    private void RadioButton_CheckedChanged(object sender, EventArgs e)
        //    {
        //        var radioButton = (RadioButton)sender;
        //        if (radioButton.Checked)
        //        {
        //            MessageBox.Show(radioButton.Tag.ToString());
        //        }
        //    }


        //    private void CheckBox_CheckStateChanged(object sender, EventArgs e)
        //    {
        //        var checkBox = sender as CheckBox;
        //        var checkState = checkBox.CheckState;
        //    }


        //    private void CheckBox_CheckedChanged(object sender, EventArgs e)
        //    {
        //        var checkBox = sender as CheckBox;
        //        anotherButton.Enabled = checkBox.Checked;
        //    }


        //    private void AnotherButton_Click(object sender, EventArgs e)
        //    {
        //        Application.Exit();
        //    }


        //    private void Button_Click(object sender, EventArgs e)
        //    {
        //        MessageBox.Show("Button was presed!");
        //    }
        //}

        //public class CustomButton : Button
        //{
        //    public CustomButton()
        //    {
        //        Text = "Custom Button!";
        //        Size = new Size(200, 100);
        //    }

        //    protected override void OnClick(EventArgs e)
        //    {
        //        base.OnClick(e);

        //        MessageBox.Show("CustomButton was be pressed!");
        //    }
    }

}
