using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleSpanish
{
    public static class Quiz
    {
        /// <summary>
        /// Name of the lesson
        /// </summary>
        public static string Name
        {
            get; set;
        } = "No Name";

        /// <summary>
        /// High score of the current lesson
        /// </summary>
        public static uint HighScore
        {
            get; set;
        }

        /// <summary>
        /// ID of current lesson
        /// </summary>
        public static uint ID
        {
            get; set;
        }

        /// <summary>
        /// Lesson Title
        /// </summary>
        public static string QuizTitle
        {
            get; set;
        } = "No Title";

        /// <summary>
        /// start in the constructor
        /// </summary>
        public static List<string> Questions
        {
            get; set;
        }

        public static List<List<string>> Options
        {
            get; set;
        }

        /// <summary>
        /// start at zero
        /// </summary>
        public static uint CurrentIndex
        {
            get; set;
        } = 0;


        /// <summary>
        /// Quiz constructor
        /// </summary>
        static Quiz()
        {
            Questions = new List<string>();
            Options = new List<List<string>>();
        }


    }
}
