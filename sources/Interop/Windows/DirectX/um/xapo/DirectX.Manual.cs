// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/xapo.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using static TerraFX.Interop.Windows.Windows;

namespace TerraFX.Interop.DirectX;

public static unsafe partial class DirectX
{
    /// <include file='DirectX.xml' path='doc/member[@name="DirectX.XAPOAlloc"]/*' />
    public static void* XAPOAlloc(nuint size) => CoTaskMemAlloc(size);

    /// <include file='DirectX.xml' path='doc/member[@name="DirectX.XAPOFree"]/*' />
    public static void XAPOFree(void* p) => CoTaskMemFree(p);
}
