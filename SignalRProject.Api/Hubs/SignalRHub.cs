﻿using Microsoft.AspNetCore.SignalR;
using SignalRProject.Data.Concrete;

namespace SignalRProject.Api.Hubs
{
    public class SignalRHub : Hub
    {
        SignalRContext context = new SignalRContext();
        public async Task SendCategoryCount()
        {
            var value = context.Categories.Count();
            await Clients.All.SendAsync("ReceiveCategoryCount", value);
        }
    }
}
