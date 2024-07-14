// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.storage.provider.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IStorageProviderStatusUI.xml' path='doc/member[@name="IStorageProviderStatusUI"]/*' />
[Guid("D6B6A758-198D-5B80-977F-5FF73DA33118")]
[NativeTypeName("struct IStorageProviderStatusUI : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IStorageProviderStatusUI : IStorageProviderStatusUI.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IStorageProviderStatusUI));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageProviderStatusUI*, Guid*, void**, int>)(lpVtbl[0]))((IStorageProviderStatusUI*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageProviderStatusUI*, uint>)(lpVtbl[1]))((IStorageProviderStatusUI*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageProviderStatusUI*, uint>)(lpVtbl[2]))((IStorageProviderStatusUI*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageProviderStatusUI*, uint*, Guid**, int>)(lpVtbl[3]))((IStorageProviderStatusUI*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageProviderStatusUI*, HSTRING*, int>)(lpVtbl[4]))((IStorageProviderStatusUI*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageProviderStatusUI*, TrustLevel*, int>)(lpVtbl[5]))((IStorageProviderStatusUI*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IStorageProviderStatusUI.xml' path='doc/member[@name="IStorageProviderStatusUI.get_ProviderState"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_ProviderState([NativeTypeName("ABI::Windows::Storage::Provider::StorageProviderState *")] StorageProviderState* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageProviderStatusUI*, StorageProviderState*, int>)(lpVtbl[6]))((IStorageProviderStatusUI*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IStorageProviderStatusUI.xml' path='doc/member[@name="IStorageProviderStatusUI.put_ProviderState"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_ProviderState([NativeTypeName("ABI::Windows::Storage::Provider::StorageProviderState")] StorageProviderState value)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageProviderStatusUI*, StorageProviderState, int>)(lpVtbl[7]))((IStorageProviderStatusUI*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IStorageProviderStatusUI.xml' path='doc/member[@name="IStorageProviderStatusUI.get_ProviderStateLabel"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_ProviderStateLabel(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageProviderStatusUI*, HSTRING*, int>)(lpVtbl[8]))((IStorageProviderStatusUI*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IStorageProviderStatusUI.xml' path='doc/member[@name="IStorageProviderStatusUI.put_ProviderStateLabel"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_ProviderStateLabel(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageProviderStatusUI*, HSTRING, int>)(lpVtbl[9]))((IStorageProviderStatusUI*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IStorageProviderStatusUI.xml' path='doc/member[@name="IStorageProviderStatusUI.get_ProviderStateIcon"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_ProviderStateIcon([NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass **")] IUriRuntimeClass** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageProviderStatusUI*, IUriRuntimeClass**, int>)(lpVtbl[10]))((IStorageProviderStatusUI*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IStorageProviderStatusUI.xml' path='doc/member[@name="IStorageProviderStatusUI.put_ProviderStateIcon"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_ProviderStateIcon([NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageProviderStatusUI*, IUriRuntimeClass*, int>)(lpVtbl[11]))((IStorageProviderStatusUI*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IStorageProviderStatusUI.xml' path='doc/member[@name="IStorageProviderStatusUI.get_SyncStatusCommand"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_SyncStatusCommand([NativeTypeName("ABI::Windows::Storage::Provider::IStorageProviderUICommand **")] IStorageProviderUICommand** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageProviderStatusUI*, IStorageProviderUICommand**, int>)(lpVtbl[12]))((IStorageProviderStatusUI*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IStorageProviderStatusUI.xml' path='doc/member[@name="IStorageProviderStatusUI.put_SyncStatusCommand"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT put_SyncStatusCommand([NativeTypeName("ABI::Windows::Storage::Provider::IStorageProviderUICommand *")] IStorageProviderUICommand* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageProviderStatusUI*, IStorageProviderUICommand*, int>)(lpVtbl[13]))((IStorageProviderStatusUI*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IStorageProviderStatusUI.xml' path='doc/member[@name="IStorageProviderStatusUI.get_QuotaUI"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_QuotaUI([NativeTypeName("ABI::Windows::Storage::Provider::IStorageProviderQuotaUI **")] IStorageProviderQuotaUI** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageProviderStatusUI*, IStorageProviderQuotaUI**, int>)(lpVtbl[14]))((IStorageProviderStatusUI*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IStorageProviderStatusUI.xml' path='doc/member[@name="IStorageProviderStatusUI.put_QuotaUI"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT put_QuotaUI([NativeTypeName("ABI::Windows::Storage::Provider::IStorageProviderQuotaUI *")] IStorageProviderQuotaUI* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageProviderStatusUI*, IStorageProviderQuotaUI*, int>)(lpVtbl[15]))((IStorageProviderStatusUI*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IStorageProviderStatusUI.xml' path='doc/member[@name="IStorageProviderStatusUI.get_MoreInfoUI"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_MoreInfoUI([NativeTypeName("ABI::Windows::Storage::Provider::IStorageProviderMoreInfoUI **")] IStorageProviderMoreInfoUI** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageProviderStatusUI*, IStorageProviderMoreInfoUI**, int>)(lpVtbl[16]))((IStorageProviderStatusUI*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IStorageProviderStatusUI.xml' path='doc/member[@name="IStorageProviderStatusUI.put_MoreInfoUI"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT put_MoreInfoUI([NativeTypeName("ABI::Windows::Storage::Provider::IStorageProviderMoreInfoUI *")] IStorageProviderMoreInfoUI* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageProviderStatusUI*, IStorageProviderMoreInfoUI*, int>)(lpVtbl[17]))((IStorageProviderStatusUI*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IStorageProviderStatusUI.xml' path='doc/member[@name="IStorageProviderStatusUI.get_ProviderPrimaryCommand"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT get_ProviderPrimaryCommand([NativeTypeName("ABI::Windows::Storage::Provider::IStorageProviderUICommand **")] IStorageProviderUICommand** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageProviderStatusUI*, IStorageProviderUICommand**, int>)(lpVtbl[18]))((IStorageProviderStatusUI*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IStorageProviderStatusUI.xml' path='doc/member[@name="IStorageProviderStatusUI.put_ProviderPrimaryCommand"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT put_ProviderPrimaryCommand([NativeTypeName("ABI::Windows::Storage::Provider::IStorageProviderUICommand *")] IStorageProviderUICommand* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageProviderStatusUI*, IStorageProviderUICommand*, int>)(lpVtbl[19]))((IStorageProviderStatusUI*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IStorageProviderStatusUI.xml' path='doc/member[@name="IStorageProviderStatusUI.get_ProviderSecondaryCommands"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT get_ProviderSecondaryCommands([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CStorage__CProvider__CIStorageProviderUICommand_t **")] IVector<Pointer<IStorageProviderUICommand>>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageProviderStatusUI*, IVector<Pointer<IStorageProviderUICommand>>**, int>)(lpVtbl[20]))((IStorageProviderStatusUI*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IStorageProviderStatusUI.xml' path='doc/member[@name="IStorageProviderStatusUI.put_ProviderSecondaryCommands"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT put_ProviderSecondaryCommands([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CStorage__CProvider__CIStorageProviderUICommand_t *")] IVector<Pointer<IStorageProviderUICommand>>* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageProviderStatusUI*, IVector<Pointer<IStorageProviderUICommand>>*, int>)(lpVtbl[21]))((IStorageProviderStatusUI*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_ProviderState([NativeTypeName("ABI::Windows::Storage::Provider::StorageProviderState *")] StorageProviderState* value);

        [VtblIndex(7)]
        HRESULT put_ProviderState([NativeTypeName("ABI::Windows::Storage::Provider::StorageProviderState")] StorageProviderState value);

        [VtblIndex(8)]
        HRESULT get_ProviderStateLabel(HSTRING* value);

        [VtblIndex(9)]
        HRESULT put_ProviderStateLabel(HSTRING value);

        [VtblIndex(10)]
        HRESULT get_ProviderStateIcon([NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass **")] IUriRuntimeClass** value);

        [VtblIndex(11)]
        HRESULT put_ProviderStateIcon([NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass* value);

        [VtblIndex(12)]
        HRESULT get_SyncStatusCommand([NativeTypeName("ABI::Windows::Storage::Provider::IStorageProviderUICommand **")] IStorageProviderUICommand** value);

        [VtblIndex(13)]
        HRESULT put_SyncStatusCommand([NativeTypeName("ABI::Windows::Storage::Provider::IStorageProviderUICommand *")] IStorageProviderUICommand* value);

        [VtblIndex(14)]
        HRESULT get_QuotaUI([NativeTypeName("ABI::Windows::Storage::Provider::IStorageProviderQuotaUI **")] IStorageProviderQuotaUI** value);

        [VtblIndex(15)]
        HRESULT put_QuotaUI([NativeTypeName("ABI::Windows::Storage::Provider::IStorageProviderQuotaUI *")] IStorageProviderQuotaUI* value);

        [VtblIndex(16)]
        HRESULT get_MoreInfoUI([NativeTypeName("ABI::Windows::Storage::Provider::IStorageProviderMoreInfoUI **")] IStorageProviderMoreInfoUI** value);

        [VtblIndex(17)]
        HRESULT put_MoreInfoUI([NativeTypeName("ABI::Windows::Storage::Provider::IStorageProviderMoreInfoUI *")] IStorageProviderMoreInfoUI* value);

        [VtblIndex(18)]
        HRESULT get_ProviderPrimaryCommand([NativeTypeName("ABI::Windows::Storage::Provider::IStorageProviderUICommand **")] IStorageProviderUICommand** value);

        [VtblIndex(19)]
        HRESULT put_ProviderPrimaryCommand([NativeTypeName("ABI::Windows::Storage::Provider::IStorageProviderUICommand *")] IStorageProviderUICommand* value);

        [VtblIndex(20)]
        HRESULT get_ProviderSecondaryCommands([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CStorage__CProvider__CIStorageProviderUICommand_t **")] IVector<Pointer<IStorageProviderUICommand>>** value);

        [VtblIndex(21)]
        HRESULT put_ProviderSecondaryCommands([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CStorage__CProvider__CIStorageProviderUICommand_t *")] IVector<Pointer<IStorageProviderUICommand>>* value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Provider::StorageProviderState *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, StorageProviderState*, int> get_ProviderState;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Provider::StorageProviderState) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, StorageProviderState, int> put_ProviderState;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_ProviderStateLabel;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> put_ProviderStateLabel;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::IUriRuntimeClass **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IUriRuntimeClass**, int> get_ProviderStateIcon;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::IUriRuntimeClass *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IUriRuntimeClass*, int> put_ProviderStateIcon;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Provider::IStorageProviderUICommand **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IStorageProviderUICommand**, int> get_SyncStatusCommand;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Provider::IStorageProviderUICommand *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IStorageProviderUICommand*, int> put_SyncStatusCommand;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Provider::IStorageProviderQuotaUI **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IStorageProviderQuotaUI**, int> get_QuotaUI;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Provider::IStorageProviderQuotaUI *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IStorageProviderQuotaUI*, int> put_QuotaUI;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Provider::IStorageProviderMoreInfoUI **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IStorageProviderMoreInfoUI**, int> get_MoreInfoUI;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Provider::IStorageProviderMoreInfoUI *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IStorageProviderMoreInfoUI*, int> put_MoreInfoUI;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Provider::IStorageProviderUICommand **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IStorageProviderUICommand**, int> get_ProviderPrimaryCommand;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Provider::IStorageProviderUICommand *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IStorageProviderUICommand*, int> put_ProviderPrimaryCommand;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CStorage__CProvider__CIStorageProviderUICommand_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVector<Pointer<IStorageProviderUICommand>>**, int> get_ProviderSecondaryCommands;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CStorage__CProvider__CIStorageProviderUICommand_t *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVector<Pointer<IStorageProviderUICommand>>*, int> put_ProviderSecondaryCommands;
    }
}
