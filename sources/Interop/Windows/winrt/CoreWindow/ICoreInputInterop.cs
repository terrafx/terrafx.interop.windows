// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/CoreWindow.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("40BFE3E3-B75A-4479-AC96-475365749BB8")]
    [NativeTypeName("struct ICoreInputInterop : IUnknown")]
    public unsafe partial struct ICoreInputInterop
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<ICoreInputInterop*, Guid*, void**, int>)(lpVtbl[0]))((ICoreInputInterop*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<ICoreInputInterop*, uint>)(lpVtbl[1]))((ICoreInputInterop*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<ICoreInputInterop*, uint>)(lpVtbl[2]))((ICoreInputInterop*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetInputSource([NativeTypeName("IUnknown *")] IUnknown* value)
        {
            return ((delegate* stdcall<ICoreInputInterop*, IUnknown*, int>)(lpVtbl[3]))((ICoreInputInterop*)Unsafe.AsPointer(ref this), value);
        }

        [return: NativeTypeName("HRESULT")]
        public int put_MessageHandled([NativeTypeName("boolean")] byte value)
        {
            return ((delegate* stdcall<ICoreInputInterop*, byte, int>)(lpVtbl[4]))((ICoreInputInterop*)Unsafe.AsPointer(ref this), value);
        }
    }
}
