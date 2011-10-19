using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TacCom
{
    public class Item
    {
        private String itemName;
        private String itemType;
        private Object itemAbility;

        //TODO: Remove and refactor NUnit test for CharacterTest
        public Item()
        {
        }

        //TODO: Refactor later
        public Item(String item, String itemTypes, Object itemProp)
        {
            itemName = item;
            itemType = itemTypes;
            itemAbility = itemProp;
        }

        public String getItemName()
        {
            return itemName;
        }

        public String getItemType()
        {
            return itemType;
        }

        //TODO: Refactor later
        public Object getItemAbility()
        {
            return itemAbility;
        }

    }
}
