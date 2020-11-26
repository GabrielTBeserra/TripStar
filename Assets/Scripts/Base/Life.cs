using UnityEngine;

namespace Assets.Scripts.Base
{
    public class Life
    {
        [SerializeField]
        public int life { get; set; }

        public Life(int life)
        {
            this.life = life;
        }


        public void RemoveLife()
        {
            if (life > 0)
            {
                life--;
            }
        }

        public void AddLife()
        {
            life++;
        }
    }
}
