// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.networking.backgroundtransfer.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IBackgroundTransferRangesDownloadedEventArgs.xml' path='doc/member[@name="IBackgroundTransferRangesDownloadedEventArgs"]/*' />
[Guid("3EBC7453-BF48-4A88-9248-B0C165184F5C")]
[NativeTypeName("struct IBackgroundTransferRangesDownloadedEventArgs : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IBackgroundTransferRangesDownloadedEventArgs : IBackgroundTransferRangesDownloadedEventArgs.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IBackgroundTransferRangesDownloadedEventArgs));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundTransferRangesDownloadedEventArgs*, Guid*, void**, int>)(lpVtbl[0]))((IBackgroundTransferRangesDownloadedEventArgs*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundTransferRangesDownloadedEventArgs*, uint>)(lpVtbl[1]))((IBackgroundTransferRangesDownloadedEventArgs*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundTransferRangesDownloadedEventArgs*, uint>)(lpVtbl[2]))((IBackgroundTransferRangesDownloadedEventArgs*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundTransferRangesDownloadedEventArgs*, uint*, Guid**, int>)(lpVtbl[3]))((IBackgroundTransferRangesDownloadedEventArgs*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundTransferRangesDownloadedEventArgs*, HSTRING*, int>)(lpVtbl[4]))((IBackgroundTransferRangesDownloadedEventArgs*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundTransferRangesDownloadedEventArgs*, TrustLevel*, int>)(lpVtbl[5]))((IBackgroundTransferRangesDownloadedEventArgs*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IBackgroundTransferRangesDownloadedEventArgs.xml' path='doc/member[@name="IBackgroundTransferRangesDownloadedEventArgs.get_WasDownloadRestarted"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_WasDownloadRestarted([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundTransferRangesDownloadedEventArgs*, byte*, int>)(lpVtbl[6]))((IBackgroundTransferRangesDownloadedEventArgs*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBackgroundTransferRangesDownloadedEventArgs.xml' path='doc/member[@name="IBackgroundTransferRangesDownloadedEventArgs.get_AddedRanges"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_AddedRanges([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CNetworking__CBackgroundTransfer__CBackgroundTransferFileRange_t **")] IVector<BackgroundTransferFileRange>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundTransferRangesDownloadedEventArgs*, IVector<BackgroundTransferFileRange>**, int>)(lpVtbl[7]))((IBackgroundTransferRangesDownloadedEventArgs*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBackgroundTransferRangesDownloadedEventArgs.xml' path='doc/member[@name="IBackgroundTransferRangesDownloadedEventArgs.GetDeferral"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetDeferral([NativeTypeName("ABI::Windows::Foundation::IDeferral **")] IDeferral** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundTransferRangesDownloadedEventArgs*, IDeferral**, int>)(lpVtbl[8]))((IBackgroundTransferRangesDownloadedEventArgs*)Unsafe.AsPointer(ref this), result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_WasDownloadRestarted([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(7)]
        HRESULT get_AddedRanges([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CNetworking__CBackgroundTransfer__CBackgroundTransferFileRange_t **")] IVector<BackgroundTransferFileRange>** value);

        [VtblIndex(8)]
        HRESULT GetDeferral([NativeTypeName("ABI::Windows::Foundation::IDeferral **")] IDeferral** result);
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

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_WasDownloadRestarted;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CNetworking__CBackgroundTransfer__CBackgroundTransferFileRange_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVector<BackgroundTransferFileRange>**, int> get_AddedRanges;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::IDeferral **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IDeferral**, int> GetDeferral;
    }
}
