// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ole2.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

public static unsafe partial class Windows
{
    /// <include file='Windows.xml' path='doc/member[@name="Windows.OleBuildVersion"]/*' />
    [DllImport("ole32", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint OleBuildVersion();

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WriteFmtUserTypeStg"]/*' />
    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT WriteFmtUserTypeStg([NativeTypeName("LPSTORAGE")] IStorage* pstg, [NativeTypeName("CLIPFORMAT")] ushort cf, [NativeTypeName("LPOLESTR")] char* lpszUserType);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ReadFmtUserTypeStg"]/*' />
    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT ReadFmtUserTypeStg([NativeTypeName("LPSTORAGE")] IStorage* pstg, [NativeTypeName("CLIPFORMAT *")] ushort* pcf, [NativeTypeName("LPOLESTR *")] char** lplpszUserType);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.OleInitialize"]/*' />
    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT OleInitialize([NativeTypeName("LPVOID")] void* pvReserved);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.OleUninitialize"]/*' />
    [DllImport("ole32", ExactSpelling = true)]
    public static extern void OleUninitialize();

    /// <include file='Windows.xml' path='doc/member[@name="Windows.OleQueryLinkFromData"]/*' />
    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT OleQueryLinkFromData([NativeTypeName("LPDATAOBJECT")] IDataObject* pSrcDataObject);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.OleQueryCreateFromData"]/*' />
    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT OleQueryCreateFromData([NativeTypeName("LPDATAOBJECT")] IDataObject* pSrcDataObject);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.OleCreate"]/*' />
    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT OleCreate([NativeTypeName("const IID &")] Guid* rclsid, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("DWORD")] uint renderopt, [NativeTypeName("LPFORMATETC")] FORMATETC* pFormatEtc, [NativeTypeName("LPOLECLIENTSITE")] IOleClientSite* pClientSite, [NativeTypeName("LPSTORAGE")] IStorage* pStg, [NativeTypeName("LPVOID *")] void** ppvObj);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.OleCreateEx"]/*' />
    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT OleCreateEx([NativeTypeName("const IID &")] Guid* rclsid, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("DWORD")] uint renderopt, [NativeTypeName("ULONG")] uint cFormats, [NativeTypeName("DWORD *")] uint* rgAdvf, [NativeTypeName("LPFORMATETC")] FORMATETC* rgFormatEtc, IAdviseSink* lpAdviseSink, [NativeTypeName("DWORD *")] uint* rgdwConnection, [NativeTypeName("LPOLECLIENTSITE")] IOleClientSite* pClientSite, [NativeTypeName("LPSTORAGE")] IStorage* pStg, [NativeTypeName("LPVOID *")] void** ppvObj);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.OleCreateFromData"]/*' />
    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT OleCreateFromData([NativeTypeName("LPDATAOBJECT")] IDataObject* pSrcDataObj, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("DWORD")] uint renderopt, [NativeTypeName("LPFORMATETC")] FORMATETC* pFormatEtc, [NativeTypeName("LPOLECLIENTSITE")] IOleClientSite* pClientSite, [NativeTypeName("LPSTORAGE")] IStorage* pStg, [NativeTypeName("LPVOID *")] void** ppvObj);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.OleCreateFromDataEx"]/*' />
    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT OleCreateFromDataEx([NativeTypeName("LPDATAOBJECT")] IDataObject* pSrcDataObj, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("DWORD")] uint renderopt, [NativeTypeName("ULONG")] uint cFormats, [NativeTypeName("DWORD *")] uint* rgAdvf, [NativeTypeName("LPFORMATETC")] FORMATETC* rgFormatEtc, IAdviseSink* lpAdviseSink, [NativeTypeName("DWORD *")] uint* rgdwConnection, [NativeTypeName("LPOLECLIENTSITE")] IOleClientSite* pClientSite, [NativeTypeName("LPSTORAGE")] IStorage* pStg, [NativeTypeName("LPVOID *")] void** ppvObj);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.OleCreateLinkFromData"]/*' />
    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT OleCreateLinkFromData([NativeTypeName("LPDATAOBJECT")] IDataObject* pSrcDataObj, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("DWORD")] uint renderopt, [NativeTypeName("LPFORMATETC")] FORMATETC* pFormatEtc, [NativeTypeName("LPOLECLIENTSITE")] IOleClientSite* pClientSite, [NativeTypeName("LPSTORAGE")] IStorage* pStg, [NativeTypeName("LPVOID *")] void** ppvObj);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.OleCreateLinkFromDataEx"]/*' />
    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT OleCreateLinkFromDataEx([NativeTypeName("LPDATAOBJECT")] IDataObject* pSrcDataObj, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("DWORD")] uint renderopt, [NativeTypeName("ULONG")] uint cFormats, [NativeTypeName("DWORD *")] uint* rgAdvf, [NativeTypeName("LPFORMATETC")] FORMATETC* rgFormatEtc, IAdviseSink* lpAdviseSink, [NativeTypeName("DWORD *")] uint* rgdwConnection, [NativeTypeName("LPOLECLIENTSITE")] IOleClientSite* pClientSite, [NativeTypeName("LPSTORAGE")] IStorage* pStg, [NativeTypeName("LPVOID *")] void** ppvObj);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.OleCreateStaticFromData"]/*' />
    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT OleCreateStaticFromData([NativeTypeName("LPDATAOBJECT")] IDataObject* pSrcDataObj, [NativeTypeName("const IID &")] Guid* iid, [NativeTypeName("DWORD")] uint renderopt, [NativeTypeName("LPFORMATETC")] FORMATETC* pFormatEtc, [NativeTypeName("LPOLECLIENTSITE")] IOleClientSite* pClientSite, [NativeTypeName("LPSTORAGE")] IStorage* pStg, [NativeTypeName("LPVOID *")] void** ppvObj);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.OleCreateLink"]/*' />
    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT OleCreateLink([NativeTypeName("LPMONIKER")] IMoniker* pmkLinkSrc, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("DWORD")] uint renderopt, [NativeTypeName("LPFORMATETC")] FORMATETC* lpFormatEtc, [NativeTypeName("LPOLECLIENTSITE")] IOleClientSite* pClientSite, [NativeTypeName("LPSTORAGE")] IStorage* pStg, [NativeTypeName("LPVOID *")] void** ppvObj);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.OleCreateLinkEx"]/*' />
    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT OleCreateLinkEx([NativeTypeName("LPMONIKER")] IMoniker* pmkLinkSrc, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("DWORD")] uint renderopt, [NativeTypeName("ULONG")] uint cFormats, [NativeTypeName("DWORD *")] uint* rgAdvf, [NativeTypeName("LPFORMATETC")] FORMATETC* rgFormatEtc, IAdviseSink* lpAdviseSink, [NativeTypeName("DWORD *")] uint* rgdwConnection, [NativeTypeName("LPOLECLIENTSITE")] IOleClientSite* pClientSite, [NativeTypeName("LPSTORAGE")] IStorage* pStg, [NativeTypeName("LPVOID *")] void** ppvObj);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.OleCreateLinkToFile"]/*' />
    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT OleCreateLinkToFile([NativeTypeName("LPCOLESTR")] char* lpszFileName, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("DWORD")] uint renderopt, [NativeTypeName("LPFORMATETC")] FORMATETC* lpFormatEtc, [NativeTypeName("LPOLECLIENTSITE")] IOleClientSite* pClientSite, [NativeTypeName("LPSTORAGE")] IStorage* pStg, [NativeTypeName("LPVOID *")] void** ppvObj);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.OleCreateLinkToFileEx"]/*' />
    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT OleCreateLinkToFileEx([NativeTypeName("LPCOLESTR")] char* lpszFileName, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("DWORD")] uint renderopt, [NativeTypeName("ULONG")] uint cFormats, [NativeTypeName("DWORD *")] uint* rgAdvf, [NativeTypeName("LPFORMATETC")] FORMATETC* rgFormatEtc, IAdviseSink* lpAdviseSink, [NativeTypeName("DWORD *")] uint* rgdwConnection, [NativeTypeName("LPOLECLIENTSITE")] IOleClientSite* pClientSite, [NativeTypeName("LPSTORAGE")] IStorage* pStg, [NativeTypeName("LPVOID *")] void** ppvObj);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.OleCreateFromFile"]/*' />
    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT OleCreateFromFile([NativeTypeName("const IID &")] Guid* rclsid, [NativeTypeName("LPCOLESTR")] char* lpszFileName, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("DWORD")] uint renderopt, [NativeTypeName("LPFORMATETC")] FORMATETC* lpFormatEtc, [NativeTypeName("LPOLECLIENTSITE")] IOleClientSite* pClientSite, [NativeTypeName("LPSTORAGE")] IStorage* pStg, [NativeTypeName("LPVOID *")] void** ppvObj);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.OleCreateFromFileEx"]/*' />
    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT OleCreateFromFileEx([NativeTypeName("const IID &")] Guid* rclsid, [NativeTypeName("LPCOLESTR")] char* lpszFileName, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("DWORD")] uint renderopt, [NativeTypeName("ULONG")] uint cFormats, [NativeTypeName("DWORD *")] uint* rgAdvf, [NativeTypeName("LPFORMATETC")] FORMATETC* rgFormatEtc, IAdviseSink* lpAdviseSink, [NativeTypeName("DWORD *")] uint* rgdwConnection, [NativeTypeName("LPOLECLIENTSITE")] IOleClientSite* pClientSite, [NativeTypeName("LPSTORAGE")] IStorage* pStg, [NativeTypeName("LPVOID *")] void** ppvObj);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.OleLoad"]/*' />
    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT OleLoad([NativeTypeName("LPSTORAGE")] IStorage* pStg, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLECLIENTSITE")] IOleClientSite* pClientSite, [NativeTypeName("LPVOID *")] void** ppvObj);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.OleSave"]/*' />
    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT OleSave([NativeTypeName("LPPERSISTSTORAGE")] IPersistStorage* pPS, [NativeTypeName("LPSTORAGE")] IStorage* pStg, BOOL fSameAsLoad);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.OleLoadFromStream"]/*' />
    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT OleLoadFromStream([NativeTypeName("LPSTREAM")] IStream* pStm, [NativeTypeName("const IID &")] Guid* iidInterface, [NativeTypeName("LPVOID *")] void** ppvObj);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.OleSaveToStream"]/*' />
    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT OleSaveToStream([NativeTypeName("LPPERSISTSTREAM")] IPersistStream* pPStm, [NativeTypeName("LPSTREAM")] IStream* pStm);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.OleSetContainedObject"]/*' />
    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT OleSetContainedObject([NativeTypeName("LPUNKNOWN")] IUnknown* pUnknown, BOOL fContained);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.OleNoteObjectVisible"]/*' />
    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT OleNoteObjectVisible([NativeTypeName("LPUNKNOWN")] IUnknown* pUnknown, BOOL fVisible);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RegisterDragDrop"]/*' />
    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT RegisterDragDrop(HWND hwnd, [NativeTypeName("LPDROPTARGET")] IDropTarget* pDropTarget);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RevokeDragDrop"]/*' />
    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT RevokeDragDrop(HWND hwnd);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DoDragDrop"]/*' />
    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT DoDragDrop([NativeTypeName("LPDATAOBJECT")] IDataObject* pDataObj, [NativeTypeName("LPDROPSOURCE")] IDropSource* pDropSource, [NativeTypeName("DWORD")] uint dwOKEffects, [NativeTypeName("LPDWORD")] uint* pdwEffect);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.OleSetClipboard"]/*' />
    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT OleSetClipboard([NativeTypeName("LPDATAOBJECT")] IDataObject* pDataObj);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.OleGetClipboard"]/*' />
    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT OleGetClipboard([NativeTypeName("LPDATAOBJECT *")] IDataObject** ppDataObj);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.OleGetClipboardWithEnterpriseInfo"]/*' />
    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT OleGetClipboardWithEnterpriseInfo(IDataObject** dataObject, [NativeTypeName("PWSTR *")] char** dataEnterpriseId, [NativeTypeName("PWSTR *")] char** sourceDescription, [NativeTypeName("PWSTR *")] char** targetDescription, [NativeTypeName("PWSTR *")] char** dataDescription);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.OleFlushClipboard"]/*' />
    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT OleFlushClipboard();

    /// <include file='Windows.xml' path='doc/member[@name="Windows.OleIsCurrentClipboard"]/*' />
    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT OleIsCurrentClipboard([NativeTypeName("LPDATAOBJECT")] IDataObject* pDataObj);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.OleCreateMenuDescriptor"]/*' />
    [DllImport("ole32", ExactSpelling = true)]
    [return: NativeTypeName("HOLEMENU")]
    public static extern HGLOBAL OleCreateMenuDescriptor(HMENU hmenuCombined, [NativeTypeName("LPOLEMENUGROUPWIDTHS")] OLEMENUGROUPWIDTHS* lpMenuWidths);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.OleSetMenuDescriptor"]/*' />
    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT OleSetMenuDescriptor([NativeTypeName("HOLEMENU")] HGLOBAL holemenu, HWND hwndFrame, HWND hwndActiveObject, [NativeTypeName("LPOLEINPLACEFRAME")] IOleInPlaceFrame* lpFrame, [NativeTypeName("LPOLEINPLACEACTIVEOBJECT")] IOleInPlaceActiveObject* lpActiveObj);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.OleDestroyMenuDescriptor"]/*' />
    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT OleDestroyMenuDescriptor([NativeTypeName("HOLEMENU")] HGLOBAL holemenu);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.OleTranslateAccelerator"]/*' />
    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT OleTranslateAccelerator([NativeTypeName("LPOLEINPLACEFRAME")] IOleInPlaceFrame* lpFrame, [NativeTypeName("LPOLEINPLACEFRAMEINFO")] OLEINPLACEFRAMEINFO* lpFrameInfo, [NativeTypeName("LPMSG")] MSG* lpmsg);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.OleDuplicateData"]/*' />
    [DllImport("ole32", ExactSpelling = true)]
    public static extern HANDLE OleDuplicateData(HANDLE hSrc, [NativeTypeName("CLIPFORMAT")] ushort cfFormat, uint uiFlags);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.OleDraw"]/*' />
    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT OleDraw([NativeTypeName("LPUNKNOWN")] IUnknown* pUnknown, [NativeTypeName("DWORD")] uint dwAspect, HDC hdcDraw, [NativeTypeName("LPCRECT")] RECT* lprcBounds);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.OleRun"]/*' />
    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT OleRun([NativeTypeName("LPUNKNOWN")] IUnknown* pUnknown);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.OleIsRunning"]/*' />
    [DllImport("ole32", ExactSpelling = true)]
    public static extern BOOL OleIsRunning([NativeTypeName("LPOLEOBJECT")] IOleObject* pObject);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.OleLockRunning"]/*' />
    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT OleLockRunning([NativeTypeName("LPUNKNOWN")] IUnknown* pUnknown, BOOL fLock, BOOL fLastUnlockCloses);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ReleaseStgMedium"]/*' />
    [DllImport("ole32", ExactSpelling = true)]
    public static extern void ReleaseStgMedium([NativeTypeName("LPSTGMEDIUM")] STGMEDIUM* param0);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CreateOleAdviseHolder"]/*' />
    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT CreateOleAdviseHolder([NativeTypeName("LPOLEADVISEHOLDER *")] IOleAdviseHolder** ppOAHolder);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.OleCreateDefaultHandler"]/*' />
    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT OleCreateDefaultHandler([NativeTypeName("const IID &")] Guid* clsid, [NativeTypeName("LPUNKNOWN")] IUnknown* pUnkOuter, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPVOID *")] void** lplpObj);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.OleCreateEmbeddingHelper"]/*' />
    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT OleCreateEmbeddingHelper([NativeTypeName("const IID &")] Guid* clsid, [NativeTypeName("LPUNKNOWN")] IUnknown* pUnkOuter, [NativeTypeName("DWORD")] uint flags, [NativeTypeName("LPCLASSFACTORY")] IClassFactory* pCF, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPVOID *")] void** lplpObj);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.IsAccelerator"]/*' />
    [DllImport("ole32", ExactSpelling = true)]
    public static extern BOOL IsAccelerator(HACCEL hAccel, int cAccelEntries, [NativeTypeName("LPMSG")] MSG* lpMsg, [NativeTypeName("WORD *")] ushort* lpwCmd);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.OleGetIconOfFile"]/*' />
    [DllImport("ole32", ExactSpelling = true)]
    public static extern HGLOBAL OleGetIconOfFile([NativeTypeName("LPOLESTR")] char* lpszPath, BOOL fUseFileAsLabel);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.OleGetIconOfClass"]/*' />
    [DllImport("ole32", ExactSpelling = true)]
    public static extern HGLOBAL OleGetIconOfClass([NativeTypeName("const IID &")] Guid* rclsid, [NativeTypeName("LPOLESTR")] char* lpszLabel, BOOL fUseTypeAsLabel);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.OleMetafilePictFromIconAndLabel"]/*' />
    [DllImport("ole32", ExactSpelling = true)]
    public static extern HGLOBAL OleMetafilePictFromIconAndLabel(HICON hIcon, [NativeTypeName("LPOLESTR")] char* lpszLabel, [NativeTypeName("LPOLESTR")] char* lpszSourceFile, uint iIconIndex);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.OleRegGetUserType"]/*' />
    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT OleRegGetUserType([NativeTypeName("const IID &")] Guid* clsid, [NativeTypeName("DWORD")] uint dwFormOfType, [NativeTypeName("LPOLESTR *")] char** pszUserType);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.OleRegGetMiscStatus"]/*' />
    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT OleRegGetMiscStatus([NativeTypeName("const IID &")] Guid* clsid, [NativeTypeName("DWORD")] uint dwAspect, [NativeTypeName("DWORD *")] uint* pdwStatus);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.OleRegEnumFormatEtc"]/*' />
    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT OleRegEnumFormatEtc([NativeTypeName("const IID &")] Guid* clsid, [NativeTypeName("DWORD")] uint dwDirection, [NativeTypeName("LPENUMFORMATETC *")] IEnumFORMATETC** ppenum);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.OleRegEnumVerbs"]/*' />
    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT OleRegEnumVerbs([NativeTypeName("const IID &")] Guid* clsid, [NativeTypeName("LPENUMOLEVERB *")] IEnumOLEVERB** ppenum);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.OleConvertOLESTREAMToIStorage"]/*' />
    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT OleConvertOLESTREAMToIStorage([NativeTypeName("LPOLESTREAM")] OLESTREAM* lpolestream, [NativeTypeName("LPSTORAGE")] IStorage* pstg, [NativeTypeName("const DVTARGETDEVICE *")] DVTARGETDEVICE* ptd);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.OleConvertOLESTREAMToIStorage2"]/*' />
    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT OleConvertOLESTREAMToIStorage2([NativeTypeName("LPOLESTREAM")] OLESTREAM* lpolestream, [NativeTypeName("LPSTORAGE")] IStorage* pstg, [NativeTypeName("const DVTARGETDEVICE *")] DVTARGETDEVICE* ptd, [NativeTypeName("DWORD")] uint opt, [NativeTypeName("PVOID")] void* pvCallbackContext, [NativeTypeName("OLESTREAMQUERYCONVERTOLELINKCALLBACK")] delegate* unmanaged<Guid*, char*, char*, char*, char*, uint, void*, HRESULT> pQueryConvertOLELinkCallback);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.OleConvertIStorageToOLESTREAM"]/*' />
    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT OleConvertIStorageToOLESTREAM([NativeTypeName("LPSTORAGE")] IStorage* pstg, [NativeTypeName("LPOLESTREAM")] OLESTREAM* lpolestream);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.OleDoAutoConvert"]/*' />
    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT OleDoAutoConvert([NativeTypeName("LPSTORAGE")] IStorage* pStg, [NativeTypeName("LPCLSID")] Guid* pClsidNew);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.OleGetAutoConvert"]/*' />
    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT OleGetAutoConvert([NativeTypeName("const IID &")] Guid* clsidOld, [NativeTypeName("LPCLSID")] Guid* pClsidNew);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.OleSetAutoConvert"]/*' />
    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT OleSetAutoConvert([NativeTypeName("const IID &")] Guid* clsidOld, [NativeTypeName("const IID &")] Guid* clsidNew);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetConvertStg"]/*' />
    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT SetConvertStg([NativeTypeName("LPSTORAGE")] IStorage* pStg, BOOL fConvert);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.OleConvertIStorageToOLESTREAMEx"]/*' />
    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT OleConvertIStorageToOLESTREAMEx([NativeTypeName("LPSTORAGE")] IStorage* pstg, [NativeTypeName("CLIPFORMAT")] ushort cfFormat, [NativeTypeName("LONG")] int lWidth, [NativeTypeName("LONG")] int lHeight, [NativeTypeName("DWORD")] uint dwSize, [NativeTypeName("LPSTGMEDIUM")] STGMEDIUM* pmedium, [NativeTypeName("LPOLESTREAM")] OLESTREAM* polestm);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.OleConvertOLESTREAMToIStorageEx"]/*' />
    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT OleConvertOLESTREAMToIStorageEx([NativeTypeName("LPOLESTREAM")] OLESTREAM* polestm, [NativeTypeName("LPSTORAGE")] IStorage* pstg, [NativeTypeName("CLIPFORMAT *")] ushort* pcfFormat, [NativeTypeName("LONG *")] int* plwWidth, [NativeTypeName("LONG *")] int* plHeight, [NativeTypeName("DWORD *")] uint* pdwSize, [NativeTypeName("LPSTGMEDIUM")] STGMEDIUM* pmedium);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.OleConvertOLESTREAMToIStorageEx2"]/*' />
    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT OleConvertOLESTREAMToIStorageEx2([NativeTypeName("LPOLESTREAM")] OLESTREAM* polestm, [NativeTypeName("LPSTORAGE")] IStorage* pstg, [NativeTypeName("CLIPFORMAT *")] ushort* pcfFormat, [NativeTypeName("LONG *")] int* plwWidth, [NativeTypeName("LONG *")] int* plHeight, [NativeTypeName("DWORD *")] uint* pdwSize, [NativeTypeName("LPSTGMEDIUM")] STGMEDIUM* pmedium, [NativeTypeName("DWORD")] uint opt, [NativeTypeName("PVOID")] void* pvCallbackContext, [NativeTypeName("OLESTREAMQUERYCONVERTOLELINKCALLBACK")] delegate* unmanaged<Guid*, char*, char*, char*, char*, uint, void*, HRESULT> pQueryConvertOLELinkCallback);

    [NativeTypeName("#define DATA_E_FORMATETC DV_E_FORMATETC")]
    public const int DATA_E_FORMATETC = unchecked((int)(0x80040064));

    [NativeTypeName("#define OLEIVERB_PRIMARY (0L)")]
    public const int OLEIVERB_PRIMARY = (0);

    [NativeTypeName("#define OLEIVERB_SHOW (-1L)")]
    public const int OLEIVERB_SHOW = (-1);

    [NativeTypeName("#define OLEIVERB_OPEN (-2L)")]
    public const int OLEIVERB_OPEN = (-2);

    [NativeTypeName("#define OLEIVERB_HIDE (-3L)")]
    public const int OLEIVERB_HIDE = (-3);

    [NativeTypeName("#define OLEIVERB_UIACTIVATE (-4L)")]
    public const int OLEIVERB_UIACTIVATE = (-4);

    [NativeTypeName("#define OLEIVERB_INPLACEACTIVATE (-5L)")]
    public const int OLEIVERB_INPLACEACTIVATE = (-5);

    [NativeTypeName("#define OLEIVERB_DISCARDUNDOSTATE (-6L)")]
    public const int OLEIVERB_DISCARDUNDOSTATE = (-6);

    [NativeTypeName("#define EMBDHLP_INPROC_HANDLER 0x0000L")]
    public const int EMBDHLP_INPROC_HANDLER = 0x0000;

    [NativeTypeName("#define EMBDHLP_INPROC_SERVER 0x0001L")]
    public const int EMBDHLP_INPROC_SERVER = 0x0001;

    [NativeTypeName("#define EMBDHLP_CREATENOW 0x00000000L")]
    public const int EMBDHLP_CREATENOW = 0x00000000;

    [NativeTypeName("#define EMBDHLP_DELAYCREATE 0x00010000L")]
    public const int EMBDHLP_DELAYCREATE = 0x00010000;

    [NativeTypeName("#define OLECREATE_LEAVERUNNING 0x00000001")]
    public const int OLECREATE_LEAVERUNNING = 0x00000001;

    [NativeTypeName("#define OLESTREAM_CONVERSION_DEFAULT 0x00000000L")]
    public const int OLESTREAM_CONVERSION_DEFAULT = 0x00000000;

    [NativeTypeName("#define OLESTREAM_CONVERSION_DISABLEOLELINK 0x00000001L")]
    public const int OLESTREAM_CONVERSION_DISABLEOLELINK = 0x00000001;
}
