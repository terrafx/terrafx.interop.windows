// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WindowsStorageCOM.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("D1019A0E-6243-4329-8497-2E75894D7710")]
    [NativeTypeName("struct IUnbufferedFileHandleOplockCallback : IUnknown")]
    public unsafe partial struct IUnbufferedFileHandleOplockCallback
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IUnbufferedFileHandleOplockCallback*, Guid*, void**, int>)(lpVtbl[0]))((IUnbufferedFileHandleOplockCallback*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IUnbufferedFileHandleOplockCallback*, uint>)(lpVtbl[1]))((IUnbufferedFileHandleOplockCallback*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IUnbufferedFileHandleOplockCallback*, uint>)(lpVtbl[2]))((IUnbufferedFileHandleOplockCallback*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int OnBrokenCallback()
        {
            return ((delegate* unmanaged<IUnbufferedFileHandleOplockCallback*, int>)(lpVtbl[3]))((IUnbufferedFileHandleOplockCallback*)Unsafe.AsPointer(ref this));
        }
    }
}
