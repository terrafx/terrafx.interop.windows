// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ObjIdlbase.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("00000022-0000-0000-C000-000000000046")]
    [NativeTypeName("struct ISurrogate : IUnknown")]
    public unsafe partial struct ISurrogate
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<ISurrogate*, Guid*, void**, int>)(lpVtbl[0]))((ISurrogate*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<ISurrogate*, uint>)(lpVtbl[1]))((ISurrogate*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<ISurrogate*, uint>)(lpVtbl[2]))((ISurrogate*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int LoadDllServer([NativeTypeName("const IID &")] Guid* Clsid)
        {
            return ((delegate* stdcall<ISurrogate*, Guid*, int>)(lpVtbl[3]))((ISurrogate*)Unsafe.AsPointer(ref this), Clsid);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int FreeSurrogate()
        {
            return ((delegate* stdcall<ISurrogate*, int>)(lpVtbl[4]))((ISurrogate*)Unsafe.AsPointer(ref this));
        }
    }
}
