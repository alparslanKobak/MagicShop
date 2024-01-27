using MagicShop.Kernel.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicShop.Business
{
    public class DbSeeder
    {
        public static void Seed(DatabaseContext _context)
        {

            SeedAppUsers(_context);
            SeedCategory(_context);
            SeedHoroscope(_context);
            SeedProduct(_context);
            SeedBlogPost(_context);
            SeedCart(_context);
            SeedCardItem(_context);
            SeedComment(_context);
            SeedContact(_context);

        }

        private static void SeedAppUsers(DatabaseContext _context)
        {
            if (!_context.AppUsers.Any())
            {
                _context.AppUsers.AddRange(
                    new AppUser
                    {

                        UserName = "Admin",

                        Email = "admin@magicshop.com",
                        Password = "123456",

                    },
                    new AppUser
                    {

                        UserName = "horoscopelover",

                        Email = "horoscopelover@gmail.com",
                        Password = "123456"
                    },
                    new AppUser
                    {

                        UserName = "horoscopebeliever",

                        Email = "horoscopebeliever@gmail.com",
                        Password = "123456"
                    }
                    );
                _context.SaveChanges();
            }

        }

        private static void SeedCategory(DatabaseContext _context)
        {
            if (!_context.Categories.Any())
            {
                _context.Categories.AddRange(

                    new Category
                    {
                        CategoryName = "Service",
                        Slug = "service",

                    },
                    new Category
                    {
                        CategoryName = "Product",
                        Slug = "product",

                    }
                    );

                _context.SaveChanges();
            }

        }

        private static void SeedHoroscope(DatabaseContext _context)
        {
            if (!_context.Horoscopes.Any())
            {
                _context.Horoscopes.AddRange(
                    new Horoscope
                    {
                        HoroscopeName = "Aries",
                        HoroscopeDescription = "Aries is the first sign of the zodiac, and that’s pretty much how those born under this sign see themselves: first. Aries are the leaders of the pack, first in line to get things going. Whether or not everything gets done is another question altogether, for an Aries prefers to initiate rather than to complete. Do you have a project needing a kick-start? Call an Aries, by all means. The leadership displayed by Aries is most impressive, so don’t be surprised if they can rally the troops against seemingly insurmountable odds—they have that kind of personal magnetism.",
                        HoroscopeImage = "aries.jpg",
                        HoroscopeIcon = "aries.png",
                        Slug = "aries",

                    },
                    new Horoscope
                    {
                        HoroscopeName = "Taurus",
                        HoroscopeDescription = "Smart, ambitious, and trustworthy, Taurus is the anchor of the Zodiac. Amazing friends, colleagues, and partners, Taureans value honesty above all else and are proud that their personal relationships tend to be drama free. Bulls get the reputation of being stubborn, but they're not always stuck in their ways. This searching sign is willing to see another point of view, but they won't flip-flop on an opinion just to make someone else happy. They will shift their thinking only if they truly have a change of heart.",
                        HoroscopeImage = "taurus.jpg",
                        HoroscopeIcon = "taurus.png",
                        Slug = "taurus",

                    },
                    new Horoscope
                    {
                        HoroscopeName = "Gemini",
                        HoroscopeDescription = "Have you ever been so busy that you wished you could clone yourself just to get everything done? That’s the Gemini experience in a nutshell. Appropriately symbolized by the celestial twins, this air sign was interested in so many pursuits that it had to double itself. Because of Geminis' intrinsic duality, they're often falsely misrepresented as two-faced. In reality, however, Gemini rarely has a hidden agenda. Playful and intellectually curious, Gemini is constantly juggling a variety of passions, hobbies, careers, and friend groups. They are the social butterflies of the zodiac: These quick-witted twins can talk to anyone about anything. Find them buzzing between happy hours, dinner parties, and dance floors.",
                        HoroscopeImage = "gemini.jpg",
                        HoroscopeIcon = "gemini.png",
                        Slug = "gemini",

                    },
                    new Horoscope
                    {
                        HoroscopeName = "Cancer",
                        HoroscopeDescription = "Emotional, intuitive, and practically psychic; ruled by the moon and characterized by the crab, Cancer has so much going on in its watery depths. Cancers may seem prickly and standoffish at first meeting, once they make the decision to become friends with someone, that person has a friend for life.",
                        HoroscopeImage = "cancer.jpg",
                        HoroscopeIcon = "cancer.png",
                        Slug = "cancer",

                    },
                    new Horoscope
                    {
                        HoroscopeName = "Leo",
                        HoroscopeDescription = "Bold, intelligent, warm, and courageous, fire sign Leo is a natural leader of the Zodiac, ready to blaze a trail, vanquish injustice, and make a name for themselves along the way. Blessed with high self-esteem, Lions know that they possess enviable traits—and they're proud of them. They don't believe in false modesty and will be the first to praise themselves for a job well done. But Leo isn't self-aggrandizing or unwilling to roll up those sleeves and do the work: this sign knows that in order to be respected and admired, he or she needs to put in the effort worthy of a leader.",
                        HoroscopeImage = "leo.jpg",
                        HoroscopeIcon = "leo.png",
                        Slug = "leo",

                    },
                    new Horoscope
                    {
                        HoroscopeName = "Virgo",
                        HoroscopeDescription = "Smart, sophisticated, and kind, Virgo gets the job done without complaining. Virgos are amazing friends, always there to lend a hand and also lend advice. Practical Virgos are incredibly adept at big picture thinking, and planning out their life, their vacations, and what they're going to do today isn't a drag it makes them feel in control and secure.",
                        HoroscopeImage = "virgo.jpg",
                        HoroscopeIcon = "virgo.png",
                        Slug = "virgo",

                    },
                    new Horoscope
                    {
                        HoroscopeName = "Libra",
                        HoroscopeDescription = "Intelligent, kind, and always willing to put others before themselves, Libras value harmony in all forms. Ruled by Venus, the planet of beauty, Libra adores a life that looks good. As the master of compromise and diplomacy, Libra is adept at seeing all points of view and excels at crafting compromises and effecting mediation between others. This sign has a rich inner life yet loves other people, and they're always happiest with a large group of friends, family, and coworkers on whom they can count.",
                        HoroscopeImage = "libra.jpg",
                        HoroscopeIcon = "libra.png",
                        Slug = "libra",

                    },
                    new Horoscope
                    {
                        HoroscopeName = "Scorpio",
                        HoroscopeDescription = "Passionate, independent, and unafraid to blaze their own trail no matter what others think, Scorpios make a statement wherever they go. They love debates, aren't afraid of controversy, and won't back down from a debate. They also hate people who aren't genuine, and are all about being authentic—even if authentic isn't pretty.",
                        HoroscopeImage = "scorpio.jpg",
                        HoroscopeIcon = "scorpio.png",
                        Slug = "scorpio",

                    },
                    new Horoscope
                    {
                        HoroscopeName = "Sagittarius",
                        HoroscopeDescription = "Independent and strong-willed, Sagittarius personalities are all about going off the beaten path. Sagittarius isn’t afraid to step away from the pack, and is a natural born leader who goes after what he or she wants, regardless of what other people think. Sagittarius is a born adventurer, and loves solo travel and exploration. Sagittarius also loves exploring the inner workings of their minds, and love stretching their horizons through a good book or movie.",
                        HoroscopeImage = "sagittarius.jpg",
                        HoroscopeIcon = "sagittarius.png",
                        Slug = "sagittarius",

                    },
                    new Horoscope
                    {
                        HoroscopeName = "Capricorn",
                        HoroscopeDescription = "Smart, hardworking, and fully in control of their destiny, a Capricorn will always get what they set their mind to, in both personal and professional life—no excuses. Capricorns may get a reputation as stubborn, but they simply know what they want, and also know how they wish other people would behave.",
                        HoroscopeImage = "capricorn.jpg",
                        HoroscopeIcon = "capricorn.png",
                        Slug = "capricorn",

                    },
                    new Horoscope
                    {
                        HoroscopeName = "Aquarius",
                        HoroscopeDescription = "Independent and enigmatical, Aquarians are unique. There is no one quite like an Aquarius, and because each is so incredibly individual, it can be tough to describe them as a group. Aquarians don't like labels, and may shy away from any adjective—even the good ones you might bestow upon them. Aquarians believe in the nature of change and evolution, and even though they're a fixed sign, they may not necessarily believe they are the \"same\" people they were when they were born.",
                        HoroscopeImage = "aquarius.jpg",
                        HoroscopeIcon = "aquarius.png",
                        Slug = "aquarius",

                    },
                    new Horoscope
                    {
                        HoroscopeName = "Pisces",
                        HoroscopeDescription = "Smart, creative, and deeply intuitive, Pisces can be close to psychic. Pisces feel things deeply, and have incredibly strong gut reactions. A Pisces \"knows\" things from deep within, and can often judge whether a person or situation is good or bad. That doesn't mean a Pisces ignores the logical part of their brain, though. Deeply intelligent, Pisces have a profound respect for the power of the human mind. Is it a surprise that Albert Einstein was a Pisces?",
                        HoroscopeImage = "pisces.jpg",
                        HoroscopeIcon = "pisces.png",
                        Slug = "pisces",

                    }
                    );
                _context.SaveChanges();
            }
        }

        private static void SeedProduct(DatabaseContext _context)
        {

            if (!_context.Products.Any())
            {
                _context.Products.AddRange(
                    new Product
                    {
                        CategoryId = _context.Categories.FirstOrDefault(x => x.CategoryName == "Product").CategoryId,
                        ProductName = "Magic Wand",
                        ProductDescription = "A magic wand is a wand that is used by a magician to channel magic energies, and is often used in magic rituals.",
                        ProductImage = "magicwand.jpg",
                        Slug = "magic-wand",
                        ProductPrice = 100,

                    },
                    new Product
                    {
                        CategoryId = _context.Categories.FirstOrDefault(x => x.CategoryName == "Product").CategoryId,
                        ProductName = "Magic Hat",
                        ProductDescription = "A magic hat is a hat that is used by a magician to channel magic energies, and is often used in magic rituals.",
                        ProductImage = "magichat.jpg",
                        Slug = "magic-hat",
                        ProductPrice = 200,

                    },
                    new Product
                    {
                        CategoryId = _context.Categories.FirstOrDefault(x => x.CategoryName == "Product").CategoryId,
                        ProductName = "Magic Cloak",
                        ProductDescription = "A magic cloak is a cloak that is used by a magician to channel magic energies, and is often used in magic rituals.",
                        ProductImage = "magiccloak.jpg",
                        Slug = "magic-cloak",
                        ProductPrice = 300,

                    },
                    new Product
                    {
                        CategoryId = _context.Categories.FirstOrDefault(x => x.CategoryName == "Service").CategoryId,
                        ProductName = "Magic Lesson",
                        ProductDescription = "A magic lesson is a lesson that is used by a magician to channel magic energies, and is often used in magic rituals.",
                        ProductImage = "magiclesson.jpg",
                        Slug = "magic-lesson",
                        ProductPrice = 400,

                    },
                    new Product
                    {
                        CategoryId = _context.Categories.FirstOrDefault(x => x.CategoryName == "Service").CategoryId,
                        ProductName = "Magic Show",
                        ProductDescription = "A magic show is a show that is used by a magician to channel magic energies, and is often used in magic rituals.",
                        ProductImage = "magicshow.jpg",
                        Slug = "magic-show",
                        ProductPrice = 500,

                    },
                    new Product
                    {
                        CategoryId = _context.Categories.FirstOrDefault(x => x.CategoryName == "Service").CategoryId,
                        ProductName = "Magic Trick",
                        ProductDescription = "A magic trick is a trick that is used by a magician to channel magic energies, and is often used in magic rituals.",
                        ProductImage = "magictrick.jpg",
                        Slug = "magic-trick",
                        ProductPrice = 600,

                    },
                    new Product
                    {
                        CategoryId = _context.Categories.FirstOrDefault(x => x.CategoryName == "Service").CategoryId,
                        ProductName = "Love Spell",
                        ProductDescription = "A love spell is a spell that is used by a magician to channel magic energies, and is often used in magic rituals.",
                        ProductImage = "lovespell.jpg",
                        Slug = "love-spell",
                        ProductPrice = 700,

                    }

                    );
                _context.SaveChanges();

            }
        }

        private static void SeedBlogPost(DatabaseContext _context)
        {
            if (!_context.BlogPosts.Any())
            {
                _context.BlogPosts.AddRange(

                    new BlogPost
                    {
                        BlogPostContent = "Aries is the first sign of the zodiac, and that’s pretty much how those born under this sign see themselves: first. Aries are the leaders of the pack, first in line to get things going. Whether or not everything gets done is another question altogether, for an Aries prefers to initiate rather than to complete. Do you have a project needing a kick-start? Call an Aries, by all means. The leadership displayed by Aries is most impressive, so don’t be surprised if they can rally the troops against seemingly insurmountable odds—they have that kind of personal magnetism.",
                        BlogPostImage = "aries.jpg",
                        BlogPostName = "Aries : Sign of the Zodiac",
                        Slug = "aries-sign-of-the-zodiac",
                        HoroscopeId = _context.Horoscopes.FirstOrDefault(x => x.HoroscopeName == "Aries").HoroscopeId,

                    },
                    new BlogPost
                    {
                        BlogPostContent = "Smart, ambitious, and trustworthy, Taurus is the anchor of the Zodiac. Amazing friends, colleagues, and partners, Taureans value honesty above all else and are proud that their personal relationships tend to be drama free. Bulls get the reputation of being stubborn, but they're not always stuck in their ways. This searching sign is willing to see another point of view, but they won't flip-flop on an opinion just to make someone else happy. They will shift their thinking only if they truly have a change of heart.",
                        BlogPostImage = "taurus.jpg",
                        BlogPostName = "Taurus : Sign of the Zodiac",
                        Slug = "taurus-sign-of-the-zodiac",
                        HoroscopeId = _context.Horoscopes.FirstOrDefault(x => x.HoroscopeName == "Taurus").HoroscopeId,

                    },
                    new BlogPost
                    {
                        BlogPostContent = "Have you ever been so busy that you wished you could clone yourself just to get everything done? That’s the Gemini experience in a nutshell. Appropriately symbolized by the celestial twins, this air sign was interested in so many pursuits that it had to double itself. Because of Geminis' intrinsic duality, they're often falsely misrepresented as two-faced. In reality, however, Gemini rarely has a hidden agenda. Playful and intellectually curious, Gemini is constantly juggling a variety of passions, hobbies, careers, and friend groups. They are the social butterflies of the zodiac: These quick-witted twins can talk to anyone about anything. Find them buzzing between happy hours, dinner parties, and dance floors.",
                        BlogPostImage = "gemini.jpg",
                        BlogPostName = "Gemini : Sign of the Zodiac",
                        Slug = "gemini-sign-of-the-zodiac",
                        HoroscopeId = _context.Horoscopes.FirstOrDefault(x => x.HoroscopeName == "Gemini").HoroscopeId,

                    },
                    new BlogPost
                    {
                        BlogPostContent = "Emotional, intuitive, and practically psychic; ruled by the moon and characterized by the crab, Cancer has so much going on in its watery depths. Cancers may seem prickly and standoffish at first meeting, once they make the decision to become friends with someone, that person has a friend for life.",
                        BlogPostImage = "cancer.jpg",
                        BlogPostName = "Cancer : Sign of the Zodiac",
                        Slug = "cancer-sign-of-the-zodiac",
                        HoroscopeId = _context.Horoscopes.FirstOrDefault(x => x.HoroscopeName == "Cancer").HoroscopeId,

                    },
                    new BlogPost
                    {
                        BlogPostContent = "Bold, intelligent, warm, and courageous, fire sign Leo is a natural leader of the Zodiac, ready to blaze a trail, vanquish injustice, and make a name for themselves along the way. Blessed with high self-esteem, Lions know that they possess enviable traits—and they're proud of them. They don't believe in false modesty and will be the first to praise themselves for a job well done. But Leo isn't self-aggrandizing or unwilling to roll up those sleeves and do the work: this sign knows that in order to be respected and admired, he or she needs to put in the effort worthy of a leader.",
                        BlogPostImage = "leo.jpg",
                        BlogPostName = "Leo : Sign of the Zodiac",
                        Slug = "leo-sign-of-the-zodiac",
                        HoroscopeId = _context.Horoscopes.FirstOrDefault(x => x.HoroscopeName == "Leo").HoroscopeId,

                    },
                    new BlogPost
                    {
                        BlogPostContent = "Smart, sophisticated, and kind, Virgo gets the job done without complaining. Virgos are amazing friends, always there to lend a hand and also lend advice. Practical Virgos are incredibly adept at big picture thinking, and planning out their life, their vacations, and what they're going to do today isn't a drag it makes them feel in control and secure.",
                        BlogPostImage = "virgo.jpg",
                        BlogPostName = "Virgo : Sign of the Zodiac",
                        Slug = "virgo-sign-of-the-zodiac",
                        HoroscopeId = _context.Horoscopes.FirstOrDefault(x => x.HoroscopeName == "Virgo").HoroscopeId,

                    },
                    new BlogPost
                    {
                        BlogPostContent = "Intelligent, kind, and always willing to put others before themselves, Libras value harmony in all forms. Ruled by Venus, the planet of beauty, Libra adores a life that looks good. As the master of compromise and diplomacy, Libra is adept at seeing all points of view and excels at crafting compromises and effecting mediation between others. This sign has a rich inner life yet loves other people, and they're always happiest with a large group of friends, family, and coworkers on whom they can count.",
                        BlogPostImage = "libra.jpg",
                        BlogPostName = "Libra : Sign of the Zodiac",
                        Slug = "libra-sign-of-the-zodiac",
                        HoroscopeId = _context.Horoscopes.FirstOrDefault(x => x.HoroscopeName == "Libra").HoroscopeId,

                    },
                    new BlogPost
                    {
                        BlogPostContent = "Passionate, independent, and unafraid to blaze their own trail no matter what others think, Scorpios make a statement wherever they go. They love debates, aren't afraid of controversy, and won't back down from a debate. They also hate people who aren't genuine, and are all about being authentic—even if authentic isn't pretty.",
                        BlogPostImage = "scorpio.jpg",
                        BlogPostName = "Scorpio : Sign of the Zodiac",
                        Slug = "scorpio-sign-of-the-zodiac",
                        HoroscopeId = _context.Horoscopes.FirstOrDefault(x => x.HoroscopeName == "Scorpio").HoroscopeId,

                    },
                    new BlogPost
                    {
                        BlogPostContent = "Independent and strong-willed, Sagittarius personalities are all about going off the beaten path. Sagittarius isn’t afraid to step away from the pack, and is a natural born leader who goes after what he or she wants, regardless of what other people think. Sagittarius is a born adventurer, and loves solo travel and exploration. Sagittarius also loves exploring the inner workings of their minds, and love stretching their horizons through a good book or movie.",
                        BlogPostImage = "sagittarius.jpg",
                        BlogPostName = "Sagittarius : Sign of the Zodiac",
                        Slug = "sagittarius-sign-of-the-zodiac",
                        HoroscopeId = _context.Horoscopes.FirstOrDefault(x => x.HoroscopeName == "Sagittarius").HoroscopeId,

                    },
                    new BlogPost
                    {
                        BlogPostContent = "Smart, hardworking, and fully in control of their destiny, a Capricorn will always get what they set their mind to, in both personal and professional life—no excuses. Capricorns may get a reputation as stubborn, but they simply know what they want, and also know how they wish other people would behave.",
                        BlogPostImage = "capricorn.jpg",
                        BlogPostName = "Capricorn : Sign of the Zodiac",
                        Slug = "capricorn-sign-of-the-zodiac",
                        HoroscopeId = _context.Horoscopes.FirstOrDefault(x => x.HoroscopeName == "Capricorn").HoroscopeId,

                    },
                    new BlogPost
                    {
                        BlogPostContent = "Independent and enigmatical, Aquarians are unique. There is no one quite like an Aquarius, and because each is so incredibly individual, it can be tough to describe them as a group. Aquarians don't like labels, and may shy away from any adjective—even the good ones you might bestow upon them. Aquarians believe in the nature of change and evolution, and even though they're a fixed sign, they may not necessarily believe they are the \"same\" people they were when they were born.",
                        BlogPostImage = "aquarius.jpg",
                        BlogPostName = "Aquarius : Sign of the Zodiac",
                        Slug = "aquarius-sign-of-the-zodiac",
                        HoroscopeId = _context.Horoscopes.FirstOrDefault(x => x.HoroscopeName == "Aquarius").HoroscopeId,

                    },
                    new BlogPost
                    {
                        BlogPostContent = "Smart, creative, and deeply intuitive, Pisces can be close to psychic. Pisces feel things deeply, and have incredibly strong gut reactions. A Pisces \"knows\" things from deep within, and can often judge whether a person or situation is good or bad. That doesn't mean a Pisces ignores the logical part of their brain, though. Deeply intelligent, Pisces have a profound respect for the power of the human mind. Is it a surprise that Albert Einstein was a Pisces?",
                        BlogPostImage = "pisces.jpg",
                        BlogPostName = "Pisces : Sign of the Zodiac",
                        Slug = "pisces-sign-of-the-zodiac",
                        HoroscopeId = _context.Horoscopes.FirstOrDefault(x => x.HoroscopeName == "Pisces").HoroscopeId,

                    }
                    );

                _context.SaveChanges();


            }
        }

        private static void SeedCart(DatabaseContext _context)
        {
            if (!_context.Carts.Any())
            {
                _context.Carts.AddRange(

                    new Cart
                    {
                        AppUserId = _context.AppUsers.FirstOrDefault(x => x.UserName == "horoscopelover").AppUserId,

                    },
                    new Cart
                    {
                        AppUserId = _context.AppUsers.FirstOrDefault(x => x.UserName == "horoscopebeliever").AppUserId,

                    }
                    );


                _context.SaveChanges();
            }
        }

        private static void SeedCardItem(DatabaseContext _context)
        {
            if (!_context.CardItems.Any())
            {
                _context.CardItems.AddRange(
                    new CartItem
                    {
                        ProductId = _context.Products.FirstOrDefault(x => x.ProductName == "Magic Wand").ProductId,
                        Quantity = 2,
                        CartId = _context.Carts.FirstOrDefault(x => x.AppUserId == _context.AppUsers.FirstOrDefault(x => x.UserName == "horoscopelover").AppUserId).CartId,
                    },
                    new CartItem
                    {
                        ProductId = _context.Products.FirstOrDefault(x => x.ProductName == "Magic Hat").ProductId,
                        Quantity = 3,
                        CartId = _context.Carts.FirstOrDefault(x => x.AppUserId == _context.AppUsers.FirstOrDefault(x => x.UserName == "horoscopelover").AppUserId).CartId,
                    }
                    );
                _context.SaveChanges();
            }
        }

        private static void SeedComment(DatabaseContext _context)
        {
            if (!_context.Comments.Any())
            {
                _context.Comments.AddRange(

                    new Comment
                    {
                        CommentContent = "I love Aries boys. I am sure they are definetly my type... Amazing!!!!!",
                        CreateDate = DateTime.Now,
                        AppUserId = _context.AppUsers.FirstOrDefault(x => x.UserName == "horoscopelover").AppUserId,
                        BlogPostId = _context.BlogPosts.FirstOrDefault(x => x.BlogPostName == "Aries : Sign of the Zodiac").BlogPostId,
                    },
                    new Comment
                    {
                        CreateDate = DateTime.Now,
                        AppUserId = _context.AppUsers.FirstOrDefault(x => x.UserName == "horoscopebeliever").AppUserId,
                        BlogPostId = _context.BlogPosts.FirstOrDefault(x => x.BlogPostName == "Taurus : Sign of the Zodiac").BlogPostId,
                        CommentContent = "Do you know guys? Taurus boys are loves eating something soooo so much!"

                    }
                    );

                _context.SaveChanges();
            }
        }

        private static void SeedContact(DatabaseContext _context)
        {
            if (!_context.Contacts.Any())
            {
                _context.Contacts.AddRange(

                   new Contact
                   {
                       ContactName = "Horoscope Lover",
                       ContactEmail = "horoscopelover@gmail.com",
                       ContactSubject = "I love your website!",
                       ContactMessage = "I love your website! I am a big fan of horoscopes. I am sure that you are doing a great job. Keep going!",

                   },
                   new Contact
                   {
                          ContactName = "Horoscope Believer",
                          ContactEmail = "horoscopebeliever@gmail.com",
                          ContactSubject = "I believe in horoscopes!",
                          ContactMessage = "I believe in horoscopes! I am a big fan of horoscopes. I am sure that you are doing a great job. Keep going!",

                   }
                   );
                _context.SaveChanges();
            }
        }
    }
}
