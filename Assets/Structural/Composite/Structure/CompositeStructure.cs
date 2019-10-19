using System.Collections.Generic;
using UnityEngine;

namespace Composite
{
    public class CompositeStructure : MonoBehaviour
    {
        /// <summary>
        ///     The Component interface describes operations that are common to both simple and complex elements of the tree.
        /// </summary>
        public interface IComponent
        {
            void Operate();
        }

        /// <summary>
        ///     The Component is an element that has sub-elements: leaves or other sub-components.
        /// </summary>
        public class Component : IComponent
        {
            readonly List<IComponent> _components = new List<IComponent>();

            /// <summary>
            ///     Propagate the operation over the sub components.
            /// </summary>
            public void Operate()
            {
                foreach (var c in _components)
                    c.Operate();
            }

            public void AddComponent(IComponent c) => _components.Add(c);
            public void RemoveComponent(IComponent c) => _components.Remove(c);
            public IComponent GetComponent(int index) => _components[index];
        }

        /// <summary>
        ///     Subcomponents are basic elements of a tree that doesn’t have sub-elements. Also called leaf
        ///     They end up doing most of the real work, since they don’t have anyone to delegate the work to.
        /// </summary>
        public class SubComponent : IComponent
        {
            public void Operate()
            {
                //Do some work.
            }
        }
    }
}