// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.viewmanagement.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IUISettings3.xml' path='doc/member[@name="IUISettings3"]/*' />
[Guid("03021BE4-5254-4781-8194-5168F7D06D7B")]
[NativeTypeName("struct IUISettings3 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IUISettings3 : IUISettings3.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IUISettings3));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IUISettings3*, Guid*, void**, int>)(lpVtbl[0]))((IUISettings3*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IUISettings3*, uint>)(lpVtbl[1]))((IUISettings3*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IUISettings3*, uint>)(lpVtbl[2]))((IUISettings3*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IUISettings3*, uint*, Guid**, int>)(lpVtbl[3]))((IUISettings3*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IUISettings3*, HSTRING*, int>)(lpVtbl[4]))((IUISettings3*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IUISettings3*, TrustLevel*, int>)(lpVtbl[5]))((IUISettings3*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IUISettings3.xml' path='doc/member[@name="IUISettings3.GetColorValue"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetColorValue([NativeTypeName("ABI::Windows::UI::ViewManagement::UIColorType")] UIColorType desiredColor, [NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IUISettings3*, UIColorType, Color*, int>)(lpVtbl[6]))((IUISettings3*)Unsafe.AsPointer(ref this), desiredColor, value);
    }

    /// <include file='IUISettings3.xml' path='doc/member[@name="IUISettings3.add_ColorValuesChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT add_ColorValuesChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CViewManagement__CUISettings_IInspectable_t *")] ITypedEventHandler<Pointer<IUISettings>, Pointer<IInspectable>>* handler, EventRegistrationToken* cookie)
    {
        return ((delegate* unmanaged[MemberFunction]<IUISettings3*, ITypedEventHandler<Pointer<IUISettings>, Pointer<IInspectable>>*, EventRegistrationToken*, int>)(lpVtbl[7]))((IUISettings3*)Unsafe.AsPointer(ref this), handler, cookie);
    }

    /// <include file='IUISettings3.xml' path='doc/member[@name="IUISettings3.remove_ColorValuesChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT remove_ColorValuesChanged(EventRegistrationToken cookie)
    {
        return ((delegate* unmanaged[MemberFunction]<IUISettings3*, EventRegistrationToken, int>)(lpVtbl[8]))((IUISettings3*)Unsafe.AsPointer(ref this), cookie);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT GetColorValue([NativeTypeName("ABI::Windows::UI::ViewManagement::UIColorType")] UIColorType desiredColor, [NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(7)]
        HRESULT add_ColorValuesChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CViewManagement__CUISettings_IInspectable_t *")] ITypedEventHandler<Pointer<IUISettings>, Pointer<IInspectable>>* handler, EventRegistrationToken* cookie);

        [VtblIndex(8)]
        HRESULT remove_ColorValuesChanged(EventRegistrationToken cookie);
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

        [NativeTypeName("HRESULT (ABI::Windows::UI::ViewManagement::UIColorType, ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, UIColorType, Color*, int> GetColorValue;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CViewManagement__CUISettings_IInspectable_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IUISettings>, Pointer<IInspectable>>*, EventRegistrationToken*, int> add_ColorValuesChanged;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_ColorValuesChanged;
    }
}
