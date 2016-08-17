namespace AngularCRUD.Classify.DTOs.OutputModels
{
    using Abp.Application.Services.Dto;

    public class SuperHeroOutput : EntityDto, IOutputDto
    {
        public string Name { get; set; }
    }
}
