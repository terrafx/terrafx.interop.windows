// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MSAAText.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class TS
{
    /// <include file='TS.xml' path='doc/member[@name="TS.TS_STRF_START"]/*' />
    [NativeTypeName("#define TS_STRF_START ( 0 )")]
    public const int TS_STRF_START = (0);

    /// <include file='TS.xml' path='doc/member[@name="TS.TS_STRF_MID"]/*' />
    [NativeTypeName("#define TS_STRF_MID ( 1 )")]
    public const int TS_STRF_MID = (1);

    /// <include file='TS.xml' path='doc/member[@name="TS.TS_STRF_END"]/*' />
    [NativeTypeName("#define TS_STRF_END ( 2 )")]
    public const int TS_STRF_END = (2);
}
