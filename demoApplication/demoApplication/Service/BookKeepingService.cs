using SkillTreeHomework.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SkillTreeHomework.Service
{
    public class BookKeepingService
    {
        public IEnumerable<TrackViewModel> GetTrackdata()
        {
            var tracklist = new List<TrackViewModel>();
            int num = 0;
            //塞假資料100筆
            for (int i = 0; i < 100; i++)
            {
                //隨機數字
                num = new Random(Guid.NewGuid().GetHashCode()).Next(1,9999) + i;
                TrackViewModel result = new TrackViewModel
                {
                    Category = (CategoryType)(num % 2),
                    Amount = num,
                    Date = DateTime.Now.AddDays(i)
                };

                //資料丟進List
                tracklist.Add(result);
            }


            return tracklist;
        }
    }
}