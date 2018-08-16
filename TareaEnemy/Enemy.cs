using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaEnemigo
{
    class Enemy
    {
        public int PosicionX;
        public int PosicionY;


        private int _habbocreditos;
        public int Robux
        {
            get
            {
                return _habbocreditos;
            }
            set
            {
                if (_habbocreditos < 100)
                {
                    _habbocreditos = 100;
                }
            }
        }


        public void Mover()
        {

        }

        public void Disparar()
        {

        }

        public void Morir()
        {

        }
    }
}
