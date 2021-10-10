// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("54C39221-8380-11D0-B3F0-00AA003761C5")]
    [NativeTypeName("struct IAMAudioInputMixer : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IAMAudioInputMixer
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IAMAudioInputMixer*, Guid*, void**, int>)(lpVtbl[0]))((IAMAudioInputMixer*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IAMAudioInputMixer*, uint>)(lpVtbl[1]))((IAMAudioInputMixer*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IAMAudioInputMixer*, uint>)(lpVtbl[2]))((IAMAudioInputMixer*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int put_Enable([NativeTypeName("BOOL")] int fEnable)
        {
            return ((delegate* unmanaged<IAMAudioInputMixer*, int, int>)(lpVtbl[3]))((IAMAudioInputMixer*)Unsafe.AsPointer(ref this), fEnable);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int get_Enable([NativeTypeName("BOOL *")] int* pfEnable)
        {
            return ((delegate* unmanaged<IAMAudioInputMixer*, int*, int>)(lpVtbl[4]))((IAMAudioInputMixer*)Unsafe.AsPointer(ref this), pfEnable);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int put_Mono([NativeTypeName("BOOL")] int fMono)
        {
            return ((delegate* unmanaged<IAMAudioInputMixer*, int, int>)(lpVtbl[5]))((IAMAudioInputMixer*)Unsafe.AsPointer(ref this), fMono);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int get_Mono([NativeTypeName("BOOL *")] int* pfMono)
        {
            return ((delegate* unmanaged<IAMAudioInputMixer*, int*, int>)(lpVtbl[6]))((IAMAudioInputMixer*)Unsafe.AsPointer(ref this), pfMono);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int put_MixLevel(double Level)
        {
            return ((delegate* unmanaged<IAMAudioInputMixer*, double, int>)(lpVtbl[7]))((IAMAudioInputMixer*)Unsafe.AsPointer(ref this), Level);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("HRESULT")]
        public int get_MixLevel(double* pLevel)
        {
            return ((delegate* unmanaged<IAMAudioInputMixer*, double*, int>)(lpVtbl[8]))((IAMAudioInputMixer*)Unsafe.AsPointer(ref this), pLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        [return: NativeTypeName("HRESULT")]
        public int put_Pan(double Pan)
        {
            return ((delegate* unmanaged<IAMAudioInputMixer*, double, int>)(lpVtbl[9]))((IAMAudioInputMixer*)Unsafe.AsPointer(ref this), Pan);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        [return: NativeTypeName("HRESULT")]
        public int get_Pan(double* pPan)
        {
            return ((delegate* unmanaged<IAMAudioInputMixer*, double*, int>)(lpVtbl[10]))((IAMAudioInputMixer*)Unsafe.AsPointer(ref this), pPan);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        [return: NativeTypeName("HRESULT")]
        public int put_Loudness([NativeTypeName("BOOL")] int fLoudness)
        {
            return ((delegate* unmanaged<IAMAudioInputMixer*, int, int>)(lpVtbl[11]))((IAMAudioInputMixer*)Unsafe.AsPointer(ref this), fLoudness);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        [return: NativeTypeName("HRESULT")]
        public int get_Loudness([NativeTypeName("BOOL *")] int* pfLoudness)
        {
            return ((delegate* unmanaged<IAMAudioInputMixer*, int*, int>)(lpVtbl[12]))((IAMAudioInputMixer*)Unsafe.AsPointer(ref this), pfLoudness);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        [return: NativeTypeName("HRESULT")]
        public int put_Treble(double Treble)
        {
            return ((delegate* unmanaged<IAMAudioInputMixer*, double, int>)(lpVtbl[13]))((IAMAudioInputMixer*)Unsafe.AsPointer(ref this), Treble);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        [return: NativeTypeName("HRESULT")]
        public int get_Treble(double* pTreble)
        {
            return ((delegate* unmanaged<IAMAudioInputMixer*, double*, int>)(lpVtbl[14]))((IAMAudioInputMixer*)Unsafe.AsPointer(ref this), pTreble);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        [return: NativeTypeName("HRESULT")]
        public int get_TrebleRange(double* pRange)
        {
            return ((delegate* unmanaged<IAMAudioInputMixer*, double*, int>)(lpVtbl[15]))((IAMAudioInputMixer*)Unsafe.AsPointer(ref this), pRange);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        [return: NativeTypeName("HRESULT")]
        public int put_Bass(double Bass)
        {
            return ((delegate* unmanaged<IAMAudioInputMixer*, double, int>)(lpVtbl[16]))((IAMAudioInputMixer*)Unsafe.AsPointer(ref this), Bass);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        [return: NativeTypeName("HRESULT")]
        public int get_Bass(double* pBass)
        {
            return ((delegate* unmanaged<IAMAudioInputMixer*, double*, int>)(lpVtbl[17]))((IAMAudioInputMixer*)Unsafe.AsPointer(ref this), pBass);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        [return: NativeTypeName("HRESULT")]
        public int get_BassRange(double* pRange)
        {
            return ((delegate* unmanaged<IAMAudioInputMixer*, double*, int>)(lpVtbl[18]))((IAMAudioInputMixer*)Unsafe.AsPointer(ref this), pRange);
        }
    }
}
