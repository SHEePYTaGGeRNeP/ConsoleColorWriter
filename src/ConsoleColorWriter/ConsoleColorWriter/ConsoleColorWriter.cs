using System;
using System.Text;

namespace SHEePYTaGGeRNeP.ConsoleColorWriter
{
    /// <summary>
    /// Very easy to use console colors.
    /// Works out of the box, no initializing necessary. Just call the static methods everything is setup already.
    /// You can of course change all the colors being used by the methods by changing the properties ( ex: StandardBackColor ).
    /// 
    /// Made by SHEePYTaGGeRNeP
    /// </summary>
    public static class CCW
    {
        

        #region - - - - - - - - - - - - - - - - - - Color Variables - - - - - - - - - - - - - - - - - - 
        
        #region - - - - - - - - - - - - - - - - - - Fields - - - - - - - - - - - - - - - - - - 

        private static ConsoleColor _standardFrontColor = ConsoleColor.White;
        private static ConsoleColor _standardBackColor = ConsoleColor.Black;
        private static ConsoleColor _questionFrontColor = ConsoleColor.Black;
        private static ConsoleColor _questionBackColor = ConsoleColor.White;
        private static ConsoleColor _errorFrontColor = ConsoleColor.Red;
        private static ConsoleColor _errorBackColor = ConsoleColor.Black;
        private static ConsoleColor _errorMessageFrontColor = ConsoleColor.White;
        private static ConsoleColor _errorMessageBackColor = ConsoleColor.Red;
        private static ConsoleColor _warningFrontColor = ConsoleColor.DarkYellow;
        private static ConsoleColor _warningBackColor = ConsoleColor.Black;
        private static ConsoleColor _warningMessageFrontColor = ConsoleColor.White;
        private static ConsoleColor _warningMessageBackColor = ConsoleColor.DarkYellow;

        #endregion
        
        #region - - - - - - - - - - - - - - - - - - Properties - - - - - - - - - - - - - - - - - - 

        /// <summary>
        /// Standard Front color. Used in WriteSeperator and WriteText
        /// </summary>
        public static ConsoleColor StandardFrontColor
        {
            get { return _standardFrontColor; }
            set { _standardFrontColor = value; }
        }

        /// <summary>
        /// Standard Background color. Used in WriteSeperator and WriteText
        /// </summary>
        public static ConsoleColor StandardBackColor
        {
            get { return _standardBackColor; }
            set { _standardBackColor = value; }
        }

        /// <summary>
        /// Used in WriteQuestionMessage
        /// </summary>
        public static ConsoleColor QuestionFrontColor
        {
            get { return _questionFrontColor; }
            set { _questionFrontColor = value; }
        }

        /// <summary>
        /// Used in WriteQuestionMessage
        /// </summary>
        public static ConsoleColor QuestionBackColor
        {
            get { return _questionBackColor; }
            set { _questionBackColor = value; }
        }

        /// <summary>
        /// Used in WriteErrorMessage. This is changes the "ERROR: " color. 
        /// </summary>
        public static ConsoleColor ErrorFrontColor
        {
            get { return _errorFrontColor; }
            set { _errorFrontColor = value; }
        }

        /// <summary>
        /// Used in WriteErrorMessage. This is changes the "ERROR: " color. 
        /// </summary>
        public static ConsoleColor ErrorBackColor
        {
            get { return _errorBackColor; }
            set { _errorBackColor = value; }
        }

        /// <summary>
        /// Used in WriteErrorMessage. This changes the color of the actual message.
        /// </summary>
        public static ConsoleColor ErrorMessageFrontColor
        {
            get { return _errorMessageFrontColor; }
            set { _errorMessageFrontColor = value; }
        }

        /// <summary>
        /// Used in WriteErrorMessage. This changes the color of the actual message.
        /// </summary>
        public static ConsoleColor ErrorMessageBackColor
        {
            get { return _errorMessageBackColor; }
            set { _errorMessageBackColor = value; }
        }

        /// <summary>
        /// Used in WriteWarningMessage. This is changes the "WARNING: " color.
        /// </summary>
        public static ConsoleColor WarningFrontColor
        {
            get { return _warningFrontColor; }
            set { _warningFrontColor = value; }
        }

        /// <summary>
        /// Used in WriteWarningMessage. This is changes the "WARNING: " color. 
        /// </summary>
        public static ConsoleColor WarningBackColor
        {
            get { return _warningBackColor; }
            set { _warningBackColor = value; }
        }

        /// <summary>
        /// Used in WriteWarningMessage. This changes the color of the actual message.
        /// </summary>
        public static ConsoleColor WarningMessageFrontColor
        {
            get { return _warningMessageFrontColor; }
            set { _warningMessageFrontColor = value; }
        }

        /// <summary>
        /// Used in WriteWarningMessage. This changes the color of the actual message.
        /// </summary>
        public static ConsoleColor WarningMessageBackColor
        {
            get { return _warningMessageBackColor; }
            set { _warningMessageBackColor = value; }
        }

