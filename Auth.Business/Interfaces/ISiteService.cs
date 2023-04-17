﻿using Auth.Data.Models;

namespace Auth.Business.Interfaces
{
    public interface ISiteService
    {
        Task<Site> Create(int orgId, string name);
        Task<IEnumerable<Site>> GetAll();
    }
}