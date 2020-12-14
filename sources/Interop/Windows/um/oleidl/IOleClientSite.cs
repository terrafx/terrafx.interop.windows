// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/oleidl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("00000118-0000-0000-C000-000000000046")]
    [NativeTypeName("struct IOleClientSite : IUnknown")]
    public unsafe partial struct IOleClientSite
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IOleClientSite*, Guid*, void**, int>)(lpVtbl[0]))((IOleClientSite*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IOleClientSite*, uint>)(lpVtbl[1]))((IOleClientSite*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IOleClientSite*, uint>)(lpVtbl[2]))((IOleClientSite*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SaveObject()
        {
            return ((delegate* unmanaged<IOleClientSite*, int>)(lpVtbl[3]))((IOleClientSite*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetMoniker([NativeTypeName("DWORD")] uint dwAssign, [NativeTypeName("DWORD")] uint dwWhichMoniker, [NativeTypeName("IMoniker **")] IMoniker** ppmk)
        {
            return ((delegate* unmanaged<IOleClientSite*, uint, uint, IMoniker**, int>)(lpVtbl[4]))((IOleClientSite*)Unsafe.AsPointer(ref this), dwAssign, dwWhichMoniker, ppmk);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetContainer([NativeTypeName("IOleContainer **")] IOleContainer** ppContainer)
        {
            return ((delegate* unmanaged<IOleClientSite*, IOleContainer**, int>)(lpVtbl[5]))((IOleClientSite*)Unsafe.AsPointer(ref this), ppContainer);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ShowObject()
        {
            return ((delegate* unmanaged<IOleClientSite*, int>)(lpVtbl[6]))((IOleClientSite*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int OnShowWindow([NativeTypeName("BOOL")] int fShow)
        {
            return ((delegate* unmanaged<IOleClientSite*, int, int>)(lpVtbl[7]))((IOleClientSite*)Unsafe.AsPointer(ref this), fShow);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int RequestNewObjectLayout()
        {
            return ((delegate* unmanaged<IOleClientSite*, int>)(lpVtbl[8]))((IOleClientSite*)Unsafe.AsPointer(ref this));
        }
    }
}
