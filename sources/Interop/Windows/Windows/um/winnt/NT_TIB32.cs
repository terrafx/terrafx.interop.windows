// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='NT_TIB32.xml' path='doc/member[@name="NT_TIB32"]/*' />
public partial struct NT_TIB32
{
    /// <include file='NT_TIB32.xml' path='doc/member[@name="NT_TIB32.ExceptionList"]/*' />
    [NativeTypeName("DWORD")]
    public uint ExceptionList;

    /// <include file='NT_TIB32.xml' path='doc/member[@name="NT_TIB32.StackBase"]/*' />
    [NativeTypeName("DWORD")]
    public uint StackBase;

    /// <include file='NT_TIB32.xml' path='doc/member[@name="NT_TIB32.StackLimit"]/*' />
    [NativeTypeName("DWORD")]
    public uint StackLimit;

    /// <include file='NT_TIB32.xml' path='doc/member[@name="NT_TIB32.SubSystemTib"]/*' />
    [NativeTypeName("DWORD")]
    public uint SubSystemTib;

    /// <include file='NT_TIB32.xml' path='doc/member[@name="NT_TIB32.Anonymous"]/*' />
    [NativeTypeName("_NT_TIB32::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.20348.0/um/winnt.h:12493:5)")]
    public _Anonymous_e__Union Anonymous;

    /// <include file='NT_TIB32.xml' path='doc/member[@name="NT_TIB32.ArbitraryUserPointer"]/*' />
    [NativeTypeName("DWORD")]
    public uint ArbitraryUserPointer;

    /// <include file='NT_TIB32.xml' path='doc/member[@name="NT_TIB32.Self"]/*' />
    [NativeTypeName("DWORD")]
    public uint Self;

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.FiberData"]/*' />
    [UnscopedRef]
    public ref uint FiberData
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.FiberData;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Version"]/*' />
    [UnscopedRef]
    public ref uint Version
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.Version;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union"]/*' />
    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.FiberData"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint FiberData;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Version"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint Version;
    }
}
