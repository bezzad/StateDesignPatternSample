# State Design Pattern

The State design pattern allows an object to alter its behavior when its internal state changes. The object will appear to change its class.

Frequency of use: medium

### Participants

The classes and objects participating in this pattern include:

* Context  (ContractContext)
	+ defines the interface of interest to clients
	+ maintains an instance of a ConcreteState subclass that defines the current state.

* State  (ContractState)
	+ defines an interface for encapsulating the behavior associated with a particular state of the Context.

* Concrete State  (Accepted, Cancelled, Draft, Expired, InProgress, Waiting, Completed)
	+ each subclass implements a behavior associated with a state of Context