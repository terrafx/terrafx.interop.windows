// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dwmapi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Windows
    {
        [NativeTypeName("const UINT")]
        public const uint c_DwmMaxQueuedBuffers = 8;

        [NativeTypeName("const UINT")]
        public const uint c_DwmMaxMonitors = 16;

        [NativeTypeName("const UINT")]
        public const uint c_DwmMaxAdapters = 16;

        [DllImport("dwmapi", ExactSpelling = true)]
        public static extern BOOL DwmDefWindowProc(HWND hWnd, [NativeTypeName("UINT")] uint msg, [NativeTypeName("WPARAM")] nuint wParam, [NativeTypeName("LPARAM")] nint lParam, [NativeTypeName("LRESULT *")] nint* plResult);

        [DllImport("dwmapi", ExactSpelling = true)]
        public static extern HRESULT DwmEnableBlurBehindWindow(HWND hWnd, [NativeTypeName("const DWM_BLURBEHIND *")] DWM_BLURBEHIND* pBlurBehind);

        [DllImport("dwmapi", ExactSpelling = true)]
        public static extern HRESULT DwmEnableComposition([NativeTypeName("UINT")] uint uCompositionAction);

        [DllImport("dwmapi", ExactSpelling = true)]
        public static extern HRESULT DwmEnableMMCSS(BOOL fEnableMMCSS);

        [DllImport("dwmapi", ExactSpelling = true)]
        public static extern HRESULT DwmExtendFrameIntoClientArea(HWND hWnd, [NativeTypeName("const MARGINS *")] MARGINS* pMarInset);

        [DllImport("dwmapi", ExactSpelling = true)]
        public static extern HRESULT DwmGetColorizationColor([NativeTypeName("DWORD *")] uint* pcrColorization, BOOL* pfOpaqueBlend);

        [DllImport("dwmapi", ExactSpelling = true)]
        public static extern HRESULT DwmGetCompositionTimingInfo(HWND hwnd, DWM_TIMING_INFO* pTimingInfo);

        [DllImport("dwmapi", ExactSpelling = true)]
        public static extern HRESULT DwmGetWindowAttribute(HWND hwnd, [NativeTypeName("DWORD")] uint dwAttribute, [NativeTypeName("PVOID")] void* pvAttribute, [NativeTypeName("DWORD")] uint cbAttribute);

        [DllImport("dwmapi", ExactSpelling = true)]
        public static extern HRESULT DwmIsCompositionEnabled(BOOL* pfEnabled);

        [DllImport("dwmapi", ExactSpelling = true)]
        public static extern HRESULT DwmModifyPreviousDxFrameDuration(HWND hwnd, [NativeTypeName("INT")] int cRefreshes, BOOL fRelative);

        [DllImport("dwmapi", ExactSpelling = true)]
        public static extern HRESULT DwmQueryThumbnailSourceSize([NativeTypeName("HTHUMBNAIL")] HANDLE hThumbnail, [NativeTypeName("PSIZE")] SIZE* pSize);

        [DllImport("dwmapi", ExactSpelling = true)]
        public static extern HRESULT DwmRegisterThumbnail(HWND hwndDestination, HWND hwndSource, [NativeTypeName("PHTHUMBNAIL")] HANDLE* phThumbnailId);

        [DllImport("dwmapi", ExactSpelling = true)]
        public static extern HRESULT DwmSetDxFrameDuration(HWND hwnd, [NativeTypeName("INT")] int cRefreshes);

        [DllImport("dwmapi", ExactSpelling = true)]
        public static extern HRESULT DwmSetPresentParameters(HWND hwnd, DWM_PRESENT_PARAMETERS* pPresentParams);

        [DllImport("dwmapi", ExactSpelling = true)]
        public static extern HRESULT DwmSetWindowAttribute(HWND hwnd, [NativeTypeName("DWORD")] uint dwAttribute, [NativeTypeName("LPCVOID")] void* pvAttribute, [NativeTypeName("DWORD")] uint cbAttribute);

        [DllImport("dwmapi", ExactSpelling = true)]
        public static extern HRESULT DwmUnregisterThumbnail([NativeTypeName("HTHUMBNAIL")] HANDLE hThumbnailId);

        [DllImport("dwmapi", ExactSpelling = true)]
        public static extern HRESULT DwmUpdateThumbnailProperties([NativeTypeName("HTHUMBNAIL")] HANDLE hThumbnailId, [NativeTypeName("const DWM_THUMBNAIL_PROPERTIES *")] DWM_THUMBNAIL_PROPERTIES* ptnProperties);

        [DllImport("dwmapi", ExactSpelling = true)]
        public static extern HRESULT DwmSetIconicThumbnail(HWND hwnd, HBITMAP hbmp, [NativeTypeName("DWORD")] uint dwSITFlags);

        [DllImport("dwmapi", ExactSpelling = true)]
        public static extern HRESULT DwmSetIconicLivePreviewBitmap(HWND hwnd, HBITMAP hbmp, POINT* pptClient, [NativeTypeName("DWORD")] uint dwSITFlags);

        [DllImport("dwmapi", ExactSpelling = true)]
        public static extern HRESULT DwmInvalidateIconicBitmaps(HWND hwnd);

        [DllImport("dwmapi", ExactSpelling = true)]
        public static extern HRESULT DwmAttachMilContent(HWND hwnd);

        [DllImport("dwmapi", ExactSpelling = true)]
        public static extern HRESULT DwmDetachMilContent(HWND hwnd);

        [DllImport("dwmapi", ExactSpelling = true)]
        public static extern HRESULT DwmFlush();

        [DllImport("dwmapi", ExactSpelling = true)]
        public static extern HRESULT DwmGetGraphicsStreamTransformHint([NativeTypeName("UINT")] uint uIndex, MilMatrix3x2D* pTransform);

        [DllImport("dwmapi", ExactSpelling = true)]
        public static extern HRESULT DwmGetGraphicsStreamClient([NativeTypeName("UINT")] uint uIndex, [NativeTypeName("UUID *")] Guid* pClientUuid);

        [DllImport("dwmapi", ExactSpelling = true)]
        public static extern HRESULT DwmGetTransportAttributes(BOOL* pfIsRemoting, BOOL* pfIsConnected, [NativeTypeName("DWORD *")] uint* pDwGeneration);

        [DllImport("dwmapi", ExactSpelling = true)]
        public static extern HRESULT DwmTransitionOwnedWindow(HWND hwnd, [NativeTypeName("enum DWMTRANSITION_OWNEDWINDOW_TARGET")] DWMTRANSITION_OWNEDWINDOW_TARGET target);

        [DllImport("dwmapi", ExactSpelling = true)]
        public static extern HRESULT DwmRenderGesture([NativeTypeName("enum GESTURE_TYPE")] GESTURE_TYPE gt, [NativeTypeName("UINT")] uint cContacts, [NativeTypeName("const DWORD *")] uint* pdwPointerID, [NativeTypeName("const POINT *")] POINT* pPoints);

        [DllImport("dwmapi", ExactSpelling = true)]
        public static extern HRESULT DwmTetherContact([NativeTypeName("DWORD")] uint dwPointerID, BOOL fEnable, POINT ptTether);

        [DllImport("dwmapi", ExactSpelling = true)]
        public static extern HRESULT DwmShowContact([NativeTypeName("DWORD")] uint dwPointerID, [NativeTypeName("enum DWM_SHOWCONTACT")] DWM_SHOWCONTACT eShowContact);

        [DllImport("dwmapi", ExactSpelling = true)]
        public static extern HRESULT DwmGetUnmetTabRequirements(HWND appWindow, [NativeTypeName("enum DWM_TAB_WINDOW_REQUIREMENTS *")] DWM_TAB_WINDOW_REQUIREMENTS* value);

        [NativeTypeName("#define DWM_BB_ENABLE 0x00000001")]
        public const int DWM_BB_ENABLE = 0x00000001;

        [NativeTypeName("#define DWM_BB_BLURREGION 0x00000002")]
        public const int DWM_BB_BLURREGION = 0x00000002;

        [NativeTypeName("#define DWM_BB_TRANSITIONONMAXIMIZED 0x00000004")]
        public const int DWM_BB_TRANSITIONONMAXIMIZED = 0x00000004;

        [NativeTypeName("#define DWM_CLOAKED_APP 0x00000001")]
        public const int DWM_CLOAKED_APP = 0x00000001;

        [NativeTypeName("#define DWM_CLOAKED_SHELL 0x00000002")]
        public const int DWM_CLOAKED_SHELL = 0x00000002;

        [NativeTypeName("#define DWM_CLOAKED_INHERITED 0x00000004")]
        public const int DWM_CLOAKED_INHERITED = 0x00000004;

        [NativeTypeName("#define DWM_TNP_RECTDESTINATION 0x00000001")]
        public const int DWM_TNP_RECTDESTINATION = 0x00000001;

        [NativeTypeName("#define DWM_TNP_RECTSOURCE 0x00000002")]
        public const int DWM_TNP_RECTSOURCE = 0x00000002;

        [NativeTypeName("#define DWM_TNP_OPACITY 0x00000004")]
        public const int DWM_TNP_OPACITY = 0x00000004;

        [NativeTypeName("#define DWM_TNP_VISIBLE 0x00000008")]
        public const int DWM_TNP_VISIBLE = 0x00000008;

        [NativeTypeName("#define DWM_TNP_SOURCECLIENTAREAONLY 0x00000010")]
        public const int DWM_TNP_SOURCECLIENTAREAONLY = 0x00000010;

        [NativeTypeName("#define DWM_FRAME_DURATION_DEFAULT -1")]
        public const int DWM_FRAME_DURATION_DEFAULT = -1;

        [NativeTypeName("#define DWM_EC_DISABLECOMPOSITION 0")]
        public const int DWM_EC_DISABLECOMPOSITION = 0;

        [NativeTypeName("#define DWM_EC_ENABLECOMPOSITION 1")]
        public const int DWM_EC_ENABLECOMPOSITION = 1;

        [NativeTypeName("#define DWM_SIT_DISPLAYFRAME 0x00000001")]
        public const int DWM_SIT_DISPLAYFRAME = 0x00000001;
    }
}
