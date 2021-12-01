// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='CREATE_DISK.xml' path='doc/member[@name="CREATE_DISK"]/*' />
public partial struct CREATE_DISK
{
    /// <include file='CREATE_DISK.xml' path='doc/member[@name="CREATE_DISK.PartitionStyle"]/*' />
    public PARTITION_STYLE PartitionStyle;

    /// <include file='CREATE_DISK.xml' path='doc/member[@name="CREATE_DISK.Anonymous"]/*' />
    [NativeTypeName("_CREATE_DISK::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.20348.0/um/winioctl.h:9106:5)")]
    public _Anonymous_e__Union Anonymous;

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Mbr"]/*' />
    public ref CREATE_DISK_MBR Mbr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Mbr, 1));
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Gpt"]/*' />
    public ref CREATE_DISK_GPT Gpt
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
        public CREATE_DISK_MBR Mbr;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Gpt"]/*' />
        [FieldOffset(0)]
        public CREATE_DISK_GPT Gpt;
    }
}
