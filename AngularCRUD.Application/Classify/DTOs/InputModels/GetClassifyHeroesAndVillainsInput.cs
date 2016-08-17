namespace AngularCRUD.Classify.DTOs.InputModels
{
    using System.Collections.Generic;

    using Abp.Application.Services.Dto;

    public class GetClassifyHeroesAndVillainsInput : IInputDto
    {
        public List<string> ListHeroesAndVillains { get; set; }
    }
}
