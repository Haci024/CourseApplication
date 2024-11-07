namespace Entities.Models
{
    public class Filial
    {
        public int Id { get; set; }

        public string FilialName { get; set; }

        public bool Status { get; set; }

        public ICollection<AppUserFilial> AppUserFilial { get; set; }

        public ICollection<Groups> Groups { get; set; }

        public Packets Packets { get; set; }

        public int PacketId { get; set; }


    }
}
