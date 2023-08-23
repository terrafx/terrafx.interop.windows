// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

/// <include file='XSAVE_FORMAT.xml' path='doc/member[@name="XSAVE_FORMAT"]/*' />
public unsafe partial struct XSAVE_FORMAT
{
    /// <include file='XSAVE_FORMAT.xml' path='doc/member[@name="XSAVE_FORMAT.ControlWord"]/*' />
    [NativeTypeName("WORD")]
    public ushort ControlWord;

    /// <include file='XSAVE_FORMAT.xml' path='doc/member[@name="XSAVE_FORMAT.StatusWord"]/*' />
    [NativeTypeName("WORD")]
    public ushort StatusWord;

    /// <include file='XSAVE_FORMAT.xml' path='doc/member[@name="XSAVE_FORMAT.TagWord"]/*' />
    public byte TagWord;

    /// <include file='XSAVE_FORMAT.xml' path='doc/member[@name="XSAVE_FORMAT.Reserved1"]/*' />
    public byte Reserved1;

    /// <include file='XSAVE_FORMAT.xml' path='doc/member[@name="XSAVE_FORMAT.ErrorOpcode"]/*' />
    [NativeTypeName("WORD")]
    public ushort ErrorOpcode;

    /// <include file='XSAVE_FORMAT.xml' path='doc/member[@name="XSAVE_FORMAT.ErrorOffset"]/*' />
    [NativeTypeName("DWORD")]
    public uint ErrorOffset;

    /// <include file='XSAVE_FORMAT.xml' path='doc/member[@name="XSAVE_FORMAT.ErrorSelector"]/*' />
    [NativeTypeName("WORD")]
    public ushort ErrorSelector;

    /// <include file='XSAVE_FORMAT.xml' path='doc/member[@name="XSAVE_FORMAT.Reserved2"]/*' />
    [NativeTypeName("WORD")]
    public ushort Reserved2;

    /// <include file='XSAVE_FORMAT.xml' path='doc/member[@name="XSAVE_FORMAT.DataOffset"]/*' />
    [NativeTypeName("DWORD")]
    public uint DataOffset;

    /// <include file='XSAVE_FORMAT.xml' path='doc/member[@name="XSAVE_FORMAT.DataSelector"]/*' />
    [NativeTypeName("WORD")]
    public ushort DataSelector;

    /// <include file='XSAVE_FORMAT.xml' path='doc/member[@name="XSAVE_FORMAT.Reserved3"]/*' />
    [NativeTypeName("WORD")]
    public ushort Reserved3;

    /// <include file='XSAVE_FORMAT.xml' path='doc/member[@name="XSAVE_FORMAT.MxCsr"]/*' />
    [NativeTypeName("DWORD")]
    public uint MxCsr;

    /// <include file='XSAVE_FORMAT.xml' path='doc/member[@name="XSAVE_FORMAT.MxCsr_Mask"]/*' />
    [NativeTypeName("DWORD")]
    public uint MxCsr_Mask;

    /// <include file='XSAVE_FORMAT.xml' path='doc/member[@name="XSAVE_FORMAT.FloatRegisters"]/*' />
    [NativeTypeName("M128A[8]")]
    public _FloatRegisters_e__FixedBuffer FloatRegisters;

    /// <include file='XSAVE_FORMAT.xml' path='doc/member[@name="XSAVE_FORMAT.XmmRegisters"]/*' />
    [NativeTypeName("M128A[16]")]
    public _XmmRegisters_e__FixedBuffer XmmRegisters;

    /// <include file='XSAVE_FORMAT.xml' path='doc/member[@name="XSAVE_FORMAT.Reserved4"]/*' />
    [NativeTypeName("BYTE[96]")]
    public fixed byte Reserved4[96];

    /// <include file='_FloatRegisters_e__FixedBuffer.xml' path='doc/member[@name="_FloatRegisters_e__FixedBuffer"]/*' />
    [InlineArray(8)]
    public partial struct _FloatRegisters_e__FixedBuffer
    {
        public M128A e0;
    }

    /// <include file='_XmmRegisters_e__FixedBuffer.xml' path='doc/member[@name="_XmmRegisters_e__FixedBuffer"]/*' />
    [InlineArray(16)]
    public partial struct _XmmRegisters_e__FixedBuffer
    {
        public M128A e0;
    }
}
