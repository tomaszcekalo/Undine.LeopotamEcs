using Leopotam.Ecs;
using Undine.Core;

namespace Undine.LeopotamEcs
{
    public class LeopotamEcsContainer : EcsContainer
    {
        private readonly EcsWorld _ecsWorld;
        private readonly EcsSystems _systems;

        private readonly EcsSystems _systems2;

        public LeopotamEcsContainer()
        {
            _ecsWorld = new EcsWorld();
            _systems = new EcsSystems(_ecsWorld);
            _systems2 = new EcsSystems(_ecsWorld);
        }

        public override void AddSystem<T>(UnifiedSystem<T> system)
        {
            this.RegisterComponentType<T>();
            _systems.Add(new LeopotamSystem<T>()
            {
                System = system
            });
        }

        public override void AddSystem<A, B>(UnifiedSystem<A, B> system)
        {
            this.RegisterComponentType<A>();
            this.RegisterComponentType<B>();
            _systems.Add(new LeopotamSystem<A, B>()
            {
                System = system
            });
        }

        public override void AddSystem<A, B, C>(UnifiedSystem<A, B, C> system)
        {
            this.RegisterComponentType<A>();
            this.RegisterComponentType<B>();
            this.RegisterComponentType<C>();
            _systems.Add(new LeopotamSystem<A, B, C>()
            {
                System = system
            });
        }

        public override void AddSystem<A, B, C, D>(UnifiedSystem<A, B, C, D> system)
        {
            this.RegisterComponentType<A>();
            this.RegisterComponentType<B>();
            this.RegisterComponentType<C>();
            this.RegisterComponentType<D>();
            _systems.Add(new LeopotamSystem<A, B, C, D>()
            {
                System = system
            });
        }

        public override IUnifiedEntity CreateNewEntity()
        {
            return new LeopotamEntity(_ecsWorld.NewEntity());
        }

        public override ISystem GetSystem<A>(UnifiedSystem<A> system)
        {
            this.RegisterComponentType<A>();
            var result = new LeopotamSystem<A>()
            {
                System = system
            };
            _systems2.Add(result);
            return result;
        }

        public override ISystem GetSystem<A, B>(UnifiedSystem<A, B> system)
        {
            this.RegisterComponentType<A>();
            this.RegisterComponentType<B>();
            var result = new LeopotamSystem<A, B>()
            {
                System = system
            };
            _systems2.Add(result);
            return result;
        }

        public override ISystem GetSystem<A, B, C>(UnifiedSystem<A, B, C> system)
        {
            this.RegisterComponentType<A>();
            this.RegisterComponentType<B>();
            this.RegisterComponentType<C>();
            var result = new LeopotamSystem<A, B, C>()
            {
                System = system
            };
            _systems2.Add(result);
            return result;
        }

        public override ISystem GetSystem<A, B, C, D>(UnifiedSystem<A, B, C, D> system)
        {
            this.RegisterComponentType<A>();
            this.RegisterComponentType<B>();
            this.RegisterComponentType<C>();
            this.RegisterComponentType<D>();
            var result = new LeopotamSystem<A, B, C, D>()
            {
                System = system
            };
            _systems2.Add(result);
            return result;
        }

        public override void Init()
        {
            _systems.Init();
            _systems2.Init();
        }

        public override void Run()
        {
            _systems.Run();
        }
    }
}