// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.activation.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IWalletActionActivatedEventArgs.xml' path='doc/member[@name="IWalletActionActivatedEventArgs"]/*' />
[Guid("FCFC027B-1A1A-4D22-923F-AE6F45FA52D9")]
[NativeTypeName("struct IWalletActionActivatedEventArgs : IInspectable")]
[NativeInheritance("IInspectable")]
[Obsolete("IWalletActionActivatedEventArgs is deprecated and might not work on all platforms. For more info, see MSDN.")]
public unsafe partial struct IWalletActionActivatedEventArgs : IWalletActionActivatedEventArgs.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IWalletActionActivatedEventArgs);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IWalletActionActivatedEventArgs*, Guid*, void**, int>)(lpVtbl[0]))((IWalletActionActivatedEventArgs*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IWalletActionActivatedEventArgs*, uint>)(lpVtbl[1]))((IWalletActionActivatedEventArgs*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IWalletActionActivatedEventArgs*, uint>)(lpVtbl[2]))((IWalletActionActivatedEventArgs*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IWalletActionActivatedEventArgs*, uint*, Guid**, int>)(lpVtbl[3]))((IWalletActionActivatedEventArgs*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IWalletActionActivatedEventArgs*, HSTRING*, int>)(lpVtbl[4]))((IWalletActionActivatedEventArgs*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IWalletActionActivatedEventArgs*, TrustLevel*, int>)(lpVtbl[5]))((IWalletActionActivatedEventArgs*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IWalletActionActivatedEventArgs.xml' path='doc/member[@name="IWalletActionActivatedEventArgs.get_ItemId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    [Obsolete("IWalletActionActivatedEventArgs is deprecated and might not work on all platforms. For more info, see MSDN.")]
    public HRESULT get_ItemId(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IWalletActionActivatedEventArgs*, HSTRING*, int>)(lpVtbl[6]))((IWalletActionActivatedEventArgs*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IWalletActionActivatedEventArgs.xml' path='doc/member[@name="IWalletActionActivatedEventArgs.get_ActionKind"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    [Obsolete("IWalletActionActivatedEventArgs is deprecated and might not work on all platforms. For more info, see MSDN.")]
    public HRESULT get_ActionKind([NativeTypeName("ABI::Windows::ApplicationModel::Wallet::WalletActionKind *")] WalletActionKind* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IWalletActionActivatedEventArgs*, WalletActionKind*, int>)(lpVtbl[7]))((IWalletActionActivatedEventArgs*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IWalletActionActivatedEventArgs.xml' path='doc/member[@name="IWalletActionActivatedEventArgs.get_ActionId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    [Obsolete("IWalletActionActivatedEventArgs is deprecated and might not work on all platforms. For more info, see MSDN.")]
    public HRESULT get_ActionId(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IWalletActionActivatedEventArgs*, HSTRING*, int>)(lpVtbl[8]))((IWalletActionActivatedEventArgs*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        [Obsolete("IWalletActionActivatedEventArgs is deprecated and might not work on all platforms. For more info, see MSDN.")]
        HRESULT get_ItemId(HSTRING* value);

        [VtblIndex(7)]
        [Obsolete("IWalletActionActivatedEventArgs is deprecated and might not work on all platforms. For more info, see MSDN.")]
        HRESULT get_ActionKind([NativeTypeName("ABI::Windows::ApplicationModel::Wallet::WalletActionKind *")] WalletActionKind* value);

        [VtblIndex(8)]
        [Obsolete("IWalletActionActivatedEventArgs is deprecated and might not work on all platforms. For more info, see MSDN.")]
        HRESULT get_ActionId(HSTRING* value);
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
        [Obsolete("IWalletActionActivatedEventArgs is deprecated and might not work on all platforms. For more info, see MSDN.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_ItemId;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Wallet::WalletActionKind *) __attribute__((stdcall))")]
        [Obsolete("IWalletActionActivatedEventArgs is deprecated and might not work on all platforms. For more info, see MSDN.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, WalletActionKind*, int> get_ActionKind;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        [Obsolete("IWalletActionActivatedEventArgs is deprecated and might not work on all platforms. For more info, see MSDN.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_ActionId;
    }
}
