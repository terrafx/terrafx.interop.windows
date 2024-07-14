// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

/// <include file='AMCOPPSignature.xml' path='doc/member[@name="AMCOPPSignature"]/*' />
public partial struct AMCOPPSignature
{
    /// <include file='AMCOPPSignature.xml' path='doc/member[@name="AMCOPPSignature.Signature"]/*' />
    [NativeTypeName("BYTE[256]")]
    public _Signature_e__FixedBuffer Signature;

    /// <include file='_Signature_e__FixedBuffer.xml' path='doc/member[@name="_Signature_e__FixedBuffer"]/*' />
    [InlineArray(256)]
    public partial struct _Signature_e__FixedBuffer
    {
        public byte e0;
    }
}
