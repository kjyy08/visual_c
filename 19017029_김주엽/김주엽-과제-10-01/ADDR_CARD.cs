using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 김주엽_과제_10_01
{
    [Serializable]
    class ADDR_CARD
    {
        public ADDR_CARD() { }
        public ADDR_CARD(string n, string i, string m) { name = n; id = i; major = m; }

        public string name;
        public string id;
        public string major;
    }

    class ItemManager
    {
        public List<ADDR_CARD> items;

        public ItemManager()
        {
            items = new List<ADDR_CARD>();
        }

        public void Add(string name, string id, string major)
        {
            items.Add(new ADDR_CARD(name, id, major));
        }

        public int GetSelectedIdx(string name)
        {
            return items.FindIndex(x=>x.name == name);
        }

        public ADDR_CARD GetItem(string name)
        {
            return items.Find(x=>x.name == name);
        }

        public ADDR_CARD GetItem(int idx)
        {

            return items[idx];
        }
    }
}
