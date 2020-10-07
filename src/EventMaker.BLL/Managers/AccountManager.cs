﻿using EventMaker.BLL.Interfaces;
using EventMaker.DAL.Entities;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EventMaker.BLL.Managers
{
    /// <inheritdoc cref="IAccountManager"/>
    public class AccountManager : IAccountManager
    {
        private readonly UserManager<ApplicationUser> _userManager;

        public AccountManager(UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager ?? throw new ArgumentNullException(nameof(userManager));
        }

        public async Task<IdentityResult> RegisterAsync(string email , string password , string username)
        {
             var user = new ApplicationUser 
             { 
                 Email = email,
                 UserName = username 
             };
             return await _userManager.CreateAsync(user, password);
        }
    }
} 
