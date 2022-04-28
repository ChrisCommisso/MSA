using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
namespace Assets.Scripts
{
    abstract class BulletWeapon : Weapon
    {
        int shotDamage;
        public float range;
        public float recoilReset;
        public float timeSinceLastShot;
        public int trajectoryIndex;
        public Vector3[] Trajectories;
        public virtual void ResetTrajectoryIndex() {
            if (timeSinceLastShot > recoilReset && trajectoryIndex > 0) {
                trajectoryIndex = 0;
            }
        }
        public virtual Vector3 shotTrajectory() {
            Vector3 ShotTraj = Trajectories[trajectoryIndex];
            trajectoryIndex++;
            return ShotTraj;
        }
        public void Start() { 
        
        }
        public void Update() {
            timeSinceLastShot += Time.deltaTime;

            ResetTrajectoryIndex();
        }
        public override IEnumerator shoot(Vector3 lookdir, Transform head)
        {
            timeSinceLastShot = 0;
            RaycastHit info;
            if (Physics.Raycast(head.transform.position, lookdir, out info)) 
            {
                if (range == 0 || (info.point - head.transform.position).sqrMagnitude <= range * range)
                {
                    Health targetHealth = info.transform.gameObject.GetComponent<Health>();
                    if (targetHealth != null)
                    {
                        targetHealth.DoDamage(shotDamage);
                    }
                }
            }
            return null;
        }
    }
}
