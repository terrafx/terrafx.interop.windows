// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1_1.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

using static TerraFX.Interop.D2D1_FACTORY_TYPE;

namespace TerraFX.Interop
{
    public enum D2D1_THREADING_MODE : uint
    {
        D2D1_THREADING_MODE_SINGLE_THREADED = D2D1_FACTORY_TYPE_SINGLE_THREADED,
        D2D1_THREADING_MODE_MULTI_THREADED = D2D1_FACTORY_TYPE_MULTI_THREADED,
        D2D1_THREADING_MODE_FORCE_DWORD = 0xFFFFFFFF,
    }
}
