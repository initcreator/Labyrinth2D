﻿using System;
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
    public partial class FormLevel1 : Form
    {
        int leftBoxes;

        public FormLevel1()
        {
            InitializeComponent();
        }

        private void FormLevel1_Load(object sender, EventArgs e)
        {
        }

        private void start_game()
        {
            Point point;
            point = label_start.Location;
            point.Offset(label_start.Width / 2, label_start.Height / 2);
            Cursor.Position = PointToScreen(point);
            leftBoxes = 4;
            label_box1.Visible = true;
            label_box2.Visible = true;
            label_box3.Visible = true;
            label_box4.Visible = true;
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
            {
                start_game();
            }
            else
                DialogResult = System.Windows.Forms.DialogResult.Abort;
        }

        private void FormLevel1_Shown(object sender, EventArgs e)
        {
            start_game();
        }

        private void label_finish_MouseEnter(object sender, EventArgs e)
        {
            if (leftBoxes == 0)
                DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void label6_MouseEnter(object sender, EventArgs e)
        {
            finish_game();
        }

        private void label_box1_MouseEnter(object sender, EventArgs e)
        {
            Sound.play_key();
            leftBoxes--;
            ((Label) sender).Visible = false;
        }
    }
}
