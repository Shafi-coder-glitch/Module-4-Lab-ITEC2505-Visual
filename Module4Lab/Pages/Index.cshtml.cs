using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Module4Lab.Pages
{
    public class IndexModel : PageModel
    {
        // This array stores the three Guthrie Theater show titles.
        public string[] Shows = { "Hamlet", "Cabaret", "Fences" };

        // This variable counts how many show titles are longer than 5 letters.
        public int LongTitleCount = 0;

        public void OnGet()
        {
            // Start at the first position in the array.
            int i = 0;

            // The while loop continues until we reach the end of the array.
            while (i < Shows.Length)
            {
                // Check if the current show title has more than 5 letters.
                if (Shows[i].Length > 5)
                {
                    // Increase the count by 1 when the title is longer than 5 letters.
                    LongTitleCount++;
                }

                // Move to the next show in the array.
                i++;
            }
        }
    }
}