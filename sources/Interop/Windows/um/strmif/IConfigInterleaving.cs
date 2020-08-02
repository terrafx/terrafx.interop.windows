// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("BEE3D220-157B-11D0-BD23-00A0C911CE86")]
    public unsafe partial struct IConfigInterleaving
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IConfigInterleaving*, Guid*, void**, int>)(lpVtbl[0]))((IConfigInterleaving*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IConfigInterleaving*, uint>)(lpVtbl[1]))((IConfigInterleaving*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IConfigInterleaving*, uint>)(lpVtbl[2]))((IConfigInterleaving*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int put_Mode(InterleavingMode mode)
        {
            return ((delegate* stdcall<IConfigInterleaving*, InterleavingMode, int>)(lpVtbl[3]))((IConfigInterleaving*)Unsafe.AsPointer(ref this), mode);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_Mode([NativeTypeName("InterleavingMode *")] InterleavingMode* pMode)
        {
            return ((delegate* stdcall<IConfigInterleaving*, InterleavingMode*, int>)(lpVtbl[4]))((IConfigInterleaving*)Unsafe.AsPointer(ref this), pMode);
        }

        [return: NativeTypeName("HRESULT")]
        public int put_Interleaving([NativeTypeName("const REFERENCE_TIME *")] long* prtInterleave, [NativeTypeName("const REFERENCE_TIME *")] long* prtPreroll)
        {
            return ((delegate* stdcall<IConfigInterleaving*, long*, long*, int>)(lpVtbl[5]))((IConfigInterleaving*)Unsafe.AsPointer(ref this), prtInterleave, prtPreroll);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_Interleaving([NativeTypeName("REFERENCE_TIME *")] long* prtInterleave, [NativeTypeName("REFERENCE_TIME *")] long* prtPreroll)
        {
            return ((delegate* stdcall<IConfigInterleaving*, long*, long*, int>)(lpVtbl[6]))((IConfigInterleaving*)Unsafe.AsPointer(ref this), prtInterleave, prtPreroll);
        }
    }
}
