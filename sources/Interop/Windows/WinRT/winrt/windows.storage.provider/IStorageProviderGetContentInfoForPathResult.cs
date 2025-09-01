// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.storage.provider.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IStorageProviderGetContentInfoForPathResult.xml' path='doc/member[@name="IStorageProviderGetContentInfoForPathResult"]/*' />
[Guid("2564711D-AA89-4D12-82E3-F72A92E33966")]
[NativeTypeName("struct IStorageProviderGetContentInfoForPathResult : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IStorageProviderGetContentInfoForPathResult : IStorageProviderGetContentInfoForPathResult.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IStorageProviderGetContentInfoForPathResult);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageProviderGetContentInfoForPathResult*, Guid*, void**, int>)(lpVtbl[0]))((IStorageProviderGetContentInfoForPathResult*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageProviderGetContentInfoForPathResult*, uint>)(lpVtbl[1]))((IStorageProviderGetContentInfoForPathResult*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageProviderGetContentInfoForPathResult*, uint>)(lpVtbl[2]))((IStorageProviderGetContentInfoForPathResult*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageProviderGetContentInfoForPathResult*, uint*, Guid**, int>)(lpVtbl[3]))((IStorageProviderGetContentInfoForPathResult*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageProviderGetContentInfoForPathResult*, HSTRING*, int>)(lpVtbl[4]))((IStorageProviderGetContentInfoForPathResult*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageProviderGetContentInfoForPathResult*, TrustLevel*, int>)(lpVtbl[5]))((IStorageProviderGetContentInfoForPathResult*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IStorageProviderGetContentInfoForPathResult.xml' path='doc/member[@name="IStorageProviderGetContentInfoForPathResult.get_Status"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Status([NativeTypeName("ABI::Windows::Storage::Provider::StorageProviderUriSourceStatus *")] StorageProviderUriSourceStatus* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageProviderGetContentInfoForPathResult*, StorageProviderUriSourceStatus*, int>)(lpVtbl[6]))((IStorageProviderGetContentInfoForPathResult*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IStorageProviderGetContentInfoForPathResult.xml' path='doc/member[@name="IStorageProviderGetContentInfoForPathResult.put_Status"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_Status([NativeTypeName("ABI::Windows::Storage::Provider::StorageProviderUriSourceStatus")] StorageProviderUriSourceStatus value)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageProviderGetContentInfoForPathResult*, StorageProviderUriSourceStatus, int>)(lpVtbl[7]))((IStorageProviderGetContentInfoForPathResult*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IStorageProviderGetContentInfoForPathResult.xml' path='doc/member[@name="IStorageProviderGetContentInfoForPathResult.get_ContentUri"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_ContentUri(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageProviderGetContentInfoForPathResult*, HSTRING*, int>)(lpVtbl[8]))((IStorageProviderGetContentInfoForPathResult*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IStorageProviderGetContentInfoForPathResult.xml' path='doc/member[@name="IStorageProviderGetContentInfoForPathResult.put_ContentUri"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_ContentUri(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageProviderGetContentInfoForPathResult*, HSTRING, int>)(lpVtbl[9]))((IStorageProviderGetContentInfoForPathResult*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IStorageProviderGetContentInfoForPathResult.xml' path='doc/member[@name="IStorageProviderGetContentInfoForPathResult.get_ContentId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_ContentId(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageProviderGetContentInfoForPathResult*, HSTRING*, int>)(lpVtbl[10]))((IStorageProviderGetContentInfoForPathResult*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IStorageProviderGetContentInfoForPathResult.xml' path='doc/member[@name="IStorageProviderGetContentInfoForPathResult.put_ContentId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_ContentId(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageProviderGetContentInfoForPathResult*, HSTRING, int>)(lpVtbl[11]))((IStorageProviderGetContentInfoForPathResult*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Status([NativeTypeName("ABI::Windows::Storage::Provider::StorageProviderUriSourceStatus *")] StorageProviderUriSourceStatus* value);

        [VtblIndex(7)]
        HRESULT put_Status([NativeTypeName("ABI::Windows::Storage::Provider::StorageProviderUriSourceStatus")] StorageProviderUriSourceStatus value);

        [VtblIndex(8)]
        HRESULT get_ContentUri(HSTRING* value);

        [VtblIndex(9)]
        HRESULT put_ContentUri(HSTRING value);

        [VtblIndex(10)]
        HRESULT get_ContentId(HSTRING* value);

        [VtblIndex(11)]
        HRESULT put_ContentId(HSTRING value);
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
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_ContentUri;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> put_ContentUri;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_ContentId;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> put_ContentId;
    }
}
