// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.notifications.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ITileUpdater.xml' path='doc/member[@name="ITileUpdater"]/*' />
[Guid("0942A48B-1D91-44EC-9243-C1E821C29A20")]
[NativeTypeName("struct ITileUpdater : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ITileUpdater : ITileUpdater.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ITileUpdater));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ITileUpdater*, Guid*, void**, int>)(lpVtbl[0]))((ITileUpdater*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ITileUpdater*, uint>)(lpVtbl[1]))((ITileUpdater*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ITileUpdater*, uint>)(lpVtbl[2]))((ITileUpdater*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ITileUpdater*, uint*, Guid**, int>)(lpVtbl[3]))((ITileUpdater*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ITileUpdater*, HSTRING*, int>)(lpVtbl[4]))((ITileUpdater*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ITileUpdater*, TrustLevel*, int>)(lpVtbl[5]))((ITileUpdater*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ITileUpdater.xml' path='doc/member[@name="ITileUpdater.Update"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Update([NativeTypeName("ABI::Windows::UI::Notifications::ITileNotification *")] ITileNotification* notification)
    {
        return ((delegate* unmanaged[MemberFunction]<ITileUpdater*, ITileNotification*, int>)(lpVtbl[6]))((ITileUpdater*)Unsafe.AsPointer(ref this), notification);
    }

    /// <include file='ITileUpdater.xml' path='doc/member[@name="ITileUpdater.Clear"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT Clear()
    {
        return ((delegate* unmanaged[MemberFunction]<ITileUpdater*, int>)(lpVtbl[7]))((ITileUpdater*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ITileUpdater.xml' path='doc/member[@name="ITileUpdater.EnableNotificationQueue"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT EnableNotificationQueue([NativeTypeName("boolean")] byte enable)
    {
        return ((delegate* unmanaged[MemberFunction]<ITileUpdater*, byte, int>)(lpVtbl[8]))((ITileUpdater*)Unsafe.AsPointer(ref this), enable);
    }

    /// <include file='ITileUpdater.xml' path='doc/member[@name="ITileUpdater.get_Setting"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_Setting([NativeTypeName("ABI::Windows::UI::Notifications::NotificationSetting *")] NotificationSetting* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ITileUpdater*, NotificationSetting*, int>)(lpVtbl[9]))((ITileUpdater*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ITileUpdater.xml' path='doc/member[@name="ITileUpdater.AddToSchedule"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT AddToSchedule([NativeTypeName("ABI::Windows::UI::Notifications::IScheduledTileNotification *")] IScheduledTileNotification* scheduledTile)
    {
        return ((delegate* unmanaged[MemberFunction]<ITileUpdater*, IScheduledTileNotification*, int>)(lpVtbl[10]))((ITileUpdater*)Unsafe.AsPointer(ref this), scheduledTile);
    }

    /// <include file='ITileUpdater.xml' path='doc/member[@name="ITileUpdater.RemoveFromSchedule"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT RemoveFromSchedule([NativeTypeName("ABI::Windows::UI::Notifications::IScheduledTileNotification *")] IScheduledTileNotification* scheduledTile)
    {
        return ((delegate* unmanaged[MemberFunction]<ITileUpdater*, IScheduledTileNotification*, int>)(lpVtbl[11]))((ITileUpdater*)Unsafe.AsPointer(ref this), scheduledTile);
    }

    /// <include file='ITileUpdater.xml' path='doc/member[@name="ITileUpdater.GetScheduledTileNotifications"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT GetScheduledTileNotifications([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CUI__CNotifications__CScheduledTileNotification_t **")] IVectorView<IntPtr>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<ITileUpdater*, IVectorView<IntPtr>**, int>)(lpVtbl[12]))((ITileUpdater*)Unsafe.AsPointer(ref this), result);
    }

    /// <include file='ITileUpdater.xml' path='doc/member[@name="ITileUpdater.StartPeriodicUpdate"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT StartPeriodicUpdate([NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass* tileContent, [NativeTypeName("ABI::Windows::UI::Notifications::PeriodicUpdateRecurrence")] PeriodicUpdateRecurrence requestedInterval)
    {
        return ((delegate* unmanaged[MemberFunction]<ITileUpdater*, IUriRuntimeClass*, PeriodicUpdateRecurrence, int>)(lpVtbl[13]))((ITileUpdater*)Unsafe.AsPointer(ref this), tileContent, requestedInterval);
    }

    /// <include file='ITileUpdater.xml' path='doc/member[@name="ITileUpdater.StartPeriodicUpdateAtTime"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT StartPeriodicUpdateAtTime([NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass* tileContent, [NativeTypeName("ABI::Windows::Foundation::DateTime")] WinRTDateTime startTime, [NativeTypeName("ABI::Windows::UI::Notifications::PeriodicUpdateRecurrence")] PeriodicUpdateRecurrence requestedInterval)
    {
        return ((delegate* unmanaged[MemberFunction]<ITileUpdater*, IUriRuntimeClass*, WinRTDateTime, PeriodicUpdateRecurrence, int>)(lpVtbl[14]))((ITileUpdater*)Unsafe.AsPointer(ref this), tileContent, startTime, requestedInterval);
    }

    /// <include file='ITileUpdater.xml' path='doc/member[@name="ITileUpdater.StopPeriodicUpdate"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT StopPeriodicUpdate()
    {
        return ((delegate* unmanaged[MemberFunction]<ITileUpdater*, int>)(lpVtbl[15]))((ITileUpdater*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ITileUpdater.xml' path='doc/member[@name="ITileUpdater.StartPeriodicUpdateBatch"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT StartPeriodicUpdateBatch([NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CFoundation__CUri_t *")] IIterable<IntPtr>* tileContents, [NativeTypeName("ABI::Windows::UI::Notifications::PeriodicUpdateRecurrence")] PeriodicUpdateRecurrence requestedInterval)
    {
        return ((delegate* unmanaged[MemberFunction]<ITileUpdater*, IIterable<IntPtr>*, PeriodicUpdateRecurrence, int>)(lpVtbl[16]))((ITileUpdater*)Unsafe.AsPointer(ref this), tileContents, requestedInterval);
    }

    /// <include file='ITileUpdater.xml' path='doc/member[@name="ITileUpdater.StartPeriodicUpdateBatchAtTime"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT StartPeriodicUpdateBatchAtTime([NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CFoundation__CUri_t *")] IIterable<IntPtr>* tileContents, [NativeTypeName("ABI::Windows::Foundation::DateTime")] WinRTDateTime startTime, [NativeTypeName("ABI::Windows::UI::Notifications::PeriodicUpdateRecurrence")] PeriodicUpdateRecurrence requestedInterval)
    {
        return ((delegate* unmanaged[MemberFunction]<ITileUpdater*, IIterable<IntPtr>*, WinRTDateTime, PeriodicUpdateRecurrence, int>)(lpVtbl[17]))((ITileUpdater*)Unsafe.AsPointer(ref this), tileContents, startTime, requestedInterval);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT Update([NativeTypeName("ABI::Windows::UI::Notifications::ITileNotification *")] ITileNotification* notification);

        [VtblIndex(7)]
        HRESULT Clear();

        [VtblIndex(8)]
        HRESULT EnableNotificationQueue([NativeTypeName("boolean")] byte enable);

        [VtblIndex(9)]
        HRESULT get_Setting([NativeTypeName("ABI::Windows::UI::Notifications::NotificationSetting *")] NotificationSetting* value);

        [VtblIndex(10)]
        HRESULT AddToSchedule([NativeTypeName("ABI::Windows::UI::Notifications::IScheduledTileNotification *")] IScheduledTileNotification* scheduledTile);

        [VtblIndex(11)]
        HRESULT RemoveFromSchedule([NativeTypeName("ABI::Windows::UI::Notifications::IScheduledTileNotification *")] IScheduledTileNotification* scheduledTile);

        [VtblIndex(12)]
        HRESULT GetScheduledTileNotifications([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CUI__CNotifications__CScheduledTileNotification_t **")] IVectorView<IntPtr>** result);

        [VtblIndex(13)]
        HRESULT StartPeriodicUpdate([NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass* tileContent, [NativeTypeName("ABI::Windows::UI::Notifications::PeriodicUpdateRecurrence")] PeriodicUpdateRecurrence requestedInterval);

        [VtblIndex(14)]
        HRESULT StartPeriodicUpdateAtTime([NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass* tileContent, [NativeTypeName("ABI::Windows::Foundation::DateTime")] WinRTDateTime startTime, [NativeTypeName("ABI::Windows::UI::Notifications::PeriodicUpdateRecurrence")] PeriodicUpdateRecurrence requestedInterval);

        [VtblIndex(15)]
        HRESULT StopPeriodicUpdate();

        [VtblIndex(16)]
        HRESULT StartPeriodicUpdateBatch([NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CFoundation__CUri_t *")] IIterable<IntPtr>* tileContents, [NativeTypeName("ABI::Windows::UI::Notifications::PeriodicUpdateRecurrence")] PeriodicUpdateRecurrence requestedInterval);

        [VtblIndex(17)]
        HRESULT StartPeriodicUpdateBatchAtTime([NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CFoundation__CUri_t *")] IIterable<IntPtr>* tileContents, [NativeTypeName("ABI::Windows::Foundation::DateTime")] WinRTDateTime startTime, [NativeTypeName("ABI::Windows::UI::Notifications::PeriodicUpdateRecurrence")] PeriodicUpdateRecurrence requestedInterval);
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

        [NativeTypeName("HRESULT (ABI::Windows::UI::Notifications::ITileNotification *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITileNotification*, int> Update;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> Clear;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, int> EnableNotificationQueue;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Notifications::NotificationSetting *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, NotificationSetting*, int> get_Setting;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Notifications::IScheduledTileNotification *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IScheduledTileNotification*, int> AddToSchedule;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Notifications::IScheduledTileNotification *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IScheduledTileNotification*, int> RemoveFromSchedule;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CUI__CNotifications__CScheduledTileNotification_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVectorView<IntPtr>**, int> GetScheduledTileNotifications;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::IUriRuntimeClass *, ABI::Windows::UI::Notifications::PeriodicUpdateRecurrence) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IUriRuntimeClass*, PeriodicUpdateRecurrence, int> StartPeriodicUpdate;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::IUriRuntimeClass *, ABI::Windows::Foundation::DateTime, ABI::Windows::UI::Notifications::PeriodicUpdateRecurrence) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IUriRuntimeClass*, WinRTDateTime, PeriodicUpdateRecurrence, int> StartPeriodicUpdateAtTime;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> StopPeriodicUpdate;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CFoundation__CUri_t *, ABI::Windows::UI::Notifications::PeriodicUpdateRecurrence) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IIterable<IntPtr>*, PeriodicUpdateRecurrence, int> StartPeriodicUpdateBatch;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CFoundation__CUri_t *, ABI::Windows::Foundation::DateTime, ABI::Windows::UI::Notifications::PeriodicUpdateRecurrence) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IIterable<IntPtr>*, WinRTDateTime, PeriodicUpdateRecurrence, int> StartPeriodicUpdateBatchAtTime;
    }
}
