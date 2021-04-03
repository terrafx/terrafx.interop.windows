// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/oleidl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("00000129-0000-0000-C000-000000000046")]
    [NativeTypeName("struct IOleCacheControl : IUnknown")]
    public unsafe partial struct IOleCacheControl
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IOleCacheControl*, Guid*, void**, int>)(lpVtbl[0]))((IOleCacheControl*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IOleCacheControl*, uint>)(lpVtbl[1]))((IOleCacheControl*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IOleCacheControl*, uint>)(lpVtbl[2]))((IOleCacheControl*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int OnRun([NativeTypeName("LPDATAOBJECT")] IDataObject* pDataObject)
        {
            return ((delegate* unmanaged<IOleCacheControl*, IDataObject*, int>)(lpVtbl[3]))((IOleCacheControl*)Unsafe.AsPointer(ref this), pDataObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int OnStop()
        {
            return ((delegate* unmanaged<IOleCacheControl*, int>)(lpVtbl[4]))((IOleCacheControl*)Unsafe.AsPointer(ref this));
        }
    }
}
