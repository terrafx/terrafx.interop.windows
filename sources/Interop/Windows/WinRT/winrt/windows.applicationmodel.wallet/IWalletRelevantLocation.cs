// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.wallet.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IWalletRelevantLocation.xml' path='doc/member[@name="IWalletRelevantLocation"]/*' />
[Guid("9FD8782A-E3F9-4DE1-BAB3-BB192E46B3F3")]
[NativeTypeName("struct IWalletRelevantLocation : IInspectable")]
[NativeInheritance("IInspectable")]
[Obsolete("IWalletRelevantLocation is deprecated and might not work on all platforms. For more info, see MSDN.")]
public unsafe partial struct IWalletRelevantLocation : IWalletRelevantLocation.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWalletRelevantLocation));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IWalletRelevantLocation*, Guid*, void**, int>)(lpVtbl[0]))((IWalletRelevantLocation*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IWalletRelevantLocation*, uint>)(lpVtbl[1]))((IWalletRelevantLocation*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IWalletRelevantLocation*, uint>)(lpVtbl[2]))((IWalletRelevantLocation*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IWalletRelevantLocation*, uint*, Guid**, int>)(lpVtbl[3]))((IWalletRelevantLocation*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IWalletRelevantLocation*, HSTRING*, int>)(lpVtbl[4]))((IWalletRelevantLocation*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IWalletRelevantLocation*, TrustLevel*, int>)(lpVtbl[5]))((IWalletRelevantLocation*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IWalletRelevantLocation.xml' path='doc/member[@name="IWalletRelevantLocation.get_Position"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    [Obsolete("IWalletRelevantLocation is deprecated and might not work on all platforms. For more info, see MSDN.")]
    public HRESULT get_Position([NativeTypeName("ABI::Windows::Devices::Geolocation::BasicGeoposition *")] BasicGeoposition* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IWalletRelevantLocation*, BasicGeoposition*, int>)(lpVtbl[6]))((IWalletRelevantLocation*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IWalletRelevantLocation.xml' path='doc/member[@name="IWalletRelevantLocation.put_Position"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    [Obsolete("IWalletRelevantLocation is deprecated and might not work on all platforms. For more info, see MSDN.")]
    public HRESULT put_Position([NativeTypeName("ABI::Windows::Devices::Geolocation::BasicGeoposition")] BasicGeoposition value)
    {
        return ((delegate* unmanaged[MemberFunction]<IWalletRelevantLocation*, BasicGeoposition, int>)(lpVtbl[7]))((IWalletRelevantLocation*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IWalletRelevantLocation.xml' path='doc/member[@name="IWalletRelevantLocation.get_DisplayMessage"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    [Obsolete("IWalletRelevantLocation is deprecated and might not work on all platforms. For more info, see MSDN.")]
    public HRESULT get_DisplayMessage(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IWalletRelevantLocation*, HSTRING*, int>)(lpVtbl[8]))((IWalletRelevantLocation*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IWalletRelevantLocation.xml' path='doc/member[@name="IWalletRelevantLocation.put_DisplayMessage"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    [Obsolete("IWalletRelevantLocation is deprecated and might not work on all platforms. For more info, see MSDN.")]
    public HRESULT put_DisplayMessage(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<IWalletRelevantLocation*, HSTRING, int>)(lpVtbl[9]))((IWalletRelevantLocation*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        [Obsolete("IWalletRelevantLocation is deprecated and might not work on all platforms. For more info, see MSDN.")]
        HRESULT get_Position([NativeTypeName("ABI::Windows::Devices::Geolocation::BasicGeoposition *")] BasicGeoposition* value);

        [VtblIndex(7)]
        [Obsolete("IWalletRelevantLocation is deprecated and might not work on all platforms. For more info, see MSDN.")]
        HRESULT put_Position([NativeTypeName("ABI::Windows::Devices::Geolocation::BasicGeoposition")] BasicGeoposition value);

        [VtblIndex(8)]
        [Obsolete("IWalletRelevantLocation is deprecated and might not work on all platforms. For more info, see MSDN.")]
        HRESULT get_DisplayMessage(HSTRING* value);

        [VtblIndex(9)]
        [Obsolete("IWalletRelevantLocation is deprecated and might not work on all platforms. For more info, see MSDN.")]
        HRESULT put_DisplayMessage(HSTRING value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Geolocation::BasicGeoposition *) __attribute__((stdcall))")]
        [Obsolete("IWalletRelevantLocation is deprecated and might not work on all platforms. For more info, see MSDN.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, BasicGeoposition*, int> get_Position;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Geolocation::BasicGeoposition) __attribute__((stdcall))")]
        [Obsolete("IWalletRelevantLocation is deprecated and might not work on all platforms. For more info, see MSDN.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, BasicGeoposition, int> put_Position;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        [Obsolete("IWalletRelevantLocation is deprecated and might not work on all platforms. For more info, see MSDN.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_DisplayMessage;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        [Obsolete("IWalletRelevantLocation is deprecated and might not work on all platforms. For more info, see MSDN.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> put_DisplayMessage;
    }
}
