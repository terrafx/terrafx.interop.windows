// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.wallet.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IWalletItemCustomProperty.xml' path='doc/member[@name="IWalletItemCustomProperty"]/*' />
[Guid("B94B40F3-FA00-40FD-98DC-9DE46697F1E7")]
[NativeTypeName("struct IWalletItemCustomProperty : IInspectable")]
[NativeInheritance("IInspectable")]
[Obsolete("IWalletItemCustomProperty is deprecated and might not work on all platforms. For more info, see MSDN.")]
public unsafe partial struct IWalletItemCustomProperty : IWalletItemCustomProperty.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IWalletItemCustomProperty);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IWalletItemCustomProperty*, Guid*, void**, int>)(lpVtbl[0]))((IWalletItemCustomProperty*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IWalletItemCustomProperty*, uint>)(lpVtbl[1]))((IWalletItemCustomProperty*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IWalletItemCustomProperty*, uint>)(lpVtbl[2]))((IWalletItemCustomProperty*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IWalletItemCustomProperty*, uint*, Guid**, int>)(lpVtbl[3]))((IWalletItemCustomProperty*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IWalletItemCustomProperty*, HSTRING*, int>)(lpVtbl[4]))((IWalletItemCustomProperty*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IWalletItemCustomProperty*, TrustLevel*, int>)(lpVtbl[5]))((IWalletItemCustomProperty*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IWalletItemCustomProperty.xml' path='doc/member[@name="IWalletItemCustomProperty.get_Name"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    [Obsolete("IWalletItemCustomProperty is deprecated and might not work on all platforms. For more info, see MSDN.")]
    public HRESULT get_Name(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IWalletItemCustomProperty*, HSTRING*, int>)(lpVtbl[6]))((IWalletItemCustomProperty*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IWalletItemCustomProperty.xml' path='doc/member[@name="IWalletItemCustomProperty.put_Name"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    [Obsolete("IWalletItemCustomProperty is deprecated and might not work on all platforms. For more info, see MSDN.")]
    public HRESULT put_Name(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<IWalletItemCustomProperty*, HSTRING, int>)(lpVtbl[7]))((IWalletItemCustomProperty*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IWalletItemCustomProperty.xml' path='doc/member[@name="IWalletItemCustomProperty.get_Value"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    [Obsolete("IWalletItemCustomProperty is deprecated and might not work on all platforms. For more info, see MSDN.")]
    public HRESULT get_Value(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IWalletItemCustomProperty*, HSTRING*, int>)(lpVtbl[8]))((IWalletItemCustomProperty*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IWalletItemCustomProperty.xml' path='doc/member[@name="IWalletItemCustomProperty.put_Value"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    [Obsolete("IWalletItemCustomProperty is deprecated and might not work on all platforms. For more info, see MSDN.")]
    public HRESULT put_Value(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<IWalletItemCustomProperty*, HSTRING, int>)(lpVtbl[9]))((IWalletItemCustomProperty*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IWalletItemCustomProperty.xml' path='doc/member[@name="IWalletItemCustomProperty.get_AutoDetectLinks"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    [Obsolete("IWalletItemCustomProperty is deprecated and might not work on all platforms. For more info, see MSDN.")]
    public HRESULT get_AutoDetectLinks([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IWalletItemCustomProperty*, byte*, int>)(lpVtbl[10]))((IWalletItemCustomProperty*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IWalletItemCustomProperty.xml' path='doc/member[@name="IWalletItemCustomProperty.put_AutoDetectLinks"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    [Obsolete("IWalletItemCustomProperty is deprecated and might not work on all platforms. For more info, see MSDN.")]
    public HRESULT put_AutoDetectLinks([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged[MemberFunction]<IWalletItemCustomProperty*, byte, int>)(lpVtbl[11]))((IWalletItemCustomProperty*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IWalletItemCustomProperty.xml' path='doc/member[@name="IWalletItemCustomProperty.get_DetailViewPosition"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    [Obsolete("IWalletItemCustomProperty is deprecated and might not work on all platforms. For more info, see MSDN.")]
    public HRESULT get_DetailViewPosition([NativeTypeName("ABI::Windows::ApplicationModel::Wallet::WalletDetailViewPosition *")] WalletDetailViewPosition* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IWalletItemCustomProperty*, WalletDetailViewPosition*, int>)(lpVtbl[12]))((IWalletItemCustomProperty*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IWalletItemCustomProperty.xml' path='doc/member[@name="IWalletItemCustomProperty.put_DetailViewPosition"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    [Obsolete("IWalletItemCustomProperty is deprecated and might not work on all platforms. For more info, see MSDN.")]
    public HRESULT put_DetailViewPosition([NativeTypeName("ABI::Windows::ApplicationModel::Wallet::WalletDetailViewPosition")] WalletDetailViewPosition value)
    {
        return ((delegate* unmanaged[MemberFunction]<IWalletItemCustomProperty*, WalletDetailViewPosition, int>)(lpVtbl[13]))((IWalletItemCustomProperty*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IWalletItemCustomProperty.xml' path='doc/member[@name="IWalletItemCustomProperty.get_SummaryViewPosition"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    [Obsolete("IWalletItemCustomProperty is deprecated and might not work on all platforms. For more info, see MSDN.")]
    public HRESULT get_SummaryViewPosition([NativeTypeName("ABI::Windows::ApplicationModel::Wallet::WalletSummaryViewPosition *")] WalletSummaryViewPosition* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IWalletItemCustomProperty*, WalletSummaryViewPosition*, int>)(lpVtbl[14]))((IWalletItemCustomProperty*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IWalletItemCustomProperty.xml' path='doc/member[@name="IWalletItemCustomProperty.put_SummaryViewPosition"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    [Obsolete("IWalletItemCustomProperty is deprecated and might not work on all platforms. For more info, see MSDN.")]
    public HRESULT put_SummaryViewPosition([NativeTypeName("ABI::Windows::ApplicationModel::Wallet::WalletSummaryViewPosition")] WalletSummaryViewPosition value)
    {
        return ((delegate* unmanaged[MemberFunction]<IWalletItemCustomProperty*, WalletSummaryViewPosition, int>)(lpVtbl[15]))((IWalletItemCustomProperty*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        [Obsolete("IWalletItemCustomProperty is deprecated and might not work on all platforms. For more info, see MSDN.")]
        HRESULT get_Name(HSTRING* value);

        [VtblIndex(7)]
        [Obsolete("IWalletItemCustomProperty is deprecated and might not work on all platforms. For more info, see MSDN.")]
        HRESULT put_Name(HSTRING value);

        [VtblIndex(8)]
        [Obsolete("IWalletItemCustomProperty is deprecated and might not work on all platforms. For more info, see MSDN.")]
        HRESULT get_Value(HSTRING* value);

        [VtblIndex(9)]
        [Obsolete("IWalletItemCustomProperty is deprecated and might not work on all platforms. For more info, see MSDN.")]
        HRESULT put_Value(HSTRING value);

        [VtblIndex(10)]
        [Obsolete("IWalletItemCustomProperty is deprecated and might not work on all platforms. For more info, see MSDN.")]
        HRESULT get_AutoDetectLinks([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(11)]
        [Obsolete("IWalletItemCustomProperty is deprecated and might not work on all platforms. For more info, see MSDN.")]
        HRESULT put_AutoDetectLinks([NativeTypeName("boolean")] byte value);

        [VtblIndex(12)]
        [Obsolete("IWalletItemCustomProperty is deprecated and might not work on all platforms. For more info, see MSDN.")]
        HRESULT get_DetailViewPosition([NativeTypeName("ABI::Windows::ApplicationModel::Wallet::WalletDetailViewPosition *")] WalletDetailViewPosition* value);

        [VtblIndex(13)]
        [Obsolete("IWalletItemCustomProperty is deprecated and might not work on all platforms. For more info, see MSDN.")]
        HRESULT put_DetailViewPosition([NativeTypeName("ABI::Windows::ApplicationModel::Wallet::WalletDetailViewPosition")] WalletDetailViewPosition value);

        [VtblIndex(14)]
        [Obsolete("IWalletItemCustomProperty is deprecated and might not work on all platforms. For more info, see MSDN.")]
        HRESULT get_SummaryViewPosition([NativeTypeName("ABI::Windows::ApplicationModel::Wallet::WalletSummaryViewPosition *")] WalletSummaryViewPosition* value);

        [VtblIndex(15)]
        [Obsolete("IWalletItemCustomProperty is deprecated and might not work on all platforms. For more info, see MSDN.")]
        HRESULT put_SummaryViewPosition([NativeTypeName("ABI::Windows::ApplicationModel::Wallet::WalletSummaryViewPosition")] WalletSummaryViewPosition value);
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

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        [Obsolete("IWalletItemCustomProperty is deprecated and might not work on all platforms. For more info, see MSDN.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Name;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        [Obsolete("IWalletItemCustomProperty is deprecated and might not work on all platforms. For more info, see MSDN.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> put_Name;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        [Obsolete("IWalletItemCustomProperty is deprecated and might not work on all platforms. For more info, see MSDN.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Value;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        [Obsolete("IWalletItemCustomProperty is deprecated and might not work on all platforms. For more info, see MSDN.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> put_Value;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        [Obsolete("IWalletItemCustomProperty is deprecated and might not work on all platforms. For more info, see MSDN.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_AutoDetectLinks;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        [Obsolete("IWalletItemCustomProperty is deprecated and might not work on all platforms. For more info, see MSDN.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, int> put_AutoDetectLinks;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Wallet::WalletDetailViewPosition *) __attribute__((stdcall))")]
        [Obsolete("IWalletItemCustomProperty is deprecated and might not work on all platforms. For more info, see MSDN.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, WalletDetailViewPosition*, int> get_DetailViewPosition;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Wallet::WalletDetailViewPosition) __attribute__((stdcall))")]
        [Obsolete("IWalletItemCustomProperty is deprecated and might not work on all platforms. For more info, see MSDN.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, WalletDetailViewPosition, int> put_DetailViewPosition;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Wallet::WalletSummaryViewPosition *) __attribute__((stdcall))")]
        [Obsolete("IWalletItemCustomProperty is deprecated and might not work on all platforms. For more info, see MSDN.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, WalletSummaryViewPosition*, int> get_SummaryViewPosition;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Wallet::WalletSummaryViewPosition) __attribute__((stdcall))")]
        [Obsolete("IWalletItemCustomProperty is deprecated and might not work on all platforms. For more info, see MSDN.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, WalletSummaryViewPosition, int> put_SummaryViewPosition;
    }
}
