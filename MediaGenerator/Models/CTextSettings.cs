namespace MediaGenerator.Models
{
    public class CTextSettings
    {
        string id { get; set; }
        public string textMessage { get; set; }
        public int fontSize { get; set; }
        public string fontFamily { get; set; }

        public List<eFontWeight> fontWeights { get; set; }

        public enum eFontWeight {
            Regular,
            Bold,
            Italic,
            Underlined
        }

        // need to store info like rotation, gradient over time
        // try setting up something in javascript and see how the data looks
    }
}
