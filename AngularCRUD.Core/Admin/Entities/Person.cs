namespace AngularCRUD.Admin.Entities
{
    using AngularCRUD.BaseEntity;

    public class Person : EntityMultiTenant
    {
        public string Name { get; set; }
        public string Apellido { get; set; }
        public int Edad { get; set; }
    }
}