// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IWICBitmapToneMapper.xml' path='doc/member[@name="IWICBitmapToneMapper"]/*' />
[Guid("44728DED-1EDF-4FE9-B50B-C89A264C9439")]
[NativeTypeName("struct IWICBitmapToneMapper : IWICBitmapSource")]
[NativeInheritance("IWICBitmapSource")]
public unsafe partial struct IWICBitmapToneMapper : IWICBitmapToneMapper.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IWICBitmapToneMapper);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IWICBitmapToneMapper*, Guid*, void**, int>)(lpVtbl[0]))((IWICBitmapToneMapper*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IWICBitmapToneMapper*, uint>)(lpVtbl[1]))((IWICBitmapToneMapper*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IWICBitmapToneMapper*, uint>)(lpVtbl[2]))((IWICBitmapToneMapper*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IWICBitmapSource.GetSize" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetSize(uint* puiWidth, uint* puiHeight)
    {
        return ((delegate* unmanaged[MemberFunction]<IWICBitmapToneMapper*, uint*, uint*, int>)(lpVtbl[3]))((IWICBitmapToneMapper*)Unsafe.AsPointer(ref this), puiWidth, puiHeight);
    }

    /// <inheritdoc cref="IWICBitmapSource.GetPixelFormat" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetPixelFormat([NativeTypeName("WICPixelFormatGUID *")] Guid* pPixelFormat)
    {
        return ((delegate* unmanaged[MemberFunction]<IWICBitmapToneMapper*, Guid*, int>)(lpVtbl[4]))((IWICBitmapToneMapper*)Unsafe.AsPointer(ref this), pPixelFormat);
    }

    /// <inheritdoc cref="IWICBitmapSource.GetResolution" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetResolution(double* pDpiX, double* pDpiY)
    {
        return ((delegate* unmanaged[MemberFunction]<IWICBitmapToneMapper*, double*, double*, int>)(lpVtbl[5]))((IWICBitmapToneMapper*)Unsafe.AsPointer(ref this), pDpiX, pDpiY);
    }

    /// <inheritdoc cref="IWICBitmapSource.CopyPalette" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT CopyPalette(IWICPalette* pIPalette)
    {
        return ((delegate* unmanaged[MemberFunction]<IWICBitmapToneMapper*, IWICPalette*, int>)(lpVtbl[6]))((IWICBitmapToneMapper*)Unsafe.AsPointer(ref this), pIPalette);
    }

    /// <inheritdoc cref="IWICBitmapSource.CopyPixels" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT CopyPixels([NativeTypeName("const WICRect *")] WICRect* prc, uint cbStride, uint cbBufferSize, byte* pbBuffer)
    {
        return ((delegate* unmanaged[MemberFunction]<IWICBitmapToneMapper*, WICRect*, uint, uint, byte*, int>)(lpVtbl[7]))((IWICBitmapToneMapper*)Unsafe.AsPointer(ref this), prc, cbStride, cbBufferSize, pbBuffer);
    }

    /// <include file='IWICBitmapToneMapper.xml' path='doc/member[@name="IWICBitmapToneMapper.InitializeForHdrTarget"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT InitializeForHdrTarget(IWICBitmapSource* pISource, [NativeTypeName("REFWICPixelFormatGUID")] Guid* guidDstFormat, float fLuminanceInNits, float fWhiteLevelInNits, WICBitmapToneMappingMode mode)
    {
        return ((delegate* unmanaged[MemberFunction]<IWICBitmapToneMapper*, IWICBitmapSource*, Guid*, float, float, WICBitmapToneMappingMode, int>)(lpVtbl[8]))((IWICBitmapToneMapper*)Unsafe.AsPointer(ref this), pISource, guidDstFormat, fLuminanceInNits, fWhiteLevelInNits, mode);
    }

    /// <include file='IWICBitmapToneMapper.xml' path='doc/member[@name="IWICBitmapToneMapper.InitializeForSdrTarget"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT InitializeForSdrTarget(IWICBitmapSource* pISource, [NativeTypeName("REFWICPixelFormatGUID")] Guid* guidDstFormat, WICBitmapToneMappingMode mode)
    {
        return ((delegate* unmanaged[MemberFunction]<IWICBitmapToneMapper*, IWICBitmapSource*, Guid*, WICBitmapToneMappingMode, int>)(lpVtbl[9]))((IWICBitmapToneMapper*)Unsafe.AsPointer(ref this), pISource, guidDstFormat, mode);
    }

    public interface Interface : IWICBitmapSource.Interface
    {
        [VtblIndex(8)]
        HRESULT InitializeForHdrTarget(IWICBitmapSource* pISource, [NativeTypeName("REFWICPixelFormatGUID")] Guid* guidDstFormat, float fLuminanceInNits, float fWhiteLevelInNits, WICBitmapToneMappingMode mode);

        [VtblIndex(9)]
        HRESULT InitializeForSdrTarget(IWICBitmapSource* pISource, [NativeTypeName("REFWICPixelFormatGUID")] Guid* guidDstFormat, WICBitmapToneMappingMode mode);
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

        [NativeTypeName("HRESULT (UINT *, UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, uint*, int> GetSize;

        [NativeTypeName("HRESULT (WICPixelFormatGUID *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, int> GetPixelFormat;

        [NativeTypeName("HRESULT (double *, double *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, double*, double*, int> GetResolution;

        [NativeTypeName("HRESULT (IWICPalette *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IWICPalette*, int> CopyPalette;

        [NativeTypeName("HRESULT (const WICRect *, UINT, UINT, BYTE *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, WICRect*, uint, uint, byte*, int> CopyPixels;

        [NativeTypeName("HRESULT (IWICBitmapSource *, REFWICPixelFormatGUID, FLOAT, FLOAT, WICBitmapToneMappingMode) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IWICBitmapSource*, Guid*, float, float, WICBitmapToneMappingMode, int> InitializeForHdrTarget;

        [NativeTypeName("HRESULT (IWICBitmapSource *, REFWICPixelFormatGUID, WICBitmapToneMappingMode) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IWICBitmapSource*, Guid*, WICBitmapToneMappingMode, int> InitializeForSdrTarget;
    }
}
