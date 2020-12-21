// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/control.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("56A868B8-0AD4-11CE-B03A-0020AF0BA770")]
    [NativeTypeName("struct IDeferredCommand : IUnknown")]
    public unsafe partial struct IDeferredCommand
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<IDeferredCommand*, Guid*, void**, int>)(lpVtbl[0]))((IDeferredCommand*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<IDeferredCommand*, uint>)(lpVtbl[1]))((IDeferredCommand*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<IDeferredCommand*, uint>)(lpVtbl[2]))((IDeferredCommand*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Cancel()
        {
            return ((delegate* unmanaged[Stdcall]<IDeferredCommand*, int>)(lpVtbl[3]))((IDeferredCommand*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Confidence([NativeTypeName("LONG *")] int* pConfidence)
        {
            return ((delegate* unmanaged[Stdcall]<IDeferredCommand*, int*, int>)(lpVtbl[4]))((IDeferredCommand*)Unsafe.AsPointer(ref this), pConfidence);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Postpone([NativeTypeName("REFTIME")] double newtime)
        {
            return ((delegate* unmanaged[Stdcall]<IDeferredCommand*, double, int>)(lpVtbl[5]))((IDeferredCommand*)Unsafe.AsPointer(ref this), newtime);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetHResult([NativeTypeName("HRESULT *")] int* phrResult)
        {
            return ((delegate* unmanaged[Stdcall]<IDeferredCommand*, int*, int>)(lpVtbl[6]))((IDeferredCommand*)Unsafe.AsPointer(ref this), phrResult);
        }
    }
}
