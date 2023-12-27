// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.userdatatasks.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IUserDataTask.xml' path='doc/member[@name="IUserDataTask"]/*' />
[Guid("7C6585D1-E0D4-4F99-AEE2-BC2D5DDADF4C")]
[NativeTypeName("struct IUserDataTask : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IUserDataTask : IUserDataTask.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IUserDataTask));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDataTask*, Guid*, void**, int>)(lpVtbl[0]))((IUserDataTask*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDataTask*, uint>)(lpVtbl[1]))((IUserDataTask*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDataTask*, uint>)(lpVtbl[2]))((IUserDataTask*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDataTask*, uint*, Guid**, int>)(lpVtbl[3]))((IUserDataTask*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDataTask*, HSTRING*, int>)(lpVtbl[4]))((IUserDataTask*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDataTask*, TrustLevel*, int>)(lpVtbl[5]))((IUserDataTask*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IUserDataTask.xml' path='doc/member[@name="IUserDataTask.get_Id"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Id(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDataTask*, HSTRING*, int>)(lpVtbl[6]))((IUserDataTask*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IUserDataTask.xml' path='doc/member[@name="IUserDataTask.get_ListId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_ListId(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDataTask*, HSTRING*, int>)(lpVtbl[7]))((IUserDataTask*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IUserDataTask.xml' path='doc/member[@name="IUserDataTask.get_RemoteId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_RemoteId(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDataTask*, HSTRING*, int>)(lpVtbl[8]))((IUserDataTask*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IUserDataTask.xml' path='doc/member[@name="IUserDataTask.put_RemoteId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_RemoteId(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDataTask*, HSTRING, int>)(lpVtbl[9]))((IUserDataTask*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IUserDataTask.xml' path='doc/member[@name="IUserDataTask.get_CompletedDate"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_CompletedDate([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CDateTime_t **")] IReference<DateTime>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDataTask*, IReference<DateTime>**, int>)(lpVtbl[10]))((IUserDataTask*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IUserDataTask.xml' path='doc/member[@name="IUserDataTask.put_CompletedDate"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_CompletedDate([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CDateTime_t *")] IReference<DateTime>* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDataTask*, IReference<DateTime>*, int>)(lpVtbl[11]))((IUserDataTask*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IUserDataTask.xml' path='doc/member[@name="IUserDataTask.get_Details"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_Details(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDataTask*, HSTRING*, int>)(lpVtbl[12]))((IUserDataTask*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IUserDataTask.xml' path='doc/member[@name="IUserDataTask.put_Details"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT put_Details(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDataTask*, HSTRING, int>)(lpVtbl[13]))((IUserDataTask*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IUserDataTask.xml' path='doc/member[@name="IUserDataTask.get_DetailsKind"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_DetailsKind([NativeTypeName("ABI::Windows::ApplicationModel::UserDataTasks::UserDataTaskDetailsKind *")] UserDataTaskDetailsKind* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDataTask*, UserDataTaskDetailsKind*, int>)(lpVtbl[14]))((IUserDataTask*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IUserDataTask.xml' path='doc/member[@name="IUserDataTask.put_DetailsKind"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT put_DetailsKind([NativeTypeName("ABI::Windows::ApplicationModel::UserDataTasks::UserDataTaskDetailsKind")] UserDataTaskDetailsKind value)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDataTask*, UserDataTaskDetailsKind, int>)(lpVtbl[15]))((IUserDataTask*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IUserDataTask.xml' path='doc/member[@name="IUserDataTask.get_DueDate"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_DueDate([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CDateTime_t **")] IReference<DateTime>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDataTask*, IReference<DateTime>**, int>)(lpVtbl[16]))((IUserDataTask*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IUserDataTask.xml' path='doc/member[@name="IUserDataTask.put_DueDate"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT put_DueDate([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CDateTime_t *")] IReference<DateTime>* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDataTask*, IReference<DateTime>*, int>)(lpVtbl[17]))((IUserDataTask*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IUserDataTask.xml' path='doc/member[@name="IUserDataTask.get_Kind"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT get_Kind([NativeTypeName("ABI::Windows::ApplicationModel::UserDataTasks::UserDataTaskKind *")] UserDataTaskKind* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDataTask*, UserDataTaskKind*, int>)(lpVtbl[18]))((IUserDataTask*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IUserDataTask.xml' path='doc/member[@name="IUserDataTask.get_Priority"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT get_Priority([NativeTypeName("ABI::Windows::ApplicationModel::UserDataTasks::UserDataTaskPriority *")] UserDataTaskPriority* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDataTask*, UserDataTaskPriority*, int>)(lpVtbl[19]))((IUserDataTask*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IUserDataTask.xml' path='doc/member[@name="IUserDataTask.put_Priority"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT put_Priority([NativeTypeName("ABI::Windows::ApplicationModel::UserDataTasks::UserDataTaskPriority")] UserDataTaskPriority value)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDataTask*, UserDataTaskPriority, int>)(lpVtbl[20]))((IUserDataTask*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IUserDataTask.xml' path='doc/member[@name="IUserDataTask.get_RecurrenceProperties"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT get_RecurrenceProperties([NativeTypeName("ABI::Windows::ApplicationModel::UserDataTasks::IUserDataTaskRecurrenceProperties **")] IUserDataTaskRecurrenceProperties** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDataTask*, IUserDataTaskRecurrenceProperties**, int>)(lpVtbl[21]))((IUserDataTask*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IUserDataTask.xml' path='doc/member[@name="IUserDataTask.put_RecurrenceProperties"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT put_RecurrenceProperties([NativeTypeName("ABI::Windows::ApplicationModel::UserDataTasks::IUserDataTaskRecurrenceProperties *")] IUserDataTaskRecurrenceProperties* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDataTask*, IUserDataTaskRecurrenceProperties*, int>)(lpVtbl[22]))((IUserDataTask*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IUserDataTask.xml' path='doc/member[@name="IUserDataTask.get_RegenerationProperties"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT get_RegenerationProperties([NativeTypeName("ABI::Windows::ApplicationModel::UserDataTasks::IUserDataTaskRegenerationProperties **")] IUserDataTaskRegenerationProperties** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDataTask*, IUserDataTaskRegenerationProperties**, int>)(lpVtbl[23]))((IUserDataTask*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IUserDataTask.xml' path='doc/member[@name="IUserDataTask.put_RegenerationProperties"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT put_RegenerationProperties([NativeTypeName("ABI::Windows::ApplicationModel::UserDataTasks::IUserDataTaskRegenerationProperties *")] IUserDataTaskRegenerationProperties* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDataTask*, IUserDataTaskRegenerationProperties*, int>)(lpVtbl[24]))((IUserDataTask*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IUserDataTask.xml' path='doc/member[@name="IUserDataTask.get_Reminder"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT get_Reminder([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CDateTime_t **")] IReference<DateTime>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDataTask*, IReference<DateTime>**, int>)(lpVtbl[25]))((IUserDataTask*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IUserDataTask.xml' path='doc/member[@name="IUserDataTask.put_Reminder"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT put_Reminder([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CDateTime_t *")] IReference<DateTime>* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDataTask*, IReference<DateTime>*, int>)(lpVtbl[26]))((IUserDataTask*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IUserDataTask.xml' path='doc/member[@name="IUserDataTask.get_Sensitivity"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT get_Sensitivity([NativeTypeName("ABI::Windows::ApplicationModel::UserDataTasks::UserDataTaskSensitivity *")] UserDataTaskSensitivity* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDataTask*, UserDataTaskSensitivity*, int>)(lpVtbl[27]))((IUserDataTask*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IUserDataTask.xml' path='doc/member[@name="IUserDataTask.put_Sensitivity"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public HRESULT put_Sensitivity([NativeTypeName("ABI::Windows::ApplicationModel::UserDataTasks::UserDataTaskSensitivity")] UserDataTaskSensitivity value)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDataTask*, UserDataTaskSensitivity, int>)(lpVtbl[28]))((IUserDataTask*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IUserDataTask.xml' path='doc/member[@name="IUserDataTask.get_Subject"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public HRESULT get_Subject(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDataTask*, HSTRING*, int>)(lpVtbl[29]))((IUserDataTask*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IUserDataTask.xml' path='doc/member[@name="IUserDataTask.put_Subject"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(30)]
    public HRESULT put_Subject(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDataTask*, HSTRING, int>)(lpVtbl[30]))((IUserDataTask*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IUserDataTask.xml' path='doc/member[@name="IUserDataTask.get_StartDate"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(31)]
    public HRESULT get_StartDate([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CDateTime_t **")] IReference<DateTime>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDataTask*, IReference<DateTime>**, int>)(lpVtbl[31]))((IUserDataTask*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IUserDataTask.xml' path='doc/member[@name="IUserDataTask.put_StartDate"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(32)]
    public HRESULT put_StartDate([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CDateTime_t *")] IReference<DateTime>* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDataTask*, IReference<DateTime>*, int>)(lpVtbl[32]))((IUserDataTask*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Id(HSTRING* value);

        [VtblIndex(7)]
        HRESULT get_ListId(HSTRING* value);

        [VtblIndex(8)]
        HRESULT get_RemoteId(HSTRING* value);

        [VtblIndex(9)]
        HRESULT put_RemoteId(HSTRING value);

        [VtblIndex(10)]
        HRESULT get_CompletedDate([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CDateTime_t **")] IReference<DateTime>** value);

        [VtblIndex(11)]
        HRESULT put_CompletedDate([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CDateTime_t *")] IReference<DateTime>* value);

        [VtblIndex(12)]
        HRESULT get_Details(HSTRING* value);

        [VtblIndex(13)]
        HRESULT put_Details(HSTRING value);

        [VtblIndex(14)]
        HRESULT get_DetailsKind([NativeTypeName("ABI::Windows::ApplicationModel::UserDataTasks::UserDataTaskDetailsKind *")] UserDataTaskDetailsKind* value);

        [VtblIndex(15)]
        HRESULT put_DetailsKind([NativeTypeName("ABI::Windows::ApplicationModel::UserDataTasks::UserDataTaskDetailsKind")] UserDataTaskDetailsKind value);

        [VtblIndex(16)]
        HRESULT get_DueDate([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CDateTime_t **")] IReference<DateTime>** value);

        [VtblIndex(17)]
        HRESULT put_DueDate([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CDateTime_t *")] IReference<DateTime>* value);

        [VtblIndex(18)]
        HRESULT get_Kind([NativeTypeName("ABI::Windows::ApplicationModel::UserDataTasks::UserDataTaskKind *")] UserDataTaskKind* value);

        [VtblIndex(19)]
        HRESULT get_Priority([NativeTypeName("ABI::Windows::ApplicationModel::UserDataTasks::UserDataTaskPriority *")] UserDataTaskPriority* value);

        [VtblIndex(20)]
        HRESULT put_Priority([NativeTypeName("ABI::Windows::ApplicationModel::UserDataTasks::UserDataTaskPriority")] UserDataTaskPriority value);

        [VtblIndex(21)]
        HRESULT get_RecurrenceProperties([NativeTypeName("ABI::Windows::ApplicationModel::UserDataTasks::IUserDataTaskRecurrenceProperties **")] IUserDataTaskRecurrenceProperties** value);

        [VtblIndex(22)]
        HRESULT put_RecurrenceProperties([NativeTypeName("ABI::Windows::ApplicationModel::UserDataTasks::IUserDataTaskRecurrenceProperties *")] IUserDataTaskRecurrenceProperties* value);

        [VtblIndex(23)]
        HRESULT get_RegenerationProperties([NativeTypeName("ABI::Windows::ApplicationModel::UserDataTasks::IUserDataTaskRegenerationProperties **")] IUserDataTaskRegenerationProperties** value);

        [VtblIndex(24)]
        HRESULT put_RegenerationProperties([NativeTypeName("ABI::Windows::ApplicationModel::UserDataTasks::IUserDataTaskRegenerationProperties *")] IUserDataTaskRegenerationProperties* value);

        [VtblIndex(25)]
        HRESULT get_Reminder([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CDateTime_t **")] IReference<DateTime>** value);

        [VtblIndex(26)]
        HRESULT put_Reminder([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CDateTime_t *")] IReference<DateTime>* value);

        [VtblIndex(27)]
        HRESULT get_Sensitivity([NativeTypeName("ABI::Windows::ApplicationModel::UserDataTasks::UserDataTaskSensitivity *")] UserDataTaskSensitivity* value);

        [VtblIndex(28)]
        HRESULT put_Sensitivity([NativeTypeName("ABI::Windows::ApplicationModel::UserDataTasks::UserDataTaskSensitivity")] UserDataTaskSensitivity value);

        [VtblIndex(29)]
        HRESULT get_Subject(HSTRING* value);

        [VtblIndex(30)]
        HRESULT put_Subject(HSTRING value);

        [VtblIndex(31)]
        HRESULT get_StartDate([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CDateTime_t **")] IReference<DateTime>** value);

        [VtblIndex(32)]
        HRESULT put_StartDate([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CDateTime_t *")] IReference<DateTime>* value);
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
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_ListId;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_RemoteId;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> put_RemoteId;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CDateTime_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<DateTime>**, int> get_CompletedDate;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CDateTime_t *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<DateTime>*, int> put_CompletedDate;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Details;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> put_Details;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::UserDataTasks::UserDataTaskDetailsKind *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, UserDataTaskDetailsKind*, int> get_DetailsKind;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::UserDataTasks::UserDataTaskDetailsKind) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, UserDataTaskDetailsKind, int> put_DetailsKind;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CDateTime_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<DateTime>**, int> get_DueDate;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CDateTime_t *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<DateTime>*, int> put_DueDate;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::UserDataTasks::UserDataTaskKind *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, UserDataTaskKind*, int> get_Kind;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::UserDataTasks::UserDataTaskPriority *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, UserDataTaskPriority*, int> get_Priority;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::UserDataTasks::UserDataTaskPriority) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, UserDataTaskPriority, int> put_Priority;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::UserDataTasks::IUserDataTaskRecurrenceProperties **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IUserDataTaskRecurrenceProperties**, int> get_RecurrenceProperties;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::UserDataTasks::IUserDataTaskRecurrenceProperties *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IUserDataTaskRecurrenceProperties*, int> put_RecurrenceProperties;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::UserDataTasks::IUserDataTaskRegenerationProperties **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IUserDataTaskRegenerationProperties**, int> get_RegenerationProperties;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::UserDataTasks::IUserDataTaskRegenerationProperties *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IUserDataTaskRegenerationProperties*, int> put_RegenerationProperties;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CDateTime_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<DateTime>**, int> get_Reminder;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CDateTime_t *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<DateTime>*, int> put_Reminder;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::UserDataTasks::UserDataTaskSensitivity *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, UserDataTaskSensitivity*, int> get_Sensitivity;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::UserDataTasks::UserDataTaskSensitivity) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, UserDataTaskSensitivity, int> put_Sensitivity;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Subject;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> put_Subject;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CDateTime_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<DateTime>**, int> get_StartDate;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CDateTime_t *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<DateTime>*, int> put_StartDate;
    }
}
