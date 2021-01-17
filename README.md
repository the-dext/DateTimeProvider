# DateTimeProviders

DateTimeProviders aims to solve the problems around testing code that has dependencies on the DateTime/DateTimeOffset structs, and also enforcing consistent use of Now and UtcNow.  
It does this in two ways...

* Write Testable Code  
DateTimeProviders wraps most of the standard DateTime & DateTimeOffset functionality in new abstractions that have interfaces.
By injecting these interfaces as dependencies into your code, you can now mock your use of these dependencies as you see fit.

* Maintain Consistency  
Working on a project where it is important that the developers stick to using UtcNow instead of Now?  
  
    DateTimeProviders allows you to override the standard Now/UtcNow functionality so that you can do whatever you need. For example you could make the two methods equivalent to each other, log a warning that there is an undesirable method call, or throw an exception.


# Basic Usage
1) Register DateTimeProvider and DateTimeOffsetProvider as a Singleton using your DI/IoC container
2) (Optional) If you need to enforce consistency you can set your DI/IoC containers factory method to use the non-default constructor and pass in your own implementations.
3) In your application code, do not call DateTime directly. Instead inject one of the interfaces `IDateTimeProvider` or `IDateTimeOffsetProvider`, and call the properties/methods on the instance given to you by your DI/IoC container.
4) In your unit tests or any other time you need a mock, mock out the IDateTimeProvider/IDateTimeOffsetProvider interfaces and inject your mocks into your subject-under-test.

# Enforcing Consistency 
If you need to enforce consistent usage of Now vs UtcNow, both of the abstractions support replacing the default implementations by passing your own `Func<T>` implementations, where T is either a DateTime or a DateTimeOffset.

Each abstraction provides a default parameterless constructor and a constructor that accepts arguments that allow you to override one or both of Now/UtcNow properties with your own implementation.  

If you only want to override one property, you can pass a `null` argument to the other and the default implementation will continue to be used.
The signatures of the constructors are  

`public DateTimeProvider(Func<DateTime> nowFunc = null, Func<DateTime> utcNowFunc = null)`  

`public DateTimeOffsetProvider(Func<DateTimeOffset> nowFunc = null, Func<DateTimeOffset> utcNowFunc = null)`

## Examples
Overriding Now so that it returns the same value as UtcNow

    `var dateTimeProvider = new DateTimeOffsetProvider(()=>DateTime.UtcNow, null);`

Overriding Now so that it throws an exeption

    `new DateTimeOffsetProvider(() => throw new NotSupportedException("You should call UtcNow"), null);`

# Version History
* 1.0  - Initial Release.
