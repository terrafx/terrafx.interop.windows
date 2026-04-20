// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

/// <include file='XSAVE_ARM64_SME_ZT_HEADER.xml' path='doc/member[@name="XSAVE_ARM64_SME_ZT_HEADER"]/*' />
public partial struct XSAVE_ARM64_SME_ZT_HEADER
{
    /// <include file='XSAVE_ARM64_SME_ZT_HEADER.xml' path='doc/member[@name="XSAVE_ARM64_SME_ZT_HEADER.RegisterCount"]/*' />
    [NativeTypeName("DWORD")]
    public uint RegisterCount;

    /// <include file='XSAVE_ARM64_SME_ZT_HEADER.xml' path='doc/member[@name="XSAVE_ARM64_SME_ZT_HEADER.Reserved"]/*' />
    [NativeTypeName("DWORD[7]")]
    public _Reserved_e__FixedBuffer Reserved;

    /// <include file='_Reserved_e__FixedBuffer.xml' path='doc/member[@name="_Reserved_e__FixedBuffer"]/*' />
    [InlineArray(7)]
    public partial struct _Reserved_e__FixedBuffer
    {
        public uint e0;
    }
}
