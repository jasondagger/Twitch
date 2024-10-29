
namespace Twitch.Core.Services;

using System;
using System.Collections.Generic;
using System.Runtime.Versioning;
using System.Threading.Tasks;
using Twitch.Core.Services.Databases;
using Twitch.Core.Services.Godots;
using Twitch.Core.Services.Spotifies;
using Twitch.Core.Services.Twitches;
using Twitch.Core.Services.WebCams;

internal static class Services
{
    static Services()
    {

    }

    internal static TService GetService<TService>()
        where TService :
            class,
            IService
    {
        return _ = Services.c_serviceTypes[key: _ = typeof(TService)] as TService;
    }

    internal static async Task Start()
    {
        var tasksSetup = _ = new List<Task>();
        foreach (var serviceTypes in _ = Services.c_serviceTypes)
        {
            var service = _ = serviceTypes.Value;
            tasksSetup.Add(
                item: _ = service.Setup()
            );
        }
        await Task.WhenAll(
            tasks: _ = tasksSetup
        );

        var tasksStart = _ = new List<Task>();
        foreach (var serviceTypes in _ = Services.c_serviceTypes)
        {
            var service = _ = serviceTypes.Value;
            tasksStart.Add(
                item: _ = service.Start()
            );
        }
        await Task.WhenAll(
            tasks: _ = tasksStart
        );
    }

    internal static async Task Stop()
    {
        var tasksStop = _ = new List<Task>();
        foreach (var serviceTypes in _ = Services.c_serviceTypes)
        {
            var service = _ = serviceTypes.Value;
            tasksStop.Add(
                item: _ = service.Stop()
            );
        }
        await Task.WhenAll(
            tasks: _ = tasksStop
        );
    }

    private static readonly Dictionary<Type, IService> c_serviceTypes = new()
    {
		{ _ = typeof(ServiceDatabase), _ = new ServiceDatabase() },
        { _ = typeof(ServiceGodots),   _ = new ServiceGodots()   },
        { _ = typeof(ServiceSpotify),  _ = new ServiceSpotify()  },
        { _ = typeof(ServiceTwitch),   _ = new ServiceTwitch()   },
        { _ = typeof(ServiceWebCam),   _ = new ServiceWebCam()   },
	};
}