// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/imapi2.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("27354133-7F64-5B0F-8F00-5D77AFBE261E")]
    [NativeTypeName("struct IDiscRecorder2 : IDispatch")]
    public unsafe partial struct IDiscRecorder2
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IDiscRecorder2*, Guid*, void**, int>)(lpVtbl[0]))((IDiscRecorder2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDiscRecorder2*, uint>)(lpVtbl[1]))((IDiscRecorder2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDiscRecorder2*, uint>)(lpVtbl[2]))((IDiscRecorder2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfoCount([NativeTypeName("UINT *")] uint* pctinfo)
        {
            return ((delegate* unmanaged<IDiscRecorder2*, uint*, int>)(lpVtbl[3]))((IDiscRecorder2*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfo([NativeTypeName("UINT")] uint iTInfo, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("ITypeInfo **")] ITypeInfo** ppTInfo)
        {
            return ((delegate* unmanaged<IDiscRecorder2*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((IDiscRecorder2*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, [NativeTypeName("UINT")] uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* unmanaged<IDiscRecorder2*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((IDiscRecorder2*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, [NativeTypeName("DISPPARAMS *")] DISPPARAMS* pDispParams, [NativeTypeName("VARIANT *")] VARIANT* pVarResult, [NativeTypeName("EXCEPINFO *")] EXCEPINFO* pExcepInfo, [NativeTypeName("UINT *")] uint* puArgErr)
        {
            return ((delegate* unmanaged<IDiscRecorder2*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((IDiscRecorder2*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int EjectMedia()
        {
            return ((delegate* unmanaged<IDiscRecorder2*, int>)(lpVtbl[7]))((IDiscRecorder2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CloseTray()
        {
            return ((delegate* unmanaged<IDiscRecorder2*, int>)(lpVtbl[8]))((IDiscRecorder2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int AcquireExclusiveAccess([NativeTypeName("VARIANT_BOOL")] short force, [NativeTypeName("BSTR")] ushort* __MIDL__IDiscRecorder20000)
        {
            return ((delegate* unmanaged<IDiscRecorder2*, short, ushort*, int>)(lpVtbl[9]))((IDiscRecorder2*)Unsafe.AsPointer(ref this), force, __MIDL__IDiscRecorder20000);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ReleaseExclusiveAccess()
        {
            return ((delegate* unmanaged<IDiscRecorder2*, int>)(lpVtbl[10]))((IDiscRecorder2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int DisableMcn()
        {
            return ((delegate* unmanaged<IDiscRecorder2*, int>)(lpVtbl[11]))((IDiscRecorder2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int EnableMcn()
        {
            return ((delegate* unmanaged<IDiscRecorder2*, int>)(lpVtbl[12]))((IDiscRecorder2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int InitializeDiscRecorder([NativeTypeName("BSTR")] ushort* recorderUniqueId)
        {
            return ((delegate* unmanaged<IDiscRecorder2*, ushort*, int>)(lpVtbl[13]))((IDiscRecorder2*)Unsafe.AsPointer(ref this), recorderUniqueId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_ActiveDiscRecorder([NativeTypeName("BSTR *")] ushort** value)
        {
            return ((delegate* unmanaged<IDiscRecorder2*, ushort**, int>)(lpVtbl[14]))((IDiscRecorder2*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_VendorId([NativeTypeName("BSTR *")] ushort** value)
        {
            return ((delegate* unmanaged<IDiscRecorder2*, ushort**, int>)(lpVtbl[15]))((IDiscRecorder2*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_ProductId([NativeTypeName("BSTR *")] ushort** value)
        {
            return ((delegate* unmanaged<IDiscRecorder2*, ushort**, int>)(lpVtbl[16]))((IDiscRecorder2*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_ProductRevision([NativeTypeName("BSTR *")] ushort** value)
        {
            return ((delegate* unmanaged<IDiscRecorder2*, ushort**, int>)(lpVtbl[17]))((IDiscRecorder2*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_VolumeName([NativeTypeName("BSTR *")] ushort** value)
        {
            return ((delegate* unmanaged<IDiscRecorder2*, ushort**, int>)(lpVtbl[18]))((IDiscRecorder2*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_VolumePathNames([NativeTypeName("SAFEARRAY **")] SAFEARRAY** value)
        {
            return ((delegate* unmanaged<IDiscRecorder2*, SAFEARRAY**, int>)(lpVtbl[19]))((IDiscRecorder2*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_DeviceCanLoadMedia([NativeTypeName("VARIANT_BOOL *")] short* value)
        {
            return ((delegate* unmanaged<IDiscRecorder2*, short*, int>)(lpVtbl[20]))((IDiscRecorder2*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_LegacyDeviceNumber([NativeTypeName("LONG *")] int* legacyDeviceNumber)
        {
            return ((delegate* unmanaged<IDiscRecorder2*, int*, int>)(lpVtbl[21]))((IDiscRecorder2*)Unsafe.AsPointer(ref this), legacyDeviceNumber);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_SupportedFeaturePages([NativeTypeName("SAFEARRAY **")] SAFEARRAY** value)
        {
            return ((delegate* unmanaged<IDiscRecorder2*, SAFEARRAY**, int>)(lpVtbl[22]))((IDiscRecorder2*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_CurrentFeaturePages([NativeTypeName("SAFEARRAY **")] SAFEARRAY** value)
        {
            return ((delegate* unmanaged<IDiscRecorder2*, SAFEARRAY**, int>)(lpVtbl[23]))((IDiscRecorder2*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_SupportedProfiles([NativeTypeName("SAFEARRAY **")] SAFEARRAY** value)
        {
            return ((delegate* unmanaged<IDiscRecorder2*, SAFEARRAY**, int>)(lpVtbl[24]))((IDiscRecorder2*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_CurrentProfiles([NativeTypeName("SAFEARRAY **")] SAFEARRAY** value)
        {
            return ((delegate* unmanaged<IDiscRecorder2*, SAFEARRAY**, int>)(lpVtbl[25]))((IDiscRecorder2*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_SupportedModePages([NativeTypeName("SAFEARRAY **")] SAFEARRAY** value)
        {
            return ((delegate* unmanaged<IDiscRecorder2*, SAFEARRAY**, int>)(lpVtbl[26]))((IDiscRecorder2*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_ExclusiveAccessOwner([NativeTypeName("BSTR *")] ushort** value)
        {
            return ((delegate* unmanaged<IDiscRecorder2*, ushort**, int>)(lpVtbl[27]))((IDiscRecorder2*)Unsafe.AsPointer(ref this), value);
        }
    }
}
