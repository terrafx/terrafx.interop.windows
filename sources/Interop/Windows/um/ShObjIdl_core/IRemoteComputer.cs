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
    public unsafe partial struct IRemoteComputer
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IRemoteComputer*, Guid*, void**, int>)(lpVtbl[0]))((IRemoteComputer*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IRemoteComputer*, uint>)(lpVtbl[1]))((IRemoteComputer*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IRemoteComputer*, uint>)(lpVtbl[2]))((IRemoteComputer*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Initialize([NativeTypeName("LPCWSTR")] ushort* pszMachine, [NativeTypeName("BOOL")] int bEnumerating)
        {
            return ((delegate* unmanaged<IRemoteComputer*, ushort*, int, int>)(lpVtbl[3]))((IRemoteComputer*)Unsafe.AsPointer(ref this), pszMachine, bEnumerating);
        }
    }
}
