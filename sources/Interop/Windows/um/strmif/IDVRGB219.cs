// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("58473A19-2BC8-4663-8012-25F81BABDDD1")]
    public unsafe partial struct IDVRGB219
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IDVRGB219*, Guid*, void**, int>)(lpVtbl[0]))((IDVRGB219*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IDVRGB219*, uint>)(lpVtbl[1]))((IDVRGB219*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IDVRGB219*, uint>)(lpVtbl[2]))((IDVRGB219*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetRGB219([NativeTypeName("BOOL")] int bState)
        {
            return ((delegate* stdcall<IDVRGB219*, int, int>)(lpVtbl[3]))((IDVRGB219*)Unsafe.AsPointer(ref this), bState);
        }
    }
}
