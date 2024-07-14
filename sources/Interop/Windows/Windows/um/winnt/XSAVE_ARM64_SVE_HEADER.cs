// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

/// <include file='XSAVE_ARM64_SVE_HEADER.xml' path='doc/member[@name="XSAVE_ARM64_SVE_HEADER"]/*' />
public partial struct XSAVE_ARM64_SVE_HEADER
{
    /// <include file='XSAVE_ARM64_SVE_HEADER.xml' path='doc/member[@name="XSAVE_ARM64_SVE_HEADER.VectorLength"]/*' />
    [NativeTypeName("DWORD")]
    public uint VectorLength;

    /// <include file='XSAVE_ARM64_SVE_HEADER.xml' path='doc/member[@name="XSAVE_ARM64_SVE_HEADER.VectorRegisterOffset"]/*' />
    [NativeTypeName("DWORD")]
    public uint VectorRegisterOffset;

    /// <include file='XSAVE_ARM64_SVE_HEADER.xml' path='doc/member[@name="XSAVE_ARM64_SVE_HEADER.PredicateRegisterOffset"]/*' />
    [NativeTypeName("DWORD")]
    public uint PredicateRegisterOffset;

    /// <include file='XSAVE_ARM64_SVE_HEADER.xml' path='doc/member[@name="XSAVE_ARM64_SVE_HEADER.Reserved"]/*' />
    [NativeTypeName("DWORD[5]")]
    public _Reserved_e__FixedBuffer Reserved;

    /// <include file='_Reserved_e__FixedBuffer.xml' path='doc/member[@name="_Reserved_e__FixedBuffer"]/*' />
    [InlineArray(5)]
    public partial struct _Reserved_e__FixedBuffer
    {
        public uint e0;
    }
}
