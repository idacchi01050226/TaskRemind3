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

        //ゲッターとセッター
        public void SetTitle(string Title)
        {
            this.Title = Title;
        }
        public string GetTitle(string title)
        {
            return this.Title;
        }

        public string ToTSV()
        {
            
        }

    }
}
