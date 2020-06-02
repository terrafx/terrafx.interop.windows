// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/DirectML.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Windows
    {
        [DllImport("DirectML", EntryPoint = "DMLCreateDevice", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int DMLCreateDevice([NativeTypeName("ID3D12Device *")] ID3D12Device* d3d12Device, DML_CREATE_DEVICE_FLAGS flags, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppv);

        [DllImport("DirectML", EntryPoint = "DMLCreateDevice1", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int DMLCreateDevice1([NativeTypeName("ID3D12Device *")] ID3D12Device* d3d12Device, DML_CREATE_DEVICE_FLAGS flags, DML_FEATURE_LEVEL minimumFeatureLevel, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppv);
    }
}
