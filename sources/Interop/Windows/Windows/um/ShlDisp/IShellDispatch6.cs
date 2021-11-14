// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShlDisp.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows
{
    [Guid("286E6F1B-7113-4355-9562-96B7E9D64C54")]
    [NativeTypeName("struct IShellDispatch6 : IShellDispatch5")]
    [NativeInheritance("IShellDispatch5")]
    public unsafe partial struct IShellDispatch6 : IShellDispatch6.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IShellDispatch6*, Guid*, void**, int>)(lpVtbl[0]))((IShellDispatch6*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IShellDispatch6*, uint>)(lpVtbl[1]))((IShellDispatch6*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IShellDispatch6*, uint>)(lpVtbl[2]))((IShellDispatch6*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetTypeInfoCount(uint* pctinfo)
        {
            return ((delegate* unmanaged<IShellDispatch6*, uint*, int>)(lpVtbl[3]))((IShellDispatch6*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
        {
            return ((delegate* unmanaged<IShellDispatch6*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((IShellDispatch6*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* unmanaged<IShellDispatch6*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((IShellDispatch6*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
        {
            return ((delegate* unmanaged<IShellDispatch6*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((IShellDispatch6*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT get_Application(IDispatch** ppid)
        {
            return ((delegate* unmanaged<IShellDispatch6*, IDispatch**, int>)(lpVtbl[7]))((IShellDispatch6*)Unsafe.AsPointer(ref this), ppid);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT get_Parent(IDispatch** ppid)
        {
            return ((delegate* unmanaged<IShellDispatch6*, IDispatch**, int>)(lpVtbl[8]))((IShellDispatch6*)Unsafe.AsPointer(ref this), ppid);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT NameSpace(VARIANT vDir, Folder** ppsdf)
        {
            return ((delegate* unmanaged<IShellDispatch6*, VARIANT, Folder**, int>)(lpVtbl[9]))((IShellDispatch6*)Unsafe.AsPointer(ref this), vDir, ppsdf);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT BrowseForFolder([NativeTypeName("long")] int Hwnd, [NativeTypeName("BSTR")] ushort* Title, [NativeTypeName("long")] int Options, VARIANT RootFolder, Folder** ppsdf)
        {
            return ((delegate* unmanaged<IShellDispatch6*, int, ushort*, int, VARIANT, Folder**, int>)(lpVtbl[10]))((IShellDispatch6*)Unsafe.AsPointer(ref this), Hwnd, Title, Options, RootFolder, ppsdf);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT Windows(IDispatch** ppid)
        {
            return ((delegate* unmanaged<IShellDispatch6*, IDispatch**, int>)(lpVtbl[11]))((IShellDispatch6*)Unsafe.AsPointer(ref this), ppid);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT Open(VARIANT vDir)
        {
            return ((delegate* unmanaged<IShellDispatch6*, VARIANT, int>)(lpVtbl[12]))((IShellDispatch6*)Unsafe.AsPointer(ref this), vDir);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HRESULT Explore(VARIANT vDir)
        {
            return ((delegate* unmanaged<IShellDispatch6*, VARIANT, int>)(lpVtbl[13]))((IShellDispatch6*)Unsafe.AsPointer(ref this), vDir);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public HRESULT MinimizeAll()
        {
            return ((delegate* unmanaged<IShellDispatch6*, int>)(lpVtbl[14]))((IShellDispatch6*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        public HRESULT UndoMinimizeALL()
        {
            return ((delegate* unmanaged<IShellDispatch6*, int>)(lpVtbl[15]))((IShellDispatch6*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        public HRESULT FileRun()
        {
            return ((delegate* unmanaged<IShellDispatch6*, int>)(lpVtbl[16]))((IShellDispatch6*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        public HRESULT CascadeWindows()
        {
            return ((delegate* unmanaged<IShellDispatch6*, int>)(lpVtbl[17]))((IShellDispatch6*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        public HRESULT TileVertically()
        {
            return ((delegate* unmanaged<IShellDispatch6*, int>)(lpVtbl[18]))((IShellDispatch6*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        public HRESULT TileHorizontally()
        {
            return ((delegate* unmanaged<IShellDispatch6*, int>)(lpVtbl[19]))((IShellDispatch6*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        public HRESULT ShutdownWindows()
        {
            return ((delegate* unmanaged<IShellDispatch6*, int>)(lpVtbl[20]))((IShellDispatch6*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        public HRESULT Suspend()
        {
            return ((delegate* unmanaged<IShellDispatch6*, int>)(lpVtbl[21]))((IShellDispatch6*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(22)]
        public HRESULT EjectPC()
        {
            return ((delegate* unmanaged<IShellDispatch6*, int>)(lpVtbl[22]))((IShellDispatch6*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(23)]
        public HRESULT SetTime()
        {
            return ((delegate* unmanaged<IShellDispatch6*, int>)(lpVtbl[23]))((IShellDispatch6*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(24)]
        public HRESULT TrayProperties()
        {
            return ((delegate* unmanaged<IShellDispatch6*, int>)(lpVtbl[24]))((IShellDispatch6*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(25)]
        public HRESULT Help()
        {
            return ((delegate* unmanaged<IShellDispatch6*, int>)(lpVtbl[25]))((IShellDispatch6*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(26)]
        public HRESULT FindFiles()
        {
            return ((delegate* unmanaged<IShellDispatch6*, int>)(lpVtbl[26]))((IShellDispatch6*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(27)]
        public HRESULT FindComputer()
        {
            return ((delegate* unmanaged<IShellDispatch6*, int>)(lpVtbl[27]))((IShellDispatch6*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(28)]
        public HRESULT RefreshMenu()
        {
            return ((delegate* unmanaged<IShellDispatch6*, int>)(lpVtbl[28]))((IShellDispatch6*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(29)]
        public HRESULT ControlPanelItem([NativeTypeName("BSTR")] ushort* bstrDir)
        {
            return ((delegate* unmanaged<IShellDispatch6*, ushort*, int>)(lpVtbl[29]))((IShellDispatch6*)Unsafe.AsPointer(ref this), bstrDir);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(30)]
        public HRESULT IsRestricted([NativeTypeName("BSTR")] ushort* Group, [NativeTypeName("BSTR")] ushort* Restriction, [NativeTypeName("long *")] int* plRestrictValue)
        {
            return ((delegate* unmanaged<IShellDispatch6*, ushort*, ushort*, int*, int>)(lpVtbl[30]))((IShellDispatch6*)Unsafe.AsPointer(ref this), Group, Restriction, plRestrictValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(31)]
        public HRESULT ShellExecuteW([NativeTypeName("BSTR")] ushort* File, VARIANT vArgs, VARIANT vDir, VARIANT vOperation, VARIANT vShow)
        {
            return ((delegate* unmanaged<IShellDispatch6*, ushort*, VARIANT, VARIANT, VARIANT, VARIANT, int>)(lpVtbl[31]))((IShellDispatch6*)Unsafe.AsPointer(ref this), File, vArgs, vDir, vOperation, vShow);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(32)]
        public HRESULT FindPrinter([NativeTypeName("BSTR")] ushort* name, [NativeTypeName("BSTR")] ushort* location, [NativeTypeName("BSTR")] ushort* model)
        {
            return ((delegate* unmanaged<IShellDispatch6*, ushort*, ushort*, ushort*, int>)(lpVtbl[32]))((IShellDispatch6*)Unsafe.AsPointer(ref this), name, location, model);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(33)]
        public HRESULT GetSystemInformation([NativeTypeName("BSTR")] ushort* name, VARIANT* pv)
        {
            return ((delegate* unmanaged<IShellDispatch6*, ushort*, VARIANT*, int>)(lpVtbl[33]))((IShellDispatch6*)Unsafe.AsPointer(ref this), name, pv);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(34)]
        public HRESULT ServiceStart([NativeTypeName("BSTR")] ushort* ServiceName, VARIANT Persistent, VARIANT* pSuccess)
        {
            return ((delegate* unmanaged<IShellDispatch6*, ushort*, VARIANT, VARIANT*, int>)(lpVtbl[34]))((IShellDispatch6*)Unsafe.AsPointer(ref this), ServiceName, Persistent, pSuccess);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(35)]
        public HRESULT ServiceStop([NativeTypeName("BSTR")] ushort* ServiceName, VARIANT Persistent, VARIANT* pSuccess)
        {
            return ((delegate* unmanaged<IShellDispatch6*, ushort*, VARIANT, VARIANT*, int>)(lpVtbl[35]))((IShellDispatch6*)Unsafe.AsPointer(ref this), ServiceName, Persistent, pSuccess);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(36)]
        public HRESULT IsServiceRunning([NativeTypeName("BSTR")] ushort* ServiceName, VARIANT* pRunning)
        {
            return ((delegate* unmanaged<IShellDispatch6*, ushort*, VARIANT*, int>)(lpVtbl[36]))((IShellDispatch6*)Unsafe.AsPointer(ref this), ServiceName, pRunning);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(37)]
        public HRESULT CanStartStopService([NativeTypeName("BSTR")] ushort* ServiceName, VARIANT* pCanStartStop)
        {
            return ((delegate* unmanaged<IShellDispatch6*, ushort*, VARIANT*, int>)(lpVtbl[37]))((IShellDispatch6*)Unsafe.AsPointer(ref this), ServiceName, pCanStartStop);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(38)]
        public HRESULT ShowBrowserBar([NativeTypeName("BSTR")] ushort* bstrClsid, VARIANT bShow, VARIANT* pSuccess)
        {
            return ((delegate* unmanaged<IShellDispatch6*, ushort*, VARIANT, VARIANT*, int>)(lpVtbl[38]))((IShellDispatch6*)Unsafe.AsPointer(ref this), bstrClsid, bShow, pSuccess);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(39)]
        public HRESULT AddToRecent(VARIANT varFile, [NativeTypeName("BSTR")] ushort* bstrCategory)
        {
            return ((delegate* unmanaged<IShellDispatch6*, VARIANT, ushort*, int>)(lpVtbl[39]))((IShellDispatch6*)Unsafe.AsPointer(ref this), varFile, bstrCategory);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(40)]
        public HRESULT WindowsSecurity()
        {
            return ((delegate* unmanaged<IShellDispatch6*, int>)(lpVtbl[40]))((IShellDispatch6*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(41)]
        public HRESULT ToggleDesktop()
        {
            return ((delegate* unmanaged<IShellDispatch6*, int>)(lpVtbl[41]))((IShellDispatch6*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(42)]
        public HRESULT ExplorerPolicy([NativeTypeName("BSTR")] ushort* bstrPolicyName, VARIANT* pValue)
        {
            return ((delegate* unmanaged<IShellDispatch6*, ushort*, VARIANT*, int>)(lpVtbl[42]))((IShellDispatch6*)Unsafe.AsPointer(ref this), bstrPolicyName, pValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(43)]
        public HRESULT GetSetting([NativeTypeName("long")] int lSetting, [NativeTypeName("VARIANT_BOOL *")] short* pResult)
        {
            return ((delegate* unmanaged<IShellDispatch6*, int, short*, int>)(lpVtbl[43]))((IShellDispatch6*)Unsafe.AsPointer(ref this), lSetting, pResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(44)]
        public HRESULT WindowSwitcher()
        {
            return ((delegate* unmanaged<IShellDispatch6*, int>)(lpVtbl[44]))((IShellDispatch6*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(45)]
        public HRESULT SearchCommand()
        {
            return ((delegate* unmanaged<IShellDispatch6*, int>)(lpVtbl[45]))((IShellDispatch6*)Unsafe.AsPointer(ref this));
        }

        public interface Interface : IShellDispatch5.Interface
        {
            [VtblIndex(45)]
            HRESULT SearchCommand();
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IShellDispatch6*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IShellDispatch6*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IShellDispatch6*, uint> Release;

            [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged<IShellDispatch6*, uint*, int> GetTypeInfoCount;

            [NativeTypeName("HRESULT (UINT, LCID, ITypeInfo **) __attribute__((stdcall))")]
            public delegate* unmanaged<IShellDispatch6*, uint, uint, ITypeInfo**, int> GetTypeInfo;

            [NativeTypeName("HRESULT (const IID &, LPOLESTR *, UINT, LCID, DISPID *) __attribute__((stdcall))")]
            public delegate* unmanaged<IShellDispatch6*, Guid*, ushort**, uint, uint, int*, int> GetIDsOfNames;

            [NativeTypeName("HRESULT (DISPID, const IID &, LCID, WORD, DISPPARAMS *, VARIANT *, EXCEPINFO *, UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged<IShellDispatch6*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int> Invoke;

            [NativeTypeName("HRESULT (IDispatch **) __attribute__((stdcall))")]
            public delegate* unmanaged<IShellDispatch6*, IDispatch**, int> get_Application;

            [NativeTypeName("HRESULT (IDispatch **) __attribute__((stdcall))")]
            public delegate* unmanaged<IShellDispatch6*, IDispatch**, int> get_Parent;

            [NativeTypeName("HRESULT (VARIANT, Folder **) __attribute__((stdcall))")]
            public delegate* unmanaged<IShellDispatch6*, VARIANT, Folder**, int> NameSpace;

            [NativeTypeName("HRESULT (long, BSTR, long, VARIANT, Folder **) __attribute__((stdcall))")]
            public delegate* unmanaged<IShellDispatch6*, int, ushort*, int, VARIANT, Folder**, int> BrowseForFolder;

            [NativeTypeName("HRESULT (IDispatch **) __attribute__((stdcall))")]
            public delegate* unmanaged<IShellDispatch6*, IDispatch**, int> Windows;

            [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
            public delegate* unmanaged<IShellDispatch6*, VARIANT, int> Open;

            [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
            public delegate* unmanaged<IShellDispatch6*, VARIANT, int> Explore;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<IShellDispatch6*, int> MinimizeAll;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<IShellDispatch6*, int> UndoMinimizeALL;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<IShellDispatch6*, int> FileRun;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<IShellDispatch6*, int> CascadeWindows;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<IShellDispatch6*, int> TileVertically;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<IShellDispatch6*, int> TileHorizontally;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<IShellDispatch6*, int> ShutdownWindows;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<IShellDispatch6*, int> Suspend;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<IShellDispatch6*, int> EjectPC;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<IShellDispatch6*, int> SetTime;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<IShellDispatch6*, int> TrayProperties;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<IShellDispatch6*, int> Help;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<IShellDispatch6*, int> FindFiles;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<IShellDispatch6*, int> FindComputer;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<IShellDispatch6*, int> RefreshMenu;

            [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
            public delegate* unmanaged<IShellDispatch6*, ushort*, int> ControlPanelItem;

            [NativeTypeName("HRESULT (BSTR, BSTR, long *) __attribute__((stdcall))")]
            public delegate* unmanaged<IShellDispatch6*, ushort*, ushort*, int*, int> IsRestricted;

            [NativeTypeName("HRESULT (BSTR, VARIANT, VARIANT, VARIANT, VARIANT) __attribute__((stdcall))")]
            public delegate* unmanaged<IShellDispatch6*, ushort*, VARIANT, VARIANT, VARIANT, VARIANT, int> ShellExecuteW;

            [NativeTypeName("HRESULT (BSTR, BSTR, BSTR) __attribute__((stdcall))")]
            public delegate* unmanaged<IShellDispatch6*, ushort*, ushort*, ushort*, int> FindPrinter;

            [NativeTypeName("HRESULT (BSTR, VARIANT *) __attribute__((stdcall))")]
            public delegate* unmanaged<IShellDispatch6*, ushort*, VARIANT*, int> GetSystemInformation;

            [NativeTypeName("HRESULT (BSTR, VARIANT, VARIANT *) __attribute__((stdcall))")]
            public delegate* unmanaged<IShellDispatch6*, ushort*, VARIANT, VARIANT*, int> ServiceStart;

            [NativeTypeName("HRESULT (BSTR, VARIANT, VARIANT *) __attribute__((stdcall))")]
            public delegate* unmanaged<IShellDispatch6*, ushort*, VARIANT, VARIANT*, int> ServiceStop;

            [NativeTypeName("HRESULT (BSTR, VARIANT *) __attribute__((stdcall))")]
            public delegate* unmanaged<IShellDispatch6*, ushort*, VARIANT*, int> IsServiceRunning;

            [NativeTypeName("HRESULT (BSTR, VARIANT *) __attribute__((stdcall))")]
            public delegate* unmanaged<IShellDispatch6*, ushort*, VARIANT*, int> CanStartStopService;

            [NativeTypeName("HRESULT (BSTR, VARIANT, VARIANT *) __attribute__((stdcall))")]
            public delegate* unmanaged<IShellDispatch6*, ushort*, VARIANT, VARIANT*, int> ShowBrowserBar;

            [NativeTypeName("HRESULT (VARIANT, BSTR) __attribute__((stdcall))")]
            public delegate* unmanaged<IShellDispatch6*, VARIANT, ushort*, int> AddToRecent;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<IShellDispatch6*, int> WindowsSecurity;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<IShellDispatch6*, int> ToggleDesktop;

            [NativeTypeName("HRESULT (BSTR, VARIANT *) __attribute__((stdcall))")]
            public delegate* unmanaged<IShellDispatch6*, ushort*, VARIANT*, int> ExplorerPolicy;

            [NativeTypeName("HRESULT (long, VARIANT_BOOL *) __attribute__((stdcall))")]
            public delegate* unmanaged<IShellDispatch6*, int, short*, int> GetSetting;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<IShellDispatch6*, int> WindowSwitcher;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<IShellDispatch6*, int> SearchCommand;
        }
    }
}
