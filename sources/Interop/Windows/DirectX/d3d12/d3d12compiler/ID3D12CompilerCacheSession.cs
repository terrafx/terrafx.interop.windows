// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12compiler.h in microsoft/DirectX-Headers tag v1.618.5
// Original source is Copyright © Microsoft. Licensed under the MIT license

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.DirectX;

/// <include file='ID3D12CompilerCacheSession.xml' path='doc/member[@name="ID3D12CompilerCacheSession"]/*' />
[Guid("5704E5E6-054B-4738-B661-7B0D68D8DDE2")]
[NativeTypeName("struct ID3D12CompilerCacheSession : ID3D12CompilerFactoryChild")]
[NativeInheritance("ID3D12CompilerFactoryChild")]
public unsafe partial struct ID3D12CompilerCacheSession : ID3D12CompilerCacheSession.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_ID3D12CompilerCacheSession);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D12CompilerCacheSession*, Guid*, void**, int>)(lpVtbl[0]))((ID3D12CompilerCacheSession*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D12CompilerCacheSession*, uint>)(lpVtbl[1]))((ID3D12CompilerCacheSession*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D12CompilerCacheSession*, uint>)(lpVtbl[2]))((ID3D12CompilerCacheSession*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="ID3D12CompilerFactoryChild.GetFactory" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetFactory([NativeTypeName("const IID &")] Guid* riid, void** ppCompilerFactory)
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D12CompilerCacheSession*, Guid*, void**, int>)(lpVtbl[3]))((ID3D12CompilerCacheSession*)Unsafe.AsPointer(ref this), riid, ppCompilerFactory);
    }

    /// <include file='ID3D12CompilerCacheSession.xml' path='doc/member[@name="ID3D12CompilerCacheSession.FindGroup"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT FindGroup([NativeTypeName("const D3D12_COMPILER_CACHE_GROUP_KEY *")] D3D12_COMPILER_CACHE_GROUP_KEY* pGroupKey, uint* pGroupVersion)
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D12CompilerCacheSession*, D3D12_COMPILER_CACHE_GROUP_KEY*, uint*, int>)(lpVtbl[4]))((ID3D12CompilerCacheSession*)Unsafe.AsPointer(ref this), pGroupKey, pGroupVersion);
    }

    /// <include file='ID3D12CompilerCacheSession.xml' path='doc/member[@name="ID3D12CompilerCacheSession.FindGroupValueKeys"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT FindGroupValueKeys([NativeTypeName("const D3D12_COMPILER_CACHE_GROUP_KEY *")] D3D12_COMPILER_CACHE_GROUP_KEY* pGroupKey, [NativeTypeName("const UINT *")] uint* pExpectedGroupVersion, [NativeTypeName("D3D12CompilerCacheSessionGroupValueKeysFunc")] delegate* unmanaged<D3D12_COMPILER_CACHE_VALUE_KEY*, void*, void> CallbackFunc, void* pContext)
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D12CompilerCacheSession*, D3D12_COMPILER_CACHE_GROUP_KEY*, uint*, delegate* unmanaged<D3D12_COMPILER_CACHE_VALUE_KEY*, void*, void>, void*, int>)(lpVtbl[5]))((ID3D12CompilerCacheSession*)Unsafe.AsPointer(ref this), pGroupKey, pExpectedGroupVersion, CallbackFunc, pContext);
    }

    /// <include file='ID3D12CompilerCacheSession.xml' path='doc/member[@name="ID3D12CompilerCacheSession.FindGroupValues"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT FindGroupValues([NativeTypeName("const D3D12_COMPILER_CACHE_GROUP_KEY *")] D3D12_COMPILER_CACHE_GROUP_KEY* pGroupKey, [NativeTypeName("const UINT *")] uint* pExpectedGroupVersion, D3D12_COMPILER_VALUE_TYPE_FLAGS ValueTypeFlags, [NativeTypeName("D3D12CompilerCacheSessionGroupValuesFunc")] delegate* unmanaged<uint, D3D12_COMPILER_CACHE_TYPED_CONST_VALUE*, void*, void> CallbackFunc, void* pContext)
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D12CompilerCacheSession*, D3D12_COMPILER_CACHE_GROUP_KEY*, uint*, D3D12_COMPILER_VALUE_TYPE_FLAGS, delegate* unmanaged<uint, D3D12_COMPILER_CACHE_TYPED_CONST_VALUE*, void*, void>, void*, int>)(lpVtbl[6]))((ID3D12CompilerCacheSession*)Unsafe.AsPointer(ref this), pGroupKey, pExpectedGroupVersion, ValueTypeFlags, CallbackFunc, pContext);
    }

    /// <include file='ID3D12CompilerCacheSession.xml' path='doc/member[@name="ID3D12CompilerCacheSession.FindValue"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT FindValue([NativeTypeName("const D3D12_COMPILER_CACHE_VALUE_KEY *")] D3D12_COMPILER_CACHE_VALUE_KEY* pValueKey, D3D12_COMPILER_CACHE_TYPED_VALUE* pTypedValues, uint NumTypedValues, [NativeTypeName("D3D12CompilerCacheSessionAllocationFunc")] delegate* unmanaged<nuint, void*, void*> pCallbackFunc, void* pContext)
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D12CompilerCacheSession*, D3D12_COMPILER_CACHE_VALUE_KEY*, D3D12_COMPILER_CACHE_TYPED_VALUE*, uint, delegate* unmanaged<nuint, void*, void*>, void*, int>)(lpVtbl[7]))((ID3D12CompilerCacheSession*)Unsafe.AsPointer(ref this), pValueKey, pTypedValues, NumTypedValues, pCallbackFunc, pContext);
    }

    /// <include file='ID3D12CompilerCacheSession.xml' path='doc/member[@name="ID3D12CompilerCacheSession.GetApplicationDesc"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    [return: NativeTypeName("const D3D12_APPLICATION_DESC *")]
    public D3D12_APPLICATION_DESC* GetApplicationDesc()
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D12CompilerCacheSession*, D3D12_APPLICATION_DESC*>)(lpVtbl[8]))((ID3D12CompilerCacheSession*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ID3D12CompilerCacheSession.xml' path='doc/member[@name="ID3D12CompilerCacheSession.GetCompilerTarget"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public D3D12_COMPILER_TARGET GetCompilerTarget()
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D12CompilerCacheSession*, D3D12_COMPILER_TARGET>)(lpVtbl[9]))((ID3D12CompilerCacheSession*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ID3D12CompilerCacheSession.xml' path='doc/member[@name="ID3D12CompilerCacheSession.GetValueTypes"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public D3D12_COMPILER_VALUE_TYPE_FLAGS GetValueTypes()
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D12CompilerCacheSession*, D3D12_COMPILER_VALUE_TYPE_FLAGS>)(lpVtbl[10]))((ID3D12CompilerCacheSession*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ID3D12CompilerCacheSession.xml' path='doc/member[@name="ID3D12CompilerCacheSession.StoreGroupValueKeys"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT StoreGroupValueKeys([NativeTypeName("const D3D12_COMPILER_CACHE_GROUP_KEY *")] D3D12_COMPILER_CACHE_GROUP_KEY* pGroupKey, uint GroupVersion, [NativeTypeName("const D3D12_COMPILER_CACHE_VALUE_KEY *")] D3D12_COMPILER_CACHE_VALUE_KEY* pValueKeys, uint NumValueKeys)
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D12CompilerCacheSession*, D3D12_COMPILER_CACHE_GROUP_KEY*, uint, D3D12_COMPILER_CACHE_VALUE_KEY*, uint, int>)(lpVtbl[11]))((ID3D12CompilerCacheSession*)Unsafe.AsPointer(ref this), pGroupKey, GroupVersion, pValueKeys, NumValueKeys);
    }

    /// <include file='ID3D12CompilerCacheSession.xml' path='doc/member[@name="ID3D12CompilerCacheSession.StoreValue"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT StoreValue([NativeTypeName("const D3D12_COMPILER_CACHE_VALUE_KEY *")] D3D12_COMPILER_CACHE_VALUE_KEY* pValueKey, [NativeTypeName("const D3D12_COMPILER_CACHE_TYPED_CONST_VALUE *")] D3D12_COMPILER_CACHE_TYPED_CONST_VALUE* pTypedValues, uint NumTypedValues)
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D12CompilerCacheSession*, D3D12_COMPILER_CACHE_VALUE_KEY*, D3D12_COMPILER_CACHE_TYPED_CONST_VALUE*, uint, int>)(lpVtbl[12]))((ID3D12CompilerCacheSession*)Unsafe.AsPointer(ref this), pValueKey, pTypedValues, NumTypedValues);
    }

    public interface Interface : ID3D12CompilerFactoryChild.Interface
    {
        [VtblIndex(4)]
        HRESULT FindGroup([NativeTypeName("const D3D12_COMPILER_CACHE_GROUP_KEY *")] D3D12_COMPILER_CACHE_GROUP_KEY* pGroupKey, uint* pGroupVersion);

        [VtblIndex(8)]
        [return: NativeTypeName("const D3D12_APPLICATION_DESC *")]
        D3D12_APPLICATION_DESC* GetApplicationDesc();

        [VtblIndex(9)]
        D3D12_COMPILER_TARGET GetCompilerTarget();

        [VtblIndex(10)]
        D3D12_COMPILER_VALUE_TYPE_FLAGS GetValueTypes();

        [VtblIndex(11)]
        HRESULT StoreGroupValueKeys([NativeTypeName("const D3D12_COMPILER_CACHE_GROUP_KEY *")] D3D12_COMPILER_CACHE_GROUP_KEY* pGroupKey, uint GroupVersion, [NativeTypeName("const D3D12_COMPILER_CACHE_VALUE_KEY *")] D3D12_COMPILER_CACHE_VALUE_KEY* pValueKeys, uint NumValueKeys);

        [VtblIndex(12)]
        HRESULT StoreValue([NativeTypeName("const D3D12_COMPILER_CACHE_VALUE_KEY *")] D3D12_COMPILER_CACHE_VALUE_KEY* pValueKey, [NativeTypeName("const D3D12_COMPILER_CACHE_TYPED_CONST_VALUE *")] D3D12_COMPILER_CACHE_TYPED_CONST_VALUE* pTypedValues, uint NumTypedValues);
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

        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, void**, int> GetFactory;

        [NativeTypeName("HRESULT (const D3D12_COMPILER_CACHE_GROUP_KEY *, UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, D3D12_COMPILER_CACHE_GROUP_KEY*, uint*, int> FindGroup;

        [NativeTypeName("HRESULT (const D3D12_COMPILER_CACHE_GROUP_KEY *, const UINT *, D3D12CompilerCacheSessionGroupValueKeysFunc, void *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, D3D12_COMPILER_CACHE_GROUP_KEY*, uint*, delegate* unmanaged<D3D12_COMPILER_CACHE_VALUE_KEY*, void*, void>, void*, int> FindGroupValueKeys;

        [NativeTypeName("HRESULT (const D3D12_COMPILER_CACHE_GROUP_KEY *, const UINT *, D3D12_COMPILER_VALUE_TYPE_FLAGS, D3D12CompilerCacheSessionGroupValuesFunc, void *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, D3D12_COMPILER_CACHE_GROUP_KEY*, uint*, D3D12_COMPILER_VALUE_TYPE_FLAGS, delegate* unmanaged<uint, D3D12_COMPILER_CACHE_TYPED_CONST_VALUE*, void*, void>, void*, int> FindGroupValues;

        [NativeTypeName("HRESULT (const D3D12_COMPILER_CACHE_VALUE_KEY *, D3D12_COMPILER_CACHE_TYPED_VALUE *, UINT, D3D12CompilerCacheSessionAllocationFunc, void *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, D3D12_COMPILER_CACHE_VALUE_KEY*, D3D12_COMPILER_CACHE_TYPED_VALUE*, uint, delegate* unmanaged<nuint, void*, void*>, void*, int> FindValue;

        [NativeTypeName("const D3D12_APPLICATION_DESC *() __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, D3D12_APPLICATION_DESC*> GetApplicationDesc;

        [NativeTypeName("D3D12_COMPILER_TARGET () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, D3D12_COMPILER_TARGET> GetCompilerTarget;

        [NativeTypeName("D3D12_COMPILER_VALUE_TYPE_FLAGS () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, D3D12_COMPILER_VALUE_TYPE_FLAGS> GetValueTypes;

        [NativeTypeName("HRESULT (const D3D12_COMPILER_CACHE_GROUP_KEY *, UINT, const D3D12_COMPILER_CACHE_VALUE_KEY *, UINT) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, D3D12_COMPILER_CACHE_GROUP_KEY*, uint, D3D12_COMPILER_CACHE_VALUE_KEY*, uint, int> StoreGroupValueKeys;

        [NativeTypeName("HRESULT (const D3D12_COMPILER_CACHE_VALUE_KEY *, const D3D12_COMPILER_CACHE_TYPED_CONST_VALUE *, UINT) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, D3D12_COMPILER_CACHE_VALUE_KEY*, D3D12_COMPILER_CACHE_TYPED_CONST_VALUE*, uint, int> StoreValue;
    }
}
