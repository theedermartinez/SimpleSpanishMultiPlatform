using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleSpanish
{
    /// <summary>
    /// Lesson chosen. Changes depending on what the user picks.
    /// </summary>
    public static class Lesson
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
            get;set;
        } 

        /// <summary>
        /// ID of current lesson
        /// </summary>
        public static uint ID
        {
            get;set;
        }

        /// <summary>
        /// Lesson Title
        /// </summary>
        public static string LessonTitle
        {
            get; set;
        } = "No Title";

        /// <summary>
        /// Content of the lesson
        /// </summary>
        public static string Content
        {
            get; set;
        } = "No Content";
    }
}
