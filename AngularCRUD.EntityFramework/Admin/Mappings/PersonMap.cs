namespace AngularCRUD.Admin.Mappings
{
    using AngularCRUD.Admin.Entities;
    using AngularCRUD.MappingsBase;

    public class PersonMap : MultiTenantMap<Person>
    {
        public PersonMap()
        {
            //Atributos
            this.Property(person => person.Name).IsRequired();
            this.Property(person => person.Apellido).IsRequired();

            //Tabla
            this.ToTable("person");
        }
    }
}
