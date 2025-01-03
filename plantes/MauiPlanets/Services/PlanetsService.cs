﻿using MauiPlanets.Models;


namespace Services
{
    internal class PlanetsService
    {
        private static List<Planet> planets = new()
        {
            new()
            {
                Name = "Ceres",
                Subtitle = "The largest object in the asteroid belt",
                HeroImage = "ceres.png",
                Description = "Ceres, the smallest recognized dwarf planet," + 
                " is located in the asteroid belt between Mars and Jupiter."  +
                " Named after the Roman goddess of agriculture, it is the only" +
                " dwarf planet within the inner Solar System.",
                AccentColorStart = Color.FromArgb("#C0C0C0"),
                AccentColorEnd = Color.FromArgb("#696969"),
                Images = new()
                {
                    "https://upload.wikimedia.org/wikipedia/commons/thumb/7/76/Ceres_-_RC3_-_Haulani_Crater_%2822381131691%29_%28cropped%29.jpg/800px-Ceres_-_RC3_-_Haulani_Crater_%2822381131691%29_%28cropped%29.jpg"
                }
            },
            new()
            {
                Name = "Pluto",
                Subtitle = "The once ninth planet",
                HeroImage = "pluto.png",
                Description = "Pluto, reclassified as a dwarf planet in 2006," +
                " orbits the Sun beyond Neptune. It is named after the Roman god" +
                " of the underworld. Pluto has five known moons, with Charon being" +
                " the largest and almost half its size.",
                AccentColorStart = Color.FromArgb("#6A5ACD"),
                AccentColorEnd = Color.FromArgb("#483D8B"),
                Images = new()
                {
                    "https://media.npr.org/assets/img/2015/10/09/nasa-pluto-red_custom-d7ac4d9c97a5529e57995455641ad6dfce4bc785.jpg?s=900&c=85&f=webp"
                }
            },
            new()
            {
                Name = "Haumea",
                Subtitle = "The elliptical dwarf planet",
                HeroImage = "haumea.png",
                Description = "Haumea, known for its elongated shape, lies in the Kuiper Belt." +
                " It is named after the Hawaiian goddess of fertility and childbirth." +
                " Its fast rotation is responsible for its unique shape," +
                " and it has two moons, Hiʻiaka and Namaka.",
                AccentColorStart = Color.FromArgb("#4682B4"),
                AccentColorEnd = Color.FromArgb("#5F9EA0"),
                Images = new()
                {
                    "https://solarstory.net/img/articles/middle/artists-impression-of-the-dwarf-planet-haumea.jpg"
                }
            },
            new()
            {
                Name = "Eris",
                Subtitle = "The most massive dwarf planet",
                HeroImage = "eris.png",
                Description = "Eris, slightly larger than Pluto, is the most massive known" +
                " dwarf planet. Located in the scattered disk, it is named after the" +
                " Greek goddess of discord. Its discovery played a key role" +
                " in redefining what constitutes a planet.",
                AccentColorStart = Color.FromArgb("#D3D3D3"),
                AccentColorEnd = Color.FromArgb("#B0C4DE"),
                Images = new()
                {
                    "https://www.renderhub.com/3dstudio/dwarf-planet-eris/dwarf-planet-eris-01.jpg"
                }
            },
            new()
            {
                Name = "Makemake",
                Subtitle = "The Easter dwarf planet",
                HeroImage = "makemake.png",
                Description = "Makemake, discovered around Easter in 2005," +
                " is a dwarf planet in the Kuiper Belt. It is named after a" +
                " deity of the Rapa Nui people of Easter Island. Makemake lacks" + 
                " a significant atmosphere but has one known moon.",
                AccentColorStart = Color.FromArgb("#CD5C5C"),
                AccentColorEnd = Color.FromArgb("#8B0000"),
                Images = new()
                {
                    "https://cdn.eso.org/images/newsfeature/eso1246a.jpg"
                }
            },
            new()
            {
                Name = "Mercury",
                Subtitle = "The smallest planet",
                HeroImage = "mercury.png",
                Description = "Mercury is the first planet from the Sun and the " +
                "smallest in the Solar System. In English, it is named after the " +
                "ancient Roman god Mercurius (Mercury), god of commerce and " +
                "communication, and the messenger of the gods.",
                AccentColorStart = Color.FromArgb("#353535"),
                AccentColorEnd = Color.FromArgb("#8d9098"),
                Images = new()
                {
                    "https://cdn.theatlantic.com/thumbor/D15rQggf6357X1-u6VpTD2N1yQE=/0x27:1041x613/976x549/media/img/mt/2017/04/MercuryImage/original.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/73_carousel_mercury_2.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/75_mercury_carousel_1.jpg"
                }
            },
            new()
            {
                Name = "Venus",
                Subtitle = "The pressure cooker",
                HeroImage = "venus.png",
                Description = "Venus is the second planet from the Sun. It is a " +
                "terrestrial planet and is the closest in mass and size to its " +
                "orbital neighbour Earth. Venus has by far the densest atmosphere " +
                "of the terrestrial planets, composed mostly of carbon dioxide " +
                "with a thick, global sulfuric acid cloud cover.",
                AccentColorStart = Color.FromArgb("#a6393b"),
                AccentColorEnd = Color.FromArgb("#d17f21"),
                Images = new()
                {
                    "https://solarsystem.nasa.gov/system/feature_items/images/143_Venus-800x600.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/147_Hubble_Venus_Clouds-800x600.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/146_venus_carousel_3.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/144_PIA00485_Venus_Caldera-800.jpg"
                }
            },
            new()
            {
                Name = "Earth",
                Subtitle = "The cradle of life",
                HeroImage = "earth.png",
                Description = "Earth is the third planet from the Sun and " +
                "the only astronomical object known to harbor life. This is " +
                "enabled by Earth being an ocean world, the only one in the " +
                "Solar System sustaining liquid surface water. ",
                AccentColorStart = Color.FromArgb("#0e3d68"),
                AccentColorEnd = Color.FromArgb("#2e97c7"),
                Images = new()
                {
                    "https://solarsystem.nasa.gov/system/feature_items/images/68_epicearthmoonstill_800.png",
                    "https://solarsystem.nasa.gov/system/feature_items/images/69_earth_carousel_3.jpg",
                    "https://images.newscientist.com/wp-content/uploads/2019/09/09162708/iss048-e-2035_lrg.jpg?width=778"
                }
            },
            new()
            {
                Name = "Mars",
                Subtitle = "The red beauty",
                HeroImage = "mars.png",
                Description = "No planet has sparked the imaginations of humans as much " +
                "as Mars. It may be the reddish color of Mars, or the fact that it can " +
                "often be easily seen in the night sky, that has caused people to wonder " +
                "about this close neighbor of ours. Tales of “Martians” invading Earth " +
                "have been around for well over fifty years. But is it likely that any " +
                "kind of life really does exist on Mars? ",
                AccentColorStart = Color.FromArgb("#a23036"),
                AccentColorEnd = Color.FromArgb("#eb3333"),
                Images = new()
                {
                    "https://researchfdi.com/wp-content/uploads/2021/10/8944_1-PIA24546-1280.jpeg",
                    "https://www.worldatlas.com/r/w1300-q80/upload/bb/c3/32/shutterstock-1041249343.jpg",
                    "https://www.openaccessgovernment.org/wp-content/uploads/2021/04/dreamstime_xxl_121672573-scaled.jpg"
                }
            },
            new()
            {
                Name = "Jupiter",
                Subtitle = "The gas giant",
                HeroImage = "jupiter.png",
                Description = "Jupiter is the fifth planet from the Sun and the " +
                "largest in the Solar System. It is a gas giant with a mass more " +
                "than 2.5 times that of all the other planets in the Solar System " +
                "combined and slightly less than one-thousandth the mass of the Sun.",
                AccentColorStart = Color.FromArgb("#9d4a40"),
                AccentColorEnd = Color.FromArgb("#cd8026"),
                Images = new()
                {
                    "https://th-thumbnailer.cdn-si-edu.com/vKRt2OfGlFia5On4QNaraJ3vXJM=/1000x750/filters:no_upscale():focal(1829x871:1830x872)/https://tf-cmsv2-smithsonianmag-media.s3.amazonaws.com/filer_public/b5/5e/b55e16bf-9338-4433-b52f-a83fb5e2b840/pj_66_27_enhanced.png",
                    "https://solarsystem.nasa.gov/system/feature_items/images/10_Jupiter_Io_Juno-800.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/13_PIA24237_Jupiter_Cyclones-800.jpg"
                }
            },
            new()
            {
                Name = "Saturn",
                Subtitle = "The ring planet",
                HeroImage = "saturn.png",
                Description = "Saturn is the sixth planet from the Sun and the second " +
                "largest in the Solar System, after Jupiter. It is a gas giant, with " +
                "an average radius of about nine times that of Earth. It has an " +
                "eighth the average density of Earth, but is over 95 times more massive.",
                AccentColorStart = Color.FromArgb("#996237"),
                AccentColorEnd = Color.FromArgb("#c6502f"),
                Images = new()
                {
                    "https://solarsystem.nasa.gov/system/feature_items/images/151_saturn_carousel_1.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/152_saturn_carousel_2.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/155_saturn_carousel_5.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/153_saturn_carousel_3.jpg"
                }
            },
            new()
            {
                Name = "Uranus",
                Subtitle = "The Herschel planet",
                HeroImage = "uranus.png",
                Description = "Uranus is the seventh planet from the Sun. It is a " +
                "gaseous cyan-coloured ice giant. Most of the planet is made of " +
                "water, ammonia, and methane in a supercritical phase of matter, " +
                "which astronomy calls ice or volatiles. The planet's atmosphere " +
                "has a complex layered cloud structure and has the lowest " +
                "minimum temperature (49 K (−224 °C; −371 °F)) of all the Solar " +
                "System's planets.",
                AccentColorStart = Color.FromArgb("#9d4a40"),
                AccentColorEnd = Color.FromArgb("#996237"),
                Images = new()
                {
                    "https://ichef.bbci.co.uk/images/ic/1376xn/p0257vk5.jpg.webp",
                    "https://solarsystem.nasa.gov/system/feature_items/images/88_carousel_uranus.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/89_uranus_carousel_1.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/88_carousel_uranus.jpg"
                }
            },
            new()
            {
                Name = "Neptune",
                Subtitle = "The good of sea",
                HeroImage = "neptune.png",
                Description = "Neptune is the eighth and farthest known planet " +
                "from the Sun. It is the fourth-largest planet in the Solar " +
                "System by diameter, the third-most-massive planet, and the " +
                "densest giant planet. It is 17 times the mass of Earth. ",
                AccentColorStart = Color.FromArgb("#0c293d"),
                AccentColorEnd = Color.FromArgb("#26abe0"),
                Images = new()
                {
                    "https://images-assets.nasa.gov/image/PIA01492/PIA01492~large.jpg?w=1920&h=1917&fit=clip&crop=faces%2Cfocalpoint",
                }
            },
        };

        public static List<Planet> GetFeaturedPlanets()
        {
            var random = new Random();
            var randomizePlanets = planets
                .OrderBy(item => random.Next());

            return randomizePlanets
                .Take(2)
                .ToList();
        }

        public static List<Planet> GetAllPlanets()
            => planets;
    }
}
