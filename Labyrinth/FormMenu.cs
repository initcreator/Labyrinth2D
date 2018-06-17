using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labyrinth2D
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            start_level1();
        }

        private void box_sound_CheckedChanged(object sender, EventArgs e)
        {
            if (box_sound.Checked)
            {
                Sound.sound_on();
                box_sound.Text = "Звук есть";
                Sound.play_key();
            }
            else
            {
                Sound.sound_off();
                box_sound.Text = "Звука нет";
            }
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void start_level1()
        {
            FormLevel1 level1 = new FormLevel1();
            DialogResult dr = level1.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
                start_level2();
        }

        private void start_level2()
        {
            FormLevel2 level2 = new FormLevel2();
            DialogResult dr = level2.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                start_youwin();
            }
        }

        private void start_youwin()
        {
            Sound.play_youwin();
            MessageBox.Show("Вы успешно прошли игру!", "Поздравляем!");
        }
    }
}
