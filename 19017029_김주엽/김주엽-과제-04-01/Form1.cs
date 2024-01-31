using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 김주엽_과제_04_01
{
    public partial class form_Main : Form
    {
        private CardManager cardManager = new CardManager();

        public form_Main()
        {
            InitializeComponent();
        }

        private void btn_Input_Click(object sender, EventArgs e)
        {
            if (txtBox_Name.Text != "" &&
                txtBox_Address.Text != "" &&
                txtBox_Phone.Text != "" &&
                !cardManager.CheckCard(txtBox_Name.Text))
            {
                cardManager.AddCard(txtBox_Name.Text, txtBox_Address.Text, txtBox_Phone.Text);
                listBox_Card.Items.Add(txtBox_Name.Text);
            }
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            ADDR_CARD card = cardManager.SearchCard(txtBox_Name.Text);

            if (card != null)
            {
                txtBox_Address.Text = card.Address;
                txtBox_Phone.Text = card.Phone;
            }

            else
            {
                txtBox_Address.Text = "데이터 없음";
                txtBox_Phone.Text = "데이터 없음";
            }
        }

        private void btn_GotoFirst_Click(object sender, EventArgs e)
        {
            ADDR_CARD card = cardManager.SearchCard(0);

            if (card != null)
            {
                txtBox_Name.Text = card.Name;
                txtBox_Address.Text = card.Address;
                txtBox_Phone.Text = card.Phone;
            }

            else
            {
                txtBox_Name.Text = "데이터 없음";
                txtBox_Address.Text = "데이터 없음";
                txtBox_Phone.Text = "데이터 없음";
            }
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            txtBox_Name.Clear();
            txtBox_Address.Clear();
            txtBox_Phone.Clear();
        }
    }

    public class ADDR_CARD
    {
        public ADDR_CARD() { }
        public ADDR_CARD(string name, string address, string phone)
        {
            Name = name;
            Address = address;
            Phone = phone;
        }

        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
    }

    public class CardManager
    {
        private List<ADDR_CARD> cardList = new List<ADDR_CARD>();

        public void AddCard(ADDR_CARD card)
        {
            cardList.Add(card);
        }

        public void AddCard(string name, string address, string phone)
        {
            cardList.Add(new ADDR_CARD(name, address, phone));
        }

        public ADDR_CARD SearchCard(int idx)
        {
            if (cardList.Count > 0)
                return cardList[idx];

            return null;
        }

        public ADDR_CARD SearchCard(string name)
        {
            return cardList.Find(x=>x.Name == name);
        }

        public bool CheckCard(string name)
        {
            foreach (ADDR_CARD i in cardList)
            {
                if (i.Name.Contains(name))
                    return true;
            }

            return false;
        }
    }
}
