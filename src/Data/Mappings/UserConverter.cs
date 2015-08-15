﻿using System;
using Spoofi.FreudBot.Data.Entities;
using TelegramUser = Telegram.Bot.Types.User;

namespace Spoofi.FreudBot.Data.Mappings
{
    public static class UserConverter
    {
        public static User Convert(this TelegramUser source)
        {
            if (source == null) throw new ArgumentNullException("source");
            return new User
            {
                UserId = source.Id,
                FirstName = source.FirstName,
                LastName = source.LastName,
                UserName = source.Username
            };
        }
    }
}