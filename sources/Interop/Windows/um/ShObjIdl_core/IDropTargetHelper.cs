// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("4657278B-411B-11D2-839A-00C04FD918D0")]
    [NativeTypeName("struct IDropTargetHelper : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IDropTargetHelper
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDropTargetHelper*, Guid*, void**, int>)(lpVtbl[0]))((IDropTargetHelper*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDropTargetHelper*, uint>)(lpVtbl[1]))((IDropTargetHelper*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDropTargetHelper*, uint>)(lpVtbl[2]))((IDropTargetHelper*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT DragEnter(HWND hwndTarget, IDataObject* pDataObject, POINT* ppt, [NativeTypeName("DWORD")] uint dwEffect)
        {
            return ((delegate* unmanaged<IDropTargetHelper*, HWND, IDataObject*, POINT*, uint, int>)(lpVtbl[3]))((IDropTargetHelper*)Unsafe.AsPointer(ref this), hwndTarget, pDataObject, ppt, dwEffect);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT DragLeave()
        {
            return ((delegate* unmanaged<IDropTargetHelper*, int>)(lpVtbl[4]))((IDropTargetHelper*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT DragOver(POINT* ppt, [NativeTypeName("DWORD")] uint dwEffect)
        {
            return ((delegate* unmanaged<IDropTargetHelper*, POINT*, uint, int>)(lpVtbl[5]))((IDropTargetHelper*)Unsafe.AsPointer(ref this), ppt, dwEffect);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT Drop(IDataObject* pDataObject, POINT* ppt, [NativeTypeName("DWORD")] uint dwEffect)
        {
            return ((delegate* unmanaged<IDropTargetHelper*, IDataObject*, POINT*, uint, int>)(lpVtbl[6]))((IDropTargetHelper*)Unsafe.AsPointer(ref this), pDataObject, ppt, dwEffect);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT Show(BOOL fShow)
        {
            return ((delegate* unmanaged<IDropTargetHelper*, BOOL, int>)(lpVtbl[7]))((IDropTargetHelper*)Unsafe.AsPointer(ref this), fShow);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IDropTargetHelper*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IDropTargetHelper*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IDropTargetHelper*, uint> Release;

            [NativeTypeName("HRESULT (HWND, IDataObject *, POINT *, DWORD) __attribute__((stdcall))")]
            public delegate* unmanaged<IDropTargetHelper*, HWND, IDataObject*, POINT*, uint, int> DragEnter;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<IDropTargetHelper*, int> DragLeave;

            [NativeTypeName("HRESULT (POINT *, DWORD) __attribute__((stdcall))")]
            public delegate* unmanaged<IDropTargetHelper*, POINT*, uint, int> DragOver;

            [NativeTypeName("HRESULT (IDataObject *, POINT *, DWORD) __attribute__((stdcall))")]
            public delegate* unmanaged<IDropTargetHelper*, IDataObject*, POINT*, uint, int> Drop;

            [NativeTypeName("HRESULT (BOOL) __attribute__((stdcall))")]
            public delegate* unmanaged<IDropTargetHelper*, BOOL, int> Show;
        }
    }
}
