// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("77E425FC-CBF9-4307-BA6A-BB5727745661")]
    [NativeTypeName("struct IDeskBandInfo : IUnknown")]
    public unsafe partial struct IDeskBandInfo
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDeskBandInfo*, Guid*, void**, int>)(lpVtbl[0]))((IDeskBandInfo*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDeskBandInfo*, uint>)(lpVtbl[1]))((IDeskBandInfo*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDeskBandInfo*, uint>)(lpVtbl[2]))((IDeskBandInfo*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetDefaultBandWidth([NativeTypeName("DWORD")] uint dwBandID, [NativeTypeName("DWORD")] uint dwViewMode, int* pnWidth)
        {
            return ((delegate* unmanaged<IDeskBandInfo*, uint, uint, int*, int>)(lpVtbl[3]))((IDeskBandInfo*)Unsafe.AsPointer(ref this), dwBandID, dwViewMode, pnWidth);
        }
    }
}
