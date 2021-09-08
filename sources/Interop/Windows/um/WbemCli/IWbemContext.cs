// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WbemCli.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("44ACA674-E8FC-11D0-A07C-00C04FB68820")]
    [NativeTypeName("struct IWbemContext : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IWbemContext
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IWbemContext*, Guid*, void**, int>)(lpVtbl[0]))((IWbemContext*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IWbemContext*, uint>)(lpVtbl[1]))((IWbemContext*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IWbemContext*, uint>)(lpVtbl[2]))((IWbemContext*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int Clone(IWbemContext** ppNewCopy)
        {
            return ((delegate* unmanaged<IWbemContext*, IWbemContext**, int>)(lpVtbl[3]))((IWbemContext*)Unsafe.AsPointer(ref this), ppNewCopy);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int GetNames([NativeTypeName("long")] int lFlags, SAFEARRAY** pNames)
        {
            return ((delegate* unmanaged<IWbemContext*, int, SAFEARRAY**, int>)(lpVtbl[4]))((IWbemContext*)Unsafe.AsPointer(ref this), lFlags, pNames);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int BeginEnumeration([NativeTypeName("long")] int lFlags)
        {
            return ((delegate* unmanaged<IWbemContext*, int, int>)(lpVtbl[5]))((IWbemContext*)Unsafe.AsPointer(ref this), lFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int Next([NativeTypeName("long")] int lFlags, [NativeTypeName("BSTR *")] ushort** pstrName, VARIANT* pValue)
        {
            return ((delegate* unmanaged<IWbemContext*, int, ushort**, VARIANT*, int>)(lpVtbl[6]))((IWbemContext*)Unsafe.AsPointer(ref this), lFlags, pstrName, pValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int EndEnumeration()
        {
            return ((delegate* unmanaged<IWbemContext*, int>)(lpVtbl[7]))((IWbemContext*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("HRESULT")]
        public int SetValue([NativeTypeName("LPCWSTR")] ushort* wszName, [NativeTypeName("long")] int lFlags, VARIANT* pValue)
        {
            return ((delegate* unmanaged<IWbemContext*, ushort*, int, VARIANT*, int>)(lpVtbl[8]))((IWbemContext*)Unsafe.AsPointer(ref this), wszName, lFlags, pValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        [return: NativeTypeName("HRESULT")]
        public int GetValue([NativeTypeName("LPCWSTR")] ushort* wszName, [NativeTypeName("long")] int lFlags, VARIANT* pValue)
        {
            return ((delegate* unmanaged<IWbemContext*, ushort*, int, VARIANT*, int>)(lpVtbl[9]))((IWbemContext*)Unsafe.AsPointer(ref this), wszName, lFlags, pValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        [return: NativeTypeName("HRESULT")]
        public int DeleteValue([NativeTypeName("LPCWSTR")] ushort* wszName, [NativeTypeName("long")] int lFlags)
        {
            return ((delegate* unmanaged<IWbemContext*, ushort*, int, int>)(lpVtbl[10]))((IWbemContext*)Unsafe.AsPointer(ref this), wszName, lFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        [return: NativeTypeName("HRESULT")]
        public int DeleteAll()
        {
            return ((delegate* unmanaged<IWbemContext*, int>)(lpVtbl[11]))((IWbemContext*)Unsafe.AsPointer(ref this));
        }
    }
}
