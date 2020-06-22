// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mediaobj.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("59EFF8B9-938C-4A26-82F2-95CB84CDC837")]
    public unsafe partial struct IMediaBuffer
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IMediaBuffer*, Guid*, void**, int>)(lpVtbl[0]))((IMediaBuffer*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IMediaBuffer*, uint>)(lpVtbl[1]))((IMediaBuffer*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IMediaBuffer*, uint>)(lpVtbl[2]))((IMediaBuffer*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetLength([NativeTypeName("DWORD")] uint cbLength)
        {
            return ((delegate* stdcall<IMediaBuffer*, uint, int>)(lpVtbl[3]))((IMediaBuffer*)Unsafe.AsPointer(ref this), cbLength);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetMaxLength([NativeTypeName("DWORD *")] uint* pcbMaxLength)
        {
            return ((delegate* stdcall<IMediaBuffer*, uint*, int>)(lpVtbl[4]))((IMediaBuffer*)Unsafe.AsPointer(ref this), pcbMaxLength);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetBufferAndLength([NativeTypeName("BYTE **")] byte** ppBuffer, [NativeTypeName("DWORD *")] uint* pcbLength)
        {
            return ((delegate* stdcall<IMediaBuffer*, byte**, uint*, int>)(lpVtbl[5]))((IMediaBuffer*)Unsafe.AsPointer(ref this), ppBuffer, pcbLength);
        }
    }
}
