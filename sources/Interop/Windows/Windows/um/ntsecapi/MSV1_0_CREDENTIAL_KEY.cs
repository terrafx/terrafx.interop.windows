// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ntsecapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

/// <include file='MSV1_0_CREDENTIAL_KEY.xml' path='doc/member[@name="MSV1_0_CREDENTIAL_KEY"]/*' />
public partial struct MSV1_0_CREDENTIAL_KEY
{
    /// <include file='MSV1_0_CREDENTIAL_KEY.xml' path='doc/member[@name="MSV1_0_CREDENTIAL_KEY.Data"]/*' />
    [NativeTypeName("UCHAR[20]")]
    public _Data_e__FixedBuffer Data;

    /// <include file='_Data_e__FixedBuffer.xml' path='doc/member[@name="_Data_e__FixedBuffer"]/*' />
    [InlineArray(20)]
    public partial struct _Data_e__FixedBuffer
    {
        public byte e0;
    }
}
