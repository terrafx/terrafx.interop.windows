// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.notifications.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IToastNotificationManagerForUser2.xml' path='doc/member[@name="IToastNotificationManagerForUser2"]/*' />
[Guid("679C64B7-81AB-42C2-8819-C958767753F4")]
[NativeTypeName("struct IToastNotificationManagerForUser2 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IToastNotificationManagerForUser2 : IToastNotificationManagerForUser2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IToastNotificationManagerForUser2));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IToastNotificationManagerForUser2*, Guid*, void**, int>)(lpVtbl[0]))((IToastNotificationManagerForUser2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IToastNotificationManagerForUser2*, uint>)(lpVtbl[1]))((IToastNotificationManagerForUser2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IToastNotificationManagerForUser2*, uint>)(lpVtbl[2]))((IToastNotificationManagerForUser2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IToastNotificationManagerForUser2*, uint*, Guid**, int>)(lpVtbl[3]))((IToastNotificationManagerForUser2*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IToastNotificationManagerForUser2*, HSTRING*, int>)(lpVtbl[4]))((IToastNotificationManagerForUser2*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IToastNotificationManagerForUser2*, TrustLevel*, int>)(lpVtbl[5]))((IToastNotificationManagerForUser2*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IToastNotificationManagerForUser2.xml' path='doc/member[@name="IToastNotificationManagerForUser2.GetToastNotifierForToastCollectionIdAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetToastNotifierForToastCollectionIdAsync(HSTRING collectionId, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CUI__CNotifications__CToastNotifier_t **")] IAsyncOperation<Pointer<IToastNotifier>>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IToastNotificationManagerForUser2*, HSTRING, IAsyncOperation<Pointer<IToastNotifier>>**, int>)(lpVtbl[6]))((IToastNotificationManagerForUser2*)Unsafe.AsPointer(ref this), collectionId, operation);
    }

    /// <include file='IToastNotificationManagerForUser2.xml' path='doc/member[@name="IToastNotificationManagerForUser2.GetHistoryForToastCollectionIdAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetHistoryForToastCollectionIdAsync(HSTRING collectionId, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CUI__CNotifications__CToastNotificationHistory_t **")] IAsyncOperation<Pointer<IToastNotificationHistory>>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IToastNotificationManagerForUser2*, HSTRING, IAsyncOperation<Pointer<IToastNotificationHistory>>**, int>)(lpVtbl[7]))((IToastNotificationManagerForUser2*)Unsafe.AsPointer(ref this), collectionId, operation);
    }

    /// <include file='IToastNotificationManagerForUser2.xml' path='doc/member[@name="IToastNotificationManagerForUser2.GetToastCollectionManager"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetToastCollectionManager([NativeTypeName("ABI::Windows::UI::Notifications::IToastCollectionManager **")] IToastCollectionManager** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IToastNotificationManagerForUser2*, IToastCollectionManager**, int>)(lpVtbl[8]))((IToastNotificationManagerForUser2*)Unsafe.AsPointer(ref this), result);
    }

    /// <include file='IToastNotificationManagerForUser2.xml' path='doc/member[@name="IToastNotificationManagerForUser2.GetToastCollectionManagerWithAppId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetToastCollectionManagerWithAppId(HSTRING appId, [NativeTypeName("ABI::Windows::UI::Notifications::IToastCollectionManager **")] IToastCollectionManager** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IToastNotificationManagerForUser2*, HSTRING, IToastCollectionManager**, int>)(lpVtbl[9]))((IToastNotificationManagerForUser2*)Unsafe.AsPointer(ref this), appId, result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT GetToastNotifierForToastCollectionIdAsync(HSTRING collectionId, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CUI__CNotifications__CToastNotifier_t **")] IAsyncOperation<Pointer<IToastNotifier>>** operation);

        [VtblIndex(7)]
        HRESULT GetHistoryForToastCollectionIdAsync(HSTRING collectionId, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CUI__CNotifications__CToastNotificationHistory_t **")] IAsyncOperation<Pointer<IToastNotificationHistory>>** operation);

        [VtblIndex(8)]
        HRESULT GetToastCollectionManager([NativeTypeName("ABI::Windows::UI::Notifications::IToastCollectionManager **")] IToastCollectionManager** result);

        [VtblIndex(9)]
        HRESULT GetToastCollectionManagerWithAppId(HSTRING appId, [NativeTypeName("ABI::Windows::UI::Notifications::IToastCollectionManager **")] IToastCollectionManager** result);
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

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CUI__CNotifications__CToastNotifier_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IAsyncOperation<Pointer<IToastNotifier>>**, int> GetToastNotifierForToastCollectionIdAsync;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CUI__CNotifications__CToastNotificationHistory_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IAsyncOperation<Pointer<IToastNotificationHistory>>**, int> GetHistoryForToastCollectionIdAsync;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Notifications::IToastCollectionManager **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IToastCollectionManager**, int> GetToastCollectionManager;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::UI::Notifications::IToastCollectionManager **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IToastCollectionManager**, int> GetToastCollectionManagerWithAppId;
    }
}
