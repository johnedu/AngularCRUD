namespace AngularCRUD.Classify.DTOs.OutputModels
{
    using System.Collections.Generic;

    using Abp.Application.Services.Dto;

    public class GetAllSuperHeroesOutput : IOutputDto
    {
        public List<SuperHeroOutput> SuperHeroes { get; set; }
    }
}
