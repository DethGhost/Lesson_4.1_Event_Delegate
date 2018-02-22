using System;

namespace Lesson_4._1_Event_Delegate
{
    public delegate void MyCustomEvent(object a, MyCustomEventArgs eventArgs);

    public class Hello_event
    {
        public event MyCustomEvent myEvent;

        public void StartMyEvent()
        {
            if (myEvent != null)
            {
                myEvent(this, new MyCustomEventArgs(time: DateTime.Now));
            }
        }

        
    }
}