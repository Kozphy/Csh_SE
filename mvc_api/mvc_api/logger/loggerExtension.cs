using System.Runtime.CompilerServices;

namespace mvc_api.logger
{
    public static class loggerExtensions
    {
        public static Serilog.ILogger Here(this Serilog.ILogger logger,
            [CallerMemberName] string memberName = "",
            [CallerFilePath] string sourceFilePath = "",
            [CallerLineNumber] int lineNumber = 0
            )
        {
            char seperator = Path.DirectorySeparatorChar;
            string[] filePath = sourceFilePath.Split(seperator);
            string fileName = filePath[filePath.Length - 1];

            return logger.ForContext("methodName", memberName).ForContext("fileName", fileName).ForContext("lineNum", lineNumber);
        }
    }
}
