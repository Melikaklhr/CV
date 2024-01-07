namespace CVMVC.Models
{
    public class BlogModel
    {
        public BlogModel(int id, string img, string title,  string date, string coment, string author, string text)
        {
            ID = id;
            Img = img;
            Title = title;
            Date = date;
            Coment = coment;
            Author = author;
            Text = text;
        }
        public int ID { get; set; }
        public string Img { get; set; }
        public string Title { get; set; }
        public string Date { get; set; }
        public string  Coment { get; set; }
        public string Text { get; set; }
        public string Author { get; set; }
        

    }
}