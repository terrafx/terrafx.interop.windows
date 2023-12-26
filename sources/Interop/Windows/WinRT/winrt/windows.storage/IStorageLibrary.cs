// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.storage.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IStorageLibrary.xml' path='doc/member[@name="IStorageLibrary"]/*' />
[Guid("1EDD7103-0E5E-4D6C-B5E8-9318983D6A03")]
[NativeTypeName("struct IStorageLibrary : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IStorageLibrary : IStorageLibrary.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IStorageLibrary));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageLibrary*, Guid*, void**, int>)(lpVtbl[0]))((IStorageLibrary*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageLibrary*, uint>)(lpVtbl[1]))((IStorageLibrary*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageLibrary*, uint>)(lpVtbl[2]))((IStorageLibrary*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageLibrary*, uint*, Guid**, int>)(lpVtbl[3]))((IStorageLibrary*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageLibrary*, HSTRING*, int>)(lpVtbl[4]))((IStorageLibrary*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageLibrary*, TrustLevel*, int>)(lpVtbl[5]))((IStorageLibrary*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IStorageLibrary.xml' path='doc/member[@name="IStorageLibrary.RequestAddFolderAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT RequestAddFolderAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStorageFolder_t **")] IAsyncOperation<IntPtr>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageLibrary*, IAsyncOperation<IntPtr>**, int>)(lpVtbl[6]))((IStorageLibrary*)Unsafe.AsPointer(ref this), operation);
    }

    /// <include file='IStorageLibrary.xml' path='doc/member[@name="IStorageLibrary.RequestRemoveFolderAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT RequestRemoveFolderAsync([NativeTypeName("ABI::Windows::Storage::IStorageFolder *")] IStorageFolder* folder, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")] IAsyncOperation<bool>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageLibrary*, IStorageFolder*, IAsyncOperation<bool>**, int>)(lpVtbl[7]))((IStorageLibrary*)Unsafe.AsPointer(ref this), folder, operation);
    }

    /// <include file='IStorageLibrary.xml' path='doc/member[@name="IStorageLibrary.get_Folders"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_Folders([NativeTypeName("ABI::Windows::Foundation::Collections::__FIObservableVector_1_Windows__CStorage__CStorageFolder_t **")] IObservableVector<IntPtr>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageLibrary*, IObservableVector<IntPtr>**, int>)(lpVtbl[8]))((IStorageLibrary*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IStorageLibrary.xml' path='doc/member[@name="IStorageLibrary.get_SaveFolder"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_SaveFolder([NativeTypeName("ABI::Windows::Storage::IStorageFolder **")] IStorageFolder** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageLibrary*, IStorageFolder**, int>)(lpVtbl[9]))((IStorageLibrary*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IStorageLibrary.xml' path='doc/member[@name="IStorageLibrary.add_DefinitionChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT add_DefinitionChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CStorage__CStorageLibrary_IInspectable_t *")] ITypedEventHandler<IntPtr, IntPtr>* handler, EventRegistrationToken* eventCookie)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageLibrary*, ITypedEventHandler<IntPtr, IntPtr>*, EventRegistrationToken*, int>)(lpVtbl[10]))((IStorageLibrary*)Unsafe.AsPointer(ref this), handler, eventCookie);
    }

    /// <include file='IStorageLibrary.xml' path='doc/member[@name="IStorageLibrary.remove_DefinitionChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT remove_DefinitionChanged(EventRegistrationToken eventCookie)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageLibrary*, EventRegistrationToken, int>)(lpVtbl[11]))((IStorageLibrary*)Unsafe.AsPointer(ref this), eventCookie);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT RequestAddFolderAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStorageFolder_t **")] IAsyncOperation<IntPtr>** operation);

        [VtblIndex(7)]
        HRESULT RequestRemoveFolderAsync([NativeTypeName("ABI::Windows::Storage::IStorageFolder *")] IStorageFolder* folder, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")] IAsyncOperation<bool>** operation);

        [VtblIndex(8)]
        HRESULT get_Folders([NativeTypeName("ABI::Windows::Foundation::Collections::__FIObservableVector_1_Windows__CStorage__CStorageFolder_t **")] IObservableVector<IntPtr>** value);

        [VtblIndex(9)]
        HRESULT get_SaveFolder([NativeTypeName("ABI::Windows::Storage::IStorageFolder **")] IStorageFolder** value);

        [VtblIndex(10)]
        HRESULT add_DefinitionChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CStorage__CStorageLibrary_IInspectable_t *")] ITypedEventHandler<IntPtr, IntPtr>* handler, EventRegistrationToken* eventCookie);

        [VtblIndex(11)]
        HRESULT remove_DefinitionChanged(EventRegistrationToken eventCookie);
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStorageFolder_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAsyncOperation<IntPtr>**, int> RequestAddFolderAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::IStorageFolder *, ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IStorageFolder*, IAsyncOperation<bool>**, int> RequestRemoveFolderAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIObservableVector_1_Windows__CStorage__CStorageFolder_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IObservableVector<IntPtr>**, int> get_Folders;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::IStorageFolder **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IStorageFolder**, int> get_SaveFolder;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CStorage__CStorageLibrary_IInspectable_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<IntPtr, IntPtr>*, EventRegistrationToken*, int> add_DefinitionChanged;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_DefinitionChanged;
    }
}
