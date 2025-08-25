// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.graphics.display.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IDisplayPropertiesStatics.xml' path='doc/member[@name="IDisplayPropertiesStatics"]/*' />
[Guid("6937ED8D-30EA-4DED-8271-4553FF02F68A")]
[NativeTypeName("struct IDisplayPropertiesStatics : IInspectable")]
[NativeInheritance("IInspectable")]
[Obsolete("DisplayProperties may be altered or unavailable for releases after Windows Phone 8.1. Instead, use DisplayInformation.")]
public unsafe partial struct IDisplayPropertiesStatics : IDisplayPropertiesStatics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IDisplayPropertiesStatics);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IDisplayPropertiesStatics*, Guid*, void**, int>)(lpVtbl[0]))((IDisplayPropertiesStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IDisplayPropertiesStatics*, uint>)(lpVtbl[1]))((IDisplayPropertiesStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IDisplayPropertiesStatics*, uint>)(lpVtbl[2]))((IDisplayPropertiesStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IDisplayPropertiesStatics*, uint*, Guid**, int>)(lpVtbl[3]))((IDisplayPropertiesStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IDisplayPropertiesStatics*, HSTRING*, int>)(lpVtbl[4]))((IDisplayPropertiesStatics*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IDisplayPropertiesStatics*, TrustLevel*, int>)(lpVtbl[5]))((IDisplayPropertiesStatics*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IDisplayPropertiesStatics.xml' path='doc/member[@name="IDisplayPropertiesStatics.get_CurrentOrientation"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    [Obsolete("DisplayProperties may be altered or unavailable for releases after Windows Phone 8.1. Instead, use DisplayInformation.")]
    public HRESULT get_CurrentOrientation([NativeTypeName("ABI::Windows::Graphics::Display::DisplayOrientations *")] DisplayOrientations* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IDisplayPropertiesStatics*, DisplayOrientations*, int>)(lpVtbl[6]))((IDisplayPropertiesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IDisplayPropertiesStatics.xml' path='doc/member[@name="IDisplayPropertiesStatics.get_NativeOrientation"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    [Obsolete("DisplayProperties may be altered or unavailable for releases after Windows Phone 8.1. Instead, use DisplayInformation.")]
    public HRESULT get_NativeOrientation([NativeTypeName("ABI::Windows::Graphics::Display::DisplayOrientations *")] DisplayOrientations* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IDisplayPropertiesStatics*, DisplayOrientations*, int>)(lpVtbl[7]))((IDisplayPropertiesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IDisplayPropertiesStatics.xml' path='doc/member[@name="IDisplayPropertiesStatics.get_AutoRotationPreferences"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    [Obsolete("DisplayProperties may be altered or unavailable for releases after Windows Phone 8.1. Instead, use DisplayInformation.")]
    public HRESULT get_AutoRotationPreferences([NativeTypeName("ABI::Windows::Graphics::Display::DisplayOrientations *")] DisplayOrientations* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IDisplayPropertiesStatics*, DisplayOrientations*, int>)(lpVtbl[8]))((IDisplayPropertiesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IDisplayPropertiesStatics.xml' path='doc/member[@name="IDisplayPropertiesStatics.put_AutoRotationPreferences"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    [Obsolete("DisplayProperties may be altered or unavailable for releases after Windows Phone 8.1. Instead, use DisplayInformation.")]
    public HRESULT put_AutoRotationPreferences([NativeTypeName("ABI::Windows::Graphics::Display::DisplayOrientations")] DisplayOrientations value)
    {
        return ((delegate* unmanaged[MemberFunction]<IDisplayPropertiesStatics*, DisplayOrientations, int>)(lpVtbl[9]))((IDisplayPropertiesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IDisplayPropertiesStatics.xml' path='doc/member[@name="IDisplayPropertiesStatics.add_OrientationChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    [Obsolete("DisplayProperties may be altered or unavailable for releases after Windows Phone 8.1. Instead, use DisplayInformation.")]
    public HRESULT add_OrientationChanged([NativeTypeName("ABI::Windows::Graphics::Display::IDisplayPropertiesEventHandler *")] IDisplayPropertiesEventHandler* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IDisplayPropertiesStatics*, IDisplayPropertiesEventHandler*, EventRegistrationToken*, int>)(lpVtbl[10]))((IDisplayPropertiesStatics*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IDisplayPropertiesStatics.xml' path='doc/member[@name="IDisplayPropertiesStatics.remove_OrientationChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    [Obsolete("DisplayProperties may be altered or unavailable for releases after Windows Phone 8.1. Instead, use DisplayInformation.")]
    public HRESULT remove_OrientationChanged(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IDisplayPropertiesStatics*, EventRegistrationToken, int>)(lpVtbl[11]))((IDisplayPropertiesStatics*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='IDisplayPropertiesStatics.xml' path='doc/member[@name="IDisplayPropertiesStatics.get_ResolutionScale"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    [Obsolete("DisplayProperties may be altered or unavailable for releases after Windows Phone 8.1. Instead, use DisplayInformation.")]
    public HRESULT get_ResolutionScale([NativeTypeName("ABI::Windows::Graphics::Display::ResolutionScale *")] ResolutionScale* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IDisplayPropertiesStatics*, ResolutionScale*, int>)(lpVtbl[12]))((IDisplayPropertiesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IDisplayPropertiesStatics.xml' path='doc/member[@name="IDisplayPropertiesStatics.get_LogicalDpi"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    [Obsolete("DisplayProperties may be altered or unavailable for releases after Windows Phone 8.1. Instead, use DisplayInformation.")]
    public HRESULT get_LogicalDpi(float* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IDisplayPropertiesStatics*, float*, int>)(lpVtbl[13]))((IDisplayPropertiesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IDisplayPropertiesStatics.xml' path='doc/member[@name="IDisplayPropertiesStatics.add_LogicalDpiChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    [Obsolete("DisplayProperties may be altered or unavailable for releases after Windows Phone 8.1. Instead, use DisplayInformation.")]
    public HRESULT add_LogicalDpiChanged([NativeTypeName("ABI::Windows::Graphics::Display::IDisplayPropertiesEventHandler *")] IDisplayPropertiesEventHandler* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IDisplayPropertiesStatics*, IDisplayPropertiesEventHandler*, EventRegistrationToken*, int>)(lpVtbl[14]))((IDisplayPropertiesStatics*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IDisplayPropertiesStatics.xml' path='doc/member[@name="IDisplayPropertiesStatics.remove_LogicalDpiChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    [Obsolete("DisplayProperties may be altered or unavailable for releases after Windows Phone 8.1. Instead, use DisplayInformation.")]
    public HRESULT remove_LogicalDpiChanged(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IDisplayPropertiesStatics*, EventRegistrationToken, int>)(lpVtbl[15]))((IDisplayPropertiesStatics*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='IDisplayPropertiesStatics.xml' path='doc/member[@name="IDisplayPropertiesStatics.get_StereoEnabled"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    [Obsolete("DisplayProperties may be altered or unavailable for releases after Windows Phone 8.1. Instead, use DisplayInformation.")]
    public HRESULT get_StereoEnabled([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IDisplayPropertiesStatics*, byte*, int>)(lpVtbl[16]))((IDisplayPropertiesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IDisplayPropertiesStatics.xml' path='doc/member[@name="IDisplayPropertiesStatics.add_StereoEnabledChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    [Obsolete("DisplayProperties may be altered or unavailable for releases after Windows Phone 8.1. Instead, use DisplayInformation.")]
    public HRESULT add_StereoEnabledChanged([NativeTypeName("ABI::Windows::Graphics::Display::IDisplayPropertiesEventHandler *")] IDisplayPropertiesEventHandler* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IDisplayPropertiesStatics*, IDisplayPropertiesEventHandler*, EventRegistrationToken*, int>)(lpVtbl[17]))((IDisplayPropertiesStatics*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IDisplayPropertiesStatics.xml' path='doc/member[@name="IDisplayPropertiesStatics.remove_StereoEnabledChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    [Obsolete("DisplayProperties may be altered or unavailable for releases after Windows Phone 8.1. Instead, use DisplayInformation.")]
    public HRESULT remove_StereoEnabledChanged(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IDisplayPropertiesStatics*, EventRegistrationToken, int>)(lpVtbl[18]))((IDisplayPropertiesStatics*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='IDisplayPropertiesStatics.xml' path='doc/member[@name="IDisplayPropertiesStatics.GetColorProfileAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    [Obsolete("DisplayProperties may be altered or unavailable for releases after Windows Phone 8.1. Instead, use DisplayInformation.")]
    public HRESULT GetColorProfileAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStreams__CIRandomAccessStream_t **")] IAsyncOperation<Pointer<IRandomAccessStream>>** asyncInfo)
    {
        return ((delegate* unmanaged[MemberFunction]<IDisplayPropertiesStatics*, IAsyncOperation<Pointer<IRandomAccessStream>>**, int>)(lpVtbl[19]))((IDisplayPropertiesStatics*)Unsafe.AsPointer(ref this), asyncInfo);
    }

    /// <include file='IDisplayPropertiesStatics.xml' path='doc/member[@name="IDisplayPropertiesStatics.add_ColorProfileChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    [Obsolete("DisplayProperties may be altered or unavailable for releases after Windows Phone 8.1. Instead, use DisplayInformation.")]
    public HRESULT add_ColorProfileChanged([NativeTypeName("ABI::Windows::Graphics::Display::IDisplayPropertiesEventHandler *")] IDisplayPropertiesEventHandler* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IDisplayPropertiesStatics*, IDisplayPropertiesEventHandler*, EventRegistrationToken*, int>)(lpVtbl[20]))((IDisplayPropertiesStatics*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IDisplayPropertiesStatics.xml' path='doc/member[@name="IDisplayPropertiesStatics.remove_ColorProfileChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    [Obsolete("DisplayProperties may be altered or unavailable for releases after Windows Phone 8.1. Instead, use DisplayInformation.")]
    public HRESULT remove_ColorProfileChanged(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IDisplayPropertiesStatics*, EventRegistrationToken, int>)(lpVtbl[21]))((IDisplayPropertiesStatics*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='IDisplayPropertiesStatics.xml' path='doc/member[@name="IDisplayPropertiesStatics.add_DisplayContentsInvalidated"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    [Obsolete("DisplayProperties may be altered or unavailable for releases after Windows Phone 8.1. Instead, use DisplayInformation.")]
    public HRESULT add_DisplayContentsInvalidated([NativeTypeName("ABI::Windows::Graphics::Display::IDisplayPropertiesEventHandler *")] IDisplayPropertiesEventHandler* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IDisplayPropertiesStatics*, IDisplayPropertiesEventHandler*, EventRegistrationToken*, int>)(lpVtbl[22]))((IDisplayPropertiesStatics*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IDisplayPropertiesStatics.xml' path='doc/member[@name="IDisplayPropertiesStatics.remove_DisplayContentsInvalidated"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    [Obsolete("DisplayProperties may be altered or unavailable for releases after Windows Phone 8.1. Instead, use DisplayInformation.")]
    public HRESULT remove_DisplayContentsInvalidated(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IDisplayPropertiesStatics*, EventRegistrationToken, int>)(lpVtbl[23]))((IDisplayPropertiesStatics*)Unsafe.AsPointer(ref this), token);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        [Obsolete("DisplayProperties may be altered or unavailable for releases after Windows Phone 8.1. Instead, use DisplayInformation.")]
        HRESULT get_CurrentOrientation([NativeTypeName("ABI::Windows::Graphics::Display::DisplayOrientations *")] DisplayOrientations* value);

        [VtblIndex(7)]
        [Obsolete("DisplayProperties may be altered or unavailable for releases after Windows Phone 8.1. Instead, use DisplayInformation.")]
        HRESULT get_NativeOrientation([NativeTypeName("ABI::Windows::Graphics::Display::DisplayOrientations *")] DisplayOrientations* value);

        [VtblIndex(8)]
        [Obsolete("DisplayProperties may be altered or unavailable for releases after Windows Phone 8.1. Instead, use DisplayInformation.")]
        HRESULT get_AutoRotationPreferences([NativeTypeName("ABI::Windows::Graphics::Display::DisplayOrientations *")] DisplayOrientations* value);

        [VtblIndex(9)]
        [Obsolete("DisplayProperties may be altered or unavailable for releases after Windows Phone 8.1. Instead, use DisplayInformation.")]
        HRESULT put_AutoRotationPreferences([NativeTypeName("ABI::Windows::Graphics::Display::DisplayOrientations")] DisplayOrientations value);

        [VtblIndex(10)]
        [Obsolete("DisplayProperties may be altered or unavailable for releases after Windows Phone 8.1. Instead, use DisplayInformation.")]
        HRESULT add_OrientationChanged([NativeTypeName("ABI::Windows::Graphics::Display::IDisplayPropertiesEventHandler *")] IDisplayPropertiesEventHandler* handler, EventRegistrationToken* token);

        [VtblIndex(11)]
        [Obsolete("DisplayProperties may be altered or unavailable for releases after Windows Phone 8.1. Instead, use DisplayInformation.")]
        HRESULT remove_OrientationChanged(EventRegistrationToken token);

        [VtblIndex(12)]
        [Obsolete("DisplayProperties may be altered or unavailable for releases after Windows Phone 8.1. Instead, use DisplayInformation.")]
        HRESULT get_ResolutionScale([NativeTypeName("ABI::Windows::Graphics::Display::ResolutionScale *")] ResolutionScale* value);

        [VtblIndex(13)]
        [Obsolete("DisplayProperties may be altered or unavailable for releases after Windows Phone 8.1. Instead, use DisplayInformation.")]
        HRESULT get_LogicalDpi(float* value);

        [VtblIndex(14)]
        [Obsolete("DisplayProperties may be altered or unavailable for releases after Windows Phone 8.1. Instead, use DisplayInformation.")]
        HRESULT add_LogicalDpiChanged([NativeTypeName("ABI::Windows::Graphics::Display::IDisplayPropertiesEventHandler *")] IDisplayPropertiesEventHandler* handler, EventRegistrationToken* token);

        [VtblIndex(15)]
        [Obsolete("DisplayProperties may be altered or unavailable for releases after Windows Phone 8.1. Instead, use DisplayInformation.")]
        HRESULT remove_LogicalDpiChanged(EventRegistrationToken token);

        [VtblIndex(16)]
        [Obsolete("DisplayProperties may be altered or unavailable for releases after Windows Phone 8.1. Instead, use DisplayInformation.")]
        HRESULT get_StereoEnabled([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(17)]
        [Obsolete("DisplayProperties may be altered or unavailable for releases after Windows Phone 8.1. Instead, use DisplayInformation.")]
        HRESULT add_StereoEnabledChanged([NativeTypeName("ABI::Windows::Graphics::Display::IDisplayPropertiesEventHandler *")] IDisplayPropertiesEventHandler* handler, EventRegistrationToken* token);

        [VtblIndex(18)]
        [Obsolete("DisplayProperties may be altered or unavailable for releases after Windows Phone 8.1. Instead, use DisplayInformation.")]
        HRESULT remove_StereoEnabledChanged(EventRegistrationToken token);

        [VtblIndex(19)]
        [Obsolete("DisplayProperties may be altered or unavailable for releases after Windows Phone 8.1. Instead, use DisplayInformation.")]
        HRESULT GetColorProfileAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStreams__CIRandomAccessStream_t **")] IAsyncOperation<Pointer<IRandomAccessStream>>** asyncInfo);

        [VtblIndex(20)]
        [Obsolete("DisplayProperties may be altered or unavailable for releases after Windows Phone 8.1. Instead, use DisplayInformation.")]
        HRESULT add_ColorProfileChanged([NativeTypeName("ABI::Windows::Graphics::Display::IDisplayPropertiesEventHandler *")] IDisplayPropertiesEventHandler* handler, EventRegistrationToken* token);

        [VtblIndex(21)]
        [Obsolete("DisplayProperties may be altered or unavailable for releases after Windows Phone 8.1. Instead, use DisplayInformation.")]
        HRESULT remove_ColorProfileChanged(EventRegistrationToken token);

        [VtblIndex(22)]
        [Obsolete("DisplayProperties may be altered or unavailable for releases after Windows Phone 8.1. Instead, use DisplayInformation.")]
        HRESULT add_DisplayContentsInvalidated([NativeTypeName("ABI::Windows::Graphics::Display::IDisplayPropertiesEventHandler *")] IDisplayPropertiesEventHandler* handler, EventRegistrationToken* token);

        [VtblIndex(23)]
        [Obsolete("DisplayProperties may be altered or unavailable for releases after Windows Phone 8.1. Instead, use DisplayInformation.")]
        HRESULT remove_DisplayContentsInvalidated(EventRegistrationToken token);
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
        [Obsolete("DisplayProperties may be altered or unavailable for releases after Windows Phone 8.1. Instead, use DisplayInformation.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, DisplayOrientations*, int> get_CurrentOrientation;

        [NativeTypeName("HRESULT (ABI::Windows::Graphics::Display::DisplayOrientations *) __attribute__((stdcall))")]
        [Obsolete("DisplayProperties may be altered or unavailable for releases after Windows Phone 8.1. Instead, use DisplayInformation.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, DisplayOrientations*, int> get_NativeOrientation;

        [NativeTypeName("HRESULT (ABI::Windows::Graphics::Display::DisplayOrientations *) __attribute__((stdcall))")]
        [Obsolete("DisplayProperties may be altered or unavailable for releases after Windows Phone 8.1. Instead, use DisplayInformation.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, DisplayOrientations*, int> get_AutoRotationPreferences;

        [NativeTypeName("HRESULT (ABI::Windows::Graphics::Display::DisplayOrientations) __attribute__((stdcall))")]
        [Obsolete("DisplayProperties may be altered or unavailable for releases after Windows Phone 8.1. Instead, use DisplayInformation.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, DisplayOrientations, int> put_AutoRotationPreferences;

        [NativeTypeName("HRESULT (ABI::Windows::Graphics::Display::IDisplayPropertiesEventHandler *, EventRegistrationToken *) __attribute__((stdcall))")]
        [Obsolete("DisplayProperties may be altered or unavailable for releases after Windows Phone 8.1. Instead, use DisplayInformation.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IDisplayPropertiesEventHandler*, EventRegistrationToken*, int> add_OrientationChanged;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        [Obsolete("DisplayProperties may be altered or unavailable for releases after Windows Phone 8.1. Instead, use DisplayInformation.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_OrientationChanged;

        [NativeTypeName("HRESULT (ABI::Windows::Graphics::Display::ResolutionScale *) __attribute__((stdcall))")]
        [Obsolete("DisplayProperties may be altered or unavailable for releases after Windows Phone 8.1. Instead, use DisplayInformation.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ResolutionScale*, int> get_ResolutionScale;

        [NativeTypeName("HRESULT (FLOAT *) __attribute__((stdcall))")]
        [Obsolete("DisplayProperties may be altered or unavailable for releases after Windows Phone 8.1. Instead, use DisplayInformation.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, float*, int> get_LogicalDpi;

        [NativeTypeName("HRESULT (ABI::Windows::Graphics::Display::IDisplayPropertiesEventHandler *, EventRegistrationToken *) __attribute__((stdcall))")]
        [Obsolete("DisplayProperties may be altered or unavailable for releases after Windows Phone 8.1. Instead, use DisplayInformation.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IDisplayPropertiesEventHandler*, EventRegistrationToken*, int> add_LogicalDpiChanged;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        [Obsolete("DisplayProperties may be altered or unavailable for releases after Windows Phone 8.1. Instead, use DisplayInformation.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_LogicalDpiChanged;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        [Obsolete("DisplayProperties may be altered or unavailable for releases after Windows Phone 8.1. Instead, use DisplayInformation.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_StereoEnabled;

        [NativeTypeName("HRESULT (ABI::Windows::Graphics::Display::IDisplayPropertiesEventHandler *, EventRegistrationToken *) __attribute__((stdcall))")]
        [Obsolete("DisplayProperties may be altered or unavailable for releases after Windows Phone 8.1. Instead, use DisplayInformation.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IDisplayPropertiesEventHandler*, EventRegistrationToken*, int> add_StereoEnabledChanged;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        [Obsolete("DisplayProperties may be altered or unavailable for releases after Windows Phone 8.1. Instead, use DisplayInformation.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_StereoEnabledChanged;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStreams__CIRandomAccessStream_t **) __attribute__((stdcall))")]
        [Obsolete("DisplayProperties may be altered or unavailable for releases after Windows Phone 8.1. Instead, use DisplayInformation.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAsyncOperation<Pointer<IRandomAccessStream>>**, int> GetColorProfileAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Graphics::Display::IDisplayPropertiesEventHandler *, EventRegistrationToken *) __attribute__((stdcall))")]
        [Obsolete("DisplayProperties may be altered or unavailable for releases after Windows Phone 8.1. Instead, use DisplayInformation.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IDisplayPropertiesEventHandler*, EventRegistrationToken*, int> add_ColorProfileChanged;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        [Obsolete("DisplayProperties may be altered or unavailable for releases after Windows Phone 8.1. Instead, use DisplayInformation.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_ColorProfileChanged;

        [NativeTypeName("HRESULT (ABI::Windows::Graphics::Display::IDisplayPropertiesEventHandler *, EventRegistrationToken *) __attribute__((stdcall))")]
        [Obsolete("DisplayProperties may be altered or unavailable for releases after Windows Phone 8.1. Instead, use DisplayInformation.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IDisplayPropertiesEventHandler*, EventRegistrationToken*, int> add_DisplayContentsInvalidated;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        [Obsolete("DisplayProperties may be altered or unavailable for releases after Windows Phone 8.1. Instead, use DisplayInformation.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_DisplayContentsInvalidated;
    }
}
