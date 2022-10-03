using System;
using System.Collections.Generic;
using System.Text;

namespace RockPapereScisors
{
    public class player
    {
        private Random random = new Random();
        public int Money { get; internal set; }
        public player(int money)
        {
            Money = money;
        }
        public PlayerState GetState()
        {
            int value = random.Next(0, 3);
            return (PlayerState)value;


        }
        public void Win()
        {
            Money++;
        }
        public void Lose()
        {
            Money--;
        }
    }
    public enum PlayerState
    {
        Rock,
        Paper,
        Scissors
    }
}
