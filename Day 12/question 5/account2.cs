using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication55
{
     public partial class account
     {
         int id;
         string name;

         public account(int id,string name)
         {
             Id = id;
             Name = name;
         }
         public int Id
         {
             set;
             get;
         }
         public string Name
         {
             set;
             get;
         }
     }
}
