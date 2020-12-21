// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ObjIdlbase.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("0000002A-0000-0000-C000-000000000046")]
    [NativeTypeName("struct IAsyncManager : IUnknown")]
    public unsafe partial struct IAsyncManager
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<IAsyncManager*, Guid*, void**, int>)(lpVtbl[0]))((IAsyncManager*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<IAsyncManager*, uint>)(lpVtbl[1]))((IAsyncManager*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<IAsyncManager*, uint>)(lpVtbl[2]))((IAsyncManager*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CompleteCall([NativeTypeName("HRESULT")] int Result)
        {
            return ((delegate* unmanaged[Stdcall]<IAsyncManager*, int, int>)(lpVtbl[3]))((IAsyncManager*)Unsafe.AsPointer(ref this), Result);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetCallContext([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** pInterface)
        {
            return ((delegate* unmanaged[Stdcall]<IAsyncManager*, Guid*, void**, int>)(lpVtbl[4]))((IAsyncManager*)Unsafe.AsPointer(ref this), riid, pInterface);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetState([NativeTypeName("ULONG *")] uint* pulStateFlags)
        {
            return ((delegate* unmanaged[Stdcall]<IAsyncManager*, uint*, int>)(lpVtbl[5]))((IAsyncManager*)Unsafe.AsPointer(ref this), pulStateFlags);
        }
    }
}
