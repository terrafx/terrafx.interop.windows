// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SrRestorePtApi.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class MAX
{
    /// <include file='MAX.xml' path='doc/member[@name="MAX.MAX_EVENT"]/*' />
    [NativeTypeName("#define MAX_EVENT 104")]
    public const int MAX_EVENT = 104;

    /// <include file='MAX.xml' path='doc/member[@name="MAX.MAX_RPT"]/*' />
    [NativeTypeName("#define MAX_RPT 18")]
    public const int MAX_RPT = 18;

    /// <include file='MAX.xml' path='doc/member[@name="MAX.MAX_DESC"]/*' />
    [NativeTypeName("#define MAX_DESC 64")]
    public const int MAX_DESC = 64;

    /// <include file='MAX.xml' path='doc/member[@name="MAX.MAX_DESC_W"]/*' />
    [NativeTypeName("#define MAX_DESC_W 256")]
    public const int MAX_DESC_W = 256;
}
