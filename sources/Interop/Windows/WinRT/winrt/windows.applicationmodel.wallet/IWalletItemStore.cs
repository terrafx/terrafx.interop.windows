// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.wallet.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IWalletItemStore.xml' path='doc/member[@name="IWalletItemStore"]/*' />
[Guid("7160484B-6D49-48F8-91A9-40A1D0F13EF4")]
[NativeTypeName("struct IWalletItemStore : IInspectable")]
[NativeInheritance("IInspectable")]
[Obsolete("IWalletItemStore is deprecated and might not work on all platforms. For more info, see MSDN.")]
public unsafe partial struct IWalletItemStore : IWalletItemStore.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWalletItemStore));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IWalletItemStore*, Guid*, void**, int>)(lpVtbl[0]))((IWalletItemStore*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IWalletItemStore*, uint>)(lpVtbl[1]))((IWalletItemStore*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IWalletItemStore*, uint>)(lpVtbl[2]))((IWalletItemStore*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IWalletItemStore*, uint*, Guid**, int>)(lpVtbl[3]))((IWalletItemStore*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IWalletItemStore*, HSTRING*, int>)(lpVtbl[4]))((IWalletItemStore*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IWalletItemStore*, TrustLevel*, int>)(lpVtbl[5]))((IWalletItemStore*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IWalletItemStore.xml' path='doc/member[@name="IWalletItemStore.AddAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    [Obsolete("IWalletItemStore is deprecated and might not work on all platforms. For more info, see MSDN.")]
    public HRESULT AddAsync(HSTRING id, [NativeTypeName("ABI::Windows::ApplicationModel::Wallet::IWalletItem *")] IWalletItem* item, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IWalletItemStore*, HSTRING, IWalletItem*, IAsyncAction**, int>)(lpVtbl[6]))((IWalletItemStore*)Unsafe.AsPointer(ref this), id, item, operation);
    }

    /// <include file='IWalletItemStore.xml' path='doc/member[@name="IWalletItemStore.ClearAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    [Obsolete("IWalletItemStore is deprecated and might not work on all platforms. For more info, see MSDN.")]
    public HRESULT ClearAsync([NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IWalletItemStore*, IAsyncAction**, int>)(lpVtbl[7]))((IWalletItemStore*)Unsafe.AsPointer(ref this), operation);
    }

    /// <include file='IWalletItemStore.xml' path='doc/member[@name="IWalletItemStore.GetWalletItemAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    [Obsolete("IWalletItemStore is deprecated and might not work on all platforms. For more info, see MSDN.")]
    public HRESULT GetWalletItemAsync(HSTRING id, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CWallet__CWalletItem_t **")] IAsyncOperation<Pointer<IWalletItem>>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IWalletItemStore*, HSTRING, IAsyncOperation<Pointer<IWalletItem>>**, int>)(lpVtbl[8]))((IWalletItemStore*)Unsafe.AsPointer(ref this), id, operation);
    }

    /// <include file='IWalletItemStore.xml' path='doc/member[@name="IWalletItemStore.GetItemsAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    [Obsolete("IWalletItemStore is deprecated and might not work on all platforms. For more info, see MSDN.")]
    public HRESULT GetItemsAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CApplicationModel__CWallet__CWalletItem_t **")] IAsyncOperation<Pointer<IVectorView<Pointer<IWalletItem>>>>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IWalletItemStore*, IAsyncOperation<Pointer<IVectorView<Pointer<IWalletItem>>>>**, int>)(lpVtbl[9]))((IWalletItemStore*)Unsafe.AsPointer(ref this), operation);
    }

    /// <include file='IWalletItemStore.xml' path='doc/member[@name="IWalletItemStore.GetItemsWithKindAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    [Obsolete("IWalletItemStore is deprecated and might not work on all platforms. For more info, see MSDN.")]
    public HRESULT GetItemsWithKindAsync([NativeTypeName("ABI::Windows::ApplicationModel::Wallet::WalletItemKind")] WalletItemKind kind, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CApplicationModel__CWallet__CWalletItem_t **")] IAsyncOperation<Pointer<IVectorView<Pointer<IWalletItem>>>>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IWalletItemStore*, WalletItemKind, IAsyncOperation<Pointer<IVectorView<Pointer<IWalletItem>>>>**, int>)(lpVtbl[10]))((IWalletItemStore*)Unsafe.AsPointer(ref this), kind, operation);
    }

    /// <include file='IWalletItemStore.xml' path='doc/member[@name="IWalletItemStore.ImportItemAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    [Obsolete("IWalletItemStore is deprecated and might not work on all platforms. For more info, see MSDN.")]
    public HRESULT ImportItemAsync([NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStreamReference *")] IRandomAccessStreamReference* stream, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CWallet__CWalletItem_t **")] IAsyncOperation<Pointer<IWalletItem>>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IWalletItemStore*, IRandomAccessStreamReference*, IAsyncOperation<Pointer<IWalletItem>>**, int>)(lpVtbl[11]))((IWalletItemStore*)Unsafe.AsPointer(ref this), stream, operation);
    }

    /// <include file='IWalletItemStore.xml' path='doc/member[@name="IWalletItemStore.DeleteAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    [Obsolete("IWalletItemStore is deprecated and might not work on all platforms. For more info, see MSDN.")]
    public HRESULT DeleteAsync(HSTRING id, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IWalletItemStore*, HSTRING, IAsyncAction**, int>)(lpVtbl[12]))((IWalletItemStore*)Unsafe.AsPointer(ref this), id, operation);
    }

    /// <include file='IWalletItemStore.xml' path='doc/member[@name="IWalletItemStore.ShowAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    [Obsolete("IWalletItemStore is deprecated and might not work on all platforms. For more info, see MSDN.")]
    public HRESULT ShowAsync([NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IWalletItemStore*, IAsyncAction**, int>)(lpVtbl[13]))((IWalletItemStore*)Unsafe.AsPointer(ref this), operation);
    }

    /// <include file='IWalletItemStore.xml' path='doc/member[@name="IWalletItemStore.ShowItemAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    [Obsolete("IWalletItemStore is deprecated and might not work on all platforms. For more info, see MSDN.")]
    public HRESULT ShowItemAsync(HSTRING id, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IWalletItemStore*, HSTRING, IAsyncAction**, int>)(lpVtbl[14]))((IWalletItemStore*)Unsafe.AsPointer(ref this), id, operation);
    }

    /// <include file='IWalletItemStore.xml' path='doc/member[@name="IWalletItemStore.UpdateAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    [Obsolete("IWalletItemStore is deprecated and might not work on all platforms. For more info, see MSDN.")]
    public HRESULT UpdateAsync([NativeTypeName("ABI::Windows::ApplicationModel::Wallet::IWalletItem *")] IWalletItem* item, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IWalletItemStore*, IWalletItem*, IAsyncAction**, int>)(lpVtbl[15]))((IWalletItemStore*)Unsafe.AsPointer(ref this), item, operation);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        [Obsolete("IWalletItemStore is deprecated and might not work on all platforms. For more info, see MSDN.")]
        HRESULT AddAsync(HSTRING id, [NativeTypeName("ABI::Windows::ApplicationModel::Wallet::IWalletItem *")] IWalletItem* item, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** operation);

        [VtblIndex(7)]
        [Obsolete("IWalletItemStore is deprecated and might not work on all platforms. For more info, see MSDN.")]
        HRESULT ClearAsync([NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** operation);

        [VtblIndex(8)]
        [Obsolete("IWalletItemStore is deprecated and might not work on all platforms. For more info, see MSDN.")]
        HRESULT GetWalletItemAsync(HSTRING id, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CWallet__CWalletItem_t **")] IAsyncOperation<Pointer<IWalletItem>>** operation);

        [VtblIndex(9)]
        [Obsolete("IWalletItemStore is deprecated and might not work on all platforms. For more info, see MSDN.")]
        HRESULT GetItemsAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CApplicationModel__CWallet__CWalletItem_t **")] IAsyncOperation<Pointer<IVectorView<Pointer<IWalletItem>>>>** operation);

        [VtblIndex(10)]
        [Obsolete("IWalletItemStore is deprecated and might not work on all platforms. For more info, see MSDN.")]
        HRESULT GetItemsWithKindAsync([NativeTypeName("ABI::Windows::ApplicationModel::Wallet::WalletItemKind")] WalletItemKind kind, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CApplicationModel__CWallet__CWalletItem_t **")] IAsyncOperation<Pointer<IVectorView<Pointer<IWalletItem>>>>** operation);

        [VtblIndex(11)]
        [Obsolete("IWalletItemStore is deprecated and might not work on all platforms. For more info, see MSDN.")]
        HRESULT ImportItemAsync([NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStreamReference *")] IRandomAccessStreamReference* stream, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CWallet__CWalletItem_t **")] IAsyncOperation<Pointer<IWalletItem>>** operation);

        [VtblIndex(12)]
        [Obsolete("IWalletItemStore is deprecated and might not work on all platforms. For more info, see MSDN.")]
        HRESULT DeleteAsync(HSTRING id, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** operation);

        [VtblIndex(13)]
        [Obsolete("IWalletItemStore is deprecated and might not work on all platforms. For more info, see MSDN.")]
        HRESULT ShowAsync([NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** operation);

        [VtblIndex(14)]
        [Obsolete("IWalletItemStore is deprecated and might not work on all platforms. For more info, see MSDN.")]
        HRESULT ShowItemAsync(HSTRING id, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** operation);

        [VtblIndex(15)]
        [Obsolete("IWalletItemStore is deprecated and might not work on all platforms. For more info, see MSDN.")]
        HRESULT UpdateAsync([NativeTypeName("ABI::Windows::ApplicationModel::Wallet::IWalletItem *")] IWalletItem* item, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** operation);
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

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::ApplicationModel::Wallet::IWalletItem *, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))")]
        [Obsolete("IWalletItemStore is deprecated and might not work on all platforms. For more info, see MSDN.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IWalletItem*, IAsyncAction**, int> AddAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))")]
        [Obsolete("IWalletItemStore is deprecated and might not work on all platforms. For more info, see MSDN.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAsyncAction**, int> ClearAsync;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CWallet__CWalletItem_t **) __attribute__((stdcall))")]
        [Obsolete("IWalletItemStore is deprecated and might not work on all platforms. For more info, see MSDN.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IAsyncOperation<Pointer<IWalletItem>>**, int> GetWalletItemAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CApplicationModel__CWallet__CWalletItem_t **) __attribute__((stdcall))")]
        [Obsolete("IWalletItemStore is deprecated and might not work on all platforms. For more info, see MSDN.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAsyncOperation<Pointer<IVectorView<Pointer<IWalletItem>>>>**, int> GetItemsAsync;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Wallet::WalletItemKind, ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CApplicationModel__CWallet__CWalletItem_t **) __attribute__((stdcall))")]
        [Obsolete("IWalletItemStore is deprecated and might not work on all platforms. For more info, see MSDN.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, WalletItemKind, IAsyncOperation<Pointer<IVectorView<Pointer<IWalletItem>>>>**, int> GetItemsWithKindAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Streams::IRandomAccessStreamReference *, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CWallet__CWalletItem_t **) __attribute__((stdcall))")]
        [Obsolete("IWalletItemStore is deprecated and might not work on all platforms. For more info, see MSDN.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IRandomAccessStreamReference*, IAsyncOperation<Pointer<IWalletItem>>**, int> ImportItemAsync;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))")]
        [Obsolete("IWalletItemStore is deprecated and might not work on all platforms. For more info, see MSDN.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IAsyncAction**, int> DeleteAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))")]
        [Obsolete("IWalletItemStore is deprecated and might not work on all platforms. For more info, see MSDN.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAsyncAction**, int> ShowAsync;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))")]
        [Obsolete("IWalletItemStore is deprecated and might not work on all platforms. For more info, see MSDN.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IAsyncAction**, int> ShowItemAsync;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Wallet::IWalletItem *, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))")]
        [Obsolete("IWalletItemStore is deprecated and might not work on all platforms. For more info, see MSDN.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IWalletItem*, IAsyncAction**, int> UpdateAsync;
    }
}
