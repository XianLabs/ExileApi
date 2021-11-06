using System.Runtime.InteropServices;

namespace GameOffsets
{
    [StructLayout(LayoutKind.Explicit, Pack = 1)]
    public struct IngameStateOffsets
    {
        [FieldOffset(0x18)] public long Data;
        [FieldOffset(0x80)] public long IngameUi;
        [FieldOffset(0xA0)] public long EntityLabelMap;
        [FieldOffset(0x4F8)] public long UIRoot;
        [FieldOffset(0x530)] public long UIHoverElement;
        [FieldOffset(0x530)] public long UIHover; // element which is currently hovered
        [FieldOffset(0x538)] public float UIHoverPosX; // top left corner of currently hovered UI element
        [FieldOffset(0x53C)] public float UIHoverPosY; // top left corner of currently hovered UI element
        [FieldOffset(0x540)] public long UIHoverTooltip;
        [FieldOffset(0x57C)] public float MousePosX;
        [FieldOffset(0x580)] public float MousePosY;
        [FieldOffset(0x600)] public int UIHoverCellX; // top left corner of currently hovered UI element, int version
        [FieldOffset(0x604)] public int UIHoverCellY; // top left corner of currently hovered UI element, int version
        [FieldOffset(0x754)] public float TimeInGameF; // time since last frame in seconds
        [FieldOffset(0x758)] public float TimeInGame; // total time in game in seconds
        [FieldOffset(0x768)] public long TerrainData; 
        [FieldOffset(0x58)] public short IsMapRevealed; //2nd offset from TerrainData, gives you "is_map_revealed" flag.
        [FieldOffset(0x618)] public int DiagnosticInfoType;
        [FieldOffset(0x848)] public long LatencyRectangle;
        [FieldOffset(0xCE8)] public long FrameTimeRectangle;
        [FieldOffset(0xF38)] public long FPSRectangle;
        [FieldOffset(0x870)] public int Camera;
        [FieldOffset(0xC08)] public float CameraZoom;   
          
    }
}
