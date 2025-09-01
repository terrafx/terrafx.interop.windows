// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.viewmanagement.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IUIViewSettingsPreferredInteractionMode.xml' path='doc/member[@name="IUIViewSettingsPreferredInteractionMode"]/*' />
[Guid("426DE261-82EC-5F61-BAD4-19B2D0D3CF35")]
[NativeTypeName("struct IUIViewSettingsPreferredInteractionMode : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IUIViewSettingsPreferredInteractionMode : IUIViewSettingsPreferredInteractionMode.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IUIViewSettingsPreferredInteractionMode);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IUIViewSettingsPreferredInteractionMode*, Guid*, void**, int>)(lpVtbl[0]))((IUIViewSettingsPreferredInteractionMode*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IUIViewSettingsPreferredInteractionMode*, uint>)(lpVtbl[1]))((IUIViewSettingsPreferredInteractionMode*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IUIViewSettingsPreferredInteractionMode*, uint>)(lpVtbl[2]))((IUIViewSettingsPreferredInteractionMode*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IUIViewSettingsPreferredInteractionMode*, uint*, Guid**, int>)(lpVtbl[3]))((IUIViewSettingsPreferredInteractionMode*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IUIViewSettingsPreferredInteractionMode*, HSTRING*, int>)(lpVtbl[4]))((IUIViewSettingsPreferredInteractionMode*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IUIViewSettingsPreferredInteractionMode*, TrustLevel*, int>)(lpVtbl[5]))((IUIViewSettingsPreferredInteractionMode*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IUIViewSettingsPreferredInteractionMode.xml' path='doc/member[@name="IUIViewSettingsPreferredInteractionMode.GetPreferredInteractionMode"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetPreferredInteractionMode([NativeTypeName("UINT32")] uint supportedModesLength, [NativeTypeName("ABI::Windows::UI::ViewManagement::UserInteractionMode *")] UserInteractionMode* supportedModes, [NativeTypeName("ABI::Windows::UI::ViewManagement::UserInteractionMode *")] UserInteractionMode* result)
    {
        return ((delegate* unmanaged[MemberFunction]<IUIViewSettingsPreferredInteractionMode*, uint, UserInteractionMode*, UserInteractionMode*, int>)(lpVtbl[6]))((IUIViewSettingsPreferredInteractionMode*)Unsafe.AsPointer(ref this), supportedModesLength, supportedModes, result);
    }

    /// <include file='IUIViewSettingsPreferredInteractionMode.xml' path='doc/member[@name="IUIViewSettingsPreferredInteractionMode.add_PreferredInteractionModeChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT add_PreferredInteractionModeChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CViewManagement__CUIViewSettings_IInspectable_t *")] ITypedEventHandler<Pointer<IUIViewSettings>, Pointer<IInspectable>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IUIViewSettingsPreferredInteractionMode*, ITypedEventHandler<Pointer<IUIViewSettings>, Pointer<IInspectable>>*, EventRegistrationToken*, int>)(lpVtbl[7]))((IUIViewSettingsPreferredInteractionMode*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IUIViewSettingsPreferredInteractionMode.xml' path='doc/member[@name="IUIViewSettingsPreferredInteractionMode.remove_PreferredInteractionModeChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT remove_PreferredInteractionModeChanged(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IUIViewSettingsPreferredInteractionMode*, EventRegistrationToken, int>)(lpVtbl[8]))((IUIViewSettingsPreferredInteractionMode*)Unsafe.AsPointer(ref this), token);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT GetPreferredInteractionMode([NativeTypeName("UINT32")] uint supportedModesLength, [NativeTypeName("ABI::Windows::UI::ViewManagement::UserInteractionMode *")] UserInteractionMode* supportedModes, [NativeTypeName("ABI::Windows::UI::ViewManagement::UserInteractionMode *")] UserInteractionMode* result);

        [VtblIndex(7)]
        HRESULT add_PreferredInteractionModeChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CViewManagement__CUIViewSettings_IInspectable_t *")] ITypedEventHandler<Pointer<IUIViewSettings>, Pointer<IInspectable>>* handler, EventRegistrationToken* token);

        [VtblIndex(8)]
        HRESULT remove_PreferredInteractionModeChanged(EventRegistrationToken token);
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

        [NativeTypeName("HRESULT (UINT32, ABI::Windows::UI::ViewManagement::UserInteractionMode *, ABI::Windows::UI::ViewManagement::UserInteractionMode *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, UserInteractionMode*, UserInteractionMode*, int> GetPreferredInteractionMode;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CViewManagement__CUIViewSettings_IInspectable_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IUIViewSettings>, Pointer<IInspectable>>*, EventRegistrationToken*, int> add_PreferredInteractionModeChanged;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_PreferredInteractionModeChanged;
    }
}
