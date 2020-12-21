// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("A7E025DD-5303-4A62-89D6-E747E1EFAC73")]
    [NativeTypeName("struct IMFSAMIStyle : IUnknown")]
    public unsafe partial struct IMFSAMIStyle
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<IMFSAMIStyle*, Guid*, void**, int>)(lpVtbl[0]))((IMFSAMIStyle*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<IMFSAMIStyle*, uint>)(lpVtbl[1]))((IMFSAMIStyle*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<IMFSAMIStyle*, uint>)(lpVtbl[2]))((IMFSAMIStyle*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetStyleCount([NativeTypeName("DWORD *")] uint* pdwCount)
        {
            return ((delegate* unmanaged[Stdcall]<IMFSAMIStyle*, uint*, int>)(lpVtbl[3]))((IMFSAMIStyle*)Unsafe.AsPointer(ref this), pdwCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetStyles([NativeTypeName("PROPVARIANT *")] PROPVARIANT* pPropVarStyleArray)
        {
            return ((delegate* unmanaged[Stdcall]<IMFSAMIStyle*, PROPVARIANT*, int>)(lpVtbl[4]))((IMFSAMIStyle*)Unsafe.AsPointer(ref this), pPropVarStyleArray);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetSelectedStyle([NativeTypeName("LPCWSTR")] ushort* pwszStyle)
        {
            return ((delegate* unmanaged[Stdcall]<IMFSAMIStyle*, ushort*, int>)(lpVtbl[5]))((IMFSAMIStyle*)Unsafe.AsPointer(ref this), pwszStyle);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetSelectedStyle([NativeTypeName("LPWSTR *")] ushort** ppwszStyle)
        {
            return ((delegate* unmanaged[Stdcall]<IMFSAMIStyle*, ushort**, int>)(lpVtbl[6]))((IMFSAMIStyle*)Unsafe.AsPointer(ref this), ppwszStyle);
        }
    }
}
