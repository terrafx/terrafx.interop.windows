// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

/// <include file='TOKEN_AUDIT_POLICY.xml' path='doc/member[@name="TOKEN_AUDIT_POLICY"]/*' />
public partial struct TOKEN_AUDIT_POLICY
{
    /// <include file='TOKEN_AUDIT_POLICY.xml' path='doc/member[@name="TOKEN_AUDIT_POLICY.PerUserPolicy"]/*' />
    [NativeTypeName("BYTE[30]")]
    public _PerUserPolicy_e__FixedBuffer PerUserPolicy;

    /// <include file='_PerUserPolicy_e__FixedBuffer.xml' path='doc/member[@name="_PerUserPolicy_e__FixedBuffer"]/*' />
    [InlineArray(30)]
    public partial struct _PerUserPolicy_e__FixedBuffer
    {
        public byte e0;
    }
}
