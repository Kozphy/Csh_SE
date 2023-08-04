using DI_Container.Interface;

namespace DI_Container.SampleDI
{
    public class SampleService
    {
        private readonly ITransient _transient;
        private readonly IScoped _scoped;
        private readonly ISingleton _singleton;

        public SampleService(ITransient transient, IScoped scoped, ISingleton singleton)
        { 
            _transient = transient;
            _scoped = scoped;
            _singleton = singleton;
        }

        public string GetSampleHashCode()
        {
            return $"Transient: {_transient.GetHashCode()}, "
                + $"Scoped: {_scoped.GetHashCode()}, "
                + $"Singleton: {_singleton.GetHashCode()}";
        }
    }
}
