﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Abstract
{
    public abstract class BasePlayerManager : IPlayerService
    {
        public virtual void Add(Player player)
        {
            Console.WriteLine("Saved to db: " + player.FirstName);
            Console.WriteLine("\n");
        }

        public virtual void Delete(Player player)
        {
            throw new NotImplementedException();
        }

        public virtual void Update(Player player)
        {
            throw new NotImplementedException();
        }
    }
}
