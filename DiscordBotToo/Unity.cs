using DiscordBotToo.Storage;
using DiscordBotToo.Storage.Implementations;
using System;
using System.Collections.Generic;
using System.Text;
using Unity;
using Unity.Injection;
using Unity.Resolution;
using Unity.Lifetime;
using Discord.WebSocket;
using DiscordBotToo.Discord;

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

            _container.RegisterSingleton<IDataStorage, JsonStorage>();
            _container.RegisterSingleton<ILogger, Logger>();
            _container.RegisterType<DiscordSocketConfig>(new InjectionFactory(i => DiscordStealer.GetDefault()));
            //_container.RegisterType<DiscordSocketConfig>(IUnityContainer.RegisterFactory(i => DiscordStealer.GetDefault()));
            _container.RegisterSingleton<DiscordSocketClient>(new InjectionConstructor(typeof(DiscordSocketConfig)));
            _container.RegisterSingleton<Discord.Connection>();

        }


        internal static T Resolve<T>() {
            return _container.Resolve<T>();
        }
        //^ Unity apperently has its own resolution, this doesn't seem to work anymore https://unitycontainer.github.io/api/Unity.Resolution.IResolve.html
    }
}
