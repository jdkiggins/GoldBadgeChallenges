using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeekThreeChallenges_01
{
    public class CafeRepository
    {
        private List<CafeMenu> _listOfMenuItems = new List<CafeMenu>();

        public void AddMenuItemToList(CafeMenu content)
        {
            _listOfMenuItems.Add(content);
        }
        public List<CafeMenu> GetMenuItems()
        {
            return _listOfMenuItems;
        }
        
        public CafeMenu OrderItemFromList(int menuNumber)
        {
            foreach (CafeMenu content in _listOfMenuItems)
            {
                if (content.TypeOfOrder.ToLower() == menuNumber.ToString());
                {
                    return content;
                }
            }
            return null;
        }
        public bool RemoveMenuItemFromList(CafeMenu content)
        {
            int initalCount = _listOfMenuItems.Count;
            _listOfMenuItems.Remove(content);
            if (initalCount > _listOfMenuItems.Count)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
