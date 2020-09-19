﻿namespace SharedTrip.Services
{
    public interface IUsersService
    {
        string GetUserId(string username, string password);

        bool UsernameExists(string username);

        bool EmailExists(string email);

        void Register(string username, string email, string password);
    }
}
