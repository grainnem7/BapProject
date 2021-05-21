using BapProject.Models;
using BapProject.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BapProject.Repositories
{
    public class AppRepository : IAppRepository
    {

        private bapAppsContext db;

        public AppRepository(bapAppsContext db)
        {
            this.db = db;
        }

        public List<AppViewModel> GetBapApps()
        {
            if (db != null)
            {
                List<AppViewModel> apps = new List<AppViewModel>();

                var result = from o in db.BapApps
                             orderby o.Name ascending, o.Rating ascending
                             select o;

                foreach (var r in result)
                {
                    AppViewModel app= new AppViewModel();
                    app.AppId = r.AppId;
                    app.Name = r.Name;
                    app.Rating = r.Rating;
                    app.NoofpeopleRated = r.NoofpeopleRated;
                    app.Category = r.Category;
                    app.Date = r.Date;
                    app.Price = r.Price;


                    apps.Add(app);
                }

                return apps;

 
    }

            return null;
        }
    }
}
