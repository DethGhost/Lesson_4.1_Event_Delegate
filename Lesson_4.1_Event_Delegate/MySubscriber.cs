using System;

namespace Lesson_4._1_Event_Delegate
{
    public class MySubscriber
    {

        private readonly Hello_event _event;
        private int index;
        
        public MySubscriber()
        {
        }
        
        public MySubscriber(int index, Hello_event MyEvent)
        {
            this.index = index;
            this._event = MyEvent;
        }
        
        public void Subscribe()
        {
            this._event.myEvent += PublisherOnStartMyEvent;
        }
        
        public void Unsubscribe()
        {
            this._event.myEvent -= PublisherOnStartMyEvent;
        }

        private void PublisherOnStartMyEvent(object sender, MyCustomEventArgs eventArgs)
        {
            Console.WriteLine("This was happend, was coling by {0} at {1}", this.index, eventArgs.Time);
        }
    }
}