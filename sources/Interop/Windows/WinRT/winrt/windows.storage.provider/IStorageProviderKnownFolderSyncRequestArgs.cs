// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.storage.provider.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IStorageProviderKnownFolderSyncRequestArgs.xml' path='doc/member[@name="IStorageProviderKnownFolderSyncRequestArgs"]/*' />
[Guid("EDA6D569-B4E8-542F-AB8D-F3613F250A4A")]
[NativeTypeName("struct IStorageProviderKnownFolderSyncRequestArgs : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IStorageProviderKnownFolderSyncRequestArgs : IStorageProviderKnownFolderSyncRequestArgs.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IStorageProviderKnownFolderSyncRequestArgs));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageProviderKnownFolderSyncRequestArgs*, Guid*, void**, int>)(lpVtbl[0]))((IStorageProviderKnownFolderSyncRequestArgs*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageProviderKnownFolderSyncRequestArgs*, uint>)(lpVtbl[1]))((IStorageProviderKnownFolderSyncRequestArgs*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageProviderKnownFolderSyncRequestArgs*, uint>)(lpVtbl[2]))((IStorageProviderKnownFolderSyncRequestArgs*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageProviderKnownFolderSyncRequestArgs*, uint*, Guid**, int>)(lpVtbl[3]))((IStorageProviderKnownFolderSyncRequestArgs*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageProviderKnownFolderSyncRequestArgs*, HSTRING*, int>)(lpVtbl[4]))((IStorageProviderKnownFolderSyncRequestArgs*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageProviderKnownFolderSyncRequestArgs*, TrustLevel*, int>)(lpVtbl[5]))((IStorageProviderKnownFolderSyncRequestArgs*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IStorageProviderKnownFolderSyncRequestArgs.xml' path='doc/member[@name="IStorageProviderKnownFolderSyncRequestArgs.get_KnownFolders"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_KnownFolders([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_GUID_t **")] IVectorView<Guid>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageProviderKnownFolderSyncRequestArgs*, IVectorView<Guid>**, int>)(lpVtbl[6]))((IStorageProviderKnownFolderSyncRequestArgs*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IStorageProviderKnownFolderSyncRequestArgs.xml' path='doc/member[@name="IStorageProviderKnownFolderSyncRequestArgs.get_Source"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Source([NativeTypeName("ABI::Windows::Storage::IStorageFolder **")] IStorageFolder** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageProviderKnownFolderSyncRequestArgs*, IStorageFolder**, int>)(lpVtbl[7]))((IStorageProviderKnownFolderSyncRequestArgs*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_KnownFolders([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_GUID_t **")] IVectorView<Guid>** value);

        [VtblIndex(7)]
        HRESULT get_Source([NativeTypeName("ABI::Windows::Storage::IStorageFolder **")] IStorageFolder** value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVectorView_1_GUID_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVectorView<Guid>**, int> get_KnownFolders;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::IStorageFolder **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IStorageFolder**, int> get_Source;
    }
}
