// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ObjIdlbase.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("00000018-0000-0000-C000-000000000046")]
    [NativeTypeName("struct IStdMarshalInfo : IUnknown")]
    public unsafe partial struct IStdMarshalInfo
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IStdMarshalInfo*, Guid*, void**, int>)(lpVtbl[0]))((IStdMarshalInfo*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IStdMarshalInfo*, uint>)(lpVtbl[1]))((IStdMarshalInfo*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IStdMarshalInfo*, uint>)(lpVtbl[2]))((IStdMarshalInfo*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetClassForHandler([NativeTypeName("DWORD")] uint dwDestContext, [NativeTypeName("void *")] void* pvDestContext, [NativeTypeName("CLSID *")] Guid* pClsid)
        {
            return ((delegate* unmanaged<IStdMarshalInfo*, uint, void*, Guid*, int>)(lpVtbl[3]))((IStdMarshalInfo*)Unsafe.AsPointer(ref this), dwDestContext, pvDestContext, pClsid);
        }
    }
}
