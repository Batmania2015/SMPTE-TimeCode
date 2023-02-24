using System;

class Program
{
    static void Main(string[] args)
    {
        // Get the current date and time
        DateTime now = DateTime.Now;

        // Convert the current time to SMPTE timecode
        int hours = now.Hour;
        int minutes = now.Minute;
        int seconds = now.Second;
        int frames = (now.Millisecond / 33) % 30;

        // Calculate the total number of frames
        int totalFrames = frames + (seconds * 30) + (minutes * 30 * 60) + (hours * 30 * 60 * 60);

        // Start the timecode loop
        while (true)
        {
            // Convert the total number of frames back to SMPTE timecode
            frames = totalFrames % 30;
            seconds = (totalFrames / 30) % 60;
            minutes = (totalFrames / (30 * 60)) % 60;
            hours = (totalFrames / (30 * 60 * 60)) % 24;

            // Move the cursor back to the beginning of the line
            Console.SetCursorPosition(0, Console.CursorTop);

            // Output the SMPTE timecode to the console
            Console.Write($"{hours:D2}:{minutes:D2}:{seconds:D2}:{frames:D2}");

            // Increment the total number of frames
            totalFrames++;

            // Wait for one second
            System.Threading.Thread.Sleep(1000);
        }
    }
}
