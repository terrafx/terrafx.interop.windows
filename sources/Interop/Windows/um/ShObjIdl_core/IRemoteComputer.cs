// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("000214FE-0000-0000-C000-000000000046")]
    [NativeTypeName("struct IRemoteComputer : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IRemoteComputer : IRemoteComputer.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IRemoteComputer*, Guid*, void**, int>)(lpVtbl[0]))((IRemoteComputer*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IRemoteComputer*, uint>)(lpVtbl[1]))((IRemoteComputer*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IRemoteComputer*, uint>)(lpVtbl[2]))((IRemoteComputer*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT Initialize([NativeTypeName("LPCWSTR")] ushort* pszMachine, BOOL bEnumerating)
        {
            return ((delegate* unmanaged<IRemoteComputer*, ushort*, BOOL, int>)(lpVtbl[3]))((IRemoteComputer*)Unsafe.AsPointer(ref this), pszMachine, bEnumerating);
        }

        public interface Interface : IUnknown.Interface
        {
            [VtblIndex(3)]
            HRESULT Initialize([NativeTypeName("LPCWSTR")] ushort* pszMachine, BOOL bEnumerating);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IRemoteComputer*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IRemoteComputer*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IRemoteComputer*, uint> Release;

            [NativeTypeName("HRESULT (LPCWSTR, BOOL) __attribute__((stdcall))")]
            public delegate* unmanaged<IRemoteComputer*, ushort*, BOOL, int> Initialize;
        }
    }
}
