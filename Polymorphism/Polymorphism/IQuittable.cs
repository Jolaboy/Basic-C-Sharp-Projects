using System;

namespace Polymorphism
{
    /// <summary>
    /// This is an interface. It's a contract that guarantees a class implementing it
    /// will have a certain method. This interface defines one method, Quit().
    /// </summary>
    public interface IQuittable
    {
        // This method signature indicates that any class implementing this interface
        // must have a public void method called Quit() with no parameters.
        void Quit();
    }

}
