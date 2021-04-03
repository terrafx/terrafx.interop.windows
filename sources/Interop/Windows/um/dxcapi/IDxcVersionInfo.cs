// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dxcapi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the University of Illinois Open Source License.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("B04F5B50-2059-4F12-A8FF-A1E0CDE1CC7E")]
    [NativeTypeName("struct IDxcVersionInfo : IUnknown")]
    public unsafe partial struct IDxcVersionInfo
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDxcVersionInfo*, Guid*, void**, int>)(lpVtbl[0]))((IDxcVersionInfo*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDxcVersionInfo*, uint>)(lpVtbl[1]))((IDxcVersionInfo*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDxcVersionInfo*, uint>)(lpVtbl[2]))((IDxcVersionInfo*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetVersion([NativeTypeName("UINT32 *")] uint* pMajor, [NativeTypeName("UINT32 *")] uint* pMinor)
        {
            return ((delegate* unmanaged<IDxcVersionInfo*, uint*, uint*, int>)(lpVtbl[3]))((IDxcVersionInfo*)Unsafe.AsPointer(ref this), pMajor, pMinor);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetFlags([NativeTypeName("UINT32 *")] uint* pFlags)
        {
            return ((delegate* unmanaged<IDxcVersionInfo*, uint*, int>)(lpVtbl[4]))((IDxcVersionInfo*)Unsafe.AsPointer(ref this), pFlags);
        }
    }
}
