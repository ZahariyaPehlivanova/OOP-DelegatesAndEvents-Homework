using System;
namespace _04.StudentClass
{
    class Program
    {
        static void Main(string[] args)
        {
            var student = new Student("Pesho", 38);

            student.OnPropertyChanged += PropertyHandler;

            student.Name = "Ivan";
            student.Age = 22;

            student.OnPropertyChanged -= PropertyHandler;

            student.OnPropertyChanged += (sender, eventArgs) =>
            {
                Console.WriteLine(
                    "Property changed: {0} (from {1} to {2})",
                    eventArgs.PropertyName,
                    eventArgs.OldValue,
                    eventArgs.NewValue);
            };
            student.Name = "Maria";
            student.Age = 19;
        }

        private static void PropertyHandler(object sender, PropertyChangedEventArgs eventArgs)
        {
            Console.WriteLine(
                "Property changed: {0} (from {1} to {2})",
                eventArgs.PropertyName,
                eventArgs.OldValue,
                eventArgs.NewValue);
        }
    }
}
