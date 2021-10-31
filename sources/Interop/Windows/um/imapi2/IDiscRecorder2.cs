// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/imapi2.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("27354133-7F64-5B0F-8F00-5D77AFBE261E")]
    [NativeTypeName("struct IDiscRecorder2 : IDispatch")]
    [NativeInheritance("IDispatch")]
    public unsafe partial struct IDiscRecorder2
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDiscRecorder2*, Guid*, void**, int>)(lpVtbl[0]))((IDiscRecorder2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDiscRecorder2*, uint>)(lpVtbl[1]))((IDiscRecorder2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDiscRecorder2*, uint>)(lpVtbl[2]))((IDiscRecorder2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetTypeInfoCount(uint* pctinfo)
        {
            return ((delegate* unmanaged<IDiscRecorder2*, uint*, int>)(lpVtbl[3]))((IDiscRecorder2*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
        {
            return ((delegate* unmanaged<IDiscRecorder2*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((IDiscRecorder2*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* unmanaged<IDiscRecorder2*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((IDiscRecorder2*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
        {
            return ((delegate* unmanaged<IDiscRecorder2*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((IDiscRecorder2*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT EjectMedia()
        {
            return ((delegate* unmanaged<IDiscRecorder2*, int>)(lpVtbl[7]))((IDiscRecorder2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT CloseTray()
        {
            return ((delegate* unmanaged<IDiscRecorder2*, int>)(lpVtbl[8]))((IDiscRecorder2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT AcquireExclusiveAccess([NativeTypeName("VARIANT_BOOL")] short force, [NativeTypeName("BSTR")] ushort* __MIDL__IDiscRecorder20000)
        {
            return ((delegate* unmanaged<IDiscRecorder2*, short, ushort*, int>)(lpVtbl[9]))((IDiscRecorder2*)Unsafe.AsPointer(ref this), force, __MIDL__IDiscRecorder20000);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT ReleaseExclusiveAccess()
        {
            return ((delegate* unmanaged<IDiscRecorder2*, int>)(lpVtbl[10]))((IDiscRecorder2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT DisableMcn()
        {
            return ((delegate* unmanaged<IDiscRecorder2*, int>)(lpVtbl[11]))((IDiscRecorder2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT EnableMcn()
        {
            return ((delegate* unmanaged<IDiscRecorder2*, int>)(lpVtbl[12]))((IDiscRecorder2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HRESULT InitializeDiscRecorder([NativeTypeName("BSTR")] ushort* recorderUniqueId)
        {
            return ((delegate* unmanaged<IDiscRecorder2*, ushort*, int>)(lpVtbl[13]))((IDiscRecorder2*)Unsafe.AsPointer(ref this), recorderUniqueId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public HRESULT get_ActiveDiscRecorder([NativeTypeName("BSTR *")] ushort** value)
        {
            return ((delegate* unmanaged<IDiscRecorder2*, ushort**, int>)(lpVtbl[14]))((IDiscRecorder2*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        public HRESULT get_VendorId([NativeTypeName("BSTR *")] ushort** value)
        {
            return ((delegate* unmanaged<IDiscRecorder2*, ushort**, int>)(lpVtbl[15]))((IDiscRecorder2*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        public HRESULT get_ProductId([NativeTypeName("BSTR *")] ushort** value)
        {
            return ((delegate* unmanaged<IDiscRecorder2*, ushort**, int>)(lpVtbl[16]))((IDiscRecorder2*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        public HRESULT get_ProductRevision([NativeTypeName("BSTR *")] ushort** value)
        {
            return ((delegate* unmanaged<IDiscRecorder2*, ushort**, int>)(lpVtbl[17]))((IDiscRecorder2*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        public HRESULT get_VolumeName([NativeTypeName("BSTR *")] ushort** value)
        {
            return ((delegate* unmanaged<IDiscRecorder2*, ushort**, int>)(lpVtbl[18]))((IDiscRecorder2*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        public HRESULT get_VolumePathNames(SAFEARRAY** value)
        {
            return ((delegate* unmanaged<IDiscRecorder2*, SAFEARRAY**, int>)(lpVtbl[19]))((IDiscRecorder2*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        public HRESULT get_DeviceCanLoadMedia([NativeTypeName("VARIANT_BOOL *")] short* value)
        {
            return ((delegate* unmanaged<IDiscRecorder2*, short*, int>)(lpVtbl[20]))((IDiscRecorder2*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        public HRESULT get_LegacyDeviceNumber([NativeTypeName("LONG *")] int* legacyDeviceNumber)
        {
            return ((delegate* unmanaged<IDiscRecorder2*, int*, int>)(lpVtbl[21]))((IDiscRecorder2*)Unsafe.AsPointer(ref this), legacyDeviceNumber);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(22)]
        public HRESULT get_SupportedFeaturePages(SAFEARRAY** value)
        {
            return ((delegate* unmanaged<IDiscRecorder2*, SAFEARRAY**, int>)(lpVtbl[22]))((IDiscRecorder2*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(23)]
        public HRESULT get_CurrentFeaturePages(SAFEARRAY** value)
        {
            return ((delegate* unmanaged<IDiscRecorder2*, SAFEARRAY**, int>)(lpVtbl[23]))((IDiscRecorder2*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(24)]
        public HRESULT get_SupportedProfiles(SAFEARRAY** value)
        {
            return ((delegate* unmanaged<IDiscRecorder2*, SAFEARRAY**, int>)(lpVtbl[24]))((IDiscRecorder2*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(25)]
        public HRESULT get_CurrentProfiles(SAFEARRAY** value)
        {
            return ((delegate* unmanaged<IDiscRecorder2*, SAFEARRAY**, int>)(lpVtbl[25]))((IDiscRecorder2*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(26)]
        public HRESULT get_SupportedModePages(SAFEARRAY** value)
        {
            return ((delegate* unmanaged<IDiscRecorder2*, SAFEARRAY**, int>)(lpVtbl[26]))((IDiscRecorder2*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(27)]
        public HRESULT get_ExclusiveAccessOwner([NativeTypeName("BSTR *")] ushort** value)
        {
            return ((delegate* unmanaged<IDiscRecorder2*, ushort**, int>)(lpVtbl[27]))((IDiscRecorder2*)Unsafe.AsPointer(ref this), value);
        }
    }
}
