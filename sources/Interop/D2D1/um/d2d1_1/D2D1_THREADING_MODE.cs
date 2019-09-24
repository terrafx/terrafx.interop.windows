// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d2d1_1.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using static TerraFX.Interop.D2D1_FACTORY_TYPE;

namespace TerraFX.Interop
{
    /// <summary>This specifies the threading mode used while simultaneously creating the device, factory, and device context.</summary>
    public enum D2D1_THREADING_MODE : uint
    {
        /// <summary>Resources may only be invoked serially.  Reference counts on resources are interlocked, however, resource and render target state is not protected from multi-threaded access</summary>
        D2D1_THREADING_MODE_SINGLE_THREADED = D2D1_FACTORY_TYPE_SINGLE_THREADED,

        /// <summary>Resources may be invoked from multiple threads. Resources use interlocked reference counting and their state is protected.</summary>
        D2D1_THREADING_MODE_MULTI_THREADED = D2D1_FACTORY_TYPE_MULTI_THREADED,

        D2D1_THREADING_MODE_FORCE_DWORD = 0xFFFFFFFF
    }
}
