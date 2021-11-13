// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShlDisp.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows
{
    [Guid("A4C6892C-3BA9-11D2-9DEA-00C04FB16162")]
    [NativeTypeName("struct IShellDispatch2 : IShellDispatch")]
    [NativeInheritance("IShellDispatch")]
    public unsafe partial struct IShellDispatch2 : IShellDispatch2.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IShellDispatch2*, Guid*, void**, int>)(lpVtbl[0]))((IShellDispatch2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IShellDispatch2*, uint>)(lpVtbl[1]))((IShellDispatch2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IShellDispatch2*, uint>)(lpVtbl[2]))((IShellDispatch2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetTypeInfoCount(uint* pctinfo)
        {
            return ((delegate* unmanaged<IShellDispatch2*, uint*, int>)(lpVtbl[3]))((IShellDispatch2*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
        {
            return ((delegate* unmanaged<IShellDispatch2*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((IShellDispatch2*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* unmanaged<IShellDispatch2*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((IShellDispatch2*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
        {
            return ((delegate* unmanaged<IShellDispatch2*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((IShellDispatch2*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT get_Application(IDispatch** ppid)
        {
            return ((delegate* unmanaged<IShellDispatch2*, IDispatch**, int>)(lpVtbl[7]))((IShellDispatch2*)Unsafe.AsPointer(ref this), ppid);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT get_Parent(IDispatch** ppid)
        {
            return ((delegate* unmanaged<IShellDispatch2*, IDispatch**, int>)(lpVtbl[8]))((IShellDispatch2*)Unsafe.AsPointer(ref this), ppid);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT NameSpace(VARIANT vDir, Folder** ppsdf)
        {
            return ((delegate* unmanaged<IShellDispatch2*, VARIANT, Folder**, int>)(lpVtbl[9]))((IShellDispatch2*)Unsafe.AsPointer(ref this), vDir, ppsdf);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT BrowseForFolder([NativeTypeName("long")] int Hwnd, [NativeTypeName("BSTR")] ushort* Title, [NativeTypeName("long")] int Options, VARIANT RootFolder, Folder** ppsdf)
        {
            return ((delegate* unmanaged<IShellDispatch2*, int, ushort*, int, VARIANT, Folder**, int>)(lpVtbl[10]))((IShellDispatch2*)Unsafe.AsPointer(ref this), Hwnd, Title, Options, RootFolder, ppsdf);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT Windows(IDispatch** ppid)
        {
            return ((delegate* unmanaged<IShellDispatch2*, IDispatch**, int>)(lpVtbl[11]))((IShellDispatch2*)Unsafe.AsPointer(ref this), ppid);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT Open(VARIANT vDir)
        {
            return ((delegate* unmanaged<IShellDispatch2*, VARIANT, int>)(lpVtbl[12]))((IShellDispatch2*)Unsafe.AsPointer(ref this), vDir);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HRESULT Explore(VARIANT vDir)
        {
            return ((delegate* unmanaged<IShellDispatch2*, VARIANT, int>)(lpVtbl[13]))((IShellDispatch2*)Unsafe.AsPointer(ref this), vDir);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public HRESULT MinimizeAll()
        {
            return ((delegate* unmanaged<IShellDispatch2*, int>)(lpVtbl[14]))((IShellDispatch2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        public HRESULT UndoMinimizeALL()
        {
            return ((delegate* unmanaged<IShellDispatch2*, int>)(lpVtbl[15]))((IShellDispatch2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        public HRESULT FileRun()
        {
            return ((delegate* unmanaged<IShellDispatch2*, int>)(lpVtbl[16]))((IShellDispatch2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        public HRESULT CascadeWindows()
        {
            return ((delegate* unmanaged<IShellDispatch2*, int>)(lpVtbl[17]))((IShellDispatch2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        public HRESULT TileVertically()
        {
            return ((delegate* unmanaged<IShellDispatch2*, int>)(lpVtbl[18]))((IShellDispatch2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        public HRESULT TileHorizontally()
        {
            return ((delegate* unmanaged<IShellDispatch2*, int>)(lpVtbl[19]))((IShellDispatch2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        public HRESULT ShutdownWindows()
        {
            return ((delegate* unmanaged<IShellDispatch2*, int>)(lpVtbl[20]))((IShellDispatch2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        public HRESULT Suspend()
        {
            return ((delegate* unmanaged<IShellDispatch2*, int>)(lpVtbl[21]))((IShellDispatch2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(22)]
        public HRESULT EjectPC()
        {
            return ((delegate* unmanaged<IShellDispatch2*, int>)(lpVtbl[22]))((IShellDispatch2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(23)]
        public HRESULT SetTime()
        {
            return ((delegate* unmanaged<IShellDispatch2*, int>)(lpVtbl[23]))((IShellDispatch2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(24)]
        public HRESULT TrayProperties()
        {
            return ((delegate* unmanaged<IShellDispatch2*, int>)(lpVtbl[24]))((IShellDispatch2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(25)]
        public HRESULT Help()
        {
            return ((delegate* unmanaged<IShellDispatch2*, int>)(lpVtbl[25]))((IShellDispatch2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(26)]
        public HRESULT FindFiles()
        {
            return ((delegate* unmanaged<IShellDispatch2*, int>)(lpVtbl[26]))((IShellDispatch2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(27)]
        public HRESULT FindComputer()
        {
            return ((delegate* unmanaged<IShellDispatch2*, int>)(lpVtbl[27]))((IShellDispatch2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(28)]
        public HRESULT RefreshMenu()
        {
            return ((delegate* unmanaged<IShellDispatch2*, int>)(lpVtbl[28]))((IShellDispatch2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(29)]
        public HRESULT ControlPanelItem([NativeTypeName("BSTR")] ushort* bstrDir)
        {
            return ((delegate* unmanaged<IShellDispatch2*, ushort*, int>)(lpVtbl[29]))((IShellDispatch2*)Unsafe.AsPointer(ref this), bstrDir);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(30)]
        public HRESULT IsRestricted([NativeTypeName("BSTR")] ushort* Group, [NativeTypeName("BSTR")] ushort* Restriction, [NativeTypeName("long *")] int* plRestrictValue)
        {
            return ((delegate* unmanaged<IShellDispatch2*, ushort*, ushort*, int*, int>)(lpVtbl[30]))((IShellDispatch2*)Unsafe.AsPointer(ref this), Group, Restriction, plRestrictValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(31)]
        public HRESULT ShellExecuteW([NativeTypeName("BSTR")] ushort* File, VARIANT vArgs, VARIANT vDir, VARIANT vOperation, VARIANT vShow)
        {
            return ((delegate* unmanaged<IShellDispatch2*, ushort*, VARIANT, VARIANT, VARIANT, VARIANT, int>)(lpVtbl[31]))((IShellDispatch2*)Unsafe.AsPointer(ref this), File, vArgs, vDir, vOperation, vShow);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(32)]
        public HRESULT FindPrinter([NativeTypeName("BSTR")] ushort* name, [NativeTypeName("BSTR")] ushort* location, [NativeTypeName("BSTR")] ushort* model)
        {
            return ((delegate* unmanaged<IShellDispatch2*, ushort*, ushort*, ushort*, int>)(lpVtbl[32]))((IShellDispatch2*)Unsafe.AsPointer(ref this), name, location, model);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(33)]
        public HRESULT GetSystemInformation([NativeTypeName("BSTR")] ushort* name, VARIANT* pv)
        {
            return ((delegate* unmanaged<IShellDispatch2*, ushort*, VARIANT*, int>)(lpVtbl[33]))((IShellDispatch2*)Unsafe.AsPointer(ref this), name, pv);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(34)]
        public HRESULT ServiceStart([NativeTypeName("BSTR")] ushort* ServiceName, VARIANT Persistent, VARIANT* pSuccess)
        {
            return ((delegate* unmanaged<IShellDispatch2*, ushort*, VARIANT, VARIANT*, int>)(lpVtbl[34]))((IShellDispatch2*)Unsafe.AsPointer(ref this), ServiceName, Persistent, pSuccess);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(35)]
        public HRESULT ServiceStop([NativeTypeName("BSTR")] ushort* ServiceName, VARIANT Persistent, VARIANT* pSuccess)
        {
            return ((delegate* unmanaged<IShellDispatch2*, ushort*, VARIANT, VARIANT*, int>)(lpVtbl[35]))((IShellDispatch2*)Unsafe.AsPointer(ref this), ServiceName, Persistent, pSuccess);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(36)]
        public HRESULT IsServiceRunning([NativeTypeName("BSTR")] ushort* ServiceName, VARIANT* pRunning)
        {
            return ((delegate* unmanaged<IShellDispatch2*, ushort*, VARIANT*, int>)(lpVtbl[36]))((IShellDispatch2*)Unsafe.AsPointer(ref this), ServiceName, pRunning);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(37)]
        public HRESULT CanStartStopService([NativeTypeName("BSTR")] ushort* ServiceName, VARIANT* pCanStartStop)
        {
            return ((delegate* unmanaged<IShellDispatch2*, ushort*, VARIANT*, int>)(lpVtbl[37]))((IShellDispatch2*)Unsafe.AsPointer(ref this), ServiceName, pCanStartStop);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(38)]
        public HRESULT ShowBrowserBar([NativeTypeName("BSTR")] ushort* bstrClsid, VARIANT bShow, VARIANT* pSuccess)
        {
            return ((delegate* unmanaged<IShellDispatch2*, ushort*, VARIANT, VARIANT*, int>)(lpVtbl[38]))((IShellDispatch2*)Unsafe.AsPointer(ref this), bstrClsid, bShow, pSuccess);
        }

        public interface Interface : IShellDispatch.Interface
        {
            [VtblIndex(30)]
            HRESULT IsRestricted([NativeTypeName("BSTR")] ushort* Group, [NativeTypeName("BSTR")] ushort* Restriction, [NativeTypeName("long *")] int* plRestrictValue);

            [VtblIndex(31)]
            HRESULT ShellExecuteW([NativeTypeName("BSTR")] ushort* File, VARIANT vArgs, VARIANT vDir, VARIANT vOperation, VARIANT vShow);

            [VtblIndex(32)]
            HRESULT FindPrinter([NativeTypeName("BSTR")] ushort* name, [NativeTypeName("BSTR")] ushort* location, [NativeTypeName("BSTR")] ushort* model);

            [VtblIndex(33)]
            HRESULT GetSystemInformation([NativeTypeName("BSTR")] ushort* name, VARIANT* pv);

            [VtblIndex(34)]
            HRESULT ServiceStart([NativeTypeName("BSTR")] ushort* ServiceName, VARIANT Persistent, VARIANT* pSuccess);

            [VtblIndex(35)]
            HRESULT ServiceStop([NativeTypeName("BSTR")] ushort* ServiceName, VARIANT Persistent, VARIANT* pSuccess);

            [VtblIndex(36)]
            HRESULT IsServiceRunning([NativeTypeName("BSTR")] ushort* ServiceName, VARIANT* pRunning);

            [VtblIndex(37)]
            HRESULT CanStartStopService([NativeTypeName("BSTR")] ushort* ServiceName, VARIANT* pCanStartStop);

            [VtblIndex(38)]
            HRESULT ShowBrowserBar([NativeTypeName("BSTR")] ushort* bstrClsid, VARIANT bShow, VARIANT* pSuccess);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IShellDispatch2*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IShellDispatch2*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IShellDispatch2*, uint> Release;

            [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged<IShellDispatch2*, uint*, int> GetTypeInfoCount;

            [NativeTypeName("HRESULT (UINT, LCID, ITypeInfo **) __attribute__((stdcall))")]
            public delegate* unmanaged<IShellDispatch2*, uint, uint, ITypeInfo**, int> GetTypeInfo;

            [NativeTypeName("HRESULT (const IID &, LPOLESTR *, UINT, LCID, DISPID *) __attribute__((stdcall))")]
            public delegate* unmanaged<IShellDispatch2*, Guid*, ushort**, uint, uint, int*, int> GetIDsOfNames;

            [NativeTypeName("HRESULT (DISPID, const IID &, LCID, WORD, DISPPARAMS *, VARIANT *, EXCEPINFO *, UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged<IShellDispatch2*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int> Invoke;

            [NativeTypeName("HRESULT (IDispatch **) __attribute__((stdcall))")]
            public delegate* unmanaged<IShellDispatch2*, IDispatch**, int> get_Application;

            [NativeTypeName("HRESULT (IDispatch **) __attribute__((stdcall))")]
            public delegate* unmanaged<IShellDispatch2*, IDispatch**, int> get_Parent;

            [NativeTypeName("HRESULT (VARIANT, Folder **) __attribute__((stdcall))")]
            public delegate* unmanaged<IShellDispatch2*, VARIANT, Folder**, int> NameSpace;

            [NativeTypeName("HRESULT (long, BSTR, long, VARIANT, Folder **) __attribute__((stdcall))")]
            public delegate* unmanaged<IShellDispatch2*, int, ushort*, int, VARIANT, Folder**, int> BrowseForFolder;

            [NativeTypeName("HRESULT (IDispatch **) __attribute__((stdcall))")]
            public delegate* unmanaged<IShellDispatch2*, IDispatch**, int> Windows;

            [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
            public delegate* unmanaged<IShellDispatch2*, VARIANT, int> Open;

            [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
            public delegate* unmanaged<IShellDispatch2*, VARIANT, int> Explore;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<IShellDispatch2*, int> MinimizeAll;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<IShellDispatch2*, int> UndoMinimizeALL;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<IShellDispatch2*, int> FileRun;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<IShellDispatch2*, int> CascadeWindows;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<IShellDispatch2*, int> TileVertically;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<IShellDispatch2*, int> TileHorizontally;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<IShellDispatch2*, int> ShutdownWindows;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<IShellDispatch2*, int> Suspend;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<IShellDispatch2*, int> EjectPC;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<IShellDispatch2*, int> SetTime;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<IShellDispatch2*, int> TrayProperties;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<IShellDispatch2*, int> Help;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<IShellDispatch2*, int> FindFiles;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<IShellDispatch2*, int> FindComputer;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<IShellDispatch2*, int> RefreshMenu;

            [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
            public delegate* unmanaged<IShellDispatch2*, ushort*, int> ControlPanelItem;

            [NativeTypeName("HRESULT (BSTR, BSTR, long *) __attribute__((stdcall))")]
            public delegate* unmanaged<IShellDispatch2*, ushort*, ushort*, int*, int> IsRestricted;

            [NativeTypeName("HRESULT (BSTR, VARIANT, VARIANT, VARIANT, VARIANT) __attribute__((stdcall))")]
            public delegate* unmanaged<IShellDispatch2*, ushort*, VARIANT, VARIANT, VARIANT, VARIANT, int> ShellExecuteW;

            [NativeTypeName("HRESULT (BSTR, BSTR, BSTR) __attribute__((stdcall))")]
            public delegate* unmanaged<IShellDispatch2*, ushort*, ushort*, ushort*, int> FindPrinter;

            [NativeTypeName("HRESULT (BSTR, VARIANT *) __attribute__((stdcall))")]
            public delegate* unmanaged<IShellDispatch2*, ushort*, VARIANT*, int> GetSystemInformation;

            [NativeTypeName("HRESULT (BSTR, VARIANT, VARIANT *) __attribute__((stdcall))")]
            public delegate* unmanaged<IShellDispatch2*, ushort*, VARIANT, VARIANT*, int> ServiceStart;

            [NativeTypeName("HRESULT (BSTR, VARIANT, VARIANT *) __attribute__((stdcall))")]
            public delegate* unmanaged<IShellDispatch2*, ushort*, VARIANT, VARIANT*, int> ServiceStop;

            [NativeTypeName("HRESULT (BSTR, VARIANT *) __attribute__((stdcall))")]
            public delegate* unmanaged<IShellDispatch2*, ushort*, VARIANT*, int> IsServiceRunning;

            [NativeTypeName("HRESULT (BSTR, VARIANT *) __attribute__((stdcall))")]
            public delegate* unmanaged<IShellDispatch2*, ushort*, VARIANT*, int> CanStartStopService;

            [NativeTypeName("HRESULT (BSTR, VARIANT, VARIANT *) __attribute__((stdcall))")]
            public delegate* unmanaged<IShellDispatch2*, ushort*, VARIANT, VARIANT*, int> ShowBrowserBar;
        }
    }
}
