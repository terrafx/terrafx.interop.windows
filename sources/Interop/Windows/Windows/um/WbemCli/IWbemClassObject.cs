// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WbemCli.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

[Guid("DC12A681-737F-11CF-884D-00AA004B2E24")]
[NativeTypeName("struct IWbemClassObject : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IWbemClassObject : IWbemClassObject.Interface
{
    public void** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IWbemClassObject*, Guid*, void**, int>)(lpVtbl[0]))((IWbemClassObject*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IWbemClassObject*, uint>)(lpVtbl[1]))((IWbemClassObject*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IWbemClassObject*, uint>)(lpVtbl[2]))((IWbemClassObject*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetQualifierSet(IWbemQualifierSet** ppQualSet)
    {
        return ((delegate* unmanaged<IWbemClassObject*, IWbemQualifierSet**, int>)(lpVtbl[3]))((IWbemClassObject*)Unsafe.AsPointer(ref this), ppQualSet);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT Get([NativeTypeName("LPCWSTR")] ushort* wszName, [NativeTypeName("long")] int lFlags, VARIANT* pVal, [NativeTypeName("CIMTYPE *")] int* pType, [NativeTypeName("long *")] int* plFlavor)
    {
        return ((delegate* unmanaged<IWbemClassObject*, ushort*, int, VARIANT*, int*, int*, int>)(lpVtbl[4]))((IWbemClassObject*)Unsafe.AsPointer(ref this), wszName, lFlags, pVal, pType, plFlavor);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT Put([NativeTypeName("LPCWSTR")] ushort* wszName, [NativeTypeName("long")] int lFlags, VARIANT* pVal, [NativeTypeName("CIMTYPE")] int Type)
    {
        return ((delegate* unmanaged<IWbemClassObject*, ushort*, int, VARIANT*, int, int>)(lpVtbl[5]))((IWbemClassObject*)Unsafe.AsPointer(ref this), wszName, lFlags, pVal, Type);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Delete([NativeTypeName("LPCWSTR")] ushort* wszName)
    {
        return ((delegate* unmanaged<IWbemClassObject*, ushort*, int>)(lpVtbl[6]))((IWbemClassObject*)Unsafe.AsPointer(ref this), wszName);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetNames([NativeTypeName("LPCWSTR")] ushort* wszQualifierName, [NativeTypeName("long")] int lFlags, VARIANT* pQualifierVal, SAFEARRAY** pNames)
    {
        return ((delegate* unmanaged<IWbemClassObject*, ushort*, int, VARIANT*, SAFEARRAY**, int>)(lpVtbl[7]))((IWbemClassObject*)Unsafe.AsPointer(ref this), wszQualifierName, lFlags, pQualifierVal, pNames);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT BeginEnumeration([NativeTypeName("long")] int lEnumFlags)
    {
        return ((delegate* unmanaged<IWbemClassObject*, int, int>)(lpVtbl[8]))((IWbemClassObject*)Unsafe.AsPointer(ref this), lEnumFlags);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT Next([NativeTypeName("long")] int lFlags, [NativeTypeName("BSTR *")] ushort** strName, VARIANT* pVal, [NativeTypeName("CIMTYPE *")] int* pType, [NativeTypeName("long *")] int* plFlavor)
    {
        return ((delegate* unmanaged<IWbemClassObject*, int, ushort**, VARIANT*, int*, int*, int>)(lpVtbl[9]))((IWbemClassObject*)Unsafe.AsPointer(ref this), lFlags, strName, pVal, pType, plFlavor);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT EndEnumeration()
    {
        return ((delegate* unmanaged<IWbemClassObject*, int>)(lpVtbl[10]))((IWbemClassObject*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT GetPropertyQualifierSet([NativeTypeName("LPCWSTR")] ushort* wszProperty, IWbemQualifierSet** ppQualSet)
    {
        return ((delegate* unmanaged<IWbemClassObject*, ushort*, IWbemQualifierSet**, int>)(lpVtbl[11]))((IWbemClassObject*)Unsafe.AsPointer(ref this), wszProperty, ppQualSet);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT Clone(IWbemClassObject** ppCopy)
    {
        return ((delegate* unmanaged<IWbemClassObject*, IWbemClassObject**, int>)(lpVtbl[12]))((IWbemClassObject*)Unsafe.AsPointer(ref this), ppCopy);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT GetObjectText([NativeTypeName("long")] int lFlags, [NativeTypeName("BSTR *")] ushort** pstrObjectText)
    {
        return ((delegate* unmanaged<IWbemClassObject*, int, ushort**, int>)(lpVtbl[13]))((IWbemClassObject*)Unsafe.AsPointer(ref this), lFlags, pstrObjectText);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT SpawnDerivedClass([NativeTypeName("long")] int lFlags, IWbemClassObject** ppNewClass)
    {
        return ((delegate* unmanaged<IWbemClassObject*, int, IWbemClassObject**, int>)(lpVtbl[14]))((IWbemClassObject*)Unsafe.AsPointer(ref this), lFlags, ppNewClass);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT SpawnInstance([NativeTypeName("long")] int lFlags, IWbemClassObject** ppNewInstance)
    {
        return ((delegate* unmanaged<IWbemClassObject*, int, IWbemClassObject**, int>)(lpVtbl[15]))((IWbemClassObject*)Unsafe.AsPointer(ref this), lFlags, ppNewInstance);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT CompareTo([NativeTypeName("long")] int lFlags, IWbemClassObject* pCompareTo)
    {
        return ((delegate* unmanaged<IWbemClassObject*, int, IWbemClassObject*, int>)(lpVtbl[16]))((IWbemClassObject*)Unsafe.AsPointer(ref this), lFlags, pCompareTo);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT GetPropertyOrigin([NativeTypeName("LPCWSTR")] ushort* wszName, [NativeTypeName("BSTR *")] ushort** pstrClassName)
    {
        return ((delegate* unmanaged<IWbemClassObject*, ushort*, ushort**, int>)(lpVtbl[17]))((IWbemClassObject*)Unsafe.AsPointer(ref this), wszName, pstrClassName);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT InheritsFrom([NativeTypeName("LPCWSTR")] ushort* strAncestor)
    {
        return ((delegate* unmanaged<IWbemClassObject*, ushort*, int>)(lpVtbl[18]))((IWbemClassObject*)Unsafe.AsPointer(ref this), strAncestor);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT GetMethod([NativeTypeName("LPCWSTR")] ushort* wszName, [NativeTypeName("long")] int lFlags, IWbemClassObject** ppInSignature, IWbemClassObject** ppOutSignature)
    {
        return ((delegate* unmanaged<IWbemClassObject*, ushort*, int, IWbemClassObject**, IWbemClassObject**, int>)(lpVtbl[19]))((IWbemClassObject*)Unsafe.AsPointer(ref this), wszName, lFlags, ppInSignature, ppOutSignature);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT PutMethod([NativeTypeName("LPCWSTR")] ushort* wszName, [NativeTypeName("long")] int lFlags, IWbemClassObject* pInSignature, IWbemClassObject* pOutSignature)
    {
        return ((delegate* unmanaged<IWbemClassObject*, ushort*, int, IWbemClassObject*, IWbemClassObject*, int>)(lpVtbl[20]))((IWbemClassObject*)Unsafe.AsPointer(ref this), wszName, lFlags, pInSignature, pOutSignature);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT DeleteMethod([NativeTypeName("LPCWSTR")] ushort* wszName)
    {
        return ((delegate* unmanaged<IWbemClassObject*, ushort*, int>)(lpVtbl[21]))((IWbemClassObject*)Unsafe.AsPointer(ref this), wszName);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT BeginMethodEnumeration([NativeTypeName("long")] int lEnumFlags)
    {
        return ((delegate* unmanaged<IWbemClassObject*, int, int>)(lpVtbl[22]))((IWbemClassObject*)Unsafe.AsPointer(ref this), lEnumFlags);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT NextMethod([NativeTypeName("long")] int lFlags, [NativeTypeName("BSTR *")] ushort** pstrName, IWbemClassObject** ppInSignature, IWbemClassObject** ppOutSignature)
    {
        return ((delegate* unmanaged<IWbemClassObject*, int, ushort**, IWbemClassObject**, IWbemClassObject**, int>)(lpVtbl[23]))((IWbemClassObject*)Unsafe.AsPointer(ref this), lFlags, pstrName, ppInSignature, ppOutSignature);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT EndMethodEnumeration()
    {
        return ((delegate* unmanaged<IWbemClassObject*, int>)(lpVtbl[24]))((IWbemClassObject*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT GetMethodQualifierSet([NativeTypeName("LPCWSTR")] ushort* wszMethod, IWbemQualifierSet** ppQualSet)
    {
        return ((delegate* unmanaged<IWbemClassObject*, ushort*, IWbemQualifierSet**, int>)(lpVtbl[25]))((IWbemClassObject*)Unsafe.AsPointer(ref this), wszMethod, ppQualSet);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT GetMethodOrigin([NativeTypeName("LPCWSTR")] ushort* wszMethodName, [NativeTypeName("BSTR *")] ushort** pstrClassName)
    {
        return ((delegate* unmanaged<IWbemClassObject*, ushort*, ushort**, int>)(lpVtbl[26]))((IWbemClassObject*)Unsafe.AsPointer(ref this), wszMethodName, pstrClassName);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetQualifierSet(IWbemQualifierSet** ppQualSet);

        [VtblIndex(4)]
        HRESULT Get([NativeTypeName("LPCWSTR")] ushort* wszName, [NativeTypeName("long")] int lFlags, VARIANT* pVal, [NativeTypeName("CIMTYPE *")] int* pType, [NativeTypeName("long *")] int* plFlavor);

        [VtblIndex(5)]
        HRESULT Put([NativeTypeName("LPCWSTR")] ushort* wszName, [NativeTypeName("long")] int lFlags, VARIANT* pVal, [NativeTypeName("CIMTYPE")] int Type);

        [VtblIndex(6)]
        HRESULT Delete([NativeTypeName("LPCWSTR")] ushort* wszName);

        [VtblIndex(7)]
        HRESULT GetNames([NativeTypeName("LPCWSTR")] ushort* wszQualifierName, [NativeTypeName("long")] int lFlags, VARIANT* pQualifierVal, SAFEARRAY** pNames);

        [VtblIndex(8)]
        HRESULT BeginEnumeration([NativeTypeName("long")] int lEnumFlags);

        [VtblIndex(9)]
        HRESULT Next([NativeTypeName("long")] int lFlags, [NativeTypeName("BSTR *")] ushort** strName, VARIANT* pVal, [NativeTypeName("CIMTYPE *")] int* pType, [NativeTypeName("long *")] int* plFlavor);

        [VtblIndex(10)]
        HRESULT EndEnumeration();

        [VtblIndex(11)]
        HRESULT GetPropertyQualifierSet([NativeTypeName("LPCWSTR")] ushort* wszProperty, IWbemQualifierSet** ppQualSet);

        [VtblIndex(12)]
        HRESULT Clone(IWbemClassObject** ppCopy);

        [VtblIndex(13)]
        HRESULT GetObjectText([NativeTypeName("long")] int lFlags, [NativeTypeName("BSTR *")] ushort** pstrObjectText);

        [VtblIndex(14)]
        HRESULT SpawnDerivedClass([NativeTypeName("long")] int lFlags, IWbemClassObject** ppNewClass);

        [VtblIndex(15)]
        HRESULT SpawnInstance([NativeTypeName("long")] int lFlags, IWbemClassObject** ppNewInstance);

        [VtblIndex(16)]
        HRESULT CompareTo([NativeTypeName("long")] int lFlags, IWbemClassObject* pCompareTo);

        [VtblIndex(17)]
        HRESULT GetPropertyOrigin([NativeTypeName("LPCWSTR")] ushort* wszName, [NativeTypeName("BSTR *")] ushort** pstrClassName);

        [VtblIndex(18)]
        HRESULT InheritsFrom([NativeTypeName("LPCWSTR")] ushort* strAncestor);

        [VtblIndex(19)]
        HRESULT GetMethod([NativeTypeName("LPCWSTR")] ushort* wszName, [NativeTypeName("long")] int lFlags, IWbemClassObject** ppInSignature, IWbemClassObject** ppOutSignature);

        [VtblIndex(20)]
        HRESULT PutMethod([NativeTypeName("LPCWSTR")] ushort* wszName, [NativeTypeName("long")] int lFlags, IWbemClassObject* pInSignature, IWbemClassObject* pOutSignature);

        [VtblIndex(21)]
        HRESULT DeleteMethod([NativeTypeName("LPCWSTR")] ushort* wszName);

        [VtblIndex(22)]
        HRESULT BeginMethodEnumeration([NativeTypeName("long")] int lEnumFlags);

        [VtblIndex(23)]
        HRESULT NextMethod([NativeTypeName("long")] int lFlags, [NativeTypeName("BSTR *")] ushort** pstrName, IWbemClassObject** ppInSignature, IWbemClassObject** ppOutSignature);

        [VtblIndex(24)]
        HRESULT EndMethodEnumeration();

        [VtblIndex(25)]
        HRESULT GetMethodQualifierSet([NativeTypeName("LPCWSTR")] ushort* wszMethod, IWbemQualifierSet** ppQualSet);

        [VtblIndex(26)]
        HRESULT GetMethodOrigin([NativeTypeName("LPCWSTR")] ushort* wszMethodName, [NativeTypeName("BSTR *")] ushort** pstrClassName);
    }

    public partial struct Vtbl
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<IWbemClassObject*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<IWbemClassObject*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<IWbemClassObject*, uint> Release;

        [NativeTypeName("HRESULT (IWbemQualifierSet **) __attribute__((stdcall))")]
        public delegate* unmanaged<IWbemClassObject*, IWbemQualifierSet**, int> GetQualifierSet;

        [NativeTypeName("HRESULT (LPCWSTR, long, VARIANT *, CIMTYPE *, long *) __attribute__((stdcall))")]
        public delegate* unmanaged<IWbemClassObject*, ushort*, int, VARIANT*, int*, int*, int> Get;

        [NativeTypeName("HRESULT (LPCWSTR, long, VARIANT *, CIMTYPE) __attribute__((stdcall))")]
        public delegate* unmanaged<IWbemClassObject*, ushort*, int, VARIANT*, int, int> Put;

        [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<IWbemClassObject*, ushort*, int> Delete;

        [NativeTypeName("HRESULT (LPCWSTR, long, VARIANT *, SAFEARRAY **) __attribute__((stdcall))")]
        public delegate* unmanaged<IWbemClassObject*, ushort*, int, VARIANT*, SAFEARRAY**, int> GetNames;

        [NativeTypeName("HRESULT (long) __attribute__((stdcall))")]
        public delegate* unmanaged<IWbemClassObject*, int, int> BeginEnumeration;

        [NativeTypeName("HRESULT (long, BSTR *, VARIANT *, CIMTYPE *, long *) __attribute__((stdcall))")]
        public delegate* unmanaged<IWbemClassObject*, int, ushort**, VARIANT*, int*, int*, int> Next;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<IWbemClassObject*, int> EndEnumeration;

        [NativeTypeName("HRESULT (LPCWSTR, IWbemQualifierSet **) __attribute__((stdcall))")]
        public delegate* unmanaged<IWbemClassObject*, ushort*, IWbemQualifierSet**, int> GetPropertyQualifierSet;

        [NativeTypeName("HRESULT (IWbemClassObject **) __attribute__((stdcall))")]
        public delegate* unmanaged<IWbemClassObject*, IWbemClassObject**, int> Clone;

        [NativeTypeName("HRESULT (long, BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<IWbemClassObject*, int, ushort**, int> GetObjectText;

        [NativeTypeName("HRESULT (long, IWbemClassObject **) __attribute__((stdcall))")]
        public delegate* unmanaged<IWbemClassObject*, int, IWbemClassObject**, int> SpawnDerivedClass;

        [NativeTypeName("HRESULT (long, IWbemClassObject **) __attribute__((stdcall))")]
        public delegate* unmanaged<IWbemClassObject*, int, IWbemClassObject**, int> SpawnInstance;

        [NativeTypeName("HRESULT (long, IWbemClassObject *) __attribute__((stdcall))")]
        public delegate* unmanaged<IWbemClassObject*, int, IWbemClassObject*, int> CompareTo;

        [NativeTypeName("HRESULT (LPCWSTR, BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<IWbemClassObject*, ushort*, ushort**, int> GetPropertyOrigin;

        [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<IWbemClassObject*, ushort*, int> InheritsFrom;

        [NativeTypeName("HRESULT (LPCWSTR, long, IWbemClassObject **, IWbemClassObject **) __attribute__((stdcall))")]
        public delegate* unmanaged<IWbemClassObject*, ushort*, int, IWbemClassObject**, IWbemClassObject**, int> GetMethod;

        [NativeTypeName("HRESULT (LPCWSTR, long, IWbemClassObject *, IWbemClassObject *) __attribute__((stdcall))")]
        public delegate* unmanaged<IWbemClassObject*, ushort*, int, IWbemClassObject*, IWbemClassObject*, int> PutMethod;

        [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<IWbemClassObject*, ushort*, int> DeleteMethod;

        [NativeTypeName("HRESULT (long) __attribute__((stdcall))")]
        public delegate* unmanaged<IWbemClassObject*, int, int> BeginMethodEnumeration;

        [NativeTypeName("HRESULT (long, BSTR *, IWbemClassObject **, IWbemClassObject **) __attribute__((stdcall))")]
        public delegate* unmanaged<IWbemClassObject*, int, ushort**, IWbemClassObject**, IWbemClassObject**, int> NextMethod;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<IWbemClassObject*, int> EndMethodEnumeration;

        [NativeTypeName("HRESULT (LPCWSTR, IWbemQualifierSet **) __attribute__((stdcall))")]
        public delegate* unmanaged<IWbemClassObject*, ushort*, IWbemQualifierSet**, int> GetMethodQualifierSet;

        [NativeTypeName("HRESULT (LPCWSTR, BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<IWbemClassObject*, ushort*, ushort**, int> GetMethodOrigin;
    }
}
