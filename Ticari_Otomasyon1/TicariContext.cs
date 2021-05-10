using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Ticari_Otomasyon1
{
    public class TicariContext : Microsoft.EntityFrameworkCore.DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {


            optionsBuilder.UseSqlServer(@"Server=AB01500-3535\SQLEXPRESS;Initial Catalog=DboTicariOtomasyon;Integrated Security=True");
        }

    }
}
