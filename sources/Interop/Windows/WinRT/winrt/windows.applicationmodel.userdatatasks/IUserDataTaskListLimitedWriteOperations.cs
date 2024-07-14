// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.userdatatasks.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IUserDataTaskListLimitedWriteOperations.xml' path='doc/member[@name="IUserDataTaskListLimitedWriteOperations"]/*' />
[Guid("7AA267F2-6078-4183-919E-4F29F19CFAE9")]
[NativeTypeName("struct IUserDataTaskListLimitedWriteOperations : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IUserDataTaskListLimitedWriteOperations : IUserDataTaskListLimitedWriteOperations.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IUserDataTaskListLimitedWriteOperations));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDataTaskListLimitedWriteOperations*, Guid*, void**, int>)(lpVtbl[0]))((IUserDataTaskListLimitedWriteOperations*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDataTaskListLimitedWriteOperations*, uint>)(lpVtbl[1]))((IUserDataTaskListLimitedWriteOperations*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDataTaskListLimitedWriteOperations*, uint>)(lpVtbl[2]))((IUserDataTaskListLimitedWriteOperations*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDataTaskListLimitedWriteOperations*, uint*, Guid**, int>)(lpVtbl[3]))((IUserDataTaskListLimitedWriteOperations*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDataTaskListLimitedWriteOperations*, HSTRING*, int>)(lpVtbl[4]))((IUserDataTaskListLimitedWriteOperations*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDataTaskListLimitedWriteOperations*, TrustLevel*, int>)(lpVtbl[5]))((IUserDataTaskListLimitedWriteOperations*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IUserDataTaskListLimitedWriteOperations.xml' path='doc/member[@name="IUserDataTaskListLimitedWriteOperations.TryCompleteTaskAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT TryCompleteTaskAsync(HSTRING userDataTaskId, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_HSTRING_t **")] IAsyncOperation<HSTRING>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDataTaskListLimitedWriteOperations*, HSTRING, IAsyncOperation<HSTRING>**, int>)(lpVtbl[6]))((IUserDataTaskListLimitedWriteOperations*)Unsafe.AsPointer(ref this), userDataTaskId, operation);
    }

    /// <include file='IUserDataTaskListLimitedWriteOperations.xml' path='doc/member[@name="IUserDataTaskListLimitedWriteOperations.TryCreateOrUpdateTaskAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT TryCreateOrUpdateTaskAsync([NativeTypeName("ABI::Windows::ApplicationModel::UserDataTasks::IUserDataTask *")] IUserDataTask* userDataTask, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")] IAsyncOperation<bool>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDataTaskListLimitedWriteOperations*, IUserDataTask*, IAsyncOperation<bool>**, int>)(lpVtbl[7]))((IUserDataTaskListLimitedWriteOperations*)Unsafe.AsPointer(ref this), userDataTask, operation);
    }

    /// <include file='IUserDataTaskListLimitedWriteOperations.xml' path='doc/member[@name="IUserDataTaskListLimitedWriteOperations.TryDeleteTaskAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT TryDeleteTaskAsync(HSTRING userDataTaskId, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")] IAsyncOperation<bool>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDataTaskListLimitedWriteOperations*, HSTRING, IAsyncOperation<bool>**, int>)(lpVtbl[8]))((IUserDataTaskListLimitedWriteOperations*)Unsafe.AsPointer(ref this), userDataTaskId, operation);
    }

    /// <include file='IUserDataTaskListLimitedWriteOperations.xml' path='doc/member[@name="IUserDataTaskListLimitedWriteOperations.TrySkipOccurrenceAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT TrySkipOccurrenceAsync(HSTRING userDataTaskId, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")] IAsyncOperation<bool>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDataTaskListLimitedWriteOperations*, HSTRING, IAsyncOperation<bool>**, int>)(lpVtbl[9]))((IUserDataTaskListLimitedWriteOperations*)Unsafe.AsPointer(ref this), userDataTaskId, operation);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT TryCompleteTaskAsync(HSTRING userDataTaskId, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_HSTRING_t **")] IAsyncOperation<HSTRING>** operation);

        [VtblIndex(7)]
        HRESULT TryCreateOrUpdateTaskAsync([NativeTypeName("ABI::Windows::ApplicationModel::UserDataTasks::IUserDataTask *")] IUserDataTask* userDataTask, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")] IAsyncOperation<bool>** operation);

        [VtblIndex(8)]
        HRESULT TryDeleteTaskAsync(HSTRING userDataTaskId, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")] IAsyncOperation<bool>** operation);

        [VtblIndex(9)]
        HRESULT TrySkipOccurrenceAsync(HSTRING userDataTaskId, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")] IAsyncOperation<bool>** operation);
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

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Foundation::__FIAsyncOperation_1_HSTRING_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IAsyncOperation<HSTRING>**, int> TryCompleteTaskAsync;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::UserDataTasks::IUserDataTask *, ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IUserDataTask*, IAsyncOperation<bool>**, int> TryCreateOrUpdateTaskAsync;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IAsyncOperation<bool>**, int> TryDeleteTaskAsync;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IAsyncOperation<bool>**, int> TrySkipOccurrenceAsync;
    }
}
