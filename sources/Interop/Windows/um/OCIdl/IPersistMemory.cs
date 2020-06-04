// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/OCIdl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("BD1AE5E0-A6AE-11CE-BD37-504200C10000")]
    public unsafe partial struct IPersistMemory
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IPersistMemory*, Guid*, void**, int>)(lpVtbl[0]))((IPersistMemory*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IPersistMemory*, uint>)(lpVtbl[1]))((IPersistMemory*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IPersistMemory*, uint>)(lpVtbl[2]))((IPersistMemory*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetClassID([NativeTypeName("CLSID *")] Guid* pClassID)
        {
            return ((delegate* stdcall<IPersistMemory*, Guid*, int>)(lpVtbl[3]))((IPersistMemory*)Unsafe.AsPointer(ref this), pClassID);
        }

        [return: NativeTypeName("HRESULT")]
        public int IsDirty()
        {
            return ((delegate* stdcall<IPersistMemory*, int>)(lpVtbl[4]))((IPersistMemory*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int Load([NativeTypeName("LPVOID")] void* pMem, [NativeTypeName("ULONG")] uint cbSize)
        {
            return ((delegate* stdcall<IPersistMemory*, void*, uint, int>)(lpVtbl[5]))((IPersistMemory*)Unsafe.AsPointer(ref this), pMem, cbSize);
        }

        [return: NativeTypeName("HRESULT")]
        public int Save([NativeTypeName("LPVOID")] void* pMem, [NativeTypeName("BOOL")] int fClearDirty, [NativeTypeName("ULONG")] uint cbSize)
        {
            return ((delegate* stdcall<IPersistMemory*, void*, int, uint, int>)(lpVtbl[6]))((IPersistMemory*)Unsafe.AsPointer(ref this), pMem, fClearDirty, cbSize);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetSizeMax([NativeTypeName("ULONG *")] uint* pCbSize)
        {
            return ((delegate* stdcall<IPersistMemory*, uint*, int>)(lpVtbl[7]))((IPersistMemory*)Unsafe.AsPointer(ref this), pCbSize);
        }

        [return: NativeTypeName("HRESULT")]
        public int InitNew()
        {
            return ((delegate* stdcall<IPersistMemory*, int>)(lpVtbl[8]))((IPersistMemory*)Unsafe.AsPointer(ref this));
        }
    }
}
