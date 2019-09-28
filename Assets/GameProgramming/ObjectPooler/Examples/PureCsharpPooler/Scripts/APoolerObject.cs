using Patterns;

namespace Pooler
{
    public class APoolerObject : GenericPooler<APooledObject>
    {
        public APoolerObject(int startingSize) : base(startingSize)
        {
        }
    }
}