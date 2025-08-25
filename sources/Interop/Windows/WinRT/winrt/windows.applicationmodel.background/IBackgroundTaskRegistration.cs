// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.background.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IBackgroundTaskRegistration.xml' path='doc/member[@name="IBackgroundTaskRegistration"]/*' />
[Guid("10654CC2-A26E-43BF-8C12-1FB40DBFBFA0")]
[NativeTypeName("struct IBackgroundTaskRegistration : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IBackgroundTaskRegistration : IBackgroundTaskRegistration.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IBackgroundTaskRegistration);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundTaskRegistration*, Guid*, void**, int>)(lpVtbl[0]))((IBackgroundTaskRegistration*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundTaskRegistration*, uint>)(lpVtbl[1]))((IBackgroundTaskRegistration*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundTaskRegistration*, uint>)(lpVtbl[2]))((IBackgroundTaskRegistration*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundTaskRegistration*, uint*, Guid**, int>)(lpVtbl[3]))((IBackgroundTaskRegistration*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundTaskRegistration*, HSTRING*, int>)(lpVtbl[4]))((IBackgroundTaskRegistration*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundTaskRegistration*, TrustLevel*, int>)(lpVtbl[5]))((IBackgroundTaskRegistration*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IBackgroundTaskRegistration.xml' path='doc/member[@name="IBackgroundTaskRegistration.get_TaskId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_TaskId(Guid* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundTaskRegistration*, Guid*, int>)(lpVtbl[6]))((IBackgroundTaskRegistration*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBackgroundTaskRegistration.xml' path='doc/member[@name="IBackgroundTaskRegistration.get_Name"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Name(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundTaskRegistration*, HSTRING*, int>)(lpVtbl[7]))((IBackgroundTaskRegistration*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBackgroundTaskRegistration.xml' path='doc/member[@name="IBackgroundTaskRegistration.add_Progress"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT add_Progress([NativeTypeName("ABI::Windows::ApplicationModel::Background::IBackgroundTaskProgressEventHandler *")] IBackgroundTaskProgressEventHandler* handler, EventRegistrationToken* cookie)
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundTaskRegistration*, IBackgroundTaskProgressEventHandler*, EventRegistrationToken*, int>)(lpVtbl[8]))((IBackgroundTaskRegistration*)Unsafe.AsPointer(ref this), handler, cookie);
    }

    /// <include file='IBackgroundTaskRegistration.xml' path='doc/member[@name="IBackgroundTaskRegistration.remove_Progress"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT remove_Progress(EventRegistrationToken cookie)
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundTaskRegistration*, EventRegistrationToken, int>)(lpVtbl[9]))((IBackgroundTaskRegistration*)Unsafe.AsPointer(ref this), cookie);
    }

    /// <include file='IBackgroundTaskRegistration.xml' path='doc/member[@name="IBackgroundTaskRegistration.add_Completed"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT add_Completed([NativeTypeName("ABI::Windows::ApplicationModel::Background::IBackgroundTaskCompletedEventHandler *")] IBackgroundTaskCompletedEventHandler* handler, EventRegistrationToken* cookie)
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundTaskRegistration*, IBackgroundTaskCompletedEventHandler*, EventRegistrationToken*, int>)(lpVtbl[10]))((IBackgroundTaskRegistration*)Unsafe.AsPointer(ref this), handler, cookie);
    }

    /// <include file='IBackgroundTaskRegistration.xml' path='doc/member[@name="IBackgroundTaskRegistration.remove_Completed"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT remove_Completed(EventRegistrationToken cookie)
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundTaskRegistration*, EventRegistrationToken, int>)(lpVtbl[11]))((IBackgroundTaskRegistration*)Unsafe.AsPointer(ref this), cookie);
    }

    /// <include file='IBackgroundTaskRegistration.xml' path='doc/member[@name="IBackgroundTaskRegistration.Unregister"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT Unregister([NativeTypeName("boolean")] byte cancelTask)
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundTaskRegistration*, byte, int>)(lpVtbl[12]))((IBackgroundTaskRegistration*)Unsafe.AsPointer(ref this), cancelTask);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_TaskId(Guid* value);

        [VtblIndex(7)]
        HRESULT get_Name(HSTRING* value);

        [VtblIndex(8)]
        HRESULT add_Progress([NativeTypeName("ABI::Windows::ApplicationModel::Background::IBackgroundTaskProgressEventHandler *")] IBackgroundTaskProgressEventHandler* handler, EventRegistrationToken* cookie);

        [VtblIndex(9)]
        HRESULT remove_Progress(EventRegistrationToken cookie);

        [VtblIndex(10)]
        HRESULT add_Completed([NativeTypeName("ABI::Windows::ApplicationModel::Background::IBackgroundTaskCompletedEventHandler *")] IBackgroundTaskCompletedEventHandler* handler, EventRegistrationToken* cookie);

        [VtblIndex(11)]
        HRESULT remove_Completed(EventRegistrationToken cookie);

        [VtblIndex(12)]
        HRESULT Unregister([NativeTypeName("boolean")] byte cancelTask);
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
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, int> get_TaskId;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Name;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Background::IBackgroundTaskProgressEventHandler *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IBackgroundTaskProgressEventHandler*, EventRegistrationToken*, int> add_Progress;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_Progress;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Background::IBackgroundTaskCompletedEventHandler *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IBackgroundTaskCompletedEventHandler*, EventRegistrationToken*, int> add_Completed;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_Completed;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, int> Unregister;
    }
}
