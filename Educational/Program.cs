using Educational;
//OBJECT
StaticObject.Explenation();


//CLASS WITH IMPLICIT CONSTRUCTOR
ClassWithGetterAndSetters classWithoutConstructor = new ClassWithGetterAndSetters();
classWithoutConstructor.Name = "Arne";
Console.WriteLine(classWithoutConstructor.Name);
classWithoutConstructor.Explanation();


//CLASS WITH CONSTRUCTOR
ClassWithExplicitConstructor withConstructor = new ClassWithExplicitConstructor("Arnes");
Console.WriteLine($"The name property is empty if the Name (first) argument is shorter than 5 characters: {withConstructor.Name}");
withConstructor.Explanation();