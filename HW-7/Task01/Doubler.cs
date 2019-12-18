using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01
{
    class Doubler
    {
        private int maxStep;
        private int task;
        private int number;
        private bool active = false;

        public int Step { get { return Steps.Count(); } }
        public int MaxStep { get { return this.maxStep; } }
        public int Task { get { return this.task; } }
        public int Number { get { return this.number; } }
        public bool Active { get { return this.active; } }

        private Stack<int> Steps = new Stack<int>();

        public bool WinFlag = false;
        public bool LostFlag = false;

        public Doubler()
        {
            NewGame();
        }

        public void DoDouble()
        {
            number *= 2;
            Steps.Push(2);
            Check();
        }

        public void DoIncrement()
        {
            number++;
            Steps.Push(1);
            Check();
        }

        public void CancelStep()
        {
            switch (Steps.Pop())
            {
                case 1:
                    number--;
                    break;
                case 2:
                    number /= 2;
                    break;
            }
        }

        public void Reset()
        {
            number = 1;
            Steps.Clear();
            active = false;
        }

        public void NewGame()
        {
            Random rnd = new Random();
            task = 10 + rnd.Next(90);
            Steps.Clear();

            number = 1;

            int tNum = task;
            maxStep = 0;

            do
            {
                if(tNum % 2 == 0)
                {
                    tNum /= 2;
                }
                else 
                { 
                    tNum--;
                }
                maxStep++;
            } while (tNum != 1);
            active = true;
        }
        
        public void Check()
        {
            if (number == task)
            {
                WinFlag = true;
                Reset();
            }
            else if (Step == maxStep)
            {
                LostFlag = true;
                Reset();
            }
        }

    }
}