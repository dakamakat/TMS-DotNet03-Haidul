﻿using System.Threading.Tasks;
using EventMaker.BLL.Models;

namespace EventMaker.BLL.Interfaces
{
    /// <summary>
    /// Profile manager.
    /// </summary>
    public interface IProfileManager
    {
        /// <summary>
        /// Get User Profile.
        /// </summary>
        /// <param name="userName">Username</param>
        /// <returns>Task<ProfileDto></returns>
        Task<ProfileDto> GetProfile(string userName);

        /// <summary>
        /// Create Profile.
        /// </summary>
        /// <param name="email">Email</param>
        /// <param name="userName">Username</param>
        Task CreateProfileAsync(string email, string userName, string userId);

        /// <summary>
        /// Edit profile.
        /// </summary>
        /// <param name="profileDto">Profile DTO</param>
        Task UpdateProfileAsync(ProfileDto profileDto);
    }
}
