// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.networking.backgroundtransfer.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IBackgroundDownloader2.xml' path='doc/member[@name="IBackgroundDownloader2"]/*' />
[Guid("A94A5847-348D-4A35-890E-8A1EF3798479")]
[NativeTypeName("struct IBackgroundDownloader2 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IBackgroundDownloader2 : IBackgroundDownloader2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IBackgroundDownloader2);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundDownloader2*, Guid*, void**, int>)(lpVtbl[0]))((IBackgroundDownloader2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundDownloader2*, uint>)(lpVtbl[1]))((IBackgroundDownloader2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundDownloader2*, uint>)(lpVtbl[2]))((IBackgroundDownloader2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundDownloader2*, uint*, Guid**, int>)(lpVtbl[3]))((IBackgroundDownloader2*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundDownloader2*, HSTRING*, int>)(lpVtbl[4]))((IBackgroundDownloader2*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundDownloader2*, TrustLevel*, int>)(lpVtbl[5]))((IBackgroundDownloader2*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IBackgroundDownloader2.xml' path='doc/member[@name="IBackgroundDownloader2.get_TransferGroup"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_TransferGroup([NativeTypeName("ABI::Windows::Networking::BackgroundTransfer::IBackgroundTransferGroup **")] IBackgroundTransferGroup** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundDownloader2*, IBackgroundTransferGroup**, int>)(lpVtbl[6]))((IBackgroundDownloader2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBackgroundDownloader2.xml' path='doc/member[@name="IBackgroundDownloader2.put_TransferGroup"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_TransferGroup([NativeTypeName("ABI::Windows::Networking::BackgroundTransfer::IBackgroundTransferGroup *")] IBackgroundTransferGroup* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundDownloader2*, IBackgroundTransferGroup*, int>)(lpVtbl[7]))((IBackgroundDownloader2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBackgroundDownloader2.xml' path='doc/member[@name="IBackgroundDownloader2.get_SuccessToastNotification"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_SuccessToastNotification([NativeTypeName("ABI::Windows::UI::Notifications::IToastNotification **")] IToastNotification** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundDownloader2*, IToastNotification**, int>)(lpVtbl[8]))((IBackgroundDownloader2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBackgroundDownloader2.xml' path='doc/member[@name="IBackgroundDownloader2.put_SuccessToastNotification"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_SuccessToastNotification([NativeTypeName("ABI::Windows::UI::Notifications::IToastNotification *")] IToastNotification* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundDownloader2*, IToastNotification*, int>)(lpVtbl[9]))((IBackgroundDownloader2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBackgroundDownloader2.xml' path='doc/member[@name="IBackgroundDownloader2.get_FailureToastNotification"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_FailureToastNotification([NativeTypeName("ABI::Windows::UI::Notifications::IToastNotification **")] IToastNotification** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundDownloader2*, IToastNotification**, int>)(lpVtbl[10]))((IBackgroundDownloader2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBackgroundDownloader2.xml' path='doc/member[@name="IBackgroundDownloader2.put_FailureToastNotification"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_FailureToastNotification([NativeTypeName("ABI::Windows::UI::Notifications::IToastNotification *")] IToastNotification* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundDownloader2*, IToastNotification*, int>)(lpVtbl[11]))((IBackgroundDownloader2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBackgroundDownloader2.xml' path='doc/member[@name="IBackgroundDownloader2.get_SuccessTileNotification"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_SuccessTileNotification([NativeTypeName("ABI::Windows::UI::Notifications::ITileNotification **")] ITileNotification** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundDownloader2*, ITileNotification**, int>)(lpVtbl[12]))((IBackgroundDownloader2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBackgroundDownloader2.xml' path='doc/member[@name="IBackgroundDownloader2.put_SuccessTileNotification"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT put_SuccessTileNotification([NativeTypeName("ABI::Windows::UI::Notifications::ITileNotification *")] ITileNotification* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundDownloader2*, ITileNotification*, int>)(lpVtbl[13]))((IBackgroundDownloader2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBackgroundDownloader2.xml' path='doc/member[@name="IBackgroundDownloader2.get_FailureTileNotification"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_FailureTileNotification([NativeTypeName("ABI::Windows::UI::Notifications::ITileNotification **")] ITileNotification** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundDownloader2*, ITileNotification**, int>)(lpVtbl[14]))((IBackgroundDownloader2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBackgroundDownloader2.xml' path='doc/member[@name="IBackgroundDownloader2.put_FailureTileNotification"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT put_FailureTileNotification([NativeTypeName("ABI::Windows::UI::Notifications::ITileNotification *")] ITileNotification* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundDownloader2*, ITileNotification*, int>)(lpVtbl[15]))((IBackgroundDownloader2*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_TransferGroup([NativeTypeName("ABI::Windows::Networking::BackgroundTransfer::IBackgroundTransferGroup **")] IBackgroundTransferGroup** value);

        [VtblIndex(7)]
        HRESULT put_TransferGroup([NativeTypeName("ABI::Windows::Networking::BackgroundTransfer::IBackgroundTransferGroup *")] IBackgroundTransferGroup* value);

        [VtblIndex(8)]
        HRESULT get_SuccessToastNotification([NativeTypeName("ABI::Windows::UI::Notifications::IToastNotification **")] IToastNotification** value);

        [VtblIndex(9)]
        HRESULT put_SuccessToastNotification([NativeTypeName("ABI::Windows::UI::Notifications::IToastNotification *")] IToastNotification* value);

        [VtblIndex(10)]
        HRESULT get_FailureToastNotification([NativeTypeName("ABI::Windows::UI::Notifications::IToastNotification **")] IToastNotification** value);

        [VtblIndex(11)]
        HRESULT put_FailureToastNotification([NativeTypeName("ABI::Windows::UI::Notifications::IToastNotification *")] IToastNotification* value);

        [VtblIndex(12)]
        HRESULT get_SuccessTileNotification([NativeTypeName("ABI::Windows::UI::Notifications::ITileNotification **")] ITileNotification** value);

        [VtblIndex(13)]
        HRESULT put_SuccessTileNotification([NativeTypeName("ABI::Windows::UI::Notifications::ITileNotification *")] ITileNotification* value);

        [VtblIndex(14)]
        HRESULT get_FailureTileNotification([NativeTypeName("ABI::Windows::UI::Notifications::ITileNotification **")] ITileNotification** value);

        [VtblIndex(15)]
        HRESULT put_FailureTileNotification([NativeTypeName("ABI::Windows::UI::Notifications::ITileNotification *")] ITileNotification* value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Networking::BackgroundTransfer::IBackgroundTransferGroup **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IBackgroundTransferGroup**, int> get_TransferGroup;

        [NativeTypeName("HRESULT (ABI::Windows::Networking::BackgroundTransfer::IBackgroundTransferGroup *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IBackgroundTransferGroup*, int> put_TransferGroup;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Notifications::IToastNotification **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IToastNotification**, int> get_SuccessToastNotification;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Notifications::IToastNotification *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IToastNotification*, int> put_SuccessToastNotification;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Notifications::IToastNotification **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IToastNotification**, int> get_FailureToastNotification;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Notifications::IToastNotification *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IToastNotification*, int> put_FailureToastNotification;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Notifications::ITileNotification **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITileNotification**, int> get_SuccessTileNotification;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Notifications::ITileNotification *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITileNotification*, int> put_SuccessTileNotification;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Notifications::ITileNotification **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITileNotification**, int> get_FailureTileNotification;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Notifications::ITileNotification *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITileNotification*, int> put_FailureTileNotification;
    }
}
