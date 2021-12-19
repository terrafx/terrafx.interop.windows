// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='MFTOPONODE_ATTRIBUTE_UPDATE.xml' path='doc/member[@name="MFTOPONODE_ATTRIBUTE_UPDATE"]/*' />
public partial struct MFTOPONODE_ATTRIBUTE_UPDATE
{
    /// <include file='MFTOPONODE_ATTRIBUTE_UPDATE.xml' path='doc/member[@name="MFTOPONODE_ATTRIBUTE_UPDATE.NodeId"]/*' />
    [NativeTypeName("TOPOID")]
    public ulong NodeId;

    /// <include file='MFTOPONODE_ATTRIBUTE_UPDATE.xml' path='doc/member[@name="MFTOPONODE_ATTRIBUTE_UPDATE.guidAttributeKey"]/*' />
    public Guid guidAttributeKey;

    /// <include file='MFTOPONODE_ATTRIBUTE_UPDATE.xml' path='doc/member[@name="MFTOPONODE_ATTRIBUTE_UPDATE.attrType"]/*' />
    public MF_ATTRIBUTE_TYPE attrType;

    /// <include file='MFTOPONODE_ATTRIBUTE_UPDATE.xml' path='doc/member[@name="MFTOPONODE_ATTRIBUTE_UPDATE.Anonymous"]/*' />
    [NativeTypeName("_MFTOPONODE_ATTRIBUTE_UPDATE::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.22000.0/um/mfidl.h:11434:36)")]
    public _Anonymous_e__Union Anonymous;

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.u32"]/*' />
    public ref uint u32
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.u32, 1));
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.u64"]/*' />
    public ref ulong u64
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.u64, 1));
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.d"]/*' />
    public ref double d
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.d, 1));
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union"]/*' />
    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.u32"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("UINT32")]
        public uint u32;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.u64"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("UINT64")]
        public ulong u64;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.d"]/*' />
        [FieldOffset(0)]
        public double d;
    }
}
