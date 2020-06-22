// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfmediaengine.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("6A0083F9-8947-4C1D-9CE0-CDEE22B23135")]
    public unsafe partial struct IMFMediaKeySessionNotify
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IMFMediaKeySessionNotify*, Guid*, void**, int>)(lpVtbl[0]))((IMFMediaKeySessionNotify*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IMFMediaKeySessionNotify*, uint>)(lpVtbl[1]))((IMFMediaKeySessionNotify*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IMFMediaKeySessionNotify*, uint>)(lpVtbl[2]))((IMFMediaKeySessionNotify*)Unsafe.AsPointer(ref this));
        }

        public void KeyMessage([NativeTypeName("BSTR")] ushort* destinationURL, [NativeTypeName("const BYTE *")] byte* message, [NativeTypeName("DWORD")] uint cb)
        {
            ((delegate* stdcall<IMFMediaKeySessionNotify*, ushort*, byte*, uint, void>)(lpVtbl[3]))((IMFMediaKeySessionNotify*)Unsafe.AsPointer(ref this), destinationURL, message, cb);
        }

        public void KeyAdded()
        {
            ((delegate* stdcall<IMFMediaKeySessionNotify*, void>)(lpVtbl[4]))((IMFMediaKeySessionNotify*)Unsafe.AsPointer(ref this));
        }

        public void KeyError([NativeTypeName("USHORT")] ushort code, [NativeTypeName("DWORD")] uint systemCode)
        {
            ((delegate* stdcall<IMFMediaKeySessionNotify*, ushort, uint, void>)(lpVtbl[5]))((IMFMediaKeySessionNotify*)Unsafe.AsPointer(ref this), code, systemCode);
        }
    }
}
