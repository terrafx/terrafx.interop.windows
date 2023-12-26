// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.wallet.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IWalletBarcode.xml' path='doc/member[@name="IWalletBarcode"]/*' />
[Guid("4F857B29-DE80-4EA4-A1CD-81CD084DAC27")]
[NativeTypeName("struct IWalletBarcode : IInspectable")]
[NativeInheritance("IInspectable")]
[Obsolete("IWalletBarcode is deprecated and might not work on all platforms. For more info, see MSDN.")]
public unsafe partial struct IWalletBarcode : IWalletBarcode.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWalletBarcode));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IWalletBarcode*, Guid*, void**, int>)(lpVtbl[0]))((IWalletBarcode*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IWalletBarcode*, uint>)(lpVtbl[1]))((IWalletBarcode*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IWalletBarcode*, uint>)(lpVtbl[2]))((IWalletBarcode*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IWalletBarcode*, uint*, Guid**, int>)(lpVtbl[3]))((IWalletBarcode*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IWalletBarcode*, HSTRING*, int>)(lpVtbl[4]))((IWalletBarcode*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IWalletBarcode*, TrustLevel*, int>)(lpVtbl[5]))((IWalletBarcode*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IWalletBarcode.xml' path='doc/member[@name="IWalletBarcode.get_Symbology"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    [Obsolete("IWalletBarcode is deprecated and might not work on all platforms. For more info, see MSDN.")]
    public HRESULT get_Symbology([NativeTypeName("ABI::Windows::ApplicationModel::Wallet::WalletBarcodeSymbology *")] WalletBarcodeSymbology* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IWalletBarcode*, WalletBarcodeSymbology*, int>)(lpVtbl[6]))((IWalletBarcode*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IWalletBarcode.xml' path='doc/member[@name="IWalletBarcode.get_Value"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    [Obsolete("IWalletBarcode is deprecated and might not work on all platforms. For more info, see MSDN.")]
    public HRESULT get_Value(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IWalletBarcode*, HSTRING*, int>)(lpVtbl[7]))((IWalletBarcode*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IWalletBarcode.xml' path='doc/member[@name="IWalletBarcode.GetImageAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    [Obsolete("IWalletBarcode is deprecated and might not work on all platforms. For more info, see MSDN.")]
    public HRESULT GetImageAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStreams__CIRandomAccessStreamReference_t **")] IAsyncOperation<IntPtr>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IWalletBarcode*, IAsyncOperation<IntPtr>**, int>)(lpVtbl[8]))((IWalletBarcode*)Unsafe.AsPointer(ref this), operation);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        [Obsolete("IWalletBarcode is deprecated and might not work on all platforms. For more info, see MSDN.")]
        HRESULT get_Symbology([NativeTypeName("ABI::Windows::ApplicationModel::Wallet::WalletBarcodeSymbology *")] WalletBarcodeSymbology* value);

        [VtblIndex(7)]
        [Obsolete("IWalletBarcode is deprecated and might not work on all platforms. For more info, see MSDN.")]
        HRESULT get_Value(HSTRING* value);

        [VtblIndex(8)]
        [Obsolete("IWalletBarcode is deprecated and might not work on all platforms. For more info, see MSDN.")]
        HRESULT GetImageAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStreams__CIRandomAccessStreamReference_t **")] IAsyncOperation<IntPtr>** operation);
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

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Wallet::WalletBarcodeSymbology *) __attribute__((stdcall))")]
        [Obsolete("IWalletBarcode is deprecated and might not work on all platforms. For more info, see MSDN.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, WalletBarcodeSymbology*, int> get_Symbology;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        [Obsolete("IWalletBarcode is deprecated and might not work on all platforms. For more info, see MSDN.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Value;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStreams__CIRandomAccessStreamReference_t **) __attribute__((stdcall))")]
        [Obsolete("IWalletBarcode is deprecated and might not work on all platforms. For more info, see MSDN.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAsyncOperation<IntPtr>**, int> GetImageAsync;
    }
}
