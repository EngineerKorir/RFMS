using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ron_Financial_Management_System.Models;
namespace Ron_Financial_Management_System.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            MenuModel ObjMenuModel = new MenuModel();
            ObjMenuModel.MainMenuModel = new List<MainMenu>();
            ObjMenuModel.MainMenuModel = GetMainMenu();
            ObjMenuModel.SubMenuModel = new List<SubMenu>();
            ObjMenuModel.SubMenuModel = GetSubMenu();

            return View(ObjMenuModel);
        }

        public List<MainMenu> GetMainMenu()
        {
            List<MainMenu> ObjMainMenu = new List<MainMenu>();
            ObjMainMenu.Add(new MainMenu { ID = 1, MainMenuItem = "Home", MainMenuURL = "#" });
            ObjMainMenu.Add(new MainMenu { ID = 2, MainMenuItem = "System Setup", MainMenuURL = "#" });
            ObjMainMenu.Add(new MainMenu { ID = 3, MainMenuItem = "Loan Management", MainMenuURL = "#" });
            ObjMainMenu.Add(new MainMenu { ID = 4, MainMenuItem = "Accounts Receivables", MainMenuURL = "#" });
            ObjMainMenu.Add(new MainMenu { ID = 5, MainMenuItem = "Accounts Payables", MainMenuURL = "#" });
            ObjMainMenu.Add(new MainMenu { ID = 6, MainMenuItem = "General Accounts", MainMenuURL = "#" });
            ObjMainMenu.Add(new MainMenu { ID = 7, MainMenuItem = "Quick Task", MainMenuURL = "#" });
            ObjMainMenu.Add(new MainMenu { ID = 8, MainMenuItem = "Report Manager", MainMenuURL = "#" });
            ObjMainMenu.Add(new MainMenu { ID = 9, MainMenuItem = "Chart Types", MainMenuURL = "#" });

            return ObjMainMenu;
        }
        public List<SubMenu> GetSubMenu()
        {
            List<SubMenu> ObjSubMenu = new List<SubMenu>();
            ObjSubMenu.Add(new SubMenu { MainMenuID = 2, SubMenuItem = "Customer Information", SubMenuURL = "MemberReg" });
            ObjSubMenu.Add(new SubMenu { MainMenuID = 2, SubMenuItem = "Chart Of Accounts", SubMenuURL = "EmployerReg" });
            ObjSubMenu.Add(new SubMenu { MainMenuID = 2, SubMenuItem = "Loans General Setup", SubMenuURL = "CompanyInfo" });
            ObjSubMenu.Add(new SubMenu { MainMenuID = 2, SubMenuItem = "Account Types Setup", SubMenuURL = "#" });
            ObjSubMenu.Add(new SubMenu { MainMenuID = 2, SubMenuItem = "Company Configurations", SubMenuURL = "#" });
            ObjSubMenu.Add(new SubMenu { MainMenuID = 2, SubMenuItem = "Member Setup", SubMenuURL = "#" });
            ObjSubMenu.Add(new SubMenu { MainMenuID = 2, SubMenuItem = "Policy Setup", SubMenuURL = "#" });
            ObjSubMenu.Add(new SubMenu { MainMenuID = 2, SubMenuItem = "Manage Messages", SubMenuURL = "#" });
            ObjSubMenu.Add(new SubMenu { MainMenuID = 2, SubMenuItem = "Location Setups", SubMenuURL = "#" });
            ObjSubMenu.Add(new SubMenu { MainMenuID = 2, SubMenuItem = "Monthly Summary Accounts", SubMenuURL = "#" });

            ObjSubMenu.Add(new SubMenu { MainMenuID = 3, SubMenuItem = "Receive Loan Application Forms", SubMenuURL = "#" });
            ObjSubMenu.Add(new SubMenu { MainMenuID = 3, SubMenuItem = "Loan Application", SubMenuURL = "#" });
            ObjSubMenu.Add(new SubMenu { MainMenuID = 3, SubMenuItem = "Loan Appraisal", SubMenuURL = "#" });
            ObjSubMenu.Add(new SubMenu { MainMenuID = 3, SubMenuItem = "Loan Approval", SubMenuURL = "#" });
            ObjSubMenu.Add(new SubMenu { MainMenuID = 3, SubMenuItem = "Loan Disbursment", SubMenuURL = "#" });
            ObjSubMenu.Add(new SubMenu { MainMenuID = 3, SubMenuItem = "Gaurantor Management", SubMenuURL = "#" });
            ObjSubMenu.Add(new SubMenu { MainMenuID = 3, SubMenuItem = "Process Loan Clearance", SubMenuURL = "#" });

            ObjSubMenu.Add(new SubMenu { MainMenuID = 4, SubMenuItem = "Non-member receipts", SubMenuURL = "#" });
            ObjSubMenu.Add(new SubMenu { MainMenuID = 4, SubMenuItem = "Accept Cheque/Cash Deposits", SubMenuURL = "#" });
            ObjSubMenu.Add(new SubMenu { MainMenuID = 4, SubMenuItem = "Remittance Processes", SubMenuURL = "#" });
            ObjSubMenu.Add(new SubMenu { MainMenuID = 4, SubMenuItem = "Calculate Interest On Loans", SubMenuURL = "#" });
            ObjSubMenu.Add(new SubMenu { MainMenuID = 4, SubMenuItem = "Update Member  expected deductions", SubMenuURL = "#" });
            ObjSubMenu.Add(new SubMenu { MainMenuID = 4, SubMenuItem = "Fixed Deposit Management", SubMenuURL = "#" });

            ObjSubMenu.Add(new SubMenu { MainMenuID = 5, SubMenuItem = "Non-member payments", SubMenuURL = "#" });
            ObjSubMenu.Add(new SubMenu { MainMenuID = 5, SubMenuItem = "Dividend Processing", SubMenuURL = "#" });
            ObjSubMenu.Add(new SubMenu { MainMenuID = 5, SubMenuItem = "Salary Posting Managemnt", SubMenuURL = "#" });
            ObjSubMenu.Add(new SubMenu { MainMenuID = 5, SubMenuItem = "Pay Members", SubMenuURL = "#" });
            ObjSubMenu.Add(new SubMenu { MainMenuID = 5, SubMenuItem = "Transaction Reversal", SubMenuURL = "#" });
            ObjSubMenu.Add(new SubMenu { MainMenuID = 5, SubMenuItem = "System Billings", SubMenuURL = "#" });

            ObjSubMenu.Add(new SubMenu { MainMenuID = 6, SubMenuItem = "Non-member payments", SubMenuURL = "#" });
            ObjSubMenu.Add(new SubMenu { MainMenuID = 6, SubMenuItem = "Dividend Processing", SubMenuURL = "#" });
            ObjSubMenu.Add(new SubMenu { MainMenuID = 6, SubMenuItem = "Salary Posting Managemnt", SubMenuURL = "#" });
            ObjSubMenu.Add(new SubMenu { MainMenuID = 6, SubMenuItem = "Pay Members", SubMenuURL = "#" });
            ObjSubMenu.Add(new SubMenu { MainMenuID = 6, SubMenuItem = "Transaction Reversal", SubMenuURL = "#" });
            ObjSubMenu.Add(new SubMenu { MainMenuID = 6, SubMenuItem = "System Billings", SubMenuURL = "#" });

            return ObjSubMenu;
        }
    }
}
