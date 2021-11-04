// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from dia2.h in the Debug Interface Access SDK
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the MIT License (MIT).

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("4688A074-5A4D-4486-AEA8-7B90711D9F7C")]
    [NativeTypeName("struct IDiaLoadCallback2 : IDiaLoadCallback")]
    [NativeInheritance("IDiaLoadCallback")]
    public unsafe partial struct IDiaLoadCallback2
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDiaLoadCallback2*, Guid*, void**, int>)(lpVtbl[0]))((IDiaLoadCallback2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDiaLoadCallback2*, uint>)(lpVtbl[1]))((IDiaLoadCallback2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDiaLoadCallback2*, uint>)(lpVtbl[2]))((IDiaLoadCallback2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT NotifyDebugDir(BOOL fExecutable, [NativeTypeName("DWORD")] uint cbData, byte* pbData)
        {
            return ((delegate* unmanaged<IDiaLoadCallback2*, BOOL, uint, byte*, int>)(lpVtbl[3]))((IDiaLoadCallback2*)Unsafe.AsPointer(ref this), fExecutable, cbData, pbData);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT NotifyOpenDBG([NativeTypeName("LPCOLESTR")] ushort* dbgPath, HRESULT resultCode)
        {
            return ((delegate* unmanaged<IDiaLoadCallback2*, ushort*, HRESULT, int>)(lpVtbl[4]))((IDiaLoadCallback2*)Unsafe.AsPointer(ref this), dbgPath, resultCode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT NotifyOpenPDB([NativeTypeName("LPCOLESTR")] ushort* pdbPath, HRESULT resultCode)
        {
            return ((delegate* unmanaged<IDiaLoadCallback2*, ushort*, HRESULT, int>)(lpVtbl[5]))((IDiaLoadCallback2*)Unsafe.AsPointer(ref this), pdbPath, resultCode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT RestrictRegistryAccess()
        {
            return ((delegate* unmanaged<IDiaLoadCallback2*, int>)(lpVtbl[6]))((IDiaLoadCallback2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT RestrictSymbolServerAccess()
        {
            return ((delegate* unmanaged<IDiaLoadCallback2*, int>)(lpVtbl[7]))((IDiaLoadCallback2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT RestrictOriginalPathAccess()
        {
            return ((delegate* unmanaged<IDiaLoadCallback2*, int>)(lpVtbl[8]))((IDiaLoadCallback2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT RestrictReferencePathAccess()
        {
            return ((delegate* unmanaged<IDiaLoadCallback2*, int>)(lpVtbl[9]))((IDiaLoadCallback2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT RestrictDBGAccess()
        {
            return ((delegate* unmanaged<IDiaLoadCallback2*, int>)(lpVtbl[10]))((IDiaLoadCallback2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT RestrictSystemRootAccess()
        {
            return ((delegate* unmanaged<IDiaLoadCallback2*, int>)(lpVtbl[11]))((IDiaLoadCallback2*)Unsafe.AsPointer(ref this));
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IDiaLoadCallback2*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IDiaLoadCallback2*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IDiaLoadCallback2*, uint> Release;

            [NativeTypeName("HRESULT (BOOL, DWORD, BYTE *) __attribute__((stdcall))")]
            public delegate* unmanaged<IDiaLoadCallback2*, BOOL, uint, byte*, int> NotifyDebugDir;

            [NativeTypeName("HRESULT (LPCOLESTR, HRESULT) __attribute__((stdcall))")]
            public delegate* unmanaged<IDiaLoadCallback2*, ushort*, HRESULT, int> NotifyOpenDBG;

            [NativeTypeName("HRESULT (LPCOLESTR, HRESULT) __attribute__((stdcall))")]
            public delegate* unmanaged<IDiaLoadCallback2*, ushort*, HRESULT, int> NotifyOpenPDB;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<IDiaLoadCallback2*, int> RestrictRegistryAccess;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<IDiaLoadCallback2*, int> RestrictSymbolServerAccess;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<IDiaLoadCallback2*, int> RestrictOriginalPathAccess;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<IDiaLoadCallback2*, int> RestrictReferencePathAccess;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<IDiaLoadCallback2*, int> RestrictDBGAccess;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<IDiaLoadCallback2*, int> RestrictSystemRootAccess;
        }
    }
}
