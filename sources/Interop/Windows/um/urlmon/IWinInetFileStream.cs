// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/urlmon.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("F134C4B7-B1F8-4E75-B886-74B90943BECB")]
    public unsafe partial struct IWinInetFileStream
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IWinInetFileStream*, Guid*, void**, int>)(lpVtbl[0]))((IWinInetFileStream*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IWinInetFileStream*, uint>)(lpVtbl[1]))((IWinInetFileStream*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IWinInetFileStream*, uint>)(lpVtbl[2]))((IWinInetFileStream*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetHandleForUnlock([NativeTypeName("DWORD_PTR")] nuint hWinInetLockHandle, [NativeTypeName("DWORD_PTR")] nuint dwReserved)
        {
            return ((delegate* stdcall<IWinInetFileStream*, nuint, nuint, int>)(lpVtbl[3]))((IWinInetFileStream*)Unsafe.AsPointer(ref this), hWinInetLockHandle, dwReserved);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetDeleteFile([NativeTypeName("DWORD_PTR")] nuint dwReserved)
        {
            return ((delegate* stdcall<IWinInetFileStream*, nuint, int>)(lpVtbl[4]))((IWinInetFileStream*)Unsafe.AsPointer(ref this), dwReserved);
        }
    }
}
