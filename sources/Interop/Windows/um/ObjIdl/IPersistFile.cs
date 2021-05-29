// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ObjIdl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("0000010B-0000-0000-C000-000000000046")]
    [NativeTypeName("struct IPersistFile : IPersist")]
    public unsafe partial struct IPersistFile
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IPersistFile*, Guid*, void**, int>)(lpVtbl[0]))((IPersistFile*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IPersistFile*, uint>)(lpVtbl[1]))((IPersistFile*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IPersistFile*, uint>)(lpVtbl[2]))((IPersistFile*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetClassID([NativeTypeName("CLSID *")] Guid* pClassID)
        {
            return ((delegate* unmanaged<IPersistFile*, Guid*, int>)(lpVtbl[3]))((IPersistFile*)Unsafe.AsPointer(ref this), pClassID);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int IsDirty()
        {
            return ((delegate* unmanaged<IPersistFile*, int>)(lpVtbl[4]))((IPersistFile*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Load([NativeTypeName("LPCOLESTR")] ushort* pszFileName, [NativeTypeName("DWORD")] uint dwMode)
        {
            return ((delegate* unmanaged<IPersistFile*, ushort*, uint, int>)(lpVtbl[5]))((IPersistFile*)Unsafe.AsPointer(ref this), pszFileName, dwMode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Save([NativeTypeName("LPCOLESTR")] ushort* pszFileName, [NativeTypeName("BOOL")] int fRemember)
        {
            return ((delegate* unmanaged<IPersistFile*, ushort*, int, int>)(lpVtbl[6]))((IPersistFile*)Unsafe.AsPointer(ref this), pszFileName, fRemember);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SaveCompleted([NativeTypeName("LPCOLESTR")] ushort* pszFileName)
        {
            return ((delegate* unmanaged<IPersistFile*, ushort*, int>)(lpVtbl[7]))((IPersistFile*)Unsafe.AsPointer(ref this), pszFileName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetCurFile([NativeTypeName("LPOLESTR *")] ushort** ppszFileName)
        {
            return ((delegate* unmanaged<IPersistFile*, ushort**, int>)(lpVtbl[8]))((IPersistFile*)Unsafe.AsPointer(ref this), ppszFileName);
        }
    }
}
