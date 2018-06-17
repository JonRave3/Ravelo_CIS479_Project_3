using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS479_Project3
{
    public enum Biozone { Aerial, Aquatic, Land };
    //origin == region
    public enum Region { Unknown, KikoLake, Maraqua, Mystery_Island, Lutari_Island, Kraik_Island, Roo_Island, Tyrannia, TerrorMoutain,Kredulor, LostDesert, NeopiaCentral, Meridell, FearieLand };
    public enum Habitat { NotListed, Desert, Tropical, Meadows, Urban, Beaches, Oceans, Seas, Islands, Lakes, Forests, Moutains, Jungles, Space, Artic, Tundra, Sky };
    public enum Availability { Special, Rare, Common };
    public enum Kingdom { Mammal, Reptile, Dragon, Insect, Fish, Other, Bird, Alien };
    // Physical Traits
    public enum Sizes { Large, Medium, Small, Unknown };
    public enum WingType { Feathers, Webbed };
    public enum WingSize { Large, Small };
    public enum SnoutType { Beaked, Jawed, Trunked };
    public enum Diet { Unkown, Herbivore, Carnivore, Omnivore };
    public enum LegCount { None=0, Two=2, Four=4};
    public enum LegType { None, Paws, Hooves, Flippers, Other };
    public enum Hair { None, AllOver, Head, Mane, Neck, Back, Tail };
    public enum TailPurpose { Bouncing, Hanging, Navigating, Standing };
    // Personality Traits
    public enum Pers_T { Loyal, Mischevious, Playful, Lazy, Outgoing, Friendly, Shy, Sensitive, Adventureous, Lucky, Ferocious, Peaceful, Magical, Generous, Intelligent, Kind, Competitive, Brave, Courageous, Pacifist, Prissy, Foodie, Quick, Fieri };
    
    public class Phys_T
    {
        public Sizes Size { get; set; }
        public LegType LegType { get; set; }
        public LegCount Legs { get; set; }
        public bool Ears { get; set; }
        public bool Tail { get; set; }
        public TailPurpose? TailPurpose { get; set; }
        public bool Hands { get; set; }
        public bool Allergies { get; set; }
        public bool Strong { get; set; }
        public bool Tusks { get; set; }
        public bool Horns { get; set; }
        public bool Nocturnal { get; set; }
        public List<Hair> Fur { get; set; }
        public bool Clawed { get; set; }
        public WingType? Wing_Type { get; set; }
        public WingSize? Wing_Size { get; set; }
        public SnoutType Snout { get; set; }
        public Diet? Diet { get; set; }
    }

    public class Neopet
    {
        public string Name { get; set; }
        public Biozone Biozone { get; set; }
        public Availability Availability { get; set; }
        public Region Region { get; set; } // 
        public List<Habitat> Habitats { get; set; } //
        public List<Pers_T> Personality_Traits { get; set; }
        public Phys_T Physical_Traits { get; set; }
        public Kingdom Kingdom { get; set; }
        public int CF { get; set; }
    }

}
