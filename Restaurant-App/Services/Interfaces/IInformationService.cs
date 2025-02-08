﻿using Restaurant_App.Models;

namespace Restaurant_App.Services.Interfaces
{
    public interface IInformationService
    {
        Task<IEnumerable<Information>> GetAllAsync();
        Task<Information> GetByIdAsync(int id);
    }
}
