// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ObjIdl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("00000010-0000-0000-C000-000000000046")]
    public unsafe partial struct IRunningObjectTable
    {
        public Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IRunningObjectTable* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IRunningObjectTable* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IRunningObjectTable* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Register(IRunningObjectTable* pThis, [NativeTypeName("DWORD")] uint grfFlags, [NativeTypeName("IUnknown *")] IUnknown* punkObject, [NativeTypeName("IMoniker *")] IMoniker* pmkObjectName, [NativeTypeName("DWORD *")] uint* pdwRegister);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Revoke(IRunningObjectTable* pThis, [NativeTypeName("DWORD")] uint dwRegister);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _IsRunning(IRunningObjectTable* pThis, [NativeTypeName("IMoniker *")] IMoniker* pmkObjectName);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetObjectA(IRunningObjectTable* pThis, [NativeTypeName("IMoniker *")] IMoniker* pmkObjectName, [NativeTypeName("IUnknown **")] IUnknown** ppunkObject);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _NoteChangeTime(IRunningObjectTable* pThis, [NativeTypeName("DWORD")] uint dwRegister, [NativeTypeName("FILETIME *")] FILETIME* pfiletime);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetTimeOfLastChange(IRunningObjectTable* pThis, [NativeTypeName("IMoniker *")] IMoniker* pmkObjectName, [NativeTypeName("FILETIME *")] FILETIME* pfiletime);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _EnumRunning(IRunningObjectTable* pThis, [NativeTypeName("IEnumMoniker **")] IEnumMoniker** ppenumMoniker);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((IRunningObjectTable*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((IRunningObjectTable*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((IRunningObjectTable*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int Register([NativeTypeName("DWORD")] uint grfFlags, [NativeTypeName("IUnknown *")] IUnknown* punkObject, [NativeTypeName("IMoniker *")] IMoniker* pmkObjectName, [NativeTypeName("DWORD *")] uint* pdwRegister)
        {
            return Marshal.GetDelegateForFunctionPointer<_Register>(lpVtbl->Register)((IRunningObjectTable*)Unsafe.AsPointer(ref this), grfFlags, punkObject, pmkObjectName, pdwRegister);
        }

        [return: NativeTypeName("HRESULT")]
        public int Revoke([NativeTypeName("DWORD")] uint dwRegister)
        {
            return Marshal.GetDelegateForFunctionPointer<_Revoke>(lpVtbl->Revoke)((IRunningObjectTable*)Unsafe.AsPointer(ref this), dwRegister);
        }

        [return: NativeTypeName("HRESULT")]
        public int IsRunning([NativeTypeName("IMoniker *")] IMoniker* pmkObjectName)
        {
            return Marshal.GetDelegateForFunctionPointer<_IsRunning>(lpVtbl->IsRunning)((IRunningObjectTable*)Unsafe.AsPointer(ref this), pmkObjectName);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetObjectA([NativeTypeName("IMoniker *")] IMoniker* pmkObjectName, [NativeTypeName("IUnknown **")] IUnknown** ppunkObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetObjectA>(lpVtbl->GetObjectA)((IRunningObjectTable*)Unsafe.AsPointer(ref this), pmkObjectName, ppunkObject);
        }

        [return: NativeTypeName("HRESULT")]
        public int NoteChangeTime([NativeTypeName("DWORD")] uint dwRegister, [NativeTypeName("FILETIME *")] FILETIME* pfiletime)
        {
            return Marshal.GetDelegateForFunctionPointer<_NoteChangeTime>(lpVtbl->NoteChangeTime)((IRunningObjectTable*)Unsafe.AsPointer(ref this), dwRegister, pfiletime);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetTimeOfLastChange([NativeTypeName("IMoniker *")] IMoniker* pmkObjectName, [NativeTypeName("FILETIME *")] FILETIME* pfiletime)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetTimeOfLastChange>(lpVtbl->GetTimeOfLastChange)((IRunningObjectTable*)Unsafe.AsPointer(ref this), pmkObjectName, pfiletime);
        }

        [return: NativeTypeName("HRESULT")]
        public int EnumRunning([NativeTypeName("IEnumMoniker **")] IEnumMoniker** ppenumMoniker)
        {
            return Marshal.GetDelegateForFunctionPointer<_EnumRunning>(lpVtbl->EnumRunning)((IRunningObjectTable*)Unsafe.AsPointer(ref this), ppenumMoniker);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public IntPtr QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr Release;

            [NativeTypeName("HRESULT (DWORD, IUnknown *, IMoniker *, DWORD *) __attribute__((stdcall))")]
            public IntPtr Register;

            [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
            public IntPtr Revoke;

            [NativeTypeName("HRESULT (IMoniker *) __attribute__((stdcall))")]
            public IntPtr IsRunning;

            [NativeTypeName("HRESULT (IMoniker *, IUnknown **) __attribute__((stdcall))")]
            public IntPtr GetObjectA;

            [NativeTypeName("HRESULT (DWORD, FILETIME *) __attribute__((stdcall))")]
            public IntPtr NoteChangeTime;

            [NativeTypeName("HRESULT (IMoniker *, FILETIME *) __attribute__((stdcall))")]
            public IntPtr GetTimeOfLastChange;

            [NativeTypeName("HRESULT (IEnumMoniker **) __attribute__((stdcall))")]
            public IntPtr EnumRunning;
        }
    }
}
