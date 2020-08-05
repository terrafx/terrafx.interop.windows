// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfobjects.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("C1209904-E584-4752-A2D6-7F21693F8B21")]
    [NativeTypeName("struct IMFSecureBuffer : IUnknown")]
    public unsafe partial struct IMFSecureBuffer
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IMFSecureBuffer*, Guid*, void**, int>)(lpVtbl[0]))((IMFSecureBuffer*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IMFSecureBuffer*, uint>)(lpVtbl[1]))((IMFSecureBuffer*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IMFSecureBuffer*, uint>)(lpVtbl[2]))((IMFSecureBuffer*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetIdentifier([NativeTypeName("GUID *")] Guid* pGuidIdentifier)
        {
            return ((delegate* stdcall<IMFSecureBuffer*, Guid*, int>)(lpVtbl[3]))((IMFSecureBuffer*)Unsafe.AsPointer(ref this), pGuidIdentifier);
        }
    }
}
