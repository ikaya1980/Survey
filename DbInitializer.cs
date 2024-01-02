using Survey.Models;

namespace Survey
{
    internal class DbInitializer
    {
        internal static void Initialize(SurveyDbContext dbContext)
        {
            ArgumentNullException.ThrowIfNull(dbContext, nameof(dbContext));
            dbContext.Database.EnsureCreated();
            if (dbContext.Questions.Count() == 0)
            {
                //Linq içinde Any() kayıt var mı kontrolü yapar true- false döner. 

                List<Question> questions = new List<Question>();
                List<Section> sections = new List<Section>()
            {
                new Section()
                {
                    QuestionNo = 1,
                    SectionNo= 'A',
                    Text="Ankara"
                },
                new Section()
                {
                    QuestionNo = 1,
                    SectionNo= 'B',
                    Text="İstanbul"
                },
                new Section()
                {

                    QuestionNo = 1,
                    SectionNo= 'C',
                    Text="Antalya"
                }
            };

                questions.Add(new Question()
                {
                    QuestionNo = 1,
                    Sections = sections,
                    Text = "Türkyenin Başkenti neresidir?",
                    SectionNo = "A"
                });

                dbContext.Sections.AddRange(sections);
                dbContext.Questions.AddRange(questions);

                dbContext.SaveChanges();
            }
           
        }
    }
}
