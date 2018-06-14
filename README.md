# Lab05_I_Built_A_Zoo
C# Console Application which builds out the hierarchical class structure of a zoo, demonstrating OOP principles.

## Zoo Class Hierarchy

![Zoo Class Structure](/assets/lab-05-class-structure-drawing.png)

## OOP Principles

* Abstraction - Hides complexity from users and developers
by limiting the visibility of methods and properties stored within parent Classes.

Examples:
 - With the MakeSound() method, created in the Animal Class, the inner workings of the method are hidden from
users and other developers. If called, the method will carry out it's implementation without needing to
display unnecessary complexity.

- The CrawlOutOfWall() method in the Bug Class can be defined to contain any functionality you would like,
while hiding these details from others that would use this method.

* Inheritence - Enables derived Classes to utilize properties and methods defined in parent Classes,
reducing the amount of code duplication between Classes derived from a common parent.

Examples:
- In the Bug Class, I have created an abstract Boolean called "IsCreepyCrawly". This boolean is later
set to "true" in the Spider Class, where all other Classes that are derived from the Spider Class will now
also have the IsCreepyCrawly boolean set to true.

- In the Bat Class, the interface "ICanFly" is set, where it is also inhereted by all Classes that derive
from the Bat Class.

* Polymorphism - The ability for derived Classes to override properties and methods defined in parent Classes,
altering their functionality and implementation.

Examples:
- In the Batman Class, which inherits the "ICanFly" interface from the Bat Class, I am overriding the
interface to allow Batman objects to glide instead of fly.

- Each of the concrete classes sets the "Diet" property for that specific Class. This overrides the property
which is originally declared in the Animal Class.

* Encapsulation - Causes a group of related Classes to act as a single unit. The properties and methods 
from each Class is shared in the instantiated object.

Examples:
- Since all of the properties and methods from parent Classes are inherited by derived Classes, objects
created as an instance of a derived, concrete Class are able to utilize each of these properties and
methods as a single unit.

## Interfaces

An interface defines what an object can do - or the functionality that the Class,
from which the object is instantiated, can implement. Interfaces are able to be used across Class hierarchical
structures, counteracting limitations present from C# not allowing multiple inheritance.

I have created "ICanFly" and "IBeEvil" interfaces, which define functionality that unrelated Classes can
implement. The ICanFly interface is being set in the "Bat", "Batman" (where it's overridden),
and "Spider" Classes. The IBeEvil interface is set in the "VampireBat", "RattleSnake", and "Spider" Classes.

These interfaces are set because, even though the Classes are unrelated, I felt they each should share similar
functionality in this aspect.