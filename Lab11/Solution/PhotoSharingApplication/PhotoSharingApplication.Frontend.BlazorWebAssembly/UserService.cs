﻿using Microsoft.AspNetCore.Components.Authorization;
using PhotoSharingApplication.Shared.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace PhotoSharingApplication.Frontend.BlazorWebAssembly {
    public class UserService : IUserService {
        private readonly AuthenticationStateProvider authenticationStateProvider;

        public UserService(AuthenticationStateProvider authenticationStateProvider) {
            this.authenticationStateProvider = authenticationStateProvider;
        }

        public async Task<ClaimsPrincipal> GetUserAsync() {
            var state = await authenticationStateProvider.GetAuthenticationStateAsync();
            return state.User;
        }
    }
}
