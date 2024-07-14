// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

/// <include file='FILE_ID_128.xml' path='doc/member[@name="FILE_ID_128"]/*' />
public partial struct FILE_ID_128
{
    /// <include file='FILE_ID_128.xml' path='doc/member[@name="FILE_ID_128.Identifier"]/*' />
    [NativeTypeName("BYTE[16]")]
    public _Identifier_e__FixedBuffer Identifier;

    /// <include file='_Identifier_e__FixedBuffer.xml' path='doc/member[@name="_Identifier_e__FixedBuffer"]/*' />
    [InlineArray(16)]
    public partial struct _Identifier_e__FixedBuffer
    {
        public byte e0;
    }
}
