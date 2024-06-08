namespace Entities.Exceptions
{
    public sealed class BookNotFoundException : NotFoundException
    {
        public BookNotFoundException(int id) : base($"The Book with id : {id} could not found")
        {

        }
    }
}
