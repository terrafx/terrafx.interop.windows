// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.capture.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IGameBarServices.xml' path='doc/member[@name="IGameBarServices"]/*' />
[Guid("2DBEAD57-50A6-499E-8C6C-D330A7311796")]
[NativeTypeName("struct IGameBarServices : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IGameBarServices : IGameBarServices.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IGameBarServices);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IGameBarServices*, Guid*, void**, int>)(lpVtbl[0]))((IGameBarServices*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IGameBarServices*, uint>)(lpVtbl[1]))((IGameBarServices*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IGameBarServices*, uint>)(lpVtbl[2]))((IGameBarServices*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IGameBarServices*, uint*, Guid**, int>)(lpVtbl[3]))((IGameBarServices*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IGameBarServices*, HSTRING*, int>)(lpVtbl[4]))((IGameBarServices*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IGameBarServices*, TrustLevel*, int>)(lpVtbl[5]))((IGameBarServices*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IGameBarServices.xml' path='doc/member[@name="IGameBarServices.get_TargetCapturePolicy"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_TargetCapturePolicy([NativeTypeName("ABI::Windows::Media::Capture::GameBarTargetCapturePolicy *")] GameBarTargetCapturePolicy* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGameBarServices*, GameBarTargetCapturePolicy*, int>)(lpVtbl[6]))((IGameBarServices*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGameBarServices.xml' path='doc/member[@name="IGameBarServices.EnableCapture"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT EnableCapture()
    {
        return ((delegate* unmanaged[MemberFunction]<IGameBarServices*, int>)(lpVtbl[7]))((IGameBarServices*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IGameBarServices.xml' path='doc/member[@name="IGameBarServices.DisableCapture"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT DisableCapture()
    {
        return ((delegate* unmanaged[MemberFunction]<IGameBarServices*, int>)(lpVtbl[8]))((IGameBarServices*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IGameBarServices.xml' path='doc/member[@name="IGameBarServices.get_TargetInfo"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_TargetInfo([NativeTypeName("ABI::Windows::Media::Capture::IGameBarServicesTargetInfo **")] IGameBarServicesTargetInfo** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGameBarServices*, IGameBarServicesTargetInfo**, int>)(lpVtbl[9]))((IGameBarServices*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGameBarServices.xml' path='doc/member[@name="IGameBarServices.get_SessionId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_SessionId(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGameBarServices*, HSTRING*, int>)(lpVtbl[10]))((IGameBarServices*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGameBarServices.xml' path='doc/member[@name="IGameBarServices.get_AppBroadcastServices"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_AppBroadcastServices([NativeTypeName("ABI::Windows::Media::Capture::IAppBroadcastServices **")] IAppBroadcastServices** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGameBarServices*, IAppBroadcastServices**, int>)(lpVtbl[11]))((IGameBarServices*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGameBarServices.xml' path='doc/member[@name="IGameBarServices.get_AppCaptureServices"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_AppCaptureServices([NativeTypeName("ABI::Windows::Media::Capture::IAppCaptureServices **")] IAppCaptureServices** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGameBarServices*, IAppCaptureServices**, int>)(lpVtbl[12]))((IGameBarServices*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGameBarServices.xml' path='doc/member[@name="IGameBarServices.add_CommandReceived"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT add_CommandReceived([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CCapture__CGameBarServices_Windows__CMedia__CCapture__CGameBarServicesCommandEventArgs_t *")] ITypedEventHandler<Pointer<IGameBarServices>, Pointer<IGameBarServicesCommandEventArgs>>* value, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IGameBarServices*, ITypedEventHandler<Pointer<IGameBarServices>, Pointer<IGameBarServicesCommandEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[13]))((IGameBarServices*)Unsafe.AsPointer(ref this), value, token);
    }

    /// <include file='IGameBarServices.xml' path='doc/member[@name="IGameBarServices.remove_CommandReceived"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT remove_CommandReceived(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IGameBarServices*, EventRegistrationToken, int>)(lpVtbl[14]))((IGameBarServices*)Unsafe.AsPointer(ref this), token);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_TargetCapturePolicy([NativeTypeName("ABI::Windows::Media::Capture::GameBarTargetCapturePolicy *")] GameBarTargetCapturePolicy* value);

        [VtblIndex(7)]
        HRESULT EnableCapture();

        [VtblIndex(8)]
        HRESULT DisableCapture();

        [VtblIndex(9)]
        HRESULT get_TargetInfo([NativeTypeName("ABI::Windows::Media::Capture::IGameBarServicesTargetInfo **")] IGameBarServicesTargetInfo** value);

        [VtblIndex(10)]
        HRESULT get_SessionId(HSTRING* value);

        [VtblIndex(11)]
        HRESULT get_AppBroadcastServices([NativeTypeName("ABI::Windows::Media::Capture::IAppBroadcastServices **")] IAppBroadcastServices** value);

        [VtblIndex(12)]
        HRESULT get_AppCaptureServices([NativeTypeName("ABI::Windows::Media::Capture::IAppCaptureServices **")] IAppCaptureServices** value);

        [VtblIndex(13)]
        HRESULT add_CommandReceived([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CCapture__CGameBarServices_Windows__CMedia__CCapture__CGameBarServicesCommandEventArgs_t *")] ITypedEventHandler<Pointer<IGameBarServices>, Pointer<IGameBarServicesCommandEventArgs>>* value, EventRegistrationToken* token);

        [VtblIndex(14)]
        HRESULT remove_CommandReceived(EventRegistrationToken token);
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

        [NativeTypeName("HRESULT (ABI::Windows::Media::Capture::GameBarTargetCapturePolicy *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, GameBarTargetCapturePolicy*, int> get_TargetCapturePolicy;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> EnableCapture;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> DisableCapture;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Capture::IGameBarServicesTargetInfo **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IGameBarServicesTargetInfo**, int> get_TargetInfo;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_SessionId;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Capture::IAppBroadcastServices **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAppBroadcastServices**, int> get_AppBroadcastServices;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Capture::IAppCaptureServices **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAppCaptureServices**, int> get_AppCaptureServices;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CCapture__CGameBarServices_Windows__CMedia__CCapture__CGameBarServicesCommandEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IGameBarServices>, Pointer<IGameBarServicesCommandEventArgs>>*, EventRegistrationToken*, int> add_CommandReceived;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_CommandReceived;
    }
}
