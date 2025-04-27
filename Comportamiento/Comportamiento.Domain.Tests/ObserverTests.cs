using NUnit.Framework;
using Comportamiento.Domain;

namespace Comportamiento.Domain.Tests
{
    public class ObserverTests
    {
        [Test]
        public void WhenSubjectNotifies_ObserversReceiveMessage()
        {
            var subject = new ConcreteSubject();
            var observer1 = new ConcreteObserver("Observer 1");
            var observer2 = new ConcreteObserver("Observer 2");

            subject.Attach(observer1);
            subject.Attach(observer2);

            string message = "Important Update!";
            subject.Notify(message);

            Assert.AreEqual(message, observer1.LastMessage);
            Assert.AreEqual(message, observer2.LastMessage);
        }

        [Test]
        public void WhenObserverDetached_DoesNotReceiveMessages()
        {
            var subject = new ConcreteSubject();
            var observer = new ConcreteObserver("Observer");

            subject.Attach(observer);
            subject.Detach(observer);

            subject.Notify("Update after detach");

            Assert.IsNull(observer.LastMessage);
        }
    }
}
