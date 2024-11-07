using FirstApp.Entity;

namespace FirstApp.Managers
{
    public static class PersonelManager
    {
        private static List<Personel> Personels = new() {
        new Personel() { Id = 1, Fullname = "Melih Ömer KAMAR", Salary = 65000, IsActive = true },
        new Personel() { Id = 2, Fullname = "Tuğba KAMAR", Salary = 46250, IsActive = true },
        new Personel() { Id = 3, Fullname = "Abdullah ÇAVUŞ", Salary = 80000, IsActive = true },
        new Personel() { Id = 4, Fullname = "Ömer Faruk KARAYİĞİT", Salary = 49000, IsActive = true },
        new Personel() { Id = 5, Fullname = "Batuhan GÖKKAYA", Salary = 94500, IsActive = false }
        };

        public static List<Personel> GetAllPersonels()
        {
            return Personels;
        }
        public static Personel GetPersonelById(int id)
        {
            return Personels.FirstOrDefault(x => x.Id == id);
        }
        public static void AddPersonel(Personel personel)
        {
            personel.Id = Personels.Last().Id + 1;
            Personels.Add(personel);
        }
        public static void UpdatePersonel(Personel personel)
        {
            Personel currentPersonel = GetPersonelById(personel.Id);
            currentPersonel.Fullname = personel.Fullname;
            currentPersonel.Salary = personel.Salary;
            currentPersonel.IsActive = personel.IsActive;
        }
        public static void RemovePersonel(int id)
        {
            Personel currentPersonel = GetPersonelById(id);
            Personels.Remove(currentPersonel);
        }
    }
}
