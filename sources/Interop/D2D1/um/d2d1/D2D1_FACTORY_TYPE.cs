// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d2d1.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    /// <summary>Specifies the threading model of the created factory and all of its derived resources.</summary>
    public enum D2D1_FACTORY_TYPE : uint
    {
        /// <summary>The resulting factory and derived resources may only be invoked serially. Reference counts on resources are interlocked, however, resource and render target state is not protected from multi-threaded access.</summary>
        D2D1_FACTORY_TYPE_SINGLE_THREADED = 0,

        /// <summary>The resulting factory may be invoked from multiple threads. Returned resources use interlocked reference counting and their state is protected.</summary>
        D2D1_FACTORY_TYPE_MULTI_THREADED = 1,

        D2D1_FACTORY_TYPE_FORCE_DWORD = 0xFFFFFFFF
    }
}
