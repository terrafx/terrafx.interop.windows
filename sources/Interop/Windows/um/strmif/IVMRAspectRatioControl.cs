// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("EDE80B5C-BAD6-4623-B537-65586C9F8DFD")]
    [NativeTypeName("struct IVMRAspectRatioControl : IUnknown")]
    public unsafe partial struct IVMRAspectRatioControl
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IVMRAspectRatioControl*, Guid*, void**, int>)(lpVtbl[0]))((IVMRAspectRatioControl*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IVMRAspectRatioControl*, uint>)(lpVtbl[1]))((IVMRAspectRatioControl*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IVMRAspectRatioControl*, uint>)(lpVtbl[2]))((IVMRAspectRatioControl*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetAspectRatioMode([NativeTypeName("LPDWORD")] uint* lpdwARMode)
        {
            return ((delegate* stdcall<IVMRAspectRatioControl*, uint*, int>)(lpVtbl[3]))((IVMRAspectRatioControl*)Unsafe.AsPointer(ref this), lpdwARMode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetAspectRatioMode([NativeTypeName("DWORD")] uint dwARMode)
        {
            return ((delegate* stdcall<IVMRAspectRatioControl*, uint, int>)(lpVtbl[4]))((IVMRAspectRatioControl*)Unsafe.AsPointer(ref this), dwARMode);
        }
    }
}
