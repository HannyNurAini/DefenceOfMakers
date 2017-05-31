using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoM
{
    class Level
    {
        private Invader[] _invaders;
        public Tower[] Tower { get; set; }

        public Level (Invader[] invaders)
        {
            _invaders = invaders;
        }

        public bool Play()
        {
            //looping sampai smw invader mati atau invader menang
            int remainingInvaders = _invaders.Length; //brp invader yg masih ada di array

            while (remainingInvaders > 0)
            {
                //tower cek jarak dgn invader
                foreach (Tower tower in Tower)
                {
                    tower.FireOnInvaders(_invaders);
                }

                //kalo masih ada invader invader maju
                remainingInvaders = 0;
                foreach(Invader invader in _invaders)
                {
                    if (invader.IsActive)
                    {
                        invader.Move();

                        if (invader.HasScored)
                        {
                            return false;
                        }
                        remainingInvaders++;
                    }
                }
            }

            return true;
        }
    }
}
