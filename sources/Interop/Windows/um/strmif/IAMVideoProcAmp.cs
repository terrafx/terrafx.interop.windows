// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("C6E13360-30AC-11D0-A18C-00A0C9118956")]
    public unsafe partial struct IAMVideoProcAmp
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IAMVideoProcAmp*, Guid*, void**, int>)(lpVtbl[0]))((IAMVideoProcAmp*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IAMVideoProcAmp*, uint>)(lpVtbl[1]))((IAMVideoProcAmp*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IAMVideoProcAmp*, uint>)(lpVtbl[2]))((IAMVideoProcAmp*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetRange([NativeTypeName("long")] int Property, [NativeTypeName("long *")] int* pMin, [NativeTypeName("long *")] int* pMax, [NativeTypeName("long *")] int* pSteppingDelta, [NativeTypeName("long *")] int* pDefault, [NativeTypeName("long *")] int* pCapsFlags)
        {
            return ((delegate* stdcall<IAMVideoProcAmp*, int, int*, int*, int*, int*, int*, int>)(lpVtbl[3]))((IAMVideoProcAmp*)Unsafe.AsPointer(ref this), Property, pMin, pMax, pSteppingDelta, pDefault, pCapsFlags);
        }

        [return: NativeTypeName("HRESULT")]
        public int Set([NativeTypeName("long")] int Property, [NativeTypeName("long")] int lValue, [NativeTypeName("long")] int Flags)
        {
            return ((delegate* stdcall<IAMVideoProcAmp*, int, int, int, int>)(lpVtbl[4]))((IAMVideoProcAmp*)Unsafe.AsPointer(ref this), Property, lValue, Flags);
        }

        [return: NativeTypeName("HRESULT")]
        public int Get([NativeTypeName("long")] int Property, [NativeTypeName("long *")] int* lValue, [NativeTypeName("long *")] int* Flags)
        {
            return ((delegate* stdcall<IAMVideoProcAmp*, int, int*, int*, int>)(lpVtbl[5]))((IAMVideoProcAmp*)Unsafe.AsPointer(ref this), Property, lValue, Flags);
        }
    }
}
