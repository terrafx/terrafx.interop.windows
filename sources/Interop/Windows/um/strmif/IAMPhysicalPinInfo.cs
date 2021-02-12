// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("F938C991-3029-11CF-8C44-00AA006B6814")]
    [NativeTypeName("struct IAMPhysicalPinInfo : IUnknown")]
    public unsafe partial struct IAMPhysicalPinInfo
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IAMPhysicalPinInfo*, Guid*, void**, int>)(lpVtbl[0]))((IAMPhysicalPinInfo*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IAMPhysicalPinInfo*, uint>)(lpVtbl[1]))((IAMPhysicalPinInfo*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IAMPhysicalPinInfo*, uint>)(lpVtbl[2]))((IAMPhysicalPinInfo*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetPhysicalType([NativeTypeName("long *")] int* pType, [NativeTypeName("LPOLESTR *")] ushort** ppszType)
        {
            return ((delegate* unmanaged<IAMPhysicalPinInfo*, int*, ushort**, int>)(lpVtbl[3]))((IAMPhysicalPinInfo*)Unsafe.AsPointer(ref this), pType, ppszType);
        }
    }
}
