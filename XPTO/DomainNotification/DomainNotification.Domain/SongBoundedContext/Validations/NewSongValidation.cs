namespace DomainNotification.Domain.SongBoundedContext.Validations
{
    public  class NewSongValidation : SongValidation
    {
        public NewSongValidation()
        {
            ValidateTitle();

            ValidateArtistId();
        }
    }
}
