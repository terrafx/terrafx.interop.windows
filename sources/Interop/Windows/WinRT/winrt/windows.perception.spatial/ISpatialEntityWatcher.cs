// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.perception.spatial.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ISpatialEntityWatcher.xml' path='doc/member[@name="ISpatialEntityWatcher"]/*' />
[Guid("B3B85FA0-6D5E-4BBC-805D-5FE5B9BA1959")]
[NativeTypeName("struct ISpatialEntityWatcher : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ISpatialEntityWatcher : ISpatialEntityWatcher.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISpatialEntityWatcher));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpatialEntityWatcher*, Guid*, void**, int>)(lpVtbl[0]))((ISpatialEntityWatcher*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ISpatialEntityWatcher*, uint>)(lpVtbl[1]))((ISpatialEntityWatcher*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ISpatialEntityWatcher*, uint>)(lpVtbl[2]))((ISpatialEntityWatcher*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpatialEntityWatcher*, uint*, Guid**, int>)(lpVtbl[3]))((ISpatialEntityWatcher*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpatialEntityWatcher*, HSTRING*, int>)(lpVtbl[4]))((ISpatialEntityWatcher*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpatialEntityWatcher*, TrustLevel*, int>)(lpVtbl[5]))((ISpatialEntityWatcher*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ISpatialEntityWatcher.xml' path='doc/member[@name="ISpatialEntityWatcher.get_Status"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Status([NativeTypeName("ABI::Windows::Perception::Spatial::SpatialEntityWatcherStatus *")] SpatialEntityWatcherStatus* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpatialEntityWatcher*, SpatialEntityWatcherStatus*, int>)(lpVtbl[6]))((ISpatialEntityWatcher*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISpatialEntityWatcher.xml' path='doc/member[@name="ISpatialEntityWatcher.add_Added"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT add_Added([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CPerception__CSpatial__CSpatialEntityWatcher_Windows__CPerception__CSpatial__CSpatialEntityAddedEventArgs_t *")] ITypedEventHandler<IntPtr, IntPtr>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpatialEntityWatcher*, ITypedEventHandler<IntPtr, IntPtr>*, EventRegistrationToken*, int>)(lpVtbl[7]))((ISpatialEntityWatcher*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='ISpatialEntityWatcher.xml' path='doc/member[@name="ISpatialEntityWatcher.remove_Added"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT remove_Added(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpatialEntityWatcher*, EventRegistrationToken, int>)(lpVtbl[8]))((ISpatialEntityWatcher*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='ISpatialEntityWatcher.xml' path='doc/member[@name="ISpatialEntityWatcher.add_Updated"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT add_Updated([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CPerception__CSpatial__CSpatialEntityWatcher_Windows__CPerception__CSpatial__CSpatialEntityUpdatedEventArgs_t *")] ITypedEventHandler<IntPtr, IntPtr>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpatialEntityWatcher*, ITypedEventHandler<IntPtr, IntPtr>*, EventRegistrationToken*, int>)(lpVtbl[9]))((ISpatialEntityWatcher*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='ISpatialEntityWatcher.xml' path='doc/member[@name="ISpatialEntityWatcher.remove_Updated"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT remove_Updated(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpatialEntityWatcher*, EventRegistrationToken, int>)(lpVtbl[10]))((ISpatialEntityWatcher*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='ISpatialEntityWatcher.xml' path='doc/member[@name="ISpatialEntityWatcher.add_Removed"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT add_Removed([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CPerception__CSpatial__CSpatialEntityWatcher_Windows__CPerception__CSpatial__CSpatialEntityRemovedEventArgs_t *")] ITypedEventHandler<IntPtr, IntPtr>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpatialEntityWatcher*, ITypedEventHandler<IntPtr, IntPtr>*, EventRegistrationToken*, int>)(lpVtbl[11]))((ISpatialEntityWatcher*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='ISpatialEntityWatcher.xml' path='doc/member[@name="ISpatialEntityWatcher.remove_Removed"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT remove_Removed(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpatialEntityWatcher*, EventRegistrationToken, int>)(lpVtbl[12]))((ISpatialEntityWatcher*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='ISpatialEntityWatcher.xml' path='doc/member[@name="ISpatialEntityWatcher.add_EnumerationCompleted"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT add_EnumerationCompleted([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CPerception__CSpatial__CSpatialEntityWatcher_IInspectable_t *")] ITypedEventHandler<IntPtr, IntPtr>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpatialEntityWatcher*, ITypedEventHandler<IntPtr, IntPtr>*, EventRegistrationToken*, int>)(lpVtbl[13]))((ISpatialEntityWatcher*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='ISpatialEntityWatcher.xml' path='doc/member[@name="ISpatialEntityWatcher.remove_EnumerationCompleted"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT remove_EnumerationCompleted(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpatialEntityWatcher*, EventRegistrationToken, int>)(lpVtbl[14]))((ISpatialEntityWatcher*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='ISpatialEntityWatcher.xml' path='doc/member[@name="ISpatialEntityWatcher.Start"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT Start()
    {
        return ((delegate* unmanaged[MemberFunction]<ISpatialEntityWatcher*, int>)(lpVtbl[15]))((ISpatialEntityWatcher*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ISpatialEntityWatcher.xml' path='doc/member[@name="ISpatialEntityWatcher.Stop"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT Stop()
    {
        return ((delegate* unmanaged[MemberFunction]<ISpatialEntityWatcher*, int>)(lpVtbl[16]))((ISpatialEntityWatcher*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Status([NativeTypeName("ABI::Windows::Perception::Spatial::SpatialEntityWatcherStatus *")] SpatialEntityWatcherStatus* value);

        [VtblIndex(7)]
        HRESULT add_Added([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CPerception__CSpatial__CSpatialEntityWatcher_Windows__CPerception__CSpatial__CSpatialEntityAddedEventArgs_t *")] ITypedEventHandler<IntPtr, IntPtr>* handler, EventRegistrationToken* token);

        [VtblIndex(8)]
        HRESULT remove_Added(EventRegistrationToken token);

        [VtblIndex(9)]
        HRESULT add_Updated([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CPerception__CSpatial__CSpatialEntityWatcher_Windows__CPerception__CSpatial__CSpatialEntityUpdatedEventArgs_t *")] ITypedEventHandler<IntPtr, IntPtr>* handler, EventRegistrationToken* token);

        [VtblIndex(10)]
        HRESULT remove_Updated(EventRegistrationToken token);

        [VtblIndex(11)]
        HRESULT add_Removed([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CPerception__CSpatial__CSpatialEntityWatcher_Windows__CPerception__CSpatial__CSpatialEntityRemovedEventArgs_t *")] ITypedEventHandler<IntPtr, IntPtr>* handler, EventRegistrationToken* token);

        [VtblIndex(12)]
        HRESULT remove_Removed(EventRegistrationToken token);

        [VtblIndex(13)]
        HRESULT add_EnumerationCompleted([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CPerception__CSpatial__CSpatialEntityWatcher_IInspectable_t *")] ITypedEventHandler<IntPtr, IntPtr>* handler, EventRegistrationToken* token);

        [VtblIndex(14)]
        HRESULT remove_EnumerationCompleted(EventRegistrationToken token);

        [VtblIndex(15)]
        HRESULT Start();

        [VtblIndex(16)]
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

        [NativeTypeName("HRESULT (ABI::Windows::Perception::Spatial::SpatialEntityWatcherStatus *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, SpatialEntityWatcherStatus*, int> get_Status;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CPerception__CSpatial__CSpatialEntityWatcher_Windows__CPerception__CSpatial__CSpatialEntityAddedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<IntPtr, IntPtr>*, EventRegistrationToken*, int> add_Added;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_Added;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CPerception__CSpatial__CSpatialEntityWatcher_Windows__CPerception__CSpatial__CSpatialEntityUpdatedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<IntPtr, IntPtr>*, EventRegistrationToken*, int> add_Updated;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_Updated;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CPerception__CSpatial__CSpatialEntityWatcher_Windows__CPerception__CSpatial__CSpatialEntityRemovedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<IntPtr, IntPtr>*, EventRegistrationToken*, int> add_Removed;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_Removed;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CPerception__CSpatial__CSpatialEntityWatcher_IInspectable_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<IntPtr, IntPtr>*, EventRegistrationToken*, int> add_EnumerationCompleted;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_EnumerationCompleted;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> Start;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> Stop;
    }
}
