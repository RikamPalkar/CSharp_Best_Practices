using System;

namespace Prestige.Common
{
    public static class NotificationService
    {
        /// <summary>
        /// This notifies talent
        /// </summary>
        /// <param name="talentName"></param>
        public static string NotifyTalent(string talentName)
        {
            var message = "Notifying talent: " + talentName;
            Console.WriteLine(message);
            return message;
        }
    }
}
