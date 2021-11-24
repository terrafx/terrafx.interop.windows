// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

public partial struct DISK_DETECTION_INFO
{
    [NativeTypeName("DWORD")]
    public uint SizeOfDetectInfo;

    public DETECTION_TYPE DetectionType;

    [NativeTypeName("_DISK_DETECTION_INFO::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.20348.0/um/winioctl.h:9272:9)")]
    public _Anonymous_e__Union Anonymous;

    public ref DISK_INT13_INFO Int13
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous.Int13, 1));
        }
    }

    public ref DISK_EX_INT13_INFO ExInt13
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous.ExInt13, 1));
        }
    }

    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        [NativeTypeName("_DISK_DETECTION_INFO::(anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.20348.0/um/winioctl.h:9273:17)")]
        public _Anonymous_e__Struct Anonymous;

        public partial struct _Anonymous_e__Struct
        {
            public DISK_INT13_INFO Int13;

            public DISK_EX_INT13_INFO ExInt13;
        }
    }
}
