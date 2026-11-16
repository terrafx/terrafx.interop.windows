// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class DT
{
    /// <include file='DT.xml' path='doc/member[@name="DT.DT_PLOTTER"]/*' />
    [NativeTypeName("#define DT_PLOTTER 0")]
    public const int DT_PLOTTER = 0;

    /// <include file='DT.xml' path='doc/member[@name="DT.DT_RASDISPLAY"]/*' />
    [NativeTypeName("#define DT_RASDISPLAY 1")]
    public const int DT_RASDISPLAY = 1;

    /// <include file='DT.xml' path='doc/member[@name="DT.DT_RASPRINTER"]/*' />
    [NativeTypeName("#define DT_RASPRINTER 2")]
    public const int DT_RASPRINTER = 2;

    /// <include file='DT.xml' path='doc/member[@name="DT.DT_RASCAMERA"]/*' />
    [NativeTypeName("#define DT_RASCAMERA 3")]
    public const int DT_RASCAMERA = 3;

    /// <include file='DT.xml' path='doc/member[@name="DT.DT_CHARSTREAM"]/*' />
    [NativeTypeName("#define DT_CHARSTREAM 4")]
    public const int DT_CHARSTREAM = 4;

    /// <include file='DT.xml' path='doc/member[@name="DT.DT_METAFILE"]/*' />
    [NativeTypeName("#define DT_METAFILE 5")]
    public const int DT_METAFILE = 5;

    /// <include file='DT.xml' path='doc/member[@name="DT.DT_DISPFILE"]/*' />
    [NativeTypeName("#define DT_DISPFILE 6")]
    public const int DT_DISPFILE = 6;
}
