// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows;

public partial struct DISPLAYCONFIG_MODE_INFO
{
    public DISPLAYCONFIG_MODE_INFO_TYPE infoType;

    [NativeTypeName("UINT32")]
    public uint id;

    public LUID adapterId;

    [NativeTypeName("DISPLAYCONFIG_MODE_INFO::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.20348.0/um/wingdi.h:2932:5)")]
    public _Anonymous_e__Union Anonymous;

    public ref DISPLAYCONFIG_TARGET_MODE targetMode
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.targetMode, 1));
        }
    }

    public ref DISPLAYCONFIG_SOURCE_MODE sourceMode
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.sourceMode, 1));
        }
    }

    [SupportedOSPlatform("windows10.0.17763.0")]
    public ref DISPLAYCONFIG_DESKTOP_IMAGE_INFO desktopImageInfo
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.desktopImageInfo, 1));
        }
    }

    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        public DISPLAYCONFIG_TARGET_MODE targetMode;

        [FieldOffset(0)]
        public DISPLAYCONFIG_SOURCE_MODE sourceMode;

        [FieldOffset(0)]
        [SupportedOSPlatform("windows10.0.17763.0")]
        public DISPLAYCONFIG_DESKTOP_IMAGE_INFO desktopImageInfo;
    }
}
