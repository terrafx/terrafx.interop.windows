// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/WeakReference.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("00000038-0000-0000-C000-000000000046")]
    [NativeTypeName("struct IWeakReferenceSource : IUnknown")]
    public unsafe partial struct IWeakReferenceSource
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IWeakReferenceSource*, Guid*, void**, int>)(lpVtbl[0]))((IWeakReferenceSource*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IWeakReferenceSource*, uint>)(lpVtbl[1]))((IWeakReferenceSource*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IWeakReferenceSource*, uint>)(lpVtbl[2]))((IWeakReferenceSource*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetWeakReference(IWeakReference** weakReference)
        {
            return ((delegate* unmanaged<IWeakReferenceSource*, IWeakReference**, int>)(lpVtbl[3]))((IWeakReferenceSource*)Unsafe.AsPointer(ref this), weakReference);
        }
    }
}
