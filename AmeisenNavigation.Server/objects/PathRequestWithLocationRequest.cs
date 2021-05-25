using AmeisenNavigation.Server.Objects.Enums;
using System.Runtime.InteropServices;

namespace AmeisenNavigation.Server.Objects
{
    [StructLayout(LayoutKind.Sequential)]
    public struct PathRequestWithLocationRequest
    {
        public PathRequestWithLocationRequest(int mapId, Vector3 a, Vector3 b, PathRequestFlags flags = PathRequestFlags.None)
        {
            Type = 3;
            A = a;
            B = b;
            MapId = mapId;
            Flags = flags;
        }

        public int Type { get; set; }

        public Vector3 A { get; set; }

        public Vector3 B { get; set; }

        public PathRequestFlags Flags { get; set; }

        public int MapId { get; set; }
    }
}