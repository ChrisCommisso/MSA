using Q3Movement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
namespace Assets.Scripts
{
    public class Explosive:MonoBehaviour
    {
        public float size;
        public int damage;
        public float Range;
        public float power;
        private RaycastHit hit;
        public static event EventHandler<ExplosionEventArgs> onExplosion;
        private void Update()
        {
            if (Physics.SphereCast(transform.position, size, transform.forward, out hit,0)) {
                onExplosion(this, new ExplosionEventArgs(hit.point, this));
            }
        }
    }

}
