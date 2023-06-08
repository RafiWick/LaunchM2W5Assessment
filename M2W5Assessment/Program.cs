// See https://aka.ms/new-console-template for more information
using M2W5Assessment;

Console.WriteLine("Hello, World!");
using (ConcertContext context = new ConcertContext())
{
    SeedData.SeedConcertsAndPerformers(context);
}