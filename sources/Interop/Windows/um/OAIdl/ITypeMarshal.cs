// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/OAIdl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("0000002D-0000-0000-C000-000000000046")]
    [NativeTypeName("struct ITypeMarshal : IUnknown")]
    public unsafe partial struct ITypeMarshal
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<ITypeMarshal*, Guid*, void**, int>)(lpVtbl[0]))((ITypeMarshal*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<ITypeMarshal*, uint>)(lpVtbl[1]))((ITypeMarshal*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<ITypeMarshal*, uint>)(lpVtbl[2]))((ITypeMarshal*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int Size([NativeTypeName("PVOID")] void* pvType, [NativeTypeName("DWORD")] uint dwDestContext, [NativeTypeName("PVOID")] void* pvDestContext, [NativeTypeName("ULONG *")] uint* pSize)
        {
            return ((delegate* stdcall<ITypeMarshal*, void*, uint, void*, uint*, int>)(lpVtbl[3]))((ITypeMarshal*)Unsafe.AsPointer(ref this), pvType, dwDestContext, pvDestContext, pSize);
        }

        [return: NativeTypeName("HRESULT")]
        public int Marshal([NativeTypeName("PVOID")] void* pvType, [NativeTypeName("DWORD")] uint dwDestContext, [NativeTypeName("PVOID")] void* pvDestContext, [NativeTypeName("ULONG")] uint cbBufferLength, [NativeTypeName("BYTE *")] byte* pBuffer, [NativeTypeName("ULONG *")] uint* pcbWritten)
        {
            return ((delegate* stdcall<ITypeMarshal*, void*, uint, void*, uint, byte*, uint*, int>)(lpVtbl[4]))((ITypeMarshal*)Unsafe.AsPointer(ref this), pvType, dwDestContext, pvDestContext, cbBufferLength, pBuffer, pcbWritten);
        }

        [return: NativeTypeName("HRESULT")]
        public int Unmarshal([NativeTypeName("PVOID")] void* pvType, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("ULONG")] uint cbBufferLength, [NativeTypeName("BYTE *")] byte* pBuffer, [NativeTypeName("ULONG *")] uint* pcbRead)
        {
            return ((delegate* stdcall<ITypeMarshal*, void*, uint, uint, byte*, uint*, int>)(lpVtbl[5]))((ITypeMarshal*)Unsafe.AsPointer(ref this), pvType, dwFlags, cbBufferLength, pBuffer, pcbRead);
        }

        [return: NativeTypeName("HRESULT")]
        public int Free([NativeTypeName("PVOID")] void* pvType)
        {
            return ((delegate* stdcall<ITypeMarshal*, void*, int>)(lpVtbl[6]))((ITypeMarshal*)Unsafe.AsPointer(ref this), pvType);
        }
    }
}
