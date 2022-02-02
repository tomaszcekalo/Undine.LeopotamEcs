using Leopotam.Ecs;
using Undine.Core;

namespace Undine.LeopotamEcs
{
    public class LeopotamEntity : IUnifiedEntity
    {
        private EcsEntity _entity;
        public LeopotamEntity(EcsEntity entity)
        {
            _entity = entity;
        }
        public void AddComponent<A>(in A component)
            where A : struct
        {
            _entity.Replace(component);
        }

        public ref A GetComponent<A>()
            where A : struct
        {
            return ref _entity.Get<A>();
        }
    }
}