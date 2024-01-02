namespace Survey.Models
{
    public class Question
    {
        public int Id { get; set; }

        public int QuestionNo { get; set; }

        public string Text { get; set; }

        public IList<Section> Sections { get; set; }

        public string SectionNo { get; set; }
    }


}
