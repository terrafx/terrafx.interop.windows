// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.storage.search.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IStorageQueryResultBase.xml' path='doc/member[@name="IStorageQueryResultBase"]/*' />
[Guid("C297D70D-7353-47AB-BA58-8C61425DC54B")]
[NativeTypeName("struct IStorageQueryResultBase : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IStorageQueryResultBase : IStorageQueryResultBase.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IStorageQueryResultBase);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageQueryResultBase*, Guid*, void**, int>)(lpVtbl[0]))((IStorageQueryResultBase*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageQueryResultBase*, uint>)(lpVtbl[1]))((IStorageQueryResultBase*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageQueryResultBase*, uint>)(lpVtbl[2]))((IStorageQueryResultBase*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageQueryResultBase*, uint*, Guid**, int>)(lpVtbl[3]))((IStorageQueryResultBase*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageQueryResultBase*, HSTRING*, int>)(lpVtbl[4]))((IStorageQueryResultBase*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageQueryResultBase*, TrustLevel*, int>)(lpVtbl[5]))((IStorageQueryResultBase*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IStorageQueryResultBase.xml' path='doc/member[@name="IStorageQueryResultBase.GetItemCountAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetItemCountAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_UINT32_t **")] IAsyncOperation<uint>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageQueryResultBase*, IAsyncOperation<uint>**, int>)(lpVtbl[6]))((IStorageQueryResultBase*)Unsafe.AsPointer(ref this), operation);
    }

    /// <include file='IStorageQueryResultBase.xml' path='doc/member[@name="IStorageQueryResultBase.get_Folder"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Folder([NativeTypeName("ABI::Windows::Storage::IStorageFolder **")] IStorageFolder** container)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageQueryResultBase*, IStorageFolder**, int>)(lpVtbl[7]))((IStorageQueryResultBase*)Unsafe.AsPointer(ref this), container);
    }

    /// <include file='IStorageQueryResultBase.xml' path='doc/member[@name="IStorageQueryResultBase.add_ContentsChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT add_ContentsChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CStorage__CSearch__CIStorageQueryResultBase_IInspectable_t *")] ITypedEventHandler<Pointer<IStorageQueryResultBase>, Pointer<IInspectable>>* handler, EventRegistrationToken* eventCookie)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageQueryResultBase*, ITypedEventHandler<Pointer<IStorageQueryResultBase>, Pointer<IInspectable>>*, EventRegistrationToken*, int>)(lpVtbl[8]))((IStorageQueryResultBase*)Unsafe.AsPointer(ref this), handler, eventCookie);
    }

    /// <include file='IStorageQueryResultBase.xml' path='doc/member[@name="IStorageQueryResultBase.remove_ContentsChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT remove_ContentsChanged(EventRegistrationToken eventCookie)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageQueryResultBase*, EventRegistrationToken, int>)(lpVtbl[9]))((IStorageQueryResultBase*)Unsafe.AsPointer(ref this), eventCookie);
    }

    /// <include file='IStorageQueryResultBase.xml' path='doc/member[@name="IStorageQueryResultBase.add_OptionsChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT add_OptionsChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CStorage__CSearch__CIStorageQueryResultBase_IInspectable_t *")] ITypedEventHandler<Pointer<IStorageQueryResultBase>, Pointer<IInspectable>>* changedHandler, EventRegistrationToken* eventCookie)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageQueryResultBase*, ITypedEventHandler<Pointer<IStorageQueryResultBase>, Pointer<IInspectable>>*, EventRegistrationToken*, int>)(lpVtbl[10]))((IStorageQueryResultBase*)Unsafe.AsPointer(ref this), changedHandler, eventCookie);
    }

    /// <include file='IStorageQueryResultBase.xml' path='doc/member[@name="IStorageQueryResultBase.remove_OptionsChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT remove_OptionsChanged(EventRegistrationToken eventCookie)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageQueryResultBase*, EventRegistrationToken, int>)(lpVtbl[11]))((IStorageQueryResultBase*)Unsafe.AsPointer(ref this), eventCookie);
    }

    /// <include file='IStorageQueryResultBase.xml' path='doc/member[@name="IStorageQueryResultBase.FindStartIndexAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT FindStartIndexAsync(IInspectable* value, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_UINT32_t **")] IAsyncOperation<uint>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageQueryResultBase*, IInspectable*, IAsyncOperation<uint>**, int>)(lpVtbl[12]))((IStorageQueryResultBase*)Unsafe.AsPointer(ref this), value, operation);
    }

    /// <include file='IStorageQueryResultBase.xml' path='doc/member[@name="IStorageQueryResultBase.GetCurrentQueryOptions"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT GetCurrentQueryOptions([NativeTypeName("ABI::Windows::Storage::Search::IQueryOptions **")] IQueryOptions** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageQueryResultBase*, IQueryOptions**, int>)(lpVtbl[13]))((IStorageQueryResultBase*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IStorageQueryResultBase.xml' path='doc/member[@name="IStorageQueryResultBase.ApplyNewQueryOptions"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT ApplyNewQueryOptions([NativeTypeName("ABI::Windows::Storage::Search::IQueryOptions *")] IQueryOptions* newQueryOptions)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageQueryResultBase*, IQueryOptions*, int>)(lpVtbl[14]))((IStorageQueryResultBase*)Unsafe.AsPointer(ref this), newQueryOptions);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT GetItemCountAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_UINT32_t **")] IAsyncOperation<uint>** operation);

        [VtblIndex(7)]
        HRESULT get_Folder([NativeTypeName("ABI::Windows::Storage::IStorageFolder **")] IStorageFolder** container);

        [VtblIndex(8)]
        HRESULT add_ContentsChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CStorage__CSearch__CIStorageQueryResultBase_IInspectable_t *")] ITypedEventHandler<Pointer<IStorageQueryResultBase>, Pointer<IInspectable>>* handler, EventRegistrationToken* eventCookie);

        [VtblIndex(9)]
        HRESULT remove_ContentsChanged(EventRegistrationToken eventCookie);

        [VtblIndex(10)]
        HRESULT add_OptionsChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CStorage__CSearch__CIStorageQueryResultBase_IInspectable_t *")] ITypedEventHandler<Pointer<IStorageQueryResultBase>, Pointer<IInspectable>>* changedHandler, EventRegistrationToken* eventCookie);

        [VtblIndex(11)]
        HRESULT remove_OptionsChanged(EventRegistrationToken eventCookie);

        [VtblIndex(12)]
        HRESULT FindStartIndexAsync(IInspectable* value, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_UINT32_t **")] IAsyncOperation<uint>** operation);

        [VtblIndex(13)]
        HRESULT GetCurrentQueryOptions([NativeTypeName("ABI::Windows::Storage::Search::IQueryOptions **")] IQueryOptions** value);

        [VtblIndex(14)]
        HRESULT ApplyNewQueryOptions([NativeTypeName("ABI::Windows::Storage::Search::IQueryOptions *")] IQueryOptions* newQueryOptions);
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1_UINT32_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAsyncOperation<uint>**, int> GetItemCountAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::IStorageFolder **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IStorageFolder**, int> get_Folder;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CStorage__CSearch__CIStorageQueryResultBase_IInspectable_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IStorageQueryResultBase>, Pointer<IInspectable>>*, EventRegistrationToken*, int> add_ContentsChanged;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_ContentsChanged;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CStorage__CSearch__CIStorageQueryResultBase_IInspectable_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IStorageQueryResultBase>, Pointer<IInspectable>>*, EventRegistrationToken*, int> add_OptionsChanged;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_OptionsChanged;

        [NativeTypeName("HRESULT (IInspectable *, ABI::Windows::Foundation::__FIAsyncOperation_1_UINT32_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IInspectable*, IAsyncOperation<uint>**, int> FindStartIndexAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Search::IQueryOptions **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IQueryOptions**, int> GetCurrentQueryOptions;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Search::IQueryOptions *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IQueryOptions*, int> ApplyNewQueryOptions;
    }
}
