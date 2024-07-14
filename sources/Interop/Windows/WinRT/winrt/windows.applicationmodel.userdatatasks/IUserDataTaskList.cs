// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.userdatatasks.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IUserDataTaskList.xml' path='doc/member[@name="IUserDataTaskList"]/*' />
[Guid("49412E39-7C1D-4DF1-BED3-314B7CBF5E4E")]
[NativeTypeName("struct IUserDataTaskList : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IUserDataTaskList : IUserDataTaskList.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IUserDataTaskList));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDataTaskList*, Guid*, void**, int>)(lpVtbl[0]))((IUserDataTaskList*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDataTaskList*, uint>)(lpVtbl[1]))((IUserDataTaskList*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDataTaskList*, uint>)(lpVtbl[2]))((IUserDataTaskList*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDataTaskList*, uint*, Guid**, int>)(lpVtbl[3]))((IUserDataTaskList*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDataTaskList*, HSTRING*, int>)(lpVtbl[4]))((IUserDataTaskList*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDataTaskList*, TrustLevel*, int>)(lpVtbl[5]))((IUserDataTaskList*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IUserDataTaskList.xml' path='doc/member[@name="IUserDataTaskList.get_Id"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Id(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDataTaskList*, HSTRING*, int>)(lpVtbl[6]))((IUserDataTaskList*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IUserDataTaskList.xml' path='doc/member[@name="IUserDataTaskList.get_UserDataAccountId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_UserDataAccountId(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDataTaskList*, HSTRING*, int>)(lpVtbl[7]))((IUserDataTaskList*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IUserDataTaskList.xml' path='doc/member[@name="IUserDataTaskList.get_DisplayName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_DisplayName(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDataTaskList*, HSTRING*, int>)(lpVtbl[8]))((IUserDataTaskList*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IUserDataTaskList.xml' path='doc/member[@name="IUserDataTaskList.put_DisplayName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_DisplayName(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDataTaskList*, HSTRING, int>)(lpVtbl[9]))((IUserDataTaskList*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IUserDataTaskList.xml' path='doc/member[@name="IUserDataTaskList.get_SourceDisplayName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_SourceDisplayName(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDataTaskList*, HSTRING*, int>)(lpVtbl[10]))((IUserDataTaskList*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IUserDataTaskList.xml' path='doc/member[@name="IUserDataTaskList.get_OtherAppReadAccess"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_OtherAppReadAccess([NativeTypeName("ABI::Windows::ApplicationModel::UserDataTasks::UserDataTaskListOtherAppReadAccess *")] UserDataTaskListOtherAppReadAccess* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDataTaskList*, UserDataTaskListOtherAppReadAccess*, int>)(lpVtbl[11]))((IUserDataTaskList*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IUserDataTaskList.xml' path='doc/member[@name="IUserDataTaskList.put_OtherAppReadAccess"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT put_OtherAppReadAccess([NativeTypeName("ABI::Windows::ApplicationModel::UserDataTasks::UserDataTaskListOtherAppReadAccess")] UserDataTaskListOtherAppReadAccess value)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDataTaskList*, UserDataTaskListOtherAppReadAccess, int>)(lpVtbl[12]))((IUserDataTaskList*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IUserDataTaskList.xml' path='doc/member[@name="IUserDataTaskList.get_OtherAppWriteAccess"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_OtherAppWriteAccess([NativeTypeName("ABI::Windows::ApplicationModel::UserDataTasks::UserDataTaskListOtherAppWriteAccess *")] UserDataTaskListOtherAppWriteAccess* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDataTaskList*, UserDataTaskListOtherAppWriteAccess*, int>)(lpVtbl[13]))((IUserDataTaskList*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IUserDataTaskList.xml' path='doc/member[@name="IUserDataTaskList.put_OtherAppWriteAccess"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT put_OtherAppWriteAccess([NativeTypeName("ABI::Windows::ApplicationModel::UserDataTasks::UserDataTaskListOtherAppWriteAccess")] UserDataTaskListOtherAppWriteAccess value)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDataTaskList*, UserDataTaskListOtherAppWriteAccess, int>)(lpVtbl[14]))((IUserDataTaskList*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IUserDataTaskList.xml' path='doc/member[@name="IUserDataTaskList.get_LimitedWriteOperations"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT get_LimitedWriteOperations([NativeTypeName("ABI::Windows::ApplicationModel::UserDataTasks::IUserDataTaskListLimitedWriteOperations **")] IUserDataTaskListLimitedWriteOperations** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDataTaskList*, IUserDataTaskListLimitedWriteOperations**, int>)(lpVtbl[15]))((IUserDataTaskList*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IUserDataTaskList.xml' path='doc/member[@name="IUserDataTaskList.get_SyncManager"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_SyncManager([NativeTypeName("ABI::Windows::ApplicationModel::UserDataTasks::IUserDataTaskListSyncManager **")] IUserDataTaskListSyncManager** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDataTaskList*, IUserDataTaskListSyncManager**, int>)(lpVtbl[16]))((IUserDataTaskList*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IUserDataTaskList.xml' path='doc/member[@name="IUserDataTaskList.RegisterSyncManagerAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT RegisterSyncManagerAsync([NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDataTaskList*, IAsyncAction**, int>)(lpVtbl[17]))((IUserDataTaskList*)Unsafe.AsPointer(ref this), result);
    }

    /// <include file='IUserDataTaskList.xml' path='doc/member[@name="IUserDataTaskList.GetTaskReader"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT GetTaskReader([NativeTypeName("ABI::Windows::ApplicationModel::UserDataTasks::IUserDataTaskReader **")] IUserDataTaskReader** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDataTaskList*, IUserDataTaskReader**, int>)(lpVtbl[18]))((IUserDataTaskList*)Unsafe.AsPointer(ref this), result);
    }

    /// <include file='IUserDataTaskList.xml' path='doc/member[@name="IUserDataTaskList.GetTaskReaderWithOptions"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT GetTaskReaderWithOptions([NativeTypeName("ABI::Windows::ApplicationModel::UserDataTasks::IUserDataTaskQueryOptions *")] IUserDataTaskQueryOptions* options, [NativeTypeName("ABI::Windows::ApplicationModel::UserDataTasks::IUserDataTaskReader **")] IUserDataTaskReader** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDataTaskList*, IUserDataTaskQueryOptions*, IUserDataTaskReader**, int>)(lpVtbl[19]))((IUserDataTaskList*)Unsafe.AsPointer(ref this), options, value);
    }

    /// <include file='IUserDataTaskList.xml' path='doc/member[@name="IUserDataTaskList.GetTaskAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT GetTaskAsync(HSTRING userDataTask, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CUserDataTasks__CUserDataTask_t **")] IAsyncOperation<Pointer<IUserDataTask>>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDataTaskList*, HSTRING, IAsyncOperation<Pointer<IUserDataTask>>**, int>)(lpVtbl[20]))((IUserDataTaskList*)Unsafe.AsPointer(ref this), userDataTask, operation);
    }

    /// <include file='IUserDataTaskList.xml' path='doc/member[@name="IUserDataTaskList.SaveTaskAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT SaveTaskAsync([NativeTypeName("ABI::Windows::ApplicationModel::UserDataTasks::IUserDataTask *")] IUserDataTask* userDataTask, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** action)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDataTaskList*, IUserDataTask*, IAsyncAction**, int>)(lpVtbl[21]))((IUserDataTaskList*)Unsafe.AsPointer(ref this), userDataTask, action);
    }

    /// <include file='IUserDataTaskList.xml' path='doc/member[@name="IUserDataTaskList.DeleteTaskAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT DeleteTaskAsync(HSTRING userDataTaskId, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** action)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDataTaskList*, HSTRING, IAsyncAction**, int>)(lpVtbl[22]))((IUserDataTaskList*)Unsafe.AsPointer(ref this), userDataTaskId, action);
    }

    /// <include file='IUserDataTaskList.xml' path='doc/member[@name="IUserDataTaskList.DeleteAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT DeleteAsync([NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** asyncAction)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDataTaskList*, IAsyncAction**, int>)(lpVtbl[23]))((IUserDataTaskList*)Unsafe.AsPointer(ref this), asyncAction);
    }

    /// <include file='IUserDataTaskList.xml' path='doc/member[@name="IUserDataTaskList.SaveAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT SaveAsync([NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** asyncAction)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDataTaskList*, IAsyncAction**, int>)(lpVtbl[24]))((IUserDataTaskList*)Unsafe.AsPointer(ref this), asyncAction);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Id(HSTRING* value);

        [VtblIndex(7)]
        HRESULT get_UserDataAccountId(HSTRING* value);

        [VtblIndex(8)]
        HRESULT get_DisplayName(HSTRING* value);

        [VtblIndex(9)]
        HRESULT put_DisplayName(HSTRING value);

        [VtblIndex(10)]
        HRESULT get_SourceDisplayName(HSTRING* value);

        [VtblIndex(11)]
        HRESULT get_OtherAppReadAccess([NativeTypeName("ABI::Windows::ApplicationModel::UserDataTasks::UserDataTaskListOtherAppReadAccess *")] UserDataTaskListOtherAppReadAccess* value);

        [VtblIndex(12)]
        HRESULT put_OtherAppReadAccess([NativeTypeName("ABI::Windows::ApplicationModel::UserDataTasks::UserDataTaskListOtherAppReadAccess")] UserDataTaskListOtherAppReadAccess value);

        [VtblIndex(13)]
        HRESULT get_OtherAppWriteAccess([NativeTypeName("ABI::Windows::ApplicationModel::UserDataTasks::UserDataTaskListOtherAppWriteAccess *")] UserDataTaskListOtherAppWriteAccess* value);

        [VtblIndex(14)]
        HRESULT put_OtherAppWriteAccess([NativeTypeName("ABI::Windows::ApplicationModel::UserDataTasks::UserDataTaskListOtherAppWriteAccess")] UserDataTaskListOtherAppWriteAccess value);

        [VtblIndex(15)]
        HRESULT get_LimitedWriteOperations([NativeTypeName("ABI::Windows::ApplicationModel::UserDataTasks::IUserDataTaskListLimitedWriteOperations **")] IUserDataTaskListLimitedWriteOperations** value);

        [VtblIndex(16)]
        HRESULT get_SyncManager([NativeTypeName("ABI::Windows::ApplicationModel::UserDataTasks::IUserDataTaskListSyncManager **")] IUserDataTaskListSyncManager** value);

        [VtblIndex(17)]
        HRESULT RegisterSyncManagerAsync([NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** result);

        [VtblIndex(18)]
        HRESULT GetTaskReader([NativeTypeName("ABI::Windows::ApplicationModel::UserDataTasks::IUserDataTaskReader **")] IUserDataTaskReader** result);

        [VtblIndex(19)]
        HRESULT GetTaskReaderWithOptions([NativeTypeName("ABI::Windows::ApplicationModel::UserDataTasks::IUserDataTaskQueryOptions *")] IUserDataTaskQueryOptions* options, [NativeTypeName("ABI::Windows::ApplicationModel::UserDataTasks::IUserDataTaskReader **")] IUserDataTaskReader** value);

        [VtblIndex(20)]
        HRESULT GetTaskAsync(HSTRING userDataTask, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CUserDataTasks__CUserDataTask_t **")] IAsyncOperation<Pointer<IUserDataTask>>** operation);

        [VtblIndex(21)]
        HRESULT SaveTaskAsync([NativeTypeName("ABI::Windows::ApplicationModel::UserDataTasks::IUserDataTask *")] IUserDataTask* userDataTask, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** action);

        [VtblIndex(22)]
        HRESULT DeleteTaskAsync(HSTRING userDataTaskId, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** action);

        [VtblIndex(23)]
        HRESULT DeleteAsync([NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** asyncAction);

        [VtblIndex(24)]
        HRESULT SaveAsync([NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** asyncAction);
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
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Id;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_UserDataAccountId;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_DisplayName;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> put_DisplayName;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_SourceDisplayName;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::UserDataTasks::UserDataTaskListOtherAppReadAccess *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, UserDataTaskListOtherAppReadAccess*, int> get_OtherAppReadAccess;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::UserDataTasks::UserDataTaskListOtherAppReadAccess) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, UserDataTaskListOtherAppReadAccess, int> put_OtherAppReadAccess;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::UserDataTasks::UserDataTaskListOtherAppWriteAccess *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, UserDataTaskListOtherAppWriteAccess*, int> get_OtherAppWriteAccess;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::UserDataTasks::UserDataTaskListOtherAppWriteAccess) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, UserDataTaskListOtherAppWriteAccess, int> put_OtherAppWriteAccess;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::UserDataTasks::IUserDataTaskListLimitedWriteOperations **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IUserDataTaskListLimitedWriteOperations**, int> get_LimitedWriteOperations;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::UserDataTasks::IUserDataTaskListSyncManager **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IUserDataTaskListSyncManager**, int> get_SyncManager;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAsyncAction**, int> RegisterSyncManagerAsync;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::UserDataTasks::IUserDataTaskReader **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IUserDataTaskReader**, int> GetTaskReader;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::UserDataTasks::IUserDataTaskQueryOptions *, ABI::Windows::ApplicationModel::UserDataTasks::IUserDataTaskReader **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IUserDataTaskQueryOptions*, IUserDataTaskReader**, int> GetTaskReaderWithOptions;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CUserDataTasks__CUserDataTask_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IAsyncOperation<Pointer<IUserDataTask>>**, int> GetTaskAsync;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::UserDataTasks::IUserDataTask *, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IUserDataTask*, IAsyncAction**, int> SaveTaskAsync;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IAsyncAction**, int> DeleteTaskAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAsyncAction**, int> DeleteAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAsyncAction**, int> SaveAsync;
    }
}
