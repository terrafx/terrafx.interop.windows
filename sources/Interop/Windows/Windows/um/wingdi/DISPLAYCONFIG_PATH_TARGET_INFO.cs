// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

public partial struct DISPLAYCONFIG_PATH_TARGET_INFO
{
    public LUID adapterId;

    [NativeTypeName("UINT32")]
    public uint id;

    [NativeTypeName("DISPLAYCONFIG_PATH_TARGET_INFO::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.20348.0/um/wingdi.h:2973:5)")]
    public _Anonymous_e__Union Anonymous;

    public DISPLAYCONFIG_VIDEO_OUTPUT_TECHNOLOGY outputTechnology;

    public DISPLAYCONFIG_ROTATION rotation;

    public DISPLAYCONFIG_SCALING scaling;

    public DISPLAYCONFIG_RATIONAL refreshRate;

    public DISPLAYCONFIG_SCANLINE_ORDERING scanLineOrdering;

    public BOOL targetAvailable;

    [NativeTypeName("UINT32")]
    public uint statusFlags;

    public ref uint modeInfoIdx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.modeInfoIdx, 1));
        }
    }

    public uint desktopModeInfoIdx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return Anonymous.Anonymous.desktopModeInfoIdx;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            Anonymous.Anonymous.desktopModeInfoIdx = value;
        }
    }

    public uint targetModeInfoIdx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return Anonymous.Anonymous.targetModeInfoIdx;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            Anonymous.Anonymous.targetModeInfoIdx = value;
        }
    }

    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        [NativeTypeName("UINT32")]
        public uint modeInfoIdx;

        [FieldOffset(0)]
        [NativeTypeName("DISPLAYCONFIG_PATH_TARGET_INFO::(anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.20348.0/um/wingdi.h:2976:9)")]
        public _Anonymous_e__Struct Anonymous;

        public partial struct _Anonymous_e__Struct
        {
            public uint _bitfield;

            [NativeTypeName("UINT32 : 16")]
            public uint desktopModeInfoIdx
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return _bitfield & 0xFFFFu;
                }

                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                set
                {
                    _bitfield = (_bitfield & ~0xFFFFu) | (value & 0xFFFFu);
                }
            }

            [NativeTypeName("UINT32 : 16")]
            public uint targetModeInfoIdx
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return (_bitfield >> 16) & 0xFFFFu;
                }

                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                set
                {
                    _bitfield = (_bitfield & ~(0xFFFFu << 16)) | ((value & 0xFFFFu) << 16);
                }
            }
        }
    }
}
