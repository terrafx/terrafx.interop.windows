// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.notifications.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IToastNotificationHistory2.xml' path='doc/member[@name="IToastNotificationHistory2"]/*' />
[Guid("3BC3D253-2F31-4092-9129-8AD5ABF067DA")]
[NativeTypeName("struct IToastNotificationHistory2 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IToastNotificationHistory2 : IToastNotificationHistory2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IToastNotificationHistory2));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IToastNotificationHistory2*, Guid*, void**, int>)(lpVtbl[0]))((IToastNotificationHistory2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IToastNotificationHistory2*, uint>)(lpVtbl[1]))((IToastNotificationHistory2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IToastNotificationHistory2*, uint>)(lpVtbl[2]))((IToastNotificationHistory2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IToastNotificationHistory2*, uint*, Guid**, int>)(lpVtbl[3]))((IToastNotificationHistory2*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IToastNotificationHistory2*, HSTRING*, int>)(lpVtbl[4]))((IToastNotificationHistory2*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IToastNotificationHistory2*, TrustLevel*, int>)(lpVtbl[5]))((IToastNotificationHistory2*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IToastNotificationHistory2.xml' path='doc/member[@name="IToastNotificationHistory2.GetHistory"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetHistory([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CUI__CNotifications__CToastNotification_t **")] IVectorView<Pointer<IToastNotification>>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IToastNotificationHistory2*, IVectorView<Pointer<IToastNotification>>**, int>)(lpVtbl[6]))((IToastNotificationHistory2*)Unsafe.AsPointer(ref this), result);
    }

    /// <include file='IToastNotificationHistory2.xml' path='doc/member[@name="IToastNotificationHistory2.GetHistoryWithId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetHistoryWithId(HSTRING applicationId, [NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CUI__CNotifications__CToastNotification_t **")] IVectorView<Pointer<IToastNotification>>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IToastNotificationHistory2*, HSTRING, IVectorView<Pointer<IToastNotification>>**, int>)(lpVtbl[7]))((IToastNotificationHistory2*)Unsafe.AsPointer(ref this), applicationId, result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT GetHistory([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CUI__CNotifications__CToastNotification_t **")] IVectorView<Pointer<IToastNotification>>** result);

        [VtblIndex(7)]
        HRESULT GetHistoryWithId(HSTRING applicationId, [NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CUI__CNotifications__CToastNotification_t **")] IVectorView<Pointer<IToastNotification>>** result);
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CUI__CNotifications__CToastNotification_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVectorView<Pointer<IToastNotification>>**, int> GetHistory;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CUI__CNotifications__CToastNotification_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IVectorView<Pointer<IToastNotification>>**, int> GetHistoryWithId;
    }
}
