using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts
{
    public class ProjectileWeapon:Weapon
    {
        GameObject Projectile;
        public override IEnumerator shoot(Vector3 lookDir,Transform head)
        {
            GameObject activeProjectile = Instantiate(Projectile,head);
            Projectile proj = activeProjectile.GetComponent<Projectile>();
            StartCoroutine(proj.OnExecutePath(lookDir));
            yield return null;
        }
    }
}
