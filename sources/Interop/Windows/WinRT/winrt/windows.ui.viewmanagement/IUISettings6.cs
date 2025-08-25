// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.viewmanagement.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IUISettings6.xml' path='doc/member[@name="IUISettings6"]/*' />
[Guid("AEF19BD7-FE31-5A04-ADA4-469AAEC6DFA9")]
[NativeTypeName("struct IUISettings6 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IUISettings6 : IUISettings6.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IUISettings6);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IUISettings6*, Guid*, void**, int>)(lpVtbl[0]))((IUISettings6*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IUISettings6*, uint>)(lpVtbl[1]))((IUISettings6*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IUISettings6*, uint>)(lpVtbl[2]))((IUISettings6*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IUISettings6*, uint*, Guid**, int>)(lpVtbl[3]))((IUISettings6*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IUISettings6*, HSTRING*, int>)(lpVtbl[4]))((IUISettings6*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IUISettings6*, TrustLevel*, int>)(lpVtbl[5]))((IUISettings6*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IUISettings6.xml' path='doc/member[@name="IUISettings6.add_AnimationsEnabledChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT add_AnimationsEnabledChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CViewManagement__CUISettings_Windows__CUI__CViewManagement__CUISettingsAnimationsEnabledChangedEventArgs_t *")] ITypedEventHandler<Pointer<IUISettings>, Pointer<IUISettingsAnimationsEnabledChangedEventArgs>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IUISettings6*, ITypedEventHandler<Pointer<IUISettings>, Pointer<IUISettingsAnimationsEnabledChangedEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[6]))((IUISettings6*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IUISettings6.xml' path='doc/member[@name="IUISettings6.remove_AnimationsEnabledChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT remove_AnimationsEnabledChanged(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IUISettings6*, EventRegistrationToken, int>)(lpVtbl[7]))((IUISettings6*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='IUISettings6.xml' path='doc/member[@name="IUISettings6.add_MessageDurationChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT add_MessageDurationChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CViewManagement__CUISettings_Windows__CUI__CViewManagement__CUISettingsMessageDurationChangedEventArgs_t *")] ITypedEventHandler<Pointer<IUISettings>, Pointer<IUISettingsMessageDurationChangedEventArgs>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IUISettings6*, ITypedEventHandler<Pointer<IUISettings>, Pointer<IUISettingsMessageDurationChangedEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[8]))((IUISettings6*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IUISettings6.xml' path='doc/member[@name="IUISettings6.remove_MessageDurationChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT remove_MessageDurationChanged(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IUISettings6*, EventRegistrationToken, int>)(lpVtbl[9]))((IUISettings6*)Unsafe.AsPointer(ref this), token);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT add_AnimationsEnabledChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CViewManagement__CUISettings_Windows__CUI__CViewManagement__CUISettingsAnimationsEnabledChangedEventArgs_t *")] ITypedEventHandler<Pointer<IUISettings>, Pointer<IUISettingsAnimationsEnabledChangedEventArgs>>* handler, EventRegistrationToken* token);

        [VtblIndex(7)]
        HRESULT remove_AnimationsEnabledChanged(EventRegistrationToken token);

        [VtblIndex(8)]
        HRESULT add_MessageDurationChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CViewManagement__CUISettings_Windows__CUI__CViewManagement__CUISettingsMessageDurationChangedEventArgs_t *")] ITypedEventHandler<Pointer<IUISettings>, Pointer<IUISettingsMessageDurationChangedEventArgs>>* handler, EventRegistrationToken* token);

        [VtblIndex(9)]
        HRESULT remove_MessageDurationChanged(EventRegistrationToken token);
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CViewManagement__CUISettings_Windows__CUI__CViewManagement__CUISettingsAnimationsEnabledChangedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IUISettings>, Pointer<IUISettingsAnimationsEnabledChangedEventArgs>>*, EventRegistrationToken*, int> add_AnimationsEnabledChanged;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_AnimationsEnabledChanged;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CViewManagement__CUISettings_Windows__CUI__CViewManagement__CUISettingsMessageDurationChangedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IUISettings>, Pointer<IUISettingsMessageDurationChangedEventArgs>>*, EventRegistrationToken*, int> add_MessageDurationChanged;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_MessageDurationChanged;
    }
}
