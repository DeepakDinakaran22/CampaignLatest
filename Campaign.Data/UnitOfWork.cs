﻿

namespace Campaign.Data
{
    using Campaign.Data;
    using System;
    using Campaign.Data.Entities;
    public class UnitOfWork : IDisposable
    {
        private CampaignContext context = new CampaignContext();
        private GenericRepository<Campaign> campaignRepository;
        private GenericRepository<Category> categoryRepository;
        private GenericRepository<CampaignStatus> statusRepository;
        private GenericRepository<Players> playerRepository;

        private GenericRepository<Job> jobRepository;


        private GenericRepository<Network> networkRepository;
        public GenericRepository<Campaign> CampaignRepository
        {
            get
            {
                if (this.campaignRepository == null)
                {
                    this.campaignRepository = new GenericRepository<Campaign>(context);
                }
                return campaignRepository;
            }
        }
        public GenericRepository<Job> JobRepository
        {
            get
            {
                if (this.jobRepository == null)
                {
                    this.jobRepository = new GenericRepository<Job>(context);
                }
                return jobRepository;
            }
        }
        public GenericRepository<Category> CategoryRepository
        {
            get
            {
                if (this.categoryRepository == null)
                {
                    this.categoryRepository = new GenericRepository<Category>(context);
                }
                return categoryRepository;
            }
        }

        public GenericRepository<Network> NetworkRepository
        {
            get
            {
                if (this.networkRepository == null)
                {
                    this.networkRepository = new GenericRepository<Network>(context);
                }
                return networkRepository;
            }
        }

        public GenericRepository<CampaignStatus> StatusRepository
        {
            get
            {
                if (this.statusRepository == null)
                {
                    this.statusRepository = new GenericRepository<CampaignStatus>(context);
                }
                return statusRepository;
            }
        }

        public GenericRepository<Players> PlayerRepository
        {
            get
            {
                if (this.playerRepository == null)
                {
                    this.playerRepository = new GenericRepository<Players>(context);
                }
                return playerRepository;
            }
        }
        public void Save()
        {
            context.SaveChanges();
        }
        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
