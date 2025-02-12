﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Gestor_de_contraseñas.Identity
{
    public class MyIdentityDBContext : IdentityDbContext <MyUser, MyRole, String>
    {

        public MyIdentityDBContext(DbContextOptions<MyIdentityDBContext> options) : base(options) 
        {

        }


    }
}
