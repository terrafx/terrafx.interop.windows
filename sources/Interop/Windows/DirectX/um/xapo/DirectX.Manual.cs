// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/xapo.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using static TerraFX.Interop.Windows.Windows;

namespace TerraFX.Interop.DirectX
{
    public static unsafe partial class DirectX
    {
        public static void* XAPOAlloc(nuint size) => CoTaskMemAlloc(size);

        public static void XAPOFree(void* p) => CoTaskMemFree(p);
    }
}
