// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/DbgHelp.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

/// <include file='STACKFRAME.xml' path='doc/member[@name="STACKFRAME"]/*' />
public unsafe partial struct STACKFRAME
{
    /// <include file='STACKFRAME.xml' path='doc/member[@name="STACKFRAME.AddrPC"]/*' />
    public ADDRESS AddrPC;

    /// <include file='STACKFRAME.xml' path='doc/member[@name="STACKFRAME.AddrReturn"]/*' />
    public ADDRESS AddrReturn;

    /// <include file='STACKFRAME.xml' path='doc/member[@name="STACKFRAME.AddrFrame"]/*' />
    public ADDRESS AddrFrame;

    /// <include file='STACKFRAME.xml' path='doc/member[@name="STACKFRAME.AddrStack"]/*' />
    public ADDRESS AddrStack;

    /// <include file='STACKFRAME.xml' path='doc/member[@name="STACKFRAME.FuncTableEntry"]/*' />
    [NativeTypeName("PVOID")]
    public void* FuncTableEntry;

    /// <include file='STACKFRAME.xml' path='doc/member[@name="STACKFRAME.Params"]/*' />
    [NativeTypeName("DWORD[4]")]
    public _Params_e__FixedBuffer Params;

    /// <include file='STACKFRAME.xml' path='doc/member[@name="STACKFRAME.Far"]/*' />
    public BOOL Far;

    /// <include file='STACKFRAME.xml' path='doc/member[@name="STACKFRAME.Virtual"]/*' />
    public BOOL Virtual;

    /// <include file='STACKFRAME.xml' path='doc/member[@name="STACKFRAME.Reserved"]/*' />
    [NativeTypeName("DWORD[3]")]
    public _Reserved_e__FixedBuffer Reserved;

    /// <include file='STACKFRAME.xml' path='doc/member[@name="STACKFRAME.KdHelp"]/*' />
    public KDHELP KdHelp;

    /// <include file='STACKFRAME.xml' path='doc/member[@name="STACKFRAME.AddrBStore"]/*' />
    public ADDRESS AddrBStore;

    /// <include file='_Params_e__FixedBuffer.xml' path='doc/member[@name="_Params_e__FixedBuffer"]/*' />
    [InlineArray(4)]
    public partial struct _Params_e__FixedBuffer
    {
        public uint e0;
    }

    /// <include file='_Reserved_e__FixedBuffer.xml' path='doc/member[@name="_Reserved_e__FixedBuffer"]/*' />
    [InlineArray(3)]
    public partial struct _Reserved_e__FixedBuffer
    {
        public uint e0;
    }
}
