using System.Drawing;


namespace USPMorDOS {
    class Cover {
        public bool USPM { get; set; }
        public Image image { get; set; }
        public string name { get; set; }

        public Cover(bool USPM, Image image, string name) {
            this.USPM = USPM;
            this.image = image;
            this.name = name;
        }
    }
}
