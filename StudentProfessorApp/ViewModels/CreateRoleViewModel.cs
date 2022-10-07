using System.ComponentModel.DataAnnotations;

namespace StudentProfessorApp.ViewModels
{
    public class CreateRoleViewModel
    {
        [Required]
        public string  RoleName { get; set; }
    }
}
