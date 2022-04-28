using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts
{
    public class StandardProjectile:Projectile
    {
        private bool moving;
        public float speed;
        private void OnDestroy()
        {
            moving = false;
        }
        public override IEnumerator OnExecutePath(Vector3 lookdir)
        {
            while (moving)
            {
                transform.forward = lookdir.normalized;
                transform.position += transform.forward*speed;
                yield return new WaitForFixedUpdate();
            }
        }
    }
}
