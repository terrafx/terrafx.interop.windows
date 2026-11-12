// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.620.2
// Original source is Copyright © Microsoft. Licensed under the MIT license

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.DirectX;

/// <include file='ID3D12ShaderCacheSession1.xml' path='doc/member[@name="ID3D12ShaderCacheSession1"]/*' />
[Guid("1C5789FF-9203-490F-B971-984ACF1EB5FE")]
[NativeTypeName("struct ID3D12ShaderCacheSession1 : ID3D12ShaderCacheSession")]
[NativeInheritance("ID3D12ShaderCacheSession")]
public unsafe partial struct ID3D12ShaderCacheSession1 : ID3D12ShaderCacheSession1.Interface, INativeGuid
{
    /// <include file='ID3D12ShaderCacheSession1.xml' path='doc/member[@name="ID3D12ShaderCacheSession1.INativeGuid.NativeGuid"]/*' />
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_ID3D12ShaderCacheSession1);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D12ShaderCacheSession1*, Guid*, void**, int>)(lpVtbl[0]))((ID3D12ShaderCacheSession1*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D12ShaderCacheSession1*, uint>)(lpVtbl[1]))((ID3D12ShaderCacheSession1*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D12ShaderCacheSession1*, uint>)(lpVtbl[2]))((ID3D12ShaderCacheSession1*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="ID3D12Object.GetPrivateData" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetPrivateData([NativeTypeName("const GUID &")] Guid* guid, uint* pDataSize, void* pData)
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D12ShaderCacheSession1*, Guid*, uint*, void*, int>)(lpVtbl[3]))((ID3D12ShaderCacheSession1*)Unsafe.AsPointer(ref this), guid, pDataSize, pData);
    }

    /// <inheritdoc cref="ID3D12Object.SetPrivateData" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetPrivateData([NativeTypeName("const GUID &")] Guid* guid, uint DataSize, [NativeTypeName("const void *")] void* pData)
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D12ShaderCacheSession1*, Guid*, uint, void*, int>)(lpVtbl[4]))((ID3D12ShaderCacheSession1*)Unsafe.AsPointer(ref this), guid, DataSize, pData);
    }

    /// <inheritdoc cref="ID3D12Object.SetPrivateDataInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SetPrivateDataInterface([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("const IUnknown *")] IUnknown* pData)
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D12ShaderCacheSession1*, Guid*, IUnknown*, int>)(lpVtbl[5]))((ID3D12ShaderCacheSession1*)Unsafe.AsPointer(ref this), guid, pData);
    }

    /// <inheritdoc cref="ID3D12Object.SetName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT SetName([NativeTypeName("LPCWSTR")] char* Name)
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D12ShaderCacheSession1*, char*, int>)(lpVtbl[6]))((ID3D12ShaderCacheSession1*)Unsafe.AsPointer(ref this), Name);
    }

    /// <inheritdoc cref="ID3D12DeviceChild.GetDevice" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetDevice([NativeTypeName("const IID &")] Guid* riid, void** ppvDevice)
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D12ShaderCacheSession1*, Guid*, void**, int>)(lpVtbl[7]))((ID3D12ShaderCacheSession1*)Unsafe.AsPointer(ref this), riid, ppvDevice);
    }

    /// <inheritdoc cref="ID3D12ShaderCacheSession.FindValue" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT FindValue([NativeTypeName("const void *")] void* pKey, uint KeySize, void* pValue, uint* pValueSize)
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D12ShaderCacheSession1*, void*, uint, void*, uint*, int>)(lpVtbl[8]))((ID3D12ShaderCacheSession1*)Unsafe.AsPointer(ref this), pKey, KeySize, pValue, pValueSize);
    }

    /// <inheritdoc cref="ID3D12ShaderCacheSession.StoreValue" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT StoreValue([NativeTypeName("const void *")] void* pKey, uint KeySize, [NativeTypeName("const void *")] void* pValue, uint ValueSize)
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D12ShaderCacheSession1*, void*, uint, void*, uint, int>)(lpVtbl[9]))((ID3D12ShaderCacheSession1*)Unsafe.AsPointer(ref this), pKey, KeySize, pValue, ValueSize);
    }

    /// <inheritdoc cref="ID3D12ShaderCacheSession.SetDeleteOnDestroy" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public void SetDeleteOnDestroy()
    {
        ((delegate* unmanaged[MemberFunction]<ID3D12ShaderCacheSession1*, void>)(lpVtbl[10]))((ID3D12ShaderCacheSession1*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="ID3D12ShaderCacheSession.GetDesc" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public D3D12_SHADER_CACHE_SESSION_DESC GetDesc()
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D12ShaderCacheSession1*, D3D12_SHADER_CACHE_SESSION_DESC>)(lpVtbl[11]))((ID3D12ShaderCacheSession1*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ID3D12ShaderCacheSession1.xml' path='doc/member[@name="ID3D12ShaderCacheSession1.FindValue1"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT FindValue1([NativeTypeName("const D3D12_CACHE_VALUE_KEY *")] D3D12_CACHE_VALUE_KEY* pValueKey, D3D12_CACHE_TYPED_VALUE* pTypedValues, uint NumTypedValues, [NativeTypeName("D3D12CacheSessionAllocationFunc")] delegate* unmanaged<nuint, void*, void*> pCallbackFunc, void* pContext)
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D12ShaderCacheSession1*, D3D12_CACHE_VALUE_KEY*, D3D12_CACHE_TYPED_VALUE*, uint, delegate* unmanaged<nuint, void*, void*>, void*, int>)(lpVtbl[12]))((ID3D12ShaderCacheSession1*)Unsafe.AsPointer(ref this), pValueKey, pTypedValues, NumTypedValues, pCallbackFunc, pContext);
    }

    /// <include file='ID3D12ShaderCacheSession1.xml' path='doc/member[@name="ID3D12ShaderCacheSession1.StoreValue1"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT StoreValue1([NativeTypeName("const D3D12_CACHE_VALUE_KEY *")] D3D12_CACHE_VALUE_KEY* pValueKey, [NativeTypeName("const D3D12_CACHE_TYPED_CONST_VALUE *")] D3D12_CACHE_TYPED_CONST_VALUE* pTypedValues, uint NumTypedValues, D3D12_SHADER_CACHE_STORE_FLAGS Flags)
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D12ShaderCacheSession1*, D3D12_CACHE_VALUE_KEY*, D3D12_CACHE_TYPED_CONST_VALUE*, uint, D3D12_SHADER_CACHE_STORE_FLAGS, int>)(lpVtbl[13]))((ID3D12ShaderCacheSession1*)Unsafe.AsPointer(ref this), pValueKey, pTypedValues, NumTypedValues, Flags);
    }

    /// <include file='ID3D12ShaderCacheSession1.xml' path='doc/member[@name="ID3D12ShaderCacheSession1.GetSessionInfo"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT GetSessionInfo(D3D12_SHADER_CACHE_SESSION_INFO* pInfo)
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D12ShaderCacheSession1*, D3D12_SHADER_CACHE_SESSION_INFO*, int>)(lpVtbl[14]))((ID3D12ShaderCacheSession1*)Unsafe.AsPointer(ref this), pInfo);
    }

    /// <include file='ID3D12ShaderCacheSession1.xml' path='doc/member[@name="ID3D12ShaderCacheSession1.TrimTo"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT TrimTo([NativeTypeName("UINT64")] ulong SizeBytes, D3D12_SHADER_CACHE_TRIM_FLAGS Flags)
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D12ShaderCacheSession1*, ulong, D3D12_SHADER_CACHE_TRIM_FLAGS, int>)(lpVtbl[15]))((ID3D12ShaderCacheSession1*)Unsafe.AsPointer(ref this), SizeBytes, Flags);
    }

    public interface Interface : ID3D12ShaderCacheSession.Interface
    {
        [VtblIndex(13)]
        HRESULT StoreValue1([NativeTypeName("const D3D12_CACHE_VALUE_KEY *")] D3D12_CACHE_VALUE_KEY* pValueKey, [NativeTypeName("const D3D12_CACHE_TYPED_CONST_VALUE *")] D3D12_CACHE_TYPED_CONST_VALUE* pTypedValues, uint NumTypedValues, D3D12_SHADER_CACHE_STORE_FLAGS Flags);

        [VtblIndex(14)]
        HRESULT GetSessionInfo(D3D12_SHADER_CACHE_SESSION_INFO* pInfo);

        [VtblIndex(15)]
        HRESULT TrimTo([NativeTypeName("UINT64")] ulong SizeBytes, D3D12_SHADER_CACHE_TRIM_FLAGS Flags);
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint> Release;

        [NativeTypeName("HRESULT (const GUID &, UINT *, void *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, uint*, void*, int> GetPrivateData;

        [NativeTypeName("HRESULT (const GUID &, UINT, const void *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, uint, void*, int> SetPrivateData;

        [NativeTypeName("HRESULT (const GUID &, const IUnknown *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, IUnknown*, int> SetPrivateDataInterface;

        [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, int> SetName;

        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, void**, int> GetDevice;

        [NativeTypeName("HRESULT (const void *, UINT, void *, UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, void*, uint, void*, uint*, int> FindValue;

        [NativeTypeName("HRESULT (const void *, UINT, const void *, UINT) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, void*, uint, void*, uint, int> StoreValue;

        [NativeTypeName("void () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, void> SetDeleteOnDestroy;

        [NativeTypeName("D3D12_SHADER_CACHE_SESSION_DESC () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, D3D12_SHADER_CACHE_SESSION_DESC> GetDesc;

        [NativeTypeName("HRESULT (const D3D12_CACHE_VALUE_KEY *, D3D12_CACHE_TYPED_VALUE *, UINT, D3D12CacheSessionAllocationFunc, void *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, D3D12_CACHE_VALUE_KEY*, D3D12_CACHE_TYPED_VALUE*, uint, delegate* unmanaged<nuint, void*, void*>, void*, int> FindValue1;

        [NativeTypeName("HRESULT (const D3D12_CACHE_VALUE_KEY *, const D3D12_CACHE_TYPED_CONST_VALUE *, UINT, D3D12_SHADER_CACHE_STORE_FLAGS) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, D3D12_CACHE_VALUE_KEY*, D3D12_CACHE_TYPED_CONST_VALUE*, uint, D3D12_SHADER_CACHE_STORE_FLAGS, int> StoreValue1;

        [NativeTypeName("HRESULT (D3D12_SHADER_CACHE_SESSION_INFO *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, D3D12_SHADER_CACHE_SESSION_INFO*, int> GetSessionInfo;

        [NativeTypeName("HRESULT (UINT64, D3D12_SHADER_CACHE_TRIM_FLAGS) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ulong, D3D12_SHADER_CACHE_TRIM_FLAGS, int> TrimTo;
    }
}
