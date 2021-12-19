// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='DISK_PARTITION_INFO.xml' path='doc/member[@name="DISK_PARTITION_INFO"]/*' />
public partial struct DISK_PARTITION_INFO
{
    /// <include file='DISK_PARTITION_INFO.xml' path='doc/member[@name="DISK_PARTITION_INFO.SizeOfPartitionInfo"]/*' />
    [NativeTypeName("DWORD")]
    public uint SizeOfPartitionInfo;

    /// <include file='DISK_PARTITION_INFO.xml' path='doc/member[@name="DISK_PARTITION_INFO.PartitionStyle"]/*' />
    public PARTITION_STYLE PartitionStyle;

    /// <include file='DISK_PARTITION_INFO.xml' path='doc/member[@name="DISK_PARTITION_INFO.Anonymous"]/*' />
    [NativeTypeName("_DISK_PARTITION_INFO::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.22000.0/um/winioctl.h:9327:9)")]
    public _Anonymous_e__Union Anonymous;

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Mbr"]/*' />
    public ref _Anonymous_e__Union._Mbr_e__Struct Mbr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Mbr, 1));
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Gpt"]/*' />
    public ref _Anonymous_e__Union._Gpt_e__Struct Gpt
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Gpt, 1));
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union"]/*' />
    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Mbr"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("struct (anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.22000.0/um/winioctl.h:9328:17)")]
        public _Mbr_e__Struct Mbr;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Gpt"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("struct (anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.22000.0/um/winioctl.h:9332:17)")]
        public _Gpt_e__Struct Gpt;

        /// <include file='_Mbr_e__Struct.xml' path='doc/member[@name="_Mbr_e__Struct"]/*' />
        public partial struct _Mbr_e__Struct
        {
            /// <include file='_Mbr_e__Struct.xml' path='doc/member[@name="_Mbr_e__Struct.Signature"]/*' />
            [NativeTypeName("DWORD")]
            public uint Signature;

            /// <include file='_Mbr_e__Struct.xml' path='doc/member[@name="_Mbr_e__Struct.CheckSum"]/*' />
            [NativeTypeName("DWORD")]
            public uint CheckSum;
        }

        /// <include file='_Gpt_e__Struct.xml' path='doc/member[@name="_Gpt_e__Struct"]/*' />
        public partial struct _Gpt_e__Struct
        {
            /// <include file='_Gpt_e__Struct.xml' path='doc/member[@name="_Gpt_e__Struct.DiskId"]/*' />
            public Guid DiskId;
        }
    }
}
