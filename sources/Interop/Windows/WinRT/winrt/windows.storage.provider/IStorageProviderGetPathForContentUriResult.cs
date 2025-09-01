// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.storage.provider.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IStorageProviderGetPathForContentUriResult.xml' path='doc/member[@name="IStorageProviderGetPathForContentUriResult"]/*' />
[Guid("63711A9D-4118-45A6-ACB6-22C49D019F40")]
[NativeTypeName("struct IStorageProviderGetPathForContentUriResult : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IStorageProviderGetPathForContentUriResult : IStorageProviderGetPathForContentUriResult.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IStorageProviderGetPathForContentUriResult);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageProviderGetPathForContentUriResult*, Guid*, void**, int>)(lpVtbl[0]))((IStorageProviderGetPathForContentUriResult*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageProviderGetPathForContentUriResult*, uint>)(lpVtbl[1]))((IStorageProviderGetPathForContentUriResult*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageProviderGetPathForContentUriResult*, uint>)(lpVtbl[2]))((IStorageProviderGetPathForContentUriResult*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageProviderGetPathForContentUriResult*, uint*, Guid**, int>)(lpVtbl[3]))((IStorageProviderGetPathForContentUriResult*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageProviderGetPathForContentUriResult*, HSTRING*, int>)(lpVtbl[4]))((IStorageProviderGetPathForContentUriResult*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageProviderGetPathForContentUriResult*, TrustLevel*, int>)(lpVtbl[5]))((IStorageProviderGetPathForContentUriResult*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IStorageProviderGetPathForContentUriResult.xml' path='doc/member[@name="IStorageProviderGetPathForContentUriResult.get_Status"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Status([NativeTypeName("ABI::Windows::Storage::Provider::StorageProviderUriSourceStatus *")] StorageProviderUriSourceStatus* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageProviderGetPathForContentUriResult*, StorageProviderUriSourceStatus*, int>)(lpVtbl[6]))((IStorageProviderGetPathForContentUriResult*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IStorageProviderGetPathForContentUriResult.xml' path='doc/member[@name="IStorageProviderGetPathForContentUriResult.put_Status"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_Status([NativeTypeName("ABI::Windows::Storage::Provider::StorageProviderUriSourceStatus")] StorageProviderUriSourceStatus value)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageProviderGetPathForContentUriResult*, StorageProviderUriSourceStatus, int>)(lpVtbl[7]))((IStorageProviderGetPathForContentUriResult*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IStorageProviderGetPathForContentUriResult.xml' path='doc/member[@name="IStorageProviderGetPathForContentUriResult.get_Path"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_Path(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageProviderGetPathForContentUriResult*, HSTRING*, int>)(lpVtbl[8]))((IStorageProviderGetPathForContentUriResult*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IStorageProviderGetPathForContentUriResult.xml' path='doc/member[@name="IStorageProviderGetPathForContentUriResult.put_Path"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_Path(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageProviderGetPathForContentUriResult*, HSTRING, int>)(lpVtbl[9]))((IStorageProviderGetPathForContentUriResult*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Status([NativeTypeName("ABI::Windows::Storage::Provider::StorageProviderUriSourceStatus *")] StorageProviderUriSourceStatus* value);

        [VtblIndex(7)]
        HRESULT put_Status([NativeTypeName("ABI::Windows::Storage::Provider::StorageProviderUriSourceStatus")] StorageProviderUriSourceStatus value);

        [VtblIndex(8)]
        HRESULT get_Path(HSTRING* value);

        [VtblIndex(9)]
        HRESULT put_Path(HSTRING value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Provider::StorageProviderUriSourceStatus *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, StorageProviderUriSourceStatus*, int> get_Status;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Provider::StorageProviderUriSourceStatus) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, StorageProviderUriSourceStatus, int> put_Status;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Path;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> put_Path;
    }
}
