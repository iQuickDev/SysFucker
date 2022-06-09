using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Toolkit.Uwp.Notifications;

namespace SysFucker
{
    public static class NotificationSender
    {
        public static void sendRandomNotification()
        {
            SoundPlayer player = new SoundPlayer(Properties.Resources.yourcomputerhasvirus);
            player.Play();
            new ToastContentBuilder()
                .AddHeader("title", "Virus & threat protection", "your computer has virus")
                .AddText("Failed to remove the threat")
                .AddText("We've found a new threat in your system but it was impossible to remove it")
                .Show();
        }
    }
}
