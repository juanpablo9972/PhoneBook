

namespace mvcPHONE.Models
{
    using System.Data.Entity;//ctrl + .
    public class DataContext:DbContext//ctrl + .
    {
        public DataContext():base("DefaultConnection") //tab tab //ctrl v
        {

        }

        public System.Data.Entity.DbSet<mvcPHONE.Models.Phone> Phones { get; set; }
    }
}