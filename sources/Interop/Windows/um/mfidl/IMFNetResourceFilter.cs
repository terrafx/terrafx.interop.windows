// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("091878A3-BF11-4A5C-BC9F-33995B06EF2D")]
    [NativeTypeName("struct IMFNetResourceFilter : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IMFNetResourceFilter
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IMFNetResourceFilter*, Guid*, void**, int>)(lpVtbl[0]))((IMFNetResourceFilter*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IMFNetResourceFilter*, uint>)(lpVtbl[1]))((IMFNetResourceFilter*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IMFNetResourceFilter*, uint>)(lpVtbl[2]))((IMFNetResourceFilter*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT OnRedirect([NativeTypeName("LPCWSTR")] ushort* pszUrl, [NativeTypeName("VARIANT_BOOL *")] short* pvbCancel)
        {
            return ((delegate* unmanaged<IMFNetResourceFilter*, ushort*, short*, int>)(lpVtbl[3]))((IMFNetResourceFilter*)Unsafe.AsPointer(ref this), pszUrl, pvbCancel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT OnSendingRequest([NativeTypeName("LPCWSTR")] ushort* pszUrl)
        {
            return ((delegate* unmanaged<IMFNetResourceFilter*, ushort*, int>)(lpVtbl[4]))((IMFNetResourceFilter*)Unsafe.AsPointer(ref this), pszUrl);
        }
    }
}
