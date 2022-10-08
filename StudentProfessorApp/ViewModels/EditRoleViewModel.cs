using System.ComponentModel.DataAnnotations;

namespace StudentProfessorApp.ViewModels
{
    public class EditRoleViewModel
    {
        public EditRoleViewModel()
        {
            Users = new List<string>();
        }
        public string Id { get; set; }
        [Required(ErrorMessage="Role nmae is required")]
        public string RoleName { get; set; }
        public List<string> Users { get; set; }
    }
}
