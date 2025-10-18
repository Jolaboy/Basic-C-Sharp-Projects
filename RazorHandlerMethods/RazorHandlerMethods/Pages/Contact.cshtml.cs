using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace RazorHandlerMethods.Pages
{
    // 1. Inherit from PageModel
    public class ContactModel : PageModel
    {
        // 2. Use [BindProperty] to connect form data to this object on POST requests
        [BindProperty]
        public ContactForm Input { get; set; } = new ContactForm();

        // 3. Use [TempData] to persist messages across the redirect after a POST
        [TempData]
        public string Message { get; set; } = string.Empty;

        // Defines the structure of the data expected from the form
        public class ContactForm
        {
            [Required(ErrorMessage = "Name is required.")]
            public string Name { get; set; } = string.Empty;

            [Required(ErrorMessage = "Email is required.")]
            [EmailAddress(ErrorMessage = "Invalid email format.")]
            public string Email { get; set; } = string.Empty;

            [Required(ErrorMessage = "Subject is required.")]
            public string Subject { get; set; } = string.Empty;

            [Required(ErrorMessage = "Message body is required.")]
            public string Body { get; set; } = string.Empty;
        }

        // ===============================================
        // Handler Method 1: OnGet()
        // ===============================================

        // Executes on initial page load (HTTP GET)
        public void OnGet()
        {
            // OnGet is often empty, but here we can check if a redirect brought us here
            // to show a success message loaded from TempData.
            // TempData automatically transfers the 'Message' value from the previous request.

            // Example logic:
            // if (Message.Contains("success")) 
            // { 
            //     // Logic executed after a successful POST and redirect
            // }
        }

        // ===============================================
        // Handler Method 2: OnPost()
        // ===============================================

        // Executes on form submission (HTTP POST)
        public async Task<IActionResult> OnPostAsync()
        {
            // 1. Check for Validation Errors
            if (!ModelState.IsValid)
            {
                // If validation fails, return the current page (Page()) 
                // to show error messages next to the input fields.
                return Page();
            }

            // 2. Data Processing (e.g., Save to DB or Send Email)
            // Simulate an asynchronous operation
            await Task.Delay(100);

            // Log the submission for demonstration
            System.Console.WriteLine($"SUBMISSION: From {Input.Name} ({Input.Email}) - Subject: {Input.Subject}");

            // 3. Set the success message using TempData
            Message = "Thank you! Your message was received successfully.";

            // 4. Implement Post-Redirect-Get (PRG) pattern
            // Redirects to prevent duplicate submissions on refresh.
            return RedirectToPage();
        }
    }

}


