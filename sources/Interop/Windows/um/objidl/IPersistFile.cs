// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/objidl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("0000010B-0000-0000-C000-000000000046")]
    [NativeTypeName("struct IPersistFile : IPersist")]
    [NativeInheritance("IPersist")]
    public unsafe partial struct IPersistFile : IPersistFile.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IPersistFile*, Guid*, void**, int>)(lpVtbl[0]))((IPersistFile*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IPersistFile*, uint>)(lpVtbl[1]))((IPersistFile*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IPersistFile*, uint>)(lpVtbl[2]))((IPersistFile*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetClassID([NativeTypeName("CLSID *")] Guid* pClassID)
        {
            return ((delegate* unmanaged<IPersistFile*, Guid*, int>)(lpVtbl[3]))((IPersistFile*)Unsafe.AsPointer(ref this), pClassID);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT IsDirty()
        {
            return ((delegate* unmanaged<IPersistFile*, int>)(lpVtbl[4]))((IPersistFile*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT Load([NativeTypeName("LPCOLESTR")] ushort* pszFileName, [NativeTypeName("DWORD")] uint dwMode)
        {
            return ((delegate* unmanaged<IPersistFile*, ushort*, uint, int>)(lpVtbl[5]))((IPersistFile*)Unsafe.AsPointer(ref this), pszFileName, dwMode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT Save([NativeTypeName("LPCOLESTR")] ushort* pszFileName, BOOL fRemember)
        {
            return ((delegate* unmanaged<IPersistFile*, ushort*, BOOL, int>)(lpVtbl[6]))((IPersistFile*)Unsafe.AsPointer(ref this), pszFileName, fRemember);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT SaveCompleted([NativeTypeName("LPCOLESTR")] ushort* pszFileName)
        {
            return ((delegate* unmanaged<IPersistFile*, ushort*, int>)(lpVtbl[7]))((IPersistFile*)Unsafe.AsPointer(ref this), pszFileName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT GetCurFile([NativeTypeName("LPOLESTR *")] ushort** ppszFileName)
        {
            return ((delegate* unmanaged<IPersistFile*, ushort**, int>)(lpVtbl[8]))((IPersistFile*)Unsafe.AsPointer(ref this), ppszFileName);
        }

        public interface Interface : IPersist.Interface
        {
            [VtblIndex(4)]
            HRESULT IsDirty();

            [VtblIndex(5)]
            HRESULT Load([NativeTypeName("LPCOLESTR")] ushort* pszFileName, [NativeTypeName("DWORD")] uint dwMode);

            [VtblIndex(6)]
            HRESULT Save([NativeTypeName("LPCOLESTR")] ushort* pszFileName, BOOL fRemember);

            [VtblIndex(7)]
            HRESULT SaveCompleted([NativeTypeName("LPCOLESTR")] ushort* pszFileName);

            [VtblIndex(8)]
            HRESULT GetCurFile([NativeTypeName("LPOLESTR *")] ushort** ppszFileName);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IPersistFile*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IPersistFile*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IPersistFile*, uint> Release;

            [NativeTypeName("HRESULT (CLSID *) __attribute__((stdcall))")]
            public delegate* unmanaged<IPersistFile*, Guid*, int> GetClassID;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<IPersistFile*, int> IsDirty;

            [NativeTypeName("HRESULT (LPCOLESTR, DWORD) __attribute__((stdcall))")]
            public delegate* unmanaged<IPersistFile*, ushort*, uint, int> Load;

            [NativeTypeName("HRESULT (LPCOLESTR, BOOL) __attribute__((stdcall))")]
            public delegate* unmanaged<IPersistFile*, ushort*, BOOL, int> Save;

            [NativeTypeName("HRESULT (LPCOLESTR) __attribute__((stdcall))")]
            public delegate* unmanaged<IPersistFile*, ushort*, int> SaveCompleted;

            [NativeTypeName("HRESULT (LPOLESTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<IPersistFile*, ushort**, int> GetCurFile;
        }
    }
}
