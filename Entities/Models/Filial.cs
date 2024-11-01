namespace Entities.Models
{
    public class Filial
    {
        public int Id { get; set; }

        public string FilialName { get; set; }

        public bool Status { get; set; }

        public ICollection<AppUserFilial> FilialUsers { get; set; }

       
    }
}
