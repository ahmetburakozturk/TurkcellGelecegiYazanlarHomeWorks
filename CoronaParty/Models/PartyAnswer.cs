using System.ComponentModel.DataAnnotations;

namespace CoronaParty.Models
{
    public class PartyAnswer
    {
        [Required(ErrorMessage = "Boş Bırakılamaz!")]
        [Display(Name = "İsim - Soyisim ")]
        [MinLength(2,ErrorMessage = "En az 2 karakter girilmelidir.")]
        public string Name { get; set; }

        [Display(Name = "Telefon Numarası ")]
        public int PhoneNumber { get; set; }

        [Display(Name = "Katılacak Mısınız ?")]
        [Required(ErrorMessage = "Boş Bırakılamaz.")]
        public string State { get; set; }
    }
}
