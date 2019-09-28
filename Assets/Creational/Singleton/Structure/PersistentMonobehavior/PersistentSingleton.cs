using UnityEngine;

namespace Patterns
{
    /// <summary>
    ///     Auto create Singleton Version:
    ///     Ref: https://answers.unity.com/questions/576969/create-a-persistent-gameobject-using-singleton.html
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class PersistentSingleton<T> : MonoBehaviour where T : Component
    {
        static T instance;

        /// <summary>
        ///     Static instance of Persistent which allows it to be accessed by any other script.
        /// </summary>
        public static T Instance
        {
            get
            {
                if (instance == null)
                    CreateInstance();
                else
                    HandleDuplication();

                return instance;
            }
        }

        static void CreateInstance()
        {
            var go = new GameObject(typeof(T).ToString());
            instance = go.AddComponent<T>();
        }

        static void HandleDuplication()
        {
            //Then destroy this. This enforces our singleton pattern, meaning there can only ever be one instance.
            var copies = FindObjectsOfType(typeof(T));
            foreach (var copy in copies)
                if (copy != instance)
                    Destroy(copy);
        }
    }
}