using Action.Comman.Core.Events;
using System.Threading.Tasks;

namespace Action.Comman.Core.Bus
{
    public interface IEventHandler<in TEvent> : IEventHandler
                                                where TEvent : Event
    {
        Task Handler(TEvent @event);
    }

    public interface IEventHandler { }
}
