using Models.BackgroundModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public interface IBackgroundService
    {
        void CreateBackground(BackgroundCreateModel backgroundToCreate);
        IEnumerable<BackgroundListModel> GetAllBackgrounds();
        BackgroundDetailModel GetBackgroundDetailById(int backgroundId);
        void UpdateBackground(BackgroundUpdateModel backgroundToUpdate, int backgroundId);
        void DeleteBackground(int backgroundId);
    }
}
