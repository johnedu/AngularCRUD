namespace AngularCRUD.Classify.DTOs.OutputModels
{
    using System.Collections.Generic;

    using Abp.Application.Services.Dto;

    public class GetClassifyHeroesAndVillainsOutput : IOutputDto
    {
        public List<SuperHeroOutput> ListHeroes { get; set; }
        public List<SuperHeroOutput> ListVillains { get; set; }
    }
}
