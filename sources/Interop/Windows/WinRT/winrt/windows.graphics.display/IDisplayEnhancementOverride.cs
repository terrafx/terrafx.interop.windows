// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.graphics.display.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IDisplayEnhancementOverride.xml' path='doc/member[@name="IDisplayEnhancementOverride"]/*' />
[Guid("429594CF-D97A-4B02-A428-5C4292F7F522")]
[NativeTypeName("struct IDisplayEnhancementOverride : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IDisplayEnhancementOverride : IDisplayEnhancementOverride.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDisplayEnhancementOverride));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IDisplayEnhancementOverride*, Guid*, void**, int>)(lpVtbl[0]))((IDisplayEnhancementOverride*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IDisplayEnhancementOverride*, uint>)(lpVtbl[1]))((IDisplayEnhancementOverride*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IDisplayEnhancementOverride*, uint>)(lpVtbl[2]))((IDisplayEnhancementOverride*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IDisplayEnhancementOverride*, uint*, Guid**, int>)(lpVtbl[3]))((IDisplayEnhancementOverride*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IDisplayEnhancementOverride*, HSTRING*, int>)(lpVtbl[4]))((IDisplayEnhancementOverride*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IDisplayEnhancementOverride*, TrustLevel*, int>)(lpVtbl[5]))((IDisplayEnhancementOverride*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IDisplayEnhancementOverride.xml' path='doc/member[@name="IDisplayEnhancementOverride.get_ColorOverrideSettings"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_ColorOverrideSettings([NativeTypeName("ABI::Windows::Graphics::Display::IColorOverrideSettings **")] IColorOverrideSettings** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IDisplayEnhancementOverride*, IColorOverrideSettings**, int>)(lpVtbl[6]))((IDisplayEnhancementOverride*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IDisplayEnhancementOverride.xml' path='doc/member[@name="IDisplayEnhancementOverride.put_ColorOverrideSettings"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_ColorOverrideSettings([NativeTypeName("ABI::Windows::Graphics::Display::IColorOverrideSettings *")] IColorOverrideSettings* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IDisplayEnhancementOverride*, IColorOverrideSettings*, int>)(lpVtbl[7]))((IDisplayEnhancementOverride*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IDisplayEnhancementOverride.xml' path='doc/member[@name="IDisplayEnhancementOverride.get_BrightnessOverrideSettings"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_BrightnessOverrideSettings([NativeTypeName("ABI::Windows::Graphics::Display::IBrightnessOverrideSettings **")] IBrightnessOverrideSettings** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IDisplayEnhancementOverride*, IBrightnessOverrideSettings**, int>)(lpVtbl[8]))((IDisplayEnhancementOverride*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IDisplayEnhancementOverride.xml' path='doc/member[@name="IDisplayEnhancementOverride.put_BrightnessOverrideSettings"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_BrightnessOverrideSettings([NativeTypeName("ABI::Windows::Graphics::Display::IBrightnessOverrideSettings *")] IBrightnessOverrideSettings* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IDisplayEnhancementOverride*, IBrightnessOverrideSettings*, int>)(lpVtbl[9]))((IDisplayEnhancementOverride*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IDisplayEnhancementOverride.xml' path='doc/member[@name="IDisplayEnhancementOverride.get_CanOverride"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_CanOverride([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IDisplayEnhancementOverride*, byte*, int>)(lpVtbl[10]))((IDisplayEnhancementOverride*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IDisplayEnhancementOverride.xml' path='doc/member[@name="IDisplayEnhancementOverride.get_IsOverrideActive"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_IsOverrideActive([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IDisplayEnhancementOverride*, byte*, int>)(lpVtbl[11]))((IDisplayEnhancementOverride*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IDisplayEnhancementOverride.xml' path='doc/member[@name="IDisplayEnhancementOverride.GetCurrentDisplayEnhancementOverrideCapabilities"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT GetCurrentDisplayEnhancementOverrideCapabilities([NativeTypeName("ABI::Windows::Graphics::Display::IDisplayEnhancementOverrideCapabilities **")] IDisplayEnhancementOverrideCapabilities** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IDisplayEnhancementOverride*, IDisplayEnhancementOverrideCapabilities**, int>)(lpVtbl[12]))((IDisplayEnhancementOverride*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IDisplayEnhancementOverride.xml' path='doc/member[@name="IDisplayEnhancementOverride.RequestOverride"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT RequestOverride()
    {
        return ((delegate* unmanaged[MemberFunction]<IDisplayEnhancementOverride*, int>)(lpVtbl[13]))((IDisplayEnhancementOverride*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDisplayEnhancementOverride.xml' path='doc/member[@name="IDisplayEnhancementOverride.StopOverride"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT StopOverride()
    {
        return ((delegate* unmanaged[MemberFunction]<IDisplayEnhancementOverride*, int>)(lpVtbl[14]))((IDisplayEnhancementOverride*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDisplayEnhancementOverride.xml' path='doc/member[@name="IDisplayEnhancementOverride.add_CanOverrideChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT add_CanOverrideChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CGraphics__CDisplay__CDisplayEnhancementOverride_IInspectable_t *")] ITypedEventHandler<Pointer<IDisplayEnhancementOverride>, Pointer<IInspectable>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IDisplayEnhancementOverride*, ITypedEventHandler<Pointer<IDisplayEnhancementOverride>, Pointer<IInspectable>>*, EventRegistrationToken*, int>)(lpVtbl[15]))((IDisplayEnhancementOverride*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IDisplayEnhancementOverride.xml' path='doc/member[@name="IDisplayEnhancementOverride.remove_CanOverrideChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT remove_CanOverrideChanged(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IDisplayEnhancementOverride*, EventRegistrationToken, int>)(lpVtbl[16]))((IDisplayEnhancementOverride*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='IDisplayEnhancementOverride.xml' path='doc/member[@name="IDisplayEnhancementOverride.add_IsOverrideActiveChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT add_IsOverrideActiveChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CGraphics__CDisplay__CDisplayEnhancementOverride_IInspectable_t *")] ITypedEventHandler<Pointer<IDisplayEnhancementOverride>, Pointer<IInspectable>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IDisplayEnhancementOverride*, ITypedEventHandler<Pointer<IDisplayEnhancementOverride>, Pointer<IInspectable>>*, EventRegistrationToken*, int>)(lpVtbl[17]))((IDisplayEnhancementOverride*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IDisplayEnhancementOverride.xml' path='doc/member[@name="IDisplayEnhancementOverride.remove_IsOverrideActiveChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT remove_IsOverrideActiveChanged(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IDisplayEnhancementOverride*, EventRegistrationToken, int>)(lpVtbl[18]))((IDisplayEnhancementOverride*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='IDisplayEnhancementOverride.xml' path='doc/member[@name="IDisplayEnhancementOverride.add_DisplayEnhancementOverrideCapabilitiesChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT add_DisplayEnhancementOverrideCapabilitiesChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CGraphics__CDisplay__CDisplayEnhancementOverride_Windows__CGraphics__CDisplay__CDisplayEnhancementOverrideCapabilitiesChangedEventArgs_t *")] ITypedEventHandler<Pointer<IDisplayEnhancementOverride>, Pointer<IDisplayEnhancementOverrideCapabilitiesChangedEventArgs>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IDisplayEnhancementOverride*, ITypedEventHandler<Pointer<IDisplayEnhancementOverride>, Pointer<IDisplayEnhancementOverrideCapabilitiesChangedEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[19]))((IDisplayEnhancementOverride*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IDisplayEnhancementOverride.xml' path='doc/member[@name="IDisplayEnhancementOverride.remove_DisplayEnhancementOverrideCapabilitiesChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT remove_DisplayEnhancementOverrideCapabilitiesChanged(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IDisplayEnhancementOverride*, EventRegistrationToken, int>)(lpVtbl[20]))((IDisplayEnhancementOverride*)Unsafe.AsPointer(ref this), token);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_ColorOverrideSettings([NativeTypeName("ABI::Windows::Graphics::Display::IColorOverrideSettings **")] IColorOverrideSettings** value);

        [VtblIndex(7)]
        HRESULT put_ColorOverrideSettings([NativeTypeName("ABI::Windows::Graphics::Display::IColorOverrideSettings *")] IColorOverrideSettings* value);

        [VtblIndex(8)]
        HRESULT get_BrightnessOverrideSettings([NativeTypeName("ABI::Windows::Graphics::Display::IBrightnessOverrideSettings **")] IBrightnessOverrideSettings** value);

        [VtblIndex(9)]
        HRESULT put_BrightnessOverrideSettings([NativeTypeName("ABI::Windows::Graphics::Display::IBrightnessOverrideSettings *")] IBrightnessOverrideSettings* value);

        [VtblIndex(10)]
        HRESULT get_CanOverride([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(11)]
        HRESULT get_IsOverrideActive([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(12)]
        HRESULT GetCurrentDisplayEnhancementOverrideCapabilities([NativeTypeName("ABI::Windows::Graphics::Display::IDisplayEnhancementOverrideCapabilities **")] IDisplayEnhancementOverrideCapabilities** value);

        [VtblIndex(13)]
        HRESULT RequestOverride();

        [VtblIndex(14)]
        HRESULT StopOverride();

        [VtblIndex(15)]
        HRESULT add_CanOverrideChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CGraphics__CDisplay__CDisplayEnhancementOverride_IInspectable_t *")] ITypedEventHandler<Pointer<IDisplayEnhancementOverride>, Pointer<IInspectable>>* handler, EventRegistrationToken* token);

        [VtblIndex(16)]
        HRESULT remove_CanOverrideChanged(EventRegistrationToken token);

        [VtblIndex(17)]
        HRESULT add_IsOverrideActiveChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CGraphics__CDisplay__CDisplayEnhancementOverride_IInspectable_t *")] ITypedEventHandler<Pointer<IDisplayEnhancementOverride>, Pointer<IInspectable>>* handler, EventRegistrationToken* token);

        [VtblIndex(18)]
        HRESULT remove_IsOverrideActiveChanged(EventRegistrationToken token);

        [VtblIndex(19)]
        HRESULT add_DisplayEnhancementOverrideCapabilitiesChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CGraphics__CDisplay__CDisplayEnhancementOverride_Windows__CGraphics__CDisplay__CDisplayEnhancementOverrideCapabilitiesChangedEventArgs_t *")] ITypedEventHandler<Pointer<IDisplayEnhancementOverride>, Pointer<IDisplayEnhancementOverrideCapabilitiesChangedEventArgs>>* handler, EventRegistrationToken* token);

        [VtblIndex(20)]
        HRESULT remove_DisplayEnhancementOverrideCapabilitiesChanged(EventRegistrationToken token);
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

        [NativeTypeName("HRESULT (ABI::Windows::Graphics::Display::IColorOverrideSettings **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IColorOverrideSettings**, int> get_ColorOverrideSettings;

        [NativeTypeName("HRESULT (ABI::Windows::Graphics::Display::IColorOverrideSettings *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IColorOverrideSettings*, int> put_ColorOverrideSettings;

        [NativeTypeName("HRESULT (ABI::Windows::Graphics::Display::IBrightnessOverrideSettings **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IBrightnessOverrideSettings**, int> get_BrightnessOverrideSettings;

        [NativeTypeName("HRESULT (ABI::Windows::Graphics::Display::IBrightnessOverrideSettings *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IBrightnessOverrideSettings*, int> put_BrightnessOverrideSettings;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_CanOverride;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_IsOverrideActive;

        [NativeTypeName("HRESULT (ABI::Windows::Graphics::Display::IDisplayEnhancementOverrideCapabilities **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IDisplayEnhancementOverrideCapabilities**, int> GetCurrentDisplayEnhancementOverrideCapabilities;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> RequestOverride;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> StopOverride;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CGraphics__CDisplay__CDisplayEnhancementOverride_IInspectable_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IDisplayEnhancementOverride>, Pointer<IInspectable>>*, EventRegistrationToken*, int> add_CanOverrideChanged;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_CanOverrideChanged;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CGraphics__CDisplay__CDisplayEnhancementOverride_IInspectable_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IDisplayEnhancementOverride>, Pointer<IInspectable>>*, EventRegistrationToken*, int> add_IsOverrideActiveChanged;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_IsOverrideActiveChanged;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CGraphics__CDisplay__CDisplayEnhancementOverride_Windows__CGraphics__CDisplay__CDisplayEnhancementOverrideCapabilitiesChangedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IDisplayEnhancementOverride>, Pointer<IDisplayEnhancementOverrideCapabilitiesChangedEventArgs>>*, EventRegistrationToken*, int> add_DisplayEnhancementOverrideCapabilitiesChanged;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_DisplayEnhancementOverrideCapabilitiesChanged;
    }
}
