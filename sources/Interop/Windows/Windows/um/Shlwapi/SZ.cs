// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/Shlwapi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop.Windows;

public static partial class SZ
{
    [NativeTypeName("#define SZ_CONTENTTYPE_HTMLA \"text/html\"")]
    public static ReadOnlySpan<byte> SZ_CONTENTTYPE_HTMLA => new byte[] { 0x74, 0x65, 0x78, 0x74, 0x2F, 0x68, 0x74, 0x6D, 0x6C, 0x00 };

    [NativeTypeName("#define SZ_CONTENTTYPE_HTMLW L\"text/html\"")]
    public const string SZ_CONTENTTYPE_HTMLW = "text/html";

    [NativeTypeName("#define SZ_CONTENTTYPE_CDFA \"application/x-cdf\"")]
    public static ReadOnlySpan<byte> SZ_CONTENTTYPE_CDFA => new byte[] { 0x61, 0x70, 0x70, 0x6C, 0x69, 0x63, 0x61, 0x74, 0x69, 0x6F, 0x6E, 0x2F, 0x78, 0x2D, 0x63, 0x64, 0x66, 0x00 };

    [NativeTypeName("#define SZ_CONTENTTYPE_CDFW L\"application/x-cdf\"")]
    public const string SZ_CONTENTTYPE_CDFW = "application/x-cdf";

    [NativeTypeName("#define SZ_CONTENTTYPE_HTML SZ_CONTENTTYPE_HTMLW")]
    public const string SZ_CONTENTTYPE_HTML = "text/html";

    [NativeTypeName("#define SZ_CONTENTTYPE_CDF SZ_CONTENTTYPE_CDFW")]
    public const string SZ_CONTENTTYPE_CDF = "application/x-cdf";
}
