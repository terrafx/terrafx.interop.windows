// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("DE5BF786-477A-11D2-839D-00C04FD918D0")]
    [NativeTypeName("struct IDragSourceHelper : IUnknown")]
    public unsafe partial struct IDragSourceHelper
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDragSourceHelper*, Guid*, void**, int>)(lpVtbl[0]))((IDragSourceHelper*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDragSourceHelper*, uint>)(lpVtbl[1]))((IDragSourceHelper*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDragSourceHelper*, uint>)(lpVtbl[2]))((IDragSourceHelper*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int InitializeFromBitmap([NativeTypeName("LPSHDRAGIMAGE")] SHDRAGIMAGE* pshdi, IDataObject* pDataObject)
        {
            return ((delegate* unmanaged<IDragSourceHelper*, SHDRAGIMAGE*, IDataObject*, int>)(lpVtbl[3]))((IDragSourceHelper*)Unsafe.AsPointer(ref this), pshdi, pDataObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int InitializeFromWindow([NativeTypeName("HWND")] IntPtr hwnd, POINT* ppt, IDataObject* pDataObject)
        {
            return ((delegate* unmanaged<IDragSourceHelper*, IntPtr, POINT*, IDataObject*, int>)(lpVtbl[4]))((IDragSourceHelper*)Unsafe.AsPointer(ref this), hwnd, ppt, pDataObject);
        }
    }
}
