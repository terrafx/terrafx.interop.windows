// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;

namespace TerraFX.Interop.DirectX;

/// <include file='ID3D12RootSignatureDeserializer.xml' path='doc/member[@name="ID3D12RootSignatureDeserializer"]/*' />
[Guid("34AB647B-3CC8-46AC-841B-C0965645C046")]
[NativeTypeName("struct ID3D12RootSignatureDeserializer : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ID3D12RootSignatureDeserializer : ID3D12RootSignatureDeserializer.Interface
{
    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ID3D12RootSignatureDeserializer*, Guid*, void**, int>)(lpVtbl[0]))((ID3D12RootSignatureDeserializer*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ID3D12RootSignatureDeserializer*, uint>)(lpVtbl[1]))((ID3D12RootSignatureDeserializer*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ID3D12RootSignatureDeserializer*, uint>)(lpVtbl[2]))((ID3D12RootSignatureDeserializer*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ID3D12RootSignatureDeserializer.xml' path='doc/member[@name="ID3D12RootSignatureDeserializer.GetRootSignatureDesc"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    [return: NativeTypeName("const D3D12_ROOT_SIGNATURE_DESC *")]
    public D3D12_ROOT_SIGNATURE_DESC* GetRootSignatureDesc()
    {
        return ((delegate* unmanaged[SuppressGCTransition]<ID3D12RootSignatureDeserializer*, D3D12_ROOT_SIGNATURE_DESC*>)(lpVtbl[3]))((ID3D12RootSignatureDeserializer*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        [return: NativeTypeName("const D3D12_ROOT_SIGNATURE_DESC *")]
        D3D12_ROOT_SIGNATURE_DESC* GetRootSignatureDesc();
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> Release;

        [NativeTypeName("const D3D12_ROOT_SIGNATURE_DESC *() __attribute__((stdcall))")]
        public delegate* unmanaged[SuppressGCTransition]<TSelf*, D3D12_ROOT_SIGNATURE_DESC*> GetRootSignatureDesc;
    }
}
