using AutoMapper;
using SuperPowers.Classify.DTOs.InputModels;
using SuperPowers.Classify.DTOs.OutputModels;
using SuperPowers.Classify.Entities;
using SuperPowers.Classify.Repositories;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperPowers.Classify
{
    public class ClassifyService : IClassifyService
    {
        # region Repositorios

        private ISuperPowersPersonRepository _superPowersPersonRepository;

        # endregion

        public ClassifyService(ISuperPowersPersonRepository superPowersPersonRepository)
        {
            _superPowersPersonRepository = superPowersPersonRepository;
        }

        //  Método para clasificar los héroes y villanos
        public GetClassifyHeroesAndVillainsOutput GetClassifyHeroesAndVillains(GetClassifyHeroesAndVillainsInput listSuperPowersPersons)
        {
            //  Listas donde se van a clasificar las personas con super poderes
            List<SuperHeroOutput> listHeroes = new List<SuperHeroOutput>();
            List<SuperHeroOutput> listVillains = new List<SuperHeroOutput>();
            SuperPowersPerson superPowersPerson = null;
            int heroOrVillainId = 0;
            StreamWriter fileSuperHero = null;
            StreamWriter fileVillain = null;
            GetClassifyHeroesAndVillainsOutput listClassified = null;

            try
            {
                //  Ruta completa donde se van a guardar los ficheros con super héroes y villanos
                string routeSuperHero = System.AppDomain.CurrentDomain.BaseDirectory + "App_Data\\Tmp\\" + AngularCRUDConsts.SuperHeroFileName;
                fileSuperHero = new StreamWriter(routeSuperHero);
                string routeVillain = System.AppDomain.CurrentDomain.BaseDirectory + "App_Data\\Tmp\\" + AngularCRUDConsts.VillainFileName;
                fileVillain = new StreamWriter(routeVillain);

                //  Limpiamos la base de datos para guardar nuevos super héroes y villanos
                _superPowersPersonRepository.Delete(s => s.TenantId == 0);
                foreach (string heroeOrVillain in listSuperPowersPersons.ListHeroesAndVillains)
                {
                    if (heroeOrVillain.Contains(AngularCRUDConsts.VillainLetter))
                    {
                        superPowersPerson = new SuperPowersPerson { Name = heroeOrVillain, Type = AngularCRUDConsts.VillainType };
                        heroOrVillainId = _superPowersPersonRepository.InsertAndGetId(superPowersPerson);
                        listVillains.Add(new SuperHeroOutput { Id = heroOrVillainId, Name = heroeOrVillain });
                        fileVillain.WriteLine(heroeOrVillain);
                    }
                    else
                    {
                        superPowersPerson = new SuperPowersPerson { Name = heroeOrVillain, Type = AngularCRUDConsts.SuperHeroType };
                        heroOrVillainId = _superPowersPersonRepository.InsertAndGetId(superPowersPerson);
                        listHeroes.Add(new SuperHeroOutput { Id = heroOrVillainId, Name = heroeOrVillain });
                        fileSuperHero.WriteLine(heroeOrVillain);
                    }
                }
                listClassified = new GetClassifyHeroesAndVillainsOutput { ListHeroes = listHeroes, ListVillains = listVillains };
            }
            catch (System.IO.FileNotFoundException ex)
            {
                System.Console.WriteLine(ex.ToString());
            }

            catch (System.IO.IOException ex)
            {
                System.Console.WriteLine(ex.ToString());
            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex.ToString());
            }
            finally
            {
                fileVillain.Close();
                fileSuperHero.Close();
                
            }
            return listClassified;
        }

        //  Método para obtener la lista de super héroes
        public GetAllSuperHeroesOutput GetAllSuperHeroes()
        {
            GetAllSuperHeroesOutput allSuperHeroes = null;
            try
            {
                //  Obtenemos la lista de super héroes
                var listSuperHeroes = _superPowersPersonRepository.GetAll().Where(person => person.Type == AngularCRUDConsts.SuperHeroType).ToList();
                //  Hacemos el mapeo y retornamos la lista
                allSuperHeroes = new GetAllSuperHeroesOutput { SuperHeroes = Mapper.Map<List<SuperHeroOutput>>(listSuperHeroes) };
            }
            catch(AutoMapperMappingException ex) {
                System.Console.WriteLine(ex.ToString());
            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex.ToString());
            }
            return allSuperHeroes;
        }
    }
}
