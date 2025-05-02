using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgGame2025
{
    public static class DebugTools
    {
        private static readonly bool _debugOn = true;

        public static void Debug(string source="", string message = "")
        {
            if (!_debugOn) return;

            System.Diagnostics.Debug.WriteLine($"DEBUG: {source}: {message}");
        }
    }
}
