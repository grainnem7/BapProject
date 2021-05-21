using BapProject.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BapProject.Repositories
{
   public interface IAppRepository
    {

        List<AppViewModel> GetBapApps();
    }
}
