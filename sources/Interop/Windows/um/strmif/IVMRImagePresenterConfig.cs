// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("9F3A1C85-8555-49BA-935F-BE5B5B29D178")]
    [NativeTypeName("struct IVMRImagePresenterConfig : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IVMRImagePresenterConfig
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IVMRImagePresenterConfig*, Guid*, void**, int>)(lpVtbl[0]))((IVMRImagePresenterConfig*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IVMRImagePresenterConfig*, uint>)(lpVtbl[1]))((IVMRImagePresenterConfig*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IVMRImagePresenterConfig*, uint>)(lpVtbl[2]))((IVMRImagePresenterConfig*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int SetRenderingPrefs([NativeTypeName("DWORD")] uint dwRenderFlags)
        {
            return ((delegate* unmanaged<IVMRImagePresenterConfig*, uint, int>)(lpVtbl[3]))((IVMRImagePresenterConfig*)Unsafe.AsPointer(ref this), dwRenderFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int GetRenderingPrefs([NativeTypeName("DWORD *")] uint* dwRenderFlags)
        {
            return ((delegate* unmanaged<IVMRImagePresenterConfig*, uint*, int>)(lpVtbl[4]))((IVMRImagePresenterConfig*)Unsafe.AsPointer(ref this), dwRenderFlags);
        }
    }
}
