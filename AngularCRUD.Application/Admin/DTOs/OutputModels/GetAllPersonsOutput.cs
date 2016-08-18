namespace AngularCRUD.Admin.DTOs.OutputModels
{
    using System.Collections.Generic;

    using Abp.Application.Services.Dto;

    public class GetAllPersonsOutput : IOutputDto
    {
        public List<PersonOutput> PersonList { get; set; }
    }
}