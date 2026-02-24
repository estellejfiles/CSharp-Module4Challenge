using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Module4Challenge.Pages;
public class IndexModel : PageModel 
{   
    [BindProperty]
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
    public List<string> JokesToDisplay { get; set; } = new List<string>();
    public int AmountToShow { get; set; } = 2;
    // initialize property for joke currently being added
    public string JokeBeingAdded { get; set; } = string.Empty;
    // initialize list of new jokes for when user submits form for more
    public List<string> MoreNewJokes { get; set; } = new List<string>();

    // OnGet() executes when page is initially displayed
    public void OnGet()
    {
        // create instance of random class
        Random rand = new Random();
        // create loop to repeat as many times as AmountToShow
        for (int i = 0; i < AmountToShow; i++) {
            // generate random number within bounds of array index
            int arrayIndex = rand.Next(0, DadJokes.Count());
            // access item for random generated index in DadJokes array and store in property
            JokeBeingAdded = DadJokes[arrayIndex];
            // check if list if empty; if so, add joke to display since there cannot be duplicates yet
            if (JokesToDisplay.Count == 0) {
                JokesToDisplay.Add(JokeBeingAdded);
            } else {
            // otherwise, check if item is in JokesToDisplay
                // if statement executes if list contains joke trying to be added (prevents duplicates)
                if (JokesToDisplay.Contains(JokeBeingAdded)) {
                    // continue to execute while list contains joke trying to be added
                    while (JokesToDisplay.Contains(JokeBeingAdded)) {
                        // regenerate random number within bounds of array index
                        arrayIndex = rand.Next(0, DadJokes.Count());
                        // access joke via new generated random index
                        JokeBeingAdded = DadJokes[arrayIndex];
                    } // end while loop
                    // add joke to list once it is verified to not be a duplicate
                    JokesToDisplay.Add(JokeBeingAdded);
                } else {
                    JokesToDisplay.Add(JokeBeingAdded);
                } // end if else contains
            } // end if else empty
        } // end for loop
    } // end OnGet

    // OnPost() executes when user submits form
    public void OnPost()
    {
        // create new instance of random class
        Random rand = new Random();
        // create loop to repeat as many times as AmountToShow
        for (int i = 0; i < AmountToShow; i++)
        {
            // generate random int to correspond to a joke's index; store in new variable
            int postArrayIndex = rand.Next(0, DadJokes.Count());
            // access joke via new generated index
            JokeBeingAdded = DadJokes[postArrayIndex];
            // if statement executes if list contains joke trying to be added (checking that joke has not already been shown to user)
            if (JokesToDisplay.Contains(JokeBeingAdded) || MoreNewJokes.Contains(JokeBeingAdded)) {
                // continue to execute while either list contains joke trying to be added
                while (JokesToDisplay.Contains(JokeBeingAdded) || MoreNewJokes.Contains(JokeBeingAdded)) {
                    // regenerate random number within bounds of array index
                    postArrayIndex = rand.Next(0, DadJokes.Count());
                    // access joke via new generated random index
                    JokeBeingAdded = DadJokes[postArrayIndex];
                } // end while loop
                // add joke to list once it is verified to not be a duplicate
                    JokesToDisplay.Add(JokeBeingAdded);
            // add joke if not duplicate        
            } else {
                JokesToDisplay.Add(JokeBeingAdded);
            } // end if else contains joke clause
        } // end for loop
    } // end OnPost
} // end namespace