using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Whereiscat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            countDownLb.Visible = true;
            CountDown(3);
        }
        private int timeOut, countTime;

        private void CountDown(int second)
        {
            var timer =new System.Timers.Timer();
            timer.AutoReset = true;
            timer.Interval = 1000;
            timer.Start();
            timer.Elapsed += Timer_Elapsed;

            timeOut = second;
        }

         void Timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            countTime++;
            this.Invoke((MethodInvoker)delegate
            {
                countDownLb.Text = countTime.ToString();
            });

            if (countTime > timeOut)
            {

                this.Invoke((MethodInvoker)delegate
                {
                    countDownLb.Visible = false;
                    startBtn.Visible = false;

                    GameStart();
                });
            }

        }

        private void GameStart()
        {
            Whereiscat.GameUI gameUI = new Whereiscat.GameUI();
            this.Controls.Add(gameUI);

            gameUI.Location = new System.Drawing.Point(this.Width/4 , this.Height / 8);
        }
    }
}
