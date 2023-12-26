// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.capture.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IAppCaptureMetadataWriter.xml' path='doc/member[@name="IAppCaptureMetadataWriter"]/*' />
[Guid("E0CE4877-9AAF-46B4-AD31-6A60B441C780")]
[NativeTypeName("struct IAppCaptureMetadataWriter : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IAppCaptureMetadataWriter : IAppCaptureMetadataWriter.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAppCaptureMetadataWriter));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppCaptureMetadataWriter*, Guid*, void**, int>)(lpVtbl[0]))((IAppCaptureMetadataWriter*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IAppCaptureMetadataWriter*, uint>)(lpVtbl[1]))((IAppCaptureMetadataWriter*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IAppCaptureMetadataWriter*, uint>)(lpVtbl[2]))((IAppCaptureMetadataWriter*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppCaptureMetadataWriter*, uint*, Guid**, int>)(lpVtbl[3]))((IAppCaptureMetadataWriter*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppCaptureMetadataWriter*, HSTRING*, int>)(lpVtbl[4]))((IAppCaptureMetadataWriter*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppCaptureMetadataWriter*, TrustLevel*, int>)(lpVtbl[5]))((IAppCaptureMetadataWriter*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IAppCaptureMetadataWriter.xml' path='doc/member[@name="IAppCaptureMetadataWriter.AddStringEvent"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT AddStringEvent(HSTRING name, HSTRING value, [NativeTypeName("ABI::Windows::Media::Capture::AppCaptureMetadataPriority")] AppCaptureMetadataPriority priority)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppCaptureMetadataWriter*, HSTRING, HSTRING, AppCaptureMetadataPriority, int>)(lpVtbl[6]))((IAppCaptureMetadataWriter*)Unsafe.AsPointer(ref this), name, value, priority);
    }

    /// <include file='IAppCaptureMetadataWriter.xml' path='doc/member[@name="IAppCaptureMetadataWriter.AddInt32Event"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT AddInt32Event(HSTRING name, [NativeTypeName("INT32")] int value, [NativeTypeName("ABI::Windows::Media::Capture::AppCaptureMetadataPriority")] AppCaptureMetadataPriority priority)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppCaptureMetadataWriter*, HSTRING, int, AppCaptureMetadataPriority, int>)(lpVtbl[7]))((IAppCaptureMetadataWriter*)Unsafe.AsPointer(ref this), name, value, priority);
    }

    /// <include file='IAppCaptureMetadataWriter.xml' path='doc/member[@name="IAppCaptureMetadataWriter.AddDoubleEvent"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT AddDoubleEvent(HSTRING name, double value, [NativeTypeName("ABI::Windows::Media::Capture::AppCaptureMetadataPriority")] AppCaptureMetadataPriority priority)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppCaptureMetadataWriter*, HSTRING, double, AppCaptureMetadataPriority, int>)(lpVtbl[8]))((IAppCaptureMetadataWriter*)Unsafe.AsPointer(ref this), name, value, priority);
    }

    /// <include file='IAppCaptureMetadataWriter.xml' path='doc/member[@name="IAppCaptureMetadataWriter.StartStringState"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT StartStringState(HSTRING name, HSTRING value, [NativeTypeName("ABI::Windows::Media::Capture::AppCaptureMetadataPriority")] AppCaptureMetadataPriority priority)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppCaptureMetadataWriter*, HSTRING, HSTRING, AppCaptureMetadataPriority, int>)(lpVtbl[9]))((IAppCaptureMetadataWriter*)Unsafe.AsPointer(ref this), name, value, priority);
    }

    /// <include file='IAppCaptureMetadataWriter.xml' path='doc/member[@name="IAppCaptureMetadataWriter.StartInt32State"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT StartInt32State(HSTRING name, [NativeTypeName("INT32")] int value, [NativeTypeName("ABI::Windows::Media::Capture::AppCaptureMetadataPriority")] AppCaptureMetadataPriority priority)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppCaptureMetadataWriter*, HSTRING, int, AppCaptureMetadataPriority, int>)(lpVtbl[10]))((IAppCaptureMetadataWriter*)Unsafe.AsPointer(ref this), name, value, priority);
    }

    /// <include file='IAppCaptureMetadataWriter.xml' path='doc/member[@name="IAppCaptureMetadataWriter.StartDoubleState"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT StartDoubleState(HSTRING name, double value, [NativeTypeName("ABI::Windows::Media::Capture::AppCaptureMetadataPriority")] AppCaptureMetadataPriority priority)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppCaptureMetadataWriter*, HSTRING, double, AppCaptureMetadataPriority, int>)(lpVtbl[11]))((IAppCaptureMetadataWriter*)Unsafe.AsPointer(ref this), name, value, priority);
    }

    /// <include file='IAppCaptureMetadataWriter.xml' path='doc/member[@name="IAppCaptureMetadataWriter.StopState"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT StopState(HSTRING name)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppCaptureMetadataWriter*, HSTRING, int>)(lpVtbl[12]))((IAppCaptureMetadataWriter*)Unsafe.AsPointer(ref this), name);
    }

    /// <include file='IAppCaptureMetadataWriter.xml' path='doc/member[@name="IAppCaptureMetadataWriter.StopAllStates"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT StopAllStates()
    {
        return ((delegate* unmanaged[MemberFunction]<IAppCaptureMetadataWriter*, int>)(lpVtbl[13]))((IAppCaptureMetadataWriter*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IAppCaptureMetadataWriter.xml' path='doc/member[@name="IAppCaptureMetadataWriter.get_RemainingStorageBytesAvailable"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_RemainingStorageBytesAvailable([NativeTypeName("UINT64 *")] ulong* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppCaptureMetadataWriter*, ulong*, int>)(lpVtbl[14]))((IAppCaptureMetadataWriter*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppCaptureMetadataWriter.xml' path='doc/member[@name="IAppCaptureMetadataWriter.add_MetadataPurged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT add_MetadataPurged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CCapture__CAppCaptureMetadataWriter_IInspectable_t *")] ITypedEventHandler<IntPtr, IntPtr>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppCaptureMetadataWriter*, ITypedEventHandler<IntPtr, IntPtr>*, EventRegistrationToken*, int>)(lpVtbl[15]))((IAppCaptureMetadataWriter*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IAppCaptureMetadataWriter.xml' path='doc/member[@name="IAppCaptureMetadataWriter.remove_MetadataPurged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT remove_MetadataPurged(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppCaptureMetadataWriter*, EventRegistrationToken, int>)(lpVtbl[16]))((IAppCaptureMetadataWriter*)Unsafe.AsPointer(ref this), token);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT AddStringEvent(HSTRING name, HSTRING value, [NativeTypeName("ABI::Windows::Media::Capture::AppCaptureMetadataPriority")] AppCaptureMetadataPriority priority);

        [VtblIndex(7)]
        HRESULT AddInt32Event(HSTRING name, [NativeTypeName("INT32")] int value, [NativeTypeName("ABI::Windows::Media::Capture::AppCaptureMetadataPriority")] AppCaptureMetadataPriority priority);

        [VtblIndex(8)]
        HRESULT AddDoubleEvent(HSTRING name, double value, [NativeTypeName("ABI::Windows::Media::Capture::AppCaptureMetadataPriority")] AppCaptureMetadataPriority priority);

        [VtblIndex(9)]
        HRESULT StartStringState(HSTRING name, HSTRING value, [NativeTypeName("ABI::Windows::Media::Capture::AppCaptureMetadataPriority")] AppCaptureMetadataPriority priority);

        [VtblIndex(10)]
        HRESULT StartInt32State(HSTRING name, [NativeTypeName("INT32")] int value, [NativeTypeName("ABI::Windows::Media::Capture::AppCaptureMetadataPriority")] AppCaptureMetadataPriority priority);

        [VtblIndex(11)]
        HRESULT StartDoubleState(HSTRING name, double value, [NativeTypeName("ABI::Windows::Media::Capture::AppCaptureMetadataPriority")] AppCaptureMetadataPriority priority);

        [VtblIndex(12)]
        HRESULT StopState(HSTRING name);

        [VtblIndex(13)]
        HRESULT StopAllStates();

        [VtblIndex(14)]
        HRESULT get_RemainingStorageBytesAvailable([NativeTypeName("UINT64 *")] ulong* value);

        [VtblIndex(15)]
        HRESULT add_MetadataPurged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CCapture__CAppCaptureMetadataWriter_IInspectable_t *")] ITypedEventHandler<IntPtr, IntPtr>* handler, EventRegistrationToken* token);

        [VtblIndex(16)]
        HRESULT remove_MetadataPurged(EventRegistrationToken token);
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

        [NativeTypeName("HRESULT (HSTRING, HSTRING, ABI::Windows::Media::Capture::AppCaptureMetadataPriority) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, HSTRING, AppCaptureMetadataPriority, int> AddStringEvent;

        [NativeTypeName("HRESULT (HSTRING, INT32, ABI::Windows::Media::Capture::AppCaptureMetadataPriority) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int, AppCaptureMetadataPriority, int> AddInt32Event;

        [NativeTypeName("HRESULT (HSTRING, DOUBLE, ABI::Windows::Media::Capture::AppCaptureMetadataPriority) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, double, AppCaptureMetadataPriority, int> AddDoubleEvent;

        [NativeTypeName("HRESULT (HSTRING, HSTRING, ABI::Windows::Media::Capture::AppCaptureMetadataPriority) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, HSTRING, AppCaptureMetadataPriority, int> StartStringState;

        [NativeTypeName("HRESULT (HSTRING, INT32, ABI::Windows::Media::Capture::AppCaptureMetadataPriority) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int, AppCaptureMetadataPriority, int> StartInt32State;

        [NativeTypeName("HRESULT (HSTRING, DOUBLE, ABI::Windows::Media::Capture::AppCaptureMetadataPriority) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, double, AppCaptureMetadataPriority, int> StartDoubleState;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> StopState;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> StopAllStates;

        [NativeTypeName("HRESULT (UINT64 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ulong*, int> get_RemainingStorageBytesAvailable;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CCapture__CAppCaptureMetadataWriter_IInspectable_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<IntPtr, IntPtr>*, EventRegistrationToken*, int> add_MetadataPurged;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_MetadataPurged;
    }
}
