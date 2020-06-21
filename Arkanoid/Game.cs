using System;
using System.Drawing;
using System.Windows.Forms;

namespace Arkanoid
{
    public partial class Game : Form
    {
        static Random rnd = new Random();

        int racket_x, racket_y;//переменные координат ракетки
        int ball_x, ball_y; //переменные координат шарика
        int racket_shift_x = 10;//переменная смещения на 8 пикселей

        int ball_shift_x = 5;//переменная смещения шарика по Х (Максимальные)
        int ball_shift_y = 4;//переменная смещения шарика по Y (Максимальные)
        int ball_sx,
            ball_sy;    //координаты реального смещения шарика по Х и Y

        int leftWall,   //левая стена, координата Х
            rigthWall,  //правая стена координата Х
            upWall;     //верхняя стена координата Y

        int total_bricks;//переменная для подсчета блоков

        public Game()
        {
            InitializeComponent();//функция появления формы
        }

        private void timer_Tick(object sender, EventArgs e)//событие в таймере
        {
            move_ball();//вызов функции перемещения шарика
        }

        private void Game_Shown(object sender, EventArgs e)//событие при первом появлении формы
        {
            init_game();//вызов функции игры
        }

        private void init_game () //функция подготовки игры
        {
            racket_x = Raketka.Location.X;//считываение и запись в переменную координаты Х у ракетки
            racket_y = Raketka.Location.Y;//считываение и запись в переменную координаты Y у ракетки
            leftWall = labelLeft.Location.X + labelLeft.Width;//Координата Х - стороны левой стены + ширина левой стены
            rigthWall = labelRight.Location.X;//координата Х - стороны правой стены
            upWall = labelUp.Location.X + labelUp.Height;//Координата Х - стороны верхней стены + высота верхней стены
            ball_x = ball.Location.X;//записываем в переменные шарика его координату по Х
            ball_y = ball.Location.Y;//записываем в переменные шарика его координату по Y
            ball_sx = ball_shift_x;//запись в переменную ball_sx величины из переменной ball_shift_x
            ball_sy = - ball_shift_y;//запись в переменную ball_sy величины из переменной ball_shift_y
            total_bricks = 5;//количество блоков
            label_bricks.Text = Convert.ToString(total_bricks);//начальное отображение количества блоков
        }

        private void Game_KeyDown(object sender, KeyEventArgs e) //событие нажатия кнопки
        {
            Keys key = e.KeyCode; //узнаем какая клавиша нажата
            switch (key)
            {
                case Keys.Left: shift_racket(-racket_shift_x); break;//сместить с помощью функции shift_racket влево на переменную racket_shift_x
                case Keys.Right: shift_racket(racket_shift_x); break;//сместить с помощью функции shift_racket влево на переменную racket_shift_x
                case Keys.Enter: timer.Enabled = true; break;//при нажатии Enter включаем timer
            }
        }

        private void shift_racket (int sx)//функция перемещения ракетки
        {
            //проверка, чтобы ракетка не вышла за пределы игрового поля
            int ax1 = (racket_x + sx);//координата левой части ракетки
            int ax2 = (ax1 + Raketka.Width);//координата правой части ракетки
            if (ax1 > rigthWall) return;//проверка, чтобы ракетка не забежала за левую стенку
            if (ax2 < leftWall) return;//проверка, чтобы ракетка не забежала за правую стенку
            racket_x = ax1;
            Raketka.Location = new Point(racket_x, racket_y);//устанавливаем новые данные локации ракетки (перемещаем)

        }

