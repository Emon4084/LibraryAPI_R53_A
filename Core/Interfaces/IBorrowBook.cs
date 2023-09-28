using LibraryAPI_R53_A.Core.Domain;
using LibraryAPI_R53_A.Core.Repositories;

namespace LibraryAPI_R53_A.Core.Interfaces
{
    public interface IBorrowBook : IRepository<BorrowedBook>
    {
        Task CreateBorrowBook(BorrowedBook borrowedBook);
        Task<IEnumerable<BorrowedBook>> GetAllRequestedBooksByUserName(string userName);
        Task<IEnumerable<BorrowedBook>> GetAllCancelledBooksByUserName();


    }
}
