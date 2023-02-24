# SMPTE-TimeCode
Generate SMPTE TimeCode using PC time as a Reference
This is a C# program that displays the current time as SMPTE timecode, and then updates the timecode every second.

The program first uses the DateTime.Now method to get the current date and time. It then calculates the corresponding SMPTE timecode by breaking down the time into hours, minutes, seconds, and frames.

After calculating the total number of frames, the program enters a loop where it repeatedly converts the total number of frames back into SMPTE timecode, updates the console output to show the new timecode, increments the total number of frames, and waits for one second using System.Threading.Thread.Sleep(1000).

The program uses Console.SetCursorPosition(0, Console.CursorTop) to move the console cursor back to the beginning of the current line and overwrite the current output instead of adding new lines.
