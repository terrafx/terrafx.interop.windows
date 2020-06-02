// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/oleidl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("00000122-0000-0000-C000-000000000046")]
    public unsafe partial struct IDropTarget
    {
        public Vtbl* lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((IDropTarget*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IDropTarget*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IDropTarget*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int DragEnter([NativeTypeName("IDataObject *")] IDataObject* pDataObj, [NativeTypeName("DWORD")] uint grfKeyState, POINTL pt, [NativeTypeName("DWORD *")] uint* pdwEffect)
        {
            return lpVtbl->DragEnter((IDropTarget*)Unsafe.AsPointer(ref this), pDataObj, grfKeyState, pt, pdwEffect);
        }

        [return: NativeTypeName("HRESULT")]
        public int DragOver([NativeTypeName("DWORD")] uint grfKeyState, POINTL pt, [NativeTypeName("DWORD *")] uint* pdwEffect)
        {
            return lpVtbl->DragOver((IDropTarget*)Unsafe.AsPointer(ref this), grfKeyState, pt, pdwEffect);
        }

        [return: NativeTypeName("HRESULT")]
        public int DragLeave()
        {
            return lpVtbl->DragLeave((IDropTarget*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int Drop([NativeTypeName("IDataObject *")] IDataObject* pDataObj, [NativeTypeName("DWORD")] uint grfKeyState, POINTL pt, [NativeTypeName("DWORD *")] uint* pdwEffect)
        {
            return lpVtbl->Drop((IDropTarget*)Unsafe.AsPointer(ref this), pDataObj, grfKeyState, pt, pdwEffect);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<IDropTarget*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IDropTarget*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IDropTarget*, uint> Release;

            [NativeTypeName("HRESULT (IDataObject *, DWORD, POINTL, DWORD *) __attribute__((stdcall))")]
            public delegate* stdcall<IDropTarget*, IDataObject*, uint, POINTL, uint*, int> DragEnter;

            [NativeTypeName("HRESULT (DWORD, POINTL, DWORD *) __attribute__((stdcall))")]
            public delegate* stdcall<IDropTarget*, uint, POINTL, uint*, int> DragOver;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* stdcall<IDropTarget*, int> DragLeave;

            [NativeTypeName("HRESULT (IDataObject *, DWORD, POINTL, DWORD *) __attribute__((stdcall))")]
            public delegate* stdcall<IDropTarget*, IDataObject*, uint, POINTL, uint*, int> Drop;
        }
    }
}
