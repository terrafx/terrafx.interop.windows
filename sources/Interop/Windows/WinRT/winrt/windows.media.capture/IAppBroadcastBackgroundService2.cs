// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.capture.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IAppBroadcastBackgroundService2.xml' path='doc/member[@name="IAppBroadcastBackgroundService2"]/*' />
[Guid("FC8CCBBF-5549-4B87-959F-23CA401FD473")]
[NativeTypeName("struct IAppBroadcastBackgroundService2 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IAppBroadcastBackgroundService2 : IAppBroadcastBackgroundService2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAppBroadcastBackgroundService2));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastBackgroundService2*, Guid*, void**, int>)(lpVtbl[0]))((IAppBroadcastBackgroundService2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastBackgroundService2*, uint>)(lpVtbl[1]))((IAppBroadcastBackgroundService2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastBackgroundService2*, uint>)(lpVtbl[2]))((IAppBroadcastBackgroundService2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastBackgroundService2*, uint*, Guid**, int>)(lpVtbl[3]))((IAppBroadcastBackgroundService2*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastBackgroundService2*, HSTRING*, int>)(lpVtbl[4]))((IAppBroadcastBackgroundService2*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastBackgroundService2*, TrustLevel*, int>)(lpVtbl[5]))((IAppBroadcastBackgroundService2*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IAppBroadcastBackgroundService2.xml' path='doc/member[@name="IAppBroadcastBackgroundService2.put_BroadcastTitle"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT put_BroadcastTitle(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastBackgroundService2*, HSTRING, int>)(lpVtbl[6]))((IAppBroadcastBackgroundService2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppBroadcastBackgroundService2.xml' path='doc/member[@name="IAppBroadcastBackgroundService2.get_BroadcastLanguage"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_BroadcastLanguage(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastBackgroundService2*, HSTRING*, int>)(lpVtbl[7]))((IAppBroadcastBackgroundService2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppBroadcastBackgroundService2.xml' path='doc/member[@name="IAppBroadcastBackgroundService2.put_BroadcastLanguage"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT put_BroadcastLanguage(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastBackgroundService2*, HSTRING, int>)(lpVtbl[8]))((IAppBroadcastBackgroundService2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppBroadcastBackgroundService2.xml' path='doc/member[@name="IAppBroadcastBackgroundService2.get_BroadcastChannel"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_BroadcastChannel(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastBackgroundService2*, HSTRING*, int>)(lpVtbl[9]))((IAppBroadcastBackgroundService2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppBroadcastBackgroundService2.xml' path='doc/member[@name="IAppBroadcastBackgroundService2.put_BroadcastChannel"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT put_BroadcastChannel(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastBackgroundService2*, HSTRING, int>)(lpVtbl[10]))((IAppBroadcastBackgroundService2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppBroadcastBackgroundService2.xml' path='doc/member[@name="IAppBroadcastBackgroundService2.add_BroadcastTitleChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT add_BroadcastTitleChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CCapture__CAppBroadcastBackgroundService_IInspectable_t *")] ITypedEventHandler<Pointer<IAppBroadcastBackgroundService>, Pointer<IInspectable>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastBackgroundService2*, ITypedEventHandler<Pointer<IAppBroadcastBackgroundService>, Pointer<IInspectable>>*, EventRegistrationToken*, int>)(lpVtbl[11]))((IAppBroadcastBackgroundService2*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IAppBroadcastBackgroundService2.xml' path='doc/member[@name="IAppBroadcastBackgroundService2.remove_BroadcastTitleChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT remove_BroadcastTitleChanged(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastBackgroundService2*, EventRegistrationToken, int>)(lpVtbl[12]))((IAppBroadcastBackgroundService2*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='IAppBroadcastBackgroundService2.xml' path='doc/member[@name="IAppBroadcastBackgroundService2.add_BroadcastLanguageChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT add_BroadcastLanguageChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CCapture__CAppBroadcastBackgroundService_IInspectable_t *")] ITypedEventHandler<Pointer<IAppBroadcastBackgroundService>, Pointer<IInspectable>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastBackgroundService2*, ITypedEventHandler<Pointer<IAppBroadcastBackgroundService>, Pointer<IInspectable>>*, EventRegistrationToken*, int>)(lpVtbl[13]))((IAppBroadcastBackgroundService2*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IAppBroadcastBackgroundService2.xml' path='doc/member[@name="IAppBroadcastBackgroundService2.remove_BroadcastLanguageChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT remove_BroadcastLanguageChanged(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastBackgroundService2*, EventRegistrationToken, int>)(lpVtbl[14]))((IAppBroadcastBackgroundService2*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='IAppBroadcastBackgroundService2.xml' path='doc/member[@name="IAppBroadcastBackgroundService2.add_BroadcastChannelChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT add_BroadcastChannelChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CCapture__CAppBroadcastBackgroundService_IInspectable_t *")] ITypedEventHandler<Pointer<IAppBroadcastBackgroundService>, Pointer<IInspectable>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastBackgroundService2*, ITypedEventHandler<Pointer<IAppBroadcastBackgroundService>, Pointer<IInspectable>>*, EventRegistrationToken*, int>)(lpVtbl[15]))((IAppBroadcastBackgroundService2*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IAppBroadcastBackgroundService2.xml' path='doc/member[@name="IAppBroadcastBackgroundService2.remove_BroadcastChannelChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT remove_BroadcastChannelChanged(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastBackgroundService2*, EventRegistrationToken, int>)(lpVtbl[16]))((IAppBroadcastBackgroundService2*)Unsafe.AsPointer(ref this), token);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT put_BroadcastTitle(HSTRING value);

        [VtblIndex(7)]
        HRESULT get_BroadcastLanguage(HSTRING* value);

        [VtblIndex(8)]
        HRESULT put_BroadcastLanguage(HSTRING value);

        [VtblIndex(9)]
        HRESULT get_BroadcastChannel(HSTRING* value);

        [VtblIndex(10)]
        HRESULT put_BroadcastChannel(HSTRING value);

        [VtblIndex(11)]
        HRESULT add_BroadcastTitleChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CCapture__CAppBroadcastBackgroundService_IInspectable_t *")] ITypedEventHandler<Pointer<IAppBroadcastBackgroundService>, Pointer<IInspectable>>* handler, EventRegistrationToken* token);

        [VtblIndex(12)]
        HRESULT remove_BroadcastTitleChanged(EventRegistrationToken token);

        [VtblIndex(13)]
        HRESULT add_BroadcastLanguageChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CCapture__CAppBroadcastBackgroundService_IInspectable_t *")] ITypedEventHandler<Pointer<IAppBroadcastBackgroundService>, Pointer<IInspectable>>* handler, EventRegistrationToken* token);

        [VtblIndex(14)]
        HRESULT remove_BroadcastLanguageChanged(EventRegistrationToken token);

        [VtblIndex(15)]
        HRESULT add_BroadcastChannelChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CCapture__CAppBroadcastBackgroundService_IInspectable_t *")] ITypedEventHandler<Pointer<IAppBroadcastBackgroundService>, Pointer<IInspectable>>* handler, EventRegistrationToken* token);

        [VtblIndex(16)]
        HRESULT remove_BroadcastChannelChanged(EventRegistrationToken token);
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

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> put_BroadcastTitle;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_BroadcastLanguage;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> put_BroadcastLanguage;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_BroadcastChannel;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> put_BroadcastChannel;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CCapture__CAppBroadcastBackgroundService_IInspectable_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IAppBroadcastBackgroundService>, Pointer<IInspectable>>*, EventRegistrationToken*, int> add_BroadcastTitleChanged;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_BroadcastTitleChanged;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CCapture__CAppBroadcastBackgroundService_IInspectable_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IAppBroadcastBackgroundService>, Pointer<IInspectable>>*, EventRegistrationToken*, int> add_BroadcastLanguageChanged;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_BroadcastLanguageChanged;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CCapture__CAppBroadcastBackgroundService_IInspectable_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IAppBroadcastBackgroundService>, Pointer<IInspectable>>*, EventRegistrationToken*, int> add_BroadcastChannelChanged;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_BroadcastChannelChanged;
    }
}
