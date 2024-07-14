// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.graphics.display.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IAdvancedColorInfo.xml' path='doc/member[@name="IAdvancedColorInfo"]/*' />
[Guid("8797DCFB-B229-4081-AE9A-2CC85E34AD6A")]
[NativeTypeName("struct IAdvancedColorInfo : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IAdvancedColorInfo : IAdvancedColorInfo.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAdvancedColorInfo));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IAdvancedColorInfo*, Guid*, void**, int>)(lpVtbl[0]))((IAdvancedColorInfo*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IAdvancedColorInfo*, uint>)(lpVtbl[1]))((IAdvancedColorInfo*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IAdvancedColorInfo*, uint>)(lpVtbl[2]))((IAdvancedColorInfo*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IAdvancedColorInfo*, uint*, Guid**, int>)(lpVtbl[3]))((IAdvancedColorInfo*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IAdvancedColorInfo*, HSTRING*, int>)(lpVtbl[4]))((IAdvancedColorInfo*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IAdvancedColorInfo*, TrustLevel*, int>)(lpVtbl[5]))((IAdvancedColorInfo*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IAdvancedColorInfo.xml' path='doc/member[@name="IAdvancedColorInfo.get_CurrentAdvancedColorKind"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_CurrentAdvancedColorKind([NativeTypeName("ABI::Windows::Graphics::Display::AdvancedColorKind *")] AdvancedColorKind* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAdvancedColorInfo*, AdvancedColorKind*, int>)(lpVtbl[6]))((IAdvancedColorInfo*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAdvancedColorInfo.xml' path='doc/member[@name="IAdvancedColorInfo.get_RedPrimary"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_RedPrimary([NativeTypeName("ABI::Windows::Foundation::Point *")] Point* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAdvancedColorInfo*, Point*, int>)(lpVtbl[7]))((IAdvancedColorInfo*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAdvancedColorInfo.xml' path='doc/member[@name="IAdvancedColorInfo.get_GreenPrimary"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_GreenPrimary([NativeTypeName("ABI::Windows::Foundation::Point *")] Point* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAdvancedColorInfo*, Point*, int>)(lpVtbl[8]))((IAdvancedColorInfo*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAdvancedColorInfo.xml' path='doc/member[@name="IAdvancedColorInfo.get_BluePrimary"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_BluePrimary([NativeTypeName("ABI::Windows::Foundation::Point *")] Point* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAdvancedColorInfo*, Point*, int>)(lpVtbl[9]))((IAdvancedColorInfo*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAdvancedColorInfo.xml' path='doc/member[@name="IAdvancedColorInfo.get_WhitePoint"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_WhitePoint([NativeTypeName("ABI::Windows::Foundation::Point *")] Point* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAdvancedColorInfo*, Point*, int>)(lpVtbl[10]))((IAdvancedColorInfo*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAdvancedColorInfo.xml' path='doc/member[@name="IAdvancedColorInfo.get_MaxLuminanceInNits"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_MaxLuminanceInNits(float* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAdvancedColorInfo*, float*, int>)(lpVtbl[11]))((IAdvancedColorInfo*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAdvancedColorInfo.xml' path='doc/member[@name="IAdvancedColorInfo.get_MinLuminanceInNits"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_MinLuminanceInNits(float* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAdvancedColorInfo*, float*, int>)(lpVtbl[12]))((IAdvancedColorInfo*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAdvancedColorInfo.xml' path='doc/member[@name="IAdvancedColorInfo.get_MaxAverageFullFrameLuminanceInNits"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_MaxAverageFullFrameLuminanceInNits(float* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAdvancedColorInfo*, float*, int>)(lpVtbl[13]))((IAdvancedColorInfo*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAdvancedColorInfo.xml' path='doc/member[@name="IAdvancedColorInfo.get_SdrWhiteLevelInNits"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_SdrWhiteLevelInNits(float* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAdvancedColorInfo*, float*, int>)(lpVtbl[14]))((IAdvancedColorInfo*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAdvancedColorInfo.xml' path='doc/member[@name="IAdvancedColorInfo.IsHdrMetadataFormatCurrentlySupported"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT IsHdrMetadataFormatCurrentlySupported([NativeTypeName("ABI::Windows::Graphics::Display::HdrMetadataFormat")] HdrMetadataFormat format, [NativeTypeName("boolean *")] byte* result)
    {
        return ((delegate* unmanaged[MemberFunction]<IAdvancedColorInfo*, HdrMetadataFormat, byte*, int>)(lpVtbl[15]))((IAdvancedColorInfo*)Unsafe.AsPointer(ref this), format, result);
    }

    /// <include file='IAdvancedColorInfo.xml' path='doc/member[@name="IAdvancedColorInfo.IsAdvancedColorKindAvailable"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT IsAdvancedColorKindAvailable([NativeTypeName("ABI::Windows::Graphics::Display::AdvancedColorKind")] AdvancedColorKind kind, [NativeTypeName("boolean *")] byte* result)
    {
        return ((delegate* unmanaged[MemberFunction]<IAdvancedColorInfo*, AdvancedColorKind, byte*, int>)(lpVtbl[16]))((IAdvancedColorInfo*)Unsafe.AsPointer(ref this), kind, result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_CurrentAdvancedColorKind([NativeTypeName("ABI::Windows::Graphics::Display::AdvancedColorKind *")] AdvancedColorKind* value);

        [VtblIndex(7)]
        HRESULT get_RedPrimary([NativeTypeName("ABI::Windows::Foundation::Point *")] Point* value);

        [VtblIndex(8)]
        HRESULT get_GreenPrimary([NativeTypeName("ABI::Windows::Foundation::Point *")] Point* value);

        [VtblIndex(9)]
        HRESULT get_BluePrimary([NativeTypeName("ABI::Windows::Foundation::Point *")] Point* value);

        [VtblIndex(10)]
        HRESULT get_WhitePoint([NativeTypeName("ABI::Windows::Foundation::Point *")] Point* value);

        [VtblIndex(11)]
        HRESULT get_MaxLuminanceInNits(float* value);

        [VtblIndex(12)]
        HRESULT get_MinLuminanceInNits(float* value);

        [VtblIndex(13)]
        HRESULT get_MaxAverageFullFrameLuminanceInNits(float* value);

        [VtblIndex(14)]
        HRESULT get_SdrWhiteLevelInNits(float* value);

        [VtblIndex(15)]
        HRESULT IsHdrMetadataFormatCurrentlySupported([NativeTypeName("ABI::Windows::Graphics::Display::HdrMetadataFormat")] HdrMetadataFormat format, [NativeTypeName("boolean *")] byte* result);

        [VtblIndex(16)]
        HRESULT IsAdvancedColorKindAvailable([NativeTypeName("ABI::Windows::Graphics::Display::AdvancedColorKind")] AdvancedColorKind kind, [NativeTypeName("boolean *")] byte* result);
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

        [NativeTypeName("HRESULT (ABI::Windows::Graphics::Display::AdvancedColorKind *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, AdvancedColorKind*, int> get_CurrentAdvancedColorKind;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Point *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Point*, int> get_RedPrimary;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Point *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Point*, int> get_GreenPrimary;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Point *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Point*, int> get_BluePrimary;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Point *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Point*, int> get_WhitePoint;

        [NativeTypeName("HRESULT (FLOAT *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, float*, int> get_MaxLuminanceInNits;

        [NativeTypeName("HRESULT (FLOAT *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, float*, int> get_MinLuminanceInNits;

        [NativeTypeName("HRESULT (FLOAT *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, float*, int> get_MaxAverageFullFrameLuminanceInNits;

        [NativeTypeName("HRESULT (FLOAT *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, float*, int> get_SdrWhiteLevelInNits;

        [NativeTypeName("HRESULT (ABI::Windows::Graphics::Display::HdrMetadataFormat, boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HdrMetadataFormat, byte*, int> IsHdrMetadataFormatCurrentlySupported;

        [NativeTypeName("HRESULT (ABI::Windows::Graphics::Display::AdvancedColorKind, boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, AdvancedColorKind, byte*, int> IsAdvancedColorKindAvailable;
    }
}
