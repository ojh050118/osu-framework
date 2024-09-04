// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using System;
using System.Collections.Generic;
using System.Linq;
using osu.Framework.Logging;
using osu.Framework.Platform;
using osu.Framework.Platform.SDL2;
using osu.Framework.Platform.Windows.WinAPI;

namespace osu.Framework.Utils
{
    public static class WindowHelper
    {
        public static IntPtr SetParentToDesktop(IntPtr windowHandle, WindowParent parent, int x, int y, int width, int height)
        {
            IntPtr progman = User32.FindWindow("progman", null);
            IntPtr result = IntPtr.Zero;
            IntPtr workerw = IntPtr.Zero;
            IntPtr listView = IntPtr.Zero;

            User32.SendMessageTimeout(progman, 0x052C, new IntPtr(0), IntPtr.Zero, 0x0, 1000, out result);
            User32.EnumWindows(new User32.EnumWindowsProc((topHandle, topParamHandle) =>
            {
                IntPtr p = User32.FindWindowEx(topHandle, IntPtr.Zero, "SHELLDLL_DefView", null);

                if (p != IntPtr.Zero)
                {
                    workerw = User32.FindWindowEx(IntPtr.Zero, topHandle, "WorkerW", null);
                    listView = User32.FindWindowEx(p, IntPtr.Zero, "SysListView32", null);
                }

                return true;
            }), IntPtr.Zero);

            switch (parent)
            {
                case WindowParent.Desktop:
                    User32.SetParent(windowHandle, User32.GetDesktopWindow());
                    break;

                case WindowParent.SysListView32:
                    User32.SetParent(windowHandle, listView);
                    break;

                case WindowParent.WorkerW:
                    User32.SetParent(windowHandle, workerw);
                    break;
            }

            uint style = User32.GetWindowLong(windowHandle, User32.GWL_STYLE);
            style &= ~(User32.WS_CAPTION | User32.WS_THICKFRAME | User32.WS_BORDER);

            User32.SetWindowLong(windowHandle, User32.GWL_STYLE, style);
            User32.SetWindowPos(windowHandle, IntPtr.Zero, x, y, width, height, 0x0040 | 0x0004 | 0x0001 | 0x0010 | 0x0020);

            Logger.Log($"Changed window parent to {parent}! progman: {progman} | workerw: {workerw}");

            switch (parent)
            {
                case WindowParent.Desktop:
                    return User32.GetDesktopWindow();

                case WindowParent.SysListView32:
                    return listView;

                default:
                    return workerw;
            }
        }

        public static IntPtr SetParentToDesktop(ISDLWindow window, WindowParent parent, IEnumerable<Display> displays)
        {
            IntPtr windowHandle = ((SDL2Window)window).WindowHandle;
            var nearestDisplay = displays.OrderBy(d => Math.Sqrt(Math.Pow(window.Position.X - d.Bounds.X, 2) + Math.Pow(window.Position.Y - d.Bounds.Y, 2))).First();
            var left = Math.Abs(displays.OrderBy(d => d.Bounds.X).First().Bounds.X);
            var top = Math.Abs(displays.OrderBy(d => d.Bounds.Y).First().Bounds.Y);

            return SetParentToDesktop(windowHandle, parent, nearestDisplay.Bounds.X + left, nearestDisplay.Bounds.Y + top, nearestDisplay.Bounds.Width, nearestDisplay.Bounds.Height);
        }
    }

    public enum WindowParent
    {
        Desktop,
        SysListView32,
        WorkerW
    }
}
