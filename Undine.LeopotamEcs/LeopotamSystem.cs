using Leopotam.Ecs;
using Undine.Core;

namespace Undine.LeopotamEcs
{
    public class LeopotamSystem<T> : IEcsRunSystem, ISystem
        where T : struct
    {
        private EcsFilter<T> _filter = null;
        public UnifiedSystem<T> System { get; set; }

        public void ProcessAll()
        {
            Run();
        }

        public void Run()
        {
            System.PreProcess();
            foreach (var i in _filter)
            {
                ref var t = ref _filter.Get1(i);

                System.ProcessSingleEntity(i, ref t);
            }
            System.PostProcess();
        }
    }

    public class LeopotamSystem<A, B> : IEcsRunSystem, ISystem
        where A : struct
        where B : struct
    {
        private EcsFilter<A, B> _filter = null;
        public UnifiedSystem<A, B> System { get; set; }
        public void Run()
        {
            System.PreProcess();
            foreach (var i in _filter)
            {
                ref var a = ref _filter.Get1(i);
                ref var b = ref _filter.Get2(i);

                System.ProcessSingleEntity(i, ref a, ref b);
            }
            System.PostProcess();
        }
        public void ProcessAll()
        {
            Run();
        }
    }

    public class LeopotamSystem<A, B, C, D> : IEcsRunSystem, ISystem
        where A : struct
        where B : struct
        where C : struct
        where D : struct
    {
        private EcsFilter<A, B, C, D> _filter = null;
        public UnifiedSystem<A, B, C, D> System { get; set; }
        public void Run()
        {
            System.PreProcess();
            foreach (var i in _filter)
            {
                ref var a = ref _filter.Get1(i);
                ref var b = ref _filter.Get2(i);
                ref var c = ref _filter.Get3(i);
                ref var d = ref _filter.Get4(i);

                System.ProcessSingleEntity(i, ref a, ref b, ref c, ref d);
            }
            System.PostProcess();
        }
        public void ProcessAll()
        {
            Run();
        }
    }

    public class LeopotamSystem<A, B, C> : IEcsRunSystem, ISystem
        where A : struct
        where B : struct
        where C : struct
    {
        private EcsFilter<A, B, C> _filter = null;
        public UnifiedSystem<A, B, C> System { get; set; }
        public void Run()
        {
            System.PreProcess();
            foreach (var i in _filter)
            {
                ref var a = ref _filter.Get1(i);
                ref var b = ref _filter.Get2(i);
                ref var c = ref _filter.Get3(i);

                System.ProcessSingleEntity(i, ref a, ref b, ref c);
            }
            System.PostProcess();
        }
        public void ProcessAll()
        {
            Run();
        }
    }
}