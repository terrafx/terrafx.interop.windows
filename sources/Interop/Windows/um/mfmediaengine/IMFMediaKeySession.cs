// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfmediaengine.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("24FA67D5-D1D0-4DC5-995C-C0EFDC191FB5")]
    public unsafe partial struct IMFMediaKeySession
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IMFMediaKeySession*, Guid*, void**, int>)(lpVtbl[0]))((IMFMediaKeySession*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IMFMediaKeySession*, uint>)(lpVtbl[1]))((IMFMediaKeySession*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IMFMediaKeySession*, uint>)(lpVtbl[2]))((IMFMediaKeySession*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetError([NativeTypeName("USHORT *")] ushort* code, [NativeTypeName("DWORD *")] uint* systemCode)
        {
            return ((delegate* stdcall<IMFMediaKeySession*, ushort*, uint*, int>)(lpVtbl[3]))((IMFMediaKeySession*)Unsafe.AsPointer(ref this), code, systemCode);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_KeySystem([NativeTypeName("BSTR *")] ushort** keySystem)
        {
            return ((delegate* stdcall<IMFMediaKeySession*, ushort**, int>)(lpVtbl[4]))((IMFMediaKeySession*)Unsafe.AsPointer(ref this), keySystem);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_SessionId([NativeTypeName("BSTR *")] ushort** sessionId)
        {
            return ((delegate* stdcall<IMFMediaKeySession*, ushort**, int>)(lpVtbl[5]))((IMFMediaKeySession*)Unsafe.AsPointer(ref this), sessionId);
        }

        [return: NativeTypeName("HRESULT")]
        public int Update([NativeTypeName("const BYTE *")] byte* key, [NativeTypeName("DWORD")] uint cb)
        {
            return ((delegate* stdcall<IMFMediaKeySession*, byte*, uint, int>)(lpVtbl[6]))((IMFMediaKeySession*)Unsafe.AsPointer(ref this), key, cb);
        }

        [return: NativeTypeName("HRESULT")]
        public int Close()
        {
            return ((delegate* stdcall<IMFMediaKeySession*, int>)(lpVtbl[7]))((IMFMediaKeySession*)Unsafe.AsPointer(ref this));
        }
    }
}
