// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/CoreWindow.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("0576AB31-A310-4C40-BA31-FD37E0298DFA")]
    [NativeTypeName("struct ICoreWindowComponentInterop : IUnknown")]
    public unsafe partial struct ICoreWindowComponentInterop
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<ICoreWindowComponentInterop*, Guid*, void**, int>)(lpVtbl[0]))((ICoreWindowComponentInterop*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<ICoreWindowComponentInterop*, uint>)(lpVtbl[1]))((ICoreWindowComponentInterop*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<ICoreWindowComponentInterop*, uint>)(lpVtbl[2]))((ICoreWindowComponentInterop*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int ConfigureComponentInput([NativeTypeName("UINT32")] uint hostViewInstanceId, [NativeTypeName("HWND")] IntPtr hwndHost, [NativeTypeName("IUnknown *")] IUnknown* inputSourceVisual)
        {
            return ((delegate* stdcall<ICoreWindowComponentInterop*, uint, IntPtr, IUnknown*, int>)(lpVtbl[3]))((ICoreWindowComponentInterop*)Unsafe.AsPointer(ref this), hostViewInstanceId, hwndHost, inputSourceVisual);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetViewInstanceId([NativeTypeName("UINT32 *")] uint* componentViewInstanceId)
        {
            return ((delegate* stdcall<ICoreWindowComponentInterop*, uint*, int>)(lpVtbl[4]))((ICoreWindowComponentInterop*)Unsafe.AsPointer(ref this), componentViewInstanceId);
        }
    }
}
