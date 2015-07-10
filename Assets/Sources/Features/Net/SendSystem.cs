using DaoNet;
using Entitas;

public class SendSystem : IReactiveSystem {

    public IMatcher GetTriggeringMatcher() {
        return Matcher.AllOf(Matcher.Sendable, Matcher.Destroy);
    }

    public GroupEventType GetEventType() {
        return GroupEventType.OnEntityAdded;
    }

    public void Execute(Entity[] entities) {
        UnityEngine.Debug.Log("Send System triggered");

        foreach (Entity e in entities) {
            if (e.hasPosition) {
                DaoAccess.Instance().Send(string.Format("{0}:{1}", e.position.x, e.position.y), "game");
            }
        }
    }
}