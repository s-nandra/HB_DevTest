using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace HonestBobs.Website.Dal
{
    public class DatabaseInitializer : DropCreateDatabaseIfModelChanges<HBContext>
    {
        protected override void Seed(HBContext context)
        {
            GetCategories().ForEach(c => context.Categories.Add(c));
            GetBooks().ForEach(p => context.Books.Add(p));
        }

        private static List<Category> GetCategories()
        {
            var categories = new List<Category> {
                new Category
                {
                    CategoryID = 1,
                    CategoryName = "Books",
                    IsActive = true
                },
                new Category
                {
                    CategoryID = 2,
                    CategoryName = "Movies",
                    IsActive = true
                },
                new Category
                {
                    CategoryID = 3,
                    CategoryName = "Music",
                    IsActive = false
                }
            };

            return categories;
        }

        private static List<Book> GetBooks()
        {
            var books = new List<Book> {
                new Book
                {
                    BookID = 1,
                    BookName = "Before I Go To Sleep",
                    BookDescription = "Memories define us. So what if you lost yours every time you went to sleep? An original, " +
                                        "haunting and deeply chilling debut thriller, and aSunday Timesbestseller in hardcover.",

                    BookPrice = 3.86,
                    Author ="S J Watson",
                    ISBN="978 - 0552164139",
                    CategoryID = 1,
                    PageCount=384,
                    IsActive=true
               },
                new Book
                {
                    BookID = 2,
                    BookName = "War Horse",
                    BookDescription = "From master storyteller, Michael Morpurgo comes an incredibly moving story " +
                    "about one horse's experience in the deadly chaos of the first world war. In 1914, Joey, a young farm horse, " +
                    "is sold to the army and thrust into the midst of the war on the Western Front. With his officer, " +
                    "he charges towards the enemy, witnessing the horror of the frontline. " +
                    "But even in the desolation of the trenches, Joey's courage touches the soldiers around him.",

                    BookPrice = 3.86,
                    Author ="Michael Morpurgo",
                    ISBN="978-1405226660",
                    CategoryID = 1,
                    PageCount=192,
                    IsActive=true
               },
                new Book
                {
                    BookID = 3,
                    BookName = "Diary of a Wimpy Kid: The Ugly Truth",
                    BookDescription = "Catch the hapless Greg Heffley as he navigates his way through family and school life with his best friend, " +
                    "Rowley, by his side in a brand new Wimpy Kid adventure!",

                    BookPrice = 4.69,
                    Author ="Jeff Kinny",
                    ISBN="978-0141340821",
                    CategoryID = 1,
                    PageCount=240
               },
                new Book
                {
                    BookID = 4,
                    BookName = "The Fabulous Baker Brothers",
                    BookDescription = "Tom and Henry Herbert - The Fabulous Baker Brothers - are fifth generation bakers with a passion for food in all its forms. " +
                    "Tom is a talented master baker whose famous Hobbs House Bakery sits just next door to his younger brother Henry's butchery. " +
                    "Together our young brothers work side by side making the amazing bread and delicious meaty accompaniments and fillings that have made their businesses so successful.",
                    BookPrice = 10.99,
                    Author ="Tom Herbert",
                    ISBN="978-0755363650",
                    CategoryID = 1,
                    PageCount=256,
                    IsActive=true
               },
                new Book
                {
                    BookID = 5,
                    BookName = "The Prisoner",
                    BookDescription = "One of Henderson's best agents is being held captive in Frankfurt. A set of forged record cards could be his ticket to freedom, but might just as easily become his death warrant. A vital mission awaits him in France - if he can find a way to escape.",
                    BookPrice = 4.33,
                    Author ="Robert Muchamore",
                    ISBN="978-0340999172",
                    CategoryID = 1,
                    PageCount=368,
                    IsActive=true
               }
            };
            return books;
        }

        private static List<Movie> GetMovies()
        {
            var movies = new List<Movie>
            {
                new Movie
                {
                    MovieID=1,
                    MovieName="Sherlock - Series 1",
                    MovieDescription="A contemporary take on the classic Arthur Conan Doyle stories, Sherlockis a thrilling, funny, " +
                    "fast - paced adventure series set in present - day London.Co - created by Steven Moffat and Mark Gatiss, " +
                    "Sherlockstars Benedict Cumberbatch as the new Sherlock Holmes and Martin Freeman as his loyal friend, #" +
                    "Doctor John Watson. Rupert Graves plays Inspector Lestrade.",
                    MoviePrice=4.99,
                    Format="DVD",
                    Disc=2,
                    Studio="2entertain",
                    CategoryID=2,
                    IsActive=true
                },
                new Movie
                {
                    MovieID=2,
                    MovieName="The Inbetweeners Movie",
                    MovieDescription="Will (Simon Bird), Simon (Joe Thomas), Jay (James Buckley) and Neil (Blake Harrison), have finished school forever, and are off on their first lads holiday. They‘re looking forward to two weeks in Malia with no parents, no teachers and little chance with the ladies.",
                    MoviePrice=9.99,
                    Format="DVD",
                    Disc=1,
                    Studio="Channel 4 DVD",
                    CategoryID=2,
                    IsActive=true
                },
                new Movie
                {
                    MovieID=3,
                    MovieName="James Bond - 22 Film Collection",
                    MovieDescription="Collectible box set featuring all 22 James Bond films on Blu-ray disc in one complete offering for the first time.",
                     MoviePrice =89.99,
                    Format="Blu-ray",
                    Disc=22,
                    Studio="MGM",
                    CategoryID=2,
                    IsActive=true
                },
                new Movie
                {
                    MovieID=4,
                    MovieName="Harry Potter - The Complete 8-Film Collection",
                    MovieDescription="From the first spell to the final battle! The entire eight-film Harry Potter collection is now available for you to own.",
                     MoviePrice =37.99,
                    Format="Blu-ray",
                    Disc=11,
                    Studio="Warner",
                    CategoryID=2,
                    IsActive=true
                }
            };
            return movies;
        }
    }
}