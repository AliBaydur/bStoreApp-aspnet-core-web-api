using System.ComponentModel.DataAnnotations;


namespace Entities.DataTransferObjects
{
    public record UserForAuthenticationDTO
    {
        [Required(ErrorMessage ="Username is required.")]
        public string? UserName { get; init; }
        
        [Required(ErrorMessage = "Password is required.")]
        public string? Password { get; init; }
    }
}
