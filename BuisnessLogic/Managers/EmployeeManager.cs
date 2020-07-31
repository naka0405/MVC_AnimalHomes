using DataAccess.Models;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin;
using DataAccess;

namespace BuisnessLogic.Managers
{
    public class EmployeeManager:UserManager<Employee>
    {
        public EmployeeManager(IUserStore<Employee> store) : base(store){ }
            public static EmployeeManager Create(IdentityFactoryOptions<EmployeeManager> options, IOwinContext context)
            {
                AnimalHomesContext db = context.Get<AnimalHomesContext>();
                EmployeeManager manager = new EmployeeManager(new UserStore<Employee>(db));

                return manager;
            }        
    }
}
