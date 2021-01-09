// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/CastingInterop.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("F0A56423-A664-4FBD-8B43-409A45E8D9A1")]
    [NativeTypeName("struct ICastingController : IUnknown")]
    public unsafe partial struct ICastingController
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<ICastingController*, Guid*, void**, int>)(lpVtbl[0]))((ICastingController*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ICastingController*, uint>)(lpVtbl[1]))((ICastingController*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ICastingController*, uint>)(lpVtbl[2]))((ICastingController*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Initialize([NativeTypeName("IUnknown *")] IUnknown* castingEngine, [NativeTypeName("IUnknown *")] IUnknown* castingSource)
        {
            return ((delegate* unmanaged<ICastingController*, IUnknown*, IUnknown*, int>)(lpVtbl[3]))((ICastingController*)Unsafe.AsPointer(ref this), castingEngine, castingSource);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Connect()
        {
            return ((delegate* unmanaged<ICastingController*, int>)(lpVtbl[4]))((ICastingController*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Disconnect()
        {
            return ((delegate* unmanaged<ICastingController*, int>)(lpVtbl[5]))((ICastingController*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Advise([NativeTypeName("ICastingEventHandler *")] ICastingEventHandler* eventHandler, [NativeTypeName("DWORD *")] uint* cookie)
        {
            return ((delegate* unmanaged<ICastingController*, ICastingEventHandler*, uint*, int>)(lpVtbl[6]))((ICastingController*)Unsafe.AsPointer(ref this), eventHandler, cookie);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int UnAdvise([NativeTypeName("DWORD")] uint cookie)
        {
            return ((delegate* unmanaged<ICastingController*, uint, int>)(lpVtbl[7]))((ICastingController*)Unsafe.AsPointer(ref this), cookie);
        }
    }
}
