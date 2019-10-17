using DomainNotification.Domain.SongBoundedContext.Validations;

namespace DomainNotification.Domain.SongBoundedContext
{
    public class DeleteSongCommnad : SongCommnad
    {
        public override bool IsValid()
        {
            ValidationResult = new DeleteSongValidation()
                .Validate(this);

            return ValidationResult.IsValid;
        }
    }
}
