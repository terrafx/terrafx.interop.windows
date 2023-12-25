// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.system.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IAppResourceGroupInfoWatcher.xml' path='doc/member[@name="IAppResourceGroupInfoWatcher"]/*' />
[Guid("D9B0A0FD-6E5A-4C72-8B17-09FEC4A212BD")]
[NativeTypeName("struct IAppResourceGroupInfoWatcher : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IAppResourceGroupInfoWatcher : IAppResourceGroupInfoWatcher.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAppResourceGroupInfoWatcher));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppResourceGroupInfoWatcher*, Guid*, void**, int>)(lpVtbl[0]))((IAppResourceGroupInfoWatcher*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IAppResourceGroupInfoWatcher*, uint>)(lpVtbl[1]))((IAppResourceGroupInfoWatcher*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IAppResourceGroupInfoWatcher*, uint>)(lpVtbl[2]))((IAppResourceGroupInfoWatcher*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppResourceGroupInfoWatcher*, uint*, Guid**, int>)(lpVtbl[3]))((IAppResourceGroupInfoWatcher*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppResourceGroupInfoWatcher*, HSTRING*, int>)(lpVtbl[4]))((IAppResourceGroupInfoWatcher*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppResourceGroupInfoWatcher*, TrustLevel*, int>)(lpVtbl[5]))((IAppResourceGroupInfoWatcher*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IAppResourceGroupInfoWatcher.xml' path='doc/member[@name="IAppResourceGroupInfoWatcher.add_Added"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT add_Added([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CSystem__CAppResourceGroupInfoWatcher_Windows__CSystem__CAppResourceGroupInfoWatcherEventArgs_t *")] ITypedEventHandler<IntPtr, IntPtr>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppResourceGroupInfoWatcher*, ITypedEventHandler<IntPtr, IntPtr>*, EventRegistrationToken*, int>)(lpVtbl[6]))((IAppResourceGroupInfoWatcher*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IAppResourceGroupInfoWatcher.xml' path='doc/member[@name="IAppResourceGroupInfoWatcher.remove_Added"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT remove_Added(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppResourceGroupInfoWatcher*, EventRegistrationToken, int>)(lpVtbl[7]))((IAppResourceGroupInfoWatcher*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='IAppResourceGroupInfoWatcher.xml' path='doc/member[@name="IAppResourceGroupInfoWatcher.add_Removed"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT add_Removed([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CSystem__CAppResourceGroupInfoWatcher_Windows__CSystem__CAppResourceGroupInfoWatcherEventArgs_t *")] ITypedEventHandler<IntPtr, IntPtr>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppResourceGroupInfoWatcher*, ITypedEventHandler<IntPtr, IntPtr>*, EventRegistrationToken*, int>)(lpVtbl[8]))((IAppResourceGroupInfoWatcher*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IAppResourceGroupInfoWatcher.xml' path='doc/member[@name="IAppResourceGroupInfoWatcher.remove_Removed"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT remove_Removed(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppResourceGroupInfoWatcher*, EventRegistrationToken, int>)(lpVtbl[9]))((IAppResourceGroupInfoWatcher*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='IAppResourceGroupInfoWatcher.xml' path='doc/member[@name="IAppResourceGroupInfoWatcher.add_EnumerationCompleted"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT add_EnumerationCompleted([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CSystem__CAppResourceGroupInfoWatcher_IInspectable_t *")] ITypedEventHandler<IntPtr, IntPtr>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppResourceGroupInfoWatcher*, ITypedEventHandler<IntPtr, IntPtr>*, EventRegistrationToken*, int>)(lpVtbl[10]))((IAppResourceGroupInfoWatcher*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IAppResourceGroupInfoWatcher.xml' path='doc/member[@name="IAppResourceGroupInfoWatcher.remove_EnumerationCompleted"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT remove_EnumerationCompleted(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppResourceGroupInfoWatcher*, EventRegistrationToken, int>)(lpVtbl[11]))((IAppResourceGroupInfoWatcher*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='IAppResourceGroupInfoWatcher.xml' path='doc/member[@name="IAppResourceGroupInfoWatcher.add_Stopped"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT add_Stopped([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CSystem__CAppResourceGroupInfoWatcher_IInspectable_t *")] ITypedEventHandler<IntPtr, IntPtr>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppResourceGroupInfoWatcher*, ITypedEventHandler<IntPtr, IntPtr>*, EventRegistrationToken*, int>)(lpVtbl[12]))((IAppResourceGroupInfoWatcher*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IAppResourceGroupInfoWatcher.xml' path='doc/member[@name="IAppResourceGroupInfoWatcher.remove_Stopped"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT remove_Stopped(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppResourceGroupInfoWatcher*, EventRegistrationToken, int>)(lpVtbl[13]))((IAppResourceGroupInfoWatcher*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='IAppResourceGroupInfoWatcher.xml' path='doc/member[@name="IAppResourceGroupInfoWatcher.add_ExecutionStateChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT add_ExecutionStateChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CSystem__CAppResourceGroupInfoWatcher_Windows__CSystem__CAppResourceGroupInfoWatcherExecutionStateChangedEventArgs_t *")] ITypedEventHandler<IntPtr, IntPtr>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppResourceGroupInfoWatcher*, ITypedEventHandler<IntPtr, IntPtr>*, EventRegistrationToken*, int>)(lpVtbl[14]))((IAppResourceGroupInfoWatcher*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IAppResourceGroupInfoWatcher.xml' path='doc/member[@name="IAppResourceGroupInfoWatcher.remove_ExecutionStateChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT remove_ExecutionStateChanged(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppResourceGroupInfoWatcher*, EventRegistrationToken, int>)(lpVtbl[15]))((IAppResourceGroupInfoWatcher*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='IAppResourceGroupInfoWatcher.xml' path='doc/member[@name="IAppResourceGroupInfoWatcher.get_Status"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_Status([NativeTypeName("ABI::Windows::System::AppResourceGroupInfoWatcherStatus *")] AppResourceGroupInfoWatcherStatus* status)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppResourceGroupInfoWatcher*, AppResourceGroupInfoWatcherStatus*, int>)(lpVtbl[16]))((IAppResourceGroupInfoWatcher*)Unsafe.AsPointer(ref this), status);
    }

    /// <include file='IAppResourceGroupInfoWatcher.xml' path='doc/member[@name="IAppResourceGroupInfoWatcher.Start"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT Start()
    {
        return ((delegate* unmanaged[MemberFunction]<IAppResourceGroupInfoWatcher*, int>)(lpVtbl[17]))((IAppResourceGroupInfoWatcher*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IAppResourceGroupInfoWatcher.xml' path='doc/member[@name="IAppResourceGroupInfoWatcher.Stop"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT Stop()
    {
        return ((delegate* unmanaged[MemberFunction]<IAppResourceGroupInfoWatcher*, int>)(lpVtbl[18]))((IAppResourceGroupInfoWatcher*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT add_Added([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CSystem__CAppResourceGroupInfoWatcher_Windows__CSystem__CAppResourceGroupInfoWatcherEventArgs_t *")] ITypedEventHandler<IntPtr, IntPtr>* handler, EventRegistrationToken* token);

        [VtblIndex(7)]
        HRESULT remove_Added(EventRegistrationToken token);

        [VtblIndex(8)]
        HRESULT add_Removed([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CSystem__CAppResourceGroupInfoWatcher_Windows__CSystem__CAppResourceGroupInfoWatcherEventArgs_t *")] ITypedEventHandler<IntPtr, IntPtr>* handler, EventRegistrationToken* token);

        [VtblIndex(9)]
        HRESULT remove_Removed(EventRegistrationToken token);

        [VtblIndex(10)]
        HRESULT add_EnumerationCompleted([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CSystem__CAppResourceGroupInfoWatcher_IInspectable_t *")] ITypedEventHandler<IntPtr, IntPtr>* handler, EventRegistrationToken* token);

        [VtblIndex(11)]
        HRESULT remove_EnumerationCompleted(EventRegistrationToken token);

        [VtblIndex(12)]
        HRESULT add_Stopped([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CSystem__CAppResourceGroupInfoWatcher_IInspectable_t *")] ITypedEventHandler<IntPtr, IntPtr>* handler, EventRegistrationToken* token);

        [VtblIndex(13)]
        HRESULT remove_Stopped(EventRegistrationToken token);

        [VtblIndex(14)]
        HRESULT add_ExecutionStateChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CSystem__CAppResourceGroupInfoWatcher_Windows__CSystem__CAppResourceGroupInfoWatcherExecutionStateChangedEventArgs_t *")] ITypedEventHandler<IntPtr, IntPtr>* handler, EventRegistrationToken* token);

        [VtblIndex(15)]
        HRESULT remove_ExecutionStateChanged(EventRegistrationToken token);

        [VtblIndex(16)]
        HRESULT get_Status([NativeTypeName("ABI::Windows::System::AppResourceGroupInfoWatcherStatus *")] AppResourceGroupInfoWatcherStatus* status);

        [VtblIndex(17)]
        HRESULT Start();

        [VtblIndex(18)]
        HRESULT Stop();
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CSystem__CAppResourceGroupInfoWatcher_Windows__CSystem__CAppResourceGroupInfoWatcherEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<IntPtr, IntPtr>*, EventRegistrationToken*, int> add_Added;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_Added;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CSystem__CAppResourceGroupInfoWatcher_Windows__CSystem__CAppResourceGroupInfoWatcherEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<IntPtr, IntPtr>*, EventRegistrationToken*, int> add_Removed;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_Removed;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CSystem__CAppResourceGroupInfoWatcher_IInspectable_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<IntPtr, IntPtr>*, EventRegistrationToken*, int> add_EnumerationCompleted;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_EnumerationCompleted;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CSystem__CAppResourceGroupInfoWatcher_IInspectable_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<IntPtr, IntPtr>*, EventRegistrationToken*, int> add_Stopped;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_Stopped;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CSystem__CAppResourceGroupInfoWatcher_Windows__CSystem__CAppResourceGroupInfoWatcherExecutionStateChangedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<IntPtr, IntPtr>*, EventRegistrationToken*, int> add_ExecutionStateChanged;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_ExecutionStateChanged;

        [NativeTypeName("HRESULT (ABI::Windows::System::AppResourceGroupInfoWatcherStatus *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, AppResourceGroupInfoWatcherStatus*, int> get_Status;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> Start;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> Stop;
    }
}
