﻿using NeonHackathon.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonHackathon.Data
{
        public class UnitOfWork : IUnitOfWork
        {
            private readonly NeonHackathonContext _dbContext;
            private readonly Dictionary<Type, object> _repositories = new Dictionary<Type, object>();

            public Dictionary<Type, object> Repositories
            {
                get { return _repositories; }
                set { Repositories = value; }
            }

            public UnitOfWork(NeonHackathonContext dbContext)
            {
                _dbContext = dbContext;
            }

            public IGenericRepository<T> Repository<T>() where T : class
            {
                if (Repositories.Keys.Contains(typeof(T)))
                {
                    return Repositories[typeof(T)] as IGenericRepository<T>;
                }

                IGenericRepository<T> repo = new GenericRepository<T>(_dbContext);
                Repositories.Add(typeof(T), repo);
                return repo;
            }

            public async Task<int> Commit()
            {
                return await _dbContext.SaveChangesAsync();
            }

            public void Rollback()
            {
                _dbContext.ChangeTracker.Entries().ToList().ForEach(x => x.Reload());
            }
        }

    }

