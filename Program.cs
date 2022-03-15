using System;
using System.Collections.Generic;
using System.Linq;


namespace Labb2LinQFinal
{
    class Program
    {
        static void Main(string[] args)
        {
            using Labb2LinQFinalContex context = new Labb2LinQFinalContex();
            //Add data
            //List<Lärare> AddLärare = new List<Lärare>
            //{
            //    new Lärare { LärareNamn ="Axel Axelsson"},
            //    new Lärare { LärareNamn ="Bo Bosson"},
            //    new Lärare { LärareNamn ="Carl Carlsson"},
            //    new Lärare { LärareNamn ="David Davidsson"},
            //    new Lärare { LärareNamn ="Erik Eriksson"}
            //};

            //foreach (Lärare item in AddLärare)
            //{
            //    context.Lärare.Add(item);
            //}

            //------------------------------------------------------------------------

            //List<Student> AddStudent = new List<Student>
            //{
            //    new Student { StudentNamn ="Felicia Feliciasson", LärareId =1, KursId = 1 },
            //    new Student { StudentNamn ="Gudrun Gudrunsson", LärareId =2, KursId = 1 },
            //    new Student { StudentNamn ="Hanna Hannasson",  LärareId =3, KursId = 1 },
            //    new Student { StudentNamn ="Iris Irisson",  LärareId =3, KursId = 1 },
            //    new Student { StudentNamn ="Jenny Jennysson",  LärareId =3, KursId = 1 }
            //};

            //foreach (Student item in AddStudent)
            //{
            //    context.Student.Add(item);
            //}

            //------------------------------------------------------------------------

            //Kurs SUT21 = new Kurs { KursNamn = "SUT21" };
            //context.Kurs.Add(SUT21);

            //------------------------------------------------------------------------

            //List<Ämne> AddÄmne = new List<Ämne>
            //{
            //    new Ämne { ÄmneNamn ="Matematik", LärareId = 1},
            //    new Ämne { ÄmneNamn ="Avancerad.net", LärareId = 2},
            //    new Ämne { ÄmneNamn ="Programmering1", LärareId = 3},
            //    new Ämne { ÄmneNamn ="Programmering2", LärareId = 3},
            //};

            //foreach (Ämne item in AddÄmne)
            //{
            //    context.Ämne.Add(item);
            //}
            //Add data END

            //------------------------------------------------------------------------

            //                                                                                       Hämta ut alla lärare som lär ut matematik, Query Syntax
            //var TeachingMath = (from L in context.Lärare
            //                    join Ä in context.Ämne
            //                    on L.LärareId equals Ä.ÄmneId
            //                    where Ä.ÄmneNamn == "Matematik"
            //                    select new
            //                    {
            //                        namn = L.LärareNamn,
            //                        ämne = Ä.ÄmneNamn
            //                    }).ToList();

            //foreach (var item in TeachingMath)
            //{
            //    Console.WriteLine("{0} lär ut {1}", item.namn, item.ämne);
            //}

            //------------------------------------------------------------------------

            //                                                                                      Hämta ut alla elever med respektive lärare
            //var StudentMedLärare = (from L in context.Lärare
            //                    join S in context.Student
            //                    on L.LärareId equals S.LärareId                                
            //                    select new
            //                    {
            //                        lärarenamn = L.LärareNamn,
            //                        studentnamn = S.StudentNamn
            //                    }).ToList();

            //foreach (var item in StudentMedLärare)
            //{
            //    Console.WriteLine("{0} lärare är {1}", item.studentnamn, item.lärarenamn);
            //}

            //------------------------------------------------------------------------

            //                                                                                      Kolla om ämnen tabell Contains programmering1            
            //List<string> prog1list = (from ä in context.Ämne select ä.ÄmneNamn).ToList();            
            //var prog1string = "Programmering1";
            //bool isProg1 = prog1list.Contains(prog1string);
            //if (isProg1 == true) Console.WriteLine("{0} är ett ämne", prog1string);
            //else Console.WriteLine("{0} är EJ ett ämne", prog1string);

            //------------------------------------------------------------------------

            //                                                                                      Editera ett Ämne från programmering2 till OOP
            //var ämnesNamnChange = context.Ämne.SingleOrDefault(ä => ä.ÄmneNamn == "Programmering2");
            //if (ämnesNamnChange != null)
            //{
            //    ämnesNamnChange.ÄmneNamn = "OOP";
            //    context.SaveChanges();
            //}


            //Edit back
            //var ämnesNamnChange = context.Ämne.SingleOrDefault(ä => ä.ÄmneNamn == "OOP");
            //if (ämnesNamnChange != null)
            //{
            //    ämnesNamnChange.ÄmneNamn = "Programmering2";
            //    context.SaveChanges();
            //}

            //Check change
            //var ämnelist = (from ä in context.Ämne select new { ä.ÄmneNamn }).ToList();
            //foreach (var item in ämnelist)
            //{
            //    Console.WriteLine(item.ÄmneNamn);
            //}

            //------------------------------------------------------------------------

            //                                                                     Uppdatera en student record om sin lärare är Axel Axelsson(id 1) till Erik Eriksson (id 5).
            //var lärarChangeAxelToErik = context.Student.Where(ä => ä.LärareId == 1);
            //if (lärarChangeAxelToErik != null)
            //{
            //    foreach (var item in lärarChangeAxelToErik)
            //    {
            //        item.LärareId = 5;
            //    }
            //    context.SaveChanges();
            //}

            //Edit back
            //var lärarChangeErikToAxel = context.Student.Where(ä => ä.LärareId == 5);
            //if (lärarChangeErikToAxel != null)
            //{
            //    foreach (var item in lärarChangeErikToAxel)
            //    {
            //        item.LärareId = 1;
            //    }
            //    context.SaveChanges();
            //}
            //Check edit
            //var StudentMedLärare = (from L in context.Lärare
            //                        join S in context.Student
            //                        on L.LärareId equals S.LärareId
            //                        select new
            //                        {
            //                            lärarenamn = L.LärareNamn,
            //                            studentnamn = S.StudentNamn
            //                        }).ToList();

            //foreach (var item in StudentMedLärare)
            //{
            //    Console.WriteLine("{0} lärare är {1}", item.studentnamn, item.lärarenamn);
            //}
            //------------------------------------------------------------------------


            //context.SaveChanges();
            Console.ReadKey();
        }
    }
}
