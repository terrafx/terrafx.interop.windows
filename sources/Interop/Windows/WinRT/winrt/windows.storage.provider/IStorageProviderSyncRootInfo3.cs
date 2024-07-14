// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.storage.provider.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IStorageProviderSyncRootInfo3.xml' path='doc/member[@name="IStorageProviderSyncRootInfo3"]/*' />
[Guid("507A6617-BEF6-56FD-855E-75ACE2E45CF5")]
[NativeTypeName("struct IStorageProviderSyncRootInfo3 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IStorageProviderSyncRootInfo3 : IStorageProviderSyncRootInfo3.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IStorageProviderSyncRootInfo3));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageProviderSyncRootInfo3*, Guid*, void**, int>)(lpVtbl[0]))((IStorageProviderSyncRootInfo3*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageProviderSyncRootInfo3*, uint>)(lpVtbl[1]))((IStorageProviderSyncRootInfo3*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageProviderSyncRootInfo3*, uint>)(lpVtbl[2]))((IStorageProviderSyncRootInfo3*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageProviderSyncRootInfo3*, uint*, Guid**, int>)(lpVtbl[3]))((IStorageProviderSyncRootInfo3*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageProviderSyncRootInfo3*, HSTRING*, int>)(lpVtbl[4]))((IStorageProviderSyncRootInfo3*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageProviderSyncRootInfo3*, TrustLevel*, int>)(lpVtbl[5]))((IStorageProviderSyncRootInfo3*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IStorageProviderSyncRootInfo3.xml' path='doc/member[@name="IStorageProviderSyncRootInfo3.get_FallbackFileTypeInfo"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_FallbackFileTypeInfo([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CStorage__CProvider__CStorageProviderFileTypeInfo_t **")] IVector<Pointer<IStorageProviderFileTypeInfo>>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageProviderSyncRootInfo3*, IVector<Pointer<IStorageProviderFileTypeInfo>>**, int>)(lpVtbl[6]))((IStorageProviderSyncRootInfo3*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_FallbackFileTypeInfo([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CStorage__CProvider__CStorageProviderFileTypeInfo_t **")] IVector<Pointer<IStorageProviderFileTypeInfo>>** value);
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

        [NativeTypeName("HRESULT (ULONG *, IID **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, Guid**, int> GetIids;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> GetRuntimeClassName;

        [NativeTypeName("HRESULT (TrustLevel *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, TrustLevel*, int> GetTrustLevel;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CStorage__CProvider__CStorageProviderFileTypeInfo_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVector<Pointer<IStorageProviderFileTypeInfo>>**, int> get_FallbackFileTypeInfo;
    }
}
