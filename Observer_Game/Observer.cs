using System;
using System.Collections.Generic;
namespace Observer_Game
{
    public interface IObserver
    {
        void Update(string action, string site);
    }
}
