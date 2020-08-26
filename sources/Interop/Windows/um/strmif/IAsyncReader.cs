// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("56A868AA-0AD4-11CE-B03A-0020AF0BA770")]
    [NativeTypeName("struct IAsyncReader : IUnknown")]
    public unsafe partial struct IAsyncReader
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IAsyncReader*, Guid*, void**, int>)(lpVtbl[0]))((IAsyncReader*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IAsyncReader*, uint>)(lpVtbl[1]))((IAsyncReader*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IAsyncReader*, uint>)(lpVtbl[2]))((IAsyncReader*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int RequestAllocator([NativeTypeName("IMemAllocator *")] IMemAllocator* pPreferred, [NativeTypeName("ALLOCATOR_PROPERTIES *")] ALLOCATOR_PROPERTIES* pProps, [NativeTypeName("IMemAllocator **")] IMemAllocator** ppActual)
        {
            return ((delegate* stdcall<IAsyncReader*, IMemAllocator*, ALLOCATOR_PROPERTIES*, IMemAllocator**, int>)(lpVtbl[3]))((IAsyncReader*)Unsafe.AsPointer(ref this), pPreferred, pProps, ppActual);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Request([NativeTypeName("IMediaSample *")] IMediaSample* pSample, [NativeTypeName("DWORD_PTR")] nuint dwUser)
        {
            return ((delegate* stdcall<IAsyncReader*, IMediaSample*, nuint, int>)(lpVtbl[4]))((IAsyncReader*)Unsafe.AsPointer(ref this), pSample, dwUser);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int WaitForNext([NativeTypeName("DWORD")] uint dwTimeout, [NativeTypeName("IMediaSample **")] IMediaSample** ppSample, [NativeTypeName("DWORD_PTR *")] nuint* pdwUser)
        {
            return ((delegate* stdcall<IAsyncReader*, uint, IMediaSample**, nuint*, int>)(lpVtbl[5]))((IAsyncReader*)Unsafe.AsPointer(ref this), dwTimeout, ppSample, pdwUser);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SyncReadAligned([NativeTypeName("IMediaSample *")] IMediaSample* pSample)
        {
            return ((delegate* stdcall<IAsyncReader*, IMediaSample*, int>)(lpVtbl[6]))((IAsyncReader*)Unsafe.AsPointer(ref this), pSample);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SyncRead([NativeTypeName("LONGLONG")] long llPosition, [NativeTypeName("LONG")] int lLength, [NativeTypeName("BYTE *")] byte* pBuffer)
        {
            return ((delegate* stdcall<IAsyncReader*, long, int, byte*, int>)(lpVtbl[7]))((IAsyncReader*)Unsafe.AsPointer(ref this), llPosition, lLength, pBuffer);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Length([NativeTypeName("LONGLONG *")] long* pTotal, [NativeTypeName("LONGLONG *")] long* pAvailable)
        {
            return ((delegate* stdcall<IAsyncReader*, long*, long*, int>)(lpVtbl[8]))((IAsyncReader*)Unsafe.AsPointer(ref this), pTotal, pAvailable);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int BeginFlush()
        {
            return ((delegate* stdcall<IAsyncReader*, int>)(lpVtbl[9]))((IAsyncReader*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int EndFlush()
        {
            return ((delegate* stdcall<IAsyncReader*, int>)(lpVtbl[10]))((IAsyncReader*)Unsafe.AsPointer(ref this));
        }
    }
}
