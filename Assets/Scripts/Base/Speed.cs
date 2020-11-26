using UnityEngine;

namespace Assets.Scripts.Base
{
    public class Speed
    {
        [SerializeField]
        public float speed { get; set; }
        [SerializeField]
        public float rotateSpeed { get; set; }


        public Speed()
        {
            this.speed = 5;
            this.rotateSpeed = 5;
        }

        public Speed(float speed, float rotateSpeed)
        {
            this.speed = speed;
            this.rotateSpeed = rotateSpeed;
        }

    }
}
