using System;
using System.Collections.Generic;
using System.Text;

namespace TaskRemind3
{
    public class Data
    {
        //変数の宣言
        private string Title;//こいつだけ手書きで動作書いた
        public string Content { get; set; }
        public bool CheckStartNow { get; set; }
        public DateTime RemindStart { get; set; }
        public TimeSpan RemindInterval { get; set; }

        // public DateTime SelectDayCombox { get; set; }
        //  public TimeSpan RemindStart { get; set; }
        //public int RemindStartHour { get; set; }
        //public int RemindStartMinute { get; set; }
        //public int IntervalDay { get; set; }
        //public int IntervalHour { get; set; }
        //public int IntervalMinute { get; set; }

        //ゲッターとセッター、一つだけ作った
        public void SetTitle(string Title)
        {
            this.Title = Title;
        }
        public string GetTitle()
        {
            return this.Title;
        }


    }
}
