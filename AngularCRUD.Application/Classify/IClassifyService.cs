namespace AngularCRUD.Classify
{
    using Abp.Application.Services;

    using AngularCRUD.Classify.DTOs.InputModels;
    using AngularCRUD.Classify.DTOs.OutputModels;

    public interface IClassifyService : IApplicationService
    {
        GetClassifyHeroesAndVillainsOutput GetClassifyHeroesAndVillains(GetClassifyHeroesAndVillainsInput listSuperPowersPersons);

        GetAllSuperHeroesOutput GetAllSuperHeroes();
    }
}
