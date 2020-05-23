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

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IOleUndoManager* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IOleUndoManager* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IOleUndoManager* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Open(IOleUndoManager* pThis, [NativeTypeName("IOleParentUndoUnit *")] IOleParentUndoUnit* pPUU);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Close(IOleUndoManager* pThis, [NativeTypeName("IOleParentUndoUnit *")] IOleParentUndoUnit* pPUU, [NativeTypeName("BOOL")] int fCommit);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Add(IOleUndoManager* pThis, [NativeTypeName("IOleUndoUnit *")] IOleUndoUnit* pUU);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetOpenParentState(IOleUndoManager* pThis, [NativeTypeName("DWORD *")] uint* pdwState);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _DiscardFrom(IOleUndoManager* pThis, [NativeTypeName("IOleUndoUnit *")] IOleUndoUnit* pUU);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _UndoTo(IOleUndoManager* pThis, [NativeTypeName("IOleUndoUnit *")] IOleUndoUnit* pUU);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _RedoTo(IOleUndoManager* pThis, [NativeTypeName("IOleUndoUnit *")] IOleUndoUnit* pUU);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _EnumUndoable(IOleUndoManager* pThis, [NativeTypeName("IEnumOleUndoUnits **")] IEnumOleUndoUnits** ppEnum);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _EnumRedoable(IOleUndoManager* pThis, [NativeTypeName("IEnumOleUndoUnits **")] IEnumOleUndoUnits** ppEnum);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetLastUndoDescription(IOleUndoManager* pThis, [NativeTypeName("BSTR *")] ushort** pBstr);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetLastRedoDescription(IOleUndoManager* pThis, [NativeTypeName("BSTR *")] ushort** pBstr);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Enable(IOleUndoManager* pThis, [NativeTypeName("BOOL")] int fEnable);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((IOleUndoManager*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((IOleUndoManager*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((IOleUndoManager*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int Open([NativeTypeName("IOleParentUndoUnit *")] IOleParentUndoUnit* pPUU)
        {
            return Marshal.GetDelegateForFunctionPointer<_Open>(lpVtbl->Open)((IOleUndoManager*)Unsafe.AsPointer(ref this), pPUU);
        }

        [return: NativeTypeName("HRESULT")]
        public int Close([NativeTypeName("IOleParentUndoUnit *")] IOleParentUndoUnit* pPUU, [NativeTypeName("BOOL")] int fCommit)
        {
            return Marshal.GetDelegateForFunctionPointer<_Close>(lpVtbl->Close)((IOleUndoManager*)Unsafe.AsPointer(ref this), pPUU, fCommit);
        }

        [return: NativeTypeName("HRESULT")]
        public int Add([NativeTypeName("IOleUndoUnit *")] IOleUndoUnit* pUU)
        {
            return Marshal.GetDelegateForFunctionPointer<_Add>(lpVtbl->Add)((IOleUndoManager*)Unsafe.AsPointer(ref this), pUU);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetOpenParentState([NativeTypeName("DWORD *")] uint* pdwState)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetOpenParentState>(lpVtbl->GetOpenParentState)((IOleUndoManager*)Unsafe.AsPointer(ref this), pdwState);
        }

        [return: NativeTypeName("HRESULT")]
        public int DiscardFrom([NativeTypeName("IOleUndoUnit *")] IOleUndoUnit* pUU)
        {
            return Marshal.GetDelegateForFunctionPointer<_DiscardFrom>(lpVtbl->DiscardFrom)((IOleUndoManager*)Unsafe.AsPointer(ref this), pUU);
        }

        [return: NativeTypeName("HRESULT")]
        public int UndoTo([NativeTypeName("IOleUndoUnit *")] IOleUndoUnit* pUU)
        {
            return Marshal.GetDelegateForFunctionPointer<_UndoTo>(lpVtbl->UndoTo)((IOleUndoManager*)Unsafe.AsPointer(ref this), pUU);
        }

        [return: NativeTypeName("HRESULT")]
        public int RedoTo([NativeTypeName("IOleUndoUnit *")] IOleUndoUnit* pUU)
        {
            return Marshal.GetDelegateForFunctionPointer<_RedoTo>(lpVtbl->RedoTo)((IOleUndoManager*)Unsafe.AsPointer(ref this), pUU);
        }

        [return: NativeTypeName("HRESULT")]
        public int EnumUndoable([NativeTypeName("IEnumOleUndoUnits **")] IEnumOleUndoUnits** ppEnum)
        {
            return Marshal.GetDelegateForFunctionPointer<_EnumUndoable>(lpVtbl->EnumUndoable)((IOleUndoManager*)Unsafe.AsPointer(ref this), ppEnum);
        }

        [return: NativeTypeName("HRESULT")]
        public int EnumRedoable([NativeTypeName("IEnumOleUndoUnits **")] IEnumOleUndoUnits** ppEnum)
        {
            return Marshal.GetDelegateForFunctionPointer<_EnumRedoable>(lpVtbl->EnumRedoable)((IOleUndoManager*)Unsafe.AsPointer(ref this), ppEnum);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetLastUndoDescription([NativeTypeName("BSTR *")] ushort** pBstr)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetLastUndoDescription>(lpVtbl->GetLastUndoDescription)((IOleUndoManager*)Unsafe.AsPointer(ref this), pBstr);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetLastRedoDescription([NativeTypeName("BSTR *")] ushort** pBstr)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetLastRedoDescription>(lpVtbl->GetLastRedoDescription)((IOleUndoManager*)Unsafe.AsPointer(ref this), pBstr);
        }

        [return: NativeTypeName("HRESULT")]
        public int Enable([NativeTypeName("BOOL")] int fEnable)
        {
            return Marshal.GetDelegateForFunctionPointer<_Enable>(lpVtbl->Enable)((IOleUndoManager*)Unsafe.AsPointer(ref this), fEnable);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public IntPtr QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr Release;

            [NativeTypeName("HRESULT (IOleParentUndoUnit *) __attribute__((stdcall))")]
            public IntPtr Open;

            [NativeTypeName("HRESULT (IOleParentUndoUnit *, BOOL) __attribute__((stdcall))")]
            public IntPtr Close;

            [NativeTypeName("HRESULT (IOleUndoUnit *) __attribute__((stdcall))")]
            public IntPtr Add;

            [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
            public IntPtr GetOpenParentState;

            [NativeTypeName("HRESULT (IOleUndoUnit *) __attribute__((stdcall))")]
            public IntPtr DiscardFrom;

            [NativeTypeName("HRESULT (IOleUndoUnit *) __attribute__((stdcall))")]
            public IntPtr UndoTo;

            [NativeTypeName("HRESULT (IOleUndoUnit *) __attribute__((stdcall))")]
            public IntPtr RedoTo;

            [NativeTypeName("HRESULT (IEnumOleUndoUnits **) __attribute__((stdcall))")]
            public IntPtr EnumUndoable;

            [NativeTypeName("HRESULT (IEnumOleUndoUnits **) __attribute__((stdcall))")]
            public IntPtr EnumRedoable;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public IntPtr GetLastUndoDescription;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public IntPtr GetLastRedoDescription;

            [NativeTypeName("HRESULT (BOOL) __attribute__((stdcall))")]
            public IntPtr Enable;
        }
    }
}
