// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/urlmon.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("A5CA5F7F-1847-4D87-9C5B-918509F7511D")]
    [NativeTypeName("struct IMonikerProp : IUnknown")]
    public unsafe partial struct IMonikerProp
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IMonikerProp*, Guid*, void**, int>)(lpVtbl[0]))((IMonikerProp*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IMonikerProp*, uint>)(lpVtbl[1]))((IMonikerProp*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IMonikerProp*, uint>)(lpVtbl[2]))((IMonikerProp*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int PutProperty(MONIKERPROPERTY mkp, [NativeTypeName("LPCWSTR")] ushort* val)
        {
            return ((delegate* stdcall<IMonikerProp*, MONIKERPROPERTY, ushort*, int>)(lpVtbl[3]))((IMonikerProp*)Unsafe.AsPointer(ref this), mkp, val);
        }
    }
}
