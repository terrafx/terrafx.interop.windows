// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

/// <include file='SCRUB_DATA_INPUT.xml' path='doc/member[@name="SCRUB_DATA_INPUT"]/*' />
public partial struct SCRUB_DATA_INPUT
{
    /// <include file='SCRUB_DATA_INPUT.xml' path='doc/member[@name="SCRUB_DATA_INPUT.Size"]/*' />
    [NativeTypeName("DWORD")]
    public uint Size;

    /// <include file='SCRUB_DATA_INPUT.xml' path='doc/member[@name="SCRUB_DATA_INPUT.Flags"]/*' />
    [NativeTypeName("DWORD")]
    public uint Flags;

    /// <include file='SCRUB_DATA_INPUT.xml' path='doc/member[@name="SCRUB_DATA_INPUT.MaximumIos"]/*' />
    [NativeTypeName("DWORD")]
    public uint MaximumIos;

    /// <include file='SCRUB_DATA_INPUT.xml' path='doc/member[@name="SCRUB_DATA_INPUT.ObjectId"]/*' />
    [NativeTypeName("DWORD[4]")]
    public _ObjectId_e__FixedBuffer ObjectId;

    /// <include file='SCRUB_DATA_INPUT.xml' path='doc/member[@name="SCRUB_DATA_INPUT.Reserved"]/*' />
    [NativeTypeName("DWORD[41]")]
    public _Reserved_e__FixedBuffer Reserved;

    /// <include file='SCRUB_DATA_INPUT.xml' path='doc/member[@name="SCRUB_DATA_INPUT.ResumeContext"]/*' />
    [NativeTypeName("BYTE[1040]")]
    public _ResumeContext_e__FixedBuffer ResumeContext;

    /// <include file='_ObjectId_e__FixedBuffer.xml' path='doc/member[@name="_ObjectId_e__FixedBuffer"]/*' />
    [InlineArray(4)]
    public partial struct _ObjectId_e__FixedBuffer
    {
        public uint e0;
    }

    /// <include file='_Reserved_e__FixedBuffer.xml' path='doc/member[@name="_Reserved_e__FixedBuffer"]/*' />
    [InlineArray(41)]
    public partial struct _Reserved_e__FixedBuffer
    {
        public uint e0;
    }

    /// <include file='_ResumeContext_e__FixedBuffer.xml' path='doc/member[@name="_ResumeContext_e__FixedBuffer"]/*' />
    [InlineArray(1040)]
    public partial struct _ResumeContext_e__FixedBuffer
    {
        public byte e0;
    }
}
