using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Module4Challenge.Pages;
public class IndexModel : PageModel 
{
    // create attributes to describe class and store data
    public string[] DadJokes { get; set; } =
    [
        "Why do programmers hate nature? Too many bugs.",
        "Why do Java developers wear glasses? They don't C#.",
        "Why did the programmer quit his job? He didn't get arrays.",
        "Why do programmers prefer dark mode? Light attracts bugs.",
        "Why was the array so confident? It knew its bounds.",
        "Why was the CSS file so stylish? It had great attributes.",
        "Why did the object get kicked out? It wouldn't obey class rules.",
        "Why did the developer bring a pillow to work? For SOFTware development.",
        "Why are AI models bad comedians? Their timing is always artificial.",
        "Why did the AI model start a podcast? It had a lot of input to share.",
        "Why did the AI model get detention? It kept copying from its training set.",
        "Why was the LLM a bad listener? It kept interrupting and completeing sentences."
    ];
    public List<string> JokesToDisplay { get; set; }
    public int AmountToShow { get; set; } = 2;
    // initialize property for joke currently being added
    public string JokeBeingAdded { get; set; } = string.Empty;

    // OnGet() executes when page is initially displayed
    public void OnGet()
    {
        // create instance of random class
        Random rand = new Random();
        // create loop to repeat as many times as AmountToShow
        for (int i = 0; i < AmountToShow; i++)
        {
            // generate random number within bounds of array index
            int arrayIndex = rand.Next(0, DadJokes.Count());
            // access item for random generated index in DadJokes array and store in property
            JokeBeingAdded = DadJokes[arrayIndex];
            // check if list if empty; if so, add joke to display since there cannot be duplicates yet
            if (JokesToDisplay.Count == 0)
            {
                JokesToDisplay.Add(JokeBeingAdded);
            } else
            // otherwise, check if item is in JokesToDisplay
            {
                // check each item in list
                foreach (string joke in JokesToDisplay)
                {
                    
                }
            }
        }
    }

    // OnPost() executes when user submits form
    public void OnPost()
    {
        
    }
}