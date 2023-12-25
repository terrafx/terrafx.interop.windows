// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.graphics.display.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IBrightnessOverride.xml' path='doc/member[@name="IBrightnessOverride"]/*' />
[Guid("96C9621A-C143-4392-BEDD-4A7E9574C8FD")]
[NativeTypeName("struct IBrightnessOverride : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IBrightnessOverride : IBrightnessOverride.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IBrightnessOverride));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IBrightnessOverride*, Guid*, void**, int>)(lpVtbl[0]))((IBrightnessOverride*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IBrightnessOverride*, uint>)(lpVtbl[1]))((IBrightnessOverride*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IBrightnessOverride*, uint>)(lpVtbl[2]))((IBrightnessOverride*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IBrightnessOverride*, uint*, Guid**, int>)(lpVtbl[3]))((IBrightnessOverride*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IBrightnessOverride*, HSTRING*, int>)(lpVtbl[4]))((IBrightnessOverride*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IBrightnessOverride*, TrustLevel*, int>)(lpVtbl[5]))((IBrightnessOverride*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IBrightnessOverride.xml' path='doc/member[@name="IBrightnessOverride.get_IsSupported"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_IsSupported([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBrightnessOverride*, byte*, int>)(lpVtbl[6]))((IBrightnessOverride*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBrightnessOverride.xml' path='doc/member[@name="IBrightnessOverride.get_IsOverrideActive"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_IsOverrideActive([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBrightnessOverride*, byte*, int>)(lpVtbl[7]))((IBrightnessOverride*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBrightnessOverride.xml' path='doc/member[@name="IBrightnessOverride.get_BrightnessLevel"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_BrightnessLevel(double* level)
    {
        return ((delegate* unmanaged[MemberFunction]<IBrightnessOverride*, double*, int>)(lpVtbl[8]))((IBrightnessOverride*)Unsafe.AsPointer(ref this), level);
    }

    /// <include file='IBrightnessOverride.xml' path='doc/member[@name="IBrightnessOverride.SetBrightnessLevel"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT SetBrightnessLevel(double brightnessLevel, [NativeTypeName("ABI::Windows::Graphics::Display::DisplayBrightnessOverrideOptions")] DisplayBrightnessOverrideOptions options)
    {
        return ((delegate* unmanaged[MemberFunction]<IBrightnessOverride*, double, DisplayBrightnessOverrideOptions, int>)(lpVtbl[9]))((IBrightnessOverride*)Unsafe.AsPointer(ref this), brightnessLevel, options);
    }

    /// <include file='IBrightnessOverride.xml' path='doc/member[@name="IBrightnessOverride.SetBrightnessScenario"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT SetBrightnessScenario([NativeTypeName("ABI::Windows::Graphics::Display::DisplayBrightnessScenario")] DisplayBrightnessScenario scenario, [NativeTypeName("ABI::Windows::Graphics::Display::DisplayBrightnessOverrideOptions")] DisplayBrightnessOverrideOptions options)
    {
        return ((delegate* unmanaged[MemberFunction]<IBrightnessOverride*, DisplayBrightnessScenario, DisplayBrightnessOverrideOptions, int>)(lpVtbl[10]))((IBrightnessOverride*)Unsafe.AsPointer(ref this), scenario, options);
    }

    /// <include file='IBrightnessOverride.xml' path='doc/member[@name="IBrightnessOverride.GetLevelForScenario"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT GetLevelForScenario([NativeTypeName("ABI::Windows::Graphics::Display::DisplayBrightnessScenario")] DisplayBrightnessScenario scenario, double* brightnessLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IBrightnessOverride*, DisplayBrightnessScenario, double*, int>)(lpVtbl[11]))((IBrightnessOverride*)Unsafe.AsPointer(ref this), scenario, brightnessLevel);
    }

    /// <include file='IBrightnessOverride.xml' path='doc/member[@name="IBrightnessOverride.StartOverride"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT StartOverride()
    {
        return ((delegate* unmanaged[MemberFunction]<IBrightnessOverride*, int>)(lpVtbl[12]))((IBrightnessOverride*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IBrightnessOverride.xml' path='doc/member[@name="IBrightnessOverride.StopOverride"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT StopOverride()
    {
        return ((delegate* unmanaged[MemberFunction]<IBrightnessOverride*, int>)(lpVtbl[13]))((IBrightnessOverride*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IBrightnessOverride.xml' path='doc/member[@name="IBrightnessOverride.add_IsSupportedChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT add_IsSupportedChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CGraphics__CDisplay__CBrightnessOverride_IInspectable_t *")] ITypedEventHandler<IntPtr, IntPtr>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IBrightnessOverride*, ITypedEventHandler<IntPtr, IntPtr>*, EventRegistrationToken*, int>)(lpVtbl[14]))((IBrightnessOverride*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IBrightnessOverride.xml' path='doc/member[@name="IBrightnessOverride.remove_IsSupportedChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT remove_IsSupportedChanged(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IBrightnessOverride*, EventRegistrationToken, int>)(lpVtbl[15]))((IBrightnessOverride*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='IBrightnessOverride.xml' path='doc/member[@name="IBrightnessOverride.add_IsOverrideActiveChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT add_IsOverrideActiveChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CGraphics__CDisplay__CBrightnessOverride_IInspectable_t *")] ITypedEventHandler<IntPtr, IntPtr>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IBrightnessOverride*, ITypedEventHandler<IntPtr, IntPtr>*, EventRegistrationToken*, int>)(lpVtbl[16]))((IBrightnessOverride*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IBrightnessOverride.xml' path='doc/member[@name="IBrightnessOverride.remove_IsOverrideActiveChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT remove_IsOverrideActiveChanged(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IBrightnessOverride*, EventRegistrationToken, int>)(lpVtbl[17]))((IBrightnessOverride*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='IBrightnessOverride.xml' path='doc/member[@name="IBrightnessOverride.add_BrightnessLevelChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT add_BrightnessLevelChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CGraphics__CDisplay__CBrightnessOverride_IInspectable_t *")] ITypedEventHandler<IntPtr, IntPtr>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IBrightnessOverride*, ITypedEventHandler<IntPtr, IntPtr>*, EventRegistrationToken*, int>)(lpVtbl[18]))((IBrightnessOverride*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IBrightnessOverride.xml' path='doc/member[@name="IBrightnessOverride.remove_BrightnessLevelChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT remove_BrightnessLevelChanged(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IBrightnessOverride*, EventRegistrationToken, int>)(lpVtbl[19]))((IBrightnessOverride*)Unsafe.AsPointer(ref this), token);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_IsSupported([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(7)]
        HRESULT get_IsOverrideActive([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(8)]
        HRESULT get_BrightnessLevel(double* level);

        [VtblIndex(9)]
        HRESULT SetBrightnessLevel(double brightnessLevel, [NativeTypeName("ABI::Windows::Graphics::Display::DisplayBrightnessOverrideOptions")] DisplayBrightnessOverrideOptions options);

        [VtblIndex(10)]
        HRESULT SetBrightnessScenario([NativeTypeName("ABI::Windows::Graphics::Display::DisplayBrightnessScenario")] DisplayBrightnessScenario scenario, [NativeTypeName("ABI::Windows::Graphics::Display::DisplayBrightnessOverrideOptions")] DisplayBrightnessOverrideOptions options);

        [VtblIndex(11)]
        HRESULT GetLevelForScenario([NativeTypeName("ABI::Windows::Graphics::Display::DisplayBrightnessScenario")] DisplayBrightnessScenario scenario, double* brightnessLevel);

        [VtblIndex(12)]
        HRESULT StartOverride();

        [VtblIndex(13)]
        HRESULT StopOverride();

        [VtblIndex(14)]
        HRESULT add_IsSupportedChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CGraphics__CDisplay__CBrightnessOverride_IInspectable_t *")] ITypedEventHandler<IntPtr, IntPtr>* handler, EventRegistrationToken* token);

        [VtblIndex(15)]
        HRESULT remove_IsSupportedChanged(EventRegistrationToken token);

        [VtblIndex(16)]
        HRESULT add_IsOverrideActiveChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CGraphics__CDisplay__CBrightnessOverride_IInspectable_t *")] ITypedEventHandler<IntPtr, IntPtr>* handler, EventRegistrationToken* token);

        [VtblIndex(17)]
        HRESULT remove_IsOverrideActiveChanged(EventRegistrationToken token);

        [VtblIndex(18)]
        HRESULT add_BrightnessLevelChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CGraphics__CDisplay__CBrightnessOverride_IInspectable_t *")] ITypedEventHandler<IntPtr, IntPtr>* handler, EventRegistrationToken* token);

        [VtblIndex(19)]
        HRESULT remove_BrightnessLevelChanged(EventRegistrationToken token);
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

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_IsSupported;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_IsOverrideActive;

        [NativeTypeName("HRESULT (DOUBLE *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, double*, int> get_BrightnessLevel;

        [NativeTypeName("HRESULT (DOUBLE, ABI::Windows::Graphics::Display::DisplayBrightnessOverrideOptions) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, double, DisplayBrightnessOverrideOptions, int> SetBrightnessLevel;

        [NativeTypeName("HRESULT (ABI::Windows::Graphics::Display::DisplayBrightnessScenario, ABI::Windows::Graphics::Display::DisplayBrightnessOverrideOptions) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, DisplayBrightnessScenario, DisplayBrightnessOverrideOptions, int> SetBrightnessScenario;

        [NativeTypeName("HRESULT (ABI::Windows::Graphics::Display::DisplayBrightnessScenario, DOUBLE *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, DisplayBrightnessScenario, double*, int> GetLevelForScenario;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> StartOverride;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> StopOverride;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CGraphics__CDisplay__CBrightnessOverride_IInspectable_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<IntPtr, IntPtr>*, EventRegistrationToken*, int> add_IsSupportedChanged;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_IsSupportedChanged;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CGraphics__CDisplay__CBrightnessOverride_IInspectable_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<IntPtr, IntPtr>*, EventRegistrationToken*, int> add_IsOverrideActiveChanged;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_IsOverrideActiveChanged;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CGraphics__CDisplay__CBrightnessOverride_IInspectable_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<IntPtr, IntPtr>*, EventRegistrationToken*, int> add_BrightnessLevelChanged;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_BrightnessLevelChanged;
    }
}
