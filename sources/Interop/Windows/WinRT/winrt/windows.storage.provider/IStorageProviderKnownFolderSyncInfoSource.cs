// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.storage.provider.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IStorageProviderKnownFolderSyncInfoSource.xml' path='doc/member[@name="IStorageProviderKnownFolderSyncInfoSource"]/*' />
[Guid("51359342-F7C0-53D0-BBB6-1CDC098EBDA9")]
[NativeTypeName("struct IStorageProviderKnownFolderSyncInfoSource : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IStorageProviderKnownFolderSyncInfoSource : IStorageProviderKnownFolderSyncInfoSource.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IStorageProviderKnownFolderSyncInfoSource);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageProviderKnownFolderSyncInfoSource*, Guid*, void**, int>)(lpVtbl[0]))((IStorageProviderKnownFolderSyncInfoSource*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageProviderKnownFolderSyncInfoSource*, uint>)(lpVtbl[1]))((IStorageProviderKnownFolderSyncInfoSource*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageProviderKnownFolderSyncInfoSource*, uint>)(lpVtbl[2]))((IStorageProviderKnownFolderSyncInfoSource*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageProviderKnownFolderSyncInfoSource*, uint*, Guid**, int>)(lpVtbl[3]))((IStorageProviderKnownFolderSyncInfoSource*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageProviderKnownFolderSyncInfoSource*, HSTRING*, int>)(lpVtbl[4]))((IStorageProviderKnownFolderSyncInfoSource*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageProviderKnownFolderSyncInfoSource*, TrustLevel*, int>)(lpVtbl[5]))((IStorageProviderKnownFolderSyncInfoSource*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IStorageProviderKnownFolderSyncInfoSource.xml' path='doc/member[@name="IStorageProviderKnownFolderSyncInfoSource.GetKnownFolderSyncInfo"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetKnownFolderSyncInfo([NativeTypeName("ABI::Windows::Storage::Provider::IStorageProviderKnownFolderSyncInfo **")] IStorageProviderKnownFolderSyncInfo** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageProviderKnownFolderSyncInfoSource*, IStorageProviderKnownFolderSyncInfo**, int>)(lpVtbl[6]))((IStorageProviderKnownFolderSyncInfoSource*)Unsafe.AsPointer(ref this), result);
    }

    /// <include file='IStorageProviderKnownFolderSyncInfoSource.xml' path='doc/member[@name="IStorageProviderKnownFolderSyncInfoSource.add_KnownFolderSyncInfoChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT add_KnownFolderSyncInfoChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CStorage__CProvider__CIStorageProviderKnownFolderSyncInfoSource_IInspectable_t *")] ITypedEventHandler<Pointer<IStorageProviderKnownFolderSyncInfoSource>, Pointer<IInspectable>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageProviderKnownFolderSyncInfoSource*, ITypedEventHandler<Pointer<IStorageProviderKnownFolderSyncInfoSource>, Pointer<IInspectable>>*, EventRegistrationToken*, int>)(lpVtbl[7]))((IStorageProviderKnownFolderSyncInfoSource*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IStorageProviderKnownFolderSyncInfoSource.xml' path='doc/member[@name="IStorageProviderKnownFolderSyncInfoSource.remove_KnownFolderSyncInfoChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT remove_KnownFolderSyncInfoChanged(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageProviderKnownFolderSyncInfoSource*, EventRegistrationToken, int>)(lpVtbl[8]))((IStorageProviderKnownFolderSyncInfoSource*)Unsafe.AsPointer(ref this), token);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT GetKnownFolderSyncInfo([NativeTypeName("ABI::Windows::Storage::Provider::IStorageProviderKnownFolderSyncInfo **")] IStorageProviderKnownFolderSyncInfo** result);

        [VtblIndex(7)]
        HRESULT add_KnownFolderSyncInfoChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CStorage__CProvider__CIStorageProviderKnownFolderSyncInfoSource_IInspectable_t *")] ITypedEventHandler<Pointer<IStorageProviderKnownFolderSyncInfoSource>, Pointer<IInspectable>>* handler, EventRegistrationToken* token);

        [VtblIndex(8)]
        HRESULT remove_KnownFolderSyncInfoChanged(EventRegistrationToken token);
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

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Provider::IStorageProviderKnownFolderSyncInfo **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IStorageProviderKnownFolderSyncInfo**, int> GetKnownFolderSyncInfo;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CStorage__CProvider__CIStorageProviderKnownFolderSyncInfoSource_IInspectable_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IStorageProviderKnownFolderSyncInfoSource>, Pointer<IInspectable>>*, EventRegistrationToken*, int> add_KnownFolderSyncInfoChanged;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_KnownFolderSyncInfoChanged;
    }
}
