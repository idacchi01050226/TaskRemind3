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

            data.SetTitle(TitleTextBox.Text);
            data.Content = TitleTextBox.Text;
            data.CheckStartNow = checkStartNow.Checked;
            //セレクトボックスのところから作れてない、先セレクトボックスの中身作ります


        }

        private void SelectDayCombox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectDayCombox.SelectedIndex = 0;

            if (SelectDayCombox.SelectedIndex == 3)
            {
                //カレンダーが選択された時の処理をここから作っていければ
                //https://dianxnao.com/cs%E3%82%B3%E3%83%B3%E3%83%9C%E3%83%9C%E3%83%83%E3%82%AF%E3%82%B9%E3%81%AE%E4%BD%BF%E3%81%84%E6%96%B9/
            }
        }
    }
}
