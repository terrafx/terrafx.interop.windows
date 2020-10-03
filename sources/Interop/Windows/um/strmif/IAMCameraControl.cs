// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("C6E13370-30AC-11D0-A18C-00A0C9118956")]
    [NativeTypeName("struct IAMCameraControl : IUnknown")]
    public unsafe partial struct IAMCameraControl
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IAMCameraControl*, Guid*, void**, int>)(lpVtbl[0]))((IAMCameraControl*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IAMCameraControl*, uint>)(lpVtbl[1]))((IAMCameraControl*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IAMCameraControl*, uint>)(lpVtbl[2]))((IAMCameraControl*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRange([NativeTypeName("long")] int Property, [NativeTypeName("long *")] int* pMin, [NativeTypeName("long *")] int* pMax, [NativeTypeName("long *")] int* pSteppingDelta, [NativeTypeName("long *")] int* pDefault, [NativeTypeName("long *")] int* pCapsFlags)
        {
            return ((delegate* unmanaged<IAMCameraControl*, int, int*, int*, int*, int*, int*, int>)(lpVtbl[3]))((IAMCameraControl*)Unsafe.AsPointer(ref this), Property, pMin, pMax, pSteppingDelta, pDefault, pCapsFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Set([NativeTypeName("long")] int Property, [NativeTypeName("long")] int lValue, [NativeTypeName("long")] int Flags)
        {
            return ((delegate* unmanaged<IAMCameraControl*, int, int, int, int>)(lpVtbl[4]))((IAMCameraControl*)Unsafe.AsPointer(ref this), Property, lValue, Flags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Get([NativeTypeName("long")] int Property, [NativeTypeName("long *")] int* lValue, [NativeTypeName("long *")] int* Flags)
        {
            return ((delegate* unmanaged<IAMCameraControl*, int, int*, int*, int>)(lpVtbl[5]))((IAMCameraControl*)Unsafe.AsPointer(ref this), Property, lValue, Flags);
        }
    }
}
