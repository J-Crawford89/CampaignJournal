using Contracts;
using Data;
using Models.BackgroundModels;
using Models.EntityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class BackgroundService : IBackgroundService
    {
        private readonly ApplicationDbContext _ctx = new ApplicationDbContext();
        public void CreateBackground(BackgroundCreateModel backgroundToCreate)
        {
            var backgroundEntity = new Background()
            {
                Name = backgroundToCreate.Name,
                Description = backgroundToCreate.Description,
                DateCreated = DateTime.Now,
                LastUpdated = DateTime.Now,
                IsDeleted = false
            };
            _ctx.Backgrounds.Add(backgroundEntity);
            _ctx.SaveChanges();
        }

        public void DeleteBackground(int backgroundId)
        {
            var backgroundEntity = _ctx.Backgrounds.Single(background => background.Id == backgroundId);
            backgroundEntity.IsDeleted = true;

            _ctx.SaveChanges();
        }

        public IEnumerable<BackgroundListModel> GetAllBackgrounds()
        {
            var backgroundList = _ctx.Backgrounds.Select(background => new BackgroundListModel()
            {
                Id = background.Id,
                Name = background.Name
            }).ToList();

            return backgroundList;
        }

        public BackgroundDetailModel GetBackgroundDetailById(int backgroundId)
        {
            var backgroundEntity = _ctx.Backgrounds.Single(background => background.Id == backgroundId);
            BackgroundDetailModel backgroundDetail = new BackgroundDetailModel()
            {
                Id = backgroundEntity.Id,
                Name = backgroundEntity.Name,
                Description = backgroundEntity.Description,
                DateCreated = backgroundEntity.DateCreated,
                LastUpdated = backgroundEntity.LastUpdated
            };

            return backgroundDetail;
        }

        public void UpdateBackground(BackgroundUpdateModel backgroundToUpdate, int backgroundId)
        {
            var backgroundEntity = _ctx.Backgrounds.Single(background => background.Id == backgroundId);
            if (backgroundEntity != null)
            {
                if (backgroundToUpdate.UpdatedName != null)
                    backgroundEntity.Name = backgroundToUpdate.UpdatedName;
                if (backgroundToUpdate.UpdatedDescription != null)
                    backgroundEntity.Description = backgroundToUpdate.UpdatedDescription;
                backgroundEntity.LastUpdated = DateTime.Now;

                _ctx.SaveChanges();
            }
        }
    }
}
