// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from Win32Application.h in https://github.com/Microsoft/DirectX-Graphics-Samples
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the MIT License (MIT).

using System;
using System.Drawing;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop;
using static TerraFX.Interop.DXGI_FORMAT;
using static TerraFX.Interop.Windows;
using Size = System.Drawing.Size;

namespace TerraFX.Samples.DirectX
{
    public static unsafe class Win32Application
    {
        private static HWND s_hwnd;

        public static HWND Hwnd => s_hwnd;

        public static int Run(DXSample sample, HINSTANCE hInstance, int nCmdShow)
        {
            var useWarpDevice = false;

            // Parse the command line parameters
            foreach (var arg in Environment.GetCommandLineArgs())
            {
                if (Program.Matches(arg, "warp"))
                {
                    useWarpDevice = true;
                    continue;
                }
            }

            fixed (char* lpszClassName = "DXSampleClass")
            fixed (char* lpWindowName = sample.Name)
            {
                // Initialize the window class.
                var windowClass = new WNDCLASSEXW {
                    cbSize = (uint)sizeof(WNDCLASSEXW),
                    style = CS_HREDRAW | CS_VREDRAW,
                    lpfnWndProc = &WindowProc,
                    hInstance = hInstance,
                    hCursor = LoadCursorW(IntPtr.Zero, (ushort*)IDC_ARROW),
                    lpszClassName = (ushort*)lpszClassName
                };
                _ = RegisterClassExW(&windowClass);

                // Create the window and store a handle to it.
                s_hwnd = CreateWindowExW(
                    0,
                    windowClass.lpszClassName,
                    (ushort*)lpWindowName,
                    WS_OVERLAPPEDWINDOW,
                    CW_USEDEFAULT,
                    CW_USEDEFAULT,
                    CW_USEDEFAULT,
                    CW_USEDEFAULT,
                    HWND.NULL,                              // We have no parent window.
                    HMENU.NULL,                             // We aren't using menus.
                    hInstance,
                    ((IntPtr)GCHandle.Alloc(sample)).ToPointer()
                );
            }

            RECT windowRect;
            _ = GetClientRect(s_hwnd, &windowRect);

            // Initialize the sample. OnInit is defined in each child-implementation of DXSample.
            var backgroundColor = new Vector4(0.0f, 0.2f, 0.4f, 1.0f);

            var size = new Size((windowRect.right - windowRect.left), (windowRect.bottom - windowRect.top));
            sample.OnInit(DXGI_FORMAT_UNKNOWN, backgroundColor, DXGI_FORMAT_UNKNOWN, 1.0f, 2, s_hwnd, true, size, useWarpDevice);

            _ = ShowWindow(s_hwnd, nCmdShow);

            // Main sample loop.
            MSG msg;
            DispatchPending(&msg);

            var lastFramesPerSecond = 0u;

            while (msg.message != WM_QUIT)
            {
                var delta = sample.OnBeginFrame();
                sample.OnUpdate(delta);

                var framesPerSecond = sample.FramesPerSecond;

                if (framesPerSecond != lastFramesPerSecond)
                {
                    fixed (char* lpWindowName = $"{sample.Name} ({framesPerSecond} fps)")
                    {
                        _ = SetWindowTextW(s_hwnd, (ushort*)lpWindowName);
                    }
                    lastFramesPerSecond = framesPerSecond;
                }

                if (sample.IsWindowVisible)
                {
                    sample.OnRender();
                }

                DispatchPending(&msg);
            }

            sample.OnDestroy();

            // Return this part of the WM_QUIT message to Windows.
            return (int)msg.wParam;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            static void DispatchPending(MSG* lpMsg)
            {
                // Process any messages in the queue.

                while (PeekMessageW(lpMsg, hWnd: IntPtr.Zero, wMsgFilterMin: WM_NULL, wMsgFilterMax: WM_NULL, PM_REMOVE) != FALSE)
                {
                    _ = TranslateMessage(lpMsg);
                    _ = DispatchMessageW(lpMsg);
                }
            }
        }

        // Main message handler for the sample
        [UnmanagedCallersOnly]
        private static nint WindowProc(IntPtr hWnd, uint message, nuint wParam, nint lParam)
        {
            var handle = GetWindowLongPtrW(hWnd, GWLP_USERDATA);
            var pSample = (handle != IntPtr.Zero) ? (DXSample?)GCHandle.FromIntPtr(handle).Target : null;

            switch (message)
            {
                case WM_CREATE:
                {
                    // Save the DXSample* passed in to CreateWindow.
                    var pCreateStruct = (CREATESTRUCTW*)lParam;
                    _ = SetWindowLongPtrW(hWnd, GWLP_USERDATA, (IntPtr)pCreateStruct->lpCreateParams);
                    return IntPtr.Zero;
                }

                case WM_DESTROY:
                {
                    PostQuitMessage(0);
                    return IntPtr.Zero;
                }

                case WM_SIZE:
                {
                    if (pSample != null)
                    {
                        var size = new Size(LOWORD(lParam), HIWORD(lParam));
                        pSample.OnWindowSizeChanged(size);
                    }
                    return IntPtr.Zero;
                }

                case WM_KEYDOWN:
                {
                    pSample?.OnKeyDown((byte)wParam);
                    return IntPtr.Zero;
                }

                case WM_KEYUP:
                {
                    pSample?.OnKeyUp((byte)wParam);
                    return IntPtr.Zero;
                }

                default:
                {
                    return DefWindowProcW(hWnd, message, wParam, lParam);
                }
            }
        }
    }
}
