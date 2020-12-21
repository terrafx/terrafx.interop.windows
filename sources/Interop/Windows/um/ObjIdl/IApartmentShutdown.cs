// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ObjIdl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("A2F05A09-27A2-42B5-BC0E-AC163EF49D9B")]
    [NativeTypeName("struct IApartmentShutdown : IUnknown")]
    public unsafe partial struct IApartmentShutdown
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<IApartmentShutdown*, Guid*, void**, int>)(lpVtbl[0]))((IApartmentShutdown*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<IApartmentShutdown*, uint>)(lpVtbl[1]))((IApartmentShutdown*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<IApartmentShutdown*, uint>)(lpVtbl[2]))((IApartmentShutdown*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void OnUninitialize([NativeTypeName("UINT64")] ulong ui64ApartmentIdentifier)
        {
            ((delegate* unmanaged[Stdcall]<IApartmentShutdown*, ulong, void>)(lpVtbl[3]))((IApartmentShutdown*)Unsafe.AsPointer(ref this), ui64ApartmentIdentifier);
        }
    }
}
