// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("56A868AB-0AD4-11CE-B03A-0020AF0BA770")]
    [NativeTypeName("struct IGraphVersion : IUnknown")]
    public unsafe partial struct IGraphVersion
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IGraphVersion*, Guid*, void**, int>)(lpVtbl[0]))((IGraphVersion*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IGraphVersion*, uint>)(lpVtbl[1]))((IGraphVersion*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IGraphVersion*, uint>)(lpVtbl[2]))((IGraphVersion*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryVersion([NativeTypeName("LONG *")] int* pVersion)
        {
            return ((delegate* unmanaged<IGraphVersion*, int*, int>)(lpVtbl[3]))((IGraphVersion*)Unsafe.AsPointer(ref this), pVersion);
        }
    }
}
