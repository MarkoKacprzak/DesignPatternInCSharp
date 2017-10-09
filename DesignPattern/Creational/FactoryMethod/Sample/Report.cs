namespace DesignPattern.Creational.FactoryMethod.Sample
{
    /// <summary>
    /// A 'ConcreteCreator' class
    /// </summary>
    public class Report : Document
    {
        // Factory Method implementation
        public override void CreatePages()
        {
            Pages.Add(new IntroductionPage());
            Pages.Add(new ResultsPage());
            Pages.Add(new ConclusionPage());
            Pages.Add(new SummaryPage());
            Pages.Add(new BibliographyPage());
        }
    }
}
