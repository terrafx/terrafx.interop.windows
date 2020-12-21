// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("FFF4AF3A-1FC1-4EF9-A29B-D26C49E2F31A")]
    [NativeTypeName("struct IMFSystemId : IUnknown")]
    public unsafe partial struct IMFSystemId
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<IMFSystemId*, Guid*, void**, int>)(lpVtbl[0]))((IMFSystemId*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<IMFSystemId*, uint>)(lpVtbl[1]))((IMFSystemId*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<IMFSystemId*, uint>)(lpVtbl[2]))((IMFSystemId*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetData([NativeTypeName("UINT32 *")] uint* size, [NativeTypeName("BYTE **")] byte** data)
        {
            return ((delegate* unmanaged[Stdcall]<IMFSystemId*, uint*, byte**, int>)(lpVtbl[3]))((IMFSystemId*)Unsafe.AsPointer(ref this), size, data);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Setup([NativeTypeName("UINT32")] uint stage, [NativeTypeName("UINT32")] uint cbIn, [NativeTypeName("const BYTE *")] byte* pbIn, [NativeTypeName("UINT32 *")] uint* pcbOut, [NativeTypeName("BYTE **")] byte** ppbOut)
        {
            return ((delegate* unmanaged[Stdcall]<IMFSystemId*, uint, uint, byte*, uint*, byte**, int>)(lpVtbl[4]))((IMFSystemId*)Unsafe.AsPointer(ref this), stage, cbIn, pbIn, pcbOut, ppbOut);
        }
    }
}
