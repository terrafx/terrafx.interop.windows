// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='DISK_DETECTION_INFO.xml' path='doc/member[@name="DISK_DETECTION_INFO"]/*' />
public partial struct DISK_DETECTION_INFO
{
    /// <include file='DISK_DETECTION_INFO.xml' path='doc/member[@name="DISK_DETECTION_INFO.SizeOfDetectInfo"]/*' />
    [NativeTypeName("DWORD")]
    public uint SizeOfDetectInfo;

    /// <include file='DISK_DETECTION_INFO.xml' path='doc/member[@name="DISK_DETECTION_INFO.DetectionType"]/*' />
    public DETECTION_TYPE DetectionType;

    /// <include file='DISK_DETECTION_INFO.xml' path='doc/member[@name="DISK_DETECTION_INFO.Anonymous"]/*' />
    [NativeTypeName("_DISK_DETECTION_INFO::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.22000.0/um/winioctl.h:9272:9)")]
    public _Anonymous_e__Union Anonymous;

    /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.Int13"]/*' />
    public ref DISK_INT13_INFO Int13
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous.Int13, 1));
        }
    }

    /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.ExInt13"]/*' />
    public ref DISK_EX_INT13_INFO ExInt13
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous.ExInt13, 1));
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union"]/*' />
    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Anonymous"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("_DISK_DETECTION_INFO::(anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.22000.0/um/winioctl.h:9273:17)")]
        public _Anonymous_e__Struct Anonymous;

        /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct"]/*' />
        public partial struct _Anonymous_e__Struct
        {
            /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.Int13"]/*' />
            public DISK_INT13_INFO Int13;

            /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.ExInt13"]/*' />
            public DISK_EX_INT13_INFO ExInt13;
        }
    }
}
