// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("436EEE9C-264F-4242-90E1-4E330C107512")]
    public unsafe partial struct IMpeg2Demultiplexer
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IMpeg2Demultiplexer*, Guid*, void**, int>)(lpVtbl[0]))((IMpeg2Demultiplexer*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IMpeg2Demultiplexer*, uint>)(lpVtbl[1]))((IMpeg2Demultiplexer*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IMpeg2Demultiplexer*, uint>)(lpVtbl[2]))((IMpeg2Demultiplexer*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateOutputPin([NativeTypeName("AM_MEDIA_TYPE *")] AM_MEDIA_TYPE* pMediaType, [NativeTypeName("LPWSTR")] ushort* pszPinName, [NativeTypeName("IPin **")] IPin** ppIPin)
        {
            return ((delegate* stdcall<IMpeg2Demultiplexer*, AM_MEDIA_TYPE*, ushort*, IPin**, int>)(lpVtbl[3]))((IMpeg2Demultiplexer*)Unsafe.AsPointer(ref this), pMediaType, pszPinName, ppIPin);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetOutputPinMediaType([NativeTypeName("LPWSTR")] ushort* pszPinName, [NativeTypeName("AM_MEDIA_TYPE *")] AM_MEDIA_TYPE* pMediaType)
        {
            return ((delegate* stdcall<IMpeg2Demultiplexer*, ushort*, AM_MEDIA_TYPE*, int>)(lpVtbl[4]))((IMpeg2Demultiplexer*)Unsafe.AsPointer(ref this), pszPinName, pMediaType);
        }

        [return: NativeTypeName("HRESULT")]
        public int DeleteOutputPin([NativeTypeName("LPWSTR")] ushort* pszPinName)
        {
            return ((delegate* stdcall<IMpeg2Demultiplexer*, ushort*, int>)(lpVtbl[5]))((IMpeg2Demultiplexer*)Unsafe.AsPointer(ref this), pszPinName);
        }
    }
}
