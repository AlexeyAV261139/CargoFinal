﻿using DB;
using DB.Models;
using Microsoft.EntityFrameworkCore;
using WinFormsApp2.DTO;

namespace WinFormsApp2.Services
{
    public class RouteService
    {
        public async Task<List<Route>> GetRoutes()
        {
            using CargoContext context = new();
            return await context.Routes
                .AsNoTracking()
                .Include(x => x.DifficultyClass)
                .AsNoTracking()
                .ToListAsync();
        }

        public async Task CreateRoute(RouteDTO dto)
        {
            Route route = new()
            {
                Destination = dto.Destination,
                DistanceKm = dto.DistanceKm,
                Price = dto.Price,
                DifficultyClassId = dto.DifficultyClassId,
            };
            using CargoContext context = new();
            await context.Routes.AddAsync(route);     
            await context.SaveChangesAsync();
        }

        public async Task DeleteRoute(Guid id)
        {
            using CargoContext context = new();
            await context.Routes
                .Where(x => x.Id == id)
                .ExecuteDeleteAsync();
        }

        //public async Task<ProfitInfo> GetInfoAboutMostProfitableRoute()
        //{
        //    using CargoContext context = new();
        //    await context.Trips
        //        .Include(x => x.Route)
        //        .GroupBy(x => x.Route)
        //        .Max(x => x.)

        //}

    }

    public class ProfitInfo
    {
        public Route Route { get; set; }

        public decimal Total {  get; set; }
    }
}
