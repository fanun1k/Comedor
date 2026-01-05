using NLog;

namespace FoodService
{
    public class Log
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();

        public static void Info(string message)
        {
            logger.Info(message);
        }

        public static void Info(string message, params object[] parameters)
        {
            logger.Info(message, parameters);
        }

        public static void Error(string message)
        {
            logger.Error(message);
        }

        public static void Error(string message, params object[] parameters)
        {
            logger.Error(message, parameters);
        }
    }
}
