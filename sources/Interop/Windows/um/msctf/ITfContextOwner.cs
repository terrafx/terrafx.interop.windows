// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/msctf.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("AA80E80C-2021-11D2-93E0-0060B067B86E")]
    [NativeTypeName("struct ITfContextOwner : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct ITfContextOwner
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ITfContextOwner*, Guid*, void**, int>)(lpVtbl[0]))((ITfContextOwner*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ITfContextOwner*, uint>)(lpVtbl[1]))((ITfContextOwner*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ITfContextOwner*, uint>)(lpVtbl[2]))((ITfContextOwner*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int GetACPFromPoint([NativeTypeName("const POINT *")] POINT* ptScreen, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("LONG *")] int* pacp)
        {
            return ((delegate* unmanaged<ITfContextOwner*, POINT*, uint, int*, int>)(lpVtbl[3]))((ITfContextOwner*)Unsafe.AsPointer(ref this), ptScreen, dwFlags, pacp);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int GetTextExt([NativeTypeName("LONG")] int acpStart, [NativeTypeName("LONG")] int acpEnd, RECT* prc, [NativeTypeName("BOOL *")] int* pfClipped)
        {
            return ((delegate* unmanaged<ITfContextOwner*, int, int, RECT*, int*, int>)(lpVtbl[4]))((ITfContextOwner*)Unsafe.AsPointer(ref this), acpStart, acpEnd, prc, pfClipped);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int GetScreenExt(RECT* prc)
        {
            return ((delegate* unmanaged<ITfContextOwner*, RECT*, int>)(lpVtbl[5]))((ITfContextOwner*)Unsafe.AsPointer(ref this), prc);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int GetStatus([NativeTypeName("TF_STATUS *")] TS_STATUS* pdcs)
        {
            return ((delegate* unmanaged<ITfContextOwner*, TS_STATUS*, int>)(lpVtbl[6]))((ITfContextOwner*)Unsafe.AsPointer(ref this), pdcs);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int GetWnd([NativeTypeName("HWND *")] IntPtr* phwnd)
        {
            return ((delegate* unmanaged<ITfContextOwner*, IntPtr*, int>)(lpVtbl[7]))((ITfContextOwner*)Unsafe.AsPointer(ref this), phwnd);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("HRESULT")]
        public int GetAttribute([NativeTypeName("const GUID &")] Guid* rguidAttribute, VARIANT* pvarValue)
        {
            return ((delegate* unmanaged<ITfContextOwner*, Guid*, VARIANT*, int>)(lpVtbl[8]))((ITfContextOwner*)Unsafe.AsPointer(ref this), rguidAttribute, pvarValue);
        }
    }
}
