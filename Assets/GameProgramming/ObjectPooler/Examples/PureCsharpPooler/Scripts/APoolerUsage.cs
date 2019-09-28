using System.Collections.Generic;
using UnityEngine;

namespace Pooler
{
    public class APoolerUsage : MonoBehaviour
    {
        const int Count = 10;
        readonly List<APooledObject> objects = new List<APooledObject>();
        readonly APoolerObject pool = new APoolerObject(Count);

        [Button]
        void Get()
        {
            var obj = pool.Get();
            objects.Add(obj);
            Debug.Log("[" + objects.Count + "]:" + obj.GetType() + " Created ");
        }

        [Button]
        void ReleaseRandom()
        {
            if (objects.Count < 1)
                return;

            var index = Random.Range(0, objects.Count);
            var obj = objects[index];
            pool.Release(obj);
            objects.Remove(obj);
            Debug.Log("[" + index + "]:" + obj.GetType() + " Released ");
        }
    }
}