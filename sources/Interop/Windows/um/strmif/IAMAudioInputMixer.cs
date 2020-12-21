// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("54C39221-8380-11D0-B3F0-00AA003761C5")]
    [NativeTypeName("struct IAMAudioInputMixer : IUnknown")]
    public unsafe partial struct IAMAudioInputMixer
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<IAMAudioInputMixer*, Guid*, void**, int>)(lpVtbl[0]))((IAMAudioInputMixer*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<IAMAudioInputMixer*, uint>)(lpVtbl[1]))((IAMAudioInputMixer*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<IAMAudioInputMixer*, uint>)(lpVtbl[2]))((IAMAudioInputMixer*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_Enable([NativeTypeName("BOOL")] int fEnable)
        {
            return ((delegate* unmanaged[Stdcall]<IAMAudioInputMixer*, int, int>)(lpVtbl[3]))((IAMAudioInputMixer*)Unsafe.AsPointer(ref this), fEnable);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Enable([NativeTypeName("BOOL *")] int* pfEnable)
        {
            return ((delegate* unmanaged[Stdcall]<IAMAudioInputMixer*, int*, int>)(lpVtbl[4]))((IAMAudioInputMixer*)Unsafe.AsPointer(ref this), pfEnable);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_Mono([NativeTypeName("BOOL")] int fMono)
        {
            return ((delegate* unmanaged[Stdcall]<IAMAudioInputMixer*, int, int>)(lpVtbl[5]))((IAMAudioInputMixer*)Unsafe.AsPointer(ref this), fMono);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Mono([NativeTypeName("BOOL *")] int* pfMono)
        {
            return ((delegate* unmanaged[Stdcall]<IAMAudioInputMixer*, int*, int>)(lpVtbl[6]))((IAMAudioInputMixer*)Unsafe.AsPointer(ref this), pfMono);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_MixLevel(double Level)
        {
            return ((delegate* unmanaged[Stdcall]<IAMAudioInputMixer*, double, int>)(lpVtbl[7]))((IAMAudioInputMixer*)Unsafe.AsPointer(ref this), Level);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_MixLevel([NativeTypeName("double *")] double* pLevel)
        {
            return ((delegate* unmanaged[Stdcall]<IAMAudioInputMixer*, double*, int>)(lpVtbl[8]))((IAMAudioInputMixer*)Unsafe.AsPointer(ref this), pLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_Pan(double Pan)
        {
            return ((delegate* unmanaged[Stdcall]<IAMAudioInputMixer*, double, int>)(lpVtbl[9]))((IAMAudioInputMixer*)Unsafe.AsPointer(ref this), Pan);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Pan([NativeTypeName("double *")] double* pPan)
        {
            return ((delegate* unmanaged[Stdcall]<IAMAudioInputMixer*, double*, int>)(lpVtbl[10]))((IAMAudioInputMixer*)Unsafe.AsPointer(ref this), pPan);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_Loudness([NativeTypeName("BOOL")] int fLoudness)
        {
            return ((delegate* unmanaged[Stdcall]<IAMAudioInputMixer*, int, int>)(lpVtbl[11]))((IAMAudioInputMixer*)Unsafe.AsPointer(ref this), fLoudness);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Loudness([NativeTypeName("BOOL *")] int* pfLoudness)
        {
            return ((delegate* unmanaged[Stdcall]<IAMAudioInputMixer*, int*, int>)(lpVtbl[12]))((IAMAudioInputMixer*)Unsafe.AsPointer(ref this), pfLoudness);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_Treble(double Treble)
        {
            return ((delegate* unmanaged[Stdcall]<IAMAudioInputMixer*, double, int>)(lpVtbl[13]))((IAMAudioInputMixer*)Unsafe.AsPointer(ref this), Treble);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Treble([NativeTypeName("double *")] double* pTreble)
        {
            return ((delegate* unmanaged[Stdcall]<IAMAudioInputMixer*, double*, int>)(lpVtbl[14]))((IAMAudioInputMixer*)Unsafe.AsPointer(ref this), pTreble);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_TrebleRange([NativeTypeName("double *")] double* pRange)
        {
            return ((delegate* unmanaged[Stdcall]<IAMAudioInputMixer*, double*, int>)(lpVtbl[15]))((IAMAudioInputMixer*)Unsafe.AsPointer(ref this), pRange);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_Bass(double Bass)
        {
            return ((delegate* unmanaged[Stdcall]<IAMAudioInputMixer*, double, int>)(lpVtbl[16]))((IAMAudioInputMixer*)Unsafe.AsPointer(ref this), Bass);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Bass([NativeTypeName("double *")] double* pBass)
        {
            return ((delegate* unmanaged[Stdcall]<IAMAudioInputMixer*, double*, int>)(lpVtbl[17]))((IAMAudioInputMixer*)Unsafe.AsPointer(ref this), pBass);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_BassRange([NativeTypeName("double *")] double* pRange)
        {
            return ((delegate* unmanaged[Stdcall]<IAMAudioInputMixer*, double*, int>)(lpVtbl[18]))((IAMAudioInputMixer*)Unsafe.AsPointer(ref this), pRange);
        }
    }
}
