// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winternl.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='IO_STATUS_BLOCK.xml' path='doc/member[@name="IO_STATUS_BLOCK"]/*' />
public unsafe partial struct IO_STATUS_BLOCK
{
    /// <include file='IO_STATUS_BLOCK.xml' path='doc/member[@name="IO_STATUS_BLOCK.Anonymous"]/*' />
    [NativeTypeName("_IO_STATUS_BLOCK::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.22000.0/um/winternl.h:226:5)")]
    public _Anonymous_e__Union Anonymous;

    /// <include file='IO_STATUS_BLOCK.xml' path='doc/member[@name="IO_STATUS_BLOCK.Information"]/*' />
    [NativeTypeName("ULONG_PTR")]
    public nuint Information;

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Status"]/*' />
    public ref int Status
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Status, 1));
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Pointer"]/*' />
    public ref void* Pointer
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref this, 1)).Anonymous.Pointer;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union"]/*' />
    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct _Anonymous_e__Union
    {
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Status"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("NTSTATUS")]
        public int Status;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Pointer"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("PVOID")]
        public void* Pointer;
    }
}
