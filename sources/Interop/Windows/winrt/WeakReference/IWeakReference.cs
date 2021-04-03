// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/WeakReference.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("00000037-0000-0000-C000-000000000046")]
    [NativeTypeName("struct IWeakReference : IUnknown")]
    public unsafe partial struct IWeakReference
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IWeakReference*, Guid*, void**, int>)(lpVtbl[0]))((IWeakReference*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IWeakReference*, uint>)(lpVtbl[1]))((IWeakReference*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IWeakReference*, uint>)(lpVtbl[2]))((IWeakReference*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Resolve([NativeTypeName("const IID &")] Guid* riid, IInspectable** objectReference)
        {
            return ((delegate* unmanaged<IWeakReference*, Guid*, IInspectable**, int>)(lpVtbl[3]))((IWeakReference*)Unsafe.AsPointer(ref this), riid, objectReference);
        }
    }
}
