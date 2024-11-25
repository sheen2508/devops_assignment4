using System.Collections.Generic;

namespace QuizApp.Models
{
    public static class QuestionPool
    {
        public static List<Question> GetQuestions()
        {
            return new List<Question>
            {
                new Question
                {
                    Id = 1,
                    Text = "Which animal is known as the 'King of the Jungle'?",
                    Options = new List<string> { "Tiger", "Lion", "Elephant", "Cheetah" },
                    CorrectAnswerIndex = 1
                },
                new Question
                {
                    Id = 2,
                    Text = "Which element has the chemical symbol 'O'?",
                    Options = new List<string> { "Oxygen", "Osmium", "Oxide", "Ozone" },
                    CorrectAnswerIndex = 0
                },
                new Question
                {
                    Id = 3,
                    Text = "What is the square root of 81?",
                    Options = new List<string> { "7", "8", "9", "10" },
                    CorrectAnswerIndex = 2
                },
                new Question
                {
                    Id = 4,
                    Text = "Which continent is the Sahara Desert located in?",
                    Options = new List<string> { "Asia", "Africa", "Australia", "South America" },
                    CorrectAnswerIndex = 1
                },
                new Question
                {
                    Id = 5,
                    Text = "Who discovered gravity?",
                    Options = new List<string> { "Albert Einstein", "Isaac Newton", "Galileo Galilei", "Nikola Tesla" },
                    CorrectAnswerIndex = 1
                },
                new Question
                {
                    Id = 6,
                    Text = "What is the name of the longest river in the world?",
                    Options = new List<string> { "Amazon River", "Nile River", "Yangtze River", "Mississippi River" },
                    CorrectAnswerIndex = 0
                },
                new Question
                {
                    Id = 7,
                    Text = "Which color is at the top of a rainbow?",
                    Options = new List<string> { "Blue", "Red", "Green", "Yellow" },
                    CorrectAnswerIndex = 1
                },
                new Question
                {
                    Id = 8,
                    Text = "What is the name of the first man to walk on the moon?",
                    Options = new List<string> { "Neil Armstrong", "Buzz Aldrin", "Michael Collins", "Yuri Gagarin" },
                    CorrectAnswerIndex = 0
                },
                new Question
                {
                    Id = 9,
                    Text = "What is the main ingredient in sushi?",
                    Options = new List<string> { "Fish", "Seaweed", "Rice", "Soy Sauce" },
                    CorrectAnswerIndex = 2
                },
                new Question
                {
                    Id = 10,
                    Text = "Which gas do plants absorb during photosynthesis?",
                    Options = new List<string> { "Oxygen", "Carbon Dioxide", "Nitrogen", "Hydrogen" },
                    CorrectAnswerIndex = 1
                },
                new Question
                {
                    Id = 11,
                    Text = "Who painted the ceiling of the Sistine Chapel?",
                    Options = new List<string> { "Leonardo da Vinci", "Michelangelo", "Raphael", "Donatello" },
                    CorrectAnswerIndex = 1
                },
                new Question
                {
                    Id = 12,
                    Text = "Which country is home to the Great Barrier Reef?",
                    Options = new List<string> { "Australia", "Brazil", "Indonesia", "India" },
                    CorrectAnswerIndex = 0
                },
                new Question
                {
                    Id = 13,
                    Text = "What is the name of the tallest mountain in the world?",
                    Options = new List<string> { "K2", "Mount Everest", "Kilimanjaro", "Denali" },
                    CorrectAnswerIndex = 1
                },
                new Question
                {
                    Id = 14,
                    Text = "Which planet is known as the Red Planet?",
                    Options = new List<string> { "Mars", "Venus", "Mercury", "Saturn" },
                    CorrectAnswerIndex = 0
                },
                new Question
                {
                    Id = 15,
                    Text = "How many legs does a spider have?",
                    Options = new List<string> { "6", "8", "10", "12" },
                    CorrectAnswerIndex = 1
                },
                new Question
                {
                    Id = 16,
                    Text = "What is the name of the largest ocean on Earth?",
                    Options = new List<string> { "Atlantic Ocean", "Indian Ocean", "Arctic Ocean", "Pacific Ocean" },
                    CorrectAnswerIndex = 3
                },
                new Question
                {
                    Id = 17,
                    Text = "What is the capital city of Spain?",
                    Options = new List<string> { "Barcelona", "Madrid", "Seville", "Valencia" },
                    CorrectAnswerIndex = 1
                },
                new Question
                {
                    Id = 18,
                    Text = "What is the name of the main character in 'The Legend of Zelda' video game series?",
                    Options = new List<string> { "Zelda", "Link", "Ganon", "Epona" },
                    CorrectAnswerIndex = 1
                },
                new Question
                {
                    Id = 19,
                    Text = "Which organ in the human body filters blood?",
                    Options = new List<string> { "Liver", "Kidney", "Heart", "Lungs" },
                    CorrectAnswerIndex = 1
                },
                new Question
                {
                    Id = 20,
                    Text = "Who is known as the 'Father of Computers'?",
                    Options = new List<string> { "Alan Turing", "Charles Babbage", "John von Neumann", "Ada Lovelace" },
                    CorrectAnswerIndex = 1
                },
            };
        }
    }
}
