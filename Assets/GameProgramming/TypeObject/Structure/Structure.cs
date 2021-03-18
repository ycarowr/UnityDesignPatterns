using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace TypeObject
{
    /// <summary>
    ///     The typed object that contains a reference that represents the type itself.
    /// </summary>
    public class TypedObject
    {
        private readonly TypeObject _type;

        public TypedObject(TypeObject type)
        {
            _type = type;
        }
    }

    /// <summary>
    ///     The Type of the <see cref="TypedObject"/>>.
    /// </summary>
    public class TypeObject
    {
        public readonly TypeObject Parent;

        public TypeObject(TypeObject parent)
        {
            Parent = parent;
        }
    }


    public class Structure
    {
        public Structure()
        {
            var type = new TypeObject(null);
            
            var typedObject = new TypedObject(type);
        }
    }
}