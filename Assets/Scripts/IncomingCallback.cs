using DaoNet;

public class IncomingCallback : ZoneBehaviour {
    private string[] incPos;

    public override void OnConnectionLost() {
    }

    public override void OnEnterZone() {
    }

    public override void OnLeaveZone() {
    }

    public override void OnMessage(string message) {
        incPos = message.Split(':');
        Pools.pool.CreateEntity().IsIncoming(true).AddInput(int.Parse(incPos[0]), int.Parse(incPos[1]));
    }

    public override void OnReconnect() {
    }
}