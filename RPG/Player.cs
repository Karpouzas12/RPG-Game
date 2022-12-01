using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
  class Player
  {
    int Strength, Dexterity, Constitution, Intelligence, Wisdom, Charisma;

    public Player()
    {

    }

    public Player(int _str,int _dex,int _con,int _int, int _wis, int _cha)
    {
      Strength = _str;
      Dexterity = _dex;
      Constitution = _con;
      Intelligence = _int;
      Wisdom = _wis;
      Charisma = _cha;
    }
  }
}
