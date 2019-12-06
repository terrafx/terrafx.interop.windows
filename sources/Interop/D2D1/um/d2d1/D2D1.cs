// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class D2D1
    {
        [DllImport(LibraryPath, CallingConvention = CallingConvention.StdCall, EntryPoint = "D2D1CreateFactory", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int D2D1CreateFactory(D2D1_FACTORY_TYPE factoryType, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("const D2D1_FACTORY_OPTIONS *")] D2D1_FACTORY_OPTIONS* pFactoryOptions, [NativeTypeName("void **")] void** ppIFactory);

        [return: NativeTypeName("HRESULT")]
        public static int D2D1CreateFactory(D2D1_FACTORY_TYPE factoryType, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** factory)
        {
            return D2D1CreateFactory(factoryType, riid, null, factory);
        }
    }
}
