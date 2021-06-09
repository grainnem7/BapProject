using BapProject.ViewModels;
using System.Collections.Generic;


namespace BapProject.Repositories
{
   public interface IAppRepository
    {
        IEnumerable<AppViewModel> GetBapApps();
        AppViewModel GetBapApp(int appId);
    }
}
