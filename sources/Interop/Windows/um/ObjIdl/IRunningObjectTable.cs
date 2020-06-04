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
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IRunningObjectTable*, Guid*, void**, int>)(lpVtbl[0]))((IRunningObjectTable*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IRunningObjectTable*, uint>)(lpVtbl[1]))((IRunningObjectTable*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IRunningObjectTable*, uint>)(lpVtbl[2]))((IRunningObjectTable*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int Register([NativeTypeName("DWORD")] uint grfFlags, [NativeTypeName("IUnknown *")] IUnknown* punkObject, [NativeTypeName("IMoniker *")] IMoniker* pmkObjectName, [NativeTypeName("DWORD *")] uint* pdwRegister)
        {
            return ((delegate* stdcall<IRunningObjectTable*, uint, IUnknown*, IMoniker*, uint*, int>)(lpVtbl[3]))((IRunningObjectTable*)Unsafe.AsPointer(ref this), grfFlags, punkObject, pmkObjectName, pdwRegister);
        }

        [return: NativeTypeName("HRESULT")]
        public int Revoke([NativeTypeName("DWORD")] uint dwRegister)
        {
            return ((delegate* stdcall<IRunningObjectTable*, uint, int>)(lpVtbl[4]))((IRunningObjectTable*)Unsafe.AsPointer(ref this), dwRegister);
        }

        [return: NativeTypeName("HRESULT")]
        public int IsRunning([NativeTypeName("IMoniker *")] IMoniker* pmkObjectName)
        {
            return ((delegate* stdcall<IRunningObjectTable*, IMoniker*, int>)(lpVtbl[5]))((IRunningObjectTable*)Unsafe.AsPointer(ref this), pmkObjectName);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetObjectA([NativeTypeName("IMoniker *")] IMoniker* pmkObjectName, [NativeTypeName("IUnknown **")] IUnknown** ppunkObject)
        {
            return ((delegate* stdcall<IRunningObjectTable*, IMoniker*, IUnknown**, int>)(lpVtbl[6]))((IRunningObjectTable*)Unsafe.AsPointer(ref this), pmkObjectName, ppunkObject);
        }

        [return: NativeTypeName("HRESULT")]
        public int NoteChangeTime([NativeTypeName("DWORD")] uint dwRegister, [NativeTypeName("FILETIME *")] FILETIME* pfiletime)
        {
            return ((delegate* stdcall<IRunningObjectTable*, uint, FILETIME*, int>)(lpVtbl[7]))((IRunningObjectTable*)Unsafe.AsPointer(ref this), dwRegister, pfiletime);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetTimeOfLastChange([NativeTypeName("IMoniker *")] IMoniker* pmkObjectName, [NativeTypeName("FILETIME *")] FILETIME* pfiletime)
        {
            return ((delegate* stdcall<IRunningObjectTable*, IMoniker*, FILETIME*, int>)(lpVtbl[8]))((IRunningObjectTable*)Unsafe.AsPointer(ref this), pmkObjectName, pfiletime);
        }

        [return: NativeTypeName("HRESULT")]
        public int EnumRunning([NativeTypeName("IEnumMoniker **")] IEnumMoniker** ppenumMoniker)
        {
            return ((delegate* stdcall<IRunningObjectTable*, IEnumMoniker**, int>)(lpVtbl[9]))((IRunningObjectTable*)Unsafe.AsPointer(ref this), ppenumMoniker);
        }
    }
}
