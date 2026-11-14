// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinBase.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

using static TerraFX.Interop.Windows.SECURITY_IMPERSONATION_LEVEL;

namespace TerraFX.Interop.Windows;

public static partial class SECURITY
{
    /// <include file='SECURITY.xml' path='doc/member[@name="SECURITY.SECURITY_ANONYMOUS"]/*' />
    [NativeTypeName("#define SECURITY_ANONYMOUS ( SecurityAnonymous      << 16 )")]
    public const int SECURITY_ANONYMOUS = ((int)(SecurityAnonymous) << 16);

    /// <include file='SECURITY.xml' path='doc/member[@name="SECURITY.SECURITY_IDENTIFICATION"]/*' />
    [NativeTypeName("#define SECURITY_IDENTIFICATION ( SecurityIdentification << 16 )")]
    public const int SECURITY_IDENTIFICATION = ((int)(SecurityIdentification) << 16);

    /// <include file='SECURITY.xml' path='doc/member[@name="SECURITY.SECURITY_IMPERSONATION"]/*' />
    [NativeTypeName("#define SECURITY_IMPERSONATION ( SecurityImpersonation  << 16 )")]
    public const int SECURITY_IMPERSONATION = ((int)(SecurityImpersonation) << 16);

    /// <include file='SECURITY.xml' path='doc/member[@name="SECURITY.SECURITY_DELEGATION"]/*' />
    [NativeTypeName("#define SECURITY_DELEGATION ( SecurityDelegation     << 16 )")]
    public const int SECURITY_DELEGATION = ((int)(SecurityDelegation) << 16);

    /// <include file='SECURITY.xml' path='doc/member[@name="SECURITY.SECURITY_CONTEXT_TRACKING"]/*' />
    [NativeTypeName("#define SECURITY_CONTEXT_TRACKING 0x00040000")]
    public const int SECURITY_CONTEXT_TRACKING = 0x00040000;

    /// <include file='SECURITY.xml' path='doc/member[@name="SECURITY.SECURITY_EFFECTIVE_ONLY"]/*' />
    [NativeTypeName("#define SECURITY_EFFECTIVE_ONLY 0x00080000")]
    public const int SECURITY_EFFECTIVE_ONLY = 0x00080000;

    /// <include file='SECURITY.xml' path='doc/member[@name="SECURITY.SECURITY_SQOS_PRESENT"]/*' />
    [NativeTypeName("#define SECURITY_SQOS_PRESENT 0x00100000")]
    public const int SECURITY_SQOS_PRESENT = 0x00100000;

    /// <include file='SECURITY.xml' path='doc/member[@name="SECURITY.SECURITY_VALID_SQOS_FLAGS"]/*' />
    [NativeTypeName("#define SECURITY_VALID_SQOS_FLAGS 0x001F0000")]
    public const int SECURITY_VALID_SQOS_FLAGS = 0x001F0000;
}
