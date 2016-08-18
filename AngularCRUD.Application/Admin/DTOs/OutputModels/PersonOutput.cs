namespace AngularCRUD.Admin.DTOs.OutputModels
{
    using Abp.Application.Services.Dto;

    public class PersonOutput : EntityDto, IOutputDto
    {
        public string Name { get; set; }
        public string Apellido { get; set; }
        public int Edad { get; set; }
    }
}
