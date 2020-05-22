// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class D3D12
    {
        private const string LibraryPath = "D3D12";

        [DllImport(LibraryPath, CallingConvention = CallingConvention.StdCall, EntryPoint = "D3D12SerializeRootSignature", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int D3D12SerializeRootSignature([NativeTypeName("const D3D12_ROOT_SIGNATURE_DESC *")] D3D12_ROOT_SIGNATURE_DESC* pRootSignature, D3D_ROOT_SIGNATURE_VERSION Version, [NativeTypeName("ID3DBlob **")] ID3DBlob** ppBlob, [NativeTypeName("ID3DBlob **")] ID3DBlob** ppErrorBlob);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.StdCall, EntryPoint = "D3D12CreateRootSignatureDeserializer", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int D3D12CreateRootSignatureDeserializer([NativeTypeName("LPCVOID")] void* pSrcData, [NativeTypeName("SIZE_T")] nuint SrcDataSizeInBytes, [NativeTypeName("const IID &")] Guid* pRootSignatureDeserializerInterface, [NativeTypeName("void **")] void** ppRootSignatureDeserializer);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.StdCall, EntryPoint = "D3D12SerializeVersionedRootSignature", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int D3D12SerializeVersionedRootSignature([NativeTypeName("const D3D12_VERSIONED_ROOT_SIGNATURE_DESC *")] D3D12_VERSIONED_ROOT_SIGNATURE_DESC* pRootSignature, [NativeTypeName("ID3DBlob **")] ID3DBlob** ppBlob, [NativeTypeName("ID3DBlob **")] ID3DBlob** ppErrorBlob);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.StdCall, EntryPoint = "D3D12CreateVersionedRootSignatureDeserializer", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int D3D12CreateVersionedRootSignatureDeserializer([NativeTypeName("LPCVOID")] void* pSrcData, [NativeTypeName("SIZE_T")] nuint SrcDataSizeInBytes, [NativeTypeName("const IID &")] Guid* pRootSignatureDeserializerInterface, [NativeTypeName("void **")] void** ppRootSignatureDeserializer);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.StdCall, EntryPoint = "D3D12CreateDevice", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int D3D12CreateDevice([NativeTypeName("IUnknown *")] IUnknown* pAdapter, D3D_FEATURE_LEVEL MinimumFeatureLevel, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppDevice);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.StdCall, EntryPoint = "D3D12GetDebugInterface", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int D3D12GetDebugInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvDebug);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.StdCall, EntryPoint = "D3D12EnableExperimentalFeatures", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int D3D12EnableExperimentalFeatures([NativeTypeName("UINT")] uint NumFeatures, [NativeTypeName("const IID *")] Guid* pIIDs, [NativeTypeName("void *")] void* pConfigurationStructs, [NativeTypeName("UINT *")] uint* pConfigurationStructSizes);
    }
}
