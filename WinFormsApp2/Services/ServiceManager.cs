﻿using DB;

namespace WinFormsApp2.Services
{
    public class ServiceManager
    {
        public CargoTypeService CargoTypeService { get; set; } = new();
        public CargoService CargoService { get; set; } = new();
        public RouteService RouteService { get; set; } = new();
        public DifficultyClassService DifficultyService { get; set; } = new();
    }
}