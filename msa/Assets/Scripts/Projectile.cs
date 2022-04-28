using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts
{
    public class Projectile:MonoBehaviour
    {
        public virtual IEnumerator OnExecutePath(Vector3 lookdir) {
            
            return null;
        }
    }
}
