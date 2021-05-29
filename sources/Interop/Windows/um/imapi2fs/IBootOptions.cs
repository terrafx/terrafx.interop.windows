// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/imapi2fs.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("2C941FD4-975B-59BE-A960-9A2A262853A5")]
    [NativeTypeName("struct IBootOptions : IDispatch")]
    public unsafe partial struct IBootOptions
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IBootOptions*, Guid*, void**, int>)(lpVtbl[0]))((IBootOptions*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IBootOptions*, uint>)(lpVtbl[1]))((IBootOptions*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IBootOptions*, uint>)(lpVtbl[2]))((IBootOptions*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfoCount([NativeTypeName("UINT *")] uint* pctinfo)
        {
            return ((delegate* unmanaged<IBootOptions*, uint*, int>)(lpVtbl[3]))((IBootOptions*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfo([NativeTypeName("UINT")] uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
        {
            return ((delegate* unmanaged<IBootOptions*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((IBootOptions*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, [NativeTypeName("UINT")] uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* unmanaged<IBootOptions*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((IBootOptions*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, [NativeTypeName("UINT *")] uint* puArgErr)
        {
            return ((delegate* unmanaged<IBootOptions*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((IBootOptions*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_BootImage(IStream** pVal)
        {
            return ((delegate* unmanaged<IBootOptions*, IStream**, int>)(lpVtbl[7]))((IBootOptions*)Unsafe.AsPointer(ref this), pVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Manufacturer([NativeTypeName("BSTR *")] ushort** pVal)
        {
            return ((delegate* unmanaged<IBootOptions*, ushort**, int>)(lpVtbl[8]))((IBootOptions*)Unsafe.AsPointer(ref this), pVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_Manufacturer([NativeTypeName("BSTR")] ushort* newVal)
        {
            return ((delegate* unmanaged<IBootOptions*, ushort*, int>)(lpVtbl[9]))((IBootOptions*)Unsafe.AsPointer(ref this), newVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_PlatformId(PlatformId* pVal)
        {
            return ((delegate* unmanaged<IBootOptions*, PlatformId*, int>)(lpVtbl[10]))((IBootOptions*)Unsafe.AsPointer(ref this), pVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_PlatformId(PlatformId newVal)
        {
            return ((delegate* unmanaged<IBootOptions*, PlatformId, int>)(lpVtbl[11]))((IBootOptions*)Unsafe.AsPointer(ref this), newVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Emulation(EmulationType* pVal)
        {
            return ((delegate* unmanaged<IBootOptions*, EmulationType*, int>)(lpVtbl[12]))((IBootOptions*)Unsafe.AsPointer(ref this), pVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_Emulation(EmulationType newVal)
        {
            return ((delegate* unmanaged<IBootOptions*, EmulationType, int>)(lpVtbl[13]))((IBootOptions*)Unsafe.AsPointer(ref this), newVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_ImageSize([NativeTypeName("ULONG *")] uint* pVal)
        {
            return ((delegate* unmanaged<IBootOptions*, uint*, int>)(lpVtbl[14]))((IBootOptions*)Unsafe.AsPointer(ref this), pVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int AssignBootImage(IStream* newVal)
        {
            return ((delegate* unmanaged<IBootOptions*, IStream*, int>)(lpVtbl[15]))((IBootOptions*)Unsafe.AsPointer(ref this), newVal);
        }
    }
}
