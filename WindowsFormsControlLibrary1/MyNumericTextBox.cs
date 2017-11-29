using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsControlLibrary1
{
   public class MyNumericTextBox : TextBox
    {
        public int P1 { get; set; }//自動實作

        private int m_P2; //實作欄位
        public int P2 //實作屬性
        {
            get
            {
                //............
                return m_P2;
            }
            set
            {
                //..............
                m_P2 = value;
            }
        }


        public override string Text //將屬性設為 只能數值
        //{ get => base.Text; set => base.Text = value; }
        {
            get
            {
                return base.Text;
            }
            set
            {
                int result;
                if(int.TryParse(value, out result))//如果不是value 就out排除
                {
                    base.Text = value;
                }
            }
        }

        protected override void OnKeyPress(KeyPressEventArgs e)//keyWord事件
        {// 程式執行時的keyWord事件。
            if (e.KeyChar ==8)//8代表鍵盤Backspace
            {
                return;
            }
            if(e.KeyChar<'0' || e.KeyChar >'9')
            {
                e.Handled = true;  //表示e 處理過就不往下傳了
            }
        }


    }
}
