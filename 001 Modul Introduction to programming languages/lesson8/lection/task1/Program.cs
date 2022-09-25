string caption = "Intensive C# Demo text.";
int screenWidthPosition = (Console.WindowWidth - caption.Length) / 2;
int screenHeightPosition = Console.WindowHeight / 2;

void DrawText(string inputText, int widthPosition, int heightPosition)
{
    Console.SetCursorPosition(widthPosition, heightPosition);
    Console.WriteLine(inputText);
}

DrawText(caption,screenHeightPosition,screenWidthPosition);