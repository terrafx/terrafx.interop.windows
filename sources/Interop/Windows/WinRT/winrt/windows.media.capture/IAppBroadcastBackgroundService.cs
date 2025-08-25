// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.capture.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IAppBroadcastBackgroundService.xml' path='doc/member[@name="IAppBroadcastBackgroundService"]/*' />
[Guid("BAD1E72A-FA94-46F9-95FC-D71511CDA70B")]
[NativeTypeName("struct IAppBroadcastBackgroundService : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IAppBroadcastBackgroundService : IAppBroadcastBackgroundService.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IAppBroadcastBackgroundService);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastBackgroundService*, Guid*, void**, int>)(lpVtbl[0]))((IAppBroadcastBackgroundService*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastBackgroundService*, uint>)(lpVtbl[1]))((IAppBroadcastBackgroundService*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastBackgroundService*, uint>)(lpVtbl[2]))((IAppBroadcastBackgroundService*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastBackgroundService*, uint*, Guid**, int>)(lpVtbl[3]))((IAppBroadcastBackgroundService*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastBackgroundService*, HSTRING*, int>)(lpVtbl[4]))((IAppBroadcastBackgroundService*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastBackgroundService*, TrustLevel*, int>)(lpVtbl[5]))((IAppBroadcastBackgroundService*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IAppBroadcastBackgroundService.xml' path='doc/member[@name="IAppBroadcastBackgroundService.put_PlugInState"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT put_PlugInState([NativeTypeName("ABI::Windows::Media::Capture::AppBroadcastPlugInState")] AppBroadcastPlugInState value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastBackgroundService*, AppBroadcastPlugInState, int>)(lpVtbl[6]))((IAppBroadcastBackgroundService*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppBroadcastBackgroundService.xml' path='doc/member[@name="IAppBroadcastBackgroundService.get_PlugInState"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_PlugInState([NativeTypeName("ABI::Windows::Media::Capture::AppBroadcastPlugInState *")] AppBroadcastPlugInState* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastBackgroundService*, AppBroadcastPlugInState*, int>)(lpVtbl[7]))((IAppBroadcastBackgroundService*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppBroadcastBackgroundService.xml' path='doc/member[@name="IAppBroadcastBackgroundService.put_SignInInfo"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT put_SignInInfo([NativeTypeName("ABI::Windows::Media::Capture::IAppBroadcastBackgroundServiceSignInInfo *")] IAppBroadcastBackgroundServiceSignInInfo* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastBackgroundService*, IAppBroadcastBackgroundServiceSignInInfo*, int>)(lpVtbl[8]))((IAppBroadcastBackgroundService*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppBroadcastBackgroundService.xml' path='doc/member[@name="IAppBroadcastBackgroundService.get_SignInInfo"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_SignInInfo([NativeTypeName("ABI::Windows::Media::Capture::IAppBroadcastBackgroundServiceSignInInfo **")] IAppBroadcastBackgroundServiceSignInInfo** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastBackgroundService*, IAppBroadcastBackgroundServiceSignInInfo**, int>)(lpVtbl[9]))((IAppBroadcastBackgroundService*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppBroadcastBackgroundService.xml' path='doc/member[@name="IAppBroadcastBackgroundService.put_StreamInfo"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT put_StreamInfo([NativeTypeName("ABI::Windows::Media::Capture::IAppBroadcastBackgroundServiceStreamInfo *")] IAppBroadcastBackgroundServiceStreamInfo* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastBackgroundService*, IAppBroadcastBackgroundServiceStreamInfo*, int>)(lpVtbl[10]))((IAppBroadcastBackgroundService*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppBroadcastBackgroundService.xml' path='doc/member[@name="IAppBroadcastBackgroundService.get_StreamInfo"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_StreamInfo([NativeTypeName("ABI::Windows::Media::Capture::IAppBroadcastBackgroundServiceStreamInfo **")] IAppBroadcastBackgroundServiceStreamInfo** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastBackgroundService*, IAppBroadcastBackgroundServiceStreamInfo**, int>)(lpVtbl[11]))((IAppBroadcastBackgroundService*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppBroadcastBackgroundService.xml' path='doc/member[@name="IAppBroadcastBackgroundService.get_AppId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_AppId(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastBackgroundService*, HSTRING*, int>)(lpVtbl[12]))((IAppBroadcastBackgroundService*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppBroadcastBackgroundService.xml' path='doc/member[@name="IAppBroadcastBackgroundService.get_BroadcastTitle"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_BroadcastTitle(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastBackgroundService*, HSTRING*, int>)(lpVtbl[13]))((IAppBroadcastBackgroundService*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppBroadcastBackgroundService.xml' path='doc/member[@name="IAppBroadcastBackgroundService.put_ViewerCount"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT put_ViewerCount([NativeTypeName("UINT32")] uint value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastBackgroundService*, uint, int>)(lpVtbl[14]))((IAppBroadcastBackgroundService*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppBroadcastBackgroundService.xml' path='doc/member[@name="IAppBroadcastBackgroundService.get_ViewerCount"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT get_ViewerCount([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastBackgroundService*, uint*, int>)(lpVtbl[15]))((IAppBroadcastBackgroundService*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppBroadcastBackgroundService.xml' path='doc/member[@name="IAppBroadcastBackgroundService.TerminateBroadcast"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT TerminateBroadcast([NativeTypeName("ABI::Windows::Media::Capture::AppBroadcastTerminationReason")] AppBroadcastTerminationReason reason, [NativeTypeName("UINT32")] uint providerSpecificReason)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastBackgroundService*, AppBroadcastTerminationReason, uint, int>)(lpVtbl[16]))((IAppBroadcastBackgroundService*)Unsafe.AsPointer(ref this), reason, providerSpecificReason);
    }

    /// <include file='IAppBroadcastBackgroundService.xml' path='doc/member[@name="IAppBroadcastBackgroundService.add_HeartbeatRequested"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT add_HeartbeatRequested([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CCapture__CAppBroadcastBackgroundService_Windows__CMedia__CCapture__CAppBroadcastHeartbeatRequestedEventArgs_t *")] ITypedEventHandler<Pointer<IAppBroadcastBackgroundService>, Pointer<IAppBroadcastHeartbeatRequestedEventArgs>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastBackgroundService*, ITypedEventHandler<Pointer<IAppBroadcastBackgroundService>, Pointer<IAppBroadcastHeartbeatRequestedEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[17]))((IAppBroadcastBackgroundService*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IAppBroadcastBackgroundService.xml' path='doc/member[@name="IAppBroadcastBackgroundService.remove_HeartbeatRequested"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT remove_HeartbeatRequested(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastBackgroundService*, EventRegistrationToken, int>)(lpVtbl[18]))((IAppBroadcastBackgroundService*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='IAppBroadcastBackgroundService.xml' path='doc/member[@name="IAppBroadcastBackgroundService.get_TitleId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT get_TitleId(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastBackgroundService*, HSTRING*, int>)(lpVtbl[19]))((IAppBroadcastBackgroundService*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT put_PlugInState([NativeTypeName("ABI::Windows::Media::Capture::AppBroadcastPlugInState")] AppBroadcastPlugInState value);

        [VtblIndex(7)]
        HRESULT get_PlugInState([NativeTypeName("ABI::Windows::Media::Capture::AppBroadcastPlugInState *")] AppBroadcastPlugInState* value);

        [VtblIndex(8)]
        HRESULT put_SignInInfo([NativeTypeName("ABI::Windows::Media::Capture::IAppBroadcastBackgroundServiceSignInInfo *")] IAppBroadcastBackgroundServiceSignInInfo* value);

        [VtblIndex(9)]
        HRESULT get_SignInInfo([NativeTypeName("ABI::Windows::Media::Capture::IAppBroadcastBackgroundServiceSignInInfo **")] IAppBroadcastBackgroundServiceSignInInfo** value);

        [VtblIndex(10)]
        HRESULT put_StreamInfo([NativeTypeName("ABI::Windows::Media::Capture::IAppBroadcastBackgroundServiceStreamInfo *")] IAppBroadcastBackgroundServiceStreamInfo* value);

        [VtblIndex(11)]
        HRESULT get_StreamInfo([NativeTypeName("ABI::Windows::Media::Capture::IAppBroadcastBackgroundServiceStreamInfo **")] IAppBroadcastBackgroundServiceStreamInfo** value);

        [VtblIndex(12)]
        HRESULT get_AppId(HSTRING* value);

        [VtblIndex(13)]
        HRESULT get_BroadcastTitle(HSTRING* value);

        [VtblIndex(14)]
        HRESULT put_ViewerCount([NativeTypeName("UINT32")] uint value);

        [VtblIndex(15)]
        HRESULT get_ViewerCount([NativeTypeName("UINT32 *")] uint* value);

        [VtblIndex(16)]
        HRESULT TerminateBroadcast([NativeTypeName("ABI::Windows::Media::Capture::AppBroadcastTerminationReason")] AppBroadcastTerminationReason reason, [NativeTypeName("UINT32")] uint providerSpecificReason);

        [VtblIndex(17)]
        HRESULT add_HeartbeatRequested([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CCapture__CAppBroadcastBackgroundService_Windows__CMedia__CCapture__CAppBroadcastHeartbeatRequestedEventArgs_t *")] ITypedEventHandler<Pointer<IAppBroadcastBackgroundService>, Pointer<IAppBroadcastHeartbeatRequestedEventArgs>>* handler, EventRegistrationToken* token);

        [VtblIndex(18)]
        HRESULT remove_HeartbeatRequested(EventRegistrationToken token);

        [VtblIndex(19)]
        HRESULT get_TitleId(HSTRING* value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Media::Capture::AppBroadcastPlugInState) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, AppBroadcastPlugInState, int> put_PlugInState;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Capture::AppBroadcastPlugInState *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, AppBroadcastPlugInState*, int> get_PlugInState;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Capture::IAppBroadcastBackgroundServiceSignInInfo *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAppBroadcastBackgroundServiceSignInInfo*, int> put_SignInInfo;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Capture::IAppBroadcastBackgroundServiceSignInInfo **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAppBroadcastBackgroundServiceSignInInfo**, int> get_SignInInfo;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Capture::IAppBroadcastBackgroundServiceStreamInfo *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAppBroadcastBackgroundServiceStreamInfo*, int> put_StreamInfo;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Capture::IAppBroadcastBackgroundServiceStreamInfo **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAppBroadcastBackgroundServiceStreamInfo**, int> get_StreamInfo;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_AppId;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_BroadcastTitle;

        [NativeTypeName("HRESULT (UINT32) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, int> put_ViewerCount;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_ViewerCount;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Capture::AppBroadcastTerminationReason, UINT32) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, AppBroadcastTerminationReason, uint, int> TerminateBroadcast;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CCapture__CAppBroadcastBackgroundService_Windows__CMedia__CCapture__CAppBroadcastHeartbeatRequestedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IAppBroadcastBackgroundService>, Pointer<IAppBroadcastHeartbeatRequestedEventArgs>>*, EventRegistrationToken*, int> add_HeartbeatRequested;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_HeartbeatRequested;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_TitleId;
    }
}
