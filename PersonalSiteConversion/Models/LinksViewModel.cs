namespace PersonalSiteConversion.Models
{
    public class LinksViewModel

    {
        public int ID { get; set; }
        public string Thumbnail { get; set; } = null!;
        public string Name { get; set; } = null!;        
        public string? Website { get; set; }
        public string LinkedIn { get; set; } = null!;
        public string GitHub { get; set; } = null!;
        
        public static List<LinksViewModel> GetLinks()
        {
            var link1 = new LinksViewModel()
            {
                Name = "Jason Pinkston",                
                ID = 1,
                Thumbnail = "/assets/img/links Photos/Jason Pinkston.jpg",
                Website = "http://jpinkston.com",
                LinkedIn = "http://www.linkedin.com/in/jason-pinkston-48224243/",
                GitHub = "http://github.com/jpinky82"
            };
            var link2 = new LinksViewModel()
            {
                Name = "Tanner Hulett",
                ID = 2,
                Thumbnail = "/assets/img/Links Photos/Tanner_Hulett.png",
                Website = "http://tannerhulett.com",
                LinkedIn = "http://www.linkedin.com/in/tanner-hulett-4a8555264/",
                GitHub = "http://github.com/tannerhulett"
            };
            var link3 = new LinksViewModel()
            {
                Name = "Brodi Shrout",
                ID = 3,
                Thumbnail = "/assets/img/Links Photos/B_Shrout.png",
                Website = "http://www.brodishrout.com/",
                LinkedIn = "http://www.linkedin.com/in/brodi-shrout-8223a8266/",
                GitHub = "http://github.com/BrodiShrout"
            };
            var link4 = new LinksViewModel()
            {
                Name = "Efrain Santiago",
                ID = 4,
                Thumbnail = "/assets/img/Links Photos/Efrain_Santiago.png",
                Website = "http://www.SantiagoEfrain.com",
                LinkedIn = "http://www.linkedin.com/in/efrain-santiago-b373a0268/",
                GitHub = "http://github.com/SantiagoEfrain"
            };
            var link5 = new LinksViewModel()
            {
                Name = "Jared Alcala",
                ID = 5,
                Thumbnail = "/assets/img/Links Photos/Jared_Alcala.png",
                Website = "http://jaredalcala.com",
                LinkedIn = "http://www.linkedin.com/in/jared-alcala-667806260/",
                GitHub = "http://github.com/JaredAlcala"
            };
            var link6 = new LinksViewModel()
            {
                Name = "Steve Rogers",
                ID = 6,
                Thumbnail = "/assets/img/Links Photos/Steve_Rogers.png",
                Website = "http://sdrogers.net",
                LinkedIn = "http://www.linkedin.com/in/steve-rogers-b2427679/",
                GitHub = "http://github.com/SteveRogers1215"
            };
            var link7 = new LinksViewModel()
            {
                Name = "Will March",
                ID = 7,
                Thumbnail = "/assets/img/Links Photos/Will_March.png",
                Website = "http://willmarch.net",
                LinkedIn = "http://www.linkedin.com/in/willmarch",
                GitHub = "http://github.com/willmarch1"
            };
            var link8 = new LinksViewModel()
            {
                Name = "Kellan Campbell",
                ID = 8,
                Thumbnail = "/assets/img/links photos/Kellan_Campbell.png",
                Website = "http://www.kellancampbell.com/",
                LinkedIn = "http://www.linkedin.com/in/kellan-campbell-084227267/",
                GitHub = "https://github.com/KJCampbell"
            };


            return new List<LinksViewModel> { link1, link2, link3, link4, link5, link6, link7, link8 };

            
        }
    }
}
