﻿using Projet_2022.Models.Entities;
using Projet_2022.Data.Repository;

namespace Projet_2022.Data.IServices
{
    public interface IOrderService:IEntityBaseRepository<Order>
    {
        Task StoreOrderAsync(List<CartItem> items, string userId, string userEmailAddress);
        Task<List<Order>> GetOrdersByUserIdAndRoleAsync(string userId, string userRole);
    }
}
