using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine.UI;
using UnityEngine;

namespace Assets.Scripts
{
    public class Weapon:MonoBehaviour
    {
        public int m_ammoCount;
        public int m_magSize;
        public int m_currAmmo;
        public string Name { get; set; }
        Dictionary<string, AnimationFrame> animations2D;
        int m_animationIndex;
        Dictionary<string, Animation> animations3D;
        public virtual IEnumerator shoot(Vector3 lookdir,Transform head) {
            yield return null;
        }
    }
}
