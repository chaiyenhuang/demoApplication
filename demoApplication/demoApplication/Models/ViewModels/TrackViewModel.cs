using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SkillTreeHomework.Models.ViewModels
{
    public class TrackViewModel
    {
        /// <summary>
        /// 類別
        /// </summary>
        public CategoryType Category { get; set; }
        /// <summary>
        /// 金額
        /// </summary>
        public decimal Amount { get; set; }
        /// <summary>
        /// 日期
        /// </summary>
        public DateTime Date { get; set; }
        /// <summary>
        /// 備註
        /// </summary>
        public string Note { get; set; }
    }

    public enum CategoryType
    {
        支出 = 0,

        收入 = 1
    }
}