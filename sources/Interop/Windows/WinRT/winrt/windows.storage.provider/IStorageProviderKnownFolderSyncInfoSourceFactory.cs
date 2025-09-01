// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.storage.provider.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IStorageProviderKnownFolderSyncInfoSourceFactory.xml' path='doc/member[@name="IStorageProviderKnownFolderSyncInfoSourceFactory"]/*' />
[Guid("AAEE03A7-A7F6-50BE-A9B0-8E82D0C81082")]
[NativeTypeName("struct IStorageProviderKnownFolderSyncInfoSourceFactory : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IStorageProviderKnownFolderSyncInfoSourceFactory : IStorageProviderKnownFolderSyncInfoSourceFactory.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IStorageProviderKnownFolderSyncInfoSourceFactory);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageProviderKnownFolderSyncInfoSourceFactory*, Guid*, void**, int>)(lpVtbl[0]))((IStorageProviderKnownFolderSyncInfoSourceFactory*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageProviderKnownFolderSyncInfoSourceFactory*, uint>)(lpVtbl[1]))((IStorageProviderKnownFolderSyncInfoSourceFactory*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageProviderKnownFolderSyncInfoSourceFactory*, uint>)(lpVtbl[2]))((IStorageProviderKnownFolderSyncInfoSourceFactory*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageProviderKnownFolderSyncInfoSourceFactory*, uint*, Guid**, int>)(lpVtbl[3]))((IStorageProviderKnownFolderSyncInfoSourceFactory*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageProviderKnownFolderSyncInfoSourceFactory*, HSTRING*, int>)(lpVtbl[4]))((IStorageProviderKnownFolderSyncInfoSourceFactory*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageProviderKnownFolderSyncInfoSourceFactory*, TrustLevel*, int>)(lpVtbl[5]))((IStorageProviderKnownFolderSyncInfoSourceFactory*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IStorageProviderKnownFolderSyncInfoSourceFactory.xml' path='doc/member[@name="IStorageProviderKnownFolderSyncInfoSourceFactory.GetKnownFolderSyncInfoSource"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetKnownFolderSyncInfoSource([NativeTypeName("ABI::Windows::Storage::Provider::IStorageProviderKnownFolderSyncInfoSource **")] IStorageProviderKnownFolderSyncInfoSource** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageProviderKnownFolderSyncInfoSourceFactory*, IStorageProviderKnownFolderSyncInfoSource**, int>)(lpVtbl[6]))((IStorageProviderKnownFolderSyncInfoSourceFactory*)Unsafe.AsPointer(ref this), result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT GetKnownFolderSyncInfoSource([NativeTypeName("ABI::Windows::Storage::Provider::IStorageProviderKnownFolderSyncInfoSource **")] IStorageProviderKnownFolderSyncInfoSource** result);
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

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Provider::IStorageProviderKnownFolderSyncInfoSource **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IStorageProviderKnownFolderSyncInfoSource**, int> GetKnownFolderSyncInfoSource;
    }
}
