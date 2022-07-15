using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PikachuWinformCs
{
    public partial class Form1 : Form
    {
        #region Properties
        List<List<Button>> chessBoard;
        PROCESS xuli;
        CONST hangso;
        #endregion

        public Form1()
        {
            InitializeComponent();
            hangso = new CONST();
            pnlChessBoard.Enabled = false;
            InitMap();
        }

        #region Methods
        Button CreateButton(int x, int y, int width, int height, int index)
        {
            Button btn = new Button()
            {
                BackColor = System.Drawing.SystemColors.Control,
                ForeColor = Color.Blue,
                Location = new Point(x, y),
                Width = width,
                Height = height,
                Tag = index,
                Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)))
            };

            btn.Click += Btn_Click;

            return btn;
        }

        void CreateEmptyRow(int index)
        {
            List<Button> btnList = new List<Button>();
            for (int i = 0; i < hangso.Col + 2; i++)
            {
                Button btn = CreateButton(0, 0, 0, 0, index);
                pnlChessBoard.Controls.Add(btn);
                btnList.Add(btn);
            }
            chessBoard.Add(btnList);
        }

        void CreateChessBoard()
        {
            int startX = (pnlChessBoard.Width - hangso.Width * hangso.Col) / 2;
            int startY = (pnlChessBoard.Height - hangso.Height * hangso.Row) / 2;
            List<Button> btnList;
            Button btn;

            CreateEmptyRow(0);

            for (int i = 0; i < hangso.Row; i++)
            {
                btnList = new List<Button>();

                btn = CreateButton(0, 0, 0, 0, i + 1);
                pnlChessBoard.Controls.Add(btn);
                btnList.Add(btn);

                for (int j = 1; j < hangso.Col + 1; j++)
                {
                    btn = CreateButton(startX + (j - 1) * hangso.Width, startY + i * hangso.Height, hangso.Width, hangso.Height, i + 1);
                    pnlChessBoard.Controls.Add(btn);
                    btnList.Add(btn);
                }

                btn = CreateButton(0, 0, 0, 0, i + 1);
                pnlChessBoard.Controls.Add(btn);
                btnList.Add(btn);

                chessBoard.Add(btnList);
            }

            CreateEmptyRow(hangso.Row + 1);
        }
        #endregion


        #region Controls_Event
        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Bạn có chắc chắn thoát game?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            switch (result)
            {
                case DialogResult.Yes:
                    Application.Exit();
                    break;
                case DialogResult.No:
                    break;
                default:
                    break;
            }
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            int Y = (int)btn.Tag;
            int X = chessBoard.ElementAt(Y).IndexOf(btn);

            //MessageBox.Show("Button clicked " + Y + "," + X);
            xuli.UpdateConnect(X, Y);
        }

        private void btbStart_Click(object sender, EventArgs e)
        {
            pnlChessBoard.Enabled = true;
            (sender as Button).Enabled = false;
            xuli.CreateMap();

            SetAndStartTimer();
        }

        private void settingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            xuli.CreateMap();
            SetAndStartTimer();
        }

        void SetAndStartTimer()
        {
            pnlChessBoard.Enabled = true;
            pgrLoading.Value = pgrLoading.Maximum;
            timer1.Interval = 1000;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pgrLoading.Value - 1 < pgrLoading.Minimum)
            {
                timer1.Stop();
                pnlChessBoard.Enabled = false;
            }
            else
            {
                pgrLoading.Value--;
            }
        }

        void InitMap()
        {
            pnlChessBoard.Controls.Clear();
            chessBoard = new List<List<Button>>();
            CreateChessBoard();
            xuli = new PROCESS(chessBoard, pnlChessBoard, timer1);
        }

        void SettingInformationGame(int col, int row)
        {
            hangso.Row = row;
            hangso.Col = col;

            InitMap();

            settingToolStripMenuItem.PerformClick();
        }

        private void map16x14ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SettingInformationGame(16, 14);
        }

        private void map10x10ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SettingInformationGame(10, 10);
        }

        private void map6x6ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SettingInformationGame(6, 6);
        }
        #endregion
    }
}
