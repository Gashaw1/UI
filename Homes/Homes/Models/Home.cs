using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Homes.Models
{
    public class Home
    {
    }
    public class Addresse
    {
        public Addresse()
        {
        }

        string ID { get; set; }
        public string state { get; set; }
        public string city { get; set; }
        public string ZipCode { get; set; }
        public string _date { get; set; }
        public string userID { get; set; }
        public HouseImage HouseImage { get; set; }
        public Description Description { get; set; }

        public static List<Addresse> HouseReturnAll()
        {
            var houses = new List<Addresse>();

            var house = new Addresse();
            house.city = "Atlanta";
            house.state = "Georgia";
            house.ZipCode = "303229";
            house.HouseImage = new HouseImage()
            {
                ImageNmae = "capture22.png"
            };
            house.Description = new Description()
            {
                desctiption = "locatiod in addwethtermod this is locatiod in addwethtermod this is"
            };

            var house2 = new Addresse();
            house2.city = "Brookhaven";
            house2.state = "Georgia";
            house.ZipCode = "32229";
            house2.HouseImage = new HouseImage()
            {
                ImageNmae = "capture23.png"
            };
            house2.Description = new Description()
            {
                desctiption = "This is a good place to live halaf desctipiton sample adndoss"
            };

            houses.Add(house);
            houses.Add(house2);

            return houses;
        }
    }
    
    public class HouseImage
    {
        string ID { get; set; }
        public string ImageNmae { get; set; }
        string House_ID { get; set; }
    }
    public class Description
    {
        string ID { get; set; }
        public string desctiption { get; set; }
        string House_ID { get; set; }
    }
    public class Restriction
    {
        string ID { get; set; }
        public string restriction { get; set; }
        string House_ID { get; set; }

    }
    public class Contact
    {
        string ID { get; set; }
        string Phone { get; set; }
        string Email { get; set; }
        string House_ID { get; set; }

    }
}
