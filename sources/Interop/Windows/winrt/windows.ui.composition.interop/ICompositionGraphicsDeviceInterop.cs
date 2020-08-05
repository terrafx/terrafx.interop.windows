// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.composition.interop.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("A116FF71-F8BF-4C8A-9C98-70779A32A9C8")]
    [NativeTypeName("struct ICompositionGraphicsDeviceInterop : IUnknown")]
    public unsafe partial struct ICompositionGraphicsDeviceInterop
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<ICompositionGraphicsDeviceInterop*, Guid*, void**, int>)(lpVtbl[0]))((ICompositionGraphicsDeviceInterop*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<ICompositionGraphicsDeviceInterop*, uint>)(lpVtbl[1]))((ICompositionGraphicsDeviceInterop*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<ICompositionGraphicsDeviceInterop*, uint>)(lpVtbl[2]))((ICompositionGraphicsDeviceInterop*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetRenderingDevice([NativeTypeName("IUnknown **")] IUnknown** value)
        {
            return ((delegate* stdcall<ICompositionGraphicsDeviceInterop*, IUnknown**, int>)(lpVtbl[3]))((ICompositionGraphicsDeviceInterop*)Unsafe.AsPointer(ref this), value);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetRenderingDevice([NativeTypeName("IUnknown *")] IUnknown* value)
        {
            return ((delegate* stdcall<ICompositionGraphicsDeviceInterop*, IUnknown*, int>)(lpVtbl[4]))((ICompositionGraphicsDeviceInterop*)Unsafe.AsPointer(ref this), value);
        }
    }
}
