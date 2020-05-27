// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/OCIdl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("A1FAF330-EF97-11CE-9BC9-00AA00608E01")]
    public unsafe partial struct IOleParentUndoUnit
    {
        public Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IOleParentUndoUnit* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IOleParentUndoUnit* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IOleParentUndoUnit* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Do(IOleParentUndoUnit* pThis, [NativeTypeName("IOleUndoManager *")] IOleUndoManager* pUndoManager);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetDescription(IOleParentUndoUnit* pThis, [NativeTypeName("BSTR *")] ushort** pBstr);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetUnitType(IOleParentUndoUnit* pThis, [NativeTypeName("CLSID *")] Guid* pClsid, [NativeTypeName("LONG *")] int* plID);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _OnNextAdd(IOleParentUndoUnit* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Open(IOleParentUndoUnit* pThis, [NativeTypeName("IOleParentUndoUnit *")] IOleParentUndoUnit* pPUU);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Close(IOleParentUndoUnit* pThis, [NativeTypeName("IOleParentUndoUnit *")] IOleParentUndoUnit* pPUU, [NativeTypeName("BOOL")] int fCommit);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Add(IOleParentUndoUnit* pThis, [NativeTypeName("IOleUndoUnit *")] IOleUndoUnit* pUU);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _FindUnit(IOleParentUndoUnit* pThis, [NativeTypeName("IOleUndoUnit *")] IOleUndoUnit* pUU);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetParentState(IOleParentUndoUnit* pThis, [NativeTypeName("DWORD *")] uint* pdwState);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((IOleParentUndoUnit*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((IOleParentUndoUnit*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((IOleParentUndoUnit*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int Do([NativeTypeName("IOleUndoManager *")] IOleUndoManager* pUndoManager)
        {
            return Marshal.GetDelegateForFunctionPointer<_Do>(lpVtbl->Do)((IOleParentUndoUnit*)Unsafe.AsPointer(ref this), pUndoManager);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDescription([NativeTypeName("BSTR *")] ushort** pBstr)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetDescription>(lpVtbl->GetDescription)((IOleParentUndoUnit*)Unsafe.AsPointer(ref this), pBstr);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetUnitType([NativeTypeName("CLSID *")] Guid* pClsid, [NativeTypeName("LONG *")] int* plID)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetUnitType>(lpVtbl->GetUnitType)((IOleParentUndoUnit*)Unsafe.AsPointer(ref this), pClsid, plID);
        }

        [return: NativeTypeName("HRESULT")]
        public int OnNextAdd()
        {
            return Marshal.GetDelegateForFunctionPointer<_OnNextAdd>(lpVtbl->OnNextAdd)((IOleParentUndoUnit*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int Open([NativeTypeName("IOleParentUndoUnit *")] IOleParentUndoUnit* pPUU)
        {
            return Marshal.GetDelegateForFunctionPointer<_Open>(lpVtbl->Open)((IOleParentUndoUnit*)Unsafe.AsPointer(ref this), pPUU);
        }

        [return: NativeTypeName("HRESULT")]
        public int Close([NativeTypeName("IOleParentUndoUnit *")] IOleParentUndoUnit* pPUU, [NativeTypeName("BOOL")] int fCommit)
        {
            return Marshal.GetDelegateForFunctionPointer<_Close>(lpVtbl->Close)((IOleParentUndoUnit*)Unsafe.AsPointer(ref this), pPUU, fCommit);
        }

        [return: NativeTypeName("HRESULT")]
        public int Add([NativeTypeName("IOleUndoUnit *")] IOleUndoUnit* pUU)
        {
            return Marshal.GetDelegateForFunctionPointer<_Add>(lpVtbl->Add)((IOleParentUndoUnit*)Unsafe.AsPointer(ref this), pUU);
        }

        [return: NativeTypeName("HRESULT")]
        public int FindUnit([NativeTypeName("IOleUndoUnit *")] IOleUndoUnit* pUU)
        {
            return Marshal.GetDelegateForFunctionPointer<_FindUnit>(lpVtbl->FindUnit)((IOleParentUndoUnit*)Unsafe.AsPointer(ref this), pUU);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetParentState([NativeTypeName("DWORD *")] uint* pdwState)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetParentState>(lpVtbl->GetParentState)((IOleParentUndoUnit*)Unsafe.AsPointer(ref this), pdwState);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public IntPtr QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr Release;

            [NativeTypeName("HRESULT (IOleUndoManager *) __attribute__((stdcall))")]
            public IntPtr Do;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public IntPtr GetDescription;

            [NativeTypeName("HRESULT (CLSID *, LONG *) __attribute__((stdcall))")]
            public IntPtr GetUnitType;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public IntPtr OnNextAdd;

            [NativeTypeName("HRESULT (IOleParentUndoUnit *) __attribute__((stdcall))")]
            public IntPtr Open;

            [NativeTypeName("HRESULT (IOleParentUndoUnit *, BOOL) __attribute__((stdcall))")]
            public IntPtr Close;

            [NativeTypeName("HRESULT (IOleUndoUnit *) __attribute__((stdcall))")]
            public IntPtr Add;

            [NativeTypeName("HRESULT (IOleUndoUnit *) __attribute__((stdcall))")]
            public IntPtr FindUnit;

            [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
            public IntPtr GetParentState;
        }
    }
}
