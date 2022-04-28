using Assets.Scripts;
using UnityEngine;

namespace Q3Movement
{
    public class ExplosionEventArgs
    {
        public ExplosionEventArgs(Vector3 p, Explosive e) {
            location = p;
            explosive = e;
        }
        public Vector3 location;
        public Explosive explosive;
    }
}