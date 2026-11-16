// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/oleidl.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class CFSTR
{
    /// <include file='CFSTR.xml' path='doc/member[@name="CFSTR.CFSTR_ENTERPRISE_ID"]/*' />
    [NativeTypeName("#define CFSTR_ENTERPRISE_ID (TEXT(\"EnterpriseDataProtectionId\"))")]
    public const string CFSTR_ENTERPRISE_ID = ("EnterpriseDataProtectionId");
}
