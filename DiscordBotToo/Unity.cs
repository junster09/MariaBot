using DiscordBotToo.Storage;
using DiscordBotToo.Storage.Implementations;
using System;
using System.Collections.Generic;
using System.Text;
using Unity;
using Unity.Resolution;

namespace DiscordBotToo
{
    public static class Unity
    {
        private static UnityContainer _container;

        public static UnityContainer Container {
            get {
                if (_container == null) {
                    RegisterTypes();
                }
                return _container;

            }

        }

        public static void RegisterTypes() {

            _container = new UnityContainer();
            _container.RegisterType<IDataStorage, InMemoryStorage>();
        }


        internal static T Resolve<T>() {
            return _container.Resolve<T>();
        }
        
        //^ Unity apperently has its own resolution, this doesn't seem to work anymore https://unitycontainer.github.io/api/Unity.Resolution.IResolve.html
    }
}
