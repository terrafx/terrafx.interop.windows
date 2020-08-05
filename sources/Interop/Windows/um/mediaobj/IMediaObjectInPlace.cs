// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mediaobj.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("651B9AD0-0FC7-4AA9-9538-D89931010741")]
    [NativeTypeName("struct IMediaObjectInPlace : IUnknown")]
    public unsafe partial struct IMediaObjectInPlace
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IMediaObjectInPlace*, Guid*, void**, int>)(lpVtbl[0]))((IMediaObjectInPlace*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IMediaObjectInPlace*, uint>)(lpVtbl[1]))((IMediaObjectInPlace*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IMediaObjectInPlace*, uint>)(lpVtbl[2]))((IMediaObjectInPlace*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int Process([NativeTypeName("ULONG")] uint ulSize, [NativeTypeName("BYTE *")] byte* pData, [NativeTypeName("REFERENCE_TIME")] long refTimeStart, [NativeTypeName("DWORD")] uint dwFlags)
        {
            return ((delegate* stdcall<IMediaObjectInPlace*, uint, byte*, long, uint, int>)(lpVtbl[3]))((IMediaObjectInPlace*)Unsafe.AsPointer(ref this), ulSize, pData, refTimeStart, dwFlags);
        }

        [return: NativeTypeName("HRESULT")]
        public int Clone([NativeTypeName("IMediaObjectInPlace **")] IMediaObjectInPlace** ppMediaObject)
        {
            return ((delegate* stdcall<IMediaObjectInPlace*, IMediaObjectInPlace**, int>)(lpVtbl[4]))((IMediaObjectInPlace*)Unsafe.AsPointer(ref this), ppMediaObject);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetLatency([NativeTypeName("REFERENCE_TIME *")] long* pLatencyTime)
        {
            return ((delegate* stdcall<IMediaObjectInPlace*, long*, int>)(lpVtbl[5]))((IMediaObjectInPlace*)Unsafe.AsPointer(ref this), pLatencyTime);
        }
    }
}
