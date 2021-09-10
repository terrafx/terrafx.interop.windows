// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("60D32930-13DA-11D3-9EC6-C4FCAEF5C7BE")]
    [NativeTypeName("struct IAMVideoDecimationProperties : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IAMVideoDecimationProperties
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IAMVideoDecimationProperties*, Guid*, void**, int>)(lpVtbl[0]))((IAMVideoDecimationProperties*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IAMVideoDecimationProperties*, uint>)(lpVtbl[1]))((IAMVideoDecimationProperties*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IAMVideoDecimationProperties*, uint>)(lpVtbl[2]))((IAMVideoDecimationProperties*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int QueryDecimationUsage(DECIMATION_USAGE* lpUsage)
        {
            return ((delegate* unmanaged<IAMVideoDecimationProperties*, DECIMATION_USAGE*, int>)(lpVtbl[3]))((IAMVideoDecimationProperties*)Unsafe.AsPointer(ref this), lpUsage);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int SetDecimationUsage(DECIMATION_USAGE Usage)
        {
            return ((delegate* unmanaged<IAMVideoDecimationProperties*, DECIMATION_USAGE, int>)(lpVtbl[4]))((IAMVideoDecimationProperties*)Unsafe.AsPointer(ref this), Usage);
        }
    }
}
