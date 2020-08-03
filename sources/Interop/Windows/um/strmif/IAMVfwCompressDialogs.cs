// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("D8D715A3-6E5E-11D0-B3F0-00AA003761C5")]
    public unsafe partial struct IAMVfwCompressDialogs
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IAMVfwCompressDialogs*, Guid*, void**, int>)(lpVtbl[0]))((IAMVfwCompressDialogs*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IAMVfwCompressDialogs*, uint>)(lpVtbl[1]))((IAMVfwCompressDialogs*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IAMVfwCompressDialogs*, uint>)(lpVtbl[2]))((IAMVfwCompressDialogs*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int ShowDialog(int iDialog, [NativeTypeName("HWND")] IntPtr hwnd)
        {
            return ((delegate* stdcall<IAMVfwCompressDialogs*, int, IntPtr, int>)(lpVtbl[3]))((IAMVfwCompressDialogs*)Unsafe.AsPointer(ref this), iDialog, hwnd);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetState([NativeTypeName("LPVOID")] void* pState, [NativeTypeName("int *")] int* pcbState)
        {
            return ((delegate* stdcall<IAMVfwCompressDialogs*, void*, int*, int>)(lpVtbl[4]))((IAMVfwCompressDialogs*)Unsafe.AsPointer(ref this), pState, pcbState);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetState([NativeTypeName("LPVOID")] void* pState, int cbState)
        {
            return ((delegate* stdcall<IAMVfwCompressDialogs*, void*, int, int>)(lpVtbl[5]))((IAMVfwCompressDialogs*)Unsafe.AsPointer(ref this), pState, cbState);
        }

        [return: NativeTypeName("HRESULT")]
        public int SendDriverMessage(int uMsg, [NativeTypeName("long")] int dw1, [NativeTypeName("long")] int dw2)
        {
            return ((delegate* stdcall<IAMVfwCompressDialogs*, int, int, int, int>)(lpVtbl[6]))((IAMVfwCompressDialogs*)Unsafe.AsPointer(ref this), uMsg, dw1, dw2);
        }
    }
}
