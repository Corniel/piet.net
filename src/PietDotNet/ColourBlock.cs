using PietDotNet.Diagnostics;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;

namespace PietDotNet
{
    [DebuggerDisplay("{DebuggerDisplay}"), DebuggerTypeProxy(typeof(CollectionDebugView))]
    public class ColourBlock : IEnumerable<Point>
    {
        public static readonly ColourBlock Border = new Border();

        private readonly ISet<Point> _codels;
        private readonly Dictionary<Edge, Point> _edges = new Dictionary<Edge, Point>(8);

        protected ColourBlock() { }

        public ColourBlock(Codel codel, IEnumerable<Point> codels)
        {
            Codel = Guard.NotNull(codel, nameof(codel));
            _codels = new HashSet<Point>(Guard.HasAny(codels, nameof(codels)));

            InitEdges();
        }

        private void InitEdges()
        {
            var xMin = _codels.Min(p => p.X);
            var xMax = _codels.Max(p => p.X);
            var yMin = _codels.Min(p => p.Y);
            var yMax = _codels.Max(p => p.Y);

            _edges[new Edge(DirectionPointer.left, /*  */ CodelChooser.left)] = _codels.Where(p => p.X == xMin).OrderByDescending(p => p.Y).FirstOrDefault();
            _edges[new Edge(DirectionPointer.left, /* */ CodelChooser.right)] = _codels.Where(p => p.X == xMin).OrderBy(p => p.Y).FirstOrDefault();
            _edges[new Edge(DirectionPointer.right, /* */ CodelChooser.left)] = _codels.Where(p => p.X == xMax).OrderBy(p => p.Y).FirstOrDefault();
            _edges[new Edge(DirectionPointer.right, /**/ CodelChooser.right)] = _codels.Where(p => p.X == xMax).OrderByDescending(p => p.Y).FirstOrDefault();

            _edges[new Edge(DirectionPointer.top, /*   */ CodelChooser.left)] = _codels.Where(p => p.Y == yMin).OrderBy(p => p.X).FirstOrDefault();
            _edges[new Edge(DirectionPointer.top, /*  */ CodelChooser.right)] = _codels.Where(p => p.Y == yMin).OrderByDescending(p => p.X).FirstOrDefault();
            _edges[new Edge(DirectionPointer.down, /*  */ CodelChooser.left)] = _codels.Where(p => p.Y == xMax).OrderByDescending(p => p.X).FirstOrDefault();
            _edges[new Edge(DirectionPointer.down, /* */ CodelChooser.right)] = _codels.Where(p => p.Y == xMax).OrderBy(p => p.X).FirstOrDefault();
        }

        public bool IsBlack => Codel == Codel.Black;
        public bool IsWhite => Codel == Codel.White;

        public virtual Codel Codel { get; }

        public int Value => _codels.Count;

        public bool Contains(Point point) => _codels.Contains(point);

        public Point GetEdge(Edge edge) => _edges[edge];

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string DebuggerDisplay => $"{Codel.Colour.Debug()}, Value: {Value}";

        #region IEnumerable
        public IEnumerator<Point> GetEnumerator() => _codels.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

        #endregion
    }
}
