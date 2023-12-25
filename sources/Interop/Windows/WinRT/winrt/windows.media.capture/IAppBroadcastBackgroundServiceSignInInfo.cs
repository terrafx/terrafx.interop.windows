// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.capture.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IAppBroadcastBackgroundServiceSignInInfo.xml' path='doc/member[@name="IAppBroadcastBackgroundServiceSignInInfo"]/*' />
[Guid("5E735275-88C8-4ECA-89BA-4825985DB880")]
[NativeTypeName("struct IAppBroadcastBackgroundServiceSignInInfo : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IAppBroadcastBackgroundServiceSignInInfo : IAppBroadcastBackgroundServiceSignInInfo.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAppBroadcastBackgroundServiceSignInInfo));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastBackgroundServiceSignInInfo*, Guid*, void**, int>)(lpVtbl[0]))((IAppBroadcastBackgroundServiceSignInInfo*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastBackgroundServiceSignInInfo*, uint>)(lpVtbl[1]))((IAppBroadcastBackgroundServiceSignInInfo*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastBackgroundServiceSignInInfo*, uint>)(lpVtbl[2]))((IAppBroadcastBackgroundServiceSignInInfo*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastBackgroundServiceSignInInfo*, uint*, Guid**, int>)(lpVtbl[3]))((IAppBroadcastBackgroundServiceSignInInfo*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastBackgroundServiceSignInInfo*, HSTRING*, int>)(lpVtbl[4]))((IAppBroadcastBackgroundServiceSignInInfo*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastBackgroundServiceSignInInfo*, TrustLevel*, int>)(lpVtbl[5]))((IAppBroadcastBackgroundServiceSignInInfo*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IAppBroadcastBackgroundServiceSignInInfo.xml' path='doc/member[@name="IAppBroadcastBackgroundServiceSignInInfo.get_SignInState"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_SignInState([NativeTypeName("ABI::Windows::Media::Capture::AppBroadcastSignInState *")] AppBroadcastSignInState* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastBackgroundServiceSignInInfo*, AppBroadcastSignInState*, int>)(lpVtbl[6]))((IAppBroadcastBackgroundServiceSignInInfo*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppBroadcastBackgroundServiceSignInInfo.xml' path='doc/member[@name="IAppBroadcastBackgroundServiceSignInInfo.put_OAuthRequestUri"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_OAuthRequestUri([NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastBackgroundServiceSignInInfo*, IUriRuntimeClass*, int>)(lpVtbl[7]))((IAppBroadcastBackgroundServiceSignInInfo*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppBroadcastBackgroundServiceSignInInfo.xml' path='doc/member[@name="IAppBroadcastBackgroundServiceSignInInfo.get_OAuthRequestUri"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_OAuthRequestUri([NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass **")] IUriRuntimeClass** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastBackgroundServiceSignInInfo*, IUriRuntimeClass**, int>)(lpVtbl[8]))((IAppBroadcastBackgroundServiceSignInInfo*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppBroadcastBackgroundServiceSignInInfo.xml' path='doc/member[@name="IAppBroadcastBackgroundServiceSignInInfo.put_OAuthCallbackUri"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_OAuthCallbackUri([NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastBackgroundServiceSignInInfo*, IUriRuntimeClass*, int>)(lpVtbl[9]))((IAppBroadcastBackgroundServiceSignInInfo*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppBroadcastBackgroundServiceSignInInfo.xml' path='doc/member[@name="IAppBroadcastBackgroundServiceSignInInfo.get_OAuthCallbackUri"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_OAuthCallbackUri([NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass **")] IUriRuntimeClass** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastBackgroundServiceSignInInfo*, IUriRuntimeClass**, int>)(lpVtbl[10]))((IAppBroadcastBackgroundServiceSignInInfo*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppBroadcastBackgroundServiceSignInInfo.xml' path='doc/member[@name="IAppBroadcastBackgroundServiceSignInInfo.get_AuthenticationResult"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_AuthenticationResult([NativeTypeName("ABI::Windows::Security::Authentication::Web::IWebAuthenticationResult **")] IWebAuthenticationResult** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastBackgroundServiceSignInInfo*, IWebAuthenticationResult**, int>)(lpVtbl[11]))((IAppBroadcastBackgroundServiceSignInInfo*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppBroadcastBackgroundServiceSignInInfo.xml' path='doc/member[@name="IAppBroadcastBackgroundServiceSignInInfo.put_UserName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT put_UserName(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastBackgroundServiceSignInInfo*, HSTRING, int>)(lpVtbl[12]))((IAppBroadcastBackgroundServiceSignInInfo*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppBroadcastBackgroundServiceSignInInfo.xml' path='doc/member[@name="IAppBroadcastBackgroundServiceSignInInfo.get_UserName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_UserName(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastBackgroundServiceSignInInfo*, HSTRING*, int>)(lpVtbl[13]))((IAppBroadcastBackgroundServiceSignInInfo*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppBroadcastBackgroundServiceSignInInfo.xml' path='doc/member[@name="IAppBroadcastBackgroundServiceSignInInfo.add_SignInStateChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT add_SignInStateChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CCapture__CAppBroadcastBackgroundServiceSignInInfo_Windows__CMedia__CCapture__CAppBroadcastSignInStateChangedEventArgs_t *")] ITypedEventHandler<IntPtr, IntPtr>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastBackgroundServiceSignInInfo*, ITypedEventHandler<IntPtr, IntPtr>*, EventRegistrationToken*, int>)(lpVtbl[14]))((IAppBroadcastBackgroundServiceSignInInfo*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IAppBroadcastBackgroundServiceSignInInfo.xml' path='doc/member[@name="IAppBroadcastBackgroundServiceSignInInfo.remove_SignInStateChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT remove_SignInStateChanged(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastBackgroundServiceSignInInfo*, EventRegistrationToken, int>)(lpVtbl[15]))((IAppBroadcastBackgroundServiceSignInInfo*)Unsafe.AsPointer(ref this), token);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_SignInState([NativeTypeName("ABI::Windows::Media::Capture::AppBroadcastSignInState *")] AppBroadcastSignInState* value);

        [VtblIndex(7)]
        HRESULT put_OAuthRequestUri([NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass* value);

        [VtblIndex(8)]
        HRESULT get_OAuthRequestUri([NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass **")] IUriRuntimeClass** value);

        [VtblIndex(9)]
        HRESULT put_OAuthCallbackUri([NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass* value);

        [VtblIndex(10)]
        HRESULT get_OAuthCallbackUri([NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass **")] IUriRuntimeClass** value);

        [VtblIndex(11)]
        HRESULT get_AuthenticationResult([NativeTypeName("ABI::Windows::Security::Authentication::Web::IWebAuthenticationResult **")] IWebAuthenticationResult** value);

        [VtblIndex(12)]
        HRESULT put_UserName(HSTRING value);

        [VtblIndex(13)]
        HRESULT get_UserName(HSTRING* value);

        [VtblIndex(14)]
        HRESULT add_SignInStateChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CCapture__CAppBroadcastBackgroundServiceSignInInfo_Windows__CMedia__CCapture__CAppBroadcastSignInStateChangedEventArgs_t *")] ITypedEventHandler<IntPtr, IntPtr>* handler, EventRegistrationToken* token);

        [VtblIndex(15)]
        HRESULT remove_SignInStateChanged(EventRegistrationToken token);
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

        [NativeTypeName("HRESULT (ABI::Windows::Media::Capture::AppBroadcastSignInState *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, AppBroadcastSignInState*, int> get_SignInState;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::IUriRuntimeClass *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IUriRuntimeClass*, int> put_OAuthRequestUri;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::IUriRuntimeClass **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IUriRuntimeClass**, int> get_OAuthRequestUri;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::IUriRuntimeClass *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IUriRuntimeClass*, int> put_OAuthCallbackUri;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::IUriRuntimeClass **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IUriRuntimeClass**, int> get_OAuthCallbackUri;

        [NativeTypeName("HRESULT (ABI::Windows::Security::Authentication::Web::IWebAuthenticationResult **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IWebAuthenticationResult**, int> get_AuthenticationResult;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> put_UserName;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_UserName;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CCapture__CAppBroadcastBackgroundServiceSignInInfo_Windows__CMedia__CCapture__CAppBroadcastSignInStateChangedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<IntPtr, IntPtr>*, EventRegistrationToken*, int> add_SignInStateChanged;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_SignInStateChanged;
    }
}
