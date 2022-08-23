namespace PatternsLearning.ServiceLocator.ServiceLocator
{
    public class ServiceLocator : IServiceLocator
    {
        private readonly Dictionary<Type, List<object>> services = new();

        public void Register<TService>(TService service)
        {
            var key = typeof(TService);
            if (!services.ContainsKey(key))
                services.Add(key, new List<object>());
            services[key].Add(service);
        }

        public TService GetService<TService>()
        {
            if (services.ContainsKey(typeof(TService)))
                return (TService)services[typeof(TService)].Single();
            else
                throw new InvalidOperationException(
                    "Can't resolve service " + typeof(TService));
        }

        public TService GetService<TServiceKey, TService>()
        {
            if (services.ContainsKey(typeof(TServiceKey)))
            {
                var servicesFromContainer = services[typeof(TServiceKey)];

                var servicesFromContainerType = servicesFromContainer[0].GetType();

                var tmp = typeof(TService);

                var service = (TService)servicesFromContainer
                    .First(s => s.GetType() == typeof(TService));

                return service;
            }
            else
                throw new InvalidOperationException(
                    "Can't resolve service " + typeof(TService));
        }
    }
}
