﻿using Core.Persistence.Interfaces.Repositories;
using Domain.Entities;

namespace Application.Services.Repositories
{
    public interface IBrandRepository : IAsyncRepository<Brand>, IRepository<Brand>
    {

    }
}