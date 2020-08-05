// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("C0DFF467-D499-4986-972B-E1D9090FA941")]
    [NativeTypeName("struct IAMDecoderCaps : IUnknown")]
    public unsafe partial struct IAMDecoderCaps
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IAMDecoderCaps*, Guid*, void**, int>)(lpVtbl[0]))((IAMDecoderCaps*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IAMDecoderCaps*, uint>)(lpVtbl[1]))((IAMDecoderCaps*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IAMDecoderCaps*, uint>)(lpVtbl[2]))((IAMDecoderCaps*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDecoderCaps([NativeTypeName("DWORD")] uint dwCapIndex, [NativeTypeName("DWORD *")] uint* lpdwCap)
        {
            return ((delegate* stdcall<IAMDecoderCaps*, uint, uint*, int>)(lpVtbl[3]))((IAMDecoderCaps*)Unsafe.AsPointer(ref this), dwCapIndex, lpdwCap);
        }
    }
}
