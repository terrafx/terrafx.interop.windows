// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class WS_CERT_FAILURE
{
    /// <include file='WS_CERT_FAILURE.xml' path='doc/member[@name="WS_CERT_FAILURE.WS_CERT_FAILURE_CN_MISMATCH"]/*' />
    public const int WS_CERT_FAILURE_CN_MISMATCH = 0x1;
    /// <include file='WS_CERT_FAILURE.xml' path='doc/member[@name="WS_CERT_FAILURE.WS_CERT_FAILURE_INVALID_DATE"]/*' />
    public const int WS_CERT_FAILURE_INVALID_DATE = 0x2;
    /// <include file='WS_CERT_FAILURE.xml' path='doc/member[@name="WS_CERT_FAILURE.WS_CERT_FAILURE_UNTRUSTED_ROOT"]/*' />
    public const int WS_CERT_FAILURE_UNTRUSTED_ROOT = 0x4;
    /// <include file='WS_CERT_FAILURE.xml' path='doc/member[@name="WS_CERT_FAILURE.WS_CERT_FAILURE_WRONG_USAGE"]/*' />
    public const int WS_CERT_FAILURE_WRONG_USAGE = 0x8;
    /// <include file='WS_CERT_FAILURE.xml' path='doc/member[@name="WS_CERT_FAILURE.WS_CERT_FAILURE_REVOCATION_OFFLINE"]/*' />
    public const int WS_CERT_FAILURE_REVOCATION_OFFLINE = 0x10;
}
