using System;

namespace DesignPattern.Creational.FactoryMethod.Sample
{
    /// <summary>
    /// MainApp startup class for Real-World 
    /// Factory Method Design Pattern.
    /// </summary>
    public class Sample:ISample
    {
        /// <summary>
        /// Entry point into console application.
        /// </summary>
        public void Run()
        {
            // Note: constructors call Factory Method
            Document[] documents = new Document[2];

            documents[0] = new Resume();
            documents[1] = new Report();

            // Display document pages
            foreach (var document in documents)
            {
                Console.WriteLine($"\n{document.GetType().Name}--");
                foreach (Page page in document.Pages)
                {
                    Console.WriteLine($" {page.GetType().Name}");
                }
            }
        }
    }
}
