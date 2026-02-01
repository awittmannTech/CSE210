public class PromptGen
{
    List<Prompt> _prompts = new List<Prompt>();

    public string GenerateRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        Prompt randomPrompt = _prompts[index];
        return randomPrompt.GetPrompt();
    }
}