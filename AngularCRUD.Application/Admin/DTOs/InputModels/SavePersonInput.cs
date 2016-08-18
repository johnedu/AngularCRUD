namespace AngularCRUD.Admin.DTOs.InputModels
{
    using System.ComponentModel.DataAnnotations;

    using Abp.Application.Services.Dto;

    public class SavePersonInput : EntityDto, IInputDto
    {
        [Required]
        [MaxLength(512)]
        public string Name { get; set; }
        [Required]
        [MaxLength(512)]
        public string Apellido { get; set; }
        public int Edad { get; set; }
    }
}