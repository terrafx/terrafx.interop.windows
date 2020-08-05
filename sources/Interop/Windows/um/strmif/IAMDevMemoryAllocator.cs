// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("C6545BF0-E76B-11D0-BD52-00A0C911CE86")]
    [NativeTypeName("struct IAMDevMemoryAllocator : IUnknown")]
    public unsafe partial struct IAMDevMemoryAllocator
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IAMDevMemoryAllocator*, Guid*, void**, int>)(lpVtbl[0]))((IAMDevMemoryAllocator*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IAMDevMemoryAllocator*, uint>)(lpVtbl[1]))((IAMDevMemoryAllocator*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IAMDevMemoryAllocator*, uint>)(lpVtbl[2]))((IAMDevMemoryAllocator*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetInfo([NativeTypeName("DWORD *")] uint* pdwcbTotalFree, [NativeTypeName("DWORD *")] uint* pdwcbLargestFree, [NativeTypeName("DWORD *")] uint* pdwcbTotalMemory, [NativeTypeName("DWORD *")] uint* pdwcbMinimumChunk)
        {
            return ((delegate* stdcall<IAMDevMemoryAllocator*, uint*, uint*, uint*, uint*, int>)(lpVtbl[3]))((IAMDevMemoryAllocator*)Unsafe.AsPointer(ref this), pdwcbTotalFree, pdwcbLargestFree, pdwcbTotalMemory, pdwcbMinimumChunk);
        }

        [return: NativeTypeName("HRESULT")]
        public int CheckMemory([NativeTypeName("const BYTE *")] byte* pBuffer)
        {
            return ((delegate* stdcall<IAMDevMemoryAllocator*, byte*, int>)(lpVtbl[4]))((IAMDevMemoryAllocator*)Unsafe.AsPointer(ref this), pBuffer);
        }

        [return: NativeTypeName("HRESULT")]
        public int Alloc([NativeTypeName("BYTE **")] byte** ppBuffer, [NativeTypeName("DWORD *")] uint* pdwcbBuffer)
        {
            return ((delegate* stdcall<IAMDevMemoryAllocator*, byte**, uint*, int>)(lpVtbl[5]))((IAMDevMemoryAllocator*)Unsafe.AsPointer(ref this), ppBuffer, pdwcbBuffer);
        }

        [return: NativeTypeName("HRESULT")]
        public int Free([NativeTypeName("BYTE *")] byte* pBuffer)
        {
            return ((delegate* stdcall<IAMDevMemoryAllocator*, byte*, int>)(lpVtbl[6]))((IAMDevMemoryAllocator*)Unsafe.AsPointer(ref this), pBuffer);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDevMemoryObject([NativeTypeName("IUnknown **")] IUnknown** ppUnkInnner, [NativeTypeName("IUnknown *")] IUnknown* pUnkOuter)
        {
            return ((delegate* stdcall<IAMDevMemoryAllocator*, IUnknown**, IUnknown*, int>)(lpVtbl[7]))((IAMDevMemoryAllocator*)Unsafe.AsPointer(ref this), ppUnkInnner, pUnkOuter);
        }
    }
}
