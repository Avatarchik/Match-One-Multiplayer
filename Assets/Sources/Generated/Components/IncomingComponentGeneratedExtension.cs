namespace Entitas {
    public partial class Entity {
        static readonly IncomingComponent incomingComponent = new IncomingComponent();

        public bool isIncoming {
            get { return HasComponent(ComponentIds.Incoming); }
            set {
                if (value != isIncoming) {
                    if (value) {
                        AddComponent(ComponentIds.Incoming, incomingComponent);
                    } else {
                        RemoveComponent(ComponentIds.Incoming);
                    }
                }
            }
        }

        public Entity IsIncoming(bool value) {
            isIncoming = value;
            return this;
        }
    }

    public partial class Matcher {
        static AllOfMatcher _matcherIncoming;

        public static AllOfMatcher Incoming {
            get {
                if (_matcherIncoming == null) {
                    _matcherIncoming = new Matcher(ComponentIds.Incoming);
                }

                return _matcherIncoming;
            }
        }
    }
}
