namespace Entitas {
    public partial class Entity {
        static readonly SendableComponent sendableComponent = new SendableComponent();

        public bool isSendable {
            get { return HasComponent(ComponentIds.Sendable); }
            set {
                if (value != isSendable) {
                    if (value) {
                        AddComponent(ComponentIds.Sendable, sendableComponent);
                    } else {
                        RemoveComponent(ComponentIds.Sendable);
                    }
                }
            }
        }

        public Entity IsSendable(bool value) {
            isSendable = value;
            return this;
        }
    }

    public partial class Matcher {
        static AllOfMatcher _matcherSendable;

        public static AllOfMatcher Sendable {
            get {
                if (_matcherSendable == null) {
                    _matcherSendable = new Matcher(ComponentIds.Sendable);
                }

                return _matcherSendable;
            }
        }
    }
}
