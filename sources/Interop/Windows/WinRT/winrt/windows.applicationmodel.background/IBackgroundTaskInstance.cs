// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.background.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IBackgroundTaskInstance.xml' path='doc/member[@name="IBackgroundTaskInstance"]/*' />
[Guid("865BDA7A-21D8-4573-8F32-928A1B0641F6")]
[NativeTypeName("struct IBackgroundTaskInstance : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IBackgroundTaskInstance : IBackgroundTaskInstance.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IBackgroundTaskInstance));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundTaskInstance*, Guid*, void**, int>)(lpVtbl[0]))((IBackgroundTaskInstance*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundTaskInstance*, uint>)(lpVtbl[1]))((IBackgroundTaskInstance*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundTaskInstance*, uint>)(lpVtbl[2]))((IBackgroundTaskInstance*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundTaskInstance*, uint*, Guid**, int>)(lpVtbl[3]))((IBackgroundTaskInstance*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundTaskInstance*, HSTRING*, int>)(lpVtbl[4]))((IBackgroundTaskInstance*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundTaskInstance*, TrustLevel*, int>)(lpVtbl[5]))((IBackgroundTaskInstance*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IBackgroundTaskInstance.xml' path='doc/member[@name="IBackgroundTaskInstance.get_InstanceId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_InstanceId(Guid* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundTaskInstance*, Guid*, int>)(lpVtbl[6]))((IBackgroundTaskInstance*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBackgroundTaskInstance.xml' path='doc/member[@name="IBackgroundTaskInstance.get_Task"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Task([NativeTypeName("ABI::Windows::ApplicationModel::Background::IBackgroundTaskRegistration **")] IBackgroundTaskRegistration** task)
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundTaskInstance*, IBackgroundTaskRegistration**, int>)(lpVtbl[7]))((IBackgroundTaskInstance*)Unsafe.AsPointer(ref this), task);
    }

    /// <include file='IBackgroundTaskInstance.xml' path='doc/member[@name="IBackgroundTaskInstance.get_Progress"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_Progress([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundTaskInstance*, uint*, int>)(lpVtbl[8]))((IBackgroundTaskInstance*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBackgroundTaskInstance.xml' path='doc/member[@name="IBackgroundTaskInstance.put_Progress"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_Progress([NativeTypeName("UINT32")] uint value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundTaskInstance*, uint, int>)(lpVtbl[9]))((IBackgroundTaskInstance*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBackgroundTaskInstance.xml' path='doc/member[@name="IBackgroundTaskInstance.get_TriggerDetails"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_TriggerDetails(IInspectable** triggerDetails)
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundTaskInstance*, IInspectable**, int>)(lpVtbl[10]))((IBackgroundTaskInstance*)Unsafe.AsPointer(ref this), triggerDetails);
    }

    /// <include file='IBackgroundTaskInstance.xml' path='doc/member[@name="IBackgroundTaskInstance.add_Canceled"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT add_Canceled([NativeTypeName("ABI::Windows::ApplicationModel::Background::IBackgroundTaskCanceledEventHandler *")] IBackgroundTaskCanceledEventHandler* cancelHandler, EventRegistrationToken* cookie)
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundTaskInstance*, IBackgroundTaskCanceledEventHandler*, EventRegistrationToken*, int>)(lpVtbl[11]))((IBackgroundTaskInstance*)Unsafe.AsPointer(ref this), cancelHandler, cookie);
    }

    /// <include file='IBackgroundTaskInstance.xml' path='doc/member[@name="IBackgroundTaskInstance.remove_Canceled"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT remove_Canceled(EventRegistrationToken cookie)
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundTaskInstance*, EventRegistrationToken, int>)(lpVtbl[12]))((IBackgroundTaskInstance*)Unsafe.AsPointer(ref this), cookie);
    }

    /// <include file='IBackgroundTaskInstance.xml' path='doc/member[@name="IBackgroundTaskInstance.get_SuspendedCount"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_SuspendedCount([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundTaskInstance*, uint*, int>)(lpVtbl[13]))((IBackgroundTaskInstance*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBackgroundTaskInstance.xml' path='doc/member[@name="IBackgroundTaskInstance.GetDeferral"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT GetDeferral([NativeTypeName("ABI::Windows::ApplicationModel::Background::IBackgroundTaskDeferral **")] IBackgroundTaskDeferral** deferral)
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundTaskInstance*, IBackgroundTaskDeferral**, int>)(lpVtbl[14]))((IBackgroundTaskInstance*)Unsafe.AsPointer(ref this), deferral);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_InstanceId(Guid* value);

        [VtblIndex(7)]
        HRESULT get_Task([NativeTypeName("ABI::Windows::ApplicationModel::Background::IBackgroundTaskRegistration **")] IBackgroundTaskRegistration** task);

        [VtblIndex(8)]
        HRESULT get_Progress([NativeTypeName("UINT32 *")] uint* value);

        [VtblIndex(9)]
        HRESULT put_Progress([NativeTypeName("UINT32")] uint value);

        [VtblIndex(10)]
        HRESULT get_TriggerDetails(IInspectable** triggerDetails);

        [VtblIndex(11)]
        HRESULT add_Canceled([NativeTypeName("ABI::Windows::ApplicationModel::Background::IBackgroundTaskCanceledEventHandler *")] IBackgroundTaskCanceledEventHandler* cancelHandler, EventRegistrationToken* cookie);

        [VtblIndex(12)]
        HRESULT remove_Canceled(EventRegistrationToken cookie);

        [VtblIndex(13)]
        HRESULT get_SuspendedCount([NativeTypeName("UINT32 *")] uint* value);

        [VtblIndex(14)]
        HRESULT GetDeferral([NativeTypeName("ABI::Windows::ApplicationModel::Background::IBackgroundTaskDeferral **")] IBackgroundTaskDeferral** deferral);
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

        [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, int> get_InstanceId;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Background::IBackgroundTaskRegistration **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IBackgroundTaskRegistration**, int> get_Task;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_Progress;

        [NativeTypeName("HRESULT (UINT32) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, int> put_Progress;

        [NativeTypeName("HRESULT (IInspectable **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IInspectable**, int> get_TriggerDetails;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Background::IBackgroundTaskCanceledEventHandler *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IBackgroundTaskCanceledEventHandler*, EventRegistrationToken*, int> add_Canceled;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_Canceled;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_SuspendedCount;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Background::IBackgroundTaskDeferral **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IBackgroundTaskDeferral**, int> GetDeferral;
    }
}
