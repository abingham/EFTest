using System;
using System.Data.Entity.Infrastructure;

namespace EFTest
{
    class MainClass
    {
        public static void Main (string[] args)
        {
            using (var context = new SimpleContext ()) {
                var person = new Person { 
                    FirstName = "Hudson", 
                    LastName = "Hawk" 
                };

                context.People.Add (person);
                context.SaveChanges ();

//                bool saveFailed; 
//                do 
//                { 
//                    saveFailed = false; 
//
//                    try 
//                    { 
//                        context.SaveChanges(); 
//                    } 
//                    catch (DbUpdateConcurrencyException ex) 
//                    { 
//                        saveFailed = true; 
//
//                        // Update the values of the entity that failed to save from the store
//                        foreach (var e in ex.Entries) {
//                            e.Reload();
//                        }
//                    } 
//
//                } while (saveFailed); 
            }
        }
    }
}
