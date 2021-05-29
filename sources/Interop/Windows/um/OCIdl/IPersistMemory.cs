// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/OCIdl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("BD1AE5E0-A6AE-11CE-BD37-504200C10000")]
    [NativeTypeName("struct IPersistMemory : IPersist")]
    public unsafe partial struct IPersistMemory
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IPersistMemory*, Guid*, void**, int>)(lpVtbl[0]))((IPersistMemory*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IPersistMemory*, uint>)(lpVtbl[1]))((IPersistMemory*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IPersistMemory*, uint>)(lpVtbl[2]))((IPersistMemory*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetClassID([NativeTypeName("CLSID *")] Guid* pClassID)
        {
            return ((delegate* unmanaged<IPersistMemory*, Guid*, int>)(lpVtbl[3]))((IPersistMemory*)Unsafe.AsPointer(ref this), pClassID);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int IsDirty()
        {
            return ((delegate* unmanaged<IPersistMemory*, int>)(lpVtbl[4]))((IPersistMemory*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Load([NativeTypeName("LPVOID")] void* pMem, [NativeTypeName("ULONG")] uint cbSize)
        {
            return ((delegate* unmanaged<IPersistMemory*, void*, uint, int>)(lpVtbl[5]))((IPersistMemory*)Unsafe.AsPointer(ref this), pMem, cbSize);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Save([NativeTypeName("LPVOID")] void* pMem, [NativeTypeName("BOOL")] int fClearDirty, [NativeTypeName("ULONG")] uint cbSize)
        {
            return ((delegate* unmanaged<IPersistMemory*, void*, int, uint, int>)(lpVtbl[6]))((IPersistMemory*)Unsafe.AsPointer(ref this), pMem, fClearDirty, cbSize);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetSizeMax([NativeTypeName("ULONG *")] uint* pCbSize)
        {
            return ((delegate* unmanaged<IPersistMemory*, uint*, int>)(lpVtbl[7]))((IPersistMemory*)Unsafe.AsPointer(ref this), pCbSize);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int InitNew()
        {
            return ((delegate* unmanaged<IPersistMemory*, int>)(lpVtbl[8]))((IPersistMemory*)Unsafe.AsPointer(ref this));
        }
    }
}
