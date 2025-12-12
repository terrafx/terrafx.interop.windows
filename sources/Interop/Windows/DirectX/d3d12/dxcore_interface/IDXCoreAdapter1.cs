// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from dxcore_interface.h in microsoft/DirectX-Headers tag v1.618.5
// Original source is Copyright © Microsoft. Licensed under the MIT license

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.DirectX;

/// <include file='IDXCoreAdapter1.xml' path='doc/member[@name="IDXCoreAdapter1"]/*' />
[Guid("A0783366-CFA3-43BE-9D79-55B2DA97C63C")]
[NativeTypeName("struct IDXCoreAdapter1 : IDXCoreAdapter")]
[NativeInheritance("IDXCoreAdapter")]
public unsafe partial struct IDXCoreAdapter1 : IDXCoreAdapter1.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IDXCoreAdapter1);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IDXCoreAdapter1*, Guid*, void**, int>)(lpVtbl[0]))((IDXCoreAdapter1*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IDXCoreAdapter1*, uint>)(lpVtbl[1]))((IDXCoreAdapter1*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IDXCoreAdapter1*, uint>)(lpVtbl[2]))((IDXCoreAdapter1*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IDXCoreAdapter.IsValid" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public bool IsValid()
    {
        return ((delegate* unmanaged[MemberFunction]<IDXCoreAdapter1*, bool>)(lpVtbl[3]))((IDXCoreAdapter1*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IDXCoreAdapter.IsAttributeSupported" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public bool IsAttributeSupported([NativeTypeName("const GUID &")] Guid* attributeGUID)
    {
        return ((delegate* unmanaged[MemberFunction]<IDXCoreAdapter1*, Guid*, bool>)(lpVtbl[4]))((IDXCoreAdapter1*)Unsafe.AsPointer(ref this), attributeGUID);
    }

    /// <inheritdoc cref="IDXCoreAdapter.IsPropertySupported" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public bool IsPropertySupported(DXCoreAdapterProperty property)
    {
        return ((delegate* unmanaged[MemberFunction]<IDXCoreAdapter1*, DXCoreAdapterProperty, bool>)(lpVtbl[5]))((IDXCoreAdapter1*)Unsafe.AsPointer(ref this), property);
    }

    /// <inheritdoc cref="IDXCoreAdapter.GetProperty" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetProperty(DXCoreAdapterProperty property, [NativeTypeName("size_t")] nuint bufferSize, void* propertyData)
    {
        return ((delegate* unmanaged[MemberFunction]<IDXCoreAdapter1*, DXCoreAdapterProperty, nuint, void*, int>)(lpVtbl[6]))((IDXCoreAdapter1*)Unsafe.AsPointer(ref this), property, bufferSize, propertyData);
    }

    /// <inheritdoc cref="IDXCoreAdapter.GetPropertySize" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetPropertySize(DXCoreAdapterProperty property, [NativeTypeName("size_t *")] nuint* bufferSize)
    {
        return ((delegate* unmanaged[MemberFunction]<IDXCoreAdapter1*, DXCoreAdapterProperty, nuint*, int>)(lpVtbl[7]))((IDXCoreAdapter1*)Unsafe.AsPointer(ref this), property, bufferSize);
    }

    /// <inheritdoc cref="IDXCoreAdapter.IsQueryStateSupported" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public bool IsQueryStateSupported(DXCoreAdapterState property)
    {
        return ((delegate* unmanaged[MemberFunction]<IDXCoreAdapter1*, DXCoreAdapterState, bool>)(lpVtbl[8]))((IDXCoreAdapter1*)Unsafe.AsPointer(ref this), property);
    }

    /// <inheritdoc cref="IDXCoreAdapter.QueryState" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT QueryState(DXCoreAdapterState state, [NativeTypeName("size_t")] nuint inputStateDetailsSize, [NativeTypeName("const void *")] void* inputStateDetails, [NativeTypeName("size_t")] nuint outputBufferSize, void* outputBuffer)
    {
        return ((delegate* unmanaged[MemberFunction]<IDXCoreAdapter1*, DXCoreAdapterState, nuint, void*, nuint, void*, int>)(lpVtbl[9]))((IDXCoreAdapter1*)Unsafe.AsPointer(ref this), state, inputStateDetailsSize, inputStateDetails, outputBufferSize, outputBuffer);
    }

    /// <inheritdoc cref="IDXCoreAdapter.IsSetStateSupported" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public bool IsSetStateSupported(DXCoreAdapterState property)
    {
        return ((delegate* unmanaged[MemberFunction]<IDXCoreAdapter1*, DXCoreAdapterState, bool>)(lpVtbl[10]))((IDXCoreAdapter1*)Unsafe.AsPointer(ref this), property);
    }

    /// <inheritdoc cref="IDXCoreAdapter.SetState" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT SetState(DXCoreAdapterState state, [NativeTypeName("size_t")] nuint inputStateDetailsSize, [NativeTypeName("const void *")] void* inputStateDetails, [NativeTypeName("size_t")] nuint inputDataSize, [NativeTypeName("const void *")] void* inputData)
    {
        return ((delegate* unmanaged[MemberFunction]<IDXCoreAdapter1*, DXCoreAdapterState, nuint, void*, nuint, void*, int>)(lpVtbl[11]))((IDXCoreAdapter1*)Unsafe.AsPointer(ref this), state, inputStateDetailsSize, inputStateDetails, inputDataSize, inputData);
    }

    /// <inheritdoc cref="IDXCoreAdapter.GetFactory" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT GetFactory([NativeTypeName("const IID &")] Guid* riid, void** ppvFactory)
    {
        return ((delegate* unmanaged[MemberFunction]<IDXCoreAdapter1*, Guid*, void**, int>)(lpVtbl[12]))((IDXCoreAdapter1*)Unsafe.AsPointer(ref this), riid, ppvFactory);
    }

    /// <include file='IDXCoreAdapter1.xml' path='doc/member[@name="IDXCoreAdapter1.GetPropertyWithInput"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT GetPropertyWithInput(DXCoreAdapterProperty property, [NativeTypeName("size_t")] nuint inputPropertyDetailsSize, [NativeTypeName("const void *")] void* inputPropertyDetails, [NativeTypeName("size_t")] nuint outputBufferSize, void* outputBuffer)
    {
        return ((delegate* unmanaged[MemberFunction]<IDXCoreAdapter1*, DXCoreAdapterProperty, nuint, void*, nuint, void*, int>)(lpVtbl[13]))((IDXCoreAdapter1*)Unsafe.AsPointer(ref this), property, inputPropertyDetailsSize, inputPropertyDetails, outputBufferSize, outputBuffer);
    }

    public interface Interface : IDXCoreAdapter.Interface
    {
        [VtblIndex(13)]
        HRESULT GetPropertyWithInput(DXCoreAdapterProperty property, [NativeTypeName("size_t")] nuint inputPropertyDetailsSize, [NativeTypeName("const void *")] void* inputPropertyDetails, [NativeTypeName("size_t")] nuint outputBufferSize, void* outputBuffer);
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

        [NativeTypeName("bool () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, bool> IsValid;

        [NativeTypeName("bool (const GUID &) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, bool> IsAttributeSupported;

        [NativeTypeName("bool (DXCoreAdapterProperty) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, DXCoreAdapterProperty, bool> IsPropertySupported;

        [NativeTypeName("HRESULT (DXCoreAdapterProperty, size_t, void *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, DXCoreAdapterProperty, nuint, void*, int> GetProperty;

        [NativeTypeName("HRESULT (DXCoreAdapterProperty, size_t *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, DXCoreAdapterProperty, nuint*, int> GetPropertySize;

        [NativeTypeName("bool (DXCoreAdapterState) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, DXCoreAdapterState, bool> IsQueryStateSupported;

        [NativeTypeName("HRESULT (DXCoreAdapterState, size_t, const void *, size_t, void *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, DXCoreAdapterState, nuint, void*, nuint, void*, int> QueryState;

        [NativeTypeName("bool (DXCoreAdapterState) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, DXCoreAdapterState, bool> IsSetStateSupported;

        [NativeTypeName("HRESULT (DXCoreAdapterState, size_t, const void *, size_t, const void *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, DXCoreAdapterState, nuint, void*, nuint, void*, int> SetState;

        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, void**, int> GetFactory;

        [NativeTypeName("HRESULT (DXCoreAdapterProperty, size_t, const void *, size_t, void *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, DXCoreAdapterProperty, nuint, void*, nuint, void*, int> GetPropertyWithInput;
    }
}
