// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WbemCli.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("DC12A680-737F-11CF-884D-00AA004B2E24")]
    [NativeTypeName("struct IWbemQualifierSet : IUnknown")]
    public unsafe partial struct IWbemQualifierSet
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IWbemQualifierSet*, Guid*, void**, int>)(lpVtbl[0]))((IWbemQualifierSet*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IWbemQualifierSet*, uint>)(lpVtbl[1]))((IWbemQualifierSet*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IWbemQualifierSet*, uint>)(lpVtbl[2]))((IWbemQualifierSet*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Get([NativeTypeName("LPCWSTR")] ushort* wszName, [NativeTypeName("long")] int lFlags, VARIANT* pVal, [NativeTypeName("long *")] int* plFlavor)
        {
            return ((delegate* unmanaged<IWbemQualifierSet*, ushort*, int, VARIANT*, int*, int>)(lpVtbl[3]))((IWbemQualifierSet*)Unsafe.AsPointer(ref this), wszName, lFlags, pVal, plFlavor);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Put([NativeTypeName("LPCWSTR")] ushort* wszName, VARIANT* pVal, [NativeTypeName("long")] int lFlavor)
        {
            return ((delegate* unmanaged<IWbemQualifierSet*, ushort*, VARIANT*, int, int>)(lpVtbl[4]))((IWbemQualifierSet*)Unsafe.AsPointer(ref this), wszName, pVal, lFlavor);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Delete([NativeTypeName("LPCWSTR")] ushort* wszName)
        {
            return ((delegate* unmanaged<IWbemQualifierSet*, ushort*, int>)(lpVtbl[5]))((IWbemQualifierSet*)Unsafe.AsPointer(ref this), wszName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetNames([NativeTypeName("long")] int lFlags, SAFEARRAY** pNames)
        {
            return ((delegate* unmanaged<IWbemQualifierSet*, int, SAFEARRAY**, int>)(lpVtbl[6]))((IWbemQualifierSet*)Unsafe.AsPointer(ref this), lFlags, pNames);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int BeginEnumeration([NativeTypeName("long")] int lFlags)
        {
            return ((delegate* unmanaged<IWbemQualifierSet*, int, int>)(lpVtbl[7]))((IWbemQualifierSet*)Unsafe.AsPointer(ref this), lFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Next([NativeTypeName("long")] int lFlags, [NativeTypeName("BSTR *")] ushort** pstrName, VARIANT* pVal, [NativeTypeName("long *")] int* plFlavor)
        {
            return ((delegate* unmanaged<IWbemQualifierSet*, int, ushort**, VARIANT*, int*, int>)(lpVtbl[8]))((IWbemQualifierSet*)Unsafe.AsPointer(ref this), lFlags, pstrName, pVal, plFlavor);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int EndEnumeration()
        {
            return ((delegate* unmanaged<IWbemQualifierSet*, int>)(lpVtbl[9]))((IWbemQualifierSet*)Unsafe.AsPointer(ref this));
        }
    }
}
