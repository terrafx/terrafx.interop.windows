// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WindowsStorageCOM.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("A65C9109-42AB-4B94-A7B1-DD2E4E68515E")]
    [NativeTypeName("struct IUnbufferedFileHandleProvider : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IUnbufferedFileHandleProvider
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IUnbufferedFileHandleProvider*, Guid*, void**, int>)(lpVtbl[0]))((IUnbufferedFileHandleProvider*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IUnbufferedFileHandleProvider*, uint>)(lpVtbl[1]))((IUnbufferedFileHandleProvider*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IUnbufferedFileHandleProvider*, uint>)(lpVtbl[2]))((IUnbufferedFileHandleProvider*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT OpenUnbufferedFileHandle(IUnbufferedFileHandleOplockCallback* oplockBreakCallback, [NativeTypeName("DWORD_PTR *")] nuint* fileHandle)
        {
            return ((delegate* unmanaged<IUnbufferedFileHandleProvider*, IUnbufferedFileHandleOplockCallback*, nuint*, int>)(lpVtbl[3]))((IUnbufferedFileHandleProvider*)Unsafe.AsPointer(ref this), oplockBreakCallback, fileHandle);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT CloseUnbufferedFileHandle()
        {
            return ((delegate* unmanaged<IUnbufferedFileHandleProvider*, int>)(lpVtbl[4]))((IUnbufferedFileHandleProvider*)Unsafe.AsPointer(ref this));
        }
    }
}
