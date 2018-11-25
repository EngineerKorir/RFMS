using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ron_Financial_Management_System.Models
{
    public class MenuModel
    {
        public List<MainMenu> MainMenuModel { get; set; }
        public List<SubMenu> SubMenuModel { get; set; }
    }

    public class MainMenu
    {
        public int ID;
        public string MainMenuItem;
        public string MainMenuURL;
    }
    public class SubMenu
    {
        public int MainMenuID;
        public string SubMenuItem;
        public string SubMenuURL;
    }
}