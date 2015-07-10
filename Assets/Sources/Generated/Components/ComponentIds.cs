public static class ComponentIds {
    public const int Destroy = 0;
    public const int GameBoardCache = 1;
    public const int GameBoard = 2;
    public const int GameBoardElement = 3;
    public const int Incoming = 4;
    public const int Input = 5;
    public const int Interactive = 6;
    public const int Movable = 7;
    public const int Position = 8;
    public const int Resource = 9;
    public const int Score = 10;
    public const int Sendable = 11;
    public const int View = 12;

    public const int TotalComponents = 13;

    static readonly string[] components = {
        "Destroy",
        "GameBoardCache",
        "GameBoard",
        "GameBoardElement",
        "Incoming",
        "Input",
        "Interactive",
        "Movable",
        "Position",
        "Resource",
        "Score",
        "Sendable",
        "View"
    };

    public static string IdToString(int componentId) {
        return components[componentId];
    }
}

namespace Entitas {
    public partial class Matcher : AllOfMatcher {
        public Matcher(int index) : base(new [] { index }) {
        }

        public override string ToString() {
            return ComponentIds.IdToString(indices[0]);
        }
    }
}