// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/DbgHelp.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

/// <include file='STACKFRAME_EX.xml' path='doc/member[@name="STACKFRAME_EX"]/*' />
public unsafe partial struct STACKFRAME_EX
{
    /// <include file='STACKFRAME_EX.xml' path='doc/member[@name="STACKFRAME_EX.AddrPC"]/*' />
    public ADDRESS64 AddrPC;

    /// <include file='STACKFRAME_EX.xml' path='doc/member[@name="STACKFRAME_EX.AddrReturn"]/*' />
    public ADDRESS64 AddrReturn;

    /// <include file='STACKFRAME_EX.xml' path='doc/member[@name="STACKFRAME_EX.AddrFrame"]/*' />
    public ADDRESS64 AddrFrame;

    /// <include file='STACKFRAME_EX.xml' path='doc/member[@name="STACKFRAME_EX.AddrStack"]/*' />
    public ADDRESS64 AddrStack;

    /// <include file='STACKFRAME_EX.xml' path='doc/member[@name="STACKFRAME_EX.AddrBStore"]/*' />
    public ADDRESS64 AddrBStore;

    /// <include file='STACKFRAME_EX.xml' path='doc/member[@name="STACKFRAME_EX.FuncTableEntry"]/*' />
    [NativeTypeName("PVOID")]
    public void* FuncTableEntry;

    /// <include file='STACKFRAME_EX.xml' path='doc/member[@name="STACKFRAME_EX.Params"]/*' />
    [NativeTypeName("DWORD64[4]")]
    public _Params_e__FixedBuffer Params;

    /// <include file='STACKFRAME_EX.xml' path='doc/member[@name="STACKFRAME_EX.Far"]/*' />
    public BOOL Far;

    /// <include file='STACKFRAME_EX.xml' path='doc/member[@name="STACKFRAME_EX.Virtual"]/*' />
    public BOOL Virtual;

    /// <include file='STACKFRAME_EX.xml' path='doc/member[@name="STACKFRAME_EX.Reserved"]/*' />
    [NativeTypeName("DWORD64[3]")]
    public _Reserved_e__FixedBuffer Reserved;

    /// <include file='STACKFRAME_EX.xml' path='doc/member[@name="STACKFRAME_EX.KdHelp"]/*' />
    public KDHELP64 KdHelp;

    /// <include file='STACKFRAME_EX.xml' path='doc/member[@name="STACKFRAME_EX.StackFrameSize"]/*' />
    [NativeTypeName("DWORD")]
    public uint StackFrameSize;

    /// <include file='STACKFRAME_EX.xml' path='doc/member[@name="STACKFRAME_EX.InlineFrameContext"]/*' />
    [NativeTypeName("DWORD")]
    public uint InlineFrameContext;

    /// <include file='_Params_e__FixedBuffer.xml' path='doc/member[@name="_Params_e__FixedBuffer"]/*' />
    [InlineArray(4)]
    public partial struct _Params_e__FixedBuffer
    {
        public ulong e0;
    }

    /// <include file='_Reserved_e__FixedBuffer.xml' path='doc/member[@name="_Reserved_e__FixedBuffer"]/*' />
    [InlineArray(3)]
    public partial struct _Reserved_e__FixedBuffer
    {
        public ulong e0;
    }
}
