using System.ComponentModel.DataAnnotations;

namespace PersonalFinance.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}