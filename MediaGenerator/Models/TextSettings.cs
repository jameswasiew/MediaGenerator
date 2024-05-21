namespace MediaGenerator.Models
{
    public class TextSettings
    {
        public TextSettings() { }

        string id { get; set; } = "";
        public string textMessage { get; set; } = "";
        public int fontSize { get; set; } = 12;
        public string fontFamily { get; set; } = "calibri";
        public string fontColor { get; set; } = "#FFFFFF";

        public List<eFontWeight> fontWeights { get; set; } = new List<eFontWeight>();

        public enum eFontWeight {
            Bold,
            Italic,
            Underlined
        }

        // need to store info like rotation, gradient over time
        // try setting up something in javascript and see how the data looks
    }
}
