namespace exercise_119
{
    public class Timer
    {
        private ClockHand hundred;
        private ClockHand second;

        public Timer()
        {
            this.hundred = new ClockHand(100);
            this.second = new ClockHand(60);
        }
        public void Advance()
        {
            
            this.hundred.Advance();
            if  (this.hundred.value == 0)
            {
                this.second.Advance();
            }
        }
        public override string ToString()
    {
        return this.second + ":" + this.hundred;
    }
    }
    
}
