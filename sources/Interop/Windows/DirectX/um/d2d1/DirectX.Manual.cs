// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.Windows;

namespace TerraFX.Interop.DirectX;

public static unsafe partial class DirectX
{
    public static HRESULT D2D1CreateFactory<TFactory>(D2D1_FACTORY_TYPE factoryType, void** factory)
        where TFactory : unmanaged, IUnknown.Interface
    {
        return D2D1CreateFactory(factoryType, __uuidof<TFactory>(), null, factory);
    }

    public static HRESULT D2D1CreateFactory<TFactory>(D2D1_FACTORY_TYPE factoryType, [NativeTypeName("const D2D1_FACTORY_OPTIONS *")] D2D1_FACTORY_OPTIONS* pFactoryOptions, void** factory)
        where TFactory : unmanaged, IUnknown.Interface
    {
        return D2D1CreateFactory(factoryType, __uuidof<TFactory>(), pFactoryOptions, factory);
    }
}
