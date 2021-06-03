using BapProject.Models;
using BapProject.ViewModels;
using System.Collections.Generic;
using System.Linq;

namespace BapProject.Repositories
{
   public class AppRepository : IAppRepository
    {
        private readonly bapAppsContext db;
        public AppRepository(bapAppsContext db)
        {
            this.db = db;
        }
        public AppViewModel GetBapApp(int appId)
        {
            if (db != null)
            {
                BapApp app = (from dbApp in db.BapApps
                              orderby dbApp.AppId == appId
                              select dbApp).FirstOrDefault();
             
             if(app == null)
                {
                    return null;
                }
                return new AppViewModel
                {
                    AppId = app.AppId,
                    Name = app.Name,
                    Rating = app.Rating,
                    NoofpeopleRated = app.NoofpeopleRated,
                    Category = app.Category,
                    Date = app.Date,
                    Price = app.Price
                };
            }

            return null;
        }
        public IEnumerable<AppViewModel> GetBapApps()
        {
            if (db != null)
            {
                IQueryable<AppViewModel> result = from o in db.BapApps
                                                  orderby o.Name ascending, o.Rating ascending
                                                  select new AppViewModel
                                                  {
                                                      AppId = o.AppId,
                                                      Name = o.Name,
                                                      Rating = o.Rating,
                                                      NoofpeopleRated = o.NoofpeopleRated,
                                                      Date = o.Date,
                                                      Price = o.Price
                                                  };
                return result;
            
            }
            return Enumerable.Empty<AppViewModel>();
        }
    }
}
