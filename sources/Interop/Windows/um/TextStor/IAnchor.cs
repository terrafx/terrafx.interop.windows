// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/TextStor.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("0FEB7E34-5A60-4356-8EF7-ABDEC2FF7CF8")]
    [NativeTypeName("struct IAnchor : IUnknown")]
    public unsafe partial struct IAnchor
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IAnchor*, Guid*, void**, int>)(lpVtbl[0]))((IAnchor*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IAnchor*, uint>)(lpVtbl[1]))((IAnchor*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IAnchor*, uint>)(lpVtbl[2]))((IAnchor*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetGravity(TsGravity gravity)
        {
            return ((delegate* unmanaged<IAnchor*, TsGravity, int>)(lpVtbl[3]))((IAnchor*)Unsafe.AsPointer(ref this), gravity);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetGravity([NativeTypeName("TsGravity *")] TsGravity* pgravity)
        {
            return ((delegate* unmanaged<IAnchor*, TsGravity*, int>)(lpVtbl[4]))((IAnchor*)Unsafe.AsPointer(ref this), pgravity);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int IsEqual([NativeTypeName("IAnchor *")] IAnchor* paWith, [NativeTypeName("BOOL *")] int* pfEqual)
        {
            return ((delegate* unmanaged<IAnchor*, IAnchor*, int*, int>)(lpVtbl[5]))((IAnchor*)Unsafe.AsPointer(ref this), paWith, pfEqual);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Compare([NativeTypeName("IAnchor *")] IAnchor* paWith, [NativeTypeName("LONG *")] int* plResult)
        {
            return ((delegate* unmanaged<IAnchor*, IAnchor*, int*, int>)(lpVtbl[6]))((IAnchor*)Unsafe.AsPointer(ref this), paWith, plResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Shift([NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("LONG")] int cchReq, [NativeTypeName("LONG *")] int* pcch, [NativeTypeName("IAnchor *")] IAnchor* paHaltAnchor)
        {
            return ((delegate* unmanaged<IAnchor*, uint, int, int*, IAnchor*, int>)(lpVtbl[7]))((IAnchor*)Unsafe.AsPointer(ref this), dwFlags, cchReq, pcch, paHaltAnchor);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ShiftTo([NativeTypeName("IAnchor *")] IAnchor* paSite)
        {
            return ((delegate* unmanaged<IAnchor*, IAnchor*, int>)(lpVtbl[8]))((IAnchor*)Unsafe.AsPointer(ref this), paSite);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ShiftRegion([NativeTypeName("DWORD")] uint dwFlags, TsShiftDir dir, [NativeTypeName("BOOL *")] int* pfNoRegion)
        {
            return ((delegate* unmanaged<IAnchor*, uint, TsShiftDir, int*, int>)(lpVtbl[9]))((IAnchor*)Unsafe.AsPointer(ref this), dwFlags, dir, pfNoRegion);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetChangeHistoryMask([NativeTypeName("DWORD")] uint dwMask)
        {
            return ((delegate* unmanaged<IAnchor*, uint, int>)(lpVtbl[10]))((IAnchor*)Unsafe.AsPointer(ref this), dwMask);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetChangeHistory([NativeTypeName("DWORD *")] uint* pdwHistory)
        {
            return ((delegate* unmanaged<IAnchor*, uint*, int>)(lpVtbl[11]))((IAnchor*)Unsafe.AsPointer(ref this), pdwHistory);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ClearChangeHistory()
        {
            return ((delegate* unmanaged<IAnchor*, int>)(lpVtbl[12]))((IAnchor*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Clone([NativeTypeName("IAnchor **")] IAnchor** ppaClone)
        {
            return ((delegate* unmanaged<IAnchor*, IAnchor**, int>)(lpVtbl[13]))((IAnchor*)Unsafe.AsPointer(ref this), ppaClone);
        }
    }
}
