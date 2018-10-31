using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session25
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

    class ObjectReceivingInstanceMethodParameter
    {
        public void DoSomething(Person p)
        {
            // Do something with the parameter.
        }
    }

    class ObjectSendingInstanceMethodReturnValue
    {
        public Person DoSomething()
        {
            return new Person { Name = "John Doe", Age = 40 };
        }
    }

    class ClassReceivingClassMethodParameter
    {
        public static void DoSomething(Person p)
        {
            // Do something with the parameter.
        }
    }

    class ObjectReceivingConstructorParameter
    {
        private Person person;

        public ObjectReceivingConstructorParameter(Person p)
        {
            person = p;
        }

        public void DoSomething()
        {
            // Do something with the instance variable.
        }
    }

    class ClassReceivingParameter
    {
        public static void DoSomething(Person p)
        {
            // Do something with the parameter.
        }
    }

    class ObjectContainingInstanceVariable
    {
        public Person Person { get; set; }

        public void DoSomething()
        {
            // Do something with the instance variable.
        }
    }

    class ClassContainingClassVariable
    {
        public static Person Person { get; set; }

        public static void DoSomething()
        {
            // Do something with the class variable.
        }
    }

    class ClassReceivingLambdaParameter
    {
        public static void DoSomething(Func<Person, int, string> doSomethingMore)
        {
            // Do something with the lambda expression, for example:
            Person p = new Person { Name = "John Doe", Age = 40 };
            string result = doSomethingMore(p, 123);
        }
    }

    class ObjectContainingMultipleMethods
    {
        public void DoSomething(Person p)
        {
            // Do something with the parameter.
        }

        public void DoSomethingElse(string s)
        {
            // Do something with the parameter.
        }

        public void DoEvenMore(int i)
        {
            // Do something with the parameter.
        }
    }

    class ObjectReceivingObjectParameter
    {
        private ObjectContainingMultipleMethods otherObject;

        public ObjectReceivingObjectParameter(ObjectContainingMultipleMethods o)
        {
            // Do something with the object's methods right away, for example:
            o.DoSomething(new Person { Name = "John Doe", Age = 40 });
            o.DoSomethingElse("abc");
            o.DoEvenMore(123);

            // Or store it for later use:
            otherObject = o;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ExampleWithInstanceMethodParameter();
            ExampleWithInstanceMethodReturnValue();
            ExampleWithClassMethodParameter();
            ExampleWithConstructorParameter();
            ExampleWithInstanceVariable();
            ExampleWithClassVariable();
            ExampleWithLambdaParameter();
        }

        static void ExampleWithInstanceMethodParameter()
        {
            // Send value from current object/class to other object as a parameter.
            // Current object/class decides which value to send but other object decides how it is used.
            // Often combined with receiving a return value as well.
            ObjectReceivingInstanceMethodParameter o = new ObjectReceivingInstanceMethodParameter();
            Person p = new Person { Name = "Brad Pitt", Age = 53 };
            o.DoSomething(p);
        }

        static void ExampleWithInstanceMethodReturnValue()
        {
            // Send value from other object to current object/class as return value.
            // Other object decides which value to send but current object/class decides how it is used.
            // Often combined with sending parameters as well.
            ObjectSendingInstanceMethodReturnValue o = new ObjectSendingInstanceMethodReturnValue();
            Person p = o.DoSomething();
        }

        static void ExampleWithClassMethodParameter()
        {
            // Same as the example with an instance method parameter, but does not operate on any specific object.
            // Convenient if we do not need to work with different objects, or if we prefer sending the object in question as a regular parameter.
            // Important: Class methods are avoided by some developers because in some cases they do not scale well for larger programs.
            Person p = new Person { Name = "Brad Pitt", Age = 53 };
            ClassReceivingClassMethodParameter.DoSomething(p);
        }

        static void ExampleWithConstructorParameter()
        {
            // Same as the example with a regular instance method parameter, but the parameter can now be available in all methods inside the object as soon as it has been created.
            // The constructor parameter is generally assigned to a private instance variable inside the object.
            Person p = new Person { Name = "Brad Pitt", Age = 53 };
            ObjectReceivingConstructorParameter o = new ObjectReceivingConstructorParameter(p);
            o.DoSomething();
        }

        static void ExampleWithInstanceVariable()
        {
            // Send value from current object/class to other object by setting an instance variable.
            // Current object/class decides which value to send but both current object/class and other object decide how it is used (because it is public).
            // Important: Nothing *requires* the variable to be set, unlike required parameters.
            ObjectContainingInstanceVariable o = new ObjectContainingInstanceVariable();
            Person p = new Person { Name = "Angelina Jolie", Age = 43 };
            o.Person = p;
            o.DoSomething();
        }

        static void ExampleWithClassVariable()
        {
            // Same as the example with an instance variable, but this allows for only a single variable *in the entire program*.
            // Convenient if only a single variable is ever needed, but does not scale for larger programs otherwise.
            // Sometimes called "singleton". Also effectively a "global" variable.
            Person p = new Person { Name = "Angelina Jolie", Age = 43 };
            ClassContainingClassVariable.Person = p;
            ClassContainingClassVariable.DoSomething();
        }

        static void ExampleWithLambdaParameter()
        {
            // Send behavior (not value) from current object/class to other object/class as a lambda parameter.
            // Allows current object/class to provide behavior to other object/class without other object/class needing to know the details of this behavior.
            // In essence, we send a "mini-program" or a "black box" that can be used by the other object/class.
            ClassReceivingLambdaParameter.DoSomething((person, number) => "Something: " + person.Age + number);
        }

        static void ExampleWithObjectParameterContainingMultipleMethods()
        {
            // Similar to example with lambda parameter, except we can now provide multiple behaviors (one for each method in the object parameter).
            // In essence, we send a group of "mini-programs" or "black boxes" to the other object/class.
            ObjectContainingMultipleMethods a = new ObjectContainingMultipleMethods();
            ObjectReceivingObjectParameter b = new ObjectReceivingObjectParameter(a);
        }
    }
}
