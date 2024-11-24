namespace Entities.Exceptions
{
    public sealed partial class BookNotFoundException
    {
        public sealed class CategoryNotFoundException : NotFoundException
        {
            public CategoryNotFoundException(int id) : base($"Category with id:{id} could nod found.")
            {
            }
        }
    }
}
