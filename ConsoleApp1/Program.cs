using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using TryItOut.DataAccess;
using TryItOut.DataAccessEF;
using TryItOut.Domain.Models;

namespace ConsoleApp1
{
    class Program
    {
        /* ************************************************************ */
        /* Middleware program to create initial Database table contents */
        /* ************************************************************ */

        static int Main(string[] args)
        {
            Database.SetInitializer(new NullDatabaseInitializer<TryItOut.DataAccess.RegisteredUserEFContext>());
            Database.SetInitializer(new NullDatabaseInitializer<TryItOut.DataAccessEF.LocomotiveTypeEFContext>());

            System.Console.WriteLine("--------------------------");
            System.Console.WriteLine("Locomotive Database Tables");
            System.Console.WriteLine("--------------------------");


            if (args.Length == 0)
            {
                System.Console.WriteLine("Please enter a Table name or -help.");

                return -1;
            }
            else
            {
                if (args[0] == "-help")
                {
                    return 0;
                }
                else if (args[0].ToLower() == "-tablename")
                {
                    switch (args[1].ToString().ToLower())
                    {
                        case "locomotiveclassification":
                            Console.WriteLine("Locomotive type");
                            InsertLocomotiveClassification();
                            break;
                        case "locomotive":
                            Console.WriteLine("Locomotives");
                            InsertLocomotive();
                            break;
                        case "railswaysmanufacturer":
                            Console.WriteLine("Railways manufacturer");
                            InsertRailwaysManufacturer();
                            break;
                        case "insertrailwaydecoder":
                            Console.WriteLine("Railways Decoders");
                            InsertRailwayDecoder();
                            break;
                        default:
                            break;
                    }
                    return 1;
                }
                else if (args[0].ToLower() == "-show" )
                {
                    switch (args[1].ToString().ToLower())
                    {
                        case "locomotiveclassification":
                            Console.WriteLine("Locomotive Classifications");
                            ReadAllLocomotiveClassifications();
                            break;

                        case "railwaysmanufacturers":
                            Console.WriteLine("Read all railways manufacturers");
                            ReadAllRailwaysManufacturer();
                            break;

                        default:
                            break;
                    }
                    return 1;
                }
                else
                {
                    return -1;
                }
            }

        }

        //private static void InsertToDoTask()
        //{
        //    var toDoTask_A = new ToDoTask
        //    {
        //        Description = "Task_A",
        //        CreatedOn = DateTime.Now,
        //        RequiredBy = DateTime.Now,
        //        CompletedOn = DateTime.Now
        //    };

        //    var toDoTask_B = new ToDoTask
        //    {
        //        Description = "Task_B",
        //        CreatedOn = DateTime.Now,
        //        RequiredBy = DateTime.Now,
        //        CompletedOn = DateTime.Now
        //    };

        //    using (var context = new TryItOutEFContext() )
        //    {
        //        context.Database.Log = Console.WriteLine;

        //        context.ToDoTasksEF.AddRange(new List<ToDoTask> { toDoTask_A, toDoTask_B });
        //        context.SaveChanges();
        //    }

        //}

        //private static void InsertRegisteredUser()
        //{
        //    var user_A = new RegisteredUser
        //    {
        //        Username = "dmorton",
        //        Password = "ABC$123",
        //        Firstname = "David",
        //        Lastname = "Morton",
        //        IsActive = "True",
        //        LastLoggedIn = "",
        //        NumberOfAttemps = 0,
        //        Locked = false
        //    };

        //    var user_B = new RegisteredUser
        //    {
        //        Username = "ymistry",
        //        Password = "ABC$123",
        //        Firstname = "Yogi",
        //        Lastname = "Mistry",
        //        IsActive = "True",
        //        LastLoggedIn = "",
        //        NumberOfAttemps = 0,
        //        Locked = false
        //    };

        //    using (var context = new TryItOutEFContext())
        //    {
        //        context.Database.Log = Console.WriteLine;

        //        context.RegisteredUserEF.AddRange(new List<RegisteredUser> { user_A, user_B });
        //        context.SaveChanges();
        //    }

        //}

        //private static void ReadToDoTask()
        //{

        //    using (var context = new ToDoTasksEFContext())
        //    {
        //        context.Database.Log = Console.WriteLine;

