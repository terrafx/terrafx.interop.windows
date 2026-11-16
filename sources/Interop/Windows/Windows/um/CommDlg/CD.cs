// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/CommDlg.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class CD
{
    /// <include file='CD.xml' path='doc/member[@name="CD.CD_LBSELNOITEMS"]/*' />
    [NativeTypeName("#define CD_LBSELNOITEMS -1")]
    public const int CD_LBSELNOITEMS = -1;

    /// <include file='CD.xml' path='doc/member[@name="CD.CD_LBSELCHANGE"]/*' />
    [NativeTypeName("#define CD_LBSELCHANGE 0")]
    public const int CD_LBSELCHANGE = 0;

    /// <include file='CD.xml' path='doc/member[@name="CD.CD_LBSELSUB"]/*' />
    [NativeTypeName("#define CD_LBSELSUB 1")]
    public const int CD_LBSELSUB = 1;

    /// <include file='CD.xml' path='doc/member[@name="CD.CD_LBSELADD"]/*' />
    [NativeTypeName("#define CD_LBSELADD 2")]
    public const int CD_LBSELADD = 2;
}
