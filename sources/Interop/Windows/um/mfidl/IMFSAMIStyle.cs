// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("A7E025DD-5303-4A62-89D6-E747E1EFAC73")]
    public unsafe partial struct IMFSAMIStyle
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IMFSAMIStyle*, Guid*, void**, int>)(lpVtbl[0]))((IMFSAMIStyle*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IMFSAMIStyle*, uint>)(lpVtbl[1]))((IMFSAMIStyle*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IMFSAMIStyle*, uint>)(lpVtbl[2]))((IMFSAMIStyle*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetStyleCount([NativeTypeName("DWORD *")] uint* pdwCount)
        {
            return ((delegate* stdcall<IMFSAMIStyle*, uint*, int>)(lpVtbl[3]))((IMFSAMIStyle*)Unsafe.AsPointer(ref this), pdwCount);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetStyles([NativeTypeName("PROPVARIANT *")] PROPVARIANT* pPropVarStyleArray)
        {
            return ((delegate* stdcall<IMFSAMIStyle*, PROPVARIANT*, int>)(lpVtbl[4]))((IMFSAMIStyle*)Unsafe.AsPointer(ref this), pPropVarStyleArray);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetSelectedStyle([NativeTypeName("LPCWSTR")] ushort* pwszStyle)
        {
            return ((delegate* stdcall<IMFSAMIStyle*, ushort*, int>)(lpVtbl[5]))((IMFSAMIStyle*)Unsafe.AsPointer(ref this), pwszStyle);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetSelectedStyle([NativeTypeName("LPWSTR *")] ushort** ppwszStyle)
        {
            return ((delegate* stdcall<IMFSAMIStyle*, ushort**, int>)(lpVtbl[6]))((IMFSAMIStyle*)Unsafe.AsPointer(ref this), ppwszStyle);
        }
    }
}
