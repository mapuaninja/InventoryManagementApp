﻿
using InventoryManagement.Repository;
using InventoryManagement.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement.Model
{
    public class UserModel : BaseModel
    {
        UserRepository ur;
        public UserModel()
        {
            ur = new UserRepository();
        }
        public enum UserType
        {
            Admin = 1,
            Custodian,
            User
        }
        public UserViewModel CurrentUser { get;private set; }

        public UserViewModel AuthenticateUser(string username, string password)
        {
            
            CurrentUser = ur.ValidateUsernameAndPassword(username, password);
            return CurrentUser;
        }
        public bool LogoutUser()
        {
            CurrentUser = null;
            return true;
        }
        public int CreateNewUser(string username, string password, UserType userType)
        {
          
            return ur.CreateNewUser(username, password, (int)userType);
        }
        public void CheckDefaultUser()
        {
            var adminUser = ur.GetUser("admin");
            if(adminUser == null)
            {
                ur.CreateNewUser("admin", "admin", 1);
            }
        }
        public List<UserViewModel> GetUsers()
        {
            return ur.GetUsers();
        }
        public List<UserViewModel> GetUsersByDepartmentId(int departmentId)
        {
            return ur.GetUsersByDepartmentId(departmentId);
        }
    }
}
