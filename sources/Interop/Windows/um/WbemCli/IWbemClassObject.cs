// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WbemCli.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("DC12A681-737F-11CF-884D-00AA004B2E24")]
    [NativeTypeName("struct IWbemClassObject : IUnknown")]
    public unsafe partial struct IWbemClassObject
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IWbemClassObject*, Guid*, void**, int>)(lpVtbl[0]))((IWbemClassObject*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IWbemClassObject*, uint>)(lpVtbl[1]))((IWbemClassObject*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IWbemClassObject*, uint>)(lpVtbl[2]))((IWbemClassObject*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetQualifierSet(IWbemQualifierSet** ppQualSet)
        {
            return ((delegate* unmanaged<IWbemClassObject*, IWbemQualifierSet**, int>)(lpVtbl[3]))((IWbemClassObject*)Unsafe.AsPointer(ref this), ppQualSet);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Get([NativeTypeName("LPCWSTR")] ushort* wszName, [NativeTypeName("long")] int lFlags, VARIANT* pVal, [NativeTypeName("CIMTYPE *")] int* pType, [NativeTypeName("long *")] int* plFlavor)
        {
            return ((delegate* unmanaged<IWbemClassObject*, ushort*, int, VARIANT*, int*, int*, int>)(lpVtbl[4]))((IWbemClassObject*)Unsafe.AsPointer(ref this), wszName, lFlags, pVal, pType, plFlavor);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Put([NativeTypeName("LPCWSTR")] ushort* wszName, [NativeTypeName("long")] int lFlags, VARIANT* pVal, [NativeTypeName("CIMTYPE")] int Type)
        {
            return ((delegate* unmanaged<IWbemClassObject*, ushort*, int, VARIANT*, int, int>)(lpVtbl[5]))((IWbemClassObject*)Unsafe.AsPointer(ref this), wszName, lFlags, pVal, Type);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Delete([NativeTypeName("LPCWSTR")] ushort* wszName)
        {
            return ((delegate* unmanaged<IWbemClassObject*, ushort*, int>)(lpVtbl[6]))((IWbemClassObject*)Unsafe.AsPointer(ref this), wszName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetNames([NativeTypeName("LPCWSTR")] ushort* wszQualifierName, [NativeTypeName("long")] int lFlags, VARIANT* pQualifierVal, SAFEARRAY** pNames)
        {
            return ((delegate* unmanaged<IWbemClassObject*, ushort*, int, VARIANT*, SAFEARRAY**, int>)(lpVtbl[7]))((IWbemClassObject*)Unsafe.AsPointer(ref this), wszQualifierName, lFlags, pQualifierVal, pNames);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int BeginEnumeration([NativeTypeName("long")] int lEnumFlags)
        {
            return ((delegate* unmanaged<IWbemClassObject*, int, int>)(lpVtbl[8]))((IWbemClassObject*)Unsafe.AsPointer(ref this), lEnumFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Next([NativeTypeName("long")] int lFlags, [NativeTypeName("BSTR *")] ushort** strName, VARIANT* pVal, [NativeTypeName("CIMTYPE *")] int* pType, [NativeTypeName("long *")] int* plFlavor)
        {
            return ((delegate* unmanaged<IWbemClassObject*, int, ushort**, VARIANT*, int*, int*, int>)(lpVtbl[9]))((IWbemClassObject*)Unsafe.AsPointer(ref this), lFlags, strName, pVal, pType, plFlavor);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int EndEnumeration()
        {
            return ((delegate* unmanaged<IWbemClassObject*, int>)(lpVtbl[10]))((IWbemClassObject*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetPropertyQualifierSet([NativeTypeName("LPCWSTR")] ushort* wszProperty, IWbemQualifierSet** ppQualSet)
        {
            return ((delegate* unmanaged<IWbemClassObject*, ushort*, IWbemQualifierSet**, int>)(lpVtbl[11]))((IWbemClassObject*)Unsafe.AsPointer(ref this), wszProperty, ppQualSet);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Clone(IWbemClassObject** ppCopy)
        {
            return ((delegate* unmanaged<IWbemClassObject*, IWbemClassObject**, int>)(lpVtbl[12]))((IWbemClassObject*)Unsafe.AsPointer(ref this), ppCopy);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetObjectText([NativeTypeName("long")] int lFlags, [NativeTypeName("BSTR *")] ushort** pstrObjectText)
        {
            return ((delegate* unmanaged<IWbemClassObject*, int, ushort**, int>)(lpVtbl[13]))((IWbemClassObject*)Unsafe.AsPointer(ref this), lFlags, pstrObjectText);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SpawnDerivedClass([NativeTypeName("long")] int lFlags, IWbemClassObject** ppNewClass)
        {
            return ((delegate* unmanaged<IWbemClassObject*, int, IWbemClassObject**, int>)(lpVtbl[14]))((IWbemClassObject*)Unsafe.AsPointer(ref this), lFlags, ppNewClass);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SpawnInstance([NativeTypeName("long")] int lFlags, IWbemClassObject** ppNewInstance)
        {
            return ((delegate* unmanaged<IWbemClassObject*, int, IWbemClassObject**, int>)(lpVtbl[15]))((IWbemClassObject*)Unsafe.AsPointer(ref this), lFlags, ppNewInstance);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CompareTo([NativeTypeName("long")] int lFlags, IWbemClassObject* pCompareTo)
        {
            return ((delegate* unmanaged<IWbemClassObject*, int, IWbemClassObject*, int>)(lpVtbl[16]))((IWbemClassObject*)Unsafe.AsPointer(ref this), lFlags, pCompareTo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetPropertyOrigin([NativeTypeName("LPCWSTR")] ushort* wszName, [NativeTypeName("BSTR *")] ushort** pstrClassName)
        {
            return ((delegate* unmanaged<IWbemClassObject*, ushort*, ushort**, int>)(lpVtbl[17]))((IWbemClassObject*)Unsafe.AsPointer(ref this), wszName, pstrClassName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int InheritsFrom([NativeTypeName("LPCWSTR")] ushort* strAncestor)
        {
            return ((delegate* unmanaged<IWbemClassObject*, ushort*, int>)(lpVtbl[18]))((IWbemClassObject*)Unsafe.AsPointer(ref this), strAncestor);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetMethod([NativeTypeName("LPCWSTR")] ushort* wszName, [NativeTypeName("long")] int lFlags, IWbemClassObject** ppInSignature, IWbemClassObject** ppOutSignature)
        {
            return ((delegate* unmanaged<IWbemClassObject*, ushort*, int, IWbemClassObject**, IWbemClassObject**, int>)(lpVtbl[19]))((IWbemClassObject*)Unsafe.AsPointer(ref this), wszName, lFlags, ppInSignature, ppOutSignature);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int PutMethod([NativeTypeName("LPCWSTR")] ushort* wszName, [NativeTypeName("long")] int lFlags, IWbemClassObject* pInSignature, IWbemClassObject* pOutSignature)
        {
            return ((delegate* unmanaged<IWbemClassObject*, ushort*, int, IWbemClassObject*, IWbemClassObject*, int>)(lpVtbl[20]))((IWbemClassObject*)Unsafe.AsPointer(ref this), wszName, lFlags, pInSignature, pOutSignature);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int DeleteMethod([NativeTypeName("LPCWSTR")] ushort* wszName)
        {
            return ((delegate* unmanaged<IWbemClassObject*, ushort*, int>)(lpVtbl[21]))((IWbemClassObject*)Unsafe.AsPointer(ref this), wszName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int BeginMethodEnumeration([NativeTypeName("long")] int lEnumFlags)
        {
            return ((delegate* unmanaged<IWbemClassObject*, int, int>)(lpVtbl[22]))((IWbemClassObject*)Unsafe.AsPointer(ref this), lEnumFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int NextMethod([NativeTypeName("long")] int lFlags, [NativeTypeName("BSTR *")] ushort** pstrName, IWbemClassObject** ppInSignature, IWbemClassObject** ppOutSignature)
        {
            return ((delegate* unmanaged<IWbemClassObject*, int, ushort**, IWbemClassObject**, IWbemClassObject**, int>)(lpVtbl[23]))((IWbemClassObject*)Unsafe.AsPointer(ref this), lFlags, pstrName, ppInSignature, ppOutSignature);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int EndMethodEnumeration()
        {
            return ((delegate* unmanaged<IWbemClassObject*, int>)(lpVtbl[24]))((IWbemClassObject*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetMethodQualifierSet([NativeTypeName("LPCWSTR")] ushort* wszMethod, IWbemQualifierSet** ppQualSet)
        {
            return ((delegate* unmanaged<IWbemClassObject*, ushort*, IWbemQualifierSet**, int>)(lpVtbl[25]))((IWbemClassObject*)Unsafe.AsPointer(ref this), wszMethod, ppQualSet);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetMethodOrigin([NativeTypeName("LPCWSTR")] ushort* wszMethodName, [NativeTypeName("BSTR *")] ushort** pstrClassName)
        {
            return ((delegate* unmanaged<IWbemClassObject*, ushort*, ushort**, int>)(lpVtbl[26]))((IWbemClassObject*)Unsafe.AsPointer(ref this), wszMethodName, pstrClassName);
        }
    }
}
