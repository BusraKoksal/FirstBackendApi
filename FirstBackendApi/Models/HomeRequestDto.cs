using System.ComponentModel.DataAnnotations;

namespace FirstBackendApi.Models
{
    public class HomeRequestDto
    {
        [Required]
        public string Name { get; set; }    
    }
}
