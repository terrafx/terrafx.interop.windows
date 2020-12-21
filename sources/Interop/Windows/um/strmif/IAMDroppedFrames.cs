// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("C6E13344-30AC-11D0-A18C-00A0C9118956")]
    [NativeTypeName("struct IAMDroppedFrames : IUnknown")]
    public unsafe partial struct IAMDroppedFrames
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<IAMDroppedFrames*, Guid*, void**, int>)(lpVtbl[0]))((IAMDroppedFrames*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<IAMDroppedFrames*, uint>)(lpVtbl[1]))((IAMDroppedFrames*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<IAMDroppedFrames*, uint>)(lpVtbl[2]))((IAMDroppedFrames*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetNumDropped([NativeTypeName("long *")] int* plDropped)
        {
            return ((delegate* unmanaged[Stdcall]<IAMDroppedFrames*, int*, int>)(lpVtbl[3]))((IAMDroppedFrames*)Unsafe.AsPointer(ref this), plDropped);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetNumNotDropped([NativeTypeName("long *")] int* plNotDropped)
        {
            return ((delegate* unmanaged[Stdcall]<IAMDroppedFrames*, int*, int>)(lpVtbl[4]))((IAMDroppedFrames*)Unsafe.AsPointer(ref this), plNotDropped);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetDroppedInfo([NativeTypeName("long")] int lSize, [NativeTypeName("long *")] int* plArray, [NativeTypeName("long *")] int* plNumCopied)
        {
            return ((delegate* unmanaged[Stdcall]<IAMDroppedFrames*, int, int*, int*, int>)(lpVtbl[5]))((IAMDroppedFrames*)Unsafe.AsPointer(ref this), lSize, plArray, plNumCopied);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetAverageFrameSize([NativeTypeName("long *")] int* plAverageSize)
        {
            return ((delegate* unmanaged[Stdcall]<IAMDroppedFrames*, int*, int>)(lpVtbl[6]))((IAMDroppedFrames*)Unsafe.AsPointer(ref this), plAverageSize);
        }
    }
}
