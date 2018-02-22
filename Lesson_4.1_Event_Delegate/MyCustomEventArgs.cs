using System;

namespace Lesson_4._1_Event_Delegate
{
    public class MyCustomEventArgs : EventArgs
    {
        public MyCustomEventArgs(DateTime time)
        {
            Time = time;
        }

        public DateTime Time { get; set; }

    }
}