        #endregion
        
        #endregion

        /// <summary>
        /// Sets the current console colors.
        /// </summary>
        /// <param name="pFrontColor">Front color</param>
        /// <param name="pBackgroundColor">Back color</param>
        public static void SetColors(ConsoleColor pFrontColor, ConsoleColor pBackgroundColor)
        {
            Console.ForegroundColor = pFrontColor;
            Console.BackgroundColor = pBackgroundColor;
        }

        /// <summary>
        /// Writes a new line full of [pCharacter] in the CURRENT CONSOLE COLORS.
        /// </summary>
        public static void WriteSeperator(char pCharacter)
        {
            StringBuilder lvMBuilder = new StringBuilder();
            for (int lvIndex = 0; lvIndex < Console.BufferWidth; lvIndex++)
                lvMBuilder.Append(pCharacter);
            Console.WriteLine(lvMBuilder.ToString());
        }

        /// <summary>
        /// Writes with the StandardFrontColor and StandardBackColor, creates a new line and then resets the console colors to StandardFrontColor and StandardBackColor.
        /// Also writes the time.
        /// </summary>
        /// <param name="pText">Text to be written to console</param>
        public static void WriteText(string pText)
        {
            WriteColoredText(pText, StandardFrontColor, StandardBackColor, true,true);
        }
        /// <summary>
        /// Writes with the StandardFrontColor and StandardBackColor.
        /// Also writes the time.
        /// </summary>
        /// <param name="pText">Text to be written to console</param>
        /// <param name="pWriteLine">TRUE = creates a new line after text has been placed</param>
        public static void WriteText(string pText, bool pWriteLine)
        {
            WriteColoredText(pText, ConsoleColor.White, ConsoleColor.Black, pWriteLine, true);
        }
        /// <summary>
        /// Writes with the StandardFrontColor and StandardBackColor, creates a new line and then resets the console colors to StandardFrontColor and StandardBackColor.
        /// </summary>
        /// <param name="pText">Text to be written to console</param>
        /// <param name="pWriteLine">TRUE = creates a new line after text has been placed.</param>
        /// <param name="pWriteTime">TRUE = writes the current time in StandardFrontColor and StandardBackColor before writing the text.</param>
        public static void WriteText(string pText, bool pWriteLine, bool pWriteTime)
        {
            WriteColoredText(pText, StandardFrontColor, StandardBackColor, pWriteLine,pWriteTime);
        }

        /// <summary>
        /// Writes a new line with the QuestionFrontColor and QuestionBackColor.
        /// Also writes the time.
        /// </summary>
        /// <param name="pText">Text to be written to console</param>
        public static void WriteQuestionMessage(string pText)
        {
            WriteColoredText(pText, QuestionFrontColor, QuestionBackColor, true, true);
        }

        /// <summary>
        /// Writes with the QuestionFrontColor and QuestionBackColor.
        /// Also writes the time.
        /// </summary>
        /// <param name="pText">Text to be written to console</param>
        /// <param name="pWriteLine">TRUE = creates a new line after text has been placed.</param>
        public static void WriteQuestionMessage(string pText, bool pWriteLine)
        {
            WriteColoredText(pText, QuestionFrontColor, QuestionBackColor, pWriteLine, true);
        }
        /// <summary>
        /// Writes with the QuestionFrontColor and QuestionBackColor and then resets the console colors to StandardFrontColor and StandardBackColor.
        /// </summary>
        /// <param name="pText">Text to be written to console</param>
        /// <param name="pWriteLine">TRUE = creates a new line after text has been placed.</param>
        /// <param name="pWriteTime">TRUE = writes the current time in StandardFrontColor and StandardBackColor before writing the text.</param>
        public static void WriteQuestionMessage(string pText, bool pWriteLine, bool pWriteTime)
        {
            WriteColoredText(pText, QuestionFrontColor, QuestionBackColor, pWriteLine, pWriteTime);
        }

        /// <summary>
        /// Writes with the ErrorFrontColor and ErrorBackColor and then resets the console colors to StandardFrontColor and StandardBackColor.
        /// Also writes the time.
        /// </summary>
        /// <param name="pText">Text to be written to console.</param>
        public static void WriteErrorMessage(string pText)
        {
            WriteColoredText("ERROR: ", ErrorFrontColor, ErrorBackColor, false, true);
            WriteColoredText(pText, ErrorMessageFrontColor,ErrorMessageBackColor, true, false);
        }
        /// <summary>
        /// Writes with the ErrorFrontColor and ErrorBackColor and then resets the console colors to StandardFrontColor and StandardBackColor.
        /// </summary>
        /// <param name="pText">Text to be written to console.</param>
        /// <param name="pWriteTime">TRUE = writes the current time in StandardFrontColor and StandardBackColor before writing the text.</param>
        public static void WriteErrorMessage(string pText, bool pWriteTime)
        {
            WriteColoredText("ERROR: ", ErrorFrontColor, ErrorBackColor, false, pWriteTime);
            WriteColoredText(pText, ErrorMessageFrontColor,ErrorMessageBackColor, true, false);
        }

