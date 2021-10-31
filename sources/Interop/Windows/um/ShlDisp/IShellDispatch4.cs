// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShlDisp.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("EFD84B2D-4BCF-4298-BE25-EB542A59FBDA")]
    [NativeTypeName("struct IShellDispatch4 : IShellDispatch3")]
    [NativeInheritance("IShellDispatch3")]
    public unsafe partial struct IShellDispatch4
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IShellDispatch4*, Guid*, void**, int>)(lpVtbl[0]))((IShellDispatch4*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IShellDispatch4*, uint>)(lpVtbl[1]))((IShellDispatch4*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IShellDispatch4*, uint>)(lpVtbl[2]))((IShellDispatch4*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetTypeInfoCount(uint* pctinfo)
        {
            return ((delegate* unmanaged<IShellDispatch4*, uint*, int>)(lpVtbl[3]))((IShellDispatch4*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
        {
            return ((delegate* unmanaged<IShellDispatch4*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((IShellDispatch4*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* unmanaged<IShellDispatch4*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((IShellDispatch4*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
        {
            return ((delegate* unmanaged<IShellDispatch4*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((IShellDispatch4*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT get_Application(IDispatch** ppid)
        {
            return ((delegate* unmanaged<IShellDispatch4*, IDispatch**, int>)(lpVtbl[7]))((IShellDispatch4*)Unsafe.AsPointer(ref this), ppid);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT get_Parent(IDispatch** ppid)
        {
            return ((delegate* unmanaged<IShellDispatch4*, IDispatch**, int>)(lpVtbl[8]))((IShellDispatch4*)Unsafe.AsPointer(ref this), ppid);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT NameSpace(VARIANT vDir, Folder** ppsdf)
        {
            return ((delegate* unmanaged<IShellDispatch4*, VARIANT, Folder**, int>)(lpVtbl[9]))((IShellDispatch4*)Unsafe.AsPointer(ref this), vDir, ppsdf);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT BrowseForFolder([NativeTypeName("long")] int Hwnd, [NativeTypeName("BSTR")] ushort* Title, [NativeTypeName("long")] int Options, VARIANT RootFolder, Folder** ppsdf)
        {
            return ((delegate* unmanaged<IShellDispatch4*, int, ushort*, int, VARIANT, Folder**, int>)(lpVtbl[10]))((IShellDispatch4*)Unsafe.AsPointer(ref this), Hwnd, Title, Options, RootFolder, ppsdf);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT Windows(IDispatch** ppid)
        {
            return ((delegate* unmanaged<IShellDispatch4*, IDispatch**, int>)(lpVtbl[11]))((IShellDispatch4*)Unsafe.AsPointer(ref this), ppid);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT Open(VARIANT vDir)
        {
            return ((delegate* unmanaged<IShellDispatch4*, VARIANT, int>)(lpVtbl[12]))((IShellDispatch4*)Unsafe.AsPointer(ref this), vDir);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HRESULT Explore(VARIANT vDir)
        {
            return ((delegate* unmanaged<IShellDispatch4*, VARIANT, int>)(lpVtbl[13]))((IShellDispatch4*)Unsafe.AsPointer(ref this), vDir);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public HRESULT MinimizeAll()
        {
            return ((delegate* unmanaged<IShellDispatch4*, int>)(lpVtbl[14]))((IShellDispatch4*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        public HRESULT UndoMinimizeALL()
        {
            return ((delegate* unmanaged<IShellDispatch4*, int>)(lpVtbl[15]))((IShellDispatch4*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        public HRESULT FileRun()
        {
            return ((delegate* unmanaged<IShellDispatch4*, int>)(lpVtbl[16]))((IShellDispatch4*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        public HRESULT CascadeWindows()
        {
            return ((delegate* unmanaged<IShellDispatch4*, int>)(lpVtbl[17]))((IShellDispatch4*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        public HRESULT TileVertically()
        {
            return ((delegate* unmanaged<IShellDispatch4*, int>)(lpVtbl[18]))((IShellDispatch4*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        public HRESULT TileHorizontally()
        {
            return ((delegate* unmanaged<IShellDispatch4*, int>)(lpVtbl[19]))((IShellDispatch4*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        public HRESULT ShutdownWindows()
        {
            return ((delegate* unmanaged<IShellDispatch4*, int>)(lpVtbl[20]))((IShellDispatch4*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        public HRESULT Suspend()
        {
            return ((delegate* unmanaged<IShellDispatch4*, int>)(lpVtbl[21]))((IShellDispatch4*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(22)]
        public HRESULT EjectPC()
        {
            return ((delegate* unmanaged<IShellDispatch4*, int>)(lpVtbl[22]))((IShellDispatch4*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(23)]
        public HRESULT SetTime()
        {
            return ((delegate* unmanaged<IShellDispatch4*, int>)(lpVtbl[23]))((IShellDispatch4*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(24)]
        public HRESULT TrayProperties()
        {
            return ((delegate* unmanaged<IShellDispatch4*, int>)(lpVtbl[24]))((IShellDispatch4*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(25)]
        public HRESULT Help()
        {
            return ((delegate* unmanaged<IShellDispatch4*, int>)(lpVtbl[25]))((IShellDispatch4*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(26)]
        public HRESULT FindFiles()
        {
            return ((delegate* unmanaged<IShellDispatch4*, int>)(lpVtbl[26]))((IShellDispatch4*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(27)]
        public HRESULT FindComputer()
        {
            return ((delegate* unmanaged<IShellDispatch4*, int>)(lpVtbl[27]))((IShellDispatch4*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(28)]
        public HRESULT RefreshMenu()
        {
            return ((delegate* unmanaged<IShellDispatch4*, int>)(lpVtbl[28]))((IShellDispatch4*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(29)]
        public HRESULT ControlPanelItem([NativeTypeName("BSTR")] ushort* bstrDir)
        {
            return ((delegate* unmanaged<IShellDispatch4*, ushort*, int>)(lpVtbl[29]))((IShellDispatch4*)Unsafe.AsPointer(ref this), bstrDir);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(30)]
        public HRESULT IsRestricted([NativeTypeName("BSTR")] ushort* Group, [NativeTypeName("BSTR")] ushort* Restriction, [NativeTypeName("long *")] int* plRestrictValue)
        {
            return ((delegate* unmanaged<IShellDispatch4*, ushort*, ushort*, int*, int>)(lpVtbl[30]))((IShellDispatch4*)Unsafe.AsPointer(ref this), Group, Restriction, plRestrictValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(31)]
        public HRESULT ShellExecuteW([NativeTypeName("BSTR")] ushort* File, VARIANT vArgs, VARIANT vDir, VARIANT vOperation, VARIANT vShow)
        {
            return ((delegate* unmanaged<IShellDispatch4*, ushort*, VARIANT, VARIANT, VARIANT, VARIANT, int>)(lpVtbl[31]))((IShellDispatch4*)Unsafe.AsPointer(ref this), File, vArgs, vDir, vOperation, vShow);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(32)]
        public HRESULT FindPrinter([NativeTypeName("BSTR")] ushort* name, [NativeTypeName("BSTR")] ushort* location, [NativeTypeName("BSTR")] ushort* model)
        {
            return ((delegate* unmanaged<IShellDispatch4*, ushort*, ushort*, ushort*, int>)(lpVtbl[32]))((IShellDispatch4*)Unsafe.AsPointer(ref this), name, location, model);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(33)]
        public HRESULT GetSystemInformation([NativeTypeName("BSTR")] ushort* name, VARIANT* pv)
        {
            return ((delegate* unmanaged<IShellDispatch4*, ushort*, VARIANT*, int>)(lpVtbl[33]))((IShellDispatch4*)Unsafe.AsPointer(ref this), name, pv);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(34)]
        public HRESULT ServiceStart([NativeTypeName("BSTR")] ushort* ServiceName, VARIANT Persistent, VARIANT* pSuccess)
        {
            return ((delegate* unmanaged<IShellDispatch4*, ushort*, VARIANT, VARIANT*, int>)(lpVtbl[34]))((IShellDispatch4*)Unsafe.AsPointer(ref this), ServiceName, Persistent, pSuccess);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(35)]
        public HRESULT ServiceStop([NativeTypeName("BSTR")] ushort* ServiceName, VARIANT Persistent, VARIANT* pSuccess)
        {
            return ((delegate* unmanaged<IShellDispatch4*, ushort*, VARIANT, VARIANT*, int>)(lpVtbl[35]))((IShellDispatch4*)Unsafe.AsPointer(ref this), ServiceName, Persistent, pSuccess);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(36)]
        public HRESULT IsServiceRunning([NativeTypeName("BSTR")] ushort* ServiceName, VARIANT* pRunning)
        {
            return ((delegate* unmanaged<IShellDispatch4*, ushort*, VARIANT*, int>)(lpVtbl[36]))((IShellDispatch4*)Unsafe.AsPointer(ref this), ServiceName, pRunning);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(37)]
        public HRESULT CanStartStopService([NativeTypeName("BSTR")] ushort* ServiceName, VARIANT* pCanStartStop)
        {
            return ((delegate* unmanaged<IShellDispatch4*, ushort*, VARIANT*, int>)(lpVtbl[37]))((IShellDispatch4*)Unsafe.AsPointer(ref this), ServiceName, pCanStartStop);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(38)]
        public HRESULT ShowBrowserBar([NativeTypeName("BSTR")] ushort* bstrClsid, VARIANT bShow, VARIANT* pSuccess)
        {
            return ((delegate* unmanaged<IShellDispatch4*, ushort*, VARIANT, VARIANT*, int>)(lpVtbl[38]))((IShellDispatch4*)Unsafe.AsPointer(ref this), bstrClsid, bShow, pSuccess);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(39)]
        public HRESULT AddToRecent(VARIANT varFile, [NativeTypeName("BSTR")] ushort* bstrCategory)
        {
            return ((delegate* unmanaged<IShellDispatch4*, VARIANT, ushort*, int>)(lpVtbl[39]))((IShellDispatch4*)Unsafe.AsPointer(ref this), varFile, bstrCategory);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(40)]
        public HRESULT WindowsSecurity()
        {
            return ((delegate* unmanaged<IShellDispatch4*, int>)(lpVtbl[40]))((IShellDispatch4*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(41)]
        public HRESULT ToggleDesktop()
        {
            return ((delegate* unmanaged<IShellDispatch4*, int>)(lpVtbl[41]))((IShellDispatch4*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(42)]
        public HRESULT ExplorerPolicy([NativeTypeName("BSTR")] ushort* bstrPolicyName, VARIANT* pValue)
        {
            return ((delegate* unmanaged<IShellDispatch4*, ushort*, VARIANT*, int>)(lpVtbl[42]))((IShellDispatch4*)Unsafe.AsPointer(ref this), bstrPolicyName, pValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(43)]
        public HRESULT GetSetting([NativeTypeName("long")] int lSetting, [NativeTypeName("VARIANT_BOOL *")] short* pResult)
        {
            return ((delegate* unmanaged<IShellDispatch4*, int, short*, int>)(lpVtbl[43]))((IShellDispatch4*)Unsafe.AsPointer(ref this), lSetting, pResult);
        }
    }
}
