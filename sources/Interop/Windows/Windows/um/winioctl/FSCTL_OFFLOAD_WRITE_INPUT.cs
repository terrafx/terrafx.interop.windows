// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

/// <include file='FSCTL_OFFLOAD_WRITE_INPUT.xml' path='doc/member[@name="FSCTL_OFFLOAD_WRITE_INPUT"]/*' />
public partial struct FSCTL_OFFLOAD_WRITE_INPUT
{
    /// <include file='FSCTL_OFFLOAD_WRITE_INPUT.xml' path='doc/member[@name="FSCTL_OFFLOAD_WRITE_INPUT.Size"]/*' />
    [NativeTypeName("DWORD")]
    public uint Size;

    /// <include file='FSCTL_OFFLOAD_WRITE_INPUT.xml' path='doc/member[@name="FSCTL_OFFLOAD_WRITE_INPUT.Flags"]/*' />
    [NativeTypeName("DWORD")]
    public uint Flags;

    /// <include file='FSCTL_OFFLOAD_WRITE_INPUT.xml' path='doc/member[@name="FSCTL_OFFLOAD_WRITE_INPUT.FileOffset"]/*' />
    [NativeTypeName("DWORDLONG")]
    public ulong FileOffset;

    /// <include file='FSCTL_OFFLOAD_WRITE_INPUT.xml' path='doc/member[@name="FSCTL_OFFLOAD_WRITE_INPUT.CopyLength"]/*' />
    [NativeTypeName("DWORDLONG")]
    public ulong CopyLength;

    /// <include file='FSCTL_OFFLOAD_WRITE_INPUT.xml' path='doc/member[@name="FSCTL_OFFLOAD_WRITE_INPUT.TransferOffset"]/*' />
    [NativeTypeName("DWORDLONG")]
    public ulong TransferOffset;

    /// <include file='FSCTL_OFFLOAD_WRITE_INPUT.xml' path='doc/member[@name="FSCTL_OFFLOAD_WRITE_INPUT.Token"]/*' />
    [NativeTypeName("BYTE[512]")]
    public _Token_e__FixedBuffer Token;

    /// <include file='_Token_e__FixedBuffer.xml' path='doc/member[@name="_Token_e__FixedBuffer"]/*' />
    [InlineArray(512)]
    public partial struct _Token_e__FixedBuffer
    {
        public byte e0;
    }
}
