﻿using Chat.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chat.Repositories
{
    public class DbMessageRepository : IRepository<Message>
    {
        private DbContext dbContext;
        private DbSet<Message> entitySet;

        public DbMessageRepository(DbContext dbContext)
        {
            this.dbContext = dbContext;
            this.entitySet = this.dbContext.Set<Message>();
        }

        public Message Add(Message item)
        {
            this.entitySet.Add(item);
            this.dbContext.SaveChanges();
            return item;
        }

        public Message Update(int id, Message item)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            this.entitySet.Find(id);
        }

        public void Delete(Message item)
        {
            throw new NotImplementedException();
        }

        public Message Get(int id)
        {
            return this.entitySet.Find(id);
        }

        public IQueryable<Message> GetAll()
        {
            return this.entitySet;
        }
    }
}
