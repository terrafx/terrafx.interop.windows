// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.graphics.display.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IDisplayInformation.xml' path='doc/member[@name="IDisplayInformation"]/*' />
[Guid("BED112AE-ADC3-4DC9-AE65-851F4D7D4799")]
[NativeTypeName("struct IDisplayInformation : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IDisplayInformation : IDisplayInformation.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDisplayInformation));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IDisplayInformation*, Guid*, void**, int>)(lpVtbl[0]))((IDisplayInformation*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IDisplayInformation*, uint>)(lpVtbl[1]))((IDisplayInformation*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IDisplayInformation*, uint>)(lpVtbl[2]))((IDisplayInformation*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IDisplayInformation*, uint*, Guid**, int>)(lpVtbl[3]))((IDisplayInformation*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IDisplayInformation*, HSTRING*, int>)(lpVtbl[4]))((IDisplayInformation*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IDisplayInformation*, TrustLevel*, int>)(lpVtbl[5]))((IDisplayInformation*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IDisplayInformation.xml' path='doc/member[@name="IDisplayInformation.get_CurrentOrientation"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_CurrentOrientation([NativeTypeName("ABI::Windows::Graphics::Display::DisplayOrientations *")] DisplayOrientations* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IDisplayInformation*, DisplayOrientations*, int>)(lpVtbl[6]))((IDisplayInformation*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IDisplayInformation.xml' path='doc/member[@name="IDisplayInformation.get_NativeOrientation"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_NativeOrientation([NativeTypeName("ABI::Windows::Graphics::Display::DisplayOrientations *")] DisplayOrientations* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IDisplayInformation*, DisplayOrientations*, int>)(lpVtbl[7]))((IDisplayInformation*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IDisplayInformation.xml' path='doc/member[@name="IDisplayInformation.add_OrientationChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT add_OrientationChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CGraphics__CDisplay__CDisplayInformation_IInspectable_t *")] ITypedEventHandler<Pointer<IDisplayInformation>, Pointer<IInspectable>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IDisplayInformation*, ITypedEventHandler<Pointer<IDisplayInformation>, Pointer<IInspectable>>*, EventRegistrationToken*, int>)(lpVtbl[8]))((IDisplayInformation*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IDisplayInformation.xml' path='doc/member[@name="IDisplayInformation.remove_OrientationChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT remove_OrientationChanged(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IDisplayInformation*, EventRegistrationToken, int>)(lpVtbl[9]))((IDisplayInformation*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='IDisplayInformation.xml' path='doc/member[@name="IDisplayInformation.get_ResolutionScale"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_ResolutionScale([NativeTypeName("ABI::Windows::Graphics::Display::ResolutionScale *")] ResolutionScale* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IDisplayInformation*, ResolutionScale*, int>)(lpVtbl[10]))((IDisplayInformation*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IDisplayInformation.xml' path='doc/member[@name="IDisplayInformation.get_LogicalDpi"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_LogicalDpi(float* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IDisplayInformation*, float*, int>)(lpVtbl[11]))((IDisplayInformation*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IDisplayInformation.xml' path='doc/member[@name="IDisplayInformation.get_RawDpiX"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_RawDpiX(float* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IDisplayInformation*, float*, int>)(lpVtbl[12]))((IDisplayInformation*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IDisplayInformation.xml' path='doc/member[@name="IDisplayInformation.get_RawDpiY"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_RawDpiY(float* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IDisplayInformation*, float*, int>)(lpVtbl[13]))((IDisplayInformation*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IDisplayInformation.xml' path='doc/member[@name="IDisplayInformation.add_DpiChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT add_DpiChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CGraphics__CDisplay__CDisplayInformation_IInspectable_t *")] ITypedEventHandler<Pointer<IDisplayInformation>, Pointer<IInspectable>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IDisplayInformation*, ITypedEventHandler<Pointer<IDisplayInformation>, Pointer<IInspectable>>*, EventRegistrationToken*, int>)(lpVtbl[14]))((IDisplayInformation*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IDisplayInformation.xml' path='doc/member[@name="IDisplayInformation.remove_DpiChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT remove_DpiChanged(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IDisplayInformation*, EventRegistrationToken, int>)(lpVtbl[15]))((IDisplayInformation*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='IDisplayInformation.xml' path='doc/member[@name="IDisplayInformation.get_StereoEnabled"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_StereoEnabled([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IDisplayInformation*, byte*, int>)(lpVtbl[16]))((IDisplayInformation*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IDisplayInformation.xml' path='doc/member[@name="IDisplayInformation.add_StereoEnabledChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT add_StereoEnabledChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CGraphics__CDisplay__CDisplayInformation_IInspectable_t *")] ITypedEventHandler<Pointer<IDisplayInformation>, Pointer<IInspectable>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IDisplayInformation*, ITypedEventHandler<Pointer<IDisplayInformation>, Pointer<IInspectable>>*, EventRegistrationToken*, int>)(lpVtbl[17]))((IDisplayInformation*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IDisplayInformation.xml' path='doc/member[@name="IDisplayInformation.remove_StereoEnabledChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT remove_StereoEnabledChanged(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IDisplayInformation*, EventRegistrationToken, int>)(lpVtbl[18]))((IDisplayInformation*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='IDisplayInformation.xml' path='doc/member[@name="IDisplayInformation.GetColorProfileAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT GetColorProfileAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStreams__CIRandomAccessStream_t **")] IAsyncOperation<Pointer<IRandomAccessStream>>** asyncInfo)
    {
        return ((delegate* unmanaged[MemberFunction]<IDisplayInformation*, IAsyncOperation<Pointer<IRandomAccessStream>>**, int>)(lpVtbl[19]))((IDisplayInformation*)Unsafe.AsPointer(ref this), asyncInfo);
    }

    /// <include file='IDisplayInformation.xml' path='doc/member[@name="IDisplayInformation.add_ColorProfileChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT add_ColorProfileChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CGraphics__CDisplay__CDisplayInformation_IInspectable_t *")] ITypedEventHandler<Pointer<IDisplayInformation>, Pointer<IInspectable>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IDisplayInformation*, ITypedEventHandler<Pointer<IDisplayInformation>, Pointer<IInspectable>>*, EventRegistrationToken*, int>)(lpVtbl[20]))((IDisplayInformation*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IDisplayInformation.xml' path='doc/member[@name="IDisplayInformation.remove_ColorProfileChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT remove_ColorProfileChanged(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IDisplayInformation*, EventRegistrationToken, int>)(lpVtbl[21]))((IDisplayInformation*)Unsafe.AsPointer(ref this), token);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_CurrentOrientation([NativeTypeName("ABI::Windows::Graphics::Display::DisplayOrientations *")] DisplayOrientations* value);

        [VtblIndex(7)]
        HRESULT get_NativeOrientation([NativeTypeName("ABI::Windows::Graphics::Display::DisplayOrientations *")] DisplayOrientations* value);

        [VtblIndex(8)]
        HRESULT add_OrientationChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CGraphics__CDisplay__CDisplayInformation_IInspectable_t *")] ITypedEventHandler<Pointer<IDisplayInformation>, Pointer<IInspectable>>* handler, EventRegistrationToken* token);

        [VtblIndex(9)]
        HRESULT remove_OrientationChanged(EventRegistrationToken token);

        [VtblIndex(10)]
        HRESULT get_ResolutionScale([NativeTypeName("ABI::Windows::Graphics::Display::ResolutionScale *")] ResolutionScale* value);

        [VtblIndex(11)]
        HRESULT get_LogicalDpi(float* value);

        [VtblIndex(12)]
        HRESULT get_RawDpiX(float* value);

        [VtblIndex(13)]
        HRESULT get_RawDpiY(float* value);

        [VtblIndex(14)]
        HRESULT add_DpiChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CGraphics__CDisplay__CDisplayInformation_IInspectable_t *")] ITypedEventHandler<Pointer<IDisplayInformation>, Pointer<IInspectable>>* handler, EventRegistrationToken* token);

        [VtblIndex(15)]
        HRESULT remove_DpiChanged(EventRegistrationToken token);

        [VtblIndex(16)]
        HRESULT get_StereoEnabled([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(17)]
        HRESULT add_StereoEnabledChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CGraphics__CDisplay__CDisplayInformation_IInspectable_t *")] ITypedEventHandler<Pointer<IDisplayInformation>, Pointer<IInspectable>>* handler, EventRegistrationToken* token);

        [VtblIndex(18)]
        HRESULT remove_StereoEnabledChanged(EventRegistrationToken token);

        [VtblIndex(19)]
        HRESULT GetColorProfileAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStreams__CIRandomAccessStream_t **")] IAsyncOperation<Pointer<IRandomAccessStream>>** asyncInfo);

        [VtblIndex(20)]
        HRESULT add_ColorProfileChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CGraphics__CDisplay__CDisplayInformation_IInspectable_t *")] ITypedEventHandler<Pointer<IDisplayInformation>, Pointer<IInspectable>>* handler, EventRegistrationToken* token);

        [VtblIndex(21)]
        HRESULT remove_ColorProfileChanged(EventRegistrationToken token);
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

        [NativeTypeName("HRESULT (ABI::Windows::Graphics::Display::DisplayOrientations *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, DisplayOrientations*, int> get_CurrentOrientation;

        [NativeTypeName("HRESULT (ABI::Windows::Graphics::Display::DisplayOrientations *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, DisplayOrientations*, int> get_NativeOrientation;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CGraphics__CDisplay__CDisplayInformation_IInspectable_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IDisplayInformation>, Pointer<IInspectable>>*, EventRegistrationToken*, int> add_OrientationChanged;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_OrientationChanged;

        [NativeTypeName("HRESULT (ABI::Windows::Graphics::Display::ResolutionScale *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ResolutionScale*, int> get_ResolutionScale;

        [NativeTypeName("HRESULT (FLOAT *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, float*, int> get_LogicalDpi;

        [NativeTypeName("HRESULT (FLOAT *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, float*, int> get_RawDpiX;

        [NativeTypeName("HRESULT (FLOAT *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, float*, int> get_RawDpiY;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CGraphics__CDisplay__CDisplayInformation_IInspectable_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IDisplayInformation>, Pointer<IInspectable>>*, EventRegistrationToken*, int> add_DpiChanged;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_DpiChanged;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_StereoEnabled;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CGraphics__CDisplay__CDisplayInformation_IInspectable_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IDisplayInformation>, Pointer<IInspectable>>*, EventRegistrationToken*, int> add_StereoEnabledChanged;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_StereoEnabledChanged;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStreams__CIRandomAccessStream_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAsyncOperation<Pointer<IRandomAccessStream>>**, int> GetColorProfileAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CGraphics__CDisplay__CDisplayInformation_IInspectable_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IDisplayInformation>, Pointer<IInspectable>>*, EventRegistrationToken*, int> add_ColorProfileChanged;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_ColorProfileChanged;
    }
}
