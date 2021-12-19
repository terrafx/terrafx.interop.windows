// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinTrust.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop.Windows;

public static unsafe partial class CAT
{
    [NativeTypeName("#define CAT_NAMEVALUE_OBJID \"1.3.6.1.4.1.311.12.2.1\"")]
    public static ReadOnlySpan<byte> CAT_NAMEVALUE_OBJID => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x31, 0x32, 0x2E, 0x32, 0x2E, 0x31, 0x00 };

    [NativeTypeName("#define CAT_MEMBERINFO_OBJID \"1.3.6.1.4.1.311.12.2.2\"")]
    public static ReadOnlySpan<byte> CAT_MEMBERINFO_OBJID => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x31, 0x32, 0x2E, 0x32, 0x2E, 0x32, 0x00 };

    [NativeTypeName("#define CAT_MEMBERINFO2_OBJID \"1.3.6.1.4.1.311.12.2.3\"")]
    public static ReadOnlySpan<byte> CAT_MEMBERINFO2_OBJID => new byte[] { 0x31, 0x2E, 0x33, 0x2E, 0x36, 0x2E, 0x31, 0x2E, 0x34, 0x2E, 0x31, 0x2E, 0x33, 0x31, 0x31, 0x2E, 0x31, 0x32, 0x2E, 0x32, 0x2E, 0x33, 0x00 };

    [NativeTypeName("#define CAT_NAMEVALUE_STRUCT ((LPCSTR) 2221)")]
    public static sbyte* CAT_NAMEVALUE_STRUCT => ((sbyte*)(2221));

    [NativeTypeName("#define CAT_MEMBERINFO_STRUCT ((LPCSTR) 2222)")]
    public static sbyte* CAT_MEMBERINFO_STRUCT => ((sbyte*)(2222));

    [NativeTypeName("#define CAT_MEMBERINFO2_STRUCT ((LPCSTR) 2223)")]
    public static sbyte* CAT_MEMBERINFO2_STRUCT => ((sbyte*)(2223));
}
