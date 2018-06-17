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
    public partial class FormLevel2 : Form
    {
        public FormLevel2()
        {
            InitializeComponent();
        }

        private void FormLevel2_Load(object sender, EventArgs e)
        {

        }

        private void start_game()
        {
            Point point;
            point = label_start.Location;
            point.Offset(label_start.Width / 2, label_start.Height / 2);
            Cursor.Position = PointToScreen(point);
            label_key.Visible = true;
            label_door.Visible = true;
            label_wall1.Visible = true;
            label_wall2.Visible = false;
            Sound.play_start();
        }

        private void finish_game()
        {
            Sound.play_fail();
            DialogResult dr = MessageBox.Show(
                "Вы проиграли. Хотите попробовать еще раз?",
                "Сообщение",
                MessageBoxButtons.YesNo
            );
            if (dr == System.Windows.Forms.DialogResult.Yes)
                start_game();
            else
                DialogResult = System.Windows.Forms.DialogResult.Abort;
        }

        private void FormLevel2_Shown(object sender, EventArgs e)
        {
            start_game();
        }

        private void label6_MouseEnter(object sender, EventArgs e)
        {
            finish_game();
        }

        private void label_key_MouseEnter(object sender, EventArgs e)
        {
            label_key.Visible = false;
            Sound.play_key();
        }

        private void label_door_MouseEnter(object sender, EventArgs e)
        {
            if (label_key.Visible)
                finish_game();
            else
            {
                label_door.Visible = false;
                Sound.play_key();
            }
        }

        private void label_finish_MouseEnter(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label_wall1.Visible = !label_wall1.Visible;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            label_wall2.Visible = !label_wall2.Visible;
        }
    }
}
