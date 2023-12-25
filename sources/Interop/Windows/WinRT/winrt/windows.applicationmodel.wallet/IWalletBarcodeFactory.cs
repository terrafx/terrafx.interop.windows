// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.wallet.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IWalletBarcodeFactory.xml' path='doc/member[@name="IWalletBarcodeFactory"]/*' />
[Guid("30117161-ED9C-469E-BBFD-306C95EA7108")]
[NativeTypeName("struct IWalletBarcodeFactory : IInspectable")]
[NativeInheritance("IInspectable")]
[Obsolete("IWalletBarcodeFactory is deprecated and might not work on all platforms. For more info, see MSDN.")]
public unsafe partial struct IWalletBarcodeFactory : IWalletBarcodeFactory.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWalletBarcodeFactory));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IWalletBarcodeFactory*, Guid*, void**, int>)(lpVtbl[0]))((IWalletBarcodeFactory*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IWalletBarcodeFactory*, uint>)(lpVtbl[1]))((IWalletBarcodeFactory*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IWalletBarcodeFactory*, uint>)(lpVtbl[2]))((IWalletBarcodeFactory*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IWalletBarcodeFactory*, uint*, Guid**, int>)(lpVtbl[3]))((IWalletBarcodeFactory*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IWalletBarcodeFactory*, HSTRING*, int>)(lpVtbl[4]))((IWalletBarcodeFactory*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IWalletBarcodeFactory*, TrustLevel*, int>)(lpVtbl[5]))((IWalletBarcodeFactory*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IWalletBarcodeFactory.xml' path='doc/member[@name="IWalletBarcodeFactory.CreateWalletBarcode"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    [Obsolete("IWalletBarcodeFactory is deprecated and might not work on all platforms. For more info, see MSDN.")]
    public HRESULT CreateWalletBarcode([NativeTypeName("ABI::Windows::ApplicationModel::Wallet::WalletBarcodeSymbology")] WalletBarcodeSymbology symbology, HSTRING value, [NativeTypeName("ABI::Windows::ApplicationModel::Wallet::IWalletBarcode **")] IWalletBarcode** barcode)
    {
        return ((delegate* unmanaged[MemberFunction]<IWalletBarcodeFactory*, WalletBarcodeSymbology, HSTRING, IWalletBarcode**, int>)(lpVtbl[6]))((IWalletBarcodeFactory*)Unsafe.AsPointer(ref this), symbology, value, barcode);
    }

    /// <include file='IWalletBarcodeFactory.xml' path='doc/member[@name="IWalletBarcodeFactory.CreateCustomWalletBarcode"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    [Obsolete("IWalletBarcodeFactory is deprecated and might not work on all platforms. For more info, see MSDN.")]
    public HRESULT CreateCustomWalletBarcode([NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStreamReference *")] IRandomAccessStreamReference* streamToBarcodeImage, [NativeTypeName("ABI::Windows::ApplicationModel::Wallet::IWalletBarcode **")] IWalletBarcode** barcode)
    {
        return ((delegate* unmanaged[MemberFunction]<IWalletBarcodeFactory*, IRandomAccessStreamReference*, IWalletBarcode**, int>)(lpVtbl[7]))((IWalletBarcodeFactory*)Unsafe.AsPointer(ref this), streamToBarcodeImage, barcode);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        [Obsolete("IWalletBarcodeFactory is deprecated and might not work on all platforms. For more info, see MSDN.")]
        HRESULT CreateWalletBarcode([NativeTypeName("ABI::Windows::ApplicationModel::Wallet::WalletBarcodeSymbology")] WalletBarcodeSymbology symbology, HSTRING value, [NativeTypeName("ABI::Windows::ApplicationModel::Wallet::IWalletBarcode **")] IWalletBarcode** barcode);

        [VtblIndex(7)]
        [Obsolete("IWalletBarcodeFactory is deprecated and might not work on all platforms. For more info, see MSDN.")]
        HRESULT CreateCustomWalletBarcode([NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStreamReference *")] IRandomAccessStreamReference* streamToBarcodeImage, [NativeTypeName("ABI::Windows::ApplicationModel::Wallet::IWalletBarcode **")] IWalletBarcode** barcode);
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

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Wallet::WalletBarcodeSymbology, HSTRING, ABI::Windows::ApplicationModel::Wallet::IWalletBarcode **) __attribute__((stdcall))")]
        [Obsolete("IWalletBarcodeFactory is deprecated and might not work on all platforms. For more info, see MSDN.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, WalletBarcodeSymbology, HSTRING, IWalletBarcode**, int> CreateWalletBarcode;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Streams::IRandomAccessStreamReference *, ABI::Windows::ApplicationModel::Wallet::IWalletBarcode **) __attribute__((stdcall))")]
        [Obsolete("IWalletBarcodeFactory is deprecated and might not work on all platforms. For more info, see MSDN.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IRandomAccessStreamReference*, IWalletBarcode**, int> CreateCustomWalletBarcode;
    }
}
