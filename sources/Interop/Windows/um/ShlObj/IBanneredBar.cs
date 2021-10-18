// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShlObj.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("596A9A94-013E-11D1-8D34-00A0C90F2719")]
    [NativeTypeName("struct IBanneredBar : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IBanneredBar
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IBanneredBar*, Guid*, void**, int>)(lpVtbl[0]))((IBanneredBar*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IBanneredBar*, uint>)(lpVtbl[1]))((IBanneredBar*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IBanneredBar*, uint>)(lpVtbl[2]))((IBanneredBar*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int SetIconSize([NativeTypeName("DWORD")] uint iIcon)
        {
            return ((delegate* unmanaged<IBanneredBar*, uint, int>)(lpVtbl[3]))((IBanneredBar*)Unsafe.AsPointer(ref this), iIcon);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int GetIconSize([NativeTypeName("DWORD *")] uint* piIcon)
        {
            return ((delegate* unmanaged<IBanneredBar*, uint*, int>)(lpVtbl[4]))((IBanneredBar*)Unsafe.AsPointer(ref this), piIcon);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int SetBitmap([NativeTypeName("HBITMAP")] IntPtr hBitmap)
        {
            return ((delegate* unmanaged<IBanneredBar*, IntPtr, int>)(lpVtbl[5]))((IBanneredBar*)Unsafe.AsPointer(ref this), hBitmap);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int GetBitmap([NativeTypeName("HBITMAP *")] IntPtr* phBitmap)
        {
            return ((delegate* unmanaged<IBanneredBar*, IntPtr*, int>)(lpVtbl[6]))((IBanneredBar*)Unsafe.AsPointer(ref this), phBitmap);
        }
    }
}
