using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PikachuWinformCs
{
    public class PROCESS
    {
        #region Properties
        List<List<Button>> Map;
        Panel pnlMap;
        Timer timer1;
        Point start;
        Point end;
        int Row;
        int Col;
        #endregion  

        public PROCESS(List<List<Button>> chessBoard, Panel pnlMap, Timer t)
        {
            this.Map = chessBoard;
            this.pnlMap = pnlMap;
            this.timer1 = t;
            this.start = new Point(-1, -1);
            this.end = new Point(-1, -1);
            this.Row = this.Map.Count;
            this.Col = this.Map.ElementAt(0).Count;

            //Map.ElementAt(1).ElementAt(1).Text = "547";
            //MessageBox.Show((Map.Count * Map.ElementAt(0).Count).ToString());
        }

        #region Methods
        public void UpdateConnect(int x, int y)
        {
            if (GetButtonAt(x, y).Text == " ") return;

            if (start.X == x && start.Y == y)
            {
                // huỷ bỏ trạng thái của start
                start.X = end.X = -1;
                GetButtonAt(x, y).BackColor = System.Drawing.SystemColors.Window;
            }
            else if (start.X == -1)
            {
                start.X = x;
                start.Y = y;
                GetButtonAt(x, y).BackColor = Color.Aqua;
            }
            else if (end.X == -1)
            {
                end.X = x;
                end.Y = y;

                /* ktra điều kiện --> thoã điều kiện connect --> remove 2 button tương ứng --> huỷ bỏ trạng thái 2 nút (start end);
                 * --> không thoã điều kiện connect --> huỷ bỏ trạng thái 2 nút (start end);
                 */
                if (CheckConnect())
                {
                    GetButtonAt(start.X, start.Y).Text = " ";
                    GetButtonAt(end.X, end.Y).Text = " ";
                    if (IsEnd())
                    {
                        pnlMap.Enabled = false;
                        timer1.Stop();
                        MessageBox.Show("Người chơi đã mở hết ô!", "Trò chơi kết thúc", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

                // huỷ bỏ trạng thái start end
                GetButtonAt(start.X, start.Y).BackColor = System.Drawing.SystemColors.Window;
                //GetButtonAt(end.X, end.Y).BackColor = System.Drawing.SystemColors.Control;
                start.X = end.X = -1;
            }

            //MessageBox.Show(start.Y + "," + start.X + "\n" + end.Y + "," + end.X);
        }

        /// <summary>
        /// Lấy index tương ứng với x và y của button
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public int GetIndex(int x, int y)
        {
            return y * Col + x;
        }

        /// <summary>
        /// Lấy toạ độ của button tương ứng với index
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public Point GetPoint(int index)
        {
            return new Point(index % Col, index / Col);
        }

        /// <summary>
        /// Lấy button tại vị trí x và y
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public Button GetButtonAt(int x, int y)
        {
            return Map.ElementAt(y).ElementAt(x);
        }

        /// <summary>
        /// Khởi tạo bản đồ chơi
        /// </summary>
        public void CreateMap() // xem lại khởi tạo bản đồ --> lỗi ở phần biên
        {
            #region Comment
            /*
            List<int> a = new List<int>();
            // create temp array
            for (int i = 0; i < Row * Col; i++)
            {
                a.Add(i);
            }

            List<int> arr = new List<int>();
            Random rand = new Random();
            // create index array
            while (a.Count > 0)
            {
                int pos = rand.Next(a.Count);
                arr.Add(a.ElementAt(pos));
                a.RemoveAt(pos);

                pos = rand.Next(a.Count);
                arr.Add(a.ElementAt(pos));
                a.RemoveAt(pos);
            }
            // create map
            for (int i = 0; i < arr.Count / 2; i++)
            {
                int value = rand.Next(1, 10);

                Point toado = GetPoint(arr.ElementAt(2 * i));
                Button btn = GetButtonAt(toado.X, toado.Y);
                btn.Text = value.ToString();

                toado = GetPoint(arr.ElementAt(2 * i + 1));
                btn = GetButtonAt(toado.X, toado.Y);
                btn.Text = value.ToString();
            }*/
            #endregion

            // làm rỗng biên
            for (int y = 0; y < Row; y++)
            {
                GetButtonAt(0, y).Text = " ";
                GetButtonAt(Col - 1, y).Text = " ";
            }

            for (int x = 0; x < Col; x++)
            {
                GetButtonAt(x, 0).Text = " ";
                GetButtonAt(x, Row - 1).Text = " ";
            }

            // 0    1 2 3 4 5 Row - 1
            // temp 1 2 3 4 5 temp
            // tạo mảng trung gian
            List<int> a = new List<int>();
            for (int i = 1; i <= Row - 2; i++)
            {
                for (int j = 1; j <= Col - 2; j++)
                {
                    a.Add(GetIndex(j, i));
                }
            }

            // tạo mảng ngẫu nhiên - tạo bản đồ
            Random rand = new Random();
            while (a.Count > 0)
            {
                int value = rand.Next(1, 10);
                int pos = rand.Next(a.Count);
                Point toado = GetPoint(a.ElementAt(pos));
                GetButtonAt(toado.X, toado.Y).Text = value.ToString();
                a.RemoveAt(pos);

                pos = rand.Next(a.Count);
                toado = GetPoint(a.ElementAt(pos));
                GetButtonAt(toado.X, toado.Y).Text = value.ToString();
                a.RemoveAt(pos);
            }
        }

        /// <summary>
        /// Kiểm tra bản đồ còn thoã mãn để chơi tiếp
        /// </summary>
        /// <returns></returns>
        public bool CheckMap()
        {
            return false;
        }

        /// <summary>
        /// Kiểm tra trò chơi đã đạt điều kiện kết thúc hay chưa
        /// </summary>
        /// <returns></returns>
        public bool IsEnd()
        {
            foreach (var btnList in Map)
            {
                foreach (var item in btnList)
                {
                    if (item.Text != " ") return false;
                }
            }
            return true;
        }

        /// <summary>
        /// Đếm số ô rỗng cùng phía và trả về vị cuối cùng
        /// </summary>
        /// <param name="diem"></param>
        /// <param name="moveX"></param>
        /// <param name="moveY"></param>
        /// <returns></returns>
        public int FindEndPoint(ref Point diem, int moveX, int moveY)
        {
            int count = 0;

            while (true)
            {
                int X = diem.X + moveX;
                int Y = diem.Y + moveY;

                if (!CheckRange(X, Y)) break;
                if (GetButtonAt(X, Y).Text != " ") break;

                count++;
                diem.X = X;
                diem.Y = Y;
            }

            return count;
        }

        /// <summary>
        /// Tìm kiếm điểm cuối cùng xuất phát từ diem, thoã mãn điều kiện tịnh tiến theo moveX và moveY
        /// </summary>
        /// <param name="diem"></param>
        /// <param name="moveX"></param>
        /// <param name="moveY"></param>
        /// <returns></returns>
        public Point EndPoint(Point diem, int moveX, int moveY)
        {
            FindEndPoint(ref diem, moveX, moveY);
            return diem;
        }

        /// <summary>
        /// Tìm giá trị lớn nhất của hai số
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public int Max(int a, int b)
        {
            return a > b ? a : b;
        }

        /// <summary>
        /// Tìm giá trị nhỏ nhất của 2 số
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public int Min(int a, int b)
        {
            return a < b ? a : b;
        }

        /// <summary>
        /// Kiểm tra cột xem có thoã điều kiện để thực hiện connect
        /// </summary>
        /// <returns></returns>
        public bool CheckRow()
        {
            int startLeft = EndPoint(start, -1, 0).X;
            int startRight = EndPoint(start, 1, 0).X;
            int endLeft = EndPoint(end, -1, 0).X;
            int endRight = EndPoint(end, 1, 0).X;

            TapHop tapchung = new TapHop(Max(startLeft, endLeft), Min(startRight, endRight));

            for (int x = tapchung.Left; x <= tapchung.Right; x++)
            {
                Point diem = new Point(x, Min(start.Y, end.Y));
                if (FindEndPoint(ref diem, 0, 1) + 1 >= Math.Abs(start.Y - end.Y))
                {
                    return true;
                }
            }

            return false;
        }
        
        /// <summary>
        /// Kiểm tra cột xem có thoã điều kiện để thực hiện connect
        /// </summary>
        /// <returns></returns>
        public bool CheckCol()
        {
            int startLeft = EndPoint(start, 0, -1).Y;
            int startRight = EndPoint(start, 0, 1).Y;
            int endLeft = EndPoint(end, 0, -1).Y;
            int endRight = EndPoint(end, 0, 1).Y;

            TapHop tapchung = new TapHop(Max(startLeft, endLeft), Min(startRight, endRight));

            for (int y = tapchung.Left; y <= tapchung.Right; y++)
            {
                Point diem = new Point(Min(start.X, end.X), y);
                if (FindEndPoint(ref diem, 1, 0) + 1 >= Math.Abs(start.X - end.X))
                {
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// Kiểm tra xem có đường đi từ start đến end thoã mãn bài toán
        /// </summary>
        /// <returns></returns>
        public bool CheckConnect()
        {
            if (GetButtonAt(start.X, start.Y).Text != GetButtonAt(end.X, end.Y).Text) return false;

            if (Math.Abs(start.X - end.X) + Math.Abs(start.Y - end.Y) == 1) return true;
            if (start.X == end.X && (start.X == 1 || start.X == Col - 2)) return true;
            if (start.Y == end.Y && (start.Y == 1 || start.Y == Row - 2)) return true;
            if (CheckRow()) return true;
            if (CheckCol()) return true;

            return false;
        }

        /// <summary>
        /// Kiểm tra xem vị trí x, y có hợp lệ
        /// </summary>
        /// <returns></returns>
        public bool CheckRange(int x, int y)
        {
            return 0 <= x && x <= Col - 1 && 0 <= y && y <= Row - 1;
        }
        #endregion
    }

    public class TapHop
    {
        public int Left { get; set; }
        public int Right { get; set; }

        public TapHop(int left, int right)
        {
            this.Left = left;
            this.Right = right;
        }
    }
}
