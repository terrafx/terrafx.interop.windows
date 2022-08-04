// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='TXFS_READ_BACKUP_INFORMATION_OUT.xml' path='doc/member[@name="TXFS_READ_BACKUP_INFORMATION_OUT"]/*' />
public unsafe partial struct TXFS_READ_BACKUP_INFORMATION_OUT
{
    /// <include file='TXFS_READ_BACKUP_INFORMATION_OUT.xml' path='doc/member[@name="TXFS_READ_BACKUP_INFORMATION_OUT.Anonymous"]/*' />
    [NativeTypeName("_TXFS_READ_BACKUP_INFORMATION_OUT::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.22000.0/um/winioctl.h:13601:5)")]
    public _Anonymous_e__Union Anonymous;

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.BufferLength"]/*' />
    [UnscopedRef]
    public ref uint BufferLength
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.BufferLength;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Buffer"]/*' />
    [UnscopedRef]
    public Span<byte> Buffer
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return MemoryMarshal.CreateSpan(ref Anonymous.Buffer[0], 1);
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union"]/*' />
    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct _Anonymous_e__Union
    {
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.BufferLength"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint BufferLength;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Buffer"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("BYTE[1]")]
        public fixed byte Buffer[1];
    }
}
