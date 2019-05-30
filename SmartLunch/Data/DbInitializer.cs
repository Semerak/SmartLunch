using SmartLunch.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace SmartLunch.Data
{
    public class DbInitializer
    {
        public static void Initialize(SmartLunchContext context)
        {
            context.Database.EnsureCreated();
            if (context.Forms.Any())
            {
                return;
            }

            var forms = new Forms[]
            {
               new Forms{ID=1, Name_form="11 В"},
                new Forms{ID=2, Name_form="11 Б"},
                new Forms{ID=3, Name_form="11 А"},
                new Forms{ID=4, Name_form="10 А"},
                new Forms{ID=5, Name_form="10 Б"},
                new Forms{ID=6, Name_form="10 В"},
                new Forms{ID=8, Name_form="9 Б"},
                new Forms{ID=9, Name_form="9 А"}
            };

            foreach (Forms f in forms )
            {
                context.Forms.Add(f);
            }
            context.SaveChanges();

            var dishes = new Dishes[]
            {
                new Dishes{ID=2, Name_dish="Шашлик", TypesID=1, description="150 г"},
                new Dishes{ID=3, Name_dish="Компот", TypesID=5, description="200 мл"},
                new Dishes{ID=4, Name_dish="Борщ", TypesID=1, description="300 г"},
                new Dishes{ID=5, Name_dish="Котлета", TypesID=2, description="100 г"},
                new Dishes{ID=6, Name_dish="Рис", TypesID=4, description="150 г"},
                new Dishes{ID=7, Name_dish="Макарони", TypesID=4, description="200 г"},
                new Dishes{ID=9, Name_dish="Гречка", TypesID=4, description="200 г"},
                new Dishes{ID=10, Name_dish="Рис", TypesID=4, description="300 г"},
                new Dishes{ID=11, Name_dish="Відбивна", TypesID=2, description="200 г"},
                new Dishes{ID=12, Name_dish="Хек", TypesID=6, description="200 г"},
                new Dishes{ID=13, Name_dish="Булочка з корицею", TypesID=7, description="100 г"}
            };

            foreach (Dishes d in dishes)
            {
                context.Dishes.Add(d);
            }
            context.SaveChanges();

            var types = new Types[]
            {
                new Types{ID=1, Name_type="Суп"},
                new Types{ID=2, Name_type="М'ясо"},
                new Types{ID=4, Name_type="Гарнір"},
                new Types{ID=5, Name_type="Напій"},
                new Types{ID=6, Name_type="Риба"},
                new Types{ID=7, Name_type="Десерт"}

            };

            foreach (Types t in types)
            {
                context.Types.Add(t);
            }
            context.SaveChanges();

            var prices = new Prices[]
            {
                new Prices{ID=2, Price=12, DishesID=2, P_time=DateTime.Parse("2019-03-20 22:15:21.480")},
                new Prices{ID=3, Price=8, DishesID=3, P_time=DateTime.Parse("2019-03-20 22:57:56.510")},
                new Prices{ID=2, Price=10, DishesID=5, P_time=DateTime.Parse("2019-03-21 01:37:29.110")},
                new Prices{ID=2, Price=14, DishesID=6, P_time=DateTime.Parse("2019-03-21 01:37:35.073")},
                new Prices{ID=2, Price=19, DishesID=7, P_time=DateTime.Parse("2019-03-21 01:37:38.837")},
                new Prices{ID=3, Price=19, DishesID=8, P_time=DateTime.Parse("2019-03-21 01:37:44.237")},
                new Prices{ID=3, Price=15, DishesID=9, P_time=DateTime.Parse("2019-03-21 01:37:48.780")},
                new Prices{ID=3, Price=13, DishesID=10, P_time=DateTime.Parse("2019-03-21 01:37:52.110")},
                new Prices{ID=4, Price=12, DishesID=11, P_time=DateTime.Parse("2019-03-21 03:25:34.267")},
                new Prices{ID=5, Price=7, DishesID=12, P_time=DateTime.Parse("2019-03-21 03:26:53.157")},
                new Prices{ID=6, Price=5, DishesID=13, P_time=DateTime.Parse("2019-03-21 03:31:26.417")},
                new Prices{ID=6, Price=6, DishesID=14, P_time=DateTime.Parse("2019-03-21 03:55:03.587")},
                new Prices{ID=5, Price=8, DishesID=15, P_time=DateTime.Parse("2019-03-21 03:55:29.040")},
                new Prices{ID=2, Price=18, DishesID=16, P_time=DateTime.Parse("2019-03-21 03:58:51.267")},
                new Prices{ID=4, Price=13, DishesID=17, P_time=DateTime.Parse("2019-03-21 03:59:10.180")},
                new Prices{ID=7, Price=9, DishesID=18, P_time=DateTime.Parse("2019-03-21 09:34:33.327")},
                new Prices{ID=2, Price=16, DishesID=20, P_time=DateTime.Parse("2019-03-21 10:25:58.737")},
                new Prices{ID=2, Price=17, DishesID=21, P_time=DateTime.Parse("2019-03-27 18:01:07.797")},
                new Prices{ID=7, Price=10, DishesID=22, P_time=DateTime.Parse("2019-03-27 18:08:41.763")},
                new Prices{ID=9, Price=7, DishesID=23, P_time=DateTime.Parse("2019-03-27 18:29:51.573")},
                new Prices{ID=6, Price=3, DishesID=24, P_time=DateTime.Parse("2019-03-27 19:12:12.187")},
                new Prices{ID=10, Price=6, DishesID=25, P_time=DateTime.Parse("2019-03-27 23:08:28.137")},
                new Prices{ID=6, Price=4, DishesID=26, P_time=DateTime.Parse("2019-03-27 23:15:09.673")},
                new Prices{ID=11, Price=10, DishesID=27, P_time=DateTime.Parse("2019-03-27 23:26:10.133")},
                new Prices{ID=12, Price=11, DishesID=28, P_time=DateTime.Parse("2019-03-27 23:27:42.600")},
                new Prices{ID=13, Price=10, DishesID=29, P_time=DateTime.Parse("2019-03-28 09:37:34.663")},
                new Prices{ID=5, Price=10, DishesID=30, P_time=DateTime.Parse("2019-03-28 09:41:15.740")},
                new Prices{ID=13, Price=12, DishesID=31, P_time=DateTime.Parse("2019-03-26 09:44:46.843")},
                new Prices{ID=13, Price=12, DishesID=32, P_time=DateTime.Parse("2019-03-26 09:45:04.670")}

            };
            foreach (Prices p in prices)
            {
                context.Prices.Add(p);
            }
            context.SaveChanges();

            var quantities = new Quantities[]
            {
               new Quantities{ID=1, DishesID=2, Quantity=0, Q_time=DateTime.Parse("2019-03-20 22:15:21.480")},
                new Quantities{ID=2, DishesID=3, Quantity=0, Q_time=DateTime.Parse("2019-03-20 22:57:57.270")},
                new Quantities{ID=3, DishesID=4, Quantity=0, Q_time=DateTime.Parse("2019-03-21 03:25:34.690")},
                new Quantities{ID=4, DishesID=5, Quantity=0, Q_time=DateTime.Parse("2019-03-21 03:26:53.163")},
                new Quantities{ID=5, DishesID=6, Quantity=0, Q_time=DateTime.Parse("2019-03-21 03:31:26.420")},
                new Quantities{ID=6, DishesID=2, Quantity=5, Q_time=DateTime.Parse("2019-03-21 04:12:23.940")},
                new Quantities{ID=7, DishesID=3, Quantity=10, Q_time=DateTime.Parse("2019-03-21 04:12:49.627")},
                new Quantities{ID=8, DishesID=2, Quantity=4, Q_time=DateTime.Parse("2019-03-21 04:14:24.010")},
                new Quantities{ID=9, DishesID=2, Quantity=3, Q_time=DateTime.Parse("2019-03-21 04:16:26.963")},
                new Quantities{ID=10, DishesID=7, Quantity=0, Q_time=DateTime.Parse("2019-03-21 09:34:33.343")},
                new Quantities{ID=12, DishesID=4, Quantity=5, Q_time=DateTime.Parse("2019-03-21 10:26:12.457")},
                new Quantities{ID=13, DishesID=5, Quantity=8, Q_time=DateTime.Parse("2019-03-27 18:22:41.643")},
                new Quantities{ID=14, DishesID=9, Quantity=0, Q_time=DateTime.Parse("2019-03-27 18:29:51.583")},
                new Quantities{ID=15, DishesID=10, Quantity=0, Q_time=DateTime.Parse("2019-03-27 23:08:28.143")},
                new Quantities{ID=16, DishesID=11, Quantity=0, Q_time=DateTime.Parse("2019-03-27 23:26:10.140")},
                new Quantities{ID=17, DishesID=12, Quantity=0, Q_time=DateTime.Parse("2019-03-27 23:27:42.607")},
                new Quantities{ID=18, DishesID=12, Quantity=10, Q_time=DateTime.Parse("2019-03-27 23:28:00.597")},
                new Quantities{ID=19, DishesID=12, Quantity=0, Q_time=DateTime.Parse("2019-03-27 23:42:05.640")},
                new Quantities{ID=20, DishesID=12, Quantity=10, Q_time=DateTime.Parse("2019-03-27 23:42:08.717")},
                new Quantities{ID=21, DishesID=13, Quantity=0, Q_time=DateTime.Parse("2019-03-28 09:37:34.680")},
                new Quantities{ID=22, DishesID=10, Quantity=10, Q_time=DateTime.Parse("2019-04-17 18:14:43.363")},
                new Quantities{ID=23, DishesID=10, Quantity=0, Q_time=DateTime.Parse("2019-04-17 18:14:57.817")}


            };
            foreach (Quantities q in quantities)
            {
                context.Quantities.Add(q);
            }
            context.SaveChanges();
        }
    }
}
