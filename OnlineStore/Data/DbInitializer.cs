using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using OnlineStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineStore.Data
{
    public class DbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            AppDbContext context =
                applicationBuilder.ApplicationServices.GetRequiredService<AppDbContext>();

            if (!context.Categories.Any())
            {
                context.Categories.AddRange(Categories.Select(c => c.Value));
            }

            if (!context.Products.Any())
            {
                context.AddRange
                (
                    new Product
                    {
                        Name = "Guzheng",
                        Price = 499.99M,
                        ShortDescription = "Has 21 strings, is 64 inches (1.6 m) long, and is tuned in a major pentatonic scale.",
                        FullDescription = "It has a large, resonant soundboard made from Paulownia. Other components are often made from other woods for structural or decorative reasons. Guzheng players often wear fingerpicks made from materials such as plastic, resin, tortoiseshell, or ivory on one or both hands.",
                        Category = Categories["Chordophones"],
                        ImageUrl = "http://www.allthemusicalinstrumentsoftheworld.com/pics/ourbusinesses--thumb-1407028857.jpg",
                        InStock = true
                    },
                    new Product
                    {
                        Name = "Cimbalom",
                        Price = 950M,
                        ShortDescription = "A type of chordophone composed of a large, trapezoidal box with metal strings stretched across its top.",
                        FullDescription = "It is a musical instrument commonly found in the group of Central-Eastern European nations and cultures, namely contemporary Hungary, Slovakia, Czech Republic, Croatia, Romania, Moldova, Ukraine, Belarus and Poland. It is also popular in Greece and in gypsy music. The cimbalom is (typically) played by striking two beaters against the strings. The steel treble strings are arranged in groups of 4 and are tuned in unison. The bass strings which are over-spun with copper, are arranged in groups of 3 and are also tuned in unison. The Hornbostel–Sachs musical instrument classification system registers the cimbalom with the number 314.122-4,5.[1] Moreover, the instrument name “cimbalom” also denotes earlier, smaller versions of the cimbalom, and folk cimbaloms, of different tone groupings, string arrangements, and box types.",
                        Category = Categories["Chordophones"],
                        ImageUrl = "http://www.allthemusicalinstrumentsoftheworld.com/pics/ourbusinesses--thumb-1405852711.jpg",
                        InStock = true
                    },
                    new Product
                    {
                        Name = "Gusli",
                        Price = 350M,
                        ShortDescription = "The oldest East Slavic multi-string plucked instrument, belonging to the zither family, due to its strings being parallel to its resonance board.",
                        FullDescription = "Its roots lie in Veliky Novgorod in Novgorodian Rus'. It may have a connection to the Byzantine form of the Greek kythare, which in turn derived from the ancient lyre, or might have been imported from Western and Central Europe during the Middle Ages, when the zither had immense popularity. It has its relatives in Europe and throughout the world: kantele in Finland, kannel in Estonia, kanklės in Lithuania, kokles in Latvia, Zitter in Germany, citera in Czechia, psalterium in France and so on... Furthermore, the kanun has been found in Arabic countries, and the autoharp, in the United States. It is also related to such ancient instruments as Chinese gu zheng, which has a thousand-year history, and its Japanese relative koto. A stringed musical instrument called guslim is listed as one of the Me in ancient Sumer.",
                        Category = Categories["Chordophones"],
                        ImageUrl = "http://www.allthemusicalinstrumentsoftheworld.com/pics/ourbusinesses--thumb-1407028703.jpg",
                        InStock = true
                    },
                    new Product
                    {
                        Name = "Djembe",
                        Price = 250M,
                        ShortDescription = "a rope-tuned skin-covered goblet drum played with bare hands, originally from West Africa.",
                        FullDescription = "The djembe has a body (or shell) carved of hardwood and a drumhead made of untreated (not limed) rawhide, most commonly made from goatskin. Excluding rings, djembes have an exterior diameter of 30–38 cm (12–15 in) and a height of 58–63 cm (23–25 in). The majority have a diameter in the 13 to 14 inch range. The weight of a djembe ranges from 5 kg to 13 kg (11–29 lb) and depends on size and shell material. A medium-size djembe carved from one of the traditional woods (including skin, rings, and rope) weighs around 9 kg (20 lb).",
                        Category = Categories["Membranophones"],
                        ImageUrl = "http://www.allthemusicalinstrumentsoftheworld.com/pics/ourbusinesses--thumb-1408354314.jpg",
                        InStock = true
                    },
                    new Product
                    {
                        Name = "Bongo drum",
                        Price = 599M,
                        ShortDescription = "Afro-Cuban percussion instrument consisting of a pair of small open bottomed drums of different sizes.",
                        Category = Categories["Membranophones"],
                        FullDescription = "Bongo drums produce relatively high-pitched sounds compared to conga drums, and should be held behind the knees with the larger drum on the right when right-handed. It is most often played by hand and is especially associated in Cuban music with a steady pattern or ostinato of eighth-notes known as the martillo or 'hammer'. They are traditionally played by striking the edge of the drumheads with the fingers and palms. The glissando used with bongó de monte is done by rubbing the third finger, supported by the thumb, across the head of the drum. The finger is sometimes moistened with saliva, or sweat before rubbing it across the head.[22] When used in art music compositions they are usually struck with drum sticks. These drums can also be played on a stand, as is the case with concert orchestras and bands.",
                        ImageUrl = "http://www.allthemusicalinstrumentsoftheworld.com/pics/ourbusinesses--thumb-1408227661.jpg",
                        InStock = true
                    },
                    new Product
                    {
                        Name = "Cuíca",
                        Price = 900M,
                        ShortDescription = "Brazilian friction drum with a large pitch range, produced by changing tension on the head of the drum.",
                        FullDescription = "Cuíca is Portuguese for the gray four-eyed opossum (Philander opossum) which is known for its high-pitched cry. It is frequently used in carnivals,[1] as well as often in samba music. The tone it produces has a high-pitched squeaky timbre. It has been called a 'laughing gourd' due to this sound. Many also liken its sound to that of a monkey.",
                        Category = Categories["Membranophones"],
                        ImageUrl = "http://www.allthemusicalinstrumentsoftheworld.com/pics/ourbusinesses--thumb-1408347475.jpg",
                        InStock = false
                    },
                    new Product
                    {
                        Name = "Timpani",
                        Price = 2499.99M,
                        ShortDescription = "A type of drum categorised as a semispherical drum",
                        FullDescription = "A type of drum categorised as a semispherical drum, they consist of a membrane called a head stretched over a large bowl traditionally made of copper. Most modern timpani are pedal timpani and can be tuned quickly and accurately to specific pitches by skilled players through the use of a movable foot-pedal. They are played by striking the head with a specialized drum stick called a timpani stick or timpani mallet. Timpani evolved from military drums to become a staple of the classical orchestra by the last third of the 18th century. Today, they are used in many types of ensembles, including concert bands, marching bands, orchestras, and even in some rock bands.",
                        Category = Categories["Membranophones"],
                        ImageUrl = "http://imgh.us/jagermeisterL.jpg",
                        InStock = false
                    },
                    new Product
                    {
                        Name = "Dundun",
                        Price = 5000M,
                        ShortDescription = "Dundun, membranophone from Mali.",
                        FullDescription = "A dunun is a rope-tuned cylindrical drum with a rawhide skin at both ends, most commonly cow or goat. The drum is played with a stick. Depending on the region, a plain straight stick, curved stick with flat head (similar to the stick used for a tama), or a straight stick with a cylindrical head attached at right angles near one end may be used to strike the skin.",
                        Category = Categories["Membranophones"],
                        ImageUrl = "https://cdn.britannica.com/89/150589-004-B285F698.jpg",
                        InStock = true
                    },
                    new Product
                    {
                        Name = "Guitar",
                        Price = 350M,
                        ShortDescription = "A fretted musical instrument that usually has six strings.",
                        FullDescription = "The guitar is a type of chordophone, traditionally constructed from wood and strung with either gut, nylon or steel strings and distinguished from other chordophones by its construction and tuning. The modern guitar was preceded by the gittern, the vihuela, the four-course Renaissance guitar, and the five-course baroque guitar, all of which contributed to the development of the modern six-string instrument.",
                        Category = Categories["Chordophones"],
                        ImageUrl = "https://www.talentz.net/wp-content/uploads/CG10-2.jpg",
                        InStock = true
                    },
                    new Product
                    {
                        Name = "Accordion",
                        Price = 3500M,
                        ShortDescription = "A family of box-shaped musical instruments of the bellows-driven free-reed aerophone type, colloquially referred to as a squeezebox.",
                        FullDescription = "The instrument is played by compressing or expanding the bellows while pressing buttons or keys, causing pallets to open, which allow air to flow across strips of brass or steel, called reeds. These vibrate to produce sound inside the body. Valves on opposing reeds of each note are used to make the instrument's reeds sound louder without air leaking from each reed block.[notes 1] The performer normally plays the melody on buttons or keys on the right-hand manual, and the accompaniment, consisting of bass and pre-set chord buttons, on the left-hand manual.",
                        Category = Categories["Aerophones"],
                        ImageUrl = "http://www.allthemusicalinstrumentsoftheworld.com/pics/ourbusinesses--thumb-1405808717.jpg",
                        InStock = true
                    },
                    new Product
                    {
                        Name = "Piccolo",
                        Price = 250M,
                        ShortDescription = "A half-size flute, and a member of the woodwind family of musical instruments.",
                        FullDescription = "The modern piccolo has most of the same fingerings as its larger sibling, the standard transverse flute, but the sound it produces is an octave higher than written. This gave rise to the name ottavino (Italian for 'little octave'), which the instrument is called in the scores of Italian composers. It is also called flauto piccolo or flautino. Early 19th - century French piccolo in D - flat. Piccolos are now mainly manufactured in the key of C.In the early 20th century, piccolos were manufactured in D♭ as they were an earlier model of the modern piccolo. It was for this D♭ piccolo that John Philip Sousa wrote the famous solo in the final repeat of the closing section(trio) of his march 'The Stars and Stripes Forever'.",
                        Category = Categories["Aerophones"],
                        ImageUrl = "http://www.allthemusicalinstrumentsoftheworld.com/pics/ourbusinesses--thumb-1407644400.jpg",
                        InStock = false
                    },
                    new Product
                    {
                        Name = "Alto horn",
                        Price = 899M,
                        ShortDescription = "A brass instrument in the saxhorn family, and is usually pitched in E♭.",
                        FullDescription = "The tenor horn is a valved brass instrument (in E♭) which has a predominantly conical bore like the baritone horn and flugelhorn. It uses a deep funnel- or cup-shaped mouthpiece. The tenor horn's conical bore and deep mouthpiece produce a mellow, rounded tone which is often used as a middle voice, supporting the melodies of the trumpets, cornets or flugelhorns, and filling the gap above the lower tenor and bass instruments (the trombone, baritone horn, euphonium and tuba). Its valves are typically, though not exclusively, piston valves.",
                        Category = Categories["Aerophones"],
                        ImageUrl = "http://www.allthemusicalinstrumentsoftheworld.com/pics/ourbusinesses--thumb-1407835425.jpg",
                        InStock = true
                    },
                    new Product
                    {
                        Name = "Baritone horn",
                        Price = 849M,
                        ShortDescription = "A low-pitched brass instrument in the saxhorn family.",
                        FullDescription = "It is a piston-valve brass instrument with a bore that is mostly conical, like the flugelhorn and alto (tenor) horn, but is narrower than the conical bore of the euphonium. It uses a wide-rimmed cup mouthpiece like that of its peers, the trombone and euphonium. Like the trombone and the euphonium, the baritone horn can be considered either a transposing or non-transposing instrument.",
                        Category = Categories["Aerophones"],
                        ImageUrl = "http://www.allthemusicalinstrumentsoftheworld.com/pics/ourbusinesses--thumb-1407921230.jpg",
                        InStock = true
                    },
                    new Product
                    {
                        Name = "Harmoneon",
                        Price = 159.5M,
                        ShortDescription = "The Harmoneon - A remarkable musical novelty which produces chords of the most pleasing quality.",
                        FullDescription = "Similar to those of an aeolian harp. Made of beautifully decorated metal. Inside are arranged reeds same as in an organ. As the instrument is revolved by means of a cord held in the hands, the air played upon the reeds produces the most exquisite melody, swelling and diminishing as force is given by the operator.",
                        Category = Categories["Aerophones"],
                        ImageUrl = "http://www.allthemusicalinstrumentsoftheworld.com/pics/ourbusinesses--thumb-1409559243.jpg",
                        InStock = false
                    },
                    new Product
                    {
                        Name = "Biniou",
                        Price = 12.95M,
                        ShortDescription = "The binioù kozh has a one octave scale, and is very high-pitched with a soprano sound.",
                        FullDescription = "It is tuned to play one octave higher than the bombard which it accompanies. More traditional forms have a single drone, while modern instruments sometimes have two. In the old days the leather used for the bag was usually from a dog's skin, but this is nowadays replaced by synthetic materials or other leathers which are easier to procure, like cow or sheep.",
                        Category = Categories["Aerophones"],
                        ImageUrl = "http://www.allthemusicalinstrumentsoftheworld.com/pics/ourbusinesses--thumb-1408102177.jpg",
                        InStock = false
                    }
                );
            }
            context.SaveChanges();
        }

        private static Dictionary<string, Category> categories;
        public static Dictionary<string, Category> Categories
        {
            get
            {
                if (categories == null)
                {
                    var categoriesList = new Category[]
                    {
                        new Category { CategoryName = "Chordophones"},
                        new Category { CategoryName = "Membranophones"},
                        new Category { CategoryName = "Aerophones"}
                    };

                    categories = new Dictionary<string, Category>();

                    foreach (Category genre in categoriesList)
                    {
                        categories.Add(genre.CategoryName, genre);
                    }
                }

                return categories;
            }
        }
    }
}
