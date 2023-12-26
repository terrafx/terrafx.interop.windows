// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.capture.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ICapturedFrameControlValues.xml' path='doc/member[@name="ICapturedFrameControlValues"]/*' />
[Guid("90C65B7F-4E0D-4CA4-882D-7A144FED0A90")]
[NativeTypeName("struct ICapturedFrameControlValues : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ICapturedFrameControlValues : ICapturedFrameControlValues.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ICapturedFrameControlValues));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ICapturedFrameControlValues*, Guid*, void**, int>)(lpVtbl[0]))((ICapturedFrameControlValues*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ICapturedFrameControlValues*, uint>)(lpVtbl[1]))((ICapturedFrameControlValues*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ICapturedFrameControlValues*, uint>)(lpVtbl[2]))((ICapturedFrameControlValues*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ICapturedFrameControlValues*, uint*, Guid**, int>)(lpVtbl[3]))((ICapturedFrameControlValues*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ICapturedFrameControlValues*, HSTRING*, int>)(lpVtbl[4]))((ICapturedFrameControlValues*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ICapturedFrameControlValues*, TrustLevel*, int>)(lpVtbl[5]))((ICapturedFrameControlValues*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ICapturedFrameControlValues.xml' path='doc/member[@name="ICapturedFrameControlValues.get_Exposure"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Exposure([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CTimeSpan_t **")] IReference<TimeSpan>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICapturedFrameControlValues*, IReference<TimeSpan>**, int>)(lpVtbl[6]))((ICapturedFrameControlValues*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICapturedFrameControlValues.xml' path='doc/member[@name="ICapturedFrameControlValues.get_ExposureCompensation"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_ExposureCompensation([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_float_t **")] IReference<float>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICapturedFrameControlValues*, IReference<float>**, int>)(lpVtbl[7]))((ICapturedFrameControlValues*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICapturedFrameControlValues.xml' path='doc/member[@name="ICapturedFrameControlValues.get_IsoSpeed"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_IsoSpeed([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_UINT32_t **")] IReference<uint>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICapturedFrameControlValues*, IReference<uint>**, int>)(lpVtbl[8]))((ICapturedFrameControlValues*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICapturedFrameControlValues.xml' path='doc/member[@name="ICapturedFrameControlValues.get_Focus"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_Focus([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_UINT32_t **")] IReference<uint>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICapturedFrameControlValues*, IReference<uint>**, int>)(lpVtbl[9]))((ICapturedFrameControlValues*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICapturedFrameControlValues.xml' path='doc/member[@name="ICapturedFrameControlValues.get_SceneMode"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_SceneMode([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CMedia__CDevices__CCaptureSceneMode_t **")] IReference<CaptureSceneMode>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICapturedFrameControlValues*, IReference<CaptureSceneMode>**, int>)(lpVtbl[10]))((ICapturedFrameControlValues*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICapturedFrameControlValues.xml' path='doc/member[@name="ICapturedFrameControlValues.get_Flashed"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_Flashed([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_boolean_t **")] IReference<bool>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICapturedFrameControlValues*, IReference<bool>**, int>)(lpVtbl[11]))((ICapturedFrameControlValues*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICapturedFrameControlValues.xml' path='doc/member[@name="ICapturedFrameControlValues.get_FlashPowerPercent"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_FlashPowerPercent([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_float_t **")] IReference<float>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICapturedFrameControlValues*, IReference<float>**, int>)(lpVtbl[12]))((ICapturedFrameControlValues*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICapturedFrameControlValues.xml' path='doc/member[@name="ICapturedFrameControlValues.get_WhiteBalance"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_WhiteBalance([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_UINT32_t **")] IReference<uint>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICapturedFrameControlValues*, IReference<uint>**, int>)(lpVtbl[13]))((ICapturedFrameControlValues*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICapturedFrameControlValues.xml' path='doc/member[@name="ICapturedFrameControlValues.get_ZoomFactor"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_ZoomFactor([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_float_t **")] IReference<float>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICapturedFrameControlValues*, IReference<float>**, int>)(lpVtbl[14]))((ICapturedFrameControlValues*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Exposure([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CTimeSpan_t **")] IReference<TimeSpan>** value);

        [VtblIndex(7)]
        HRESULT get_ExposureCompensation([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_float_t **")] IReference<float>** value);

        [VtblIndex(8)]
        HRESULT get_IsoSpeed([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_UINT32_t **")] IReference<uint>** value);

        [VtblIndex(9)]
        HRESULT get_Focus([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_UINT32_t **")] IReference<uint>** value);

        [VtblIndex(10)]
        HRESULT get_SceneMode([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CMedia__CDevices__CCaptureSceneMode_t **")] IReference<CaptureSceneMode>** value);

        [VtblIndex(11)]
        HRESULT get_Flashed([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_boolean_t **")] IReference<bool>** value);

        [VtblIndex(12)]
        HRESULT get_FlashPowerPercent([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_float_t **")] IReference<float>** value);

        [VtblIndex(13)]
        HRESULT get_WhiteBalance([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_UINT32_t **")] IReference<uint>** value);

        [VtblIndex(14)]
        HRESULT get_ZoomFactor([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_float_t **")] IReference<float>** value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CTimeSpan_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<TimeSpan>**, int> get_Exposure;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_float_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<float>**, int> get_ExposureCompensation;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_UINT32_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<uint>**, int> get_IsoSpeed;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_UINT32_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<uint>**, int> get_Focus;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_Windows__CMedia__CDevices__CCaptureSceneMode_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<CaptureSceneMode>**, int> get_SceneMode;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_boolean_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<bool>**, int> get_Flashed;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_float_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<float>**, int> get_FlashPowerPercent;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_UINT32_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<uint>**, int> get_WhiteBalance;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_float_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<float>**, int> get_ZoomFactor;
    }
}
