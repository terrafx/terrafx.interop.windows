// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ObjIdlbase.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("0000015B-0000-0000-C000-000000000046")]
    [NativeTypeName("struct IGlobalOptions : IUnknown")]
    public unsafe partial struct IGlobalOptions
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IGlobalOptions*, Guid*, void**, int>)(lpVtbl[0]))((IGlobalOptions*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IGlobalOptions*, uint>)(lpVtbl[1]))((IGlobalOptions*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IGlobalOptions*, uint>)(lpVtbl[2]))((IGlobalOptions*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Set(GLOBALOPT_PROPERTIES dwProperty, [NativeTypeName("ULONG_PTR")] nuint dwValue)
        {
            return ((delegate* unmanaged<IGlobalOptions*, GLOBALOPT_PROPERTIES, nuint, int>)(lpVtbl[3]))((IGlobalOptions*)Unsafe.AsPointer(ref this), dwProperty, dwValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Query(GLOBALOPT_PROPERTIES dwProperty, [NativeTypeName("ULONG_PTR *")] nuint* pdwValue)
        {
            return ((delegate* unmanaged<IGlobalOptions*, GLOBALOPT_PROPERTIES, nuint*, int>)(lpVtbl[4]))((IGlobalOptions*)Unsafe.AsPointer(ref this), dwProperty, pdwValue);
        }
    }
}
