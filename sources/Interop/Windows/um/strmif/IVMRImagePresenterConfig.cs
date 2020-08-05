// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("9F3A1C85-8555-49BA-935F-BE5B5B29D178")]
    [NativeTypeName("struct IVMRImagePresenterConfig : IUnknown")]
    public unsafe partial struct IVMRImagePresenterConfig
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IVMRImagePresenterConfig*, Guid*, void**, int>)(lpVtbl[0]))((IVMRImagePresenterConfig*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IVMRImagePresenterConfig*, uint>)(lpVtbl[1]))((IVMRImagePresenterConfig*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IVMRImagePresenterConfig*, uint>)(lpVtbl[2]))((IVMRImagePresenterConfig*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetRenderingPrefs([NativeTypeName("DWORD")] uint dwRenderFlags)
        {
            return ((delegate* stdcall<IVMRImagePresenterConfig*, uint, int>)(lpVtbl[3]))((IVMRImagePresenterConfig*)Unsafe.AsPointer(ref this), dwRenderFlags);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetRenderingPrefs([NativeTypeName("DWORD *")] uint* dwRenderFlags)
        {
            return ((delegate* stdcall<IVMRImagePresenterConfig*, uint*, int>)(lpVtbl[4]))((IVMRImagePresenterConfig*)Unsafe.AsPointer(ref this), dwRenderFlags);
        }
    }
}
