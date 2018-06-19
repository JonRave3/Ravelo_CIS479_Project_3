using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CIS479_Project3
{
    public class Program
    {
        private static List<Neopet> _pets;
        
        static void Main(string[] args)
        {
            try
            {
                ConsoleKeyInfo input;
                init();
                do
                {
                    Run();
                    Console.WriteLine("Press Q to quit or any other to try again.");
                    input = Console.ReadKey();
                } while (input.Key != ConsoleKey.Q);
            }
             catch (Exception e) {
                Console.WriteLine(e.Message);
            }
        }
        static void init()
        {
            _pets = new List<Neopet>() {
                new Neopet()
            {
                Name = "Techo",
                Biozone = Biozone.Land,
                Availability = Availability.Common,
                Habitats = new List<Habitat>() { Habitat.NotListed },
                Region = Region.Unknown,
                Kingdom = Kingdom.Reptile,
                Personality_Traits = new List<Pers_T>() { Pers_T.Playful, Pers_T.Outgoing, Pers_T.Friendly },
                Physical_Traits = new Phys_T()
                {
                    Size = Sizes.Small,
                    Hands = true,
                    LegType = LegType.Paws,
                    Legs = LegCount.Two,
                    Ears = false,
                    Tail = true,
                    TailPurpose = TailPurpose.Standing,
                    Allergies = false,
                    Strong = false,
                    Tusks = false,
                    Horns = false,
                    Nocturnal = false,
                    Fur = new List<Hair> { Hair.None },
                    Clawed = true,
                    Wing_Size = null,
                    Wing_Type = null,
                    Snout = SnoutType.Jawed,
                    Diet = Diet.Unkown
                }
            },
            new Neopet()
            {
                Name = "Korbat",
                Biozone = Biozone.Aerial,
                Availability = Availability.Common,
                Habitats = new List<Habitat>() { Habitat.Moutains, Habitat.Forests },
                Region = Region.Unknown,
                Kingdom = Kingdom.Bird,
                Personality_Traits = new List<Pers_T>() { Pers_T.Playful, Pers_T.Outgoing, Pers_T.Friendly },
                Physical_Traits = new Phys_T()
                {
                    Size = Sizes.Small,
                    Legs = LegCount.Two,
                    LegType = LegType.Paws,
                    Ears = true,
                    Tail = true,
                    Hands = true,
                    Allergies = false,
                    Strong = false,
                    Tusks = false,
                    Horns = false,
                    Nocturnal = true,
                    Fur = new List<Hair> { Hair.None },
                    Clawed = false,
                    Wing_Size = WingSize.Small,
                    Wing_Type = WingType.Webbed,
                    Snout = SnoutType.Jawed,
                    Diet = Diet.Unkown
                }
            }, new Neopet()
            {
                Name = "Jubjub",
                Biozone = Biozone.Land,
                Availability = Availability.Common,
                Habitats = new List<Habitat>() { Habitat.NotListed },
                Region = Region.Unknown,
                Kingdom = Kingdom.Mammal,
                Personality_Traits = new List<Pers_T>() { Pers_T.Playful, Pers_T.Outgoing, Pers_T.Friendly },
                Physical_Traits = new Phys_T()
                {
                    Size = Sizes.Small,
                    Hands = false,
                    LegType = LegType.Paws,
                    Legs = LegCount.Two,
                    Ears = false,
                    Tail = false,
                    Allergies = false,
                    Strong = false,
                    Tusks = false,
                    Horns = false,
                    Nocturnal = false,
                    Fur = new List<Hair> { Hair.Head },
                    Clawed = false,
                    Wing_Size = null,
                    Wing_Type = null,
                    Snout = SnoutType.Jawed,
                    Diet = Diet.Unkown
                }
            }, new Neopet()
            {
                Name = "Tuskaninny",
                Biozone = Biozone.Aquatic,
                Availability = Availability.Common,
                Habitats = new List<Habitat>() { Habitat.Beaches, Habitat.Oceans, Habitat.Seas, Habitat.Islands },
                Region = Region.Unknown,
                Kingdom = Kingdom.Bird,
                Personality_Traits = new List<Pers_T>() { Pers_T.Playful, Pers_T.Outgoing, Pers_T.Friendly },
                Physical_Traits = new Phys_T()
                {
                    Size = Sizes.Unknown,
                    Legs = LegCount.Two,
                    LegType = LegType.Flippers,
                    Ears = false,
                    Tail = true,
                    TailPurpose = TailPurpose.Navigating,
                    Hands = true,
                    Allergies = false,
                    Strong = false,
                    Tusks = false,
                    Horns = false,
                    Nocturnal = false,
                    Fur = new List<Hair> { Hair.Head },
                    Clawed = false,
                    Wing_Size = null,
                    Wing_Type = null,
                    Snout = SnoutType.Jawed,
                    Diet = Diet.Unkown
                }
            }, new Neopet()
            {
                Name = "Zafara",
                Biozone = Biozone.Land,
                Availability = Availability.Common,
                Habitats = new List<Habitat>() { Habitat.Artic, Habitat.Beaches, Habitat.Forests, Habitat.Islands, Habitat.Jungles, Habitat.Meadows, Habitat.Moutains, Habitat.Oceans, Habitat.Seas, Habitat.Sky, Habitat.Space, Habitat.Tropical, Habitat.Tundra, Habitat.Urban },
                Region = Region.Unknown,
                Kingdom = Kingdom.Other,
                Personality_Traits = new List<Pers_T>() { Pers_T.Adventureous, Pers_T.Lucky, },
                Physical_Traits = new Phys_T()
                {
                    Size = Sizes.Large,
                    Hands = true,
                    LegType = LegType.Paws,
                    Legs = LegCount.Two,
                    Ears = true,
                    Tail = true,
                    Allergies = false,
                    Strong = true,
                    Tusks = false,
                    Horns = false,
                    Nocturnal = false,
                    Fur = new List<Hair> { Hair.AllOver },
                    Clawed = false,
                    Wing_Size = WingSize.Large,
                    Wing_Type = WingType.Feathers,
                    Snout = SnoutType.Jawed,
                    Diet = Diet.Unkown
                }
            }, new Neopet()
            {
                Name = "Flotsam",
                Biozone = Biozone.Aquatic,
                Availability = Availability.Common,
                Habitats = new List<Habitat>() { Habitat.Oceans, Habitat.Seas },
                Region = Region.Unknown,
                Kingdom = Kingdom.Fish,
                Personality_Traits = new List<Pers_T>() { Pers_T.Adventureous, Pers_T.Quick },
                Physical_Traits = new Phys_T()
                {
                    Size = Sizes.Small,
                    Legs = LegCount.Two,
                    LegType = LegType.Flippers,
                    Ears = false,
                    Tail = true,
                    TailPurpose = TailPurpose.Navigating,
                    Hands = false,
                    Allergies = false,
                    Strong = false,
                    Tusks = false,
                    Horns = true,
                    Nocturnal = true,
                    Fur = new List<Hair> { Hair.None },
                    Clawed = false,
                    Wing_Size = null,
                    Wing_Type = null,
                    Snout = SnoutType.Jawed,
                    Diet = Diet.Unkown
                }
            },  new Neopet()
            {
                Name = "Blumaroo",
                Biozone = Biozone.Land,
                Availability = Availability.Common,
                Habitats = new List<Habitat>() { Habitat.Islands, Habitat.Tropical, Habitat.Jungles },
                Region = Region.Roo_Island,
                Kingdom = Kingdom.Mammal,
                Personality_Traits = new List<Pers_T>() { Pers_T.Playful, Pers_T.Outgoing, Pers_T.Friendly },
                Physical_Traits = new Phys_T()
                {
                    Size = Sizes.Large,
                    Hands = true,
                    LegType = LegType.Paws,
                    Legs = LegCount.Two,
                    Ears = true,
                    Tail = true,
                    TailPurpose = TailPurpose.Bouncing,
                    Allergies = false,
                    Strong = true,
                    Tusks = false,
                    Horns = false,
                    Nocturnal = false,
                    Fur = new List<Hair> { Hair.Head },
                    Clawed = false,
                    Wing_Size = null,
                    Wing_Type = null,
                    Snout = SnoutType.Jawed,
                    Diet = Diet.Unkown
                }
            }, new Neopet()
            {
                Name = "Xweetok",
                Biozone = Biozone.Land,
                Availability = Availability.Common,
                Habitats = new List<Habitat>() { Habitat.Forests, Habitat.Jungles },
                Region = Region.Unknown,
                Kingdom = Kingdom.Mammal,
                Personality_Traits = new List<Pers_T>() { Pers_T.Quick, Pers_T.Adventureous },
                Physical_Traits = new Phys_T()
                {
                    Size = Sizes.Unknown,
                    Legs = LegCount.Four,
                    LegType = LegType.Paws,
                    Ears = true,
                    Tail = true,
                    Hands = false,
                    Allergies = false,
                    Strong = false,
                    Tusks = false,
                    Horns = false,
                    Nocturnal = false,
                    Fur = new List<Hair> { Hair.AllOver },
                    Clawed = false,
                    Wing_Size = null,
                    Wing_Type = null,
                    Snout = SnoutType.Jawed,
                    Diet = Diet.Unkown
                }
            }, new Neopet() {
                Name = "Grarrl",
                Biozone = Biozone.Land,
                Availability = Availability.Common,
                Habitats = new List<Habitat>() { Habitat.Moutains },
                Region = Region.Tyrannia,
                Kingdom = Kingdom.Reptile,
                Personality_Traits = new List<Pers_T>() { Pers_T.Ferocious },
                Physical_Traits = new Phys_T()
                {
                    Size = Sizes.Large,
                    Legs = LegCount.Two,
                    LegType = LegType.Paws,
                    Strong = true,
                    Ears = false,
                    Snout = SnoutType.Jawed,
                    Hands = true,
                    Tail = true,
                    Allergies = false,
                    Tusks = false,
                    Horns = false,
                    Nocturnal = false,
                    Fur = new List<Hair> { Hair.None },
                    Clawed = true,
                    Wing_Size = null,
                    Wing_Type = null,
                    Diet = Diet.Omnivore
                }
            }, new Neopet()
            {
                Name = "Pteri",
                Biozone = Biozone.Aerial,
                Availability = Availability.Common,
                Habitats = new List<Habitat>() { Habitat.Jungles, Habitat.Forests },
                Region = Region.Tyrannia,
                Kingdom = Kingdom.Bird,
                Personality_Traits = new List<Pers_T>() { Pers_T.Playful, Pers_T.Outgoing, Pers_T.Friendly, Pers_T.Mischevious },
                Physical_Traits = new Phys_T()
                {
                    Size = Sizes.Small,
                    Legs = LegCount.Two,
                    LegType = LegType.Other,
                    Ears = false,
                    Tail = true,
                    Hands = false,
                    Allergies = false,
                    Strong = false,
                    Tusks = false,
                    Horns = false,
                    Nocturnal = false,
                    Fur = new List<Hair> { Hair.None },
                    Clawed = true,
                    Wing_Size = WingSize.Small,
                    Wing_Type = WingType.Feathers,
                    Snout = SnoutType.Beaked,
                    Diet = Diet.Unkown
                }
            }, new Neopet()
            {
                Name = "Nimmo",
                Biozone = Biozone.Aquatic,
                Availability = Availability.Common,
                Habitats = new List<Habitat>() { Habitat.Oceans, Habitat.Seas, Habitat.Islands, Habitat.Beaches, Habitat.Lakes },
                Region = Region.Unknown,
                Kingdom = Kingdom.Reptile,
                Personality_Traits = new List<Pers_T>() { Pers_T.Intelligent, Pers_T.Peaceful, Pers_T.Pacifist, Pers_T.Loyal, Pers_T.Quick },
                Physical_Traits = new Phys_T()
                {
                    Size = Sizes.Small,
                    Hands = false,
                    LegType = LegType.Paws,
                    Legs = LegCount.Four,
                    Ears = false,
                    Tail = false,
                    Allergies = false,
                    Strong = false,
                    Tusks = false,
                    Horns = false,
                    Nocturnal = false,
                    Fur = new List<Hair> { Hair.None },
                    Clawed = false,
                    Wing_Size = null,
                    Wing_Type = null,
                    Snout = SnoutType.Jawed,
                    Diet = Diet.Unkown
                }
            }, new Neopet()
            {
                Name = "Aisha",
                Biozone = Biozone.Land,
                Availability = Availability.Common,
                Habitats = new List<Habitat>() { Habitat.NotListed },
                Region = Region.NeopiaCentral,
                Kingdom = Kingdom.Other,
                Personality_Traits = new List<Pers_T>() { Pers_T.Magical },
                Physical_Traits = new Phys_T()
                {
                    Size = Sizes.Small,
                    Legs = LegCount.Four,
                    LegType = LegType.Other,
                    Ears = true,
                    Tail = true,
                    Hands = false,
                    Allergies = false,
                    Strong = false,
                    Tusks = false,
                    Horns = false,
                    Nocturnal = false,
                    Fur = new List<Hair> { Hair.None },
                    Clawed = false,
                    Wing_Size = null,
                    Wing_Type = null,
                    Snout = SnoutType.Jawed,
                    Diet = Diet.Unkown
                }
            }, new Neopet()
            {
                Name = "Meercas",
                Biozone = Biozone.Land,
                Availability = Availability.Common,
                Habitats = new List<Habitat>() { Habitat.Artic, Habitat.Beaches, Habitat.Forests, Habitat.Islands, Habitat.Jungles, Habitat.Meadows, Habitat.Moutains, Habitat.Tropical, Habitat.Tundra, Habitat.Urban },
                Region = Region.Unknown,
                Kingdom = Kingdom.Mammal,
                Personality_Traits = new List<Pers_T>() { Pers_T.Mischevious, Pers_T.Playful, Pers_T.Quick },
                Physical_Traits = new Phys_T()
                {
                    Size = Sizes.Small,
                    Hands = true,
                    LegType = LegType.Paws,
                    Legs = LegCount.Two,
                    Ears = true,
                    Tail = true,
                    TailPurpose = TailPurpose.Standing,
                    Allergies = false,
                    Strong = false,
                    Tusks = false,
                    Horns = false,
                    Nocturnal = false,
                    Fur = new List<Hair> { Hair.AllOver },
                    Clawed = false,
                    Wing_Size = null,
                    Wing_Type = null,
                    Snout = SnoutType.Jawed,
                    Diet = Diet.Omnivore
                }
            }, new Neopet()
            {
                Name = "Usul",
                Biozone = Biozone.Land,
                Availability = Availability.Common,
                Habitats = new List<Habitat>() { Habitat.Forests, Habitat.Jungles },
                Region = Region.Unknown,
                Kingdom = Kingdom.Mammal,
                Personality_Traits = new List<Pers_T>() { Pers_T.Loyal, Pers_T.Generous, Pers_T.Friendly, Pers_T.Outgoing },
                Physical_Traits = new Phys_T()
                {
                    Size = Sizes.Small,
                    Legs = LegCount.Two,
                    LegType = LegType.Paws,
                    Ears = true,
                    Tail = true,
                    Hands = true,
                    Allergies = false,
                    Strong = false,
                    Tusks = false,
                    Horns = true,
                    Nocturnal = true,
                    Fur = new List<Hair> { Hair.AllOver },
                    Clawed = false,
                    Wing_Size = null,
                    Wing_Type = null,
                    Snout = SnoutType.Jawed,
                    Diet = Diet.Unkown
                }
            }, new Neopet()
            {
                Name = "Scorchio",
                Biozone = Biozone.Aerial,
                Availability = Availability.Common,
                Habitats = new List<Habitat>() { Habitat.Urban },
                Region = Region.NeopiaCentral,
                Kingdom = Kingdom.Dragon,
                Personality_Traits = new List<Pers_T>() { Pers_T.Friendly, Pers_T.Outgoing },
                Physical_Traits = new Phys_T()
                {
                    Size = Sizes.Large,
                    Hands = true,
                    LegType = LegType.Paws,
                    Legs = LegCount.Two,
                    Ears = false,
                    Tail = true,
                    Allergies = false,
                    Strong = true,
                    Tusks = false,
                    Horns = false,
                    Nocturnal = false,
                    Fur = new List<Hair> { Hair.None },
                    Clawed = true,
                    Wing_Size = WingSize.Large,
                    Wing_Type = WingType.Webbed,
                    Snout = SnoutType.Jawed,
                    Diet = Diet.Unkown
                }
            }, new Neopet()
            {
                Name = "Ogrin",
                Biozone = Biozone.Land,
                Availability = Availability.Common,
                Habitats = new List<Habitat>() { Habitat.NotListed },
                Region = Region.Unknown,
                Kingdom = Kingdom.Mammal,
                Personality_Traits = new List<Pers_T>() { Pers_T.Shy, Pers_T.Intelligent },
                Physical_Traits = new Phys_T()
                {
                    Size = Sizes.Unknown,
                    Legs = LegCount.Four,
                    LegType = LegType.Hooves,
                    Ears = true,
                    Tail = true,
                    Hands = false,
                    Allergies = false,
                    Strong = false,
                    Tusks = false,
                    Horns = false,
                    Nocturnal = false,
                    Fur = new List<Hair> { Hair.AllOver },
                    Clawed = false,
                    Wing_Size = null,
                    Wing_Type = null,
                    Snout = SnoutType.Jawed,
                    Diet = Diet.Carnivore
                }
            },
            // Start Gnorbu
            new Neopet()
            {
                Name = "Gnorbu",
                Biozone = Biozone.Land,
                Availability = Availability.Common,
                Habitats = new List<Habitat>() { Habitat.NotListed },
                Region = Region.Unknown,
                Kingdom = Kingdom.Mammal,
                Personality_Traits = new List<Pers_T>() { Pers_T.Playful, Pers_T.Outgoing, Pers_T.Friendly, Pers_T.Kind },
                Physical_Traits = new Phys_T()
                {
                    Size = Sizes.Small,
                    Hands = false,
                    LegType = LegType.Paws,
                    Legs = LegCount.Four,
                    Ears = true,
                    Tail = true,
                    Allergies = false,
                    Strong = false,
                    Tusks = false,
                    Horns = false,
                    Nocturnal = false,
                    Fur = new List<Hair> { Hair.Mane, Hair.Tail },
                    Clawed = false,
                    Wing_Size = null,
                    Wing_Type = null,
                    Snout = SnoutType.Jawed,
                    Diet = Diet.Unkown
                }
            },
            new Neopet()
            {
                Name = "Peophin",
                Biozone = Biozone.Aquatic,
                Availability = Availability.Common,
                Habitats = new List<Habitat>() { Habitat.Oceans, Habitat.Seas, Habitat.Lakes },
                Region = Region.Unknown,
                Kingdom = Kingdom.Other,
                Personality_Traits = new List<Pers_T>() { Pers_T.Shy, Pers_T.Lucky, Pers_T.Magical },
                Physical_Traits = new Phys_T()
                {
                    Size = Sizes.Small,
                    Legs = LegCount.Two,
                    LegType = LegType.Hooves,
                    Ears = true,
                    Tail = true,
                    TailPurpose = TailPurpose.Navigating,
                    Hands = true,
                    Allergies = false,
                    Strong = false,
                    Tusks = false,
                    Horns = false,
                    Nocturnal = true,
                    Fur = new List<Hair> { Hair.Mane },
                    Clawed = false,
                    Wing_Size = null,
                    Wing_Type = null,
                    Snout = SnoutType.Jawed,
                    Diet = Diet.Unkown
                }
            }, new Neopet()
            {
                Name = "Lupe",
                Biozone = Biozone.Land,
                Availability = Availability.Common,
                Habitats = new List<Habitat>() { Habitat.NotListed },
                Region = Region.Unknown,
                Kingdom = Kingdom.Mammal,
                Personality_Traits = new List<Pers_T>() { Pers_T.Brave, Pers_T.Loyal },
                Physical_Traits = new Phys_T()
                {
                    Size = Sizes.Medium,
                    Hands = false,
                    LegType = LegType.Paws,
                    Legs = LegCount.Four,
                    Ears = true,
                    Tail = true,
                    Allergies = false,
                    Strong = false,
                    Tusks = false,
                    Horns = false,
                    Nocturnal = false,
                    Fur = new List<Hair> { Hair.AllOver },
                    Clawed = false,
                    Wing_Size = null,
                    Wing_Type = null,
                    Snout = SnoutType.Jawed,
                    Diet = Diet.Unkown
                }
            },
                new Neopet()
                {
                    Name = "Yurble",
                    Biozone = Biozone.Land,
                    Availability = Availability.Common,
                    Habitats = new List<Habitat>() { Habitat.Forests },
                    Region = Region.Unknown,
                    Kingdom = Kingdom.Mammal,
                    Personality_Traits = new List<Pers_T>() { Pers_T.Outgoing, Pers_T.Foodie },
                    Physical_Traits = new Phys_T()
                    {
                        Size = Sizes.Unknown,
                        Legs = LegCount.Two,
                        LegType = LegType.Paws,
                        Ears = true,
                        Tail = true,
                        Hands = true,
                        Allergies = false,
                        Strong = false,
                        Tusks = false,
                        Horns = false,
                        Nocturnal = false,
                        Fur = new List<Hair> { Hair.Head, Hair.Neck, Hair.Back },
                        Clawed = true,
                        Wing_Size = null,
                        Wing_Type = null,
                        Snout = SnoutType.Jawed,
                        Diet = Diet.Omnivore
                    }
                },
                new Neopet()
                {
                    Name = "Skeith",
                    Biozone = Biozone.Aerial,
                    Availability = Availability.Common,
                    Habitats = new List<Habitat>() { Habitat.Urban },
                    Region = Region.NeopiaCentral,
                    Kingdom = Kingdom.Dragon,
                    Personality_Traits = new List<Pers_T>() { Pers_T.Foodie, Pers_T.Lazy },
                    Physical_Traits = new Phys_T()
                    {
                        Size = Sizes.Large,
                        Hands = true,
                        LegType = LegType.Paws,
                        Legs = LegCount.Two,
                        Ears = true,
                        Tail = true,
                        Allergies = true,
                        Strong = true,
                        Tusks = false,
                        Horns = false,
                        Nocturnal = false,
                        Fur = new List<Hair> { Hair.None },
                        Clawed = true,
                        Wing_Size = WingSize.Small,
                        Wing_Type = WingType.Webbed,
                        Snout = SnoutType.Jawed,
                        Diet = Diet.Unkown
                    }
                },
                new Neopet()
                {
                    Name = "Bruce",
                    Biozone = Biozone.Land,
                    Availability = Availability.Common,
                    Habitats = new List<Habitat>() { Habitat.Moutains, Habitat.Artic, Habitat.Tundra },
                    Region = Region.TerrorMoutain,
                    Kingdom = Kingdom.Bird,
                    Personality_Traits = new List<Pers_T>() { Pers_T.Playful, Pers_T.Competitive },
                    Physical_Traits = new Phys_T()
                    {
                        Size = Sizes.Medium,
                        Legs = LegCount.Two,
                        LegType = LegType.Paws,
                        Ears = false,
                        Tail = true,
                        Hands = true,
                        Allergies = false,
                        Strong = false,
                        Tusks = false,
                        Horns = true,
                        Nocturnal = true,
                        Fur = new List<Hair> { Hair.None },
                        Clawed = false,
                        Wing_Size = null,
                        Wing_Type = null,
                        Snout = SnoutType.Beaked,
                        Diet = Diet.Unkown
                    }
                },
                new Neopet()
                {
                    Name = "Eyrie",
                    Biozone = Biozone.Aerial,
                    Availability = Availability.Common,
                    Habitats = new List<Habitat>() { Habitat.Islands, Habitat.Tropical },
                    Region = Region.Mystery_Island,
                    Kingdom = Kingdom.Other,
                    Personality_Traits = new List<Pers_T>() { Pers_T.Intelligent, Pers_T.Adventureous, Pers_T.Playful, Pers_T.Ferocious },
                    Physical_Traits = new Phys_T()
                    {
                        Size = Sizes.Large,
                        Hands = false,
                        LegType = LegType.Paws,
                        Legs = LegCount.Four,
                        Ears = true,
                        Tail = true,
                        Allergies = false,
                        Strong = true,
                        Tusks = false,
                        Horns = false,
                        Nocturnal = false,
                        Fur = new List<Hair> { Hair.Mane, Hair.Tail },
                        Clawed = false,
                        Wing_Size = WingSize.Large,
                        Wing_Type = WingType.Feathers,
                        Snout = SnoutType.Beaked,
                        Diet = Diet.Unkown
                    }
                },
                new Neopet()
                {
                    Name = "Buzz",
                    Biozone = Biozone.Land,
                    Availability = Availability.Common,
                    Habitats = new List<Habitat>() { Habitat.NotListed },
                    Region = Region.Unknown,
                    Kingdom = Kingdom.Insect,
                    Personality_Traits = new List<Pers_T>() { Pers_T.Quick, Pers_T.Foodie },
                    Physical_Traits = new Phys_T()
                    {
                        Size = Sizes.Small,
                        Legs = LegCount.Two,
                        LegType = LegType.Other,
                        Ears = false,
                        Tail = true,
                        Hands = true,
                        Allergies = false,
                        Strong = false,
                        Tusks = false,
                        Horns = false,
                        Nocturnal = false,
                        Fur = new List<Hair> { Hair.None },
                        Clawed = false,
                        Wing_Size = WingSize.Small,
                        Wing_Type = WingType.Webbed,
                        Snout = SnoutType.Jawed,
                        Diet = Diet.Herbivore
                    }
                },
                new Neopet()
                {
                    Name = "Gelert",
                    Biozone = Biozone.Land,
                    Availability = Availability.Common,
                    Habitats = new List<Habitat>() { Habitat.NotListed },
                    Region = Region.Unknown,
                    Kingdom = Kingdom.Mammal,
                    Personality_Traits = new List<Pers_T>() { Pers_T.Loyal, Pers_T.Brave, Pers_T.Courageous },
                    Physical_Traits = new Phys_T()
                    {
                        Size = Sizes.Small,
                        Legs = LegCount.Four,
                        LegType = LegType.Paws,
                        Strong = false,
                        Ears = true,
                        Snout = SnoutType.Jawed,
                        Hands = false,
                        Tail = true,
                        Allergies = false,
                        Tusks = false,
                        Horns = false,
                        Nocturnal = false,
                        Fur = new List<Hair> { Hair.Head },
                        Clawed = false,
                        Wing_Size = null,
                        Wing_Type = null,
                        Diet = Diet.Unkown
                    }
                },
                new Neopet()
                {
                    Name = "Kacheek",
                    Biozone = Biozone.Land,
                    Availability = Availability.Common,
                    Habitats = new List<Habitat>() { Habitat.Meadows },
                    Region = Region.Unknown,
                    Kingdom = Kingdom.Mammal,
                    Personality_Traits = new List<Pers_T>() { Pers_T.Shy, Pers_T.Friendly, Pers_T.Pacifist, Pers_T.Peaceful },
                    Physical_Traits = new Phys_T()
                    {
                        Size = Sizes.Small,
                        Legs = LegCount.Two,
                        LegType = LegType.Paws,
                        Ears = true,
                        Tail = true,
                        Hands = true,
                        Allergies = false,
                        Strong = false,
                        Tusks = false,
                        Horns = false,
                        Nocturnal = false,
                        Fur = new List<Hair> { Hair.AllOver },
                        Clawed = false,
                        Wing_Size = null,
                        Wing_Type = null,
                        Snout = SnoutType.Jawed,
                        Diet = Diet.Unkown
                    }
                },
                new Neopet()
                {
                    Name = "Ixi",
                    Biozone = Biozone.Land,
                    Availability = Availability.Common,
                    Habitats = new List<Habitat>() { Habitat.Urban },
                    Region = Region.Meridell,
                    Kingdom = Kingdom.Mammal,
                    Personality_Traits = new List<Pers_T>() { Pers_T.Adventureous },
                    Physical_Traits = new Phys_T()
                    {
                        Size = Sizes.Medium,
                        Hands = false,
                        LegType = LegType.Hooves,
                        Legs = LegCount.Four,
                        Ears = true,
                        Tail = true,
                        Allergies = false,
                        Strong = false,
                        Tusks = false,
                        Horns = true,
                        Nocturnal = false,
                        Fur = new List<Hair> { Hair.AllOver },
                        Clawed = false,
                        Wing_Size = null,
                        Wing_Type = null,
                        Snout = SnoutType.Jawed,
                        Diet = Diet.Unkown
                    }
                },
                new Neopet()
                {
                    Name = "Acara",
                    Biozone = Biozone.Aquatic,
                    Availability = Availability.Common,
                    Habitats = new List<Habitat>() { Habitat.Urban, Habitat.Beaches },
                    Region = Region.NeopiaCentral,
                    Kingdom = Kingdom.Mammal,
                    Personality_Traits = new List<Pers_T>() { Pers_T.Playful },
                    Physical_Traits = new Phys_T()
                    {
                        Size = Sizes.Small,
                        Legs = LegCount.Four,
                        LegType = LegType.Other,
                        Ears = true,
                        Tail = false,
                        Hands = false,
                        Allergies = false,
                        Strong = false,
                        Tusks = false,
                        Horns = true,
                        Nocturnal = false,
                        Fur = new List<Hair> { Hair.AllOver },
                        Clawed = false,
                        Wing_Size = null,
                        Wing_Type = null,
                        Snout = SnoutType.Jawed,
                        Diet = Diet.Unkown
                    }
                },
                new Neopet()
                {
                    Name = "Moehog",
                    Biozone = Biozone.Land,
                    Availability = Availability.Common,
                    Habitats = new List<Habitat>() { Habitat.Moutains },
                    Region = Region.Unknown,
                    Kingdom = Kingdom.Mammal,
                    Personality_Traits = new List<Pers_T>() { Pers_T.Competitive, Pers_T.Playful },
                    Physical_Traits = new Phys_T()
                    {
                        Size = Sizes.Large,
                        Hands = false,
                        LegType = LegType.Hooves,
                        Legs = LegCount.Four,
                        Ears = true,
                        Tail = true,
                        Allergies = false,
                        Strong = false,
                        Tusks = true,
                        Horns = false,
                        Nocturnal = false,
                        Fur = new List<Hair> { Hair.Mane, Hair.Tail },
                        Clawed = false,
                        Wing_Size = null,
                        Wing_Type = null,
                        Snout = SnoutType.Jawed,
                        Diet = Diet.Unkown
                    }
                },
                new Neopet()
                {
                    Name = "Quiggle",
                    Biozone = Biozone.Land,
                    Availability = Availability.Common,
                    Habitats = new List<Habitat>() { Habitat.Lakes },
                    Region = Region.Unknown,
                    Kingdom = Kingdom.Reptile,
                    Personality_Traits = new List<Pers_T>() { Pers_T.Playful, Pers_T.Foodie },
                    Physical_Traits = new Phys_T()
                    {
                        Size = Sizes.Small,
                        Legs = LegCount.Two,
                        LegType = LegType.Other,
                        Ears = false,
                        Tail = false,
                        Hands = true,
                        Allergies = true,
                        Strong = false,
                        Tusks = false,
                        Horns = false,
                        Nocturnal = true,
                        Fur = new List<Hair> { Hair.None },
                        Clawed = false,
                        Wing_Size = null,
                        Wing_Type = null,
                        Snout = SnoutType.Jawed,
                        Diet = Diet.Herbivore
                    }
                },
                new Neopet()
                {
                    Name = "Chia",
                    Biozone = Biozone.Land,
                    Availability = Availability.Common,
                    Habitats = new List<Habitat>() { Habitat.NotListed },
                    Region = Region.Unknown,
                    Kingdom = Kingdom.Other,
                    Personality_Traits = new List<Pers_T>() { Pers_T.Friendly, Pers_T.Outgoing, Pers_T.Adventureous },
                    Physical_Traits = new Phys_T()
                    {
                        Size = Sizes.Medium,
                        Hands = true,
                        LegType = LegType.Paws,
                        Legs = LegCount.Two,
                        Ears = false,
                        Tail = false,
                        Allergies = false,
                        Strong = false,
                        Tusks = false,
                        Horns = false,
                        Nocturnal = false,
                        Fur = new List<Hair> { Hair.Head },
                        Clawed = false,
                        Wing_Size = null,
                        Wing_Type = null,
                        Snout = SnoutType.Jawed,
                        Diet = Diet.Unkown
                    }
                },
                new Neopet()
                {
                    Name = "Kyrii",
                    Biozone = Biozone.Land,
                    Availability = Availability.Common,
                    Habitats = new List<Habitat>() { Habitat.NotListed },
                    Region = Region.Unknown,
                    Kingdom = Kingdom.Mammal,
                    Personality_Traits = new List<Pers_T>() { Pers_T.Outgoing, Pers_T.Friendly, Pers_T.Ferocious },
                    Physical_Traits = new Phys_T()
                    {
                        Size = Sizes.Small,
                        Legs = LegCount.Two,
                        LegType = LegType.Paws,
                        Ears = true,
                        Tail = true,
                        Hands = true,
                        Allergies = true,
                        Strong = false,
                        Tusks = false,
                        Horns = false,
                        Nocturnal = false,
                        Fur = new List<Hair> { Hair.Head, Hair.Neck, Hair.Back, Hair.Tail },
                        Clawed = false,
                        Wing_Size = null,
                        Wing_Type = null,
                        Snout = SnoutType.Jawed,
                        Diet = Diet.Carnivore
                    }
                },
                //Start Bori
                new Neopet()
                {
                    Name = "Bori",
                    Biozone = Biozone.Land,
                    Availability = Availability.Common,
                    Habitats = new List<Habitat>() { Habitat.Moutains },
                    Region = Region.TerrorMoutain,
                    Kingdom = Kingdom.Mammal,
                    Personality_Traits = new List<Pers_T>() { Pers_T.Shy },
                    Physical_Traits = new Phys_T()
                    {
                        Size = Sizes.Small,
                        Hands = false,
                        LegType = LegType.Paws,
                        Legs = LegCount.Four,
                        Ears = true,
                        Tail = true,
                        Allergies = false,
                        Strong = false,
                        Tusks = false,
                        Horns = false,
                        Nocturnal = false,
                        Fur = new List<Hair> { Hair.AllOver },
                        Clawed = true,
                        Wing_Size = null,
                        Wing_Type = null,
                        Snout = SnoutType.Jawed,
                        Diet = Diet.Unkown
                    }
                },
                new Neopet()
                {
                    Name = "Lenny",
                    Biozone = Biozone.Aerial,
                    Availability = Availability.Common,
                    Habitats = new List<Habitat>() { Habitat.NotListed },
                    Region = Region.Unknown,
                    Kingdom = Kingdom.Bird,
                    Personality_Traits = new List<Pers_T>() { Pers_T.Magical, Pers_T.Intelligent },
                    Physical_Traits = new Phys_T()
                    {
                        Size = Sizes.Medium,
                        Legs = LegCount.Two,
                        LegType = LegType.Other,
                        Ears = false,
                        Tail = true,
                        Hands = false,
                        Allergies = false,
                        Strong = false,
                        Tusks = false,
                        Horns = false,
                        Nocturnal = false,
                        Fur = new List<Hair> { Hair.None },
                        Clawed = false,
                        Wing_Size = WingSize.Large,
                        Wing_Type = WingType.Feathers,
                        Snout = SnoutType.Beaked,
                        Diet = Diet.Unkown
                    }
                },
                new Neopet()
                {
                    Name = "Kau",
                    Biozone = Biozone.Land,
                    Availability = Availability.Common,
                    Habitats = new List<Habitat>() { Habitat.Meadows },
                    Region = Region.Unknown,
                    Kingdom = Kingdom.Mammal,
                    Personality_Traits = new List<Pers_T>() { Pers_T.Adventureous, Pers_T.Lucky },
                    Physical_Traits = new Phys_T()
                    {
                        Size = Sizes.Medium,
                        Hands = false,
                        LegType = LegType.Hooves,
                        Legs = LegCount.Four,
                        Ears = true,
                        Tail = true,
                        Allergies = false,
                        Strong = false,
                        Tusks = false,
                        Horns = true,
                        Nocturnal = false,
                        Fur = new List<Hair> { Hair.AllOver },
                        Clawed = false,
                        Wing_Size = null,
                        Wing_Type = null,
                        Snout = SnoutType.Jawed,
                        Diet = Diet.Unkown
                    }
                },
                new Neopet()
                {
                    Name = "Vandagyre",
                    Biozone = Biozone.Aerial,
                    Availability = Availability.Common,
                    Habitats = new List<Habitat>() { Habitat.Moutains },
                    Region = Region.Unknown,
                    Kingdom = Kingdom.Bird,
                    Personality_Traits = new List<Pers_T>() { Pers_T.Playful, Pers_T.Outgoing, Pers_T.Friendly, Pers_T.Kind },
                    Physical_Traits = new Phys_T()
                    {
                        Size = Sizes.Unknown,
                        Legs = LegCount.Two,
                        LegType = LegType.Paws,
                        Ears = false,
                        Tail = true,
                        TailPurpose = TailPurpose.Navigating,
                        Hands = true,
                        Allergies = false,
                        Strong = false,
                        Tusks = false,
                        Horns = false,
                        Nocturnal = false,
                        Fur = new List<Hair> { Hair.Head },
                        Clawed = false,
                        Wing_Size = WingSize.Large,
                        Wing_Type = WingType.Feathers,
                        Snout = SnoutType.Beaked,
                        Diet = Diet.Unkown
                    }
                },
                new Neopet()
                {
                    Name = "Uni",
                    Biozone = Biozone.Aerial,
                    Availability = Availability.Common,
                    Habitats = new List<Habitat>() { Habitat.Artic, Habitat.Beaches, Habitat.Forests, Habitat.Islands, Habitat.Jungles, Habitat.Meadows, Habitat.Moutains, Habitat.Oceans, Habitat.Seas, Habitat.Sky, Habitat.Space, Habitat.Tropical, Habitat.Tundra, Habitat.Urban },
                    Region = Region.Unknown,
                    Kingdom = Kingdom.Mammal,
                    Personality_Traits = new List<Pers_T>() { Pers_T.Prissy, Pers_T.Intelligent },
                    Physical_Traits = new Phys_T()
                    {
                        Size = Sizes.Large,
                        Hands = false,
                        LegType = LegType.Hooves,
                        Legs = LegCount.Four,
                        Ears = true,
                        Tail = true,
                        Allergies = false,
                        Strong = true,
                        Tusks = false,
                        Horns = true,
                        Nocturnal = false,
                        Fur = new List<Hair> { Hair.AllOver },
                        Clawed = false,
                        Wing_Size = WingSize.Small,
                        Wing_Type = WingType.Feathers,
                        Snout = SnoutType.Jawed,
                        Diet = Diet.Unkown
                    }
                },
                new Neopet()
                {
                    Name = "Elephante",
                    Biozone = Biozone.Land,
                    Availability = Availability.Common,
                    Habitats = new List<Habitat>() { Habitat.Oceans, Habitat.Seas },
                    Region = Region.Unknown,
                    Kingdom = Kingdom.Mammal,
                    Personality_Traits = new List<Pers_T>() { Pers_T.Adventureous, Pers_T.Quick },
                    Physical_Traits = new Phys_T()
                    {
                        Size = Sizes.Small,
                        Legs = LegCount.Two,
                        LegType = LegType.Hooves,
                        Ears = true,
                        Tail = true,
                        Hands = true,
                        Allergies = false,
                        Strong = false,
                        Tusks = true,
                        Horns = true,
                        Nocturnal = true,
                        Fur = new List<Hair> { Hair.Tail },
                        Clawed = false,
                        Wing_Size = WingSize.Small,
                        Wing_Type = WingType.Feathers,
                        Snout = SnoutType.Jawed,
                        Diet = Diet.Unkown
                    }
                },
                new Neopet()
                {
                    Name = "Wocky",
                    Biozone = Biozone.Land,
                    Availability = Availability.Common,
                    Habitats = new List<Habitat>() { Habitat.NotListed },
                    Region = Region.Unknown,
                    Kingdom = Kingdom.Mammal,
                    Personality_Traits = new List<Pers_T>() { Pers_T.Adventureous, Pers_T.Brave },
                    Physical_Traits = new Phys_T()
                    {
                        Size = Sizes.Unknown,
                        Hands = false,
                        LegType = LegType.Paws,
                        Legs = LegCount.Four,
                        Ears = true,
                        Tail = true,
                        Allergies = false,
                        Strong = false,
                        Tusks = false,
                        Horns = false,
                        Nocturnal = false,
                        Fur = new List<Hair> { Hair.AllOver },
                        Clawed = false,
                        Wing_Size = null,
                        Wing_Type = null,
                        Snout = SnoutType.Jawed,
                        Diet = Diet.Unkown
                    }
                },
                new Neopet()
                {
                    Name = "Shoyru",
                    Biozone = Biozone.Aerial,
                    Availability = Availability.Common,
                    Habitats = new List<Habitat>() { Habitat.Urban },
                    Region = Region.NeopiaCentral,
                    Kingdom = Kingdom.Dragon,
                    Personality_Traits = new List<Pers_T>() { Pers_T.Loyal, Pers_T.Fieri },
                    Physical_Traits = new Phys_T()
                    {
                        Size = Sizes.Small,
                        Legs = LegCount.Two,
                        LegType = LegType.Paws,
                        Ears = true,
                        Tail = true,
                        Hands = true,
                        Allergies = false,
                        Strong = false,
                        Tusks = false,
                        Horns = true,
                        Nocturnal = false,
                        Fur = new List<Hair> { Hair.None },
                        Clawed = false,
                        Wing_Size = WingSize.Large,
                        Wing_Type = WingType.Webbed,
                        Snout = SnoutType.Jawed,
                        Diet = Diet.Unkown
                    }
                },
                new Neopet()
                {
                    Name = "Kougra",
                    Biozone = Biozone.Land,
                    Availability = Availability.Common,
                    Habitats = new List<Habitat>() { Habitat.Islands },
                    Region = Region.Mystery_Island,
                    Kingdom = Kingdom.Mammal,
                    Personality_Traits = new List<Pers_T>() { Pers_T.Friendly, Pers_T.Playful },
                    Physical_Traits = new Phys_T()
                    {
                        Size = Sizes.Medium,
                        Legs = LegCount.Four,
                        LegType = LegType.Paws,
                        Strong = false,
                        Ears = true,
                        Snout = SnoutType.Jawed,
                        Hands = false,
                        Tail = true,
                        Allergies = false,
                        Tusks = false,
                        Horns = false,
                        Nocturnal = false,
                        Fur = new List<Hair> { Hair.AllOver },
                        Clawed = false,
                        Wing_Size = null,
                        Wing_Type = null,
                        Diet = Diet.Unkown,
                    }
                },
                new Neopet()
                {
                    Name = "Mynci",
                    Biozone = Biozone.Land,
                    Availability = Availability.Common,
                    Habitats = new List<Habitat>() { Habitat.Jungles, Habitat.Forests, Habitat.Islands },
                    Region = Region.Mystery_Island,
                    Kingdom = Kingdom.Mammal,
                    Personality_Traits = new List<Pers_T>() { Pers_T.Playful, Pers_T.Friendly, Pers_T.Mischevious },
                    Physical_Traits = new Phys_T()
                    {
                        Size = Sizes.Large,
                        Legs = LegCount.Two,
                        LegType = LegType.Paws,
                        Ears = true,
                        Tail = true,
                        TailPurpose = TailPurpose.Hanging,
                        Hands = true,
                        Allergies = false,
                        Strong = true,
                        Tusks = false,
                        Horns = false,
                        Nocturnal = false,
                        Fur = new List<Hair> { Hair.AllOver },
                        Clawed = false,
                        Wing_Size = null,
                        Wing_Type = null,
                        Snout = SnoutType.Jawed,
                        Diet = Diet.Unkown
                    }
                },
                new Neopet()
                {
                    Name = "Chomby",
                    Biozone = Biozone.Land,
                    Availability = Availability.Special,
                    Habitats = new List<Habitat>() { Habitat.Meadows },
                    Region = Region.Unknown,
                    Kingdom = Kingdom.Reptile,
                    Personality_Traits = new List<Pers_T>() { Pers_T.Shy },
                    Physical_Traits = new Phys_T()
                    {
                        Size = Sizes.Medium,
                        Hands = false,
                        LegType = LegType.Other,
                        Legs = LegCount.Four,
                        Ears = false,
                        Tail = true,
                        Allergies = false,
                        Strong = false,
                        Tusks = false,
                        Horns = false,
                        Nocturnal = false,
                        Fur = new List<Hair> { Hair.None },
                        Clawed = false,
                        Wing_Size = null,
                        Wing_Type = null,
                        Snout = SnoutType.Jawed,
                        Diet = Diet.Herbivore
                    }
                },
                new Neopet()
                {
                    Name = "Cybunny",
                    Biozone = Biozone.Land,
                    Availability = Availability.Special,
                    Habitats = new List<Habitat>() { Habitat.Artic, Habitat.Tundra },
                    Region = Region.TerrorMoutain,
                    Kingdom = Kingdom.Mammal,
                    Personality_Traits = new List<Pers_T>() { Pers_T.Playful, Pers_T.Friendly },
                    Physical_Traits = new Phys_T()
                    {
                        Size = Sizes.Small,
                        Legs = LegCount.Four,
                        LegType = LegType.Paws,
                        Ears = true,
                        Tail = true,
                        Hands = false,
                        Allergies = false,
                        Strong = false,
                        Tusks = false,
                        Horns = false,
                        Nocturnal = false,
                        Fur = new List<Hair> { Hair.AllOver },
                        Clawed = false,
                        Wing_Size = null,
                        Wing_Type = null,
                        Snout = SnoutType.Jawed,
                        Diet = Diet.Unkown
                    }
                },
                new Neopet()
                {
                    Name = "Grundo",
                    Biozone = Biozone.Land,
                    Availability = Availability.Special,
                    Habitats = new List<Habitat>() { Habitat.Space },
                    Region = Region.Kredulor,
                    Kingdom = Kingdom.Alien,
                    Personality_Traits = new List<Pers_T>() { Pers_T.Friendly, Pers_T.Foodie },
                    Physical_Traits = new Phys_T()
                    {
                        Size = Sizes.Small,
                        Hands = true,
                        LegType = LegType.Other,
                        Legs = LegCount.Two,
                        Ears = true,
                        Tail = false,
                        Allergies = false,
                        Strong = false,
                        Tusks = false,
                        Horns = false,
                        Nocturnal = false,
                        Fur = new List<Hair> { Hair.None },
                        Clawed = false,
                        Wing_Size = null,
                        Wing_Type = null,
                        Snout = SnoutType.Jawed,
                        Diet = Diet.Unkown
                    }
                },
                new Neopet()
                {
                    Name = "Hissi",
                    Biozone = Biozone.Aerial,
                    Availability = Availability.Special,
                    Habitats = new List<Habitat>() { Habitat.NotListed },
                    Region = Region.Unknown,
                    Kingdom = Kingdom.Reptile,
                    Personality_Traits = new List<Pers_T>() { Pers_T.Playful, Pers_T.Friendly },
                    Physical_Traits = new Phys_T()
                    {
                        Size = Sizes.Small,
                        Legs = LegCount.None,
                        LegType = LegType.None,
                        Ears = false,
                        Tail = true,
                        Hands = false,
                        Allergies = false,
                        Strong = false,
                        Tusks = false,
                        Horns = false,
                        Nocturnal = true,
                        Fur = new List<Hair> { Hair.None },
                        Clawed = false,
                        Wing_Size = WingSize.Large,
                        Wing_Type = WingType.Webbed,
                        Snout = SnoutType.Jawed,
                        Diet = Diet.Unkown
                    }
                },
                new Neopet()
                {
                    Name = "Jetsam",
                    Biozone = Biozone.Aquatic,
                    Availability = Availability.Special,
                    Habitats = new List<Habitat>() { Habitat.Oceans, Habitat.Seas },
                    Region = Region.Unknown,
                    Kingdom = Kingdom.Fish,
                    Personality_Traits = new List<Pers_T>() { Pers_T.Ferocious },
                    Physical_Traits = new Phys_T()
                    {
                        Size = Sizes.Small,
                        Hands = true,
                        LegType = LegType.Flippers,
                        Legs = LegCount.Two,
                        Ears = false,
                        Tail = true,
                        TailPurpose = TailPurpose.Navigating,
                        Allergies = false,
                        Strong = true,
                        Tusks = false,
                        Horns = false,
                        Nocturnal = false,
                        Fur = new List<Hair> { Hair.None },
                        Clawed = false,
                        Wing_Size = null,
                        Wing_Type = null,
                        Snout = SnoutType.Jawed,
                        Diet = Diet.Unkown
                    }
                },
                new Neopet()
                {
                    Name = "Kiko",
                    Biozone = Biozone.Aquatic,
                    Availability = Availability.Special,
                    Habitats = new List<Habitat>() { Habitat.Lakes },
                    Region = Region.KikoLake,
                    Kingdom = Kingdom.Fish,
                    Personality_Traits = new List<Pers_T>() { Pers_T.Playful },
                    Physical_Traits = new Phys_T()
                    {
                        Size = Sizes.Medium,
                        Legs = LegCount.None,
                        LegType = LegType.None,
                        Ears = false,
                        Tail = false,
                        Hands = true,
                        Allergies = false,
                        Strong = false,
                        Tusks = false,
                        Horns = false,
                        Nocturnal = false,
                        Fur = new List<Hair> { Hair.None },
                        Clawed = false,
                        Wing_Size = null,
                        Wing_Type = null,
                        Snout = SnoutType.Jawed,
                        Diet = Diet.Unkown
                    }
                },
                // Start Lutari
                new Neopet()
                {
                    Name = "Koi",
                    Biozone = Biozone.Aquatic,
                    Availability = Availability.Special,
                    Habitats = new List<Habitat>() { Habitat.Lakes },
                    Region = Region.Maraqua,
                    Kingdom = Kingdom.Fish,
                    Personality_Traits = new List<Pers_T>() { Pers_T.Intelligent, Pers_T.Outgoing, Pers_T.Friendly },
                    Physical_Traits = new Phys_T()
                    {
                        Size = Sizes.Small,
                        Hands = false,
                        LegType = LegType.Flippers,
                        Legs = LegCount.Two,
                        Ears = false,
                        Tail = true,
                        TailPurpose = TailPurpose.Navigating,
                        Allergies = false,
                        Strong = false,
                        Tusks = false,
                        Horns = false,
                        Nocturnal = false,
                        Fur = new List<Hair> { Hair.None },
                        Clawed = true,
                        Wing_Size = null,
                        Wing_Type = null,
                        Snout = SnoutType.Jawed,
                        Diet = Diet.Unkown
                    }
                },
                new Neopet()
                {
                    Name = "Lutari",
                    Biozone = Biozone.Aquatic,
                    Availability = Availability.Special,
                    Habitats = new List<Habitat>() { Habitat.Oceans, Habitat.Islands, Habitat.Seas },
                    Region = Region.Lutari_Island,
                    Kingdom = Kingdom.Mammal,
                    Personality_Traits = new List<Pers_T>() { Pers_T.Playful },
                    Physical_Traits = new Phys_T()
                    {
                        Size = Sizes.Unknown,
                        Legs = LegCount.Four,
                        LegType = LegType.Paws,
                        Ears = true,
                        Tail = true,
                        TailPurpose = TailPurpose.Navigating,
                        Hands = true,
                        Allergies = false,
                        Strong = false,
                        Tusks = false,
                        Horns = false,
                        Nocturnal = true,
                        Fur = new List<Hair> { Hair.AllOver },
                        Clawed = true,
                        Wing_Size = null,
                        Wing_Type = null,
                        Snout = SnoutType.Jawed,
                        Diet = Diet.Unkown
                    }
                },
                new Neopet()
                {
                    Name = "Poogle",
                    Biozone = Biozone.Land,
                    Availability = Availability.Special,
                    Habitats = new List<Habitat>() { Habitat.Sky },
                    Region = Region.FearieLand,
                    Kingdom = Kingdom.Mammal,
                    Personality_Traits = new List<Pers_T>() { },
                    Physical_Traits = new Phys_T()
                    {
                        Size = Sizes.Small,
                        Hands = false,
                        LegType = LegType.Paws,
                        Legs = LegCount.Four,
                        Ears = true,
                        Tail = true,
                        Allergies = false,
                        Strong = false,
                        Tusks = false,
                        Horns = false,
                        Nocturnal = false,
                        Fur = new List<Hair> { Hair.None },
                        Clawed = false,
                        Wing_Size = null,
                        Wing_Type = null,
                        Snout = SnoutType.Jawed,
                        Diet = Diet.Unkown
                    }
                },
                new Neopet()
                {
                    Name = "Ruki",
                    Biozone = Biozone.Aquatic,
                    Availability = Availability.Special,
                    Habitats = new List<Habitat>() { Habitat.Desert },
                    Region = Region.LostDesert,
                    Kingdom = Kingdom.Insect,
                    Personality_Traits = new List<Pers_T>() { },
                    Physical_Traits = new Phys_T()
                    {
                        Size = Sizes.Unknown,
                        Legs = LegCount.Four,
                        LegType = LegType.None,
                        Ears = false,
                        Tail = false,
                        Hands = true,
                        Allergies = false,
                        Strong = false,
                        Tusks = false,
                        Horns = false,
                        Nocturnal = false,
                        Fur = new List<Hair> { Hair.None },
                        Clawed = false,
                        Wing_Size = null,
                        Wing_Type = null,
                        Snout = SnoutType.Jawed,
                        Diet = Diet.Unkown
                    }
                },
                new Neopet()
                {
                    Name = "Tonu",
                    Biozone = Biozone.Land,
                    Availability = Availability.Special,
                    Habitats = new List<Habitat>() { Habitat.Moutains },
                    Region = Region.TerrorMoutain,
                    Kingdom = Kingdom.Mammal,
                    Personality_Traits = new List<Pers_T>() { },
                    Physical_Traits = new Phys_T()
                    {
                        Size = Sizes.Unknown,
                        Hands = false,
                        LegType = LegType.Paws,
                        Legs = LegCount.Four,
                        Ears = true,
                        Tail = true,
                        Allergies = false,
                        Strong = false,
                        Tusks = false,
                        Horns = false,
                        Nocturnal = false,
                        Fur = new List<Hair> { Hair.Neck, Hair.Tail },
                        Clawed = false,
                        Wing_Size = null,
                        Wing_Type = null,
                        Snout = SnoutType.Jawed,
                        Diet = Diet.Unkown
                    }
                },
                new Neopet()
                {
                    Name = "Draik",
                    Biozone = Biozone.Aerial,
                    Availability = Availability.Rare,
                    Habitats = new List<Habitat>() { Habitat.Urban },
                    Region = Region.Meridell,
                    Kingdom = Kingdom.Dragon,
                    Personality_Traits = new List<Pers_T>() { },
                    Physical_Traits = new Phys_T()
                    {
                        Size = Sizes.Small,
                        Legs = LegCount.Two,
                        LegType = LegType.Paws,
                        Ears = true,
                        Tail = true,
                        Hands = true,
                        Allergies = false,
                        Strong = false,
                        Tusks = false,
                        Horns = false,
                        Nocturnal = true,
                        Fur = new List<Hair> { Hair.None },
                        Clawed = false,
                        Wing_Size = WingSize.Large,
                        Wing_Type = WingType.Webbed,
                        Snout = SnoutType.Jawed,
                        Diet = Diet.Unkown
                    }
                },
                new Neopet()
                {
                    Name = "Krawk",
                    Biozone = Biozone.Aquatic,
                    Availability = Availability.Rare,
                    Habitats = new List<Habitat>() { Habitat.Islands },
                    Region = Region.Kraik_Island,
                    Kingdom = Kingdom.Reptile,
                    Personality_Traits = new List<Pers_T>() { Pers_T.Loyal, Pers_T.Playful },
                    Physical_Traits = new Phys_T()
                    {
                        Size = Sizes.Medium,
                        Legs = LegCount.Two,
                        LegType = LegType.Paws,
                        Ears = false,
                        Tail = true,
                        Hands = true,
                        Allergies = false,
                        Strong = false,
                        Tusks = false,
                        Horns = false,
                        Nocturnal = true,
                        Fur = new List<Hair> { Hair.Head, Hair.Back },
                        Clawed = true,
                        Wing_Size = null,
                        Wing_Type = null,
                        Snout = SnoutType.Jawed,
                        Diet = Diet.Unkown
                    }
                }
            };
        }
        static void Run() {
            EvalAvailability();
            EvalBio();
            EvalPhysical();
            EvalPersonality();
            GiveRecommendation();
        }

        #region Availability
        public static void EvalAvailability() {
            AvailabilityQuestion1();
        }
        public static void AvailabilityQuestion1()
        {
            var options = new string[] { "1. Common", "2. Rare", "3. Special", "4. No Preference" };
            var answer = GetInput("Is your ideal Neopet...", options);
            switch (answer)
            {
                case 1:
                    for (var i = 0; i < _pets.Count; i++)
                    {
                        if (_pets[i].Availability == Availability.Common)
                        {
                            _pets[i].CF++;
                        }
                    }
                    break;
                case 2:
                    for (var i = 0; i < _pets.Count; i++)
                    {
                        if (_pets[i].Availability == Availability.Rare)
                        {
                            _pets[i].CF++;
                        }
                    }
                    AvailabilityRareQuestion1();
                    AvailabilityRareQuestion2();
                    break;
                case 3:
                    for (var i = 0; i < _pets.Count; i++)
                    {
                        if (_pets[i].Availability == Availability.Special)
                        {
                            _pets[i].CF++;
                        }
                    }
                    AvailabilityOriginQuestion1();
                    break;
                case 4:
                    //nothing occurs
                    break;
            }
        }
        public static void AvailabilityRareQuestion1()
        {
            var options = new string[] { "1. Yes", "2. No" };
            var answer = GetInput("Do you already have a Krawk petpet?", options);

            switch (answer)
            {
                case 1:
                    for (var i = 0; i < _pets.Count; i++)
                    {
                        if (_pets[i].Name == "Krawk")
                        {
                            _pets[i].CF++;
                        }
                    }
                    break;
                case 2:
                    for (var i = 0; i < _pets.Count; i++)
                    {
                        if (_pets[i].Name == "Krawk")
                        {
                            _pets[i].CF -= 1000;
                        }
                    }

                    break;
            }
        }
        public static void AvailabilityRareQuestion2()
        {
            var options = new string[] { "1. Yes", "2. No" };
            var answer = GetInput("Do you already have a Draik Egg?", options);

            switch (answer)
            {
                case 1:
                    for (var i = 0; i < _pets.Count; i++)
                    {
                        if (_pets[i].Name == "Draik")
                        {
                            _pets[i].CF++;
                        }
                    }
                    break;
                case 2:
                    for (var i = 0; i < _pets.Count; i++)
                    {
                        if (_pets[i].Name == "Draik")
                        {
                            _pets[i].CF -= 1000;
                        }
                    }
                    break;
            }
        }
        public static void AvailabilityOriginQuestion1()
        {
            var options = new string[] { "1. Yes", "2. No" };
            var answer = GetInput("Does your Neopet originate from a specific location?", options);
            if (answer == 1)
            {
                AvailabilityUrbanQuestion1();
            }
        }
        public static void AvailabilityOriginQuestion2()
        {
            var options = new string[] { "1. Yes", "2. No" };
            var answer = GetInput("Does your Neopet originate from somewhere by WATER?", options);

            switch (answer)
            {
                case 1:
                    AvailabilityWaterQuestion1();
                    break;
                case 2:
                    AvailabilityOriginQuestion3();
                    break;
                default:
                    DefaultDateQuestion1();
                    DefaultDateQuestion2();
                    break;
            }
        }
        public static void AvailabilityOriginQuestion3()
        {
            var options = new string[] { "1. Sky", "2. The Outlands", "3. Mysterious" };
            var answer = GetInput("Does your Neopet originate from the SKY, THE OUTLANDS, or MYSTERIOULSY", options);

            switch (answer)
            {
                case 1:
                    AvailabilitySkyQuestion1();
                    break;
                case 2:
                    AvailabilityLandQuestion1();
                    break;
                case 3:
                    for (var i = 0; i < _pets.Count; i++)
                    {
                        if (_pets[i].Region == Region.Unknown)
                        {
                            _pets[i].CF++;
                        }
                    }
                    break;

            }

        }
        public static void AvailabilityUrbanQuestion1()
        {
            var options = new string[] { "1. Yes", "2. No" };
            var answer = GetInput("Does your Neopet originate in a CITY?", options);

            switch (answer)
            {
                case 1:
                    AvailabilitUrbanQuestion2();
                    break;
                case 2:
                    AvailabilityOriginQuestion2();
                    break;

            }
        }
        public static void AvailabilitUrbanQuestion2()
        {
            var options = new string[] { "1. Neopia Central", "2. Meridell", "3. Either" };
            var answer = GetInput("Does your Neopet originate from MERIDELL or NEOPIA CENTRAL", options);

            switch (answer)
            {
                case 1:
                    for (var i = 0; i < _pets.Count; i++)
                    {
                        if (_pets[i].Region == Region.NeopiaCentral)
                        {
                            _pets[i].CF++;
                        }
                    }
                    break;
                case 2:
                    for (var i = 0; i < _pets.Count; i++)
                    {
                        if (_pets[i].Region == Region.Meridell)
                        {
                            _pets[i].CF++;
                        }
                    }
                    break;
                case 3:
                    for (var i = 0; i < _pets.Count; i++)
                    {
                        if (_pets[i].Region == Region.Meridell || _pets[i].Region == Region.NeopiaCentral)
                        {
                            _pets[i].CF++;
                        }
                    }
                    break;

            }

        }
        public static void AvailabilityWaterQuestion1()
        {
            var options = new string[] { "1. Yes", "2. No" };
            var answer = GetInput("Does your Neopet originate on an ISLAND?", options);

            switch (answer)
            {
                case 1:
                    AvailabilityIslandQuestion1();
                    break;
                case 2:
                    AvailabilityWaterQuestion2();
                    break;

            }

        }
        public static void AvailabilityWaterQuestion2()
        {
            var options = new string[] { "1. Kiko Lake", "2. Maraqua", "3. Either" };
            var answer = GetInput("Does your Neopet originate from KIKO LAKE or MARAQUA", options);

            switch (answer)
            {
                case 1:
                    LakeDateQuestion1();
                    for (var i = 0; i < _pets.Count; i++)
                    {
                        //checks against other instances
                        if (_pets[i].Region == Region.Meridell && _pets[i].Name != "Kiko")
                        {
                            _pets[i].CF++;
                        }
                    }
                    break;
                case 2:
                    LakeDateQuestion2();
                    for (var i = 0; i < _pets.Count; i++)
                    {
                        //checks against other instances
                        if (_pets[i].Region == Region.Maraqua && _pets[i].Name != "Koi")
                        {
                            _pets[i].CF++;
                        }
                    }
                    break;
                case 3:
                    for (var i = 0; i < _pets.Count; i++)
                    {
                        //checks against other instances
                        if (_pets[i].Region == Region.Meridell || _pets[i].Region == Region.Maraqua)
                        {
                            _pets[i].CF++;
                        }
                    }
                    break;

            }

        }
        public static void AvailabilityIslandQuestion1()
        {
            var options = new string[] { "1. Mystery Island", "2. Lutari Island", "3. Roo Island", "4. Krawk Island", "5. No Preference" };
            var answer = GetInput("Which ISLAND would you prefer your Neopet originate from...", options);

            switch (answer)
            {
                case 1:
                    for (var i = 0; i < _pets.Count; i++)
                    {
                        if (_pets[i].Region == Region.Mystery_Island)
                        {
                            _pets[i].CF++;
                        }
                    }
                    break;
                case 2:
                    IslandDateQuestion1();
                    for (var i = 0; i < _pets.Count; i++)
                    {
                        //checks against other instances
                        if (_pets[i].Region == Region.Lutari_Island && _pets[i].Name != "Lutari")
                        {
                            _pets[i].CF++;
                        }
                    }
                    break;
                case 3:
                    for (var i = 0; i < _pets.Count; i++)
                    {
                        if (_pets[i].Region == Region.Roo_Island)
                        {
                            _pets[i].CF++;
                        }
                    }
                    break;
                case 4:
                    for (var i = 0; i < _pets.Count; i++)
                    {
                        if (_pets[i].Region == Region.Kraik_Island)
                        {
                            _pets[i].CF++;
                        }
                    }
                    break;
                default:
                    for (var i = 0; i < _pets.Count; i++)
                    {
                        if (_pets[i].Region == Region.Kraik_Island ||
                            _pets[i].Region == Region.Roo_Island ||
                            _pets[i].Region == Region.Mystery_Island || 
                            _pets[i].Region == Region.Lutari_Island)
                        {
                            _pets[i].CF++;
                        }
                    }
                    break;

            }

        }
        public static void AvailabilitySkyQuestion1()
        {
            var options = new string[] { "1. Kredulor", "2. Faerieland", "3. No Preference" };
            var answer = GetInput("Does your Neopet originate from...", options);

            switch (answer)
            {
                case 1:
                    SkyDateQuestion1();
                    for (var i = 0; i < _pets.Count; i++)
                    {
                        //checks against other instances
                        if (_pets[i].Region == Region.Kredulor && _pets[i].Name != "Grundo")
                        {
                            _pets[i].CF++;
                        }
                    }
                    break;
                case 2:
                    SkyDateQuestion2();
                    for (var i = 0; i < _pets.Count; i++)
                    {
                        //checks against other instances
                        if (_pets[i].Region == Region.FearieLand && _pets[i].Name != "Poogle")
                        {
                            _pets[i].CF++;
                        }
                    }
                    break;
                default:
                    for (var i = 0; i < _pets.Count; i++)
                    {
                        //checks against other instances
                        if (_pets[i].Region == Region.FearieLand || _pets[i].Region == Region.Kredulor)
                        {
                            _pets[i].CF++;
                        }
                    }
                    break;

            }

        }
        public static void AvailabilityLandQuestion1()
        {
            var options = new string[] { "1. Terror Mountain", "2. Tyrannia", "3. Lost Desert", "4. Any" };
            var answer = GetInput("Does your Neopet originate from...", options);

            switch (answer)
            {
                case 1:
                    LandDateQuestion1();
                    for (var i = 0; i < _pets.Count; i++)
                    {
                        //checks against other instances
                        if (_pets[i].Region == Region.TerrorMoutain && _pets[i].Name != "Cynbunny")
                        {
                            _pets[i].CF++;
                        }
                    }
                    break;
                case 2:
                    LandDateQuestion3();
                    LandDateQuestion4();
                    for (var i = 0; i < _pets.Count; i++)
                    {
                        //checks against other instances
                        if (_pets[i].Region == Region.Tyrannia && _pets[i].Name != "Chomby" && _pets[i].Name != "Tonu")
                        {
                            _pets[i].CF++;
                        }
                    }
                    break;
                case 3:
                    LandDateQuestion2();
                    for (var i = 0; i < _pets.Count; i++)
                    {
                        //checks against other instances
                        if (_pets[i].Region == Region.LostDesert && _pets[i].Name != "Ruki")
                        {
                            _pets[i].CF++;
                        }
                    }
                    break;
                default:
                    for (var i = 0; i < _pets.Count; i++)
                    {
                        //checks against other instances
                        if (_pets[i].Region == Region.LostDesert || 
                            _pets[i].Region == Region.TerrorMoutain ||
                            _pets[i].Region == Region.Tyrannia)
                        {
                            _pets[i].CF++;
                        }
                    }
                    break;
            }

        }
        public static bool IslandDateQuestion1()
        {
            var options = new string[] { "1. yes", "2. no" };
            var answer = GetInput("Is the day today April 19th?", options);

            switch (answer)
            {
                case 1:
                    for (var i = 0; i < _pets.Count; i++)
                    {
                        if (_pets[i].Name == "Lutari")
                        {
                            _pets[i].CF++;
                        }
                    }
                    return true;
                case 2:
                    for (var i = 0; i < _pets.Count; i++)
                    {
                        if (_pets[i].Name == "Lutari")
                        {
                            _pets[i].CF -= 1000;
                        }
                    }
                    break;

            }
            return false;
        }
        public static bool LakeDateQuestion1()
        {
            var options = new string[] { "1. yes", "2. no" };
            var answer = GetInput("Is the day today July 17th?", options);

            switch (answer)
            {
                case 1:
                    for (var i = 0; i < _pets.Count; i++)
                    {
                        if (_pets[i].Name == "Kiko")
                        {
                            _pets[i].CF++;
                        }
                    }
                    return true;
                case 2:
                    for (var i = 0; i < _pets.Count; i++)
                    {
                        if (_pets[i].Name == "Kiko")
                        {
                            _pets[i].CF -= 1000;
                        }
                    }
                    break;

            }
            return false;
        }
        public static bool LakeDateQuestion2()
        {
            var options = new string[] { "1. yes", "2. no" };
            var answer = GetInput("Is the day today May 25th?", options);

            switch (answer)
            {
                case 1:
                    for (var i = 0; i < _pets.Count; i++)
                    {
                        if (_pets[i].Name == "Koi")
                        {
                            _pets[i].CF++;
                        }
                    }
                    return true;
                case 2:
                    for (var i = 0; i < _pets.Count; i++)
                    {
                        if (_pets[i].Name == "Koi")
                        {
                            _pets[i].CF -= 1000;
                        }
                    }
                    break;

            }
            return false;
        }
        public static bool SkyDateQuestion1()
        {
            var options = new string[] { "1. yes", "2. no" };
            var answer = GetInput("Is the day today August 24th?", options);

            switch (answer)
            {
                case 1:
                    for (var i = 0; i < _pets.Count; i++)
                    {
                        if (_pets[i].Name == "Grundo")
                        {
                            _pets[i].CF++;
                        }
                    }
                    return true;
                case 2:
                    for (var i = 0; i < _pets.Count; i++)
                    {
                        if (_pets[i].Name == "Grundo")
                        {
                            _pets[i].CF -= 1000;
                        }
                    }
                    break;

            }
            return false;
        }
        public static bool SkyDateQuestion2()
        {
            var options = new string[] { "1. yes", "2. no" };
            var answer = GetInput("Is the day today September 19th?", options);

            switch (answer)
            {
                case 1:
                    for (var i = 0; i < _pets.Count; i++)
                    {
                        if (_pets[i].Name == "Poogle")
                        {
                            _pets[i].CF++;
                        }
                    }
                    return true;
                case 2:
                    for (var i = 0; i < _pets.Count; i++)
                    {
                        if (_pets[i].Name == "Poogle")
                        {
                            _pets[i].CF -= 1000;
                        }
                    }
                    break;

            }
            return false;
        }
        public static bool LandDateQuestion1()
        {
            var options = new string[] { "1. yes", "2. no" };
            var answer = GetInput("Is the day today April 27th?", options);

            switch (answer)
            {
                case 1:
                    for (var i = 0; i < _pets.Count; i++)
                    {
                        if (_pets[i].Name == "Cynbunny")
                        {
                            _pets[i].CF++;
                        }
                    }
                    return true;
                case 2:
                    for (var i = 0; i < _pets.Count; i++)
                    {
                        if (_pets[i].Name == "Cynbunny")
                        {
                            _pets[i].CF -= 1000;
                        }
                    }
                    break;

            }
            return false;
        }
        public static bool LandDateQuestion2()
        {
            var options = new string[] { "1. yes", "2. no" };
            var answer = GetInput("Is the day today July 19th?", options);

            switch (answer)
            {
                case 1:
                    for (var i = 0; i < _pets.Count; i++)
                    {
                        if (_pets[i].Name == "Ruki")
                        {
                            _pets[i].CF++;
                        }
                    }
                    return true;
                case 2:
                    for (var i = 0; i < _pets.Count; i++)
                    {
                        if (_pets[i].Name == "Ruki")
                        {
                            _pets[i].CF -= 1000;
                        }
                    }
                    break;

            }
            return false;
        }
        public static bool LandDateQuestion3()
        {
            var options = new string[] { "1. yes", "2. no" };
            var answer = GetInput("Is the day today March 22nd?", options);

            switch (answer)
            {
                case 1:
                    for (var i = 0; i < _pets.Count; i++)
                    {
                        if (_pets[i].Name == "Chommby")
                        {
                            _pets[i].CF++;
                        }
                    }
                    return true;
                case 2:
                    for (var i = 0; i < _pets.Count; i++)
                    {
                        if (_pets[i].Name == "Chomby")
                        {
                            _pets[i].CF -= 1000;
                        }
                    }
                    break;

            }
            return false;
        }
        public static bool LandDateQuestion4()
        {
            var options = new string[] { "1. yes", "2. no" };
            var answer = GetInput("Is the day today February 21st", options);

            switch (answer)
            {
                case 1:
                    for (var i = 0; i < _pets.Count; i++)
                    {
                        if (_pets[i].Name == "Tonu")
                        {
                            _pets[i].CF++;
                        }
                    }
                    return true;
                case 2:
                    for (var i = 0; i < _pets.Count; i++)
                    {
                        if (_pets[i].Name == "Tonu")
                        {
                            _pets[i].CF -= 1000;
                        }
                    }
                    break;

            }
            return false;
        }
        public static bool DefaultDateQuestion1()
        {
            var options = new string[] { "1. yes", "2. no" };
            var answer = GetInput("Is the day today May 4th?", options);

            switch (answer)
            {
                case 1:
                    for (var i = 0; i < _pets.Count; i++)
                    {
                        if (_pets[i].Name == "Hissi")
                        {
                            _pets[i].CF++;
                        }
                    }
                    return false;
                case 2:
                    for (var i = 0; i < _pets.Count; i++)
                    {
                        if (_pets[i].Name == "Hissi")
                        {
                            _pets[i].CF -= 1000;
                        }
                    }
                    break;

            }
            return false;
        }
        public static bool DefaultDateQuestion2()
        {
            var options = new string[] { "1. yes", "2. no" };
            var answer = GetInput("Is the day today October 16th?", options);

            switch (answer)
            {
                case 1:
                    for (var i = 0; i < _pets.Count; i++)
                    {
                        if (_pets[i].Name == "Jetsam")
                        {
                            _pets[i].CF++;
                        }
                    }
                    return true;
                case 2:
                    for (var i = 0; i < _pets.Count; i++)
                    {
                        if (_pets[i].Name == "Jetsam")
                        {
                            _pets[i].CF -= 1000;
                        }
                    }
                    break;

            }
            return false;
        }

        #endregion

        #region Bio Questions
        public static void EvalBio() {
            BioQuestion1();
        }
        public static void BioQuestion1() {
            var options = new string[] { "1. Fly", "2. Swim", "3. Crawl", "4. No Preference" };
            var answer = GetInput("Does your Neopet like to...", options);
            switch (answer)
            {
                case 1:
                    for (var i = 0; i < _pets.Count; i++)
                    {
                        if (_pets[i].Biozone == Biozone.Aerial)
                        {
                            _pets[i].CF++;
                        }
                    }
                    HabitatQuestion1(Biozone.Aerial);
                    //Physically specific 
                    AerialPhysicalQuestion1();
                    break;
                case 2:
                    for (var i = 0; i < _pets.Count; i++)
                    {
                        if (_pets[i].Biozone == Biozone.Aquatic)
                        {
                            _pets[i].CF++;
                        }
                    }
                    HabitatQuestion1(Biozone.Aquatic);
                    break;
                case 3:
                    for (var i = 0; i < _pets.Count; i++)
                    {
                        if (_pets[i].Biozone == Biozone.Land)
                        {
                            _pets[i].CF++;
                        }
                    }
                    HabitatQuestion1(Biozone.Land);
                    break;
                default:
                    HabitatQuestion1(Biozone.Land);
                    break;
            }
        }
        public static void HabitatQuestion1(Biozone zone) {
            var options = new string[] { "1. Yes", "2. No" };
            var answer = GetInput("Does your ideal Neopet have a habitat preference?", options);
            if (answer == 1)
            {
                HabitatQuestion2(zone);
            }
        }
        public static void HabitatQuestion2(Biozone zone) {
            switch (zone)
            {
                case Biozone.Aquatic:
                    HabitatAquaticQuestion1();
                    break;
                case Biozone.Land:
                    HabitatLandQuestion1();
                    break;
                case Biozone.Aerial:
                    for (var i = 0; i < _pets.Count; i++)
                    {
                        if (_pets[i].Habitats.Contains(Habitat.Sky) || _pets[i].Habitats.Contains(Habitat.Space))
                        {
                            _pets[i].CF++;
                        }
                    }
                    break;
            }
        }       
        public static void HabitatAquaticQuestion1() {
            var options = new string[] { "1. Beachy sands", "2. Placid Lakes", "3. Vast Seas or Oceans", "4. No Preference" };
            var answer = GetInput("Does your Neopet like...?", options);
            switch (answer) {
                case 1:
                    for (var i = 0; i < _pets.Count; i++)
                    {
                        if (_pets[i].Habitats.Contains(Habitat.Beaches) ||
                            _pets[i].Habitats.Contains(Habitat.Islands))
                        {
                            _pets[i].CF++;
                        }
                    }

                    break;
                case 2:
                    for (var i = 0; i < _pets.Count; i++)
                    {
                        if (_pets[i].Habitats.Contains(Habitat.Lakes) || _pets[i].Region == Region.KikoLake)
                        {
                            _pets[i].CF++;
                        }
                    }
                    break;
                case 3:
                    for (var i = 0; i < _pets.Count; i++)
                    {
                        if (_pets[i].Habitats.Contains(Habitat.Oceans) ||
                            _pets[i].Habitats.Contains(Habitat.Seas))
                        {
                            _pets[i].CF++;
                        }
                    }
                    break;
                default:
                    for (var i = 0; i < _pets.Count; i++)
                    {
                        if (_pets[i].Habitats.Contains(Habitat.Beaches) || 
                            _pets[i].Habitats.Contains(Habitat.Islands) ||
                            _pets[i].Habitats.Contains(Habitat.Oceans) ||
                            _pets[i].Habitats.Contains(Habitat.Seas) ||
                            _pets[i].Habitats.Contains(Habitat.Lakes))
                        {
                            _pets[i].CF++;
                        }
                    }
                    break;
            }
        }
        public static void HabitatLandQuestion1() {
            var options = new string[] { "1. Shades of the Trees", "2. Sprawling Cities", "3. Vast Meadows", "4. Warm sand", "5. Chilly Air" };
            var answer = GetInput("Does your Neopet prefer?", options);
            switch (answer) {
                case 1:
                    for (var i = 0; i < _pets.Count; i++)
                    {
                        if (_pets[i].Habitats.Contains(Habitat.Forests) ||
                            _pets[i].Habitats.Contains(Habitat.Jungles))
                        {
                            _pets[i].CF++;
                        }
                    }
                    break;
                case 2:
                    for (var i = 0; i < _pets.Count; i++)
                    {
                        if (_pets[i].Habitats.Contains(Habitat.Urban))
                        {
                            _pets[i].CF++;
                        }
                    }
                    break;
                case 3:
                    for (var i = 0; i < _pets.Count; i++)
                    {
                        if (_pets[i].Habitats.Contains(Habitat.Meadows))
                        {
                            _pets[i].CF++;
                        }
                    }
                    break;
                case 4:
                    for (var i = 0; i < _pets.Count; i++)
                    {
                        if (_pets[i].Habitats.Contains(Habitat.Beaches) ||
                            _pets[i].Habitats.Contains(Habitat.Islands) ||
                            _pets[i].Habitats.Contains(Habitat.Desert))
                        {
                            _pets[i].CF++;
                        }
                    }
                    break;
                case 5:
                    for (var i = 0; i < _pets.Count; i++)
                    {
                        if (_pets[i].Habitats.Contains(Habitat.Artic) ||
                            _pets[i].Habitats.Contains(Habitat.Tundra) ||
                            _pets[i].Habitats.Contains(Habitat.Moutains))
                        {
                            _pets[i].CF++;
                        }
                    }
                    break;
            }
        }

        #endregion

        #region Physical       
        public static void EvalPhysical()
        {
            PhysicalKingdomQuestion1();
            PhysicalSizeQuestion1();
            PhysicalTailQuestion1();
            PhysicalLegQuestion1();
            PhysicalEarsQuestion1();
            PhysicalTusksHornsQuestion1();
            PhysicalNoseQuestion1();
            PhysicalFurQuestion1();
            PhysicalHandsQuestion1();
            PhysicalClawsQuestion1();
            PhysicalNocturnQuestion1();
            PhysicalDietQuestion();
        }
        public static void PhysicalKingdomQuestion1() {
            var options = new string[] { "1. Dragons", "2. Aliens", "3. Birdies", "4. Live Birthers", "5. Creepy-Crawlies/Bugsie-Wugies", "6. Fishies", "7. Reptiles/Amphibians", "8. Who knows?", "9. No Preference" };
            var answer = GetInput("I like my species like i like my...", options);
            switch (answer)
            {
                case 1:
                    for (var i = 0; i < _pets.Count; i++)
                    {
                        if (_pets[i].Kingdom == Kingdom.Dragon)
                        {
                            _pets[i].CF++;
                        }
                    }
                    break;
                case 2:
                    for (var i = 0; i < _pets.Count; i++)
                    {
                        if (_pets[i].Kingdom == Kingdom.Alien)
                        {
                            _pets[i].CF++;
                        }
                    }
                    break;
                case 3:
                    for (var i = 0; i < _pets.Count; i++)
                    {
                        if (_pets[i].Kingdom == Kingdom.Bird)
                        {
                            _pets[i].CF++;
                        }
                    }
                    break;
                case 4:
                    for (var i = 0; i < _pets.Count; i++)
                    {
                        if (_pets[i].Kingdom == Kingdom.Mammal)
                        {
                            _pets[i].CF++;
                        }
                    }
                    break;
                case 5:
                    for (var i = 0; i < _pets.Count; i++)
                    {
                        if (_pets[i].Kingdom == Kingdom.Insect)
                        {
                            _pets[i].CF++;
                        }
                    }
                    break;
                case 6:
                    for (var i = 0; i < _pets.Count; i++)
                    {
                        if (_pets[i].Kingdom == Kingdom.Fish)
                        {
                            _pets[i].CF++;
                        }
                    }
                    break;
                case 7:
                    for (var i = 0; i < _pets.Count; i++)
                    {
                        if (_pets[i].Kingdom == Kingdom.Reptile)
                        {
                            _pets[i].CF++;
                        }
                    }
                    break;
                case 8:
                    for (var i = 0; i < _pets.Count; i++)
                    {
                        if (_pets[i].Kingdom == Kingdom.Other)
                        {
                            _pets[i].CF++;
                        }
                    }
                    break;
            }
        }
        public static void PhysicalSizeQuestion1() {
            var options = new string[] { "1. Large", "2. Medium", "3. Small", "4. No Preference" };
            var answer = GetInput("How big is your ideal Neopet?", options);
            switch (answer) {
                case 1:
                    for (var i = 0; i < _pets.Count; i++)
                    {
                        if (_pets[i].Physical_Traits.Size == Sizes.Large)
                        {
                            _pets[i].CF++;
                        }
                    }
                    break;
                case 2:
                    for (var i = 0; i < _pets.Count; i++)
                    {
                        if (_pets[i].Physical_Traits.Size == Sizes.Medium)
                        {
                            _pets[i].CF++;
                        }
                    }
                    break;
                case 3:
                    for (var i = 0; i < _pets.Count; i++)
                    {
                        if (_pets[i].Physical_Traits.Size == Sizes.Small)
                        {
                            _pets[i].CF++;
                        }
                    }
                    break;
            }

        }
        public static void PhysicalTailQuestion1()
        {
            var options = new string[] { "1. Yes", "2. No" };
            var answer = GetInput("Does your Neopet have a tail?", options);
            if (answer == 1) {
                for (var i = 0; i < _pets.Count; i++)
                {
                    if (_pets[i].Physical_Traits.Tail)
                    {
                        _pets[i].CF++;
                    }
                }
                PhysicalTailQuestion2();
            }
        }
        public static void PhysicalTailQuestion2() {
            var options = new string[] { "1. Bounce around", "2. Hanging", "3. Moving about", "4. Look taller", "5. No Preference" };
            var answer = GetInput("How do they use their tails?", options);
            switch (answer) {
                case 1:
                    for (var i = 0; i < _pets.Count; i++)
                    {
                        if (_pets[i].Physical_Traits.TailPurpose == TailPurpose.Bouncing)
                        {
                            _pets[i].CF++;
                        }
                    }
                    break;
                case 2:
                    for (var i = 0; i < _pets.Count; i++)
                    {
                        if (_pets[i].Physical_Traits.TailPurpose == TailPurpose.Hanging)
                        {
                            _pets[i].CF++;
                        }
                    }
                    break;
                case 3:
                    for (var i = 0; i < _pets.Count; i++)
                    {
                        if (_pets[i].Physical_Traits.TailPurpose == TailPurpose.Navigating)
                        {
                            _pets[i].CF++;
                        }
                    }
                    break;
                case 4:
                    for (var i = 0; i < _pets.Count; i++)
                    {
                        if (_pets[i].Physical_Traits.TailPurpose == TailPurpose.Standing)
                        {
                            _pets[i].CF++;
                        }
                    }
                    break;
                default: break;

            }
        }
        public static void PhysicalLegQuestion1() {
            var options = new string[] { "1. 2 Legs", "2. 4 Legs", "3. None", "4. No Preference" };
            var answer = GetInput("I would prefer them to have", options);
            switch (answer)
            {
                case 1:
                    for (var i = 0; i < _pets.Count; i++)
                    {
                        if (_pets[i].Physical_Traits.Legs == LegCount.Two)
                        {
                            _pets[i].CF++;
                        }
                    }
                    PhysicalLegQuestion2();
                    break;
                case 2:
                    for (var i = 0; i < _pets.Count; i++)
                    {
                        if (_pets[i].Physical_Traits.Legs == LegCount.Four)
                        {
                            _pets[i].CF++;
                        }
                    }
                    PhysicalLegQuestion2();
                    break;
                case 3:
                    for (var i = 0; i < _pets.Count; i++)
                    {
                        if (_pets[i].Physical_Traits.Legs == LegCount.None)
                        {
                            _pets[i].CF++;
                        }
                    }
                    break;
                default: break;

            }
        }
        public static void PhysicalLegQuestion2() {
            var options = new string[] { "1. Paws", "2. Hooves", "3. Flippers", "4. Other" };
            var answer = GetInput("What type of legs do they have?", options);
            switch (answer)
            {
                case 1:
                    for (var i = 0; i < _pets.Count; i++)
                    {
                        if (_pets[i].Physical_Traits.LegType == LegType.Paws)
                        {
                            _pets[i].CF++;
                        }
                    }
                    break;
                case 2:
                    for (var i = 0; i < _pets.Count; i++)
                    {
                        if (_pets[i].Physical_Traits.LegType == LegType.Hooves)
                        {
                            _pets[i].CF++;
                        }
                    }
                    break;
                case 3:
                    for (var i = 0; i < _pets.Count; i++)
                    {
                        if (_pets[i].Physical_Traits.LegType == LegType.Flippers)
                        {
                            _pets[i].CF++;
                        }
                    }
                    break;
                case 4:
                    for (var i = 0; i < _pets.Count; i++)
                    {
                        if (_pets[i].Physical_Traits.LegType == LegType.Other)
                        {
                            _pets[i].CF++;
                        }
                    }
                    break;
                default: break;

            }
        }
        public static void PhysicalEarsQuestion1() {
            var options = new string[] { "1. Yes", "2. No Ears", "3. No Preference" };
            var answer = GetInput("I would prefer them to have listen holes", options);
            if (answer == 1) {
                for (var i = 0; i < _pets.Count; i++)
                {
                    if (_pets[i].Physical_Traits.Ears)
                    {
                        _pets[i].CF++;
                    }
                } 
            }
            else if (answer == 2) {
                for (var i = 0; i < _pets.Count; i++)
                {
                    if (!_pets[i].Physical_Traits.Ears)
                    {
                        _pets[i].CF++;
                    }
                }
            }
        }
        public static void PhysicalTusksHornsQuestion1() {
            var options = new string[] { "1. Tusks", "2. Horns", "3. Both", "4. No Preference" };
            var answer = GetInput("I would prefer them to have", options);
            switch (answer) {
                case 1:
                    for (var i = 0; i < _pets.Count; i++)
                    {
                        if (_pets[i].Physical_Traits.Tusks)
                        {
                            _pets[i].CF++;
                        }
                    }
                    break;
                case 2:
                    for (var i = 0; i < _pets.Count; i++)
                    {
                        if (_pets[i].Physical_Traits.Horns)
                        {
                            _pets[i].CF++;
                        }
                    }
                    break;
                case 3:
                    for (var i = 0; i < _pets.Count; i++)
                    {
                        if (_pets[i].Physical_Traits.Tusks && _pets[i].Physical_Traits.Horns)
                        {
                            _pets[i].CF++;
                        }
                    }
                    break;
                default:break;
            }
        }
        public static void PhysicalNoseQuestion1() {
            var options = new string[] { "1. Beaks", "2. Trunks", "3. Jaws", "4. No preference!" };
            var answer = GetInput("I would prefer them to have", options);
            if (answer == 1)
            {
                for (var i = 0; i < _pets.Count; i++)
                {
                    if (_pets[i].Physical_Traits.Snout == SnoutType.Beaked)
                    {
                        _pets[i].CF++;
                    }
                }
            }
            else if (answer == 2)
            {
                for (var i = 0; i < _pets.Count; i++)
                {
                    if (_pets[i].Physical_Traits.Snout == SnoutType.Trunked)
                    {
                        _pets[i].CF++;
                    }
                }
            }
            else if (answer == 3)
            {
                for (var i = 0; i < _pets.Count; i++)
                {
                    if (_pets[i].Physical_Traits.Snout == SnoutType.Jawed)
                    {
                        _pets[i].CF++;
                    }
                }
            }
        }
        public static void PhysicalFurQuestion1() {
            var options = new string[] { "1. So much fur!", "2. Fur is murder!!!", "3. No Preference" };
            var answer = GetInput("My furr preference is...", options);
            switch (answer) {
                case 1:
                    PhysicalFurQuestion2();
                    break;
                case 2:
                    for (int i = 0; i < _pets.Count; i++)
                    {
                        if (_pets[i].Physical_Traits.Fur.Contains(Hair.None))
                        {
                            _pets[i].CF++;
                        }
                    }
                    break;
                default: break;
            }
        }
        public static void PhysicalFurQuestion2() {
            var options = new string[] { "1. Everywhere!", "2. On their noggin", "3. Neck", "4. Luscious Mane!", "5. Tail" };
            var answer = GetInput("They should have hair on thier...", options);
            switch (answer)
            {
                case 1:
                    for (int i = 0; i < _pets.Count; i++)
                    {
                        if (_pets[i].Physical_Traits.Fur.Contains(Hair.AllOver))
                        {
                            _pets[i].CF++;
                        }
                    }
                    break;
                case 2:
                    for (int i = 0; i < _pets.Count; i++)
                    {
                        if (_pets[i].Physical_Traits.Fur.Contains(Hair.Head))
                        {
                            _pets[i].CF++;
                        }
                    }
                    break;
                case 3:
                    for (int i = 0; i < _pets.Count; i++)
                    {
                        if (_pets[i].Physical_Traits.Fur.Contains(Hair.Neck))
                        {
                            _pets[i].CF++;
                        }
                    }
                    break;
                case 4:
                    for (int i = 0; i < _pets.Count; i++)
                    {
                        if (_pets[i].Physical_Traits.Fur.Contains(Hair.Mane))
                        {
                            _pets[i].CF++;
                        }
                    }
                    break;
                case 5:
                    for (int i = 0; i < _pets.Count; i++)
                    {
                        if (_pets[i].Physical_Traits.Fur.Contains(Hair.Tail))
                        {
                            _pets[i].CF++;
                        }
                    }
                    break;
                default: break;
            }
        }
        public static void PhysicalHandsQuestion1() {
            var options = new string[] { "1. Yes", "2. No" };
            var answer = GetInput("They should be able to grab things with thier hands?", options);
            switch (answer)
            {
                case 1:
                    for (int i = 0; i < _pets.Count; i++)
                    {
                        if (_pets[i].Physical_Traits.Hands)
                        {
                            _pets[i].CF++;
                        }
                    }
                    break;
                case 2:
                    for (int i = 0; i < _pets.Count; i++)
                    {
                        if (!_pets[i].Physical_Traits.Hands)
                        {
                            _pets[i].CF++;
                        }
                    }
                    break;
            }
        }
        public static void PhysicalAllergyQuestion1() {
            var options = new string[] { "1. Like a Boss", "2. Bring on the Sniffles!" };
            var answer = GetInput("They should be able to eat dairy or apples?", options);
            switch (answer)
            {
                case 1:
                    for (int i = 0; i < _pets.Count; i++)
                    {
                        if (!_pets[i].Physical_Traits.Allergies)
                        {
                            _pets[i].CF++;
                        }
                    }
                    break;
                case 2:
                    for (int i = 0; i < _pets.Count; i++)
                    {
                        if (_pets[i].Physical_Traits.Hands)
                        {
                            _pets[i].CF++;
                        }
                    }
                    break;
            }
        }
        public static void PhysicalClawsQuestion1() {
            var options = new string[] { "1. Heck Yass", "2. No Pokies!", "3. No Preference" };
            var answer = GetInput("Thier mitts should also have pokies!", options);
            switch (answer)
            {
                case 1:
                    for (int i = 0; i < _pets.Count; i++)
                    {
                        if (_pets[i].Physical_Traits.Clawed)
                        {
                            _pets[i].CF++;
                        }
                    }
                    break;
                case 2:
                    for (int i = 0; i < _pets.Count; i++)
                    {
                        if (!_pets[i].Physical_Traits.Clawed)
                        {
                            _pets[i].CF++;
                        }
                    }
                    break;
            }
        }
        public static void PhysicalNocturnQuestion1() {
            var options = new string[] { "1. They ain't afraid of no ghosts! ", "2. They might need a night-light", "3. No Preference" };
            var answer = GetInput("Are they afraid the dark?", options);
            switch (answer)
            {
                case 1:
                    for (int i = 0; i < _pets.Count; i++)
                    {
                        if (_pets[i].Physical_Traits.Nocturnal)
                        {
                            _pets[i].CF++;
                        }
                    }
                    break;
                case 2:
                    for (int i = 0; i < _pets.Count; i++)
                    {
                        if (!_pets[i].Physical_Traits.Nocturnal)
                        {
                            _pets[i].CF++;
                        }
                    }
                    break;
            }
        }
        public static void PhysicalDietQuestion() {
            var options = new string[] { "1. Meatsies", "2. Veggies/Fruitsies", "3. Everything", "4. No Preference" };
            var answer = GetInput("They can eat...", options);
            switch (answer)
            {
                case 1:
                    for (int i = 0; i < _pets.Count; i++)
                    {
                        if (_pets[i].Physical_Traits.Diet == Diet.Carnivore)
                        {
                            _pets[i].CF++;
                        }
                    }
                    break;
                case 2:
                    for (int i = 0; i < _pets.Count; i++)
                    {
                        if (_pets[i].Physical_Traits.Diet == Diet.Herbivore)
                        {
                            _pets[i].CF++;
                        }
                    }
                    break;
                case 3:
                    for (int i = 0; i < _pets.Count; i++)
                    {
                        if (_pets[i].Physical_Traits.Diet == Diet.Omnivore || 
                            _pets[i].Physical_Traits.Diet == Diet.Carnivore || 
                            _pets[i].Physical_Traits.Diet == Diet.Herbivore)
                        {
                            _pets[i].CF++;
                        }
                    }
                    break;
            }
            PhysicalAllergyQuestion1();
        }
        public static void AerialPhysicalQuestion1()
        {
            var options = new string[] { "1. Yes", "2. No" };
            var answer = GetInput("Does your Neopet have wings?", options);
            if (answer == 1)
            {
                for (var i = 0; i < _pets.Count; i++)
                {
                    if (_pets[i].Physical_Traits.Wing_Type.HasValue)
                    {
                        _pets[i].CF++;
                    }
                }
                AerialPhysicalQuestion2();
            }
        }
        public static void AerialPhysicalQuestion2()
        {
            var options = new string[] { "1. Long Feathers", "2. Batty Webbing" };
            var answer = GetInput("What type of wings do they have?", options);
            if (answer == 1)
            {
                for (var i = 0; i < _pets.Count; i++)
                {
                    if (_pets[i].Physical_Traits.Wing_Type == WingType.Feathers)
                    {
                        _pets[i].CF++;
                    }
                }
            }
            if (answer == 2)
            {
                for (var i = 0; i < _pets.Count; i++)
                {
                    if (_pets[i].Physical_Traits.Wing_Type == WingType.Webbed)
                    {
                        _pets[i].CF++;
                    }
                }
            }
            AerialPhysicalQuestion3();
        }
        public static void AerialPhysicalQuestion3()
        {
            var options = new string[] { "1. Grandriose Wings", "2. Pint-size flutter-flappers" };
            var answer = GetInput("Does you Neopt have...?", options);
            if (answer == 1)
            {
                for (var i = 0; i < _pets.Count; i++)
                {
                    if (_pets[i].Physical_Traits.Wing_Size == WingSize.Large)
                    {
                        _pets[i].CF++;
                    }
                }
            }
            if (answer == 2)
            {
                for (var i = 0; i < _pets.Count; i++)
                {
                    if (_pets[i].Physical_Traits.Wing_Size == WingSize.Small)
                    {
                        _pets[i].CF++;
                    }
                }
            }
        }

        #endregion

        #region Personality
        public static void EvalPersonality()
        {
            PersonalityShyOutgoingQuestion1();
            PersonalityPeacefulCombativeQuestion2();
            PersonalityAventurousIntelligentQuestion3();
            PersonalityLuckyMagicalQuestion4();
            PersonalityGenerousKindQuestion5();
            PersonalityFoodieQuestion6();
            PersonalityLoyalMischievousQuestion7();
        }
        public static void PersonalityShyOutgoingQuestion1() {
            var options = new string[] { "1. Shy", "2. Outgoing", "3. No Preference" };
            var answer = GetInput("Is your ideal Neopet SHY or OUTGOING?", options);

            switch (answer)
            {
                case 1:
                    for (var i = 0; i < _pets.Count; i++)
                    {
                        if (_pets[i].Personality_Traits.Contains(Pers_T.Shy) ||
                            _pets[i].Personality_Traits.Contains(Pers_T.Sensitive))
                        {
                            _pets[i].CF++;
                        }
                    }
                    break;
                case 2:
                    for (var i = 0; i < _pets.Count; i++)
                    {
                        if (_pets[i].Personality_Traits.Contains(Pers_T.Playful) ||
                            _pets[i].Personality_Traits.Contains(Pers_T.Outgoing) ||
                            _pets[i].Personality_Traits.Contains(Pers_T.Playful))
                        {
                            _pets[i].CF++;
                        }
                    }
                    break;
            }
        }
        public static void PersonalityPeacefulCombativeQuestion2() {
            var options = new string[] { "1. Peaceful", "2. Combative", "3. No Preference" };
            var answer = GetInput("Is your ideal Neopet PEACEFUL or COMBATIVE?", options);

            switch (answer)
            {
                case 1:
                    for (var i = 0; i < _pets.Count; i++)
                    {
                        if (_pets[i].Personality_Traits.Contains(Pers_T.Peaceful) ||
                            _pets[i].Personality_Traits.Contains(Pers_T.Pacifist) ||
                            _pets[i].Personality_Traits.Contains(Pers_T.Lazy))
                        {
                            _pets[i].CF++;
                        }
                    }
                    break;
                case 2:
                    for (var i = 0; i < _pets.Count; i++)
                    {
                        if (_pets[i].Personality_Traits.Contains(Pers_T.Ferocious) ||
                            _pets[i].Personality_Traits.Contains(Pers_T.Fieri) ||
                            _pets[i].Personality_Traits.Contains(Pers_T.Competitive))
                        {
                            _pets[i].CF++;
                        }
                    }
                    break;
            }
        }
        public static void PersonalityAventurousIntelligentQuestion3() {
            var options = new string[] { "1. Adventurous", "2. Intelligent", "3. No Preference" };
            var answer = GetInput("Is your ideal Neopet ADVENTUROUS or INTELLIGENT?", options);

            switch (answer)
            {
                case 1:
                    for (var i = 0; i < _pets.Count; i++)
                    {
                        if (_pets[i].Personality_Traits.Contains(Pers_T.Intelligent) ||
                            _pets[i].Personality_Traits.Contains(Pers_T.Quick))
                        {
                            _pets[i].CF++;
                        }
                    }
                    break;
                case 2:
                    for (var i = 0; i < _pets.Count; i++)
                    {
                        if (_pets[i].Personality_Traits.Contains(Pers_T.Brave) ||
                            _pets[i].Personality_Traits.Contains(Pers_T.Adventureous))
                        {
                            _pets[i].CF++;
                        }
                    }
                    break;
            }
        }
        public static void PersonalityLuckyMagicalQuestion4() {
            var options = new string[] { "1. Yes", "2. No", "3. No Preference" };
            var answer = GetInput("Is your ideal Neopet LUCKY or MAGICAL?", options);

            switch (answer)
            {
                case 1:
                    for (var i = 0; i < _pets.Count; i++)
                    {
                        if (_pets[i].Personality_Traits.Contains(Pers_T.Lucky) ||
                            _pets[i].Personality_Traits.Contains(Pers_T.Magical))
                        {
                            _pets[i].CF++;
                        }
                    }
                    break;
                case 2:
                    for (var i = 0; i < _pets.Count; i++)
                    {
                        if (_pets[i].Personality_Traits.Contains(Pers_T.Lucky) ||
                            _pets[i].Personality_Traits.Contains(Pers_T.Magical))
                        {
                            _pets[i].CF--;
                        }
                    }
                    break;
            }
        }
        public static void PersonalityGenerousKindQuestion5() {
            var options = new string[] { "1. Yes", "2. No", "3. No Preference" };
            var answer = GetInput("Is your ideal Neopet GENEROUS and KIND?", options);

            switch (answer)
            {
                case 1:
                    for (var i = 0; i < _pets.Count; i++)
                    {
                        if (_pets[i].Personality_Traits.Contains(Pers_T.Kind) ||
                            _pets[i].Personality_Traits.Contains(Pers_T.Generous))
                        {
                            _pets[i].CF++;
                        }
                    }
                    break;
                case 2:
                    for (var i = 0; i < _pets.Count; i++)
                    {
                        if (_pets[i].Personality_Traits.Contains(Pers_T.Kind) ||
                            _pets[i].Personality_Traits.Contains(Pers_T.Generous))
                        {
                            _pets[i].CF--;
                        }
                    }
                    break;
            }
        }
        public static void PersonalityFoodieQuestion6() {
            var options = new string[] { "1. They're a little fatty!", "2. No Preference" };
            var answer = GetInput("Does your ideal Neopet love food?", options);

            switch (answer)
            {
                case 1:
                    for (var i = 0; i < _pets.Count; i++)
                    {
                        if (_pets[i].Personality_Traits.Contains(Pers_T.Foodie))
                        {
                            _pets[i].CF++;
                        }
                    }
                    break;
            }
        }
        public static void PersonalityLoyalMischievousQuestion7() {
            var options = new string[] { "1. Ride or Die!", "2. Lil'@$$hole!", "3. No Preference" };
            var answer = GetInput("Is your ideal Neopet LOYAL or MISCHIEVOUS?", options);

            switch (answer)
            {
                case 1:
                    for (var i = 0; i < _pets.Count; i++)
                    {
                        if (_pets[i].Personality_Traits.Contains(Pers_T.Loyal))
                        {
                            _pets[i].CF++;
                        }
                    }
                    break;
                case 2:
                    for (var i = 0; i < _pets.Count; i++)
                    {
                        if (_pets[i].Personality_Traits.Contains(Pers_T.Mischevious))
                        {
                            _pets[i].CF++;
                        }
                    }
                    break;
            }
        }

        #endregion

        private static void GiveRecommendation() {
            Console.Write("Calculating");
            for (var i = 0; i < 5; i++) {
                Console.Write(".");
                Thread.Sleep(750);
            }
            _pets.Sort(new PetComparer());
            Console.WriteLine("\nDone! \nBased on your decisions, you should choose: ");
            //sort the list by CF
            //print the top-3

            Console.WriteLine("1. {0}", _pets[0].Name);
            Console.WriteLine("2. {0}", _pets[1].Name);
            Console.WriteLine("3. {0}", _pets[2].Name);
        }
        private static int GetInput(string question, string[] options) {
            string input;
            do
            {
                Console.WriteLine(question);
                foreach (var option in options) {
                    Console.WriteLine(option);
                }
                input = Console.ReadLine();
                int x;
                if (int.TryParse(input, out x) && x <= options.Length && x > 0)
                {
                    return x;
                }
                else {
                    Console.WriteLine("Invalid Option. Please choose from one of options: ");
                }
            } while (true);
        }
        private class PetComparer : IComparer<Neopet>
        {
            public int Compare(Neopet x, Neopet y)
            {
                if (x.CF < y.CF) return 1;
                else if (x.CF > y.CF) return -1;
                else return 0;
            }
        }
    }
}
