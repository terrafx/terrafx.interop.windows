// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("12337D35-94C6-48A0-BCE7-6A9C69D4D600")]
    [NativeTypeName("struct IApplicationDestinations : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IApplicationDestinations
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IApplicationDestinations*, Guid*, void**, int>)(lpVtbl[0]))((IApplicationDestinations*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IApplicationDestinations*, uint>)(lpVtbl[1]))((IApplicationDestinations*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IApplicationDestinations*, uint>)(lpVtbl[2]))((IApplicationDestinations*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int SetAppID([NativeTypeName("LPCWSTR")] ushort* pszAppID)
        {
            return ((delegate* unmanaged<IApplicationDestinations*, ushort*, int>)(lpVtbl[3]))((IApplicationDestinations*)Unsafe.AsPointer(ref this), pszAppID);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int RemoveDestination(IUnknown* punk)
        {
            return ((delegate* unmanaged<IApplicationDestinations*, IUnknown*, int>)(lpVtbl[4]))((IApplicationDestinations*)Unsafe.AsPointer(ref this), punk);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int RemoveAllDestinations()
        {
            return ((delegate* unmanaged<IApplicationDestinations*, int>)(lpVtbl[5]))((IApplicationDestinations*)Unsafe.AsPointer(ref this));
        }
    }
}
