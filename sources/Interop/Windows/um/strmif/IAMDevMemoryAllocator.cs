// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("C6545BF0-E76B-11D0-BD52-00A0C911CE86")]
    [NativeTypeName("struct IAMDevMemoryAllocator : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IAMDevMemoryAllocator
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IAMDevMemoryAllocator*, Guid*, void**, int>)(lpVtbl[0]))((IAMDevMemoryAllocator*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IAMDevMemoryAllocator*, uint>)(lpVtbl[1]))((IAMDevMemoryAllocator*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IAMDevMemoryAllocator*, uint>)(lpVtbl[2]))((IAMDevMemoryAllocator*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int GetInfo([NativeTypeName("DWORD *")] uint* pdwcbTotalFree, [NativeTypeName("DWORD *")] uint* pdwcbLargestFree, [NativeTypeName("DWORD *")] uint* pdwcbTotalMemory, [NativeTypeName("DWORD *")] uint* pdwcbMinimumChunk)
        {
            return ((delegate* unmanaged<IAMDevMemoryAllocator*, uint*, uint*, uint*, uint*, int>)(lpVtbl[3]))((IAMDevMemoryAllocator*)Unsafe.AsPointer(ref this), pdwcbTotalFree, pdwcbLargestFree, pdwcbTotalMemory, pdwcbMinimumChunk);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int CheckMemory([NativeTypeName("const BYTE *")] byte* pBuffer)
        {
            return ((delegate* unmanaged<IAMDevMemoryAllocator*, byte*, int>)(lpVtbl[4]))((IAMDevMemoryAllocator*)Unsafe.AsPointer(ref this), pBuffer);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int Alloc([NativeTypeName("BYTE **")] byte** ppBuffer, [NativeTypeName("DWORD *")] uint* pdwcbBuffer)
        {
            return ((delegate* unmanaged<IAMDevMemoryAllocator*, byte**, uint*, int>)(lpVtbl[5]))((IAMDevMemoryAllocator*)Unsafe.AsPointer(ref this), ppBuffer, pdwcbBuffer);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int Free([NativeTypeName("BYTE *")] byte* pBuffer)
        {
            return ((delegate* unmanaged<IAMDevMemoryAllocator*, byte*, int>)(lpVtbl[6]))((IAMDevMemoryAllocator*)Unsafe.AsPointer(ref this), pBuffer);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int GetDevMemoryObject(IUnknown** ppUnkInnner, IUnknown* pUnkOuter)
        {
            return ((delegate* unmanaged<IAMDevMemoryAllocator*, IUnknown**, IUnknown*, int>)(lpVtbl[7]))((IAMDevMemoryAllocator*)Unsafe.AsPointer(ref this), ppUnkInnner, pUnkOuter);
        }
    }
}
