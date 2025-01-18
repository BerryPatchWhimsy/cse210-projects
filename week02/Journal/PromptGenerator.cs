public class PromptGenerator
{
    //works DON'T TOUCH
     public string GetRandomPrompt()
        {
            List<string> _prompts = new List<string>();

            _prompts.Add("Who was the most memorable person you encountered today?");
            _prompts.Add("What was the best thing that happened to you today?");
            _prompts.Add("What tender mercies of the Lord have you noticed?");
            _prompts.Add("Describe the strongest emotion you felt today and what caused it.");
            _prompts.Add("What was the best thing you ate today?");

            Random randomGenerator = new Random();
            int index = randomGenerator.Next(_prompts.Count);
            string _randomPrompt = _prompts[index];
            return _randomPrompt;

        }
}