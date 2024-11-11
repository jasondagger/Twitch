
namespace Twitch.Core.Services.StreamStates;

using Godot;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

internal sealed class ServiceStreamStates() :
	ServiceNode()
{
	public override async Task Start()
    {
        await base.Start();

		this.PreloadSceneStreamStateTransition();
		this.LoadSceneStreamStateStart();
    }

    public override async Task Stop()
    {
        var tasksStreamStatesToUnload = _ = new List<Task>();
        tasksStreamStatesToUnload.Add(
            item: _ = Task.Run(
                () =>
                {
                    this.m_serviceStreamStateTransition.Unload();
                }
            )
        );

        foreach (var serviceStreamStateType in _ = this.m_serviceStreamStateTypes)
        {
            var serviceStreamState = _ = serviceStreamStateType.Value;
            tasksStreamStatesToUnload.Add(
                item: _ = Task.Run(
                    () =>
                    {
                        serviceStreamState.Unload();
					}
                )
            );
        }

        await Task.WhenAll(
            tasks: _ = tasksStreamStatesToUnload
        );
    }

	internal override void ParentNodeToRoot(
    	Node node
    )
	{
		this.Node.AddChild(
			node: _ = node
		);
	}

	internal void SwitchTo<TServiceStreamState>()
        where TServiceStreamState :
            class,
            IServiceStreamState
    {
        var currentType = _ = this.m_serviceStreamStateCurrent.GetType();
        var newType     = _ = typeof(TServiceStreamState);
		if (
            _ = newType.Equals(
                o: _ = currentType
            ) is true
        )
        {
            return;
        }

        this.m_serviceStreamStateTransition.Show();

		var serviceStreamState = _ = this.m_serviceStreamStateCurrent;
        if (serviceStreamState is not null)
        {
            _ = Task.Run(
                action:
                () =>
                {
                    serviceStreamState.Unload();
                }
            );
        }

        _ = this.m_serviceStreamStateCurrent = _ = this.m_serviceStreamStateTypes[
            key: _ = typeof(TServiceStreamState)
        ];
        _ = Task.Run(
            action:
            () =>
            {
                this.m_serviceStreamStateCurrent.Load();
                this.m_serviceStreamStateTransition.Hide();
            }
        );
    }

    private readonly Dictionary<Type, IServiceStreamState> m_serviceStreamStateTypes      = new()
    {
        {
            _ = typeof(ServiceStreamStateBeRightBack),
            _ = new ServiceStreamStateBeRightBack()
        },
        {
            _ = typeof(ServiceStreamStateEnd),
            _ = new ServiceStreamStateEnd()
        },
        {
            _ = typeof(ServiceStreamStateLive),
            _ = new ServiceStreamStateLive()
        },
        {
            _ = typeof(ServiceStreamStateStart),
            _ = new ServiceStreamStateStart() 
        },
	};
    private readonly ServiceStreamStateTransition          m_serviceStreamStateTransition = new();
    private IServiceStreamState                            m_serviceStreamStateCurrent    = null;

	private void LoadSceneStreamStateStart()
	{
		this.m_serviceStreamStateCurrent = _ = this.m_serviceStreamStateTypes[
            key: _ = typeof(ServiceStreamStateLive)
        ];
		this.m_serviceStreamStateCurrent.Load();
	}

	private void PreloadSceneStreamStateTransition()
    {
		this.m_serviceStreamStateTransition.Load();
        this.m_serviceStreamStateTransition.Hide();
	}
}