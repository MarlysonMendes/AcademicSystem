using System.ComponentModel.DataAnnotations;

namespace AcademicSystem.Api.Contracts.Departament.Request
{
    public record CreatePatchDepartament
    {
        [Required]
        public string DepartamentName { get; set; }
    }
}
