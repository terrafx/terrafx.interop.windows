// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("D0AE555D-3B12-4D97-B060-0990BC5AEB67")]
    [NativeTypeName("struct IMFSecureChannel : IUnknown")]
    public unsafe partial struct IMFSecureChannel
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IMFSecureChannel*, Guid*, void**, int>)(lpVtbl[0]))((IMFSecureChannel*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IMFSecureChannel*, uint>)(lpVtbl[1]))((IMFSecureChannel*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IMFSecureChannel*, uint>)(lpVtbl[2]))((IMFSecureChannel*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetCertificate([NativeTypeName("BYTE **")] byte** ppCert, [NativeTypeName("DWORD *")] uint* pcbCert)
        {
            return ((delegate* stdcall<IMFSecureChannel*, byte**, uint*, int>)(lpVtbl[3]))((IMFSecureChannel*)Unsafe.AsPointer(ref this), ppCert, pcbCert);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetupSession([NativeTypeName("BYTE *")] byte* pbEncryptedSessionKey, [NativeTypeName("DWORD")] uint cbSessionKey)
        {
            return ((delegate* stdcall<IMFSecureChannel*, byte*, uint, int>)(lpVtbl[4]))((IMFSecureChannel*)Unsafe.AsPointer(ref this), pbEncryptedSessionKey, cbSessionKey);
        }
    }
}
