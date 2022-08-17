using System;
using System.Windows.Forms;

namespace Dori37_RecursionFunction
{
    public enum ControlType
    {
        Unknown,
        Label,
        Textbox,
        Button,

    }
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txb_control_Click(object sender, EventArgs e)
        {
            int level = (int)this.numericUpDown1.Value;
            ControlType type = ControlType.Unknown;
            string strText = this.textBox1.Text;

            if (this.rdbtn_label.Checked)
            {
                type = ControlType.Label;
            }
            else if (this.rdbtn_textBox.Checked)
            {
                type = ControlType.Textbox;
            }
            else if (this.rdbtn_button.Checked)
            {
                type = ControlType.Button;
            }
            else
            {
                return;
            }

            ControlSearch(groupBoxCheckList, level, type, strText);
        }

        private void ControlSearch(GroupBox checklist, int level, ControlType type, string strChangeText)
        {
            foreach (var item in checklist.Controls)
            {
                if (item is GroupBox itemGroup)
                {
                    this.listBox1.Items.Add($"현재 GroupBox : {checklist.Text}, 다음 GroupBox : {itemGroup.Text}");
                    ControlSearch(itemGroup, level, type, strChangeText);
                }
                else
                {
                    if (checklist.Text.Equals($"Level {level}"))
                    {
                        switch (type)
                        {
                            case ControlType.Label:
                                if (item is Label)
                                    (item as Label).Text = strChangeText;
                                break;
                            case ControlType.Textbox:
                                if (item is TextBox)
                                {
                                    (item as TextBox).Text = strChangeText;
                                    this.listBox1.Items.Add($"현재 GroupBox : {checklist.Text}, {type.ToString()}의 텍스트를 {strChangeText}로 변경");
                                }

                                break;
                            case ControlType.Button:
                                if (item is Button)
                                    (item as Button).Text = strChangeText;
                                break;
                            default:
                                break;
                        }

                    }

                }

            }

        }
    }
}
