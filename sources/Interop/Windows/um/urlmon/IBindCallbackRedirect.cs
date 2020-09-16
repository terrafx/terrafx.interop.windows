// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/urlmon.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("11C81BC2-121E-4ED5-B9C4-B430BD54F2C0")]
    [NativeTypeName("struct IBindCallbackRedirect : IUnknown")]
    public unsafe partial struct IBindCallbackRedirect
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IBindCallbackRedirect*, Guid*, void**, int>)(lpVtbl[0]))((IBindCallbackRedirect*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IBindCallbackRedirect*, uint>)(lpVtbl[1]))((IBindCallbackRedirect*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IBindCallbackRedirect*, uint>)(lpVtbl[2]))((IBindCallbackRedirect*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Redirect([NativeTypeName("LPCWSTR")] ushort* lpcUrl, [NativeTypeName("VARIANT_BOOL *")] short* vbCancel)
        {
            return ((delegate* unmanaged<IBindCallbackRedirect*, ushort*, short*, int>)(lpVtbl[3]))((IBindCallbackRedirect*)Unsafe.AsPointer(ref this), lpcUrl, vbCancel);
        }
    }
}
