// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/guiddef.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop.Windows;

public static partial class Windows
{
    public static int IsEqualGUID([NativeTypeName("REFGUID")] Guid rguid1, [NativeTypeName("REFGUID")] Guid rguid2)
        => rguid1 == rguid2 ? 1 : 0;

    public static int IsEqualCLSID([NativeTypeName("REFCLSID")] Guid rclsid1, [NativeTypeName("REFCLSID")] Guid rclsid2)
        => IsEqualGUID(rclsid1, rclsid2);

    public static int IsEqualFMTID([NativeTypeName("REFFMTID")] Guid rfmtid1, [NativeTypeName("REFFMTID")] Guid rfmtid2)
        => IsEqualGUID(rfmtid1, rfmtid2);

    public static int IsEqualIID([NativeTypeName("REFIID")] Guid riid1, [NativeTypeName("REFIID")] Guid riid2)
        => IsEqualGUID(riid1, riid2);
}
