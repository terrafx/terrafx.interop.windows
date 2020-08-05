// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("091878A3-BF11-4A5C-BC9F-33995B06EF2D")]
    [NativeTypeName("struct IMFNetResourceFilter : IUnknown")]
    public unsafe partial struct IMFNetResourceFilter
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IMFNetResourceFilter*, Guid*, void**, int>)(lpVtbl[0]))((IMFNetResourceFilter*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IMFNetResourceFilter*, uint>)(lpVtbl[1]))((IMFNetResourceFilter*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IMFNetResourceFilter*, uint>)(lpVtbl[2]))((IMFNetResourceFilter*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int OnRedirect([NativeTypeName("LPCWSTR")] ushort* pszUrl, [NativeTypeName("VARIANT_BOOL *")] short* pvbCancel)
        {
            return ((delegate* stdcall<IMFNetResourceFilter*, ushort*, short*, int>)(lpVtbl[3]))((IMFNetResourceFilter*)Unsafe.AsPointer(ref this), pszUrl, pvbCancel);
        }

        [return: NativeTypeName("HRESULT")]
        public int OnSendingRequest([NativeTypeName("LPCWSTR")] ushort* pszUrl)
        {
            return ((delegate* stdcall<IMFNetResourceFilter*, ushort*, int>)(lpVtbl[4]))((IMFNetResourceFilter*)Unsafe.AsPointer(ref this), pszUrl);
        }
    }
}
