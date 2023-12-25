// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.notifications.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IToastCollectionManager.xml' path='doc/member[@name="IToastCollectionManager"]/*' />
[Guid("2A1821FE-179D-49BC-B79D-A527920D3665")]
[NativeTypeName("struct IToastCollectionManager : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IToastCollectionManager : IToastCollectionManager.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IToastCollectionManager));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IToastCollectionManager*, Guid*, void**, int>)(lpVtbl[0]))((IToastCollectionManager*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IToastCollectionManager*, uint>)(lpVtbl[1]))((IToastCollectionManager*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IToastCollectionManager*, uint>)(lpVtbl[2]))((IToastCollectionManager*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IToastCollectionManager*, uint*, Guid**, int>)(lpVtbl[3]))((IToastCollectionManager*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IToastCollectionManager*, HSTRING*, int>)(lpVtbl[4]))((IToastCollectionManager*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IToastCollectionManager*, TrustLevel*, int>)(lpVtbl[5]))((IToastCollectionManager*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IToastCollectionManager.xml' path='doc/member[@name="IToastCollectionManager.SaveToastCollectionAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT SaveToastCollectionAsync([NativeTypeName("ABI::Windows::UI::Notifications::IToastCollection *")] IToastCollection* collection, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IToastCollectionManager*, IToastCollection*, IAsyncAction**, int>)(lpVtbl[6]))((IToastCollectionManager*)Unsafe.AsPointer(ref this), collection, operation);
    }

    /// <include file='IToastCollectionManager.xml' path='doc/member[@name="IToastCollectionManager.FindAllToastCollectionsAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT FindAllToastCollectionsAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CUI__CNotifications__CToastCollection_t **")] IAsyncOperation<IntPtr>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IToastCollectionManager*, IAsyncOperation<IntPtr>**, int>)(lpVtbl[7]))((IToastCollectionManager*)Unsafe.AsPointer(ref this), operation);
    }

    /// <include file='IToastCollectionManager.xml' path='doc/member[@name="IToastCollectionManager.GetToastCollectionAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetToastCollectionAsync(HSTRING collectionId, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CUI__CNotifications__CToastCollection_t **")] IAsyncOperation<IntPtr>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IToastCollectionManager*, HSTRING, IAsyncOperation<IntPtr>**, int>)(lpVtbl[8]))((IToastCollectionManager*)Unsafe.AsPointer(ref this), collectionId, operation);
    }

    /// <include file='IToastCollectionManager.xml' path='doc/member[@name="IToastCollectionManager.RemoveToastCollectionAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT RemoveToastCollectionAsync(HSTRING collectionId, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IToastCollectionManager*, HSTRING, IAsyncAction**, int>)(lpVtbl[9]))((IToastCollectionManager*)Unsafe.AsPointer(ref this), collectionId, operation);
    }

    /// <include file='IToastCollectionManager.xml' path='doc/member[@name="IToastCollectionManager.RemoveAllToastCollectionsAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT RemoveAllToastCollectionsAsync([NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IToastCollectionManager*, IAsyncAction**, int>)(lpVtbl[10]))((IToastCollectionManager*)Unsafe.AsPointer(ref this), operation);
    }

    /// <include file='IToastCollectionManager.xml' path='doc/member[@name="IToastCollectionManager.get_User"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_User([NativeTypeName("ABI::Windows::System::IUser **")] IUser** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IToastCollectionManager*, IUser**, int>)(lpVtbl[11]))((IToastCollectionManager*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IToastCollectionManager.xml' path='doc/member[@name="IToastCollectionManager.get_AppId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_AppId(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IToastCollectionManager*, HSTRING*, int>)(lpVtbl[12]))((IToastCollectionManager*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT SaveToastCollectionAsync([NativeTypeName("ABI::Windows::UI::Notifications::IToastCollection *")] IToastCollection* collection, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** operation);

        [VtblIndex(7)]
        HRESULT FindAllToastCollectionsAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CUI__CNotifications__CToastCollection_t **")] IAsyncOperation<IntPtr>** operation);

        [VtblIndex(8)]
        HRESULT GetToastCollectionAsync(HSTRING collectionId, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CUI__CNotifications__CToastCollection_t **")] IAsyncOperation<IntPtr>** operation);

        [VtblIndex(9)]
        HRESULT RemoveToastCollectionAsync(HSTRING collectionId, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** operation);

        [VtblIndex(10)]
        HRESULT RemoveAllToastCollectionsAsync([NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** operation);

        [VtblIndex(11)]
        HRESULT get_User([NativeTypeName("ABI::Windows::System::IUser **")] IUser** value);

        [VtblIndex(12)]
        HRESULT get_AppId(HSTRING* value);
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

        [NativeTypeName("HRESULT (ABI::Windows::UI::Notifications::IToastCollection *, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IToastCollection*, IAsyncAction**, int> SaveToastCollectionAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CUI__CNotifications__CToastCollection_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAsyncOperation<IntPtr>**, int> FindAllToastCollectionsAsync;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CUI__CNotifications__CToastCollection_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IAsyncOperation<IntPtr>**, int> GetToastCollectionAsync;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IAsyncAction**, int> RemoveToastCollectionAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAsyncAction**, int> RemoveAllToastCollectionsAsync;

        [NativeTypeName("HRESULT (ABI::Windows::System::IUser **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IUser**, int> get_User;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_AppId;
    }
}
