using System.ComponentModel.DataAnnotations;

namespace Shooping.Data.Entities
{
    public class City
    {
        public int Id { get; set; }
        [Display (Name="Ciudad")]
        [MaxLength(50,ErrorMessage ="El campo {0} debe tener máximo {1} carácteres")]
        [Required (ErrorMessage ="El campo {0} debe ser obligatorio")]
            public string Name { get; set; }

    }
}
