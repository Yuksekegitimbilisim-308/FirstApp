using FirstApp.Entity;

namespace FirstApp.Models
{
    public class PersonelEditViewModel
    {
        public Personel Personel{ get; set; }
        public string PageTitle { get; set; }
        public List<Personel> Personels { get; set; }
    }
}
