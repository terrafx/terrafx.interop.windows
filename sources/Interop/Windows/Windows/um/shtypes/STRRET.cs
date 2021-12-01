// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/shtypes.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='STRRET.xml' path='doc/member[@name="STRRET"]/*' />
public unsafe partial struct STRRET
{
    /// <include file='STRRET.xml' path='doc/member[@name="STRRET.uType"]/*' />
    public uint uType;

    /// <include file='STRRET.xml' path='doc/member[@name="STRRET.Anonymous"]/*' />
    [NativeTypeName("_STRRET::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.20348.0/um/shtypes.h:285:36)")]
    public _Anonymous_e__Union Anonymous;

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pOleStr"]/*' />
    public ref ushort* pOleStr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref this, 1)).Anonymous.pOleStr;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.uOffset"]/*' />
    public ref uint uOffset
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.uOffset, 1));
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.cStr"]/*' />
    public Span<sbyte> cStr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return MemoryMarshal.CreateSpan(ref Anonymous.cStr[0], 260);
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union"]/*' />
    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct _Anonymous_e__Union
    {
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pOleStr"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("LPWSTR")]
        public ushort* pOleStr;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.uOffset"]/*' />
        [FieldOffset(0)]
        public uint uOffset;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.cStr"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("char [260]")]
        public fixed sbyte cStr[260];
    }
}
