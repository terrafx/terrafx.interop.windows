// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ObjIdl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("000001D5-0000-0000-C000-000000000046")]
    [NativeTypeName("struct IProcessLock : IUnknown")]
    public unsafe partial struct IProcessLock
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<IProcessLock*, Guid*, void**, int>)(lpVtbl[0]))((IProcessLock*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<IProcessLock*, uint>)(lpVtbl[1]))((IProcessLock*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<IProcessLock*, uint>)(lpVtbl[2]))((IProcessLock*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRefOnProcess()
        {
            return ((delegate* unmanaged[Stdcall]<IProcessLock*, uint>)(lpVtbl[3]))((IProcessLock*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint ReleaseRefOnProcess()
        {
            return ((delegate* unmanaged[Stdcall]<IProcessLock*, uint>)(lpVtbl[4]))((IProcessLock*)Unsafe.AsPointer(ref this));
        }
    }
}
