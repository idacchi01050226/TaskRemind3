using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TaskRemind3
{
    public partial class AddTask : Form
    {
        public AddTask()
        {
            InitializeComponent();
            SelectDayCombox.SelectedIndex = 0;//コンボボックスの初期値を設定
        }

        private void Discription_Label_Click(object sender, EventArgs e)
        {
            //ミス作成
        }


        private void Add_Button_Click(object sender, EventArgs e)
        {
            SaveAll();

        }

        private string SaveAll()
        {
            Data data = new Data();//Dataクラスのインスタンス作成
            //リマインド開始時間に入力された値をintに変換するメソッドを実行
            int startHour = NumEnter(RemindStartHour.Text);
            int startMinute = NumEnter(RemindStartMinute.Text);


            data.SetTitle(TitleTextBox.Text);
            data.Content = TitleTextBox.Text;
            data.CheckStartNow = checkStartNow.Checked;
            data.RemindStart = DaySelect(SelectDayCombox.SelectedIndex);
          

        }

        private void SelectDayCombox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SelectDayCombox.SelectedIndex == 3)
            {
                //カレンダーが選択された時の処理をここから作っていければ
                //https://dianxnao.com/cs%E3%82%B3%E3%83%B3%E3%83%9C%E3%83%9C%E3%83%83%E3%82%AF%E3%82%B9%E3%81%AE%E4%BD%BF%E3%81%84%E6%96%B9/
            }
        }

        //SelectDayComboxで日付を正しく取得するためのメソッド
        //起動モードはIndex番号で管理
        private DateTime DaySelect(int i)
        {
            DateTime day = DateTime.Now.Date;//今日の日付のみを取得

            //今日選択
            switch (i) 
            {
                case 0:
                    break;

                case 1:
                    day = day.AddDays(1);//一日追加
                    break;

                case 2:
                    day = day.AddDays(2);//二日追加
                    break;
            }
            return day;
        }

        //入力フォームで時間入力で入力された数字をintに変換する共通メソッド
        private int NumEnter(string content)
        {
            if(int.TryParse(content, out int intContent))
            {
                return intContent;
            }
            else
            {
                return 0;
            }
        }
    }
}
