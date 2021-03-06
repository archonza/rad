﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Jumper1.Models;
using Jumper1.Views.Renderers;
using Microsoft.Xna.Framework;

namespace Jumper1.Controllers.States
{
   public class InitialState : State
   {
      public InitialState(State nextState)
          : base(nextState) { }

      public override void Execute(GameTime gameTime)
      {
         MainMenu.InitialiseMainMenu();
      }

      public override void Draw(GameTime gameTime, MonoGameRenderer renderer)
      {
         throw new NotImplementedException();
      }
   }
}