        /// <summary>
        /// Writes with the WarningFrontColor and WarningBackColor and then resets the console colors to StandardFrontColor and StandardBackColor.
        /// </summary>
        /// <param name="pText">Text to be written to console.</param>
        public static void WriteWarningMessage(string pText)
        {
            WriteColoredText("WARNING: ", WarningFrontColor, WarningBackColor, false, true);
            WriteColoredText(pText, WarningMessageFrontColor, WarningMessageBackColor, true, false);
        }
        /// <summary>
        /// Writes with the WarningFrontColor and WarningBackColor and then resets the console colors to StandardFrontColor and StandardBackColor.
        /// </summary>
        /// <param name="pText">Text to be written to console.</param>
        /// <param name="pWriteTime">TRUE = writes the current time in StandardFrontColor and StandardBackColor before writing the text.</param>
        public static void WriteWarningMessage(string pText, bool pWriteTime)
        {
            WriteColoredText("WARNING: ", WarningFrontColor, WarningBackColor, false, pWriteTime);
            WriteColoredText(pText, WarningMessageFrontColor, WarningMessageBackColor, true, false);
        }

        /// <summary>
        /// Writes a new line with time and uses StandardBackColor and then resets the console colors to StandardFrontColor and StandardBackColor
        /// </summary>
        /// <param name="pText">Text to be written to console.</param>
        /// <param name="pFrontColor">The front color</param>
        public static void WriteColoredText(string pText, ConsoleColor pFrontColor)
        {
            WriteColoredText(pText, pFrontColor, StandardBackColor, true, false);
        }
        /// <summary>
        /// Writes with time and uses StandardBackColor and then resets the console colors to StandardFrontColor and StandardBackColor
        /// </summary>
        /// <param name="pText">Text to be written to console.</param>
        /// <param name="pFrontColor">The front color</param>
        /// <param name="pWriteLine">TRUE = creates a new line after text has been placed.</param>
        public static void WriteColoredText(string pText, ConsoleColor pFrontColor, bool pWriteLine)
        {
            WriteColoredText(pText, pFrontColor, StandardBackColor, true, pWriteLine);
        }
        /// <summary>
        /// Writes a new line with time and uses StandardBackColor and then resets the console colors to StandardFrontColor and StandardBackColor
        /// </summary>
        /// <param name="pText">Text to be written to console.</param>
        /// <param name="pFrontColor">The front color</param>
        /// <param name="pBackgroundColor">The background color</param>
        public static void WriteColoredText(string pText, ConsoleColor pFrontColor, ConsoleColor pBackgroundColor)
        {
            WriteColoredText(pText, pFrontColor, pBackgroundColor, true, true);
        }
        /// <summary>
        /// Writes Colored text to the console, uses StandardBackColor and then resets the console colors to StandardFrontColor and StandardBackColor.
        /// </summary>
        /// <param name="pText">Text to be written to console.</param>
        /// <param name="pFrontColor">The front color</param>
        /// <param name="pWriteLine">TRUE = creates a new line after text has been placed.</param>
        /// <param name="pWriteCurrentTime">TRUE = writes the current time in StandardFrontColor and StandardBackColor before writing the text.</param>
        public static void WriteColoredText(string pText, ConsoleColor pFrontColor, bool pWriteLine, bool pWriteCurrentTime)
        {
            WriteColoredText(pText, pFrontColor, StandardBackColor, pWriteLine,pWriteCurrentTime);
        }
        


        /// <summary>
        /// Writes Colored text to the console and then resets the console colors to StandardFrontColor and StandardBackColor.
        /// </summary>
        /// <param name="pText">Text to be written to console.</param>
        /// <param name="pFrontColor">The front color</param>
        /// <param name="pBackgroundColor">The back color</param>
        /// <param name="pWriteLine">TRUE = creates a new line after text has been placed.</param>
        /// <param name="pWriteCurrentTime">TRUE = writes the current time in StandardFrontColor and StandardBackColor before writing the text.</param>
        public static void WriteColoredText(string pText, ConsoleColor pFrontColor, ConsoleColor pBackgroundColor, bool pWriteLine,  bool pWriteCurrentTime)
        {
            if (pWriteCurrentTime)
            {
                Console.ForegroundColor = StandardFrontColor;
                Console.BackgroundColor = StandardBackColor;
                Console.Write(DateTime.Now + " : ");
            }
            Console.ForegroundColor = pFrontColor;
            Console.BackgroundColor = pBackgroundColor;
            if (pWriteLine)
                Console.WriteLine(pText);
            else
                Console.Write(pText);
            Console.ForegroundColor = StandardFrontColor;
            Console.BackgroundColor = StandardBackColor;
        }
    }
}
