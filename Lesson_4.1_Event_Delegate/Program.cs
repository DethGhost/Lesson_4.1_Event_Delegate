using System;

namespace Lesson_4._1_Event_Delegate
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Hello_event helloEvent = new Hello_event();
            MySubscriber subscriber = new MySubscriber(1, helloEvent);
            MySubscriber subscriber2 = new MySubscriber(2, helloEvent);
            MySubscriber subscriber3 = new MySubscriber(3, helloEvent);
            MySubscriber subscriber4 = new MySubscriber(4, helloEvent);
            MySubscriber subscriber5 = new MySubscriber(5, helloEvent);
            MySubscriber subscriber6 = new MySubscriber(6, helloEvent);
            MySubscriber subscriber7 = new MySubscriber(7, helloEvent);
            
            subscriber.Subscribe();
            subscriber2.Subscribe();
            subscriber3.Subscribe();
            subscriber4.Subscribe();
            subscriber5.Subscribe();
            subscriber6.Subscribe();
            subscriber7.Subscribe();

            helloEvent.StartMyEvent();
            subscriber2.Unsubscribe();
            subscriber5.Unsubscribe();
            subscriber6.Unsubscribe();
            helloEvent.StartMyEvent();
            Console.ReadLine();
        }
    }
}