// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/OCIdl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("376BD3AA-3845-101B-84ED-08002B2EC713")]
    [NativeTypeName("struct IPerPropertyBrowsing : IUnknown")]
    public unsafe partial struct IPerPropertyBrowsing
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<IPerPropertyBrowsing*, Guid*, void**, int>)(lpVtbl[0]))((IPerPropertyBrowsing*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<IPerPropertyBrowsing*, uint>)(lpVtbl[1]))((IPerPropertyBrowsing*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<IPerPropertyBrowsing*, uint>)(lpVtbl[2]))((IPerPropertyBrowsing*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetDisplayString([NativeTypeName("DISPID")] int dispID, [NativeTypeName("BSTR *")] ushort** pBstr)
        {
            return ((delegate* unmanaged[Stdcall]<IPerPropertyBrowsing*, int, ushort**, int>)(lpVtbl[3]))((IPerPropertyBrowsing*)Unsafe.AsPointer(ref this), dispID, pBstr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int MapPropertyToPage([NativeTypeName("DISPID")] int dispID, [NativeTypeName("CLSID *")] Guid* pClsid)
        {
            return ((delegate* unmanaged[Stdcall]<IPerPropertyBrowsing*, int, Guid*, int>)(lpVtbl[4]))((IPerPropertyBrowsing*)Unsafe.AsPointer(ref this), dispID, pClsid);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetPredefinedStrings([NativeTypeName("DISPID")] int dispID, [NativeTypeName("CALPOLESTR *")] CALPOLESTR* pCaStringsOut, [NativeTypeName("CADWORD *")] CADWORD* pCaCookiesOut)
        {
            return ((delegate* unmanaged[Stdcall]<IPerPropertyBrowsing*, int, CALPOLESTR*, CADWORD*, int>)(lpVtbl[5]))((IPerPropertyBrowsing*)Unsafe.AsPointer(ref this), dispID, pCaStringsOut, pCaCookiesOut);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetPredefinedValue([NativeTypeName("DISPID")] int dispID, [NativeTypeName("DWORD")] uint dwCookie, [NativeTypeName("VARIANT *")] VARIANT* pVarOut)
        {
            return ((delegate* unmanaged[Stdcall]<IPerPropertyBrowsing*, int, uint, VARIANT*, int>)(lpVtbl[6]))((IPerPropertyBrowsing*)Unsafe.AsPointer(ref this), dispID, dwCookie, pVarOut);
        }
    }
}
