using LibraryAPI_R53_A.Core.Domain;
using LibraryAPI_R53_A.Core.Interfaces;
using LibraryAPI_R53_A.Persistence.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace LibraryAPI_R53_A.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class BorrowBookController : ControllerBase
    {
        private readonly IBorrowBook _bR;
        private readonly IBookCopy _bCR;

        //fine and inspection data will be handle in _br to catch the dbcontext


        public BorrowBookController(IBorrowBook bR, IBookCopy bCR)
        {
            _bR = bR;
            _bCR = bCR;
        }

        [HttpGet("all-borrowlist")]
        public async Task<IActionResult> GetBorrowedList()
        {

            var requestedBooks = await _bR.GetAll();
            return Ok(requestedBooks);
        }



        [HttpGet("requested-books/{username}")]
        public async Task<IActionResult> GetRequestedBooksByUserName(string username)
        {
            try
            {

                var requestedBooks = await _bR.GetAllRequestedBooksByUserName(username);

                if (requestedBooks == null)
                {
                    return NotFound("No requested books found for the user.");
                }


                return Ok(requestedBooks);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal Server Error: {ex.Message}");
            }
        }

        [HttpGet("cancelled-books")]
        public async Task<IActionResult> GetCancelledBooksByUserName()
        {
            try
            {

                var cancelledBooks = await _bR.GetAllCancelledBooksByUserName();
                return Ok(cancelledBooks);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal Server Error: {ex.Message}");
            }
        }


        [HttpPost("book-request")]
        public async Task<IActionResult> SendBookRequest(BorrowedBook borrowedBook)
        {
            try
            {
                //only after login uId will get logged in user by this line of code
                var uId = User?.FindFirstValue(ClaimTypes.NameIdentifier);

                if (string.IsNullOrEmpty(uId))
                {
                    return Unauthorized("User not authenticated.");
                }

                var availablebookCopies = await _bCR.GetAvailable(borrowedBook.BookId);

                if (availablebookCopies == null)
                {
                    return BadRequest("All Copies are currently borrowed.");
                }


                borrowedBook = new BorrowedBook
                {
                    UserId = uId,
                    BookId = borrowedBook.BookId,
                    BookCopyId = availablebookCopies.BookCopyId,
                    Status = "Requested",
                    IsActive = true

                };

                await _bR.CreateBorrowBook(borrowedBook);
                await _bCR.ChangeAvailability(availablebookCopies.BookCopyId, false);


                return Ok("Succesfully Requested");


            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal Server Error: {ex.Message}");
            }
        }


    }
}
