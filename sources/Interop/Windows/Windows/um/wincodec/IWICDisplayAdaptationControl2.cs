// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IWICDisplayAdaptationControl2.xml' path='doc/member[@name="IWICDisplayAdaptationControl2"]/*' />
[Guid("D7508D29-3AB7-447E-A676-4D80D7DE726B")]
[NativeTypeName("struct IWICDisplayAdaptationControl2 : IWICDisplayAdaptationControl")]
[NativeInheritance("IWICDisplayAdaptationControl")]
public unsafe partial struct IWICDisplayAdaptationControl2 : IWICDisplayAdaptationControl2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IWICDisplayAdaptationControl2);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IWICDisplayAdaptationControl2*, Guid*, void**, int>)(lpVtbl[0]))((IWICDisplayAdaptationControl2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IWICDisplayAdaptationControl2*, uint>)(lpVtbl[1]))((IWICDisplayAdaptationControl2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IWICDisplayAdaptationControl2*, uint>)(lpVtbl[2]))((IWICDisplayAdaptationControl2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IWICDisplayAdaptationControl.DoesSupportChangingMaxLuminance" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT DoesSupportChangingMaxLuminance([NativeTypeName("WICPixelFormatGUID *")] Guid* pguidDstFormat, BOOL* pfIsSupported)
    {
        return ((delegate* unmanaged[MemberFunction]<IWICDisplayAdaptationControl2*, Guid*, BOOL*, int>)(lpVtbl[3]))((IWICDisplayAdaptationControl2*)Unsafe.AsPointer(ref this), pguidDstFormat, pfIsSupported);
    }

    /// <inheritdoc cref="IWICDisplayAdaptationControl.SetDisplayMaxLuminance" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetDisplayMaxLuminance(float fLuminanceInNits)
    {
        return ((delegate* unmanaged[MemberFunction]<IWICDisplayAdaptationControl2*, float, int>)(lpVtbl[4]))((IWICDisplayAdaptationControl2*)Unsafe.AsPointer(ref this), fLuminanceInNits);
    }

    /// <inheritdoc cref="IWICDisplayAdaptationControl.GetDisplayMaxLuminance" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetDisplayMaxLuminance(float* pfLuminanceInNits)
    {
        return ((delegate* unmanaged[MemberFunction]<IWICDisplayAdaptationControl2*, float*, int>)(lpVtbl[5]))((IWICDisplayAdaptationControl2*)Unsafe.AsPointer(ref this), pfLuminanceInNits);
    }

    /// <include file='IWICDisplayAdaptationControl2.xml' path='doc/member[@name="IWICDisplayAdaptationControl2.SetSdrWhiteLevel"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT SetSdrWhiteLevel(float fWhiteLevelInNits)
    {
        return ((delegate* unmanaged[MemberFunction]<IWICDisplayAdaptationControl2*, float, int>)(lpVtbl[6]))((IWICDisplayAdaptationControl2*)Unsafe.AsPointer(ref this), fWhiteLevelInNits);
    }

    /// <include file='IWICDisplayAdaptationControl2.xml' path='doc/member[@name="IWICDisplayAdaptationControl2.GetSdrWhiteLevel"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetSdrWhiteLevel(float* pfWhiteLevelInNits)
    {
        return ((delegate* unmanaged[MemberFunction]<IWICDisplayAdaptationControl2*, float*, int>)(lpVtbl[7]))((IWICDisplayAdaptationControl2*)Unsafe.AsPointer(ref this), pfWhiteLevelInNits);
    }

    /// <include file='IWICDisplayAdaptationControl2.xml' path='doc/member[@name="IWICDisplayAdaptationControl2.SetToneMappingMode"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT SetToneMappingMode(WICBitmapToneMappingMode mode)
    {
        return ((delegate* unmanaged[MemberFunction]<IWICDisplayAdaptationControl2*, WICBitmapToneMappingMode, int>)(lpVtbl[8]))((IWICDisplayAdaptationControl2*)Unsafe.AsPointer(ref this), mode);
    }

    /// <include file='IWICDisplayAdaptationControl2.xml' path='doc/member[@name="IWICDisplayAdaptationControl2.GetToneMappingMode"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetToneMappingMode(WICBitmapToneMappingMode* mode)
    {
        return ((delegate* unmanaged[MemberFunction]<IWICDisplayAdaptationControl2*, WICBitmapToneMappingMode*, int>)(lpVtbl[9]))((IWICDisplayAdaptationControl2*)Unsafe.AsPointer(ref this), mode);
    }

    /// <include file='IWICDisplayAdaptationControl2.xml' path='doc/member[@name="IWICDisplayAdaptationControl2.DoesSupportToneMappingMode"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT DoesSupportToneMappingMode(WICBitmapToneMappingMode mode, BOOL* pfIsSupported)
    {
        return ((delegate* unmanaged[MemberFunction]<IWICDisplayAdaptationControl2*, WICBitmapToneMappingMode, BOOL*, int>)(lpVtbl[10]))((IWICDisplayAdaptationControl2*)Unsafe.AsPointer(ref this), mode, pfIsSupported);
    }

    public interface Interface : IWICDisplayAdaptationControl.Interface
    {
        [VtblIndex(6)]
        HRESULT SetSdrWhiteLevel(float fWhiteLevelInNits);

        [VtblIndex(7)]
        HRESULT GetSdrWhiteLevel(float* pfWhiteLevelInNits);

        [VtblIndex(8)]
        HRESULT SetToneMappingMode(WICBitmapToneMappingMode mode);

        [VtblIndex(9)]
        HRESULT GetToneMappingMode(WICBitmapToneMappingMode* mode);

        [VtblIndex(10)]
        HRESULT DoesSupportToneMappingMode(WICBitmapToneMappingMode mode, BOOL* pfIsSupported);
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

        [NativeTypeName("HRESULT (WICPixelFormatGUID *, BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, BOOL*, int> DoesSupportChangingMaxLuminance;

        [NativeTypeName("HRESULT (FLOAT) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, float, int> SetDisplayMaxLuminance;

        [NativeTypeName("HRESULT (FLOAT *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, float*, int> GetDisplayMaxLuminance;

        [NativeTypeName("HRESULT (FLOAT) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, float, int> SetSdrWhiteLevel;

        [NativeTypeName("HRESULT (FLOAT *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, float*, int> GetSdrWhiteLevel;

        [NativeTypeName("HRESULT (WICBitmapToneMappingMode) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, WICBitmapToneMappingMode, int> SetToneMappingMode;

        [NativeTypeName("HRESULT (WICBitmapToneMappingMode *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, WICBitmapToneMappingMode*, int> GetToneMappingMode;

        [NativeTypeName("HRESULT (WICBitmapToneMappingMode, BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, WICBitmapToneMappingMode, BOOL*, int> DoesSupportToneMappingMode;
    }
}
