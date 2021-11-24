// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

[Guid("D18E17A0-AACB-11D0-AFB0-00AA00B67A42")]
[NativeTypeName("struct IDVEnc : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IDVEnc : IDVEnc.Interface
{
    public void** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDVEnc*, Guid*, void**, int>)(lpVtbl[0]))((IDVEnc*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IDVEnc*, uint>)(lpVtbl[1]))((IDVEnc*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDVEnc*, uint>)(lpVtbl[2]))((IDVEnc*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT get_IFormatResolution(int* VideoFormat, int* DVFormat, int* Resolution, byte fDVInfo, DVINFO* sDVInfo)
    {
        return ((delegate* unmanaged<IDVEnc*, int*, int*, int*, byte, DVINFO*, int>)(lpVtbl[3]))((IDVEnc*)Unsafe.AsPointer(ref this), VideoFormat, DVFormat, Resolution, fDVInfo, sDVInfo);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT put_IFormatResolution(int VideoFormat, int DVFormat, int Resolution, byte fDVInfo, DVINFO* sDVInfo)
    {
        return ((delegate* unmanaged<IDVEnc*, int, int, int, byte, DVINFO*, int>)(lpVtbl[4]))((IDVEnc*)Unsafe.AsPointer(ref this), VideoFormat, DVFormat, Resolution, fDVInfo, sDVInfo);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT get_IFormatResolution(int* VideoFormat, int* DVFormat, int* Resolution, byte fDVInfo, DVINFO* sDVInfo);

        [VtblIndex(4)]
        HRESULT put_IFormatResolution(int VideoFormat, int DVFormat, int Resolution, byte fDVInfo, DVINFO* sDVInfo);
    }

    public partial struct Vtbl
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<IDVEnc*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<IDVEnc*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<IDVEnc*, uint> Release;

        [NativeTypeName("HRESULT (int *, int *, int *, BYTE, DVINFO *) __attribute__((stdcall))")]
        public delegate* unmanaged<IDVEnc*, int*, int*, int*, byte, DVINFO*, int> get_IFormatResolution;

        [NativeTypeName("HRESULT (int, int, int, BYTE, DVINFO *) __attribute__((stdcall))")]
        public delegate* unmanaged<IDVEnc*, int, int, int, byte, DVINFO*, int> put_IFormatResolution;
    }
}
