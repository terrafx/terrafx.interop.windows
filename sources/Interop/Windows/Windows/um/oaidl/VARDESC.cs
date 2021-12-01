// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/oaidl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='VARDESC.xml' path='doc/member[@name="VARDESC"]/*' />
public unsafe partial struct VARDESC
{
    /// <include file='VARDESC.xml' path='doc/member[@name="VARDESC.memid"]/*' />
    [NativeTypeName("MEMBERID")]
    public int memid;

    /// <include file='VARDESC.xml' path='doc/member[@name="VARDESC.lpstrSchema"]/*' />
    [NativeTypeName("LPOLESTR")]
    public ushort* lpstrSchema;

    /// <include file='VARDESC.xml' path='doc/member[@name="VARDESC.Anonymous"]/*' />
    [NativeTypeName("tagVARDESC::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.20348.0/um/oaidl.h:880:36)")]
    public _Anonymous_e__Union Anonymous;

    /// <include file='VARDESC.xml' path='doc/member[@name="VARDESC.elemdescVar"]/*' />
    public ELEMDESC elemdescVar;

    /// <include file='VARDESC.xml' path='doc/member[@name="VARDESC.wVarFlags"]/*' />
    [NativeTypeName("WORD")]
    public ushort wVarFlags;

    /// <include file='VARDESC.xml' path='doc/member[@name="VARDESC.varkind"]/*' />
    public VARKIND varkind;

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.oInst"]/*' />
    public ref uint oInst
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.oInst, 1));
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.lpvarValue"]/*' />
    public ref VARIANT* lpvarValue
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref this, 1)).Anonymous.lpvarValue;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union"]/*' />
    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct _Anonymous_e__Union
    {
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.oInst"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("ULONG")]
        public uint oInst;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.lpvarValue"]/*' />
        [FieldOffset(0)]
        public VARIANT* lpvarValue;
    }
}
