namespace Data_asp_net.Pages;

using Microsoft.AspNetCore.Mvc.RazorPages;

public class IndexModel : PageModel
{
    public string UserName { get; set; }
    public DateOnly BirthDate { get; set; }
    public int UserAge { get; set; }
    public bool IsAdmin { get; set; }
    public DateTime CreationTime { get; set; }

    public void OnGet()
    {
        UserName = "John Doe";
        BirthDate = new DateOnly(1990, 5, 15);
        UserAge = DateTime.Now.Year - BirthDate.Year;
        if (BirthDate > DateOnly.FromDateTime(DateTime.Now).AddYears(-UserAge)) { UserAge--; }
        IsAdmin = true;
        CreationTime = DateTime.Now;
    }
}