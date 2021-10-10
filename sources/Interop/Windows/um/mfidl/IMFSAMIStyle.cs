// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("A7E025DD-5303-4A62-89D6-E747E1EFAC73")]
    [NativeTypeName("struct IMFSAMIStyle : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IMFSAMIStyle
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IMFSAMIStyle*, Guid*, void**, int>)(lpVtbl[0]))((IMFSAMIStyle*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IMFSAMIStyle*, uint>)(lpVtbl[1]))((IMFSAMIStyle*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IMFSAMIStyle*, uint>)(lpVtbl[2]))((IMFSAMIStyle*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int GetStyleCount([NativeTypeName("DWORD *")] uint* pdwCount)
        {
            return ((delegate* unmanaged<IMFSAMIStyle*, uint*, int>)(lpVtbl[3]))((IMFSAMIStyle*)Unsafe.AsPointer(ref this), pdwCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int GetStyles(PROPVARIANT* pPropVarStyleArray)
        {
            return ((delegate* unmanaged<IMFSAMIStyle*, PROPVARIANT*, int>)(lpVtbl[4]))((IMFSAMIStyle*)Unsafe.AsPointer(ref this), pPropVarStyleArray);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int SetSelectedStyle([NativeTypeName("LPCWSTR")] ushort* pwszStyle)
        {
            return ((delegate* unmanaged<IMFSAMIStyle*, ushort*, int>)(lpVtbl[5]))((IMFSAMIStyle*)Unsafe.AsPointer(ref this), pwszStyle);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int GetSelectedStyle([NativeTypeName("LPWSTR *")] ushort** ppwszStyle)
        {
            return ((delegate* unmanaged<IMFSAMIStyle*, ushort**, int>)(lpVtbl[6]))((IMFSAMIStyle*)Unsafe.AsPointer(ref this), ppwszStyle);
        }
    }
}
