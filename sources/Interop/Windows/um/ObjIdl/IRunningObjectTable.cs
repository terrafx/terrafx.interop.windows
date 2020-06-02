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

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((IRunningObjectTable*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IRunningObjectTable*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IRunningObjectTable*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int Register([NativeTypeName("DWORD")] uint grfFlags, [NativeTypeName("IUnknown *")] IUnknown* punkObject, [NativeTypeName("IMoniker *")] IMoniker* pmkObjectName, [NativeTypeName("DWORD *")] uint* pdwRegister)
        {
            return lpVtbl->Register((IRunningObjectTable*)Unsafe.AsPointer(ref this), grfFlags, punkObject, pmkObjectName, pdwRegister);
        }

        [return: NativeTypeName("HRESULT")]
        public int Revoke([NativeTypeName("DWORD")] uint dwRegister)
        {
            return lpVtbl->Revoke((IRunningObjectTable*)Unsafe.AsPointer(ref this), dwRegister);
        }

        [return: NativeTypeName("HRESULT")]
        public int IsRunning([NativeTypeName("IMoniker *")] IMoniker* pmkObjectName)
        {
            return lpVtbl->IsRunning((IRunningObjectTable*)Unsafe.AsPointer(ref this), pmkObjectName);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetObjectA([NativeTypeName("IMoniker *")] IMoniker* pmkObjectName, [NativeTypeName("IUnknown **")] IUnknown** ppunkObject)
        {
            return lpVtbl->GetObjectA((IRunningObjectTable*)Unsafe.AsPointer(ref this), pmkObjectName, ppunkObject);
        }

        [return: NativeTypeName("HRESULT")]
        public int NoteChangeTime([NativeTypeName("DWORD")] uint dwRegister, [NativeTypeName("FILETIME *")] FILETIME* pfiletime)
        {
            return lpVtbl->NoteChangeTime((IRunningObjectTable*)Unsafe.AsPointer(ref this), dwRegister, pfiletime);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetTimeOfLastChange([NativeTypeName("IMoniker *")] IMoniker* pmkObjectName, [NativeTypeName("FILETIME *")] FILETIME* pfiletime)
        {
            return lpVtbl->GetTimeOfLastChange((IRunningObjectTable*)Unsafe.AsPointer(ref this), pmkObjectName, pfiletime);
        }

        [return: NativeTypeName("HRESULT")]
        public int EnumRunning([NativeTypeName("IEnumMoniker **")] IEnumMoniker** ppenumMoniker)
        {
            return lpVtbl->EnumRunning((IRunningObjectTable*)Unsafe.AsPointer(ref this), ppenumMoniker);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<IRunningObjectTable*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IRunningObjectTable*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IRunningObjectTable*, uint> Release;

            [NativeTypeName("HRESULT (DWORD, IUnknown *, IMoniker *, DWORD *) __attribute__((stdcall))")]
            public delegate* stdcall<IRunningObjectTable*, uint, IUnknown*, IMoniker*, uint*, int> Register;

            [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
            public delegate* stdcall<IRunningObjectTable*, uint, int> Revoke;

            [NativeTypeName("HRESULT (IMoniker *) __attribute__((stdcall))")]
            public delegate* stdcall<IRunningObjectTable*, IMoniker*, int> IsRunning;

            [NativeTypeName("HRESULT (IMoniker *, IUnknown **) __attribute__((stdcall))")]
            public delegate* stdcall<IRunningObjectTable*, IMoniker*, IUnknown**, int> GetObjectA;

            [NativeTypeName("HRESULT (DWORD, FILETIME *) __attribute__((stdcall))")]
            public delegate* stdcall<IRunningObjectTable*, uint, FILETIME*, int> NoteChangeTime;

            [NativeTypeName("HRESULT (IMoniker *, FILETIME *) __attribute__((stdcall))")]
            public delegate* stdcall<IRunningObjectTable*, IMoniker*, FILETIME*, int> GetTimeOfLastChange;

            [NativeTypeName("HRESULT (IEnumMoniker **) __attribute__((stdcall))")]
            public delegate* stdcall<IRunningObjectTable*, IEnumMoniker**, int> EnumRunning;
        }
    }
}
