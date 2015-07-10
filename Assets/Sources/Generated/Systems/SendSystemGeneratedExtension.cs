namespace Entitas {
    public partial class Pool {
        public ISystem CreateSendSystem() {
            return this.CreateSystem<SendSystem>();
        }
    }
}