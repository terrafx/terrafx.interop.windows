// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.composition.interop.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("11F62CD1-2F9D-42D3-B05F-D6790D9E9F8E")]
    [NativeTypeName("struct IVisualInteractionSourceInterop : IUnknown")]
    public unsafe partial struct IVisualInteractionSourceInterop
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<IVisualInteractionSourceInterop*, Guid*, void**, int>)(lpVtbl[0]))((IVisualInteractionSourceInterop*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<IVisualInteractionSourceInterop*, uint>)(lpVtbl[1]))((IVisualInteractionSourceInterop*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<IVisualInteractionSourceInterop*, uint>)(lpVtbl[2]))((IVisualInteractionSourceInterop*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int TryRedirectForManipulation([NativeTypeName("const POINTER_INFO &")] POINTER_INFO* pointerInfo)
        {
            return ((delegate* unmanaged[Stdcall]<IVisualInteractionSourceInterop*, POINTER_INFO*, int>)(lpVtbl[3]))((IVisualInteractionSourceInterop*)Unsafe.AsPointer(ref this), pointerInfo);
        }
    }
}
