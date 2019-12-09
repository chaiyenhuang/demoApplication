using Dapper;
using SkillTreeHomework.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Configuration;
using demoApplication.Models;

namespace SkillTreeHomework.Service
{
    public class BookKeepingService
    {
        private readonly SqlConnection conn;

        public BookKeepingService()
        {
            conn = new SqlConnection(ConfigurationManager.ConnectionStrings["SkillTreeHomeworkEntities"].ToString());
        }
        public IEnumerable<TrackViewModel> GetTrackdata()
        {
            List<AccountBook> queryresults = null;
            using (conn)
            {
                string strSql = "Select * from AccountBook";
                queryresults = conn.Query<AccountBook>(strSql).ToList();
            }

            var tracklist = new List<TrackViewModel>();
            //塞資料
            for (int i = 0; i < queryresults.Count; i++)
            {
                TrackViewModel result = new TrackViewModel
                {
                    Category = (CategoryType)(queryresults[i].Categoryyy),
                    Amount = queryresults[i].Amounttt,
                    Date = queryresults[i].Dateee
                };

                //資料丟進List
                tracklist.Add(result);
            }

            return tracklist;
        }
    }
}