        private void move_ball ()//функция перемещения шарика с помощью таймера
        {
            int bx1, by1,
                bx2, by2;//все координаты шарика
            bx1 = ball_x;//координата шарика левая верхняя(Х)
            bx2 = ball.Width + ball_x;//координата шарика правая нижняя(Х)
            by1 = ball_y;//координата шарика левая верхняя(Y)
            by2 = ball.Height + ball_y;//координата шарика правая нижняя(Y)

            if (bx1 + ball_sx < leftWall) ball_sx = ball_shift_x; //отскок от левой стены
            if (bx2 + ball_sx > rigthWall) ball_sx = -ball_shift_x;//отскок от правой стены
            if (by1 + ball_sy < upWall) ball_sy = ball_shift_y;//отскок от верхней стены
            if (by2 + ball_sy > racket_y)
            {
                int bx0, by0; //координаты нижнего края шарика
                bx0 = (bx1 + bx2) / 2;
                by0 = (by1 + by2) / 2;
                int rx1, rx2;// координаты ракетки
                rx1 = racket_x;
                rx2 = racket_x + Raketka.Width;
                if (rx1 <= bx0 && bx0 <= rx2)
                {
                    ball_sy = -ball_shift_y + rnd.Next(-1, 2);//отскок от ракетки с учетом рандомного угла отскока
                }
                else
                if (rx1 <= bx2 && bx2 <= rx2)
                {
                    ball_sy = -ball_shift_y + rnd.Next(-1, 2);//отскок от ракетки
                    ball_sx = -ball_shift_x + rnd.Next(-1, 2);//для изменения угла отскока
                }
                else
                if (rx1 <= bx1 && bx1 <= rx2)
                {
                    ball_sy = -ball_shift_y + rnd.Next(-1, 2);//отскок от ракетки
                    ball_sx = ball_shift_x + rnd.Next(-1, 2);//для изменения угла отскока
                }
                else
                    lose_ball();//функция проигрыша

            }
            ball_x += ball_sx;//запись в переменную ball_x величины из переменной ball_sx
            ball_y += ball_sy;//запись в переменную ball_y величины из переменной ball_sx
            ball.Location = new Point(ball_x, ball_y);//новое местоположение шарика
            cross_brick(brick1);
            cross_brick(brick2);
            cross_brick(brick3);
            cross_brick(brick4);
            cross_brick(brick5);
        }

        private void cross_brick(Label brick)//пересечение шарика и кирпичных блоков
        {
            if (!brick.Visible) return;
            int bx1, bx0, bx2,
                by1, by0, by2;//все координаты шарика
            int rx1, rx2,
                ry1, ry2;//все координаты блока

            bx1 = ball_x;
            bx2 = ball_x + ball.Width;
            bx0 = (bx1 + bx2) / 2;
            by1 = ball_y;
            by2 = ball_y + ball.Height;
            by0 = (by1 + by2) / 2;
            rx1 = brick.Location.X;
            rx2 = rx1 + brick.Width;
            ry1 = brick.Location.Y;
            ry2 = ry1 + brick.Height;

            if (rx1 <= bx0 && bx0 <= rx2 &&
                ry1 <= by2 && by2 <= ry2)//прикосновение низа шарика и верха блока
            {
                drop_brick(brick);
                ball_sy = -ball_sy;
                return;
            }

            if (rx1 <= bx0 && bx0 <= rx2 && 
                ry1 <= by1 && by1 <= ry2)
            {
                drop_brick(brick);
                ball_sy = -ball_sy;
                return;
            }

            if (rx1 <= bx2 && bx2 <= rx2 &&
                ry1 <= by0 && by0 <= ry2)
            {
                drop_brick(brick);
                ball_sx = -ball_sx;
                return;
            }

            if (rx1 <= bx1 && bx1 <= rx2 &&
                ry1 <= by0 && by0 <= ry2)
            {
                drop_brick(brick);
                ball_sx = -ball_sx;
                return;
            }

            /*if ((rx1 <= bx2 && bx2 <= rx2 && ry1 <= by2 && by2 <= ry2) ||
                (rx1 <= bx1 && bx1 <= rx2 && ry1 <= by2 && by2 <= ry2) ||
                (rx1 <= bx1 && bx1 <= rx2 && ry1 <= by1 && by1 <= ry2) ||
                (rx1 <= bx2 && bx2 <= rx2 && ry1 <= by1 && by1 <= ry2))
            {
                drop_brick(brick);
                ball_sx = -ball_sx;
                ball_sy = -ball_sy;
                return;
            }*/
        }

        private void drop_brick (Label brick)//функция видимости или невидимости блока
        {
            brick.Visible = false;
            total_bricks--;//привыбивании блока, происходит уменьшение их на 1
            label_bricks.Text = Convert.ToString(total_bricks);

            if (total_bricks == 0)//если кончились блоки, игра пройдена
            {
                timer.Enabled = false;
                MessageBox.Show("You Win!");
                DialogResult = System.Windows.Forms.DialogResult.OK;
            }
        }
            

        private void lose_ball()
        {
            timer.Enabled = false; //остановим шарик
            MessageBox.Show("Game Over", "You Lose!");
            DialogResult = System.Windows.Forms.DialogResult.Abort;
        }
    }
}
