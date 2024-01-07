namespace CVMVC.Models
{
    public class PortfolioModel
    {
     /*public PortfolioModel(int id, string img, string title, string type, string date, string tec, string maker, string description)
        {
            ID = id;
            Img=img;
            Title  = title;
            Type=   type;
            Date=date;
            Tec = tec;
            Maker=maker;
            Description=description;
        }*/
        public int ID { get; set; }
        public string Img { get; set; }
        public string Title { get; set; }
        public string Type { get; set; }
        public string Date { get; set; }
        public string Tec { get; set; }
        public string Maker{ get; set; }
        public string Description { get; set; }
                                     
    }
}
