using PietDotNet.Diagnostics;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace PietDotNet
{
    [DebuggerDisplay("{DebuggerDisplay}"), DebuggerTypeProxy(typeof(CollectionDebugView))]
    public class ColourBlock : IEnumerable<Codel>
    {
        public static readonly ColourBlock Border = new Border();

        private readonly ISet<Codel> _codels;
        private readonly Dictionary<Direction, Codel> _edges = new Dictionary<Direction, Codel>(8);

        protected ColourBlock() { }

        public ColourBlock(Colour colour, IEnumerable<Codel> codels)
        {
            Colour = Guard.NotNull(colour, nameof(colour));
            _codels = new HashSet<Codel>(Guard.HasAny(codels, nameof(codels)));

            InitEdges();
        }

        private void InitEdges()
        {
            var xMin = _codels.Min(p => p.X);
            var xMax = _codels.Max(p => p.X);
            var yMin = _codels.Min(p => p.Y);
            var yMax = _codels.Max(p => p.Y);

            _edges[new Direction(DirectionPointer.left, /*  */ CodelChooser.left)] = _codels.Where(p => p.X == xMin).OrderByDescending(p => p.Y).FirstOrDefault();
            _edges[new Direction(DirectionPointer.left, /* */ CodelChooser.right)] = _codels.Where(p => p.X == xMin).OrderBy(p => p.Y).FirstOrDefault();
            _edges[new Direction(DirectionPointer.right, /* */ CodelChooser.left)] = _codels.Where(p => p.X == xMax).OrderBy(p => p.Y).FirstOrDefault();
            _edges[new Direction(DirectionPointer.right, /**/ CodelChooser.right)] = _codels.Where(p => p.X == xMax).OrderByDescending(p => p.Y).FirstOrDefault();

            _edges[new Direction(DirectionPointer.top, /*   */ CodelChooser.left)] = _codels.Where(p => p.Y == yMin).OrderBy(p => p.X).FirstOrDefault();
            _edges[new Direction(DirectionPointer.top, /*  */ CodelChooser.right)] = _codels.Where(p => p.Y == yMin).OrderByDescending(p => p.X).FirstOrDefault();
            _edges[new Direction(DirectionPointer.down, /*  */ CodelChooser.left)] = _codels.Where(p => p.Y == yMax).OrderByDescending(p => p.X).FirstOrDefault();
            _edges[new Direction(DirectionPointer.down, /* */ CodelChooser.right)] = _codels.Where(p => p.Y == yMax).OrderBy(p => p.X).FirstOrDefault();
        }

        public bool HasColour => Colour.NotBlackOrWhite;
        public bool IsBlack => Colour.IsBlack;
        public bool IsWhite => Colour.IsWhite;

        public virtual Colour Colour { get; }

        public int Value => _codels.Count;

        public bool Contains(Codel codel) => _codels.Contains(codel);

        public Pointer Leave(Pointer pointer)
        {
            var position = GetEdge(pointer).Next(pointer.DP);
            return pointer.Move(position);
        }

        public Codel GetEdge(Direction direction) => _edges[direction];

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string DebuggerDisplay => $"{Colour.Name}, Value: {Value}";

        #region IEnumerable
        public IEnumerator<Codel> GetEnumerator() => _codels.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

        #endregion
    }
}
