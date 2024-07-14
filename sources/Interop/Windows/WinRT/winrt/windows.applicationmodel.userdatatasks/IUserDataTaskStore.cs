// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.userdatatasks.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IUserDataTaskStore.xml' path='doc/member[@name="IUserDataTaskStore"]/*' />
[Guid("F06A9CB0-F1DB-45BA-8A62-086004C0213D")]
[NativeTypeName("struct IUserDataTaskStore : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IUserDataTaskStore : IUserDataTaskStore.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IUserDataTaskStore));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDataTaskStore*, Guid*, void**, int>)(lpVtbl[0]))((IUserDataTaskStore*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDataTaskStore*, uint>)(lpVtbl[1]))((IUserDataTaskStore*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDataTaskStore*, uint>)(lpVtbl[2]))((IUserDataTaskStore*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDataTaskStore*, uint*, Guid**, int>)(lpVtbl[3]))((IUserDataTaskStore*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDataTaskStore*, HSTRING*, int>)(lpVtbl[4]))((IUserDataTaskStore*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDataTaskStore*, TrustLevel*, int>)(lpVtbl[5]))((IUserDataTaskStore*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IUserDataTaskStore.xml' path='doc/member[@name="IUserDataTaskStore.CreateListAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT CreateListAsync(HSTRING name, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CUserDataTasks__CUserDataTaskList_t **")] IAsyncOperation<Pointer<IUserDataTaskList>>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDataTaskStore*, HSTRING, IAsyncOperation<Pointer<IUserDataTaskList>>**, int>)(lpVtbl[6]))((IUserDataTaskStore*)Unsafe.AsPointer(ref this), name, operation);
    }

    /// <include file='IUserDataTaskStore.xml' path='doc/member[@name="IUserDataTaskStore.CreateListInAccountAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT CreateListInAccountAsync(HSTRING name, HSTRING userDataAccountId, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CUserDataTasks__CUserDataTaskList_t **")] IAsyncOperation<Pointer<IUserDataTaskList>>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDataTaskStore*, HSTRING, HSTRING, IAsyncOperation<Pointer<IUserDataTaskList>>**, int>)(lpVtbl[7]))((IUserDataTaskStore*)Unsafe.AsPointer(ref this), name, userDataAccountId, result);
    }

    /// <include file='IUserDataTaskStore.xml' path='doc/member[@name="IUserDataTaskStore.FindListsAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT FindListsAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CApplicationModel__CUserDataTasks__CUserDataTaskList_t **")] IAsyncOperation<Pointer<IVectorView<Pointer<IUserDataTaskList>>>>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDataTaskStore*, IAsyncOperation<Pointer<IVectorView<Pointer<IUserDataTaskList>>>>**, int>)(lpVtbl[8]))((IUserDataTaskStore*)Unsafe.AsPointer(ref this), operation);
    }

    /// <include file='IUserDataTaskStore.xml' path='doc/member[@name="IUserDataTaskStore.GetListAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetListAsync(HSTRING taskListId, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CUserDataTasks__CUserDataTaskList_t **")] IAsyncOperation<Pointer<IUserDataTaskList>>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDataTaskStore*, HSTRING, IAsyncOperation<Pointer<IUserDataTaskList>>**, int>)(lpVtbl[9]))((IUserDataTaskStore*)Unsafe.AsPointer(ref this), taskListId, operation);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT CreateListAsync(HSTRING name, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CUserDataTasks__CUserDataTaskList_t **")] IAsyncOperation<Pointer<IUserDataTaskList>>** operation);

        [VtblIndex(7)]
        HRESULT CreateListInAccountAsync(HSTRING name, HSTRING userDataAccountId, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CUserDataTasks__CUserDataTaskList_t **")] IAsyncOperation<Pointer<IUserDataTaskList>>** result);

        [VtblIndex(8)]
        HRESULT FindListsAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CApplicationModel__CUserDataTasks__CUserDataTaskList_t **")] IAsyncOperation<Pointer<IVectorView<Pointer<IUserDataTaskList>>>>** operation);

        [VtblIndex(9)]
        HRESULT GetListAsync(HSTRING taskListId, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CUserDataTasks__CUserDataTaskList_t **")] IAsyncOperation<Pointer<IUserDataTaskList>>** operation);
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

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CUserDataTasks__CUserDataTaskList_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IAsyncOperation<Pointer<IUserDataTaskList>>**, int> CreateListAsync;

        [NativeTypeName("HRESULT (HSTRING, HSTRING, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CUserDataTasks__CUserDataTaskList_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, HSTRING, IAsyncOperation<Pointer<IUserDataTaskList>>**, int> CreateListInAccountAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CApplicationModel__CUserDataTasks__CUserDataTaskList_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAsyncOperation<Pointer<IVectorView<Pointer<IUserDataTaskList>>>>**, int> FindListsAsync;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CUserDataTasks__CUserDataTaskList_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IAsyncOperation<Pointer<IUserDataTaskList>>**, int> GetListAsync;
    }
}
