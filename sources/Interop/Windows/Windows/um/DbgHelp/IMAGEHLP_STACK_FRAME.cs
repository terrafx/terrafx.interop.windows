// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/DbgHelp.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

/// <include file='IMAGEHLP_STACK_FRAME.xml' path='doc/member[@name="IMAGEHLP_STACK_FRAME"]/*' />
public partial struct IMAGEHLP_STACK_FRAME
{
    /// <include file='IMAGEHLP_STACK_FRAME.xml' path='doc/member[@name="IMAGEHLP_STACK_FRAME.InstructionOffset"]/*' />
    [NativeTypeName("ULONG64")]
    public ulong InstructionOffset;

    /// <include file='IMAGEHLP_STACK_FRAME.xml' path='doc/member[@name="IMAGEHLP_STACK_FRAME.ReturnOffset"]/*' />
    [NativeTypeName("ULONG64")]
    public ulong ReturnOffset;

    /// <include file='IMAGEHLP_STACK_FRAME.xml' path='doc/member[@name="IMAGEHLP_STACK_FRAME.FrameOffset"]/*' />
    [NativeTypeName("ULONG64")]
    public ulong FrameOffset;

    /// <include file='IMAGEHLP_STACK_FRAME.xml' path='doc/member[@name="IMAGEHLP_STACK_FRAME.StackOffset"]/*' />
    [NativeTypeName("ULONG64")]
    public ulong StackOffset;

    /// <include file='IMAGEHLP_STACK_FRAME.xml' path='doc/member[@name="IMAGEHLP_STACK_FRAME.BackingStoreOffset"]/*' />
    [NativeTypeName("ULONG64")]
    public ulong BackingStoreOffset;

    /// <include file='IMAGEHLP_STACK_FRAME.xml' path='doc/member[@name="IMAGEHLP_STACK_FRAME.FuncTableEntry"]/*' />
    [NativeTypeName("ULONG64")]
    public ulong FuncTableEntry;

    /// <include file='IMAGEHLP_STACK_FRAME.xml' path='doc/member[@name="IMAGEHLP_STACK_FRAME.Params"]/*' />
    [NativeTypeName("ULONG64[4]")]
    public _Params_e__FixedBuffer Params;

    /// <include file='IMAGEHLP_STACK_FRAME.xml' path='doc/member[@name="IMAGEHLP_STACK_FRAME.Reserved"]/*' />
    [NativeTypeName("ULONG64[5]")]
    public _Reserved_e__FixedBuffer Reserved;

    /// <include file='IMAGEHLP_STACK_FRAME.xml' path='doc/member[@name="IMAGEHLP_STACK_FRAME.Virtual"]/*' />
    public BOOL Virtual;

    /// <include file='IMAGEHLP_STACK_FRAME.xml' path='doc/member[@name="IMAGEHLP_STACK_FRAME.Reserved2"]/*' />
    [NativeTypeName("ULONG")]
    public uint Reserved2;

    /// <include file='_Params_e__FixedBuffer.xml' path='doc/member[@name="_Params_e__FixedBuffer"]/*' />
    [InlineArray(4)]
    public partial struct _Params_e__FixedBuffer
    {
        public ulong e0;
    }

    /// <include file='_Reserved_e__FixedBuffer.xml' path='doc/member[@name="_Reserved_e__FixedBuffer"]/*' />
    [InlineArray(5)]
    public partial struct _Reserved_e__FixedBuffer
    {
        public ulong e0;
    }
}
