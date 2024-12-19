// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/http.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

/// <include file='HTTP_WINHTTP_FAST_FORWARDING_DATA.xml' path='doc/member[@name="HTTP_WINHTTP_FAST_FORWARDING_DATA"]/*' />
public partial struct HTTP_WINHTTP_FAST_FORWARDING_DATA
{
    /// <include file='HTTP_WINHTTP_FAST_FORWARDING_DATA.xml' path='doc/member[@name="HTTP_WINHTTP_FAST_FORWARDING_DATA.Reserved"]/*' />
    [NativeTypeName("UCHAR[16]")]
    public _Reserved_e__FixedBuffer Reserved;

    /// <include file='_Reserved_e__FixedBuffer.xml' path='doc/member[@name="_Reserved_e__FixedBuffer"]/*' />
    [InlineArray(16)]
    public partial struct _Reserved_e__FixedBuffer
    {
        public byte e0;
    }
}
