﻿using BookNowMovie.AppDbContext;
using BookNowMovie.Models;
using BookNowMovie.Services.IRepository;
using BookNowMovie.Services.Repository.Base;
using Microsoft.EntityFrameworkCore;

namespace BookNowMovie.Services.Repository
{
    public class OrderRepository : BaseRepository<Order>, IOrderRepository
    {
        private readonly ApplicationDbContext _context;
        public OrderRepository(ApplicationDbContext context) :base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Order>> GetCurrentUserOrders(int userId)
        {
            var cntuserOrders = await _context.Orders.Where(x => x.UserId == userId).Include(od=> od.OrderDetail).ToListAsync();
            return cntuserOrders;
        }

    }
}
