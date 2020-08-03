// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("86303D6D-1C4A-4087-AB42-F711167048EF")]
    public unsafe partial struct IDvdState
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IDvdState*, Guid*, void**, int>)(lpVtbl[0]))((IDvdState*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IDvdState*, uint>)(lpVtbl[1]))((IDvdState*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IDvdState*, uint>)(lpVtbl[2]))((IDvdState*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDiscID([NativeTypeName("ULONGLONG *")] ulong* pullUniqueID)
        {
            return ((delegate* stdcall<IDvdState*, ulong*, int>)(lpVtbl[3]))((IDvdState*)Unsafe.AsPointer(ref this), pullUniqueID);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetParentalLevel([NativeTypeName("ULONG *")] uint* pulParentalLevel)
        {
            return ((delegate* stdcall<IDvdState*, uint*, int>)(lpVtbl[4]))((IDvdState*)Unsafe.AsPointer(ref this), pulParentalLevel);
        }
    }
}
