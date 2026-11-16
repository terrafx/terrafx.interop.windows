// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/Uxtheme.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class SZ
{
    /// <include file='SZ.xml' path='doc/member[@name="SZ.SZ_THDOCPROP_DISPLAYNAME"]/*' />
    [NativeTypeName("#define SZ_THDOCPROP_DISPLAYNAME L\"DisplayName\"")]
    public const string SZ_THDOCPROP_DISPLAYNAME = "DisplayName";

    /// <include file='SZ.xml' path='doc/member[@name="SZ.SZ_THDOCPROP_CANONICALNAME"]/*' />
    [NativeTypeName("#define SZ_THDOCPROP_CANONICALNAME L\"ThemeName\"")]
    public const string SZ_THDOCPROP_CANONICALNAME = "ThemeName";

    /// <include file='SZ.xml' path='doc/member[@name="SZ.SZ_THDOCPROP_TOOLTIP"]/*' />
    [NativeTypeName("#define SZ_THDOCPROP_TOOLTIP L\"ToolTip\"")]
    public const string SZ_THDOCPROP_TOOLTIP = "ToolTip";

    /// <include file='SZ.xml' path='doc/member[@name="SZ.SZ_THDOCPROP_AUTHOR"]/*' />
    [NativeTypeName("#define SZ_THDOCPROP_AUTHOR L\"author\"")]
    public const string SZ_THDOCPROP_AUTHOR = "author";
}
