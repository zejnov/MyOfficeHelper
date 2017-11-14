﻿using System;

namespace OfficeAssistant.ConsoleHelper
{
    public class ArrowsHandling
    {
        public Tuple<int, int> GetValidHighligthMove(int horizontal, int vertical, int width, int height)
        {
            var inputCoordinates = new Tuple<int, int>(horizontal,vertical);
            var inputSize = new Tuple<int, int>(width,height);
            var arrowKey = ReadArrowDirection();

            arrowKey = Validate(arrowKey,horizontal,vertical,width,height);

            var result = ExecuteArrowKey(horizontal, vertical, arrowKey);
            
            return new Tuple<int, int>(horizontal, vertical);
        }

        public static AssistantEnums.ArrowDirections Validate(AssistantEnums.ArrowDirections arrowDirection, int horizontal, int vertical, int width, int height)
        {
            switch (arrowDirection)
            {
                case AssistantEnums.ArrowDirections.None:
                    break;
                case AssistantEnums.ArrowDirections.Left:
                    if (horizontal == 0)
                        return AssistantEnums.ArrowDirections.None;
                    break;
                case AssistantEnums.ArrowDirections.Right:
                    if (horizontal == width - 1)
                        return AssistantEnums.ArrowDirections.None;
                    break;
                case AssistantEnums.ArrowDirections.Up:
                    if (vertical == 0)
                        return AssistantEnums.ArrowDirections.None;
                    break;
                case AssistantEnums.ArrowDirections.Down:
                    if (vertical == height - 1)
                        return AssistantEnums.ArrowDirections.None;
                    break;
            }
            return AssistantEnums.ArrowDirections.None;
        }

        private Tuple<int, int> ExecuteArrowKey(int horizontal, int vertical, AssistantEnums.ArrowDirections arrowKey)
        {
            switch (arrowKey)
            {
                case AssistantEnums.ArrowDirections.None:
                    break;
                case AssistantEnums.ArrowDirections.Left:
                    horizontal--;
                    break;
                case AssistantEnums.ArrowDirections.Right:
                    horizontal++;
                    break;
                case AssistantEnums.ArrowDirections.Up:
                    vertical++;
                    break;
                case AssistantEnums.ArrowDirections.Down:
                    vertical--;
                    break;
            }
            return new Tuple<int, int>(horizontal, vertical);
        }

        private static AssistantEnums.ArrowDirections ReadArrowDirection()
        {
            var key = Console.ReadKey(false);
            
            switch (key.Key)
            {
                case ConsoleKey.LeftArrow:
                    return AssistantEnums.ArrowDirections.Left;

                case ConsoleKey.RightArrow:
                    return AssistantEnums.ArrowDirections.Right;
                    
                case ConsoleKey.UpArrow:
                    return AssistantEnums.ArrowDirections.Up;

                case ConsoleKey.DownArrow:
                    return AssistantEnums.ArrowDirections.Down;
            }
            return AssistantEnums.ArrowDirections.None;
        }
    }
}
