// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/tbs.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

/// <include file='TPM_WNF_PROVISIONING.xml' path='doc/member[@name="TPM_WNF_PROVISIONING"]/*' />
public partial struct TPM_WNF_PROVISIONING
{
    /// <include file='TPM_WNF_PROVISIONING.xml' path='doc/member[@name="TPM_WNF_PROVISIONING.status"]/*' />
    [NativeTypeName("UINT32")]
    public uint status;

    /// <include file='TPM_WNF_PROVISIONING.xml' path='doc/member[@name="TPM_WNF_PROVISIONING.message"]/*' />
    [NativeTypeName("BYTE[28]")]
    public _message_e__FixedBuffer message;

    /// <include file='_message_e__FixedBuffer.xml' path='doc/member[@name="_message_e__FixedBuffer"]/*' />
    [InlineArray(28)]
    public partial struct _message_e__FixedBuffer
    {
        public byte e0;
    }
}
