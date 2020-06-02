// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/OCIdl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("D001F200-EF97-11CE-9BC9-00AA00608E01")]
    public unsafe partial struct IOleUndoManager
    {
        public Vtbl* lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((IOleUndoManager*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IOleUndoManager*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IOleUndoManager*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int Open([NativeTypeName("IOleParentUndoUnit *")] IOleParentUndoUnit* pPUU)
        {
            return lpVtbl->Open((IOleUndoManager*)Unsafe.AsPointer(ref this), pPUU);
        }

        [return: NativeTypeName("HRESULT")]
        public int Close([NativeTypeName("IOleParentUndoUnit *")] IOleParentUndoUnit* pPUU, [NativeTypeName("BOOL")] int fCommit)
        {
            return lpVtbl->Close((IOleUndoManager*)Unsafe.AsPointer(ref this), pPUU, fCommit);
        }

        [return: NativeTypeName("HRESULT")]
        public int Add([NativeTypeName("IOleUndoUnit *")] IOleUndoUnit* pUU)
        {
            return lpVtbl->Add((IOleUndoManager*)Unsafe.AsPointer(ref this), pUU);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetOpenParentState([NativeTypeName("DWORD *")] uint* pdwState)
        {
            return lpVtbl->GetOpenParentState((IOleUndoManager*)Unsafe.AsPointer(ref this), pdwState);
        }

        [return: NativeTypeName("HRESULT")]
        public int DiscardFrom([NativeTypeName("IOleUndoUnit *")] IOleUndoUnit* pUU)
        {
            return lpVtbl->DiscardFrom((IOleUndoManager*)Unsafe.AsPointer(ref this), pUU);
        }

        [return: NativeTypeName("HRESULT")]
        public int UndoTo([NativeTypeName("IOleUndoUnit *")] IOleUndoUnit* pUU)
        {
            return lpVtbl->UndoTo((IOleUndoManager*)Unsafe.AsPointer(ref this), pUU);
        }

        [return: NativeTypeName("HRESULT")]
        public int RedoTo([NativeTypeName("IOleUndoUnit *")] IOleUndoUnit* pUU)
        {
            return lpVtbl->RedoTo((IOleUndoManager*)Unsafe.AsPointer(ref this), pUU);
        }

        [return: NativeTypeName("HRESULT")]
        public int EnumUndoable([NativeTypeName("IEnumOleUndoUnits **")] IEnumOleUndoUnits** ppEnum)
        {
            return lpVtbl->EnumUndoable((IOleUndoManager*)Unsafe.AsPointer(ref this), ppEnum);
        }

        [return: NativeTypeName("HRESULT")]
        public int EnumRedoable([NativeTypeName("IEnumOleUndoUnits **")] IEnumOleUndoUnits** ppEnum)
        {
            return lpVtbl->EnumRedoable((IOleUndoManager*)Unsafe.AsPointer(ref this), ppEnum);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetLastUndoDescription([NativeTypeName("BSTR *")] ushort** pBstr)
        {
            return lpVtbl->GetLastUndoDescription((IOleUndoManager*)Unsafe.AsPointer(ref this), pBstr);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetLastRedoDescription([NativeTypeName("BSTR *")] ushort** pBstr)
        {
            return lpVtbl->GetLastRedoDescription((IOleUndoManager*)Unsafe.AsPointer(ref this), pBstr);
        }

        [return: NativeTypeName("HRESULT")]
        public int Enable([NativeTypeName("BOOL")] int fEnable)
        {
            return lpVtbl->Enable((IOleUndoManager*)Unsafe.AsPointer(ref this), fEnable);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<IOleUndoManager*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IOleUndoManager*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IOleUndoManager*, uint> Release;

            [NativeTypeName("HRESULT (IOleParentUndoUnit *) __attribute__((stdcall))")]
            public delegate* stdcall<IOleUndoManager*, IOleParentUndoUnit*, int> Open;

            [NativeTypeName("HRESULT (IOleParentUndoUnit *, BOOL) __attribute__((stdcall))")]
            public delegate* stdcall<IOleUndoManager*, IOleParentUndoUnit*, int, int> Close;

            [NativeTypeName("HRESULT (IOleUndoUnit *) __attribute__((stdcall))")]
            public delegate* stdcall<IOleUndoManager*, IOleUndoUnit*, int> Add;

            [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
            public delegate* stdcall<IOleUndoManager*, uint*, int> GetOpenParentState;

            [NativeTypeName("HRESULT (IOleUndoUnit *) __attribute__((stdcall))")]
            public delegate* stdcall<IOleUndoManager*, IOleUndoUnit*, int> DiscardFrom;

            [NativeTypeName("HRESULT (IOleUndoUnit *) __attribute__((stdcall))")]
            public delegate* stdcall<IOleUndoManager*, IOleUndoUnit*, int> UndoTo;

            [NativeTypeName("HRESULT (IOleUndoUnit *) __attribute__((stdcall))")]
            public delegate* stdcall<IOleUndoManager*, IOleUndoUnit*, int> RedoTo;

            [NativeTypeName("HRESULT (IEnumOleUndoUnits **) __attribute__((stdcall))")]
            public delegate* stdcall<IOleUndoManager*, IEnumOleUndoUnits**, int> EnumUndoable;

            [NativeTypeName("HRESULT (IEnumOleUndoUnits **) __attribute__((stdcall))")]
            public delegate* stdcall<IOleUndoManager*, IEnumOleUndoUnits**, int> EnumRedoable;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* stdcall<IOleUndoManager*, ushort**, int> GetLastUndoDescription;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* stdcall<IOleUndoManager*, ushort**, int> GetLastRedoDescription;

            [NativeTypeName("HRESULT (BOOL) __attribute__((stdcall))")]
            public delegate* stdcall<IOleUndoManager*, int, int> Enable;
        }
    }
}
