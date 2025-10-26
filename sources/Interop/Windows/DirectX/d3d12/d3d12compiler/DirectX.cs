// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12compiler.h in microsoft/DirectX-Headers tag v1.618.2
// Original source is Copyright © Microsoft. Licensed under the MIT license

using System;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;

namespace TerraFX.Interop.DirectX;

public static unsafe partial class DirectX
{
    /// <include file='DirectX.xml' path='doc/member[@name="DirectX.D3D12CompilerCreateFactory"]/*' />
    [DllImport("d3d12stateobjectcompiler", ExactSpelling = true)]
    public static extern HRESULT D3D12CompilerCreateFactory([NativeTypeName("LPCWSTR")] char* pPluginCompilerDllPath, [NativeTypeName("const IID &")] Guid* riid, void** ppFactory);

    /// <include file='DirectX.xml' path='doc/member[@name="DirectX.D3D12CompilerSerializeVersionedRootSignature"]/*' />
    [DllImport("d3d12stateobjectcompiler", ExactSpelling = true)]
    public static extern HRESULT D3D12CompilerSerializeVersionedRootSignature([NativeTypeName("const D3D12_VERSIONED_ROOT_SIGNATURE_DESC *")] D3D12_VERSIONED_ROOT_SIGNATURE_DESC* pRootSignature, ID3DBlob** ppBlob, ID3DBlob** ppErrorBlob);
}
