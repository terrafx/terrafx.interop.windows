// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.capture.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IAppBroadcastSignInStateChangedEventArgs.xml' path='doc/member[@name="IAppBroadcastSignInStateChangedEventArgs"]/*' />
[Guid("02B692A4-5919-4A9E-8D5E-C9BB0DD3377A")]
[NativeTypeName("struct IAppBroadcastSignInStateChangedEventArgs : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IAppBroadcastSignInStateChangedEventArgs : IAppBroadcastSignInStateChangedEventArgs.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAppBroadcastSignInStateChangedEventArgs));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastSignInStateChangedEventArgs*, Guid*, void**, int>)(lpVtbl[0]))((IAppBroadcastSignInStateChangedEventArgs*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastSignInStateChangedEventArgs*, uint>)(lpVtbl[1]))((IAppBroadcastSignInStateChangedEventArgs*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastSignInStateChangedEventArgs*, uint>)(lpVtbl[2]))((IAppBroadcastSignInStateChangedEventArgs*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastSignInStateChangedEventArgs*, uint*, Guid**, int>)(lpVtbl[3]))((IAppBroadcastSignInStateChangedEventArgs*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastSignInStateChangedEventArgs*, HSTRING*, int>)(lpVtbl[4]))((IAppBroadcastSignInStateChangedEventArgs*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastSignInStateChangedEventArgs*, TrustLevel*, int>)(lpVtbl[5]))((IAppBroadcastSignInStateChangedEventArgs*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IAppBroadcastSignInStateChangedEventArgs.xml' path='doc/member[@name="IAppBroadcastSignInStateChangedEventArgs.get_SignInState"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_SignInState([NativeTypeName("ABI::Windows::Media::Capture::AppBroadcastSignInState *")] AppBroadcastSignInState* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastSignInStateChangedEventArgs*, AppBroadcastSignInState*, int>)(lpVtbl[6]))((IAppBroadcastSignInStateChangedEventArgs*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppBroadcastSignInStateChangedEventArgs.xml' path='doc/member[@name="IAppBroadcastSignInStateChangedEventArgs.get_Result"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Result([NativeTypeName("ABI::Windows::Media::Capture::AppBroadcastSignInResult *")] AppBroadcastSignInResult* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastSignInStateChangedEventArgs*, AppBroadcastSignInResult*, int>)(lpVtbl[7]))((IAppBroadcastSignInStateChangedEventArgs*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_SignInState([NativeTypeName("ABI::Windows::Media::Capture::AppBroadcastSignInState *")] AppBroadcastSignInState* value);

        [VtblIndex(7)]
        HRESULT get_Result([NativeTypeName("ABI::Windows::Media::Capture::AppBroadcastSignInResult *")] AppBroadcastSignInResult* value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Media::Capture::AppBroadcastSignInResult *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, AppBroadcastSignInResult*, int> get_Result;
    }
}