        //        var tasks = context.ToDoTasksEF.ToList();

        //        var task = context.ToDoTasksEF.Where(x => x.Identifier == 5);
        //    }

        //    var keyval = 1;
        //    using (var context = new TryItOutEFContext())
        //    {
        //        context.Database.Log = Console.WriteLine;

        //        var task = context.ToDoTasksEF.Find(keyval);
        //    }

        //}

        //private static void ReadandUpdateToDoTask() {

        //    using (var context = new ToDoTasksEFContext())
        //    {
        //        context.Database.Log = Console.WriteLine;

        //        ToDoTask task = context.ToDoTasksEF.FirstOrDefault();

        //        task.CompletedOn = DateTime.Now;

        //        context.SaveChanges();
        //    }

        //}


        private static void InsertRegisteredUser()
        {
            var user_A = new RegisteredUser
            {
                Username = "dmorton",
                Password = "ABC$123",
                Firstname = "David",
                Lastname = "Morton",
                IsActive = "True",
                LastLoggedIn = "",
                NumberOfAttemps = 0,
                Locked = false
            };

            var user_B = new RegisteredUser
            {
                Username = "ymistry",
                Password = "ABC$123",
                Firstname = "Yogi",
                Lastname = "Mistry",
                IsActive = "True",
                LastLoggedIn = "",
                NumberOfAttemps = 0,
                Locked = false
            };

            using (var context = new RegisteredUserEFContext())
            {
                context.Database.Log = Console.WriteLine;

                context.RegisteredUserEF.AddRange(new List<RegisteredUser> { user_A, user_B });
                context.SaveChanges();
            }

        }

        private static void InsertLocomotive()
        {
            var loco_A = new Locomotive
            {
                Name = "Class 25",
                Description = "BR Blue.",
                Classification = 6
            };

            var loco_B = new Locomotive
            {
                Name = "Class 20",
                Description = "BR Blue.",
                Classification = 6
            };

            var loco_C = new Locomotive
            {
                Name = "Class 37",
                Description = "BR Blue.",
                Classification = 6
            };

            var loco_D = new Locomotive
            {
                Name = "Class 43",
                Description = "Virgin Trains HST",
                Classification = 11
            };

            using (var context = new RailwaysContextEF())
            {
                context.Database.Log = Console.WriteLine;

                //context.LocomotiveEF.Add(loco_A);

                context.LocomotiveEF.AddRange(new List<Locomotive> {
                    loco_A,
                    loco_B,
                    loco_C,
                    loco_D});

                context.SaveChanges();
            }

        }

        private static void ReadAllLocomotive()
        {
            var Dbcontext = new RegisteredUserCRUD();

            Dbcontext.Read();
        }

        private static void InsertLocomotiveClassification()
        {
            /* ensure table is empty and reseed identity */

            var locotype_A = new LocomotiveClassification
            {
                Power = "Steam",
                Classification = "Express Passenger",
            };

            var locotype_B = new LocomotiveClassification
            {
                Power = "Steam",
                Classification = "Branch Passenger",
            };

            var locotype_C = new LocomotiveClassification
            {
                Power = "Steam",
                Classification = "Mixed Traffic",
            };

            var locotype_D = new LocomotiveClassification
            {
                Power = "Steam",
                Classification = "Branch / Shunter",
            };

            var locotype_E = new LocomotiveClassification
            {
                Power = "Diesel",
                Classification = "Express Passenger",
            };

            var locotype_F = new LocomotiveClassification
            {
                Power = "Diesel",
                Classification = "Mixed Traffic",
            };

            var locotype_G = new LocomotiveClassification
            {
                Power = "Diesel",
                Classification = "Frieght",
            };

            var locotype_H = new LocomotiveClassification
            {
                Power = "Diesel",
                Classification = "Light Traffic / Shunter",
            };

            var locotype_I = new LocomotiveClassification
            {
                Power = "Electric Multi Unit",
                Classification = "Passenger (EMU)",
            };

            var locotype_J = new LocomotiveClassification
            {
                Power = "Electric",
                Classification = "Mixed Traffic",
            };

            var locotype_K = new LocomotiveClassification
            {
                Power = "Diesel Multi Unit",
                Classification = "Passenger",
            };

            using (var context = new RailwaysContextEF())
            {
                context.Database.Log = Console.WriteLine;

                context.Database.ExecuteSqlCommand("TRUNCATE TABLE [LocomotiveClassifications]");

                context.LocomotiveClassificationEF.AddRange(new List<LocomotiveClassification> {
                    locotype_A,
                    locotype_B,
                    locotype_C,
                    locotype_D,
                    locotype_E,
                    locotype_F,
                    locotype_G,
                    locotype_H,
                    locotype_I,
                    locotype_J,
                    locotype_K
                });

                context.SaveChanges();
            }

        }

