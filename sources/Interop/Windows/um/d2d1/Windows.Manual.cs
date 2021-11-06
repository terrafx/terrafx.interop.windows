// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public static unsafe partial class Windows
    {
        public const ulong D2D1_INVALID_TAG = ULONGLONG_MAX;

        public const uint D2D1_INTERPOLATION_MODE_DEFINITION_NEAREST_NEIGHBOR = 0;

        public const uint D2D1_INTERPOLATION_MODE_DEFINITION_LINEAR = 1;

        public const uint D2D1_INTERPOLATION_MODE_DEFINITION_CUBIC = 2;

        public const uint D2D1_INTERPOLATION_MODE_DEFINITION_MULTI_SAMPLE_LINEAR = 3;

        public const uint D2D1_INTERPOLATION_MODE_DEFINITION_ANISOTROPIC = 4;

        public const uint D2D1_INTERPOLATION_MODE_DEFINITION_HIGH_QUALITY_CUBIC = 5;

        public const uint D2D1_INTERPOLATION_MODE_DEFINITION_FANT = 6;

        public const uint D2D1_INTERPOLATION_MODE_DEFINITION_MIPMAP_LINEAR = 7;

        public static HRESULT D2D1CreateFactory<Factory>(D2D1_FACTORY_TYPE factoryType, void** factory)
            where Factory : unmanaged, IUnknown.Interface
        {
            return D2D1CreateFactory(factoryType, __uuidof<Factory>(), null, factory);
        }

        public static HRESULT D2D1CreateFactory<Factory>(D2D1_FACTORY_TYPE factoryType, [NativeTypeName("const D2D1_FACTORY_OPTIONS *")] D2D1_FACTORY_OPTIONS* pFactoryOptions, void** factory)
            where Factory : unmanaged, IUnknown.Interface
        {
            return D2D1CreateFactory(factoryType, __uuidof<Factory>(), pFactoryOptions, factory);
        }
    }
}
