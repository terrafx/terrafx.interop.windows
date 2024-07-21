// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.capture.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ICapturedFrameControlValues2.xml' path='doc/member[@name="ICapturedFrameControlValues2"]/*' />
[Guid("500B2B88-06D2-4AA7-A7DB-D37AF73321D8")]
[NativeTypeName("struct ICapturedFrameControlValues2 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ICapturedFrameControlValues2 : ICapturedFrameControlValues2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ICapturedFrameControlValues2));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ICapturedFrameControlValues2*, Guid*, void**, int>)(lpVtbl[0]))((ICapturedFrameControlValues2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ICapturedFrameControlValues2*, uint>)(lpVtbl[1]))((ICapturedFrameControlValues2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ICapturedFrameControlValues2*, uint>)(lpVtbl[2]))((ICapturedFrameControlValues2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ICapturedFrameControlValues2*, uint*, Guid**, int>)(lpVtbl[3]))((ICapturedFrameControlValues2*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ICapturedFrameControlValues2*, HSTRING*, int>)(lpVtbl[4]))((ICapturedFrameControlValues2*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ICapturedFrameControlValues2*, TrustLevel*, int>)(lpVtbl[5]))((ICapturedFrameControlValues2*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ICapturedFrameControlValues2.xml' path='doc/member[@name="ICapturedFrameControlValues2.get_FocusState"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_FocusState([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CMedia__CDevices__CMediaCaptureFocusState_t **")] IReference<MediaCaptureFocusState>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICapturedFrameControlValues2*, IReference<MediaCaptureFocusState>**, int>)(lpVtbl[6]))((ICapturedFrameControlValues2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICapturedFrameControlValues2.xml' path='doc/member[@name="ICapturedFrameControlValues2.get_IsoDigitalGain"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_IsoDigitalGain([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_double_t **")] IReference<double>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICapturedFrameControlValues2*, IReference<double>**, int>)(lpVtbl[7]))((ICapturedFrameControlValues2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICapturedFrameControlValues2.xml' path='doc/member[@name="ICapturedFrameControlValues2.get_IsoAnalogGain"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_IsoAnalogGain([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_double_t **")] IReference<double>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICapturedFrameControlValues2*, IReference<double>**, int>)(lpVtbl[8]))((ICapturedFrameControlValues2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICapturedFrameControlValues2.xml' path='doc/member[@name="ICapturedFrameControlValues2.get_SensorFrameRate"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_SensorFrameRate([NativeTypeName("ABI::Windows::Media::MediaProperties::IMediaRatio **")] IMediaRatio** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICapturedFrameControlValues2*, IMediaRatio**, int>)(lpVtbl[9]))((ICapturedFrameControlValues2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICapturedFrameControlValues2.xml' path='doc/member[@name="ICapturedFrameControlValues2.get_WhiteBalanceGain"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_WhiteBalanceGain([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CMedia__CCapture__CWhiteBalanceGain_t **")] IReference<WhiteBalanceGain>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICapturedFrameControlValues2*, IReference<WhiteBalanceGain>**, int>)(lpVtbl[10]))((ICapturedFrameControlValues2*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_FocusState([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CMedia__CDevices__CMediaCaptureFocusState_t **")] IReference<MediaCaptureFocusState>** value);

        [VtblIndex(7)]
        HRESULT get_IsoDigitalGain([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_double_t **")] IReference<double>** value);

        [VtblIndex(8)]
        HRESULT get_IsoAnalogGain([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_double_t **")] IReference<double>** value);

        [VtblIndex(9)]
        HRESULT get_SensorFrameRate([NativeTypeName("ABI::Windows::Media::MediaProperties::IMediaRatio **")] IMediaRatio** value);

        [VtblIndex(10)]
        HRESULT get_WhiteBalanceGain([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CMedia__CCapture__CWhiteBalanceGain_t **")] IReference<WhiteBalanceGain>** value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_Windows__CMedia__CDevices__CMediaCaptureFocusState_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<MediaCaptureFocusState>**, int> get_FocusState;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_double_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<double>**, int> get_IsoDigitalGain;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_double_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<double>**, int> get_IsoAnalogGain;

        [NativeTypeName("HRESULT (ABI::Windows::Media::MediaProperties::IMediaRatio **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IMediaRatio**, int> get_SensorFrameRate;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_Windows__CMedia__CCapture__CWhiteBalanceGain_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<WhiteBalanceGain>**, int> get_WhiteBalanceGain;
    }
}
