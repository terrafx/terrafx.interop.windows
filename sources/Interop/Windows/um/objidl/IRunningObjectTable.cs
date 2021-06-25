// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/objidl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("00000010-0000-0000-C000-000000000046")]
    [NativeTypeName("struct IRunningObjectTable : IUnknown")]
    public unsafe partial struct IRunningObjectTable
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IRunningObjectTable*, Guid*, void**, int>)(lpVtbl[0]))((IRunningObjectTable*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IRunningObjectTable*, uint>)(lpVtbl[1]))((IRunningObjectTable*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IRunningObjectTable*, uint>)(lpVtbl[2]))((IRunningObjectTable*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Register([NativeTypeName("DWORD")] uint grfFlags, IUnknown* punkObject, IMoniker* pmkObjectName, [NativeTypeName("DWORD *")] uint* pdwRegister)
        {
            return ((delegate* unmanaged<IRunningObjectTable*, uint, IUnknown*, IMoniker*, uint*, int>)(lpVtbl[3]))((IRunningObjectTable*)Unsafe.AsPointer(ref this), grfFlags, punkObject, pmkObjectName, pdwRegister);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Revoke([NativeTypeName("DWORD")] uint dwRegister)
        {
            return ((delegate* unmanaged<IRunningObjectTable*, uint, int>)(lpVtbl[4]))((IRunningObjectTable*)Unsafe.AsPointer(ref this), dwRegister);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int IsRunning(IMoniker* pmkObjectName)
        {
            return ((delegate* unmanaged<IRunningObjectTable*, IMoniker*, int>)(lpVtbl[5]))((IRunningObjectTable*)Unsafe.AsPointer(ref this), pmkObjectName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetObject(IMoniker* pmkObjectName, IUnknown** ppunkObject)
        {
            return ((delegate* unmanaged<IRunningObjectTable*, IMoniker*, IUnknown**, int>)(lpVtbl[6]))((IRunningObjectTable*)Unsafe.AsPointer(ref this), pmkObjectName, ppunkObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int NoteChangeTime([NativeTypeName("DWORD")] uint dwRegister, FILETIME* pfiletime)
        {
            return ((delegate* unmanaged<IRunningObjectTable*, uint, FILETIME*, int>)(lpVtbl[7]))((IRunningObjectTable*)Unsafe.AsPointer(ref this), dwRegister, pfiletime);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTimeOfLastChange(IMoniker* pmkObjectName, FILETIME* pfiletime)
        {
            return ((delegate* unmanaged<IRunningObjectTable*, IMoniker*, FILETIME*, int>)(lpVtbl[8]))((IRunningObjectTable*)Unsafe.AsPointer(ref this), pmkObjectName, pfiletime);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int EnumRunning(IEnumMoniker** ppenumMoniker)
        {
            return ((delegate* unmanaged<IRunningObjectTable*, IEnumMoniker**, int>)(lpVtbl[9]))((IRunningObjectTable*)Unsafe.AsPointer(ref this), ppenumMoniker);
        }
    }
}
