using System;
using System.Collections.Generic;
using System.Text;
using System.Timers;

namespace RockPapereScisors
{
    public class Game
    {
        private Timer timer;
        public player Player1 { get;}
        public player Player2 { get;}

        public event Action FightFinished;

        public Game(int money)
        {
            Player1 = new player(money);
            Player2 = new player(money);
            timer = new Timer(1000);
            timer.Elapsed += Timer_Elapsed;

        }

        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            var p1 = Player1.GetState();
            var p2 = Player2.GetState();

            if(p1 != p2)
            {
                if (p1 == PlayerState.Rock)
                {
                    if (p2 == PlayerState.Scissors)
                    {
                        Player1.Win();
                        Player2.Lose();
                    }
                    else
                    {
                        Player2.Win();
                        Player1.Lose();
                    }
                }
                else if (p1 == PlayerState.Scissors)
                {
                    if (p2 == PlayerState.Rock)
                    {
                        Player2.Win();
                        Player1.Lose();
                    }
                    else
                    {
                        Player1.Win();
                        Player2.Lose();
                    }

                }
                else
                {
                    if (p2 == PlayerState.Scissors)
                    {
                        Player2.Win();
                        Player1.Lose();
                    }
                    else
                    {
                        Player1.Win();
                        Player2.Lose();
                    }

                }
            }
            FightFinished?.Invoke();
            
        }
        public void Start()
        {
            timer.Start();
        }
    }
}
