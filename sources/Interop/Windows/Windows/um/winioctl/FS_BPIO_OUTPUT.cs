// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='FS_BPIO_OUTPUT.xml' path='doc/member[@name="FS_BPIO_OUTPUT"]/*' />
public partial struct FS_BPIO_OUTPUT
{
    /// <include file='FS_BPIO_OUTPUT.xml' path='doc/member[@name="FS_BPIO_OUTPUT.Operation"]/*' />
    public FS_BPIO_OPERATIONS Operation;

    /// <include file='FS_BPIO_OUTPUT.xml' path='doc/member[@name="FS_BPIO_OUTPUT.OutFlags"]/*' />
    public FS_BPIO_OUTFLAGS OutFlags;

    /// <include file='FS_BPIO_OUTPUT.xml' path='doc/member[@name="FS_BPIO_OUTPUT.Reserved1"]/*' />
    [NativeTypeName("DWORDLONG")]
    public ulong Reserved1;

    /// <include file='FS_BPIO_OUTPUT.xml' path='doc/member[@name="FS_BPIO_OUTPUT.Reserved2"]/*' />
    [NativeTypeName("DWORDLONG")]
    public ulong Reserved2;

    /// <include file='FS_BPIO_OUTPUT.xml' path='doc/member[@name="FS_BPIO_OUTPUT.Anonymous"]/*' />
    [NativeTypeName("_FS_BPIO_OUTPUT::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.22000.0/um/winioctl.h:17039:5)")]
    public _Anonymous_e__Union Anonymous;

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Enable"]/*' />
    public ref FS_BPIO_RESULTS Enable
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Enable, 1));
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Query"]/*' />
    public ref FS_BPIO_RESULTS Query
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Query, 1));
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.VolumeStackResume"]/*' />
    public ref FS_BPIO_RESULTS VolumeStackResume
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.VolumeStackResume, 1));
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.StreamResume"]/*' />
    public ref FS_BPIO_RESULTS StreamResume
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.StreamResume, 1));
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.GetInfo"]/*' />
    public ref FS_BPIO_INFO GetInfo
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.GetInfo, 1));
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union"]/*' />
    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Enable"]/*' />
        [FieldOffset(0)]
        public FS_BPIO_RESULTS Enable;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Query"]/*' />
        [FieldOffset(0)]
        public FS_BPIO_RESULTS Query;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.VolumeStackResume"]/*' />
        [FieldOffset(0)]
        public FS_BPIO_RESULTS VolumeStackResume;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.StreamResume"]/*' />
        [FieldOffset(0)]
        public FS_BPIO_RESULTS StreamResume;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.GetInfo"]/*' />
        [FieldOffset(0)]
        public FS_BPIO_INFO GetInfo;
    }
}
