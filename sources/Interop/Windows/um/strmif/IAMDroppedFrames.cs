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

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IAMDroppedFrames*, Guid*, void**, int>)(lpVtbl[0]))((IAMDroppedFrames*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IAMDroppedFrames*, uint>)(lpVtbl[1]))((IAMDroppedFrames*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IAMDroppedFrames*, uint>)(lpVtbl[2]))((IAMDroppedFrames*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetNumDropped([NativeTypeName("long *")] int* plDropped)
        {
            return ((delegate* stdcall<IAMDroppedFrames*, int*, int>)(lpVtbl[3]))((IAMDroppedFrames*)Unsafe.AsPointer(ref this), plDropped);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetNumNotDropped([NativeTypeName("long *")] int* plNotDropped)
        {
            return ((delegate* stdcall<IAMDroppedFrames*, int*, int>)(lpVtbl[4]))((IAMDroppedFrames*)Unsafe.AsPointer(ref this), plNotDropped);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDroppedInfo([NativeTypeName("long")] int lSize, [NativeTypeName("long *")] int* plArray, [NativeTypeName("long *")] int* plNumCopied)
        {
            return ((delegate* stdcall<IAMDroppedFrames*, int, int*, int*, int>)(lpVtbl[5]))((IAMDroppedFrames*)Unsafe.AsPointer(ref this), lSize, plArray, plNumCopied);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetAverageFrameSize([NativeTypeName("long *")] int* plAverageSize)
        {
            return ((delegate* stdcall<IAMDroppedFrames*, int*, int>)(lpVtbl[6]))((IAMDroppedFrames*)Unsafe.AsPointer(ref this), plAverageSize);
        }
    }
}
