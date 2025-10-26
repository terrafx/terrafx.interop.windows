// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from DirectML.h in microsoft/DirectX-Headers tag v1.618.2
// Original source is Copyright © Microsoft. Licensed under the MIT license

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.DirectX;

/// <include file='IDMLDeviceChild.xml' path='doc/member[@name="IDMLDeviceChild"]/*' />
[Guid("27E83142-8165-49E3-974E-2FD66E4CB69D")]
[NativeTypeName("struct IDMLDeviceChild : IDMLObject")]
[NativeInheritance("IDMLObject")]
public unsafe partial struct IDMLDeviceChild : IDMLDeviceChild.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IDMLDeviceChild);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IDMLDeviceChild*, Guid*, void**, int>)(lpVtbl[0]))((IDMLDeviceChild*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IDMLDeviceChild*, uint>)(lpVtbl[1]))((IDMLDeviceChild*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IDMLDeviceChild*, uint>)(lpVtbl[2]))((IDMLDeviceChild*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IDMLObject.GetPrivateData" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetPrivateData([NativeTypeName("const GUID &")] Guid* guid, uint* dataSize, void* data)
    {
        return ((delegate* unmanaged[MemberFunction]<IDMLDeviceChild*, Guid*, uint*, void*, int>)(lpVtbl[3]))((IDMLDeviceChild*)Unsafe.AsPointer(ref this), guid, dataSize, data);
    }

    /// <inheritdoc cref="IDMLObject.SetPrivateData" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetPrivateData([NativeTypeName("const GUID &")] Guid* guid, uint dataSize, [NativeTypeName("const void *")] void* data)
    {
        return ((delegate* unmanaged[MemberFunction]<IDMLDeviceChild*, Guid*, uint, void*, int>)(lpVtbl[4]))((IDMLDeviceChild*)Unsafe.AsPointer(ref this), guid, dataSize, data);
    }

    /// <inheritdoc cref="IDMLObject.SetPrivateDataInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SetPrivateDataInterface([NativeTypeName("const GUID &")] Guid* guid, IUnknown* data)
    {
        return ((delegate* unmanaged[MemberFunction]<IDMLDeviceChild*, Guid*, IUnknown*, int>)(lpVtbl[5]))((IDMLDeviceChild*)Unsafe.AsPointer(ref this), guid, data);
    }

    /// <inheritdoc cref="IDMLObject.SetName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT SetName([NativeTypeName("PCWSTR")] char* name)
    {
        return ((delegate* unmanaged[MemberFunction]<IDMLDeviceChild*, char*, int>)(lpVtbl[6]))((IDMLDeviceChild*)Unsafe.AsPointer(ref this), name);
    }

    /// <include file='IDMLDeviceChild.xml' path='doc/member[@name="IDMLDeviceChild.GetDevice"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetDevice([NativeTypeName("const IID &")] Guid* riid, void** ppv)
    {
        return ((delegate* unmanaged[MemberFunction]<IDMLDeviceChild*, Guid*, void**, int>)(lpVtbl[7]))((IDMLDeviceChild*)Unsafe.AsPointer(ref this), riid, ppv);
    }

    public interface Interface : IDMLObject.Interface
    {
        [VtblIndex(7)]
        HRESULT GetDevice([NativeTypeName("const IID &")] Guid* riid, void** ppv);
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

        [NativeTypeName("HRESULT (const GUID &, UINT *, void *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, uint*, void*, int> GetPrivateData;

        [NativeTypeName("HRESULT (const GUID &, UINT, const void *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, uint, void*, int> SetPrivateData;

        [NativeTypeName("HRESULT (const GUID &, IUnknown *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, IUnknown*, int> SetPrivateDataInterface;

        [NativeTypeName("HRESULT (PCWSTR) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, int> SetName;

        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, void**, int> GetDevice;
    }
}
