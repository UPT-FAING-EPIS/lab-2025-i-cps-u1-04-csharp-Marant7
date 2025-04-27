```mermaid
classDiagram

class ConcreteObserver
ConcreteObserver : +String Name
ConcreteObserver : +String LastMessage
ConcreteObserver : +Update() Void

class ConcreteSubject
ConcreteSubject : +Attach() Void
ConcreteSubject : +Detach() Void
ConcreteSubject : +Notify() Void

class IObserver
IObserver : +Update() Void

class ISubject
ISubject : +Attach() Void
ISubject : +Detach() Void
ISubject : +Notify() Void


IObserver <|.. ConcreteObserver
ISubject <|.. ConcreteSubject

```
