// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/InkPresenterDesktop.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("73F3C0D9-2E8B-48F3-895E-20CBD27B723B")]
    [NativeTypeName("struct IInkPresenterDesktop : IUnknown")]
    public unsafe partial struct IInkPresenterDesktop
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IInkPresenterDesktop*, Guid*, void**, int>)(lpVtbl[0]))((IInkPresenterDesktop*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IInkPresenterDesktop*, uint>)(lpVtbl[1]))((IInkPresenterDesktop*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IInkPresenterDesktop*, uint>)(lpVtbl[2]))((IInkPresenterDesktop*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetRootVisual([NativeTypeName("IUnknown *")] IUnknown* rootVisual, [NativeTypeName("IUnknown *")] IUnknown* device)
        {
            return ((delegate* stdcall<IInkPresenterDesktop*, IUnknown*, IUnknown*, int>)(lpVtbl[3]))((IInkPresenterDesktop*)Unsafe.AsPointer(ref this), rootVisual, device);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetCommitRequestHandler([NativeTypeName("IInkCommitRequestHandler *")] IInkCommitRequestHandler* handler)
        {
            return ((delegate* stdcall<IInkPresenterDesktop*, IInkCommitRequestHandler*, int>)(lpVtbl[4]))((IInkPresenterDesktop*)Unsafe.AsPointer(ref this), handler);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetSize([NativeTypeName("float *")] float* width, [NativeTypeName("float *")] float* height)
        {
            return ((delegate* stdcall<IInkPresenterDesktop*, float*, float*, int>)(lpVtbl[5]))((IInkPresenterDesktop*)Unsafe.AsPointer(ref this), width, height);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetSize(float width, float height)
        {
            return ((delegate* stdcall<IInkPresenterDesktop*, float, float, int>)(lpVtbl[6]))((IInkPresenterDesktop*)Unsafe.AsPointer(ref this), width, height);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int OnHighContrastChanged()
        {
            return ((delegate* stdcall<IInkPresenterDesktop*, int>)(lpVtbl[7]))((IInkPresenterDesktop*)Unsafe.AsPointer(ref this));
        }
    }
}
