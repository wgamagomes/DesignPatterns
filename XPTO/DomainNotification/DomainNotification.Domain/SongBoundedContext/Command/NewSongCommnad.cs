using DomainNotification.Domain.SongBoundedContext.Validations;

namespace DomainNotification.Domain.SongBoundedContext
{
    public class NewSongCommnad: SongCommnad
    {
        public override bool IsValid()
        {
            ValidationResult = new NewSongValidation()
                .Validate(this);

            return ValidationResult.IsValid;
        }
    }
}