        private static void ReadAllLocomotiveClassifications()
        {
            var Dbcontext = new LocomotiveTypeCRUD();

            var listOfClassifications = Dbcontext.Read();

            foreach( var cls in listOfClassifications)
            {
                Console.WriteLine("Type {0}", cls.Power );
                Console.WriteLine("Classification {0}", cls.Classification);
                Console.WriteLine("Comments {0}", cls.Comments);
            }

            Console.ReadLine();
        }

        private static void InsertRailwaysManufacturer()
        {
            /* ensure table is empty and reseed identity */

            var manufacturer_A = new RailwaysManufacturer
            {
                 ManufacturerId = 1,
                 Name = "Hornby"
            };

            var manufacturer_B = new RailwaysManufacturer
            {
                ManufacturerId = 2,
                Name = "Bachmanns"
            };

            var manufacturer_C = new RailwaysManufacturer
            {
                ManufacturerId = 3,
                Name = "Dapol"
            };

            var manufacturer_D = new RailwaysManufacturer
            {
                ManufacturerId = 4,
                Name = "Heljan"
            };

            var manufacturer_E = new RailwaysManufacturer
            {
                ManufacturerId = 5,
                Name = "Gauagemaster"
            };

            var manufacturer_F = new RailwaysManufacturer
            {
                ManufacturerId = 6,
                Name = "DCConcepts"
            };

            var manufacturer_G = new RailwaysManufacturer
            {
                ManufacturerId = 7,
                Name = "Lais"
            };

            var manufacturer_H = new RailwaysManufacturer
            {
                ManufacturerId = 8,
                Name = "Hattons"
            };

            using (var context = new RailwaysContextEF())
            {
                context.Database.Log = Console.WriteLine;

                context.Database.ExecuteSqlCommand("TRUNCATE TABLE [RailwaysManufacturers]");

                context.RailwaysManufacturerEF.AddRange(new List<RailwaysManufacturer> {
                    manufacturer_A,
                    manufacturer_B,
                    manufacturer_C,
                    manufacturer_D,
                    manufacturer_E,
                    manufacturer_F,
                    manufacturer_G,
                    manufacturer_H,
                });

                context.SaveChanges();
            }

        }

        private static void ReadAllRailwaysManufacturer()
        {
            var Dbcontext = new RailwaysManufacturerCRUD();

            var listOfManufacturers = Dbcontext.Read();

            foreach (var man in listOfManufacturers)
            {
                Console.WriteLine("Type {0}", man.Name);
                Console.WriteLine("Classification {0}", man.ManufacturerId);
            }

            Console.ReadLine();
        }

        private static void InsertRailwayDecoder() {

            var decoder_A = new RailwayDecoder
            {
                DecoderId = 1,
                Manufacturer = 1,
                Description = "8 Pin harness",
                StayALive = false,
                Type = ""
            };

            var decoder_B = new RailwayDecoder
            {
                DecoderId = 2,
                Manufacturer = 2,
                Description = "21 Pin direct plug",
                StayALive = false,
                Type = ""
            };

            var decoder_C = new RailwayDecoder
            {
                DecoderId = 3,
                Manufacturer = 7,
                Description = "8 Pin direct plug",
                StayALive = true,
                Type = ""
            };

            using (var context = new RailwaysContextEF())
            {
                context.Database.Log = Console.WriteLine;

                context.Database.ExecuteSqlCommand("TRUNCATE TABLE [RailwayDecoders]");

                context.RailwayDecoderEF.AddRange(new List<RailwayDecoder> {
                    decoder_A,
                    decoder_B,
                    decoder_C
                });

                context.SaveChanges();
            }
        }
    }
